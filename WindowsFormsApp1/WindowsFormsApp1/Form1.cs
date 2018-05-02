using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        String rechnen;
        List<int> iList = new List<int>();
        List<string> lablelist = new List<string>();
        int[] test;
        int Zahl1;
        int Zahl2;
        int i = 0;
        int Enter;
        char Operator;
        string combindedString;
        string combinedlable;
        public Form1()
		{
			InitializeComponent();
            

		}

        private void button1_Click(object sender, EventArgs e)
        {
            
            iList.Add(1);
            lablelist.Add("1");
            print();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            iList.Add(2);
            lablelist.Add("2");
            print();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            equal();
            Zahl1 = Convert.ToInt32(combindedString) + Zahl2;
            // Zahl1 = Convert.ToInt32(combindedString) + Convert.ToInt32(label1.Text);
            Operator = '+';
            iList.Clear();
            lablelist.Add("+");
            printlable();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            iList.Add(3);
            lablelist.Add("3");
            print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iList.Add(4);
            lablelist.Add("4");
            print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iList.Add(5);
            lablelist.Add("5");
            print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iList.Add(6);
            lablelist.Add("6");
            print();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iList.Add(7);
            lablelist.Add("7");
            print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iList.Add(8);
            lablelist.Add("8");
            print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iList.Add(9);
            lablelist.Add("9");
            print();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            iList.Add(0);
            lablelist.Add("10");
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
            Zahl2 = Convert.ToInt32(combindedString);
            if (Operator == '+')
            {
                Enter = Zahl1 + Zahl2;
            }
            ergebnis.Text = Convert.ToString(Enter);
            label1.Text = Convert.ToString(Enter);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            iList.Clear();
            combindedString = "";
            ergebnis.Text = "";
        }

        private void multi_Click(object sender, EventArgs e)
        {

        }
        private void equal()
        {
            Zahl2 = Convert.ToInt32(combindedString);
            if (Operator == '+')
            {
                Enter = Zahl1 + Zahl2;
            }
            ergebnis.Text = Convert.ToString(Enter);
            label1.Text = Convert.ToString(Enter);
        }
    }
}
