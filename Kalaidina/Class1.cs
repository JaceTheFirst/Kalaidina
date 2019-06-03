using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kalaidina
{
    class Class1
    {
        List<double> laplass_first;
        List<double> laplass_second;
        string resPath, outPath;

        public Class1(string resourses_path, string output_path)
        {
            laplass_first = new List<double>();
            laplass_second = new List<double>();
            resPath = resourses_path;
            outPath = output_path;
        }

        private bool ReadTable(string path)
        {
            bool not_error = true;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] f = line.Split('\t');
                        laplass_first.Add(Convert.ToDouble(f[0]));
                        laplass_second.Add(Convert.ToDouble(f[1]));
                        line = sr.ReadLine();
                    }
                }
                return not_error;
            }
            catch
            {
                not_error = false;
                return not_error;
            }
        }

        public bool GenerateVariant(out List<string> variant, out List<string> answers)
        {
            variant = new List<string>();
            answers = new List<string>();
            bool not_error = true;

            if (Generate_6(out string cond6, out string answ6))
            {
                variant.Add(cond6);
                answers.Add(answ6);
            }
            else
            {
                not_error = false;
            }
            return not_error;
        }

        //private bool Generate_4(out string condition, out string answer)
        //{

        //}

        private bool Generate_6(out string condition, out string answer)
        {
            bool not_error = true;
            condition = "";
            answer = "";
            not_error = ReadTable(resPath + "/laplass_table.txt");
            if(not_error)
            {
                try
                {
                    Random rand = new Random();
                    int electCount = rand.Next(10, 100);
                    double electdob = electCount * 0.01;
                    int dole = rand.Next(10, 100);
                    int raz = rand.Next(1, 10);
                    double razz = raz * 0.01;
                    double num = razz * Math.Sqrt(dole / (electdob * (1 - electdob)));
                    using (StreamReader st = new StreamReader(resPath + "/6shtamp.txt", Encoding.Default))
                    {
                        string lime = st.ReadLine();
                        lime = lime.Replace("{1}", electCount.ToString());
                        lime = lime.Replace("{2}", dole.ToString());
                        lime = lime.Replace("{3}", razz.ToString());
                        condition = lime;
                    }
                    int i = 0;
                    while (i < laplass_first.Count && laplass_first[i] < num)
                        i++;
                    answer = "Ответ на задачу 6: " + laplass_second[i].ToString();
                    return not_error;
                }
                catch
                {
                    not_error = false;
                    return not_error;
                }
            }
            else
            {
                not_error = false;
                return not_error;
            }
        }
    }
}

///jklj