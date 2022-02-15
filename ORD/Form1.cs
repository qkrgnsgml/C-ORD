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
        /*string[] random = new string[]{
"거프불멸"
,"후쿠로안흔함"
,"블루노안흔함"
,"쵸파전설"
,"조로전설"
,"흰수염전설"
,"제프희귀"
,"강제초월"
,"스모커전설"
,"라분전설"
,"쿠마전설"
,"조로초월"
,"비비변이"
,"봉쿠레특별"
,"루피JET전설"
,"피셔히든"
,"킨에몬희귀"
,"징베전설"
,"모비딕호히든"
,"아오키지초월"
,"모리아특별"
,"에넬제한"
,"봉쿠레히든"
,"샹크스전설"
,"슈가전설"
,"나이트메어전설"
,"발라티에히든"
,"쵸파두강특별"
,"마젤란희귀"
,"우솝초월"
,"브룩안흔함"
,"바질희귀"
,"바르톨전설"
,"특수함"
,"쵸파전설"
,"스모커특별"
,"키자루초월"
,"반더히든"
,"조로희귀"
,"베포안흔함"
,"로우전설"
,"베이비5변이"
,"흰수염불멸"
,"시노부전설"
,"코비전설"
,"타시기안흔함"
,"레드포스호히든"
,"카벤영원"
,"후지초월"
,"시저전설"
,"카지노"
,"거프희귀"
,"시키전설"
,"크래커전설"
,"쵸파안흔함"
,"크로커희귀"
,"헤르메포특별"
,"베이비5희귀"
,"도플초월"
,"챠카특별"
,"히루루크전설"
,"버기영원"
,"하찌안흔함"
,"루치전설"
,"코알라히든"
,"버기특별"
,"엑드특별"
,"강제제한"
,"상디전설"
,"아오키지희귀"
,"이완히든"
,"시저전설"
,"모몬가희귀"
,"카이도우불멸"
,"슈가전설"
,"검수희귀"
,"시노부제한"
,"루피희귀"
,"슈가희귀"
,"상디전설"
,"해적선"
,"시키불멸"
,"에이스전설"
,"로져불멸"
,"마르코전설"
,"페로나히든"
,"도플변이"
,"브룩초월"
,"흰수염전설"
,"캡틴크로특별"
,"히루루크전설"
,"레드필드제한"
,"아론특별"
,"에넬희귀"
,"미호크히든"
,"마르코특별"
,"로우전설"
,"후지토라전설"
,"센고쿠전설"
,"레베카제한"
,"갱뱃지특별"
,"도플희귀"
,"쵸파희귀"
,"시라호시초월"
,"사보희귀"
,"모리아전설"
,"지우개가더블!"
,"숙제가더블!"
,"카르가라전설"
,"루치전설"
,"강제영원"
,"상디희귀"
,"코비변이"
,"드래곤불멸"
,"핸콕희귀"
,"벤베희귀"
,"아인제한"
,"센토마루희귀"
,"제파전설"
,"도킹특별"
,"류마히든"
,"카르가라전설"
,"상디초월"
,"바르톨전설"
,"프랑키안흔함"
,"시류히든"
,"킬러히든"
,"샹크스초월"
,"폐문클리어"
,"나미전설"
,"루치초월"
,"시류희귀"
,"샹크스전설"
,"킬러특별"
,"로우초월"
,"황금지우개"
,"크로커특별"
,"타시기초월"
,"마르코전설"
,"방주맥심히든"
,"크래커전설"
,"나이트메어전설"
,"징베전설"
,"오즈희귀"
,"이나즈마특별"
,"에이스영원"
,"크로커제한"
,"모리아전설"
,"에이스안흔함"
,"비비희귀"
,"제트불멸"
,"비비영원"
,"미호크희귀"
,"루피초월"
,"센고쿠전설"
,"검수초월"
,"우솝희귀"
,"킨에몬히든"
,"나미초월"
,"레일리전설"
,"쿠마특별"
,"레이쥬전설"
,"에이스특별"
,"페로나희귀"
,"코비전설"
,"센고쿠불멸"
,"로빈특별"
,"프랑키초월"
,"로우특별"
,"키드희귀"
,"캐럿히든"
,"가반불멸"
,"루치특별"
,"쵸파초월"
,"+1"
,"파괴왕"
,"징베초월"
,"반더희귀"
,"아카이누히든"
,"핸콕전설"
,"후지토라전설"
,"류마희귀"
,"나미전설"
,"사보히든"
,"에이스전설"
,"레일리전설"
,"레일리불멸"
,"핸콕영원"
,"마르코희귀"
,"시키전설"
,"로우희귀"
,"아카이누희귀"
,"스쿼드특별"
,"캐럿변이"
,"루피JET전설"
,"죠즈희귀"
,"에넬특별"
,"나미특별"
,"사보초월"
,"상디특별"
,"압살롬"
,"키자루희귀"
,"징베특별"
,"빅맘불멸"
,"쿠마전설"
,"레이쥬전설"
,"핸콕전설"
,"토키전설"
,"가드포인트특별"
,"우솝특별"
,"키드특별"
,"제파전설"
,"이나즈마안흔함"
,"지정지우개"
,"랜덤유닛"
,"라분전설"
,"루피특별"
,"페로나안흔함"
,"레베카히든"
,"바질특별"
,"이완희귀"
,"미호크영원"
,"로빈초월"
,"바제스희귀"
,"아카이누초월"
,"브룩희귀"
,"토키전설"
,"로빈안흔함"
,"조로전설"
,"검수전설"
,"카쿠희귀"
,"강제불멸"
,"올하도"
,"랜덤초월"
,"랜덤불멸"
,"샹크스희귀"
,"검수전설"
,"조로귀기특별"
,"저격왕안흔함"
,"내동료가되라!"
,"아오키지히든"
,"바르톨희귀"
,"카타구리제한"
,"트래져헌터"
,"드래곤전설"
,"베르고히든"
,"레일리희귀"
,"스모커전설"
,"써니호히든"
,"시노부전설"
,"에이스변이"
,"리롤금지"
,"바질초월"
,"드래곤전설"
,"오뎅영원"
,"루피기어포스초월"
,"엑드희귀"
,"네코마무시전설"
,"키드초월"
,"킹전설"
,"킹제한"
};*/
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


        /*string[] cho = new string[] {
"도플라밍고 초월"
,"시라호시 초월"
,"샹크스 초월"
,"로우 초월"
,"아카이누 초월"
,"아오키지 초월"
,"키자루 초월"
,"검은 수염 초월"
,"징베 초월"
,"브룩 초월"
,"사보 초월"
,"쵸파 초월"
,"우솝 초월"
,"조로 초월"
,"루피 초월"
,"상디 초월"
,"나미 초월"
,"로빈 초월"
,"프랑키 초월"
,"바질 초월"
,"후지토라 초월"
,"타시기 초월"
,"루치 초월"
,"기어포스 초월"
,"키드초월"};
        string[] bul = new string[] {
"레일리 불멸"
,"로져 불멸"
,"가반 불멸"
,"센고쿠 불멸"
,"제파 불멸"
,"흰수염 불멸"
,"시키 불멸"
,"드래곤 불멸"
,"거프 불멸"
,"빅맘 불멸"
,"카이도우 불멸"};
        string[] young = new string[] {
"에이스 영원함"
,"핸콕 영원함"
,"미호크 영원함"
,"카벤디슈 영원함"
,"버기 영원함"
,"비비 영원함"
,"오뎅 영원함"};
        string[] ze = new string[] {
"레드필드 제한됨"
,"크로커다일 제한됨"
,"카타구리 제한됨"
,"에넬 제한됨"
,"아인 제한됨"
,"시노부 제한됨"
,"레베카 제한됨"
,"킹 제한됨"};*/
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
        int sukCount = 0;
        private void button6_Click(object sender, EventArgs e)
        {
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

                /*while (true)
                {
                    int i = 0;
                    int jungindex = 2;
                    for (int j = 1; j < jung.Count; j++)
                    {
                        if (jung[i].Contains(jung[j]))
                        {
                            jung[i]=jung[i].Replace(jung[i], jung[i] + "x" + jungindex);
                            jungindex++;
                            jung.RemoveAt(j);
                        }
                    }
                    i++;
                    if (i == jung.Count)
                        break;
                }
                for(int i = 0; i < jung.Count; i++)
                {
                    int jungindex = 2;
                    for (int j= 1; j < jung.Count; j++)
                    {
                        if (jung[i].Contains(jung[j]))
                        {
                            jung[i].Replace(jung[i], jung[i] + "x"+jungindex);
                            jung.RemoveAt(j);
                            jungindex++;
                        }
                    }
                }*/

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

            /*            var fs2 = new FileStream(filejung, FileMode.Open);
                        var sr2 = new StreamReader(fs2);

                        jung.Clear();

                        while (sr2.EndOfStream == false)
                        {
                            string data = sr2.ReadLine();
                            data = data.TrimEnd();
                            string[] junglee = data.Split(new char[] { ' ' });
                            for (int i = 0; i < junglee.Length; i++)
                            {                    
                                jung.Add(junglee[i]);
                            }
                        }

                        sr2.Close();
                        fs2.Close();*/


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
