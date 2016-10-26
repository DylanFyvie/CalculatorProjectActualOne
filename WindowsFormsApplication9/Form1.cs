using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{/**

 *

 * Name: Dylan Fyvie

 * Teacher: Mr.Hardman

 * Assignment #2, Program #

 * Date Last Modified: 10/19/2016

 *

 */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbGrade1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGrade2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGrade3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGrade4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbGrade5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Grade1 = Convert.ToDouble(txbGrade1.Text);
            double Grade2 = Convert.ToDouble(txbGrade2.Text);
            double Grade3 = Convert.ToDouble(txbGrade3.Text);
            double Grade4 = Convert.ToDouble(txbGrade4.Text);
            double Grade5= Convert.ToDouble(txbGrade5.Text);
            double average = (Grade1 + Grade2 +Grade3+Grade4+Grade5/5);
            lblResult.Text = String.Format("{0,10}:{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}",
            "Grade 1", Grade1, "\nGrade 2", Grade2, "\nGrade 3", Grade3, "\nGrade 4", Grade4, "\nGrade 5", Grade5, "\nAverage", average);

        }
    }
}
