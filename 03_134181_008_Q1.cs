using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
  
        string operation;
        String[] alp = { "A", "B", "C", "D", "E", "F" };
        double n1, n2, result;
        public Form1()
        {
            InitializeComponent();
        }
        bool isdot(char a)
        {
            if(a=='.')
                return false;
            else
                return true;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button obj = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += obj.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "";
            operation = "+";
            label1.Visible = true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "";
            operation = "-";
            label1.Visible = true;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "";
            operation = "*";
            label1.Visible = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "";
            operation = "/";
            label1.Visible = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox1.Text);
            label1.Text += textBox1.Text;
            textBox1.Text = "";
            if (operation == "+")
                result = n1 + n2;
            else if (operation == "-")
                result = n1 - n2;
            else if (operation == "*")
                result = n1 * n2;
            else if (operation == "/")
                result = n1 / n2;
            textBox1.Text = Convert.ToString(result);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString((char)48);
            label1.Text = "";
            label1.Visible = false;
        }

        private void hex_Click(object sender, EventArgs e)
        {
           double m=17;
            int z=0;
            string b = "";
           m = Convert.ToDouble(textBox1.Text);
            string a="";
            while (m>=16)
            {
                     int v=Convert.ToInt32(m%16);
                     if (v > 9)
                         a += alp[v - 10];
                     else
                     {
                         if(v!=0)
                         a += Convert.ToString(v);
                     }

                z= Convert.ToInt32(m/16);
                int g = z * 16;
                if (g > m)
                    z = z - 1;
                 m=(16*z)/16;
             
            }
            if (m <= 9)
                a += Convert.ToString(m);
           
            else 
                a += alp[Convert.ToInt32(m - 10)];
            for (int i = a.Length-1; i >= 0; i--)
                b += a[i];
                textBox1.Text = b;
           
        }

        private void BIN_Click(object sender, EventArgs e)
        {
            double m=17;
            
            int z=0;
            string b = "";
           m = Convert.ToDouble(textBox1.Text);
            string a="";
            while (m>=2)
            {
                     int v=Convert.ToInt32(m%2);
                         a += Convert.ToString(v);

                z= Convert.ToInt32(m/2);
                int g = z * 2;
                if (g > m)
                    z = z - 1;
                 m=(2*z)/2;
             
            }
 
               a += Convert.ToString(m);
      
            for (int i = a.Length-1; i >= 0; i--)
                b += a[i];
            textBox1.Text = b;
        }

        private void boct_Click(object sender, EventArgs e)
        {
            double m = 17;

            int z = 0;
            string b = "";
            m = Convert.ToDouble(textBox1.Text);
            string a = "";
            while (m >= 8)
            {
                int v = Convert.ToInt32(m % 8);
                a += Convert.ToString(v);

                z = Convert.ToInt32(m / 8);
                int g = z * 8;
                if (g > m)
                    z = z - 1;
                m = (8 * z) / 8;

            }

            a += Convert.ToString(m);

            for (int i = a.Length - 1; i >= 0; i--)
                b += a[i];
            textBox1.Text = b;
       
               
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = "";
            for (int i = 0; i < a.Length - 1; i++)
                b += a[i];
            textBox1.Text = b;
        }
    }
}