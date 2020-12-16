using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x, 2);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x, 16);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x, 10);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x, 8);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x, 3);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x, 2);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {
                
            }
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x, 3);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x, 8);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x, 10);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x, 16);
            }
            catch
            {
                MessageBox.Show("error", "You break my app!!!");
            }
            finally
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
