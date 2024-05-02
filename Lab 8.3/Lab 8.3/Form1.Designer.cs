namespace Lab_8._3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.countN = new System.Windows.Forms.NumericUpDown();
            this.StartBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countN)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StartBt);
            this.splitContainer1.Panel1.Controls.Add(this.countN);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.prob4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.prob3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.prob2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.prob1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(918, 502);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series4.IsValueShownAsLabel = true;
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.SmartLabelStyle.CalloutLineWidth = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(609, 502);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вероятность 1";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Location = new System.Drawing.Point(172, 40);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(84, 22);
            this.prob1.TabIndex = 1;
            this.prob1.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Location = new System.Drawing.Point(172, 78);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(84, 22);
            this.prob2.TabIndex = 3;
            this.prob2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятность 2";
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Location = new System.Drawing.Point(172, 156);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(84, 22);
            this.prob4.TabIndex = 7;
            this.prob4.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вероятность 4";
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Location = new System.Drawing.Point(172, 118);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(84, 22);
            this.prob3.TabIndex = 5;
            this.prob3.Value = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вероятность 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(172, 192);
            this.label6.MinimumSize = new System.Drawing.Size(65, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "auto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Число попыток";
            // 
            // countN
            // 
            this.countN.Location = new System.Drawing.Point(172, 254);
            this.countN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countN.Name = "countN";
            this.countN.Size = new System.Drawing.Size(84, 22);
            this.countN.TabIndex = 11;
            this.countN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // StartBt
            // 
            this.StartBt.Location = new System.Drawing.Point(64, 336);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(149, 35);
            this.StartBt.TabIndex = 12;
            this.StartBt.Text = "Старт";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown countN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button StartBt;
    }
}

