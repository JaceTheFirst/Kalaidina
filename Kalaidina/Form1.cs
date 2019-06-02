using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kalaidina
{
    public partial class Form1 : Form
    {
        Class1 variant;
        bool[] exercise;

        public Form1()
        {
            InitializeComponent();
            exercise = new bool[6];
            for(int i = 0;i<6;i++)
            {
                exercise[i] = false;
            }
            variant = new Class1("../../resourses", "../../generated");
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            Success_textBox.Clear();
            int i = 0;
            for (; i < exercise.Length && exercise[i] == false; i++) ;
            switch (i)
            {
                case 5:
                    {
                        if (variant.Generate_6())
                            Success_textBox.Text = "Генерация прошла успешно";
                        else
                            Success_textBox.Text = "При генерации возникла ошибка";
                        break;
                    }
            }
        }

        private void SetEx(object sender, EventArgs e)
        {
            string ss = (sender as RadioButton).Text;
            int index = Convert.ToInt32(ss[ss.Length - 1]) - 49;
            if ((sender as RadioButton).Checked)
                exercise[index] = true;
            else
                exercise[index] = false;
        }
    }
}
