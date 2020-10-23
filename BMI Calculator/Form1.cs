using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnberekenen_Click(object sender, EventArgs e)
        {
            float gewicht = float.Parse(txtgewicht.Text);
            float lengte = float.Parse(txtlengte.Text);
            float leeftijd = float.Parse(txtleeftijd.Text);

            

            float BMI = gewicht / (lengte * lengte)  ;
            string advies = "Hier komt een advies lengte:" + lengte + " gewitcht: " + gewicht ;
            

            lblbmi.Text = BMI.ToString();
            lbladvies.Text = advies;

            if (BMI <= 18.5 )
            {
                lbladvies.Text = "Je heb ondergewicht";
            }
            if (BMI  > 18.5 && BMI < 24.5 )
            {
                lbladvies.Text = "Je bent op gewicht";
            }
            else
            {
                lbladvies.Text = "Je heb overgewicht";
            }
            

        }
    }
}
