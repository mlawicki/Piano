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

            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.C;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                        
                    }
                    break;

                case false:
                    {
                        Console.Beep(ton, dlugosc);                        
                        break;
                    }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Console.Beep(ton + 400, dlugosc);
        }

        private void button2_Click(object sender, EventArgs e)

        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.D;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 600, dlugosc);
                        break;
                    }
            }
        }



        private void button14_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1000, dlugosc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.E;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 1200, dlugosc);
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.F;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 1400, dlugosc);
                        break;
                    }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 1600, dlugosc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.G;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 1800, dlugosc);
                        break;
                    }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2000, dlugosc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.A;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 2200, dlugosc);
                        break;
                    }
            }
                
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Console.Beep(ton + 2400, dlugosc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.H;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 2600, dlugosc);
                        break;
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    {
                        System.IO.Stream str = Properties.Resources.C2;
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();

                    }
                    break;

                case false:
                    {
                        Console.Beep(ton + 2800, dlugosc);
                        break;
                    }
            }
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
            System.Windows.Forms.MessageBox.Show("Piano v 0.9 \n by mlawicki \n github.com/mlawicki");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ton = 1020;
            dlugosc = 100;

            tonacja1.Enabled = true;
            tonacja2.Enabled = true;
            tonacja3.Enabled = true;
            tonacja4.Enabled = true;
            tonacja5.Enabled = true;
            dlugosc1.Enabled = true;
            dlugosc2.Enabled = true;
            dlugosc3.Enabled = true;
            button13.Enabled = true;    //w związku z faktem braku nagranych dźwięków klawiszy czarnych
            button14.Enabled = true;    //oraz dźwięków powyżej gamy podstawowej, będą one czasowo nieaktywne
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button9.Enabled = true;
            button9.BackColor = System.Drawing.Color.White;
            button19.Enabled = true;
            button10.Enabled = true;
            button10.BackColor = System.Drawing.Color.White;


        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tonacja1.Enabled = false;
            tonacja2.Enabled = false;
            tonacja3.Enabled = false;
            tonacja4.Enabled = false;
            tonacja5.Enabled = false;
            dlugosc1.Enabled = false;
            dlugosc2.Enabled = false;
            dlugosc3.Enabled = false;
            button13.Enabled = false; //w związku z faktem braku nagranych dźwięków klawiszy czarnych
            button14.Enabled = false; //oraz dźwięków powyżej gamy podstawowej, będą one czasowo nieaktywne
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button9.Enabled = false;
            button9.BackColor = System.Drawing.Color.Gray;
            button19.Enabled = false;
            button10.Enabled = false;
            button10.BackColor = System.Drawing.Color.Gray;



        }
    }
}
