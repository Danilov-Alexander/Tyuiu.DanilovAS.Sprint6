using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DanilovAS.Sprint6.Task2.V23.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 2 выполнил студент группы ИСТНб-23-1 Данилов Александр Сергевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_DAS);
                int stopStep = Convert.ToInt32(textBoxStopValue_DAS);

                int len = ds.GetMassFunction(startStep, stopStep).Length ;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_DAS.Titles.Add("График функции");
                this.chartResult_DAS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_DAS.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_DAS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult_DAS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены наверные данные","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_DAS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Red;
        }

        private void buttonDone_DAS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Green;
        }

        private void buttonDone_DAS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Blue;
        }
    }
}
