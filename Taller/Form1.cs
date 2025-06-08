using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Octave.NET;

namespace Taller
{
    public partial class Form1 : Form
    {
        double[] functionX1;
        double[] functionX2;
        double[] functionT;

        int startPositionM1, startPositionM2;
        int startWidthK1, startWidthB1, startWidthK2, startWidthB2, startWidthK3;
        int startLocationK3X;

        int j = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            OctaveContext.OctaveSettings.OctaveCliPath = @"C:\\Program Files\\GNU Octave\\Octave-10.1.0\\mingw64\\bin\\octave-cli.exe";

            // Guardar posiciones iniciales
            startPositionM1 = picM.Location.X;
            startPositionM2 = picM2.Location.X;
            startWidthK1 = picK.Width;
            startWidthB1 = picB.Width;
            startWidthK2 = picK2.Width;
            startWidthB2 = picB2.Width;
            startWidthK3 = picK3.Width;
            startLocationK3X = picK3.Location.X;

            // Configurar gráfico
            chartG.Series.Clear();
            chartG.Series.Add("Masa 1");
            chartG.Series.Add("Masa 2");
            chartG.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartG.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartG.Series[0].Color = Color.Blue;
            chartG.Series[1].Color = Color.Red;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            j = 0;
            ResetPositions();

            var octave = new OctaveContext();
            string instructions = "clc;" +
                "clear;" +
                "pkg load control;" +
                "pkg load signal;" +
                "s=tf('s');" +
                "m1=" + txtM.Text + ";" +
                "b1=" + txtB.Text + ";" +
                "k1=" + txtK.Text + ";" +
                "m2=" + txtM2.Text + ";" +
                "b2=" + txtB2.Text + ";" +
                "k2=" + txtK2.Text + ";" +
                "k3=" + txtK3.Text + ";" +
                // Sistema de ecuaciones para dos masas acopladas
                "den1 = m1 * s ^ 2 + k3 * s + k1 + b1;" +
                "den2 = m2 * s ^ 2 + k3 * s + k2 + b2;" +
                "num = k3 * s;" +
                "G2 = num / (den1 * den2 - num ^ 2);" +
                "G1 = (G2 * den2) / num;" +
                "[x1, t] = step(G1);" +
                "[x2, t] = step(G2);" +
                "c = length(t);" +
                "tiempo = t(c);" +
                "[x1, t] = step(G1, tiempo, tiempo/" + txtElements.Text + ");" +
                "[x2, t] = step(G2, tiempo, tiempo/" + txtElements.Text + ");";

            octave.Execute(instructions);

            Array.Resize(ref functionX1, Convert.ToInt16(txtElements.Text));
            Array.Resize(ref functionX2, Convert.ToInt16(txtElements.Text));
            Array.Resize(ref functionT, Convert.ToInt16(txtElements.Text));

            functionT = octave.Execute("t").AsVector();
            functionX1 = octave.Execute("x1").AsVector();
            functionX2 = octave.Execute("x2").AsVector();

            lblTransferFunction.Text = "G1(s) = (G2*(m2*s^2 + k3*s + k2 + b2))/(k3*s)\n" +
                                       "G2(s) = (k3*s)/((m2*s^2 + k3*s + k2 + b2)*(m1*s^2 + k3*s + k1 + b1) - (k3*s)^2)\n" +
                                       "maxX1 = " + functionX1.Max().ToString("F3") + "\n" +
                                       "maxX2 = " + functionX2.Max().ToString("F3") + "\n" +
                                       "maxT = " + functionT.Max().ToString("F3");

            chartG.Series[0].Points.Clear();
            chartG.Series[1].Points.Clear();
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void ResetPositions()
        {
            picM.Location = new Point(startPositionM1, picM.Location.Y);
            picM2.Location = new Point(startPositionM2, picM2.Location.Y);
            picK.Width = startWidthK1;
            picB.Width = startWidthB1;
            picK2.Width = startWidthK2;
            picB2.Width = startWidthB2;
            picK3.Width = startWidthK3;
            picK3.Location = new Point(startLocationK3X, picK3.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j >= functionT.Length)
            {
                timer1.Enabled = false;
                return;
            }

            int escala = 200;

            // Posiciones actuales
            int newPosM1 = startPositionM1 + (int)(functionX1[j] * escala);
            int newPosM2 = startPositionM2 + (int)(functionX2[j] * escala);

            // Mover masa 1 y ajustar K1, B1 (conectados a pared izquierda)
            picM.Location = new Point(newPosM1, picM.Location.Y);
            picK.Width = startWidthK1 + (int)(functionX1[j] * escala);
            picB.Width = startWidthB1 + (int)(functionX1[j] * escala);

            // Mover masa 2 
            picM2.Location = new Point(newPosM2, picM2.Location.Y);

            // Ajustar K2, B2 (conectados a pared derecha - pictureBox4)
            // La pared está fija, entonces K2 y B2 se comprimen/extienden desde su posición original
            int wallPosition = pictureBox4.Location.X; // Posición de la pared derecha
            int m2Right = picM2.Location.X + picM2.Width; // Lado derecho de masa 2
            int distanceToWall = wallPosition - m2Right; // Distancia entre masa 2 y pared

            // K2 y B2 se ajustan según la distancia a la pared
            picK2.Location = new Point(m2Right, picK2.Location.Y);
            picK2.Width = Math.Max(10, distanceToWall);

            picB2.Location = new Point(m2Right, picB2.Location.Y);
            picB2.Width = Math.Max(10, distanceToWall);

            // Ajustar K3 (conecta masa 1 con masa 2)
            int m1Right = picM.Location.X + picM.Width;
            int m2Left = picM2.Location.X;
            int distanceK3 = m2Left - m1Right;

            picK3.Location = new Point(m1Right, picK3.Location.Y);
            picK3.Width = Math.Max(10, distanceK3);

            // Actualizar gráfico
            chartG.Series[0].Points.AddXY(functionT[j], functionX1[j]);
            chartG.Series[1].Points.AddXY(functionT[j], functionX2[j]);

            j++;
        }
    }
}