using System;
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
        public double totalvalue { get; private set; }

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
            if (textBox3.Text == "0") // This section of code states that if textbox3 (cost of credits) has the value of "0" then it should display an error message.
            {
                MessageBox.Show("You have not set the cost of a credit");

            }
            else
            {

                int currentvalue; //Here creates the int current value

                if (int.TryParse(lbl2pnd.Text, out currentvalue)) //Here we have the code see if the user input can be a boolean value
                {
                    currentvalue = (currentvalue) + 1; //With every button click we add the corrosponding amount to the variable

                    lbl2pnd.Text = currentvalue.ToString(); //This inputs a text version of the calculation output into the corresponding text box
                }


                double totalvalue; //Here creates the totalvalue double

                if (double.TryParse(textBox1.Text, out totalvalue)) //Here we have the code see if the user input can be a boolean value
                {
                    totalvalue = (totalvalue) + 200; //With every button click we add the corrosponding amount to the variable

                    textBox1.Text = totalvalue.ToString();  //This inputs a text version of the calculation output into the corresponding text box
                }
                double totalvalue2; //Here creates the totalvalue2 double

                if (double.TryParse(textBox2.Text, out totalvalue2)) //Here we have the code see if the user input can be a boolean value
                {
                    totalvalue2 = (totalvalue) / 100; //With every button click we divide the curent totalvalue variable by 100

                    textBox2.Text = totalvalue2.ToString();  //This inputs a text version of the calculation output into the corresponding text box
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text); //Here creates the creditsprice double by converting the user input into a double int

                    double totalcredits = (totalvalue) / (creditsprice); //Here creates the totalcredits double by dividing totalvalue by creditsprice

                    if (double.TryParse(textBox3.Text, out totalcredits)) //Here we have the code see if the user input can be a boolean value
                    {
                        totalcredits = (totalvalue) / creditsprice; //With every button click we divide totalvalue by creditsprice to get totalcredits

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits)); //This sets the int totalcredits2 as totalcredits (which has been converted to int). It has also been rounded to the floor so we dont give extra credits away by rounding up.


                        textBox4.Text = totalcredits2.ToString();  //This inputs a text version of the calculation output into the corresponding text box

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox1.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString(); textBox4.Text = totalcredits.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
                double totalvalue2;
                if (double.TryParse(textBox2.Text, out totalvalue2))
                {
                    totalvalue2 = (totalvalue) / 100;

                    textBox2.Text = totalvalue2.ToString();
                }
                {
                    double creditsprice = Convert.ToDouble(textBox3.Text);

                    double totalcredits = (totalvalue) / (creditsprice);

                    if (double.TryParse(textBox3.Text, out totalcredits))
                    {
                        totalcredits = (totalvalue) / creditsprice;

                        int totalcredits2 = Convert.ToInt16(Math.Floor(totalcredits));


                        textBox4.Text = totalcredits2.ToString();

                    }
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
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void textBox3_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
