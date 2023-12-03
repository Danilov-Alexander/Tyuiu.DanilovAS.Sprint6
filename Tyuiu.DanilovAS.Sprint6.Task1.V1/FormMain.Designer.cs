
namespace Tyuiu.DanilovAS.Sprint6.Task1.V1
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
            this.groupBoxCondition_DAS = new System.Windows.Forms.GroupBox();
            this.labelCondition_DAS = new System.Windows.Forms.Label();
            this.groupBoxResult_DAS = new System.Windows.Forms.GroupBox();
            this.labelResult_DAS = new System.Windows.Forms.Label();
            this.groupBoxInPut_DAS = new System.Windows.Forms.GroupBox();
            this.labelStartValue_DAS = new System.Windows.Forms.Label();
            this.textBoxStartValue_DAS = new System.Windows.Forms.TextBox();
            this.labelStopValue_DAS = new System.Windows.Forms.Label();
            this.textBoxStopValue_DAS = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp_DAS = new System.Windows.Forms.Button();
            this.buttonDone_DAS = new System.Windows.Forms.Button();
            this.groupBoxCondition_DAS.SuspendLayout();
            this.groupBoxResult_DAS.SuspendLayout();
            this.groupBoxInPut_DAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DAS
            // 
            this.groupBoxCondition_DAS.Controls.Add(this.labelCondition_DAS);
            this.groupBoxCondition_DAS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_DAS.Name = "groupBoxCondition_DAS";
            this.groupBoxCondition_DAS.Size = new System.Drawing.Size(492, 189);
            this.groupBoxCondition_DAS.TabIndex = 0;
            this.groupBoxCondition_DAS.TabStop = false;
            this.groupBoxCondition_DAS.Text = "Условие";
            // 
            // labelCondition_DAS
            // 
            this.labelCondition_DAS.AutoSize = true;
            this.labelCondition_DAS.Location = new System.Drawing.Point(8, 20);
            this.labelCondition_DAS.Name = "labelCondition_DAS";
            this.labelCondition_DAS.Size = new System.Drawing.Size(350, 104);
            this.labelCondition_DAS.TabIndex = 0;
            this.labelCondition_DAS.Text = resources.GetString("labelCondition_DAS.Text");
            // 
            // groupBoxResult_DAS
            // 
            this.groupBoxResult_DAS.Controls.Add(this.textBoxResult);
            this.groupBoxResult_DAS.Controls.Add(this.labelResult_DAS);
            this.groupBoxResult_DAS.Location = new System.Drawing.Point(522, 13);
            this.groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            this.groupBoxResult_DAS.Size = new System.Drawing.Size(186, 282);
            this.groupBoxResult_DAS.TabIndex = 1;
            this.groupBoxResult_DAS.TabStop = false;
            this.groupBoxResult_DAS.Text = "Вывод данных";
            // 
            // labelResult_DAS
            // 
            this.labelResult_DAS.AutoSize = true;
            this.labelResult_DAS.Location = new System.Drawing.Point(7, 21);
            this.labelResult_DAS.Name = "labelResult_DAS";
            this.labelResult_DAS.Size = new System.Drawing.Size(62, 13);
            this.labelResult_DAS.TabIndex = 0;
            this.labelResult_DAS.Text = "Результат:";
            // 
            // groupBoxInPut_DAS
            // 
            this.groupBoxInPut_DAS.Controls.Add(this.textBoxStopValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.labelStopValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.textBoxStartValue_DAS);
            this.groupBoxInPut_DAS.Controls.Add(this.labelStartValue_DAS);
            this.groupBoxInPut_DAS.Location = new System.Drawing.Point(13, 221);
            this.groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            this.groupBoxInPut_DAS.Size = new System.Drawing.Size(291, 75);
            this.groupBoxInPut_DAS.TabIndex = 2;
            this.groupBoxInPut_DAS.TabStop = false;
            this.groupBoxInPut_DAS.Text = "Ввод данных";
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
            // textBoxStartValue_DAS
            // 
            this.textBoxStartValue_DAS.Location = new System.Drawing.Point(7, 37);
            this.textBoxStartValue_DAS.Name = "textBoxStartValue_DAS";
            this.textBoxStartValue_DAS.Size = new System.Drawing.Size(121, 20);
            this.textBoxStartValue_DAS.TabIndex = 1;
            // 
            // labelStopValue_DAS
            // 
            this.labelStopValue_DAS.AutoSize = true;
            this.labelStopValue_DAS.Location = new System.Drawing.Point(148, 19);
            this.labelStopValue_DAS.Name = "labelStopValue_DAS";
            this.labelStopValue_DAS.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_DAS.TabIndex = 2;
            this.labelStopValue_DAS.Text = "Конец шага:";
            // 
            // textBoxStopValue_DAS
            // 
            this.textBoxStopValue_DAS.Location = new System.Drawing.Point(151, 36);
            this.textBoxStopValue_DAS.Name = "textBoxStopValue_DAS";
            this.textBoxStopValue_DAS.Size = new System.Drawing.Size(134, 20);
            this.textBoxStopValue_DAS.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 8F);
            this.textBoxResult.Location = new System.Drawing.Point(7, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(173, 226);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonHelp_DAS
            // 
            this.buttonHelp_DAS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_DAS.Location = new System.Drawing.Point(319, 229);
            this.buttonHelp_DAS.Name = "buttonHelp_DAS";
            this.buttonHelp_DAS.Size = new System.Drawing.Size(95, 65);
            this.buttonHelp_DAS.TabIndex = 3;
            this.buttonHelp_DAS.Text = "Справка";
            this.buttonHelp_DAS.UseVisualStyleBackColor = false;
            this.buttonHelp_DAS.Click += new System.EventHandler(this.buttonHelp_DAS_Click);
            // 
            // buttonDone_DAS
            // 
            this.buttonDone_DAS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DAS.Location = new System.Drawing.Point(420, 229);
            this.buttonDone_DAS.Name = "buttonDone_DAS";
            this.buttonDone_DAS.Size = new System.Drawing.Size(95, 65);
            this.buttonDone_DAS.TabIndex = 4;
            this.buttonDone_DAS.Text = "Выполнить";
            this.buttonDone_DAS.UseVisualStyleBackColor = false;
            this.buttonDone_DAS.Click += new System.EventHandler(this.buttonDone_DAS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonDone_DAS);
            this.Controls.Add(this.buttonHelp_DAS);
            this.Controls.Add(this.groupBoxInPut_DAS);
            this.Controls.Add(this.groupBoxResult_DAS);
            this.Controls.Add(this.groupBoxCondition_DAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Данилов А.С. ";
            this.groupBoxCondition_DAS.ResumeLayout(false);
            this.groupBoxCondition_DAS.PerformLayout();
            this.groupBoxResult_DAS.ResumeLayout(false);
            this.groupBoxResult_DAS.PerformLayout();
            this.groupBoxInPut_DAS.ResumeLayout(false);
            this.groupBoxInPut_DAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DAS;
        private System.Windows.Forms.Label labelCondition_DAS;
        private System.Windows.Forms.GroupBox groupBoxResult_DAS;
        private System.Windows.Forms.Label labelResult_DAS;
        private System.Windows.Forms.GroupBox groupBoxInPut_DAS;
        private System.Windows.Forms.TextBox textBoxStopValue_DAS;
        private System.Windows.Forms.Label labelStopValue_DAS;
        private System.Windows.Forms.TextBox textBoxStartValue_DAS;
        private System.Windows.Forms.Label labelStartValue_DAS;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp_DAS;
        private System.Windows.Forms.Button buttonDone_DAS;
    }
}

