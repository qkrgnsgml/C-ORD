using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;


namespace ORD
{
    public partial class Form1 : Form
    {
        static string sukList = "C:\\Onerand\\suklist.txt";
        string[] random = System.IO.File.ReadAllLines(sukList);
        
        int stack = 0;
        public Form1()
        {
            InitializeComponent();
        }
        static string path = "C:\\Onerand";
        static string fileProduct = "sukjae.txt";
        static string filejung = "C:\\Onerand\\junglee.txt";
        List<string> st = new List<string>();
        List<string> memo = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            stack += 1;
            Thread.Sleep(450);
            //Console.Beep22(2000, 100);
            //Console.Beep(3000, 200);
            string a = "";
            Random rand = new Random();
            int randIndex = rand.Next(0, random.Length);
            label1.Text = random[randIndex];
            bool yn1 = (label1.Text).Contains("초월");
            bool yn2 = (label1.Text).Contains("불멸");
            bool yn3 = (label1.Text).Contains("영원");
            bool yn4 = (label1.Text).Contains("제한");
            bool yn5 = (label1.Text).Contains("안흔함");
            bool yn6 = (label1.Text).Contains("특별");
            bool yn7 = (label1.Text).Contains("전설");
            bool yn8 = (label1.Text).Contains("히든");
            bool yn9 = (label1.Text).Contains("희귀");
            if (yn1 == true)
            {
                pictureBox1.Image = Properties.Resources.초월;
            }
            else if (yn2 == true)
            {
                pictureBox1.Image = Properties.Resources.불멸;
            }
            else if (yn3 == true)
            {
                pictureBox1.Image = Properties.Resources.영원;
            }
            else if (yn4 == true)
            {
                pictureBox1.Image = Properties.Resources.제한1;
            }
            else if (yn5 == true)
            {
                pictureBox1.Image = Properties.Resources.안흔함;
            }
            else if (yn6 == true)
            {
                pictureBox1.Image = Properties.Resources.특별;
            }
            else if (yn7 == true)
            {
                pictureBox1.Image = Properties.Resources.전설;
            }
            else if (yn8 == true)
            {
                pictureBox1.Image = Properties.Resources.히든;
            }
            else if (yn9 == true)
            {
                pictureBox1.Image = Properties.Resources.희귀;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.기본;
            }
            label2.Text = (randIndex + 1).ToString();
            st.Add((randIndex + 1).ToString() + "." + random[randIndex] + Environment.NewLine);
            memo.Add(random[randIndex]);

            foreach (var it in st)
            {
                a += it;
            }
            if (st.Count == 21)
            {
                a = "";
                st.RemoveRange(0, 20);
                foreach (var it in st)
                {
                    a += it;
                }
                label3.Text = a;
            }
            string suk = stack.ToString();
            label3.Text = "[" + suk + "숙]" + a;
            memo.Sort();
            var filename = Path.Combine(path, fileProduct);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            else { }
            if (File.Exists(filename) == false)
            {
                using (var sw = new StreamWriter(new FileStream(filename, FileMode.Create)))
                {
                    for (int i = 0; i < memo.Count; i++)
                    {
                        sw.Write($"{memo[i]}");
                    }
                }
            }
            else
            {
                File.Delete(filename);
                using (var sw = new StreamWriter(new FileStream(filename, FileMode.Create)))
                {
                    for (int i = 0; i < memo.Count; i++)
                    {
                        //sw.Write($"{memo[i]} ");
                        if ((i % 2) == 1)
                        {
                            sw.WriteLine($"{memo[i]}");
                        }
                        else
                        {
                            sw.Write($"{memo[i]} ");
                        }
                    }
                }
            }
        }

        List<int> four = new List<int>();
        List<int> four2 = new List<int>();
        List<int> three = new List<int>();
        List<int> three2 = new List<int>();
        string a = "";
        string b = "";
        private void button4_Click(object sender, EventArgs e)
        {
            four.Clear();
            four2.Clear();
            three.Clear();
            three2.Clear();
            label4.Text = "";
            a = "";
            b = "";
            if (checkBox1.Checked)
            {
                int.TryParse(textBox1.Text, out int num);
                int index = num / 4;
                Random rand = new Random();
                for (int i = 1; i <= num; ++i)
                {
                    four.Add(i);
                }

                while (0 < four.Count)
                {
                    int ct = rand.Next(0, four.Count);
                    int random_number = four[ct];
                    foreach (int a in four2)
                    {
                        if (a == random_number)
                        {
                            break;
                        }
                    }
                    four2.Add(random_number);
                    four.RemoveAt(ct);
                }

                /*while (0 < four.Count)
                {
                    int ct = rand.Next(0,four.Count); // 꺼낼 번호를 랜덤하게 선택합니다.
                    int random_number = (int)four[ct]; // 중복되지 않는 번호를 꺼내왔으니 이것을 사용하세요.
                    four2.Add(random_number);
                    four.RemoveAt(ct); // 중복되지 않도록 제거합니다.
                }*/
                for (int i = 0; i < index; i++)
                {
                    a += $"{i + 1}번 팀 {four2[4 * i]}, {four2[4 * i + 1]}, {four2[4 * i + 2]}, {four2[4 * i + 3]}," + Environment.NewLine;
                }
                label4.Text = a;
            }
            else
            {
                int.TryParse(textBox1.Text, out int num);
                int index = num / 3;
                Random rand = new Random();
                for (int i = 1; i <= num; ++i)
                {
                    three.Add(i);
                }
                while (0 < three.Count)
                {
                    int ct = rand.Next(0, three.Count);
                    int random_number = three[ct];
                    foreach (int a in three2)
                    {
                        if (a == random_number)
                        {
                            break;
                        }
                    }
                    three2.Add(random_number);
                    three.RemoveAt(ct);
                }
                for (int i = 0; i < index; i++)
                {
                    b += $"{i + 1}번 팀 {three2[3 * i]}, {three2[3 * i + 1]}, {three2[3 * i + 2]}" + Environment.NewLine;
                }
                label4.Text = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memo.Clear();
            stack = 0;
            st.RemoveRange(0, st.Count);
            label3.Text = "";
            string a = "";
            label1.Text = "";
            label2.Text = "";
            var filename = Path.Combine(path, fileProduct);
            File.Delete(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = rand.Next(1, int.Parse(textBox2.Text) + 1);
            label6.Text = i.ToString();
        }
        List<string> hab = new List<string>();


        static List<string> cho = new List<string>();
        static List<string> bul = new List<string>();
        static List<string> young = new List<string>();
        static List<string> ze = new List<string>();
        void makeList()
        {
            for (int i = 0; i < random.Length; i++)
            {
                if (random[i].Contains("강제") || random[i].Contains("랜덤"))
                {
                    continue;
                }
                if (random[i].Contains("초월"))
                {
                    cho.Add(random[i]);
                }
                if (random[i].Contains("불멸"))
                {
                    bul.Add(random[i]);
                }
                if (random[i].Contains("영원"))
                {
                    young.Add(random[i]);
                }
                if (random[i].Contains("제한"))
                {
                    ze.Add(random[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            makeList();
            hab.Clear();
            for (int i = 0; i < hab.Count; i++)
            {
                hab.RemoveAt(0);
            }
            if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }
            else if (checkBox5.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//불영제
            else if (checkBox2.Checked && checkBox3.Checked && checkBox5.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//초불제
            else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//초불영
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//초불
            else if (checkBox2.Checked && checkBox5.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//초제
            else if (checkBox2.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//초영
            else if (checkBox3.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//불영
            else if (checkBox3.Checked && checkBox5.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }
                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//불제
            else if (checkBox4.Checked && checkBox5.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }
                for (int i = 0; i < ze.Count; i++)
                {
                    hab.Add(ze[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//영제
            else if (checkBox2.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < cho.Count; i++)
                {
                    hab.Add(cho[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }
            else if (checkBox3.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < bul.Count; i++)
                {
                    hab.Add(bul[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }
            else if (checkBox4.Checked)
            {
                for (int i = 0; i < hab.Count; i++)
                {
                    hab.RemoveAt(0);
                }
                for (int i = 0; i < young.Count; i++)
                {
                    hab.Add(young[i]);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }
            else if (checkBox5.Checked)
            {

                foreach (string str in ze)
                {
                    hab.Add(str);
                }

                Random rand = new Random();
                int randIndex = rand.Next(0, hab.Count);
                label7.Text = hab[randIndex];
            }//제
        }
        Dictionary<string, int> Dic = new Dictionary<string, int>();
        static List<string> jung = new List<string>();
        static List<string> jung2 = new List<string>();
        int choct = 0;
        int bulct = 0;
        int youngct = 0;
        int zect = 0;
        int sukCount = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            choct = 0;
            bulct = 0;
            youngct = 0;
            zect = 0;
            sukCount = 0;
            Dic.Clear();
            jung.Clear();
            jung2.Clear();
            if (File.Exists(filejung) == false)
            {
                File.Create(filejung);
            }
            else
            {
                var fs = new FileStream(filejung, FileMode.Open);
                var sr = new StreamReader(fs);

                while (sr.EndOfStream == false)
                {
                    string data = sr.ReadLine();
                    data = data.TrimEnd();
                    string[] junglee = data.Split(new char[] { ' ' });
                    for (int i = 0; i < junglee.Length; i++)
                    {
                        if (junglee[i] == "") { continue; }
                        jung2.Add(junglee[i]);
                    }
                }

                sr.Close();
                fs.Close();

                File.Delete(filejung);
                jung2.Sort();
                for (int i = 0; i < jung2.Count; i++)
                {
                    if (jung2[i].Contains("x2"))
                    {
                        string a = jung2[i].Replace("x2", "");
                        jung23(2, a);
                    }
                    else if (jung2[i].Contains("x3"))
                    {
                        string a = jung2[i].Replace("x3", "");
                        jung23(3, a);
                    }
                    else if (jung2[i].Contains("x4"))
                    {
                        string a = jung2[i].Replace("x4", "");
                        jung23(4, a);
                    }
                    else if (jung2[i].Contains("x5"))
                    {
                        string a = jung2[i].Replace("x5", "");
                        jung23(5, a);
                    }
                    else if (jung2[i].Contains("x6"))
                    {
                        string a = jung2[i].Replace("x6", "");
                        jung23(6, a);
                    }
                    else if (jung2[i].Contains("x7"))
                    {
                        string a = jung2[i].Replace("x7", "");
                        jung23(7, a);
                    }
                    else if (jung2[i].Contains("x8"))
                    {
                        string a = jung2[i].Replace("x8", "");
                        jung23(8, a);
                    }
                    else if (jung2[i].Contains("x9"))
                    {
                        string a = jung2[i].Replace("x9", "");
                        jung23(9, a);
                    }
                    else if (jung2[i].Contains("x10"))
                    {
                        string a = jung2[i].Replace("x10", "");
                        jung23(10, a);
                    }
                    else if (jung2[i].Contains("x11"))
                    {
                        string a = jung2[i].Replace("x11", "");
                        jung23(11, a);
                    }
                    else if (jung2[i].Contains("x12"))
                    {
                        string a = jung2[i].Replace("x12", "");
                        jung23(12, a);
                    }
                    else if (jung2[i].Contains("x13"))
                    {
                        string a = jung2[i].Replace("x13", "");
                        jung23(13, a);
                    }
                    else
                    {
                        jung.Add(jung2[i]);
                        if (jung2[i].Contains("초월"))
                        {
                            choct++;
                        }
                        if (jung2[i].Contains("불멸"))
                        {
                            bulct++;
                        }
                        if (jung2[i].Contains("영원"))
                        {
                            youngct++;
                        }
                        if (jung2[i].Contains("제한"))
                        {
                            zect++;
                        }
                    }
                }

                foreach (string str in jung)
                {

                    int count = 0;
                    if (Dic.ContainsKey(str))
                    {
                        count = Dic[str];
                    }
                    if (count == 0)
                    {
                        Dic.Add(str, 1);
                    }
                    else
                    {
                        //Dic.Remove(str);
                        Dic[str]++;
                    }
                }

                jung.Clear();

                foreach (KeyValuePair<string, int> each in Dic)
                {
                    string K = each.Key;
                    int V = each.Value;
                    if (V == 1)
                    {
                        jung.Add(K);
                    }
                    else
                    {
                        jung.Add(K + "x" + V);
                    }

                }


                if (checkedListBox1.GetItemChecked(0))
                {
                    using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                    {
                        for (int i = 0; i < jung.Count; i++)
                        {
                            sukCount += 1;
                            for (int j = 2; j < 20; j++)
                            {
                                if (jung[i].Contains($"x{j}"))
                                {
                                    sukCount += j - 1;
                                }

                            }
                            //sw.Write($"{memo[i]} ");
                            if ((i % 3) == 2)
                            {
                                sw.WriteLine($"{jung[i]}");
                            }
                            else
                            {
                                sw.Write($"{jung[i]} ");
                            }
                        }
                        //sw.Write($"//{sukCount}숙");
                    }
                }
                else if (checkedListBox1.GetItemChecked(1))
                {
                    using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                    {
                        for (int i = 0; i < jung.Count; i++)
                        {
                            sukCount += 1;
                            for (int j = 2; j < 20; j++)
                            {
                                if (jung[i].Contains($"x{j}"))
                                {
                                    sukCount += j - 1;
                                }

                            }
                            //sw.Write($"{memo[i]} ");
                            if ((i % 4) == 3)
                            {
                                sw.WriteLine($"{jung[i]}");
                            }
                            else
                            {
                                sw.Write($"{jung[i]} ");
                            }
                        }
                        //sw.Write($"//{sukCount}숙");
                    }
                }
                else if (checkedListBox1.GetItemChecked(2))
                {
                    using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                    {
                        for (int i = 0; i < jung.Count; i++)
                        {
                            sukCount += 1;
                            for (int j = 2; j < 20; j++)
                            {
                                if (jung[i].Contains($"x{j}"))
                                {
                                    sukCount += j - 1;
                                }

                            }
                            //sw.Write($"{memo[i]} ");
                            if ((i % 5) == 4)
                            {
                                sw.WriteLine($"{jung[i]}");
                            }
                            else
                            {
                                sw.Write($"{jung[i]} ");
                            }
                        }
                        //sw.Write($"//{sukCount}숙");
                    }
                }
                else if (checkedListBox1.GetItemChecked(3))
                {
                    using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                    {
                        for (int i = 0; i < jung.Count; i++)
                        {
                            sukCount += 1;
                            for (int j = 2; j < 20; j++)
                            {
                                if (jung[i].Contains($"x{j}"))
                                {
                                    sukCount += j - 1;
                                }

                            }
                            //sw.Write($"{memo[i]} ");
                            if ((i % 6) == 5)
                            {
                                sw.WriteLine($"{jung[i]}");
                            }
                            else
                            {
                                sw.Write($"{jung[i]} ");
                            }
                        }
                        //sw.Write($"//{sukCount}숙");
                    }
                }
                else
                {
                    using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                    {
                        for (int i = 0; i < jung.Count; i++)
                        {
                            sukCount += 1;
                            for (int j = 2; j < 20; j++)
                            {
                                if (jung[i].Contains($"x{j}"))
                                {
                                    sukCount += j - 1;
                                }
                            }
                            //sw.Write($"{memo[i]} ");
                            if ((i % 2) == 1)
                            {
                                sw.WriteLine($"{jung[i]}");
                            }
                            else
                            {
                                sw.Write($"{jung[i]} ");
                            }
                        }
                        //sw.Write($"//{sukCount}숙");
                    }
                }
                label1.Text = $"정리: {sukCount}숙";
            }
            erase.Clear();
            for (int i = 0; i < jung.Count; i++)
            {
                if (jung[i].Contains("x2"))
                {
                    string a = jung[i].Replace("x2", "");
                    eras(2, a);
                }
                else if (jung[i].Contains("x3"))
                {
                    string a = jung[i].Replace("x3", "");
                    eras(3, a);
                }
                else if (jung[i].Contains("x4"))
                {
                    string a = jung[i].Replace("x4", "");
                    eras(4, a);
                }
                else if (jung[i].Contains("x5"))
                {
                    string a = jung[i].Replace("x5", "");
                    eras(5, a);
                }
                else if (jung[i].Contains("x6"))
                {
                    string a = jung[i].Replace("x6", "");
                    eras(6, a);
                }
                else if (jung[i].Contains("x7"))
                {
                    string a = jung[i].Replace("x7", "");
                    eras(7, a);
                }
                else if (jung[i].Contains("x8"))
                {
                    string a = jung[i].Replace("x8", "");
                    eras(8, a);
                }
                else if (jung[i].Contains("x9"))
                {
                    string a = jung[i].Replace("x9", "");
                    eras(9, a);
                }
                else if (jung[i].Contains("x10"))
                {
                    string a = jung[i].Replace("x10", "");
                    eras(10, a);
                }
                else if (jung[i].Contains("x11"))
                {
                    string a = jung[i].Replace("x11", "");
                    eras(11, a);
                }
                else if (jung[i].Contains("x12"))
                {
                    string a = jung[i].Replace("x12", "");
                    eras(12, a);
                }
                else if (jung[i].Contains("x13"))
                {
                    string a = jung[i].Replace("x13", "");
                    eras(13, a);
                }
                else
                {
                    erase.Add(jung[i]);
                }
            }
            label10.Text = $"초월 : {choct}개";
            label11.Text = $"불멸 : {bulct}개";
            label12.Text = $"영원 : {youngct}개";
            label13.Text = $"제한 : {zect}개";



        }
        private void eras(int i, string a)
        {

            for (int j = 0; j < i; j++)
            {
                erase.Add(a);
            }
        }
        private void jung23(int i, string a)
        {
            
            
            for (int j = 0; j < i; j++)
            {
                jung.Add(a);
                if (a.Contains("초월"))
                {
                    choct++;
                }
                if (a.Contains("불멸"))
                {
                    bulct++;
                }
                if (a.Contains("영원"))
                {
                    youngct++;
                }
                if (a.Contains("제한"))
                {
                    zect++;
                }
            }
        }

        static List<string> erase = new List<string>();

        private void button7_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randIndex = rand.Next(0, erase.Count);
            label9.Text = $"{randIndex + 1}번 {erase[randIndex]}";
            erase.RemoveAt(randIndex);


            Dic.Clear();
            jung.Clear();
            if (File.Exists(filejung) == false)
            {
                File.Create(filejung);
            }
            else
            {
                foreach (string str in erase)
                {

                    int count = 0;
                    if (Dic.ContainsKey(str))
                    {
                        count = Dic[str];
                    }
                    if (count == 0)
                    {
                        Dic.Add(str, 1);
                    }
                    else
                    {
                        //Dic.Remove(str);
                        Dic[str]++;
                    }
                }                

                foreach (KeyValuePair<string, int> each in Dic)
                {
                    string K = each.Key;
                    int V = each.Value;
                    if (V == 1)
                    {
                        jung.Add(K);
                    }
                    else
                    {
                        jung.Add(K + "x" + V);
                    }

                }

                using (var sw = new StreamWriter(new FileStream(filejung, FileMode.Create)))
                {
                    for (int i = 0; i < jung.Count; i++)
                    {
                        sukCount += 1;
                        for (int j = 2; j < 20; j++)
                        {
                            if (jung[i].Contains($"x{j}"))
                            {
                                sukCount += j - 1;
                            }
                        }
                        //sw.Write($"{memo[i]} ");
                        if ((i % 2) == 1)
                        {
                            sw.WriteLine($"{jung[i]}");
                        }
                        else
                        {
                            sw.Write($"{jung[i]} ");
                        }
                    }
                    //sw.Write($"//{sukCount}숙");
                }
            }
        }
    }
}
