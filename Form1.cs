using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_f_Click(object sender, EventArgs e)
        {
            convertFromFahrenheight();

        }

        private void txt_f_TextChanged(object sender, EventArgs e)
        {
            convertFromFahrenheight();
        }

        private void convertFromFahrenheight() {

            float f = 0;

            try
            {
                f = float.Parse(txt_f.Text.ToString());
            }

            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float c = 0;
            c = 5f / 9f * (f - 32);
            float k = c + 273;


            txt_c.Text = c.ToString();
            txt_k.Text = k.ToString();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void convertFromCelsius() {
            float c = 0;
            try {
                c = float.Parse(txt_c.Text.ToString());
            }
            catch {
                MessageBox.Show("Try only numbers");
            }

            float f = 0;
            f = c * 1.8f + 32;
            float k = c + 273;

            txt_f.Text = f.ToString();
            txt_k.Text = k.ToString();

        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromKelvin() {
            float k = 0;

            try {
                k = float.Parse(txt_k.Text.ToString());
            }
            catch {
                MessageBox.Show("Try only numbers ");
            }

            float c = 0;
            c = k - 273;
            float f = 1.8f * c + 32;
            txt_c.Text = c.ToString();
            txt_f.Text = f.ToString();
        }
    }
}
