using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sicaklik = int.Parse(textBox1.Text);

                if(sicaklik < 10)
                {
                    label2.Text = "Hava soğuk";
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                }
                else if ( sicaklik > 30)
                {
                    label2.Text = "Hava sıcak";
                    pictureBox2.Visible= true;
                    pictureBox1.Visible= false;
                    pictureBox3.Visible = false;
                }
                else
                {
                    label2.Text = "Hava güzel";
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

            }
            catch
            {
                MessageBox.Show("Lütfen geçerli sıcaklık değeri gir!");
            }
        }
    }
}
