﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public int totalvalue { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb2pnd_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");

            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl2pnd.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl2pnd.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 200;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl1p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl1p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 1;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl1pnd.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl1pnd.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 100;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl50p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl50p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 50;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl20p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl20p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 20;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl10p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl10p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 10;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl5p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl5p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 5;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("You have not set the cost of a credit");
            }
            else
            {

                int currentvalue;

                if (int.TryParse(lbl2p.Text, out currentvalue))
                {
                    currentvalue = (currentvalue) + 1;

                    lbl2p.Text = currentvalue.ToString();
                }


                double totalvalue;

                if (double.TryParse(textBox1.Text, out totalvalue))
                {
                    totalvalue = (totalvalue) + 2;

                    textBox1.Text = totalvalue.ToString();
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (totalvalue != 0) ;
            {
                double totalvalue = Convert.ToDouble(textBox1);
            }
        }
    }
}