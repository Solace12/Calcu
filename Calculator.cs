using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);

            if (radioButton1.Checked )
            {
                label4.Text = (numA + numB).ToString();         
            }else if (radioButton2.Checked )
            {
                label4.Text = (numA - numB).ToString();
            }else if (radioButton3.Checked)
            {
                label4.Text =(numA * numB).ToString();
            }else if (radioButton4.Checked)
            {
                label4.Text =(numA / numB).ToString();
            }else if (radioButton5.Checked)

                label4.Text=(numA % numB).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green; button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White; button1.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red; button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White; button2.ForeColor = Color.Black;
        }

  
        }
    }

