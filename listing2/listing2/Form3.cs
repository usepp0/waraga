using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listing2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Вычисляем размеры экрана
            Bitmap screenPicture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(screenPicture))
            {
                // копируем изображение всего экрана
                g.CopyFromScreen(0, 0, 0, 0, screenPicture.Size);
            }
            pictureBox1.Image = screenPicture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Определяем размеры экрана
            textBox1.Text = Screen.PrimaryScreen.Bounds.Width.ToString() +
            "x" + Screen.PrimaryScreen.Bounds.Height.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Определяем рабочую область экрана
            textBox1.Text = Screen.GetWorkingArea(this).Width.ToString() + "x" +
            Screen.GetWorkingArea(this).Height.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Свернем форму программно
            WindowState = FormWindowState.Minimized;
        }
    }
}
