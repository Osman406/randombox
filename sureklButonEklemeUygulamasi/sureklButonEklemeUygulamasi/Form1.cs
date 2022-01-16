using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sureklButonEklemeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rastgele = new Random();
        int width, height;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button eklenecek = button_ekle(width, height);
            panel1.Controls.Add(eklenecek);
            int x = rastgele.Next(panel1.Width - eklenecek.Width);
            int y = rastgele.Next(panel1.Height - eklenecek.Height);
            eklenecek.BringToFront();
            eklenecek.Location = new Point(x, y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(numericUpDown1.Value);
            height = Convert.ToInt32(numericUpDown2.Value);
            bool durum = timer1.Enabled;
            if (durum==true)
            { 
                timer1.Stop();
                button1.Text="Üretime Başla";
            }
            else
            {
                timer1.Start();
                button1.Text = "Üretimi Durdur";
            }
        }

        private Button button_ekle(int genislik,int yukseklik) {
            Button btn = new Button();
            btn.Width = genislik;
            btn.Height = yukseklik;
            btn.BackColor = Color.FromArgb(rastgele.Next(255), rastgele.Next(255), rastgele.Next(255));
            return btn;

        
        }
    }
}
