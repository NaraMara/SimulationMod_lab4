namespace CurRate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DayValue = new System.Windows.Forms.Label();
            this.btnSellEvro = new System.Windows.Forms.Button();
            this.btnBuyEvro = new System.Windows.Forms.Button();
            this.EvroValue = new System.Windows.Forms.Label();
            this.RublesValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DayValue);
            this.panel1.Controls.Add(this.btnSellEvro);
            this.panel1.Controls.Add(this.btnBuyEvro);
            this.panel1.Controls.Add(this.EvroValue);
            this.panel1.Controls.Add(this.RublesValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 0;
            // 
            // DayValue
            // 
            this.DayValue.AutoSize = true;
            this.DayValue.Location = new System.Drawing.Point(79, 53);
            this.DayValue.Name = "DayValue";
            this.DayValue.Size = new System.Drawing.Size(13, 13);
            this.DayValue.TabIndex = 11;
            this.DayValue.Text = "0";
            // 
            // btnSellEvro
            // 
            this.btnSellEvro.Location = new System.Drawing.Point(607, 53);
            this.btnSellEvro.Name = "btnSellEvro";
            this.btnSellEvro.Size = new System.Drawing.Size(89, 39);
            this.btnSellEvro.TabIndex = 10;
            this.btnSellEvro.Text = "Продать Евро";
            this.btnSellEvro.UseVisualStyleBackColor = true;
            this.btnSellEvro.Click += new System.EventHandler(this.btnSellEvro_Click);
            // 
            // btnBuyEvro
            // 
            this.btnBuyEvro.Location = new System.Drawing.Point(607, 12);
            this.btnBuyEvro.Name = "btnBuyEvro";
            this.btnBuyEvro.Size = new System.Drawing.Size(89, 39);
            this.btnBuyEvro.TabIndex = 9;
            this.btnBuyEvro.Text = "Купить Евро";
            this.btnBuyEvro.UseVisualStyleBackColor = true;
            this.btnBuyEvro.Click += new System.EventHandler(this.btnBuyEvro_Click);
            // 
            // EvroValue
            // 
            this.EvroValue.AutoSize = true;
            this.EvroValue.Location = new System.Drawing.Point(531, 53);
            this.EvroValue.Name = "EvroValue";
            this.EvroValue.Size = new System.Drawing.Size(13, 13);
            this.EvroValue.TabIndex = 8;
            this.EvroValue.Text = "0";
            // 
            // RublesValue
            // 
            this.RublesValue.AutoSize = true;
            this.RublesValue.Location = new System.Drawing.Point(531, 24);
            this.RublesValue.Name = "RublesValue";
            this.RublesValue.Size = new System.Drawing.Size(13, 13);
            this.RublesValue.TabIndex = 7;
            this.RublesValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ваши Евро :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ваши рубли :";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(309, 36);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 4;
            this.btCalculate.Text = "Вперёд";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "День :";
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(127, 18);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(97, 20);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            8953,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 50D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EvroValue;
        private System.Windows.Forms.Label RublesValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSellEvro;
        private System.Windows.Forms.Button btnBuyEvro;
        private System.Windows.Forms.Label DayValue;
    }
}

