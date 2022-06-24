using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gerenciador_de_renda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EstratificarRenda(double renda)
        {
            Dictionary<string, double> estratos = new Dictionary<string, double>
            {
                { "estrato50", (renda * 50) / 100 }, // 50% Para Gastos Essenciais
                { "estrato35", (renda * 35) / 100 }, // 35% Para Estilo de vida
                { "estrato15", (renda * 15) / 100 } // 15% Para Investimentos
            };

            double estrato50 = estratos["estrato50"];
            double estrato35 = estratos["estrato35"];
            double estrato15 = estratos["estrato15"];

            //Método para imprimir os resultados no formulário
            ExibirResultados(renda, estrato50, estrato35, estrato15);
        }

        private void ExibirResultados(double renda, double estrato50, double estrato35, double estrato15)
        {
            resultados.Items.Clear();
            resultados.Items.Add($"- Para {renda.ToString("C")} Faça o seguinte:");
            resultados.Items.Add(" ");
            resultados.Items.Add($"- Reserve {estrato50.ToString("C")} (50%), para GASTOS ESSENCIAIS.");
            resultados.Items.Add($"- Reserve {estrato35.ToString("C")} (35%), para HOBBIES");
            resultados.Items.Add($"- Reserve {estrato15.ToString("C")} (15%), para INVESTIMENTOS");
        }

        private void OrganizarRenda(object sender = null, EventArgs e = null)
        {
            try
            {
                double rendaCliente = double.Parse(valorRenda.Text);
                EstratificarRenda(rendaCliente);
            }
            catch
            {
                MessageBox.Show("Valor Inválido\r\n" +
                    "não insira palavras ou símbolos\r\n" +
                    "Apenas números (Ex: 4500,50) ");
            }
        }
    }
}
