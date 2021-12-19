using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();      //dama tahtası için oluşturduğumuz kodların metodu.
        }

        private void GenerateButtons()
        {
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My Button";
            //this.Controls.Add(button);  //Controls.Add = Butonu ekrana koy demek.

            Button[,] buttons = new Button[8, 8];    //8'e 8'lik bir buton döngümüz var.
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)      //0. boyutun en büyük alabileceği değer 7'dir dedik burada. 8 satır için bir değer oluşturduk.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)  //İlk 8 butonu tanımladığımız döngü.
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    left += 50;         //butonları sola doğru kaydırdık. her butonu 50 birim sola kaydırıyoruz.
                    if ((i + j) % 2 == 0)     //arkaplan renkleri için oluşturduğumuz algoritma.
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }   //Burada ilk satır biter ve satır sonunun işlemlerini tanımlarız.
                top += 50;  //ikinci satıra geçtiğinde 50 birim arttır.
                left = 0;
            }
        }
    }
}
