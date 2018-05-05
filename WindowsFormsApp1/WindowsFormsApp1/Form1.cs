using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        int i = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );

        String rechnen;
        bool nodelet = false;
        bool point = false;
        bool erstezahl = false;
        List<double> iList = new List<double>();
        List<string> lablelist = new List<string>();
        double das;
        int[] test;
        double Zahl1;
        double Zahl2=0;
        
        double Enter;
        char Operator;
        string combindedString;
        string combinedlable;
        public Form1()
		{
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void nodelete()
        { nodelet = false; }
        private void button1_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .1);
                point = false;
               }
            else
            {  iList.Add(1); }
            lablelist.Add("1");
            print();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .2);
                point = false;
            }else
            iList.Add(2);
            lablelist.Add("2");
            print();
        }

       
       
        private void button3_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .3);
                point = false;
            }else
            iList.Add(3);
            lablelist.Add("3");
            print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .4);
                point = false;
            }else
            iList.Add(4);
            lablelist.Add("4");
            print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .5);
                point = false;
            }else
            iList.Add(5);
            lablelist.Add("5");
            print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .6);
                point = false;
            }else
            iList.Add(6);
            lablelist.Add("6");
            print();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .7);
                point = false;
            }else
            iList.Add(7);
            lablelist.Add("7");
            print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .8);
                point = false;
            }else
            iList.Add(8);
            lablelist.Add("8");
            print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .9);
                point = false;
            }else
            iList.Add(9);
            lablelist.Add("9");
            print();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nodelete();
            if (point)
            {
                double test = Convert.ToDouble(combindedString);
                iList.Clear();
                iList.Add(test + .0);
                point = false;
            }else
            iList.Add(0);
            lablelist.Add("0");
            print();
        }
        private void print()
        {
            combindedString = string.Join("", iList);
            ergebnis.Text = combindedString;
        }
        private void printlable()
        {
            combinedlable = string.Join("", lablelist);
            label1.Text = combinedlable;
        }

        private void enter_Click(object sender, EventArgs e)
        {

            //ergebnis.Text = Convert.ToString(das);
            //label1.Text = Convert.ToString(das);
            nodelet = true;
            if (erstezahl)
                Zahl2 = Convert.ToDouble(combindedString);
            if (Operator == '+')
            {
                Enter = Zahl1 + Zahl2;
            }
            if (Operator == '-')
            {
                Enter = Zahl1 - Zahl2;
            }
            if (Operator == '*')
            {
                Enter = Zahl1 * Zahl2;
            }
            if (Operator == '/')
            {
                Enter = Zahl1 / Zahl2;
            }
            ergebnis.Text = Convert.ToString(Enter);
            label1.Text = Convert.ToString(Enter);
            iList.Clear();

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            iList.Clear();
            combindedString = "";
            combinedlable = "";
            ergebnis.Text = "";
            lablelist.Clear();
            label1.Text = "0";
            Zahl1 = 0;
            Zahl2 = 0;
            erstezahl = false;
            point = false;

        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (erstezahl)
            {
                das = equal();
            }

            else
            {
                Zahl1 = Convert.ToDouble(combindedString);
            }

            Operator = '*';
            label1.Text = Convert.ToString(Zahl1) + "*" + Convert.ToString(Zahl2);
            iList.Clear();
            lablelist.Add("*");
            printlable();
            erstezahl = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
          
            if (erstezahl)
            {
                
                das = equal();
         
            }

            else
            {
              
                Zahl1 = Convert.ToDouble(combindedString);
            }
          
            Operator = '+';
            label1.Text = Convert.ToString(Zahl1) + "+" + Convert.ToString(Zahl2);
            iList.Clear();
            lablelist.Add("+");
            printlable();
            erstezahl = true;
        }
        private double equal()
        {
            if (erstezahl)
            {
                Zahl2 = Convert.ToDouble(combindedString);
            }
                if (Operator == '+')
            {
                Enter = Zahl1 + Zahl2;
                Zahl1 = Enter;
            }
            if (Operator == '-')
            {
                Enter = Zahl1 - Zahl2;
                Zahl1 = Enter;
            }
            if (Operator == '*')
            {
                Enter = Zahl1 * Zahl2;
                Zahl1 = Enter;
            }
            if (Operator == '/')
            {
                Enter = Zahl1 / Zahl2;
                Zahl1 = Enter;
            }
            iList.Clear();
            ergebnis.Text = Convert.ToString(Enter);
            label1.Text = Convert.ToString(Enter);
            return Enter;
        }

        private void sub_Click(object sender, EventArgs e)
        {

            if (erstezahl)
            {
                das = equal();
            }

            else
            {
                Zahl1 = Convert.ToDouble(combindedString);
            }
   
            Operator = '-';
            label1.Text = Convert.ToString(Zahl1) + "-" + Convert.ToString(Zahl2);
            iList.Clear();
            lablelist.Add("-");
            printlable();
            erstezahl = true;
        }

        private void devide_Click(object sender, EventArgs e)
        {
            if (erstezahl)
            {
                das = equal();
            }

            else
            {
                Zahl1 = Convert.ToDouble(combindedString);
            }

            Operator = '/';
            label1.Text = Convert.ToString(Zahl1) + "/" + Convert.ToString(Zahl2);
            iList.Clear();
            lablelist.Add("/");
            printlable();
            erstezahl = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            point = true;
            double test = Convert.ToDouble(combindedString);
           
            lablelist.Add(",");
            print();
            ergebnis.Text = Convert.ToString(test) + ",";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (!nodelet)
            {
                iList.Clear();
                String test = string.Join("", lablelist);
                lablelist.Clear();
                if (test.Length - 1 != Operator)
                {
                    test = test.Remove(test.Length - 1);
                    lablelist.Add(test);
                }
                //label1.Text = test;
                ergebnis.Text = ergebnis.Text.Remove(ergebnis.Text.Length - 1);
                if (ergebnis.Text != "")
                {
                    iList.Add(Convert.ToDouble(ergebnis.Text));
                }
                print();
            }
        }
    }
}
