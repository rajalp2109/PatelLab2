using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatelLab2
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
            txtNum1.Select();
        }
        //Windows Form- Lab 2
        //Name: Rajal Patel
        //Date: 10/03/2022
        //Time: 10:30PM
        //Description: Calculator and Jetskiing in Nova Scotia.

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //pic show and data invisible
            picJetski.Show();
            lblData.Visible= false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //data hide from the label and pic hide
            lblData.Visible = false;
            picJetski.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //data clear from the Num 1, Num 2 , Answer and cursor put in Num1
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblAnswer.Text = "";
            txtNum1.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //put data in label, data label visible and pic hide
            lblData.Text = "My topic is Jet Skiing(seadoo)in Nova Scotia. \"\\n\\n\"Last year I did Jet Ski Halifax Harbour Waterfront, which was an amazing experience.\rIt was my first time to try sea-doo.\nIt was very fun and easier than I thought to try!\rBest jetskiing experience I've had.";
            lblData.Visible = true;
            picJetski.Hide();
        }

        private void picJetski_Click(object sender, EventArgs e)
        {
            //display message with pic name and your name in title
            MessageBox.Show("Jet Skiing Halifax Harbour Waterfront.", "Rajal");
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //variable declaration
            int operand1,multiplier, answer;
            //variable conversion
            operand1 = Convert.ToInt32(txtNum1.Text);
            multiplier = Convert.ToInt32(txtNum2.Text);
            //formula
            answer = operand1 * multiplier;
            //variable conversion
            lblAnswer.Text = answer.ToString();

        }

    }
}
