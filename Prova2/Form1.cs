using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double resul;
        double valorfinal;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = 0;
            /*double valor0 = 0;*/
            double valor1 = 0;
            double valor2 = 0;
            double valor3 = 0;
            double imposto1 = 0;
            double imposto2 = 0;
            double imposto3 = 0;

            valor = Convert.ToDouble(tx_valor.Text.ToString());

            //Calculo PIS
            imposto1 = Convert.ToDouble(tx_pis.Text.ToString());


            imposto1 = (imposto1 / 100);

            valor1 = valor * imposto1;

            

            //Calculo ICMS
            resul = 0;


            imposto2 = Convert.ToDouble(tx_icms.Text.ToString());

            imposto2 = (imposto2 / 100);

            valor2 = valor * imposto2;

            /*valor2 = resul;*/


            //Calculo CONFINS

            resul = 0;


            imposto3 = Convert.ToDouble(tx_confins.Text.ToString());

            imposto3 = (imposto3 / 100);

            valor3 = valor * imposto3;

            /*valor3 = resul;*/



            // Calculo Lucro
            resul = 0;

            double lucro = Convert.ToDouble(tx_lucro.Text.ToString());

            lucro = (lucro / 100);

            lucro = (valor + valor1 + valor2 + valor3) * lucro;

           /* lucro = resul;*/



            valorfinal = valor + lucro + valor1 + valor2 + valor3;

            lb_resul.Text = valorfinal.ToString();

            /*if (cbx_unidade.Text == "LT")
            {
                valorfinal = valorfinal + (valorfinal * 0.05);
            }*/
        }
    }
}
