using System;
using System.Windows.Forms;

namespace PalindromoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerificarPalindromo_Click(object sender, EventArgs e)
        {
            string palabra = PalabraTextBox.Text.ToLower();
            string palabraReversa = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraReversa += palabra[i];
            }

            if (palabra == palabraReversa)
            {
                ResultadoLabel.Text = "Es un palíndromo.";
            }
            else
            {
                ResultadoLabel.Text = "No es un palíndromo.";
            }
        }
    }
}
