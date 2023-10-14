using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Int_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pictureBox2.BackColor = System.Drawing.Color.Transparent;

            axWindowsMediaPlayer1.uiMode = "none"; // Убираем интерфейс WMP
            axWindowsMediaPlayer1.stretchToFit = true; // Растягиваем видео, чтобы оно заполнило форму

            // Загружаем видео файл
            axWindowsMediaPlayer1.URL = @"C:\Users\Konstantin\Documents\GitHub\Ресурсы\document_5280495877629165238.mp4";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Если пользователь нажимает клавишу Esc
            {
                axWindowsMediaPlayer1.fullScreen = false; // Выход из полноэкранного режима
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
