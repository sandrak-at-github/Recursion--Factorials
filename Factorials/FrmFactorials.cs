using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Factorials
{
    public partial class FrmFactorials : Form
    {
        public FrmFactorials()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // calculate the factorials of 0 through 10

            LstFactorials.Items.Clear();
            
            for (long counter = 0; counter <= 10; counter++)
            {
                LstFactorials.Items.Add(counter.ToString() + "\t" + Factorial(counter).ToString());
            }
        }

        private long Factorial(long number)
        {
            // base case                               
            if (number <= 1)
            {
                return 1;
            }
            // recursion step                          
            else
            {
                return number * Factorial(number - 1);
            }
        }
    
    }
}