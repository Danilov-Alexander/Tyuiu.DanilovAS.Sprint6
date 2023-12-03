
namespace Tyuiu.DanilovAS.Sprint6.Task2.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_DAS = new System.Windows.Forms.GroupBox();
            this.labelCondition_DAS = new System.Windows.Forms.Label();
            this.groupBoxInPut_DAS = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_DAS = new System.Windows.Forms.TextBox();
            this.labelStopValue_DAS = new System.Windows.Forms.Label();
            this.textBoxStartValue_DAS = new System.Windows.Forms.TextBox();
            this.labelStartValue_DAS = new System.Windows.Forms.Label();
            this.buttonHelp_DAS = new System.Windows.Forms.Button();
            this.buttonDone_DAS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_DAS = new System.Windows.Forms.GroupBox();
            this.chartResult_DAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_DAS = new System.Windows.Forms.DataGridView();
            this.labelResult = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_DAS.SuspendLayout();
            this.groupBoxInPut_DAS.SuspendLayout();
            this.groupBoxOutPut_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DAS
            // 
            this.groupBoxCondition_DAS.Controls.Add(this.labelCondition_DAS);
            this.groupBoxCondition_DAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_DAS.Name = "groupBoxCondition_DAS";
            this.groupBoxCondition_DAS.Size = new System.Drawing.Size(460, 202);
            this.groupBoxCondition_DAS.TabIndex = 0;
            this.groupBoxCondition_DAS.TabStop = false;
            this.groupBoxCondition_DAS.Text = "Условие";
            // 
            // labelCondition_DAS
            // 
            this.labelCondition_DAS.AutoSize = true;
            this.labelCondition_DAS.Location = new System.Drawing.Point(7, 21);
            this.labelCondition_DAS.Name = "labelCondition_DAS";
            this.labelCondition_DAS.Size = new System.Drawing.Size(350, 91);
            this.labelCondition_DAS.TabIndex = 0;
            this.labelCondition_DAS.Text = resources.GetString("labelCondition_DAS.Text");
            // 
            // groupBoxInPut_DAS
            // 
            this.groupBoxInPut_DAS.Controls.Add(this.textBoxStopValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.labelStopValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.textBoxStartValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.labelStartValue_DAS);
            this.groupBoxInPut_DAS.Location = new System.Drawing.Point(13, 222);
            this.groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            this.groupBoxInPut_DAS.Size = new System.Drawing.Size(244, 80);
            this.groupBoxInPut_DAS.TabIndex = 1;
            this.groupBoxInPut_DAS.TabStop = false;
            this.groupBoxInPut_DAS.Text = "Ввод данных";
            // 
            // textBoxStopValue_DAS
            // 
            this.textBoxStopValue_DAS.Location = new System.Drawing.Point(120, 36);
            this.textBoxStopValue_DAS.Name = "textBoxStopValue_DAS";
            this.textBoxStopValue_DAS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_DAS.TabIndex = 3;
            // 
            // labelStopValue_DAS
            // 
            this.labelStopValue_DAS.AutoSize = true;
            this.labelStopValue_DAS.Location = new System.Drawing.Point(117, 20);
            this.labelStopValue_DAS.Name = "labelStopValue_DAS";
            this.labelStopValue_DAS.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_DAS.TabIndex = 2;
            this.labelStopValue_DAS.Text = "Конец шага:";
            // 
            // textBoxStartValue_DAS
            // 
            this.textBoxStartValue_DAS.Location = new System.Drawing.Point(10, 37);
            this.textBoxStartValue_DAS.Name = "textBoxStartValue_DAS";
            this.textBoxStartValue_DAS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_DAS.TabIndex = 1;
            // 
            // labelStartValue_DAS
            // 
            this.labelStartValue_DAS.AutoSize = true;
            this.labelStartValue_DAS.Location = new System.Drawing.Point(7, 20);
            this.labelStartValue_DAS.Name = "labelStartValue_DAS";
            this.labelStartValue_DAS.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_DAS.TabIndex = 0;
            this.labelStartValue_DAS.Text = "Старт шага:";
            // 
            // buttonHelp_DAS
            // 
            this.buttonHelp_DAS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_DAS.Location = new System.Drawing.Point(263, 239);
            this.buttonHelp_DAS.Name = "buttonHelp_DAS";
            this.buttonHelp_DAS.Size = new System.Drawing.Size(90, 58);
            this.buttonHelp_DAS.TabIndex = 2;
            this.buttonHelp_DAS.Text = "Справка";
            this.buttonHelp_DAS.UseVisualStyleBackColor = false;
            this.buttonHelp_DAS.Click += new System.EventHandler(this.buttonHelp_DAS_Click);
            // 
            // buttonDone_DAS
            // 
            this.buttonDone_DAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DAS.Location = new System.Drawing.Point(359, 239);
            this.buttonDone_DAS.Name = "buttonDone_DAS";
            this.buttonDone_DAS.Size = new System.Drawing.Size(114, 58);
            this.buttonDone_DAS.TabIndex = 3;
            this.buttonDone_DAS.Text = "Выполнить";
            this.buttonDone_DAS.UseVisualStyleBackColor = false;
            this.buttonDone_DAS.Click += new System.EventHandler(this.buttonDone_DAS_Click);
            this.buttonDone_DAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_DAS_MouseDown);
            this.buttonDone_DAS.MouseEnter += new System.EventHandler(this.buttonDone_DAS_MouseEnter);
            this.buttonDone_DAS.MouseLeave += new System.EventHandler(this.buttonDone_DAS_MouseLeave);
            // 
            // groupBoxOutPut_DAS
            // 
            this.groupBoxOutPut_DAS.Controls.Add(this.chartResult_DAS);
            this.groupBoxOutPut_DAS.Controls.Add(this.dataGridViewFunction_DAS);
            this.groupBoxOutPut_DAS.Controls.Add(this.labelResult);
            this.groupBoxOutPut_DAS.Location = new System.Drawing.Point(490, 21);
            this.groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            this.groupBoxOutPut_DAS.Size = new System.Drawing.Size(517, 275);
            this.groupBoxOutPut_DAS.TabIndex = 4;
            this.groupBoxOutPut_DAS.TabStop = false;
            this.groupBoxOutPut_DAS.Text = "Вывод данных";
            // 
            // chartResult_DAS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_DAS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_DAS.Legends.Add(legend1);
            this.chartResult_DAS.Location = new System.Drawing.Point(120, 39);
            this.chartResult_DAS.Name = "chartResult_DAS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_DAS.Series.Add(series1);
            this.chartResult_DAS.Size = new System.Drawing.Size(372, 220);
            this.chartResult_DAS.TabIndex = 2;
            this.chartResult_DAS.Text = "chart1";
            // 
            // dataGridViewFunction_DAS
            // 
            this.dataGridViewFunction_DAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewFunction_DAS.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewFunction_DAS.Name = "dataGridViewFunction_DAS";
            this.dataGridViewFunction_DAS.RowHeadersVisible = false;
            this.dataGridViewFunction_DAS.Size = new System.Drawing.Size(104, 222);
            this.dataGridViewFunction_DAS.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Function
            // 
            this.Function.HeaderText = "F(X)";
            this.Function.Name = "Function";
            this.Function.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.groupBoxOutPut_DAS);
            this.Controls.Add(this.buttonDone_DAS);
            this.Controls.Add(this.buttonHelp_DAS);
            this.Controls.Add(this.groupBoxInPut_DAS);
            this.Controls.Add(this.groupBoxCondition_DAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23| Данилов А.С.";
            this.groupBoxCondition_DAS.ResumeLayout(false);
            this.groupBoxCondition_DAS.PerformLayout();
            this.groupBoxInPut_DAS.ResumeLayout(false);
            this.groupBoxInPut_DAS.PerformLayout();
            this.groupBoxOutPut_DAS.ResumeLayout(false);
            this.groupBoxOutPut_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DAS;
        private System.Windows.Forms.Label labelCondition_DAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_DAS;
        private System.Windows.Forms.TextBox textBoxStopValue_DAS;
        private System.Windows.Forms.Label labelStopValue_DAS;
        private System.Windows.Forms.TextBox textBoxStartValue_DAS;
        private System.Windows.Forms.Label labelStartValue_DAS;
        private System.Windows.Forms.Button buttonHelp_DAS;
        private System.Windows.Forms.Button buttonDone_DAS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DAS;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
    }
}

