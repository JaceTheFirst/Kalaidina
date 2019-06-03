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

        private long factorial(int a)
        {
            long f = 1;
            for (int i = 1; i <= a; i++)
                f *= i;
            return f;
        }

        private long Comb(int n, int m)
        {
            long first = factorial(n);
            long second = factorial(m);
            long third = factorial(n - m);
            long res = first / second / third;
            return res;
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
            if(Generate_4(out string cond4, out string answ4))
            {
                variant.Add(cond4);
                answers.Add(answ4);
            }
            else
            {
                not_error = false;
                return not_error;
            }
            if (Generate_5(out string cond5, out string answ5))
            {
                variant.Add(cond5);
                answers.Add(answ5);
            }
            else
            {
                not_error = false;
                return not_error;
            }
            if (Generate_6(out string cond6, out string answ6))
            {
                variant.Add(cond6);
                answers.Add(answ6);
            }
            else
            {
                not_error = false;
                return not_error;
            }
            return not_error;
        }

        private bool Generate_4(out string condition, out string answer)
        {
            bool not_error = true;
            condition = "";
            answer = "";
            try
            {
                Random rand = new Random();
                int n = rand.Next(1, 10);
                if (n > 6)
                    n = 2000;
                else
                    if (n > 3)
                    n = 1500;
                else
                    n = 1000;
                int first = rand.Next(n / 2 - 250, n / 2 + 100);
                int second = rand.Next(n / 3 - 250, n / 3 + 100);
                int third = rand.Next(n / 3 - 250, n / 3 + 100); 
                int raz = first + second + third - n;
                if (raz > 0)
                {
                    answer = "4. Разница между суммой трех групп и общим количеством - " + raz.ToString() + ". События зависимы.";
                }
                else
                {
                    answer = "4. Разница между общим количеством и суммой трех групп - " + (-raz).ToString() + ". События независимы.";
                }
                using (StreamReader st = new StreamReader(resPath + "/4shtamp.txt", Encoding.Default))
                {
                    string lime = st.ReadLine();
                    lime = lime.Replace("{1}", n.ToString());
                    lime = lime.Replace("{2}", first.ToString());
                    lime = lime.Replace("{3}", second.ToString());
                    lime = lime.Replace("{4}", third.ToString());
                    condition = "4. " + lime;
                }
                return not_error;
            }
            catch
            {
                return false;
            }
        }

        private bool Generate_5(out string condition, out string answer)
        {
            bool not_error = true;
            condition = "";
            answer = "";
            try
            {
                Random rand = new Random();
                int n = rand.Next(10, 20);
                int fal = rand.Next(5, n - 5);
                int ch = rand.Next(5, n-fal);
                int count = rand.Next(2, ch - 2);
                double[] values = new double[ch + 1];
                for (int i = 1; i <= ch; i++)
                {
                    long first = Comb(fal, i);
                    long second = Comb(n - fal, ch - i);
                    long third = Comb(n, ch);
                    double val = (double)(first * second) / third;
                    val = Math.Round(val, 4, MidpointRounding.AwayFromZero);
                    values[i] = val;
                }
                string ord = "";
                if (rand.Next(1, 10) > 5)
                {
                    ord = "более";
                }
                else
                {
                    ord = "менее";
                }
                using (StreamReader sr = new StreamReader(resPath + "/5shtamp.txt", Encoding.Default))
                {
                    string lime = sr.ReadLine();
                    lime = lime.Replace("{1}", n.ToString());
                    lime = lime.Replace("{2}", fal.ToString());
                    lime = lime.Replace("{3}", ch.ToString());
                    lime = lime.Replace("{4}", ord);
                    lime = lime.Replace("{5}", count.ToString());
                    condition = "5. " + lime;
                }
                if (not_error)
                {
                    answer = "5. Ряд распределения: ";
                    for (int i = 1; i <= ch; i++)
                    {
                        answer += i.ToString() + " - " + values[i].ToString()+"; ";
                    }
                    if (ord == "более")
                    {
                        double res = 0;
                        for (int i = count + 1; i <= ch; i++)
                        {
                            res += values[i];
                        }
                        answer += "Вероятность того, что обнаружится более " + count.ToString() + " ошибок: " + res.ToString();
                    }
                    else
                    {
                        double res = 0;
                        for (int i = 1; i < count; i++)
                        {
                            res += values[i];
                        }
                        answer += "Вероятность того, что обнаружится менее " + count.ToString() + "ошибок: " + res.ToString();
                    }
                }
                return not_error;
            }
            catch
            {
                return false;
            }
        }

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
                        condition = "6. "+lime;
                    }
                    int i = 0;
                    while (i < laplass_first.Count && laplass_first[i] < num)
                        i++;
                    answer = "6. Вероятность того, что доля не будет отличаться: " + laplass_second[i].ToString();
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