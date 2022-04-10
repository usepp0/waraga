using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = "C#.советы";
            string insertText = "Народные ";
            string bookTitle = partBookTitle.Insert(3, insertText);
           listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";
            // Удаляем подстроку с третьей позиции
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookTitle = "C#.Народные советы";
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = "око";
            string str2 = "Царь-колокол";
            int i = str2.IndexOf(str1);
            // Проверяем, входит ли строка око в слово Царь-колокол
            if (i > 0) listBox1.Items.Add(str1 + " входит в строку " + str2);
            else listBox1.Items.Add(str1 + " не входит в строку " + str2);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString(); // получим 5 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Создаем строку из 5 звездочек
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void button6_Click(object sender, EventArgs e)
        {
                string AutoName;
                AutoName = "BMW";
                textBox1.Text =
                String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }

        private void button7_Click(object sender, EventArgs e)
        {          
                // Задаем цвет
                Color clr = Color.Blue;
                // Получим имя выбранного цвета
                textBox1.Text =
                (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
                // Обратная задача. Конвертируем название цвета Green в объект Color
                clr = (Color)TypeDescriptor.GetConverter(
                typeof(Color)).ConvertFromString("Green");
                // Закрашиваем форму в выбранный цвет
                this.BackColor = clr;           
        }
        public void SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            MessageBox.Show(string.Concat("Hello, ", name));
        }
        private void button8_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentNullException("name");
                MessageBox.Show(string.Concat("Hello, ", name));           
        }
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(
 System.Text.StringBuilder pszOut,
 string pszSrc,
 Int32 cchMax,
 Int32 dwFlags);
        private void button14_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        // Исходная строка. Для большего удобства добавлено несколько пробелов
        // в конец строки
        private string scrollText = "C#.Народные советы ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Удаляем один символ слева и прибавляем его с правой стороны
            scrollText = scrollText.Substring(1, (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            public static string ReverseString(string str)
            {
                // Проверка на непустоту строки.
                if (string.IsNullOrEmpty(str))
                {
                    return str;
                }
                // Создадим объект StringBuilder с нужной длиной.
                StringBuilder revStr = new StringBuilder(str.Length);
                // Перебираем в цикле все символы
                // и присоединяем каждый символ к StringBuilder
                for (int count = str.Length - 1; count > -1; count--)
                {
                    revStr.Append(str[count]);
                }
                // Возвращаем перевернутую строку
                return revStr.ToString();
            }
            private void butReverseCS_Click(object sender, EventArgs e)
            {
                textBox1.Text = ReverseString(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            private void butReverseVB_Click(object sender, EventArgs e)
            {
                // Взять текст из текстового поля
                // Например, А роза упала на лапу Азора
                string myString = textBox1.Text;
                // Используем встроенную функцию Visual Basic
                textBox1.Text = Strings.StrReverse(myString);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Старт";
            }
        }
        public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            this.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("строка 1");
            sb.Append("строка 2");
            this.Text = sb.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show(today.Date.ToLongDateString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Измеряем производительность для UtsNow
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
            // Аналогичная проверка производительности для Now
            DateTime dt = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            MessageBox.Show(mydate.ToShortDateString());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9); // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата
                                                        // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
            FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }
        // Наш собственный метод вычисления разницы в датах
        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            string howdays = DaysDiff(DateTime.Today,
 new DateTime(1966, 07, 27)).ToString();
            MessageBox.Show("Со дня моего дня рождения прошло: " + howdays);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            MessageBox.Show(
             String.Format("{0} является високосным годом: {1}",
             DateTime.Now.Year, leapYear));
        }
        /// <summary>
        /// Алгоритм для вычисления католической Пасхи
        /// http://snippets.dzone.com/posts/show/765
        /// </summary>
        /// <param name="year">Год</param>
        /// <returns>Пасха</returns>
        public static DateTime EasterDate(int year)
        {
            int Y = year;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int month = (h + L - 7 * m + 114) / 31;
            int day = ((h + L - 7 * m + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day);
            return dt;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            // когда была католическая Пасха в 2006 году
            MessageBox.Show(EasterDate(2006).ToLongDateString());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2); // возвратит 100
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // Преобразуем в восьмеричное значение
            MessageBox.Show(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение
            MessageBox.Show(Convert.ToString(myValue, 16));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // введите в текстовое поле любое число или слово
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("Является ли " + numstring + " числом: " + bResult1);
        }
        // Пишем собственную функцию IsNumeric на чистом C#
        static bool IsNumeric(object Expression)
        {
            // Возвращаемое значение
            bool isNum;
            // Переменная, используемая в качестве параметра
            // в методе TryParse
            double retNum;
            // Метод TryParse конвертирует строку в заданный стиль
            // и локальный формат.
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Является ли " + textBox1.Text +
 " числом: " + IsNumeric(textBox1.Text));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            // Уникальный идентификатор с дефисами
            //MessageBox.Show(newGuid.ToString());
            // Уникальный идентификатор без дефисов
            textBox1.Text = newGuid.ToString("N");
        }
        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };
        private void button32_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // Перечисляем все значения перечисления
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // Получаем массив строк, содержащих все цвета в системе
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            listBox1.Items.Clear();
            // Выводим все имена в список
            listBox1.Items.AddRange(allcolors);
            // Другой вариант
            //foreach (string s in allcolors)
            //{
            // listBox1.Items.Add(s);
            //} 
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor), listBox1.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }
    }

    private void button9_Click(object sender, EventArgs e)
        {
            private void butReverseVB_Click(object sender, EventArgs e)
        {
                // Взять текст из текстового поля
                // Например, А роза упала на лапу Азора
                string myString = textBox1.Text;
                // Используем встроенную функцию Visual Basic
                textBox1.Text = Strings.StrReverse(myString);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            public static string ReverseString(string str)
            {
                // Проверка на непустоту строки.
                if (string.IsNullOrEmpty(str))
                {
                    return str;
                }
                // Создадим объект StringBuilder с нужной длиной.
                StringBuilder revStr = new StringBuilder(str.Length);
                // Перебираем в цикле все символы
                // и присоединяем каждый символ к StringBuilder
                for (int count = str.Length - 1; count > -1; count--)
                {
                    revStr.Append(str[count]);
                }
                // Возвращаем перевернутую строку
                return revStr.ToString();
            }
            private void butReverseCS_Click(object sender, EventArgs e)
            {
                textBox1.Text = ReverseString(textBox1.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {           
            [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern bool PathCompactPathEx(
             System.Text.StringBuilder pszOut,
             string pszSrc,
             Int32 cchMax,
             Int32 dwFlags);
            private void button1_Click(object sender, EventArgs e)
            {
                // длинный путь к файлу
                string strPathFile =
                "c:/program files/My SuperProgram/skins/sample.txt";
                StringBuilder sb = new StringBuilder(260);
                // оставляем 20 символов, остальное заменяем многоточием
                bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
                // Выводим результат в текстовое поле
                textBox1.Text = sb.ToString();
            }
        }
    }
