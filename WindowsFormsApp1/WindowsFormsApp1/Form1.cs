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
        int[] test;
        int Zahl1;
        int Zahl2;
        int i = 0;
        char Operator;
        string combindedString;
        public Form1()
		{
			InitializeComponent();
            

		}

        private void button1_Click(object sender, EventArgs e)
        {
            
            iList.Add(1);
            print();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            iList.Add(2);
            print();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(combindedString);
            Operator = '+';
            iList.Clear();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            iList.Add(3);
            print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iList.Add(4);
            print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iList.Add(5);
            print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iList.Add(6);
            print();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iList.Add(7);
            print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iList.Add(8);
            print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iList.Add(9);
            print();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            iList.Add(0);
            print();
        }
        private void print()
        {
            combindedString = string.Join("", iList);
            ergebnis.Text = combindedString;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Zahl2 = Convert.ToInt32(combindedString);
            if (Operator == '+')
            { ergebnis.Text = Convert.ToString(Zahl1 + Zahl2); } 
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            iList.Clear();
            combindedString = "";
            ergebnis.Text = "";
        }
    }
}
