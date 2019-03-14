using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
{
    public partial class Form1 : Form
    {
        private int factoriel(int Entier)
        {
            int total;

            if (Entier == 0)
            {
                return 1;
            }
            else
            {
                total = Entier * factoriel(Entier - 1);
                return total;
            }
        }


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            lblResult.Text = "Resultat";


            int MonEntier;
            int test;


            if (int.TryParse(txtInput.Text, out test))
            {
                MonEntier = int.Parse(txtInput.Text);

                if(MonEntier < 0)
                {
                    MessageBox.Show("Veuillez entrer une valeur égale ou supérieur à zéro");
                }
                else
                {
                    lblResult.Text += " " + factoriel(MonEntier).ToString();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un entier");
                txtInput.Text = "";
            }


                
        }
    }
}
