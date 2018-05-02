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
        int[] test;
        int i = 0;
        public Form1()
		{
			InitializeComponent();
            

		}

        private void button1_Click(object sender, EventArgs e)
        {
            ergebnis.Text = "1";
            test[i] = 1;
            i++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ergebnis.Text = "2";
            test[i] = 2;
            i++;
        }
    }
}
