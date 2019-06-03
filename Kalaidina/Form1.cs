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
        int Count_of_generated = 0;
        string inpath = "../../resourses";
        string outpath = "../../generated";

        public Form1()
        {
            InitializeComponent();
            exercise = new bool[6];
            for(int i = 0;i<6;i++)
            {
                exercise[i] = false;
            }
            variant = new Class1(inpath, outpath);
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            Success_textBox.Clear();
            bool generateError = false; //семафор ошибки
            if (!variant.GenerateVariant(out List<string> var, out List<string> ans))
                generateError = true;
            if(generateError)
            {
                Success_textBox.Text = "При генерации возникла ошибка";
            }
            else
            {
                Success_textBox.Text = "Генерация прошла успешно";
                using (StreamWriter sr = new StreamWriter(outpath + "/variant_"+Count_of_generated.ToString()+".txt"))
                {
                    foreach(string s in var)
                    {
                        sr.WriteLine(s);
                    }
                }
                using (StreamWriter sr = new StreamWriter(outpath + "/answers_"+Count_of_generated.ToString()+".txt"))
                {
                    foreach(string s in ans)
                    {
                        sr.WriteLine(s);
                    }
                }
                Count_of_generated++;
            }
        }
    }
}
