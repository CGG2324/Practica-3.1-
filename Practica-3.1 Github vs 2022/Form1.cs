using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1_Github_vs_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';//CGG2324
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (ordinario.Checked)
                tipoTelegrama = 'o';//CGG2324 modificado
            if (urgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ',',','.',';').Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;//CGG2324
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";//CGG2324


        }
    }
}
