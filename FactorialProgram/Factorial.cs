/*
Created by Matthew Ho
Created on 06-10-15
Created for ICS3U
Daily task 3-05
This program calculates factorials `using repeats.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialProgram
{
    public partial class frmFactorialNumbers : Form
    {
        public frmFactorialNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            Double factorialNumber;
            Double factorialAnswer;


            
            this.lstFactorialNumbers.Items.Clear();
            factorialAnswer = 1;
            factorialNumber = Convert.ToDouble(this.txtStartNumber.Text);


            //process
            /*
            do
            {
                factorialCounter = factorialCounter + 1;
                this.lstFactorialNumbers.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;
            } while (factorialNumber != factorialCounter);
            */

            for (int factorialCounter = 1; factorialCounter<= factorialNumber; factorialCounter++)
            {
                this.lstFactorialNumbers.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            this.lblAnswer.Text = Convert.ToString(factorialAnswer);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
