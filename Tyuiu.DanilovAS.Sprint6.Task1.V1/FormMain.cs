﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DanilovAS.Sprint6.Task1.V1.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_DAS.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_DAS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for(int i = 0; i<= len -1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1, 5:f2}  |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 1 выполнил студент группы ИСТНб-23-1 Данилов Александр Сергевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
