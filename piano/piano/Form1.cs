using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piano
{

    public partial class Piano : Form
    {
        int ton = 1020;
        int dlugosc = 100;



        


        public Piano()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dlugosc2.Checked = true;
            tonacja3.Checked = true;

            Random rnd = new Random();   //aby bylo ciekawiej - generowanie melodyjki na wstępie z przypadkowym dźwiękiem
            int przypadkowy = rnd.Next(500, 2500);
            Console.Beep(przypadkowy, 100);
            Console.Beep(1500, 100);
            Console.Beep(2000, 100);
            Console.Beep((przypadkowy+300), 200);
            Console.Beep(1000, 800);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dlugosc = 200;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dlugosc = 400;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dlugosc = 800;
        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.Beep(ton, dlugosc);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 400, dlugosc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 600, dlugosc);
        }



        private void button14_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1000, dlugosc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1200, dlugosc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1400, dlugosc);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1600, dlugosc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1800, dlugosc);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2000, dlugosc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2200, dlugosc);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2400, dlugosc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2600, dlugosc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2800, dlugosc);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 3000, dlugosc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 3200, dlugosc);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 3600, dlugosc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 3800, dlugosc);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tonacja1_CheckedChanged(object sender, EventArgs e)
        {
            ton = 500;
        }

        private void tonacja2_CheckedChanged(object sender, EventArgs e)
        {
            ton = 750;
        }

        private void tonacja3_CheckedChanged(object sender, EventArgs e)
        {
            ton = 1000;
        }

        private void tonacja4_CheckedChanged(object sender, EventArgs e)
        {
            ton = 1250;
        }

        private void tonacja5_CheckedChanged(object sender, EventArgs e)
        {
            ton = 1500;
        }

        private void info_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("by mlawicki \n github.com/mlawicki");
        }
    }
}
