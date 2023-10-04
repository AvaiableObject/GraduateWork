using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Threading;
using System.Globalization;

namespace VKRProject
{
    public partial class VKR : Form
    {
        //Создаем объект класса
        private N_adicDecomposition decomposition = new N_adicDecomposition();
        private ManualResetEvent _manualEvent = new ManualResetEvent(true);
        public VKR()
        {
            InitializeComponent();
        }

        //Формат в полях ввода
        private void textBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            text = Regex.Replace(text, "[^0-9]", string.Empty);
            text = text.TrimStart('0');
            if (text == string.Empty)
                text = "0";
            (sender as TextBox).Text = text;
        }

        //Рекуретная функция НОД
        static BigInteger GCD(BigInteger x, BigInteger y)
        {
            if (y == 0)
                return x;
            else
                return GCD(y, x % y);
        }

        //Поиск обратного элемента по модулю
        static (BigInteger, BigInteger, BigInteger) gcdex(BigInteger a, BigInteger b)
        {
            if (a == 0)
                return (b, 0, 1);
            (BigInteger gcd, BigInteger x, BigInteger y) = gcdex(b % a, a);
            return (gcd, y - (b / a) * x, x);
        }
        static BigInteger inverse(BigInteger a, BigInteger m)
        {
            (BigInteger g, BigInteger x, BigInteger y) = gcdex(a, m);
            return g > 1 ? 0 : (x % m + m) % m;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
            int N = int.Parse(textBoxN.Text);
            int u = int.Parse(textBoxU.Text);
            int o = int.Parse(textBoxQ1.Text);
            int p2 = int.Parse(textBoxQ2.Text);
            button1.Enabled = true;
            button2.Enabled = false;

            //progressBar.Value = 0;

            //double progress = 100d / (p2 - o);
            //double progressValue = progress;
            string outputText = "";

            Thread thread = new Thread(() =>
            {
                for (int p = o; p < p2; p++)
                {
                    currentQ.Text = p.ToString();
                    if ((GCD(N, p) != 1))
                    {
                        if (checkBox4.Checked)
                            continue;
                        textBoxMain.Text += $"N = {N}, u = {u}, q = {p}\r\nНОД (N, q) != 1 \r\n\r\n";
                        continue;
                    }
                    int count; // Счётчик членов последовательности
                    _manualEvent.WaitOne();
                    //Ищем n исходя из эквивалентности N^n == 1 mod q
                    int n = 1;
                    BigInteger temp = N;
                    for (int i = 1; i < p; i++)
                    {
                        if ((temp % p) == 1)
                        {
                            break;
                        }
                        if (N == p - 1)
                        {
                            break;
                        }
                        temp *= N;
                        n++;
                    }

                    //Считаем A для построения u_i
                    int a = p % N;

                    BigInteger A = N - inverse(a, N);

                    BigInteger[] b = new BigInteger[n];
                    BigInteger[] ui = new BigInteger[n];
                    BigInteger[] si = new BigInteger[n];

                    BigInteger SN = 0;
                    BigInteger Ni = 1;

                    temp = N;
                    for (int j = 1; j < n - 1; j++)
                    {
                        temp *= N;
                    }
                    b[0] = u;
                    for (int j = 1; j < n; j++)
                    {
                        b[j] = u * temp % p;
                        temp /= N;
                    }

                    //Считаем последовательность u_i и сумму S(N)
                    for (int j = 0; j < n; j++)
                    {
                        si[j] = b[j] % N;
                        ui[j] = (A * si[j]) % N;
                        SN += ui[j] * Ni;
                        Ni *= N;
                    }

                    //Находим рациональное число r (h - числитель, m - знаменатель)
                    temp = N;
                    for (int j = 1; j < n; j++)
                    {
                        temp *= N;
                    }
                    BigInteger d = GCD(SN, temp - 1);

                    BigInteger h = -SN / d;
                    BigInteger m = (temp - 1) / d;

                    decomposition = new N_adicDecomposition(h, m, N);
                    BigInteger[] Y = new BigInteger[n];
                    Y = decomposition.Decompose();


                    //Пусть U - последовательность полученная в 1 части,
                    //а Um - полученная посредством циклического сдвига
                    BigInteger[] U = new BigInteger[n];
                    BigInteger[] Um = new BigInteger[n];

                    temp = N;
                    for (int j = 1; j < n; j++)
                    {
                        temp *= N;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        U[i] = ui[i];
                        Um[i] = ui[i];
                    }
                    BigInteger y = h;

                    outputText += $"N = {N}, u = {u}, q = {p}\r\n";

                    outputText += $"u_i = ";
                    for (int i = 0; i < n; i++)
                    {
                        outputText += $"{ui[i]} ";
                    }
                    outputText += $"\r\n";

                    outputText += $"d = {d}\r\n";

                    //Вывод n, r и k_i по желанию пользователя
                    if (checkBox1.Checked)
                    {
                        outputText += $"n = {n}\r\nr = {h}/{m}\r\n";

                        //Подсчёт членов последовательности
                        for (int i = 0; i < N; i++)
                        {
                            if (GCD(N, p) != 1)
                            {
                                outputText += $"НОД N и q = q\r\n";
                                break;
                            }
                            count = 0;
                            for (int j = 0; j < n; j++)
                            {
                                if (ui[j] == i)
                                {
                                    count++;
                                }
                            }
                            outputText += $"Количество {i} в последовательности равно: {count}\r\n";
                        }
                    }

                    //Вывод разложения дроби по желанию пользователя                
                    if (checkBox3.Checked)
                    {
                        BigInteger q = h / m;
                        BigInteger f = h;
                        if (f > 0)
                        {
                            f = f - ((q + 1) * m);
                        }
                        else if (f < 0)
                        {
                            f = f - (q * m);
                        }
                        outputText += $"N-адическое разложение дроби: {f}/{m} = ";
                        outputText += $"{Y[0]} ";
                        if (Y.Length > 1)
                        {
                            for (int i = 1; i < n; i++)
                            {
                                outputText += $"+ {Y[i]}*{N}^{i} ";
                            }
                            outputText += $"+...\r\n";
                        }
                        else
                            outputText += $"\r\n";
                    }

                    List<double> CbList = new List<double>();
                    List<double> CiList = new List<double>();
                    for (int j = 0; j < n - 1; j++)
                    {
                        BigInteger x = Um[0];
                        SN = 0;
                        Ni = 1;
                        for (int i = 1; i < n; i++)
                        {
                            Um[i - 1] = Um[i];
                        }
                        Um[n - 1] = x;
                        outputText += $"\r\n";
                        //Считаем S(N)

                        for (int i = 0; i < n; i++)
                        {
                            SN += Um[i] * Ni;
                            Ni *= N;
                        }

                        //Находим рациональное число rm (hm - числитель, m - знаменатель)
                        d = GCD(SN, temp - 1);
                        outputText += $"d = {d}\r\n";
                        BigInteger hm = -SN / d;
                        m = (temp - 1) / d;

                        if (checkBox1.Checked)
                        {
                            outputText += $"r = {hm}/{m}\r\n";
                        }
                        //Считаем разность дробей r - rm
                        int new_n = n;
                        y = h - hm;
                        if (GCD(Math.Abs((int)y), m) != 1)
                        {
                            BigInteger gcdYM = GCD(y, m);
                            BigInteger temp1 = N;
                            new_n = 1;
                            y /= gcdYM;
                            m /= gcdYM;

                            for (int i = 1; i < m; i++)
                            {
                                if ((temp1 % m) == 1)
                                {
                                    break;
                                }
                                if (N == m - 1)
                                {
                                    break;
                                }
                                temp1 *= N;
                                new_n++;
                            }
                        }
                        if (checkBox1.Checked)
                        {
                            outputText += $"n = {new_n}\r\n";
                        }
                        outputText += $"Разность дробей r - rm = {y}/{m}\r\n";

                        //Полученные коэффициенты при разложении присваиваем M
                        decomposition = new N_adicDecomposition(y, m, N);
                        BigInteger[] M = new BigInteger[new_n];
                        M = decomposition.Decompose();

                        //Вывод разложения дроби по желанию пользователя                
                        if (checkBox3.Checked)
                        {
                            BigInteger q = y / m;
                            BigInteger f = y;
                            if (f > 0)
                            {
                                f = f - ((q + 1) * m);
                            }
                            else if (f < 0)
                            {
                                f = f - (q * m);
                            }
                            outputText += $"N-адическое разложение дроби: {f}/{m} = ";
                            outputText += $"{M[0]} ";
                            if (M.Length > 1)
                            {
                                for (int i = 1; i < new_n; i++)
                                {
                                    outputText += $"+ {M[i]}*{N}^{i} ";
                                }
                                outputText += $"+...\r\n";
                            }
                            else
                                outputText += $"\r\n";
                        }
                        //Вычисляем Cm
                        //Подсчёт членов последовательности mi
                        BigInteger[] mi = new BigInteger[N];

                        for (int l = 0; l < N; l++)
                        {
                            count = 0;
                            for (int i = 0; i < new_n; i++)
                            {
                                if (M[i] == l)
                                {
                                    count++;
                                }
                            }
                            mi[l] = count;
                        }

                        if (checkBox2.Checked)
                        {
                            for (int l = 0; l < N; l++)
                            {
                                outputText += $"Количество {l} на периоде разложения равно: {mi[l]}\r\n";
                            }
                        }
                        decimal Cb = 1 * (decimal)mi[0];
                        decimal Ci = 0M;
                        for (int i = 1; i < N; i++)
                        {
                            Cb += (decimal)mi[i] * (decimal)Math.Cos(2 * Math.PI * i / N);
                        }
                        for (int i = 1; i < N; i++)
                        {
                            Ci += (decimal)mi[i] * (decimal)Math.Sin(2 * Math.PI * i / N);
                        }
                        CbList.Add((double)Cb);
                        CiList.Add((double)Math.Round(Ci, 5));
                        outputText += $"C_m = {Math.Round(Cb, 5)} + i * {Math.Round(Ci, 5)}\r\n";
                    }
                    outputText += $"\r\n\r\n";
                    //progressBar.Value = (int)progress;
                    //progress += progressValue;

                    if (checkBox4.Checked)
                    {
                        decimal CmABS = 0;
                        for (int i = 0; i < CbList.Count; i++)
                        {
                            if ((decimal)Math.Sqrt(CbList[i] * CbList[i] + CiList[i] * CiList[i]) > numericUpDownLimit.Value)
                                outputText = String.Empty;
                            if ((decimal)Math.Sqrt(CbList[i] * CbList[i] + CiList[i] * CiList[i]) > CmABS)
                                CmABS = (decimal)Math.Sqrt(CbList[i] * CbList[i] + CiList[i] * CiList[i]);
                        }
                        if (outputText != String.Empty)
                        {
                            textBoxMain.Text += $"Для q = {p} выполняется ограничение \r\nn = {n}\r\nНаибольшее значение |Cm| = {CmABS}\r\n\r\n";
                        }
                        /*else
                        {
                            textBoxMain.Text += $"Для q = {p} ограничение не выполняется \r\nn = {n}\r\nНаибольшее значение |Cm| = {CmABS}\r\n\r\n";
                        }*/
                    }
                    else
                    {
                        textBoxMain.Text += outputText;
                    }

                    outputText = "";
                }
                button1.Enabled = false;
                button2.Enabled = false;
                //progressBar.Value = 0;
            });
            thread.Start();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textBoxMain.Text);
                streamWriter.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _manualEvent.Reset();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _manualEvent.Set();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void textBoxQ1_ValueChanged(object sender, EventArgs e)
        {
            textBoxQ2.Minimum = textBoxQ1.Value + 1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDownLimit.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                numericUpDownLimit.Enabled = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }
    }
}
