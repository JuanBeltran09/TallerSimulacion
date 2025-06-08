namespace Taller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTransferFunction = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtElements = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picK = new System.Windows.Forms.PictureBox();
            this.picM = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picK3 = new System.Windows.Forms.PictureBox();
            this.picM2 = new System.Windows.Forms.PictureBox();
            this.picB2 = new System.Windows.Forms.PictureBox();
            this.picK2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtK3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AccessibleName = "btnStart";
            this.btnStart.Location = new System.Drawing.Point(15, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "#";
            // 
            // lblTransferFunction
            // 
            this.lblTransferFunction.AutoSize = true;
            this.lblTransferFunction.Location = new System.Drawing.Point(12, 293);
            this.lblTransferFunction.Name = "lblTransferFunction";
            this.lblTransferFunction.Size = new System.Drawing.Size(38, 13);
            this.lblTransferFunction.TabIndex = 5;
            this.lblTransferFunction.Text = "G(s) = ";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(64, 29);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 6;
            this.txtM.Text = "100";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(64, 55);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            this.txtK.Text = "1";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(64, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 8;
            this.txtB.Text = "1";
            // 
            // txtElements
            // 
            this.txtElements.Location = new System.Drawing.Point(64, 216);
            this.txtElements.Name = "txtElements";
            this.txtElements.Size = new System.Drawing.Size(100, 20);
            this.txtElements.TabIndex = 10;
            this.txtElements.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(19, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 121);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picK
            // 
            this.picK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picK.Location = new System.Drawing.Point(31, 469);
            this.picK.Name = "picK";
            this.picK.Size = new System.Drawing.Size(141, 11);
            this.picK.TabIndex = 13;
            this.picK.TabStop = false;
            // 
            // picM
            // 
            this.picM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picM.Location = new System.Drawing.Point(171, 461);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(45, 46);
            this.picM.TabIndex = 14;
            this.picM.TabStop = false;
            // 
            // picB
            // 
            this.picB.BackColor = System.Drawing.Color.Blue;
            this.picB.Location = new System.Drawing.Point(31, 486);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(141, 11);
            this.picB.TabIndex = 15;
            this.picB.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox5.Location = new System.Drawing.Point(189, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 32);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox6.Location = new System.Drawing.Point(189, 105);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 32);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Blue;
            this.pictureBox7.Location = new System.Drawing.Point(189, 67);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 32);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // chartG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartG.Legends.Add(legend1);
            this.chartG.Location = new System.Drawing.Point(510, 32);
            this.chartG.Name = "chartG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartG.Series.Add(series1);
            this.chartG.Size = new System.Drawing.Size(541, 287);
            this.chartG.TabIndex = 19;
            this.chartG.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Resorte (k)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Masa (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Amortiguador (b)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picK3
            // 
            this.picK3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picK3.Location = new System.Drawing.Point(215, 479);
            this.picK3.Name = "picK3";
            this.picK3.Size = new System.Drawing.Size(141, 11);
            this.picK3.TabIndex = 23;
            this.picK3.TabStop = false;
            // 
            // picM2
            // 
            this.picM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picM2.Location = new System.Drawing.Point(355, 461);
            this.picM2.Name = "picM2";
            this.picM2.Size = new System.Drawing.Size(45, 46);
            this.picM2.TabIndex = 24;
            this.picM2.TabStop = false;
            // 
            // picB2
            // 
            this.picB2.BackColor = System.Drawing.Color.Blue;
            this.picB2.Location = new System.Drawing.Point(399, 486);
            this.picB2.Name = "picB2";
            this.picB2.Size = new System.Drawing.Size(141, 11);
            this.picB2.TabIndex = 26;
            this.picB2.TabStop = false;
            // 
            // picK2
            // 
            this.picK2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picK2.Location = new System.Drawing.Point(399, 469);
            this.picK2.Name = "picK2";
            this.picK2.Size = new System.Drawing.Size(141, 11);
            this.picK2.TabIndex = 25;
            this.picK2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(540, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(12, 121);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(64, 164);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 20);
            this.txtB2.TabIndex = 33;
            this.txtB2.Text = "1";
            // 
            // txtK2
            // 
            this.txtK2.Location = new System.Drawing.Point(64, 138);
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(100, 20);
            this.txtK2.TabIndex = 32;
            this.txtK2.Text = "1";
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(64, 112);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(100, 20);
            this.txtM2.TabIndex = 31;
            this.txtM2.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "b2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "k2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "m2";
            // 
            // txtK3
            // 
            this.txtK3.Location = new System.Drawing.Point(64, 190);
            this.txtK3.Name = "txtK3";
            this.txtK3.Size = new System.Drawing.Size(100, 20);
            this.txtK3.TabIndex = 35;
            this.txtK3.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "k3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 543);
            this.Controls.Add(this.txtK3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtK2);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picB2);
            this.Controls.Add(this.picK2);
            this.Controls.Add(this.picM2);
            this.Controls.Add(this.picK3);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.picK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtElements);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblTransferFunction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTransferFunction;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtElements;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picK;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picK3;
        private System.Windows.Forms.PictureBox picM2;
        private System.Windows.Forms.PictureBox picB2;
        private System.Windows.Forms.PictureBox picK2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtK3;
        private System.Windows.Forms.Label label11;
    }
}

