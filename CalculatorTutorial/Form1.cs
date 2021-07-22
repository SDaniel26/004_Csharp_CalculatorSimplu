using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double primulNr;
        double alDoileaNr;
        string operatia;
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "0";
            }
            else
            {
                mainBox.Text = mainBox.Text + "0";
            }
        }

        private void btnUnu_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "1";
            }
            else
            {
                mainBox.Text = mainBox.Text + "1";
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "2";
            }
            else
            {
                mainBox.Text = mainBox.Text + "2";
            }
        }

        private void btnTrei_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "3";
            }
            else
            {
                mainBox.Text = mainBox.Text + "3";
            }
        }

        private void btnPatru_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "4";
            }
            else
            {
                mainBox.Text = mainBox.Text + "4";
            }
        }

        private void btnCinci_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "5";
            }
            else
            {
                mainBox.Text = mainBox.Text + "5";
            }
        }

        private void btnSase_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "6";
            }
            else
            {
                mainBox.Text = mainBox.Text + "6";
            }
        }

        private void btnSapte_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "7";
            }
            else
            {
                mainBox.Text = mainBox.Text + "7";
            }
        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "8";
            }
            else
            {
                mainBox.Text = mainBox.Text + "8";
            }
        }

        private void btnNoua_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == "0" && mainBox.Text != null)
            {
                mainBox.Text = "9";
            }
            else
            {
                mainBox.Text = mainBox.Text + "9";
            }
        }

        private void btnAdunare_Click(object sender, EventArgs e)
        {
            primulNr = Int32.Parse(mainBox.Text);
            operatia = "Adunare";

            mainBox.Clear();
        }

        private void btnScadere_Click(object sender, EventArgs e)
        {
            primulNr = Int32.Parse(mainBox.Text);
            operatia = "Scadere";

            mainBox.Clear();
        }

        private void btnInmultire_Click(object sender, EventArgs e)
        {
            primulNr = Int32.Parse(mainBox.Text);
            operatia = "Inmultire";

            mainBox.Clear();
        }

        private void btnImpartire_Click(object sender, EventArgs e)
        {
            primulNr = Int32.Parse(mainBox.Text);
            operatia = "Impartire";

            mainBox.Clear();
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            alDoileaNr = Int32.Parse(mainBox.Text);
            if (operatia == "Adunare")
            {
                rezultat.Text = (primulNr + alDoileaNr).ToString();
            } else if (operatia == "Scadere")
            {
                rezultat.Text = (primulNr - alDoileaNr).ToString();
            }
            else if (operatia == "Inmultire")
            {
                rezultat.Text = (primulNr * alDoileaNr).ToString();
            }
            else if (operatia == "Impartire")
            {
                rezultat.Text = (primulNr / alDoileaNr).ToString();
            }
            primulNr = 0;
            alDoileaNr = 0;
            operatia = "";
            mainBox.Text = "0";

        }
    }
}
