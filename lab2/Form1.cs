using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        int a = 1;
        Class1 cl1 = new Class1();
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        Button btn10;
        Button btn11;
        Button btn12;
        Button btn13;
        Button btn14;
        Button btn15;
        Button btn16;








        public Form1()
        {
            InitializeComponent();
            cl1.CreateMyButton(btn1, this, "13", 50, 50, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn2, this, "1", 50, 100, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn3, this, "11", 50, 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn4, this, "15", 50, 200, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn5, this, "9", 200, 50, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn6, this, "4", 200, 100, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn7, this, "6", 200, 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn8, this, "10", 200, 200, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn9, this, "14", 350, 50, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn10, this, "12", 350, 100, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn11, this, "7", 350, 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn12, this, "5", 350, 200, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn13, this, "3", 500, 50, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn14, this, "8", 500, 100, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn15, this, "2", 500 , 150, 120, 50, Click_My_Button);
            cl1.CreateMyButton(btn16, this, "16", 500, 200, 120, 50, Click_My_Button);
        }

        private void Click_My_Button(object sender, EventArgs e)
        {
            if ((sender as Button).Text == a.ToString())
            {
                a++;
                (sender as Button).Hide();
            }
            else
            {
                a = 1;
                if (!btn2.Visible)
                {
                    btn2.Show();
                }
                btn3.Show();
                btn4.Show();
                btn5.Show();
                btn6.Show();
                btn7.Show();
                btn8.Show();
                btn9.Show();
                btn10.Show();
                btn11.Show();
                btn12.Show();
                btn13.Show();
                btn14.Show();
                btn15.Show();
                btn16.Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
