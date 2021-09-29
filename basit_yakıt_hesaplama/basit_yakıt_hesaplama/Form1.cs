using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_yakıt_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lpg, benzin, dizel;

            lpg = 4.72;
            benzin = 7.82;
            dizel = 7.72;
            double sonuc;

            double verilenyakıt;

            verilenyakıt = Convert.ToDouble(textBox1.Text);

            textBox2.Text = lpg.ToString();



            if(listBox1.SelectedIndex==0)
            {

                sonuc = dizel * verilenyakıt;

                textBox2.Text = sonuc.ToString();


               



            }
            if (listBox1.SelectedIndex == 1)
            {

                sonuc = benzin * verilenyakıt;

                textBox2.Text = sonuc.ToString();






            }

            if (listBox1.SelectedIndex == 2)
            {

                sonuc = lpg * verilenyakıt;

                textBox2.Text = sonuc.ToString();






            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
            
        }
    }
}
