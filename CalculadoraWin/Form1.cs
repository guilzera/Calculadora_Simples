using System;
using System.Windows.Forms;
using System.Globalization;

namespace CalculadoraWin
{
    public partial class Form1 : Form
    {
        string operador;
        double a = 0.0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label2.Text = "";
            a = 0;
            validar = false;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label2.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label2.Text = txtValor.Text + btnAdicao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = false;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label2.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label2.Text = txtValor.Text + btnSubtracao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = false;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtValor.Text);
                label2.Text = Convert.ToString(a) + "x";
                txtValor.Text = "";
                operador = "x";
            }
            else
            {
                label2.Text = txtValor.Text + btnMultiplicar.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "x";
                validar = false;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(txtValor.Text);
                label2.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label2.Text = txtValor.Text + btnDividir.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = false;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label2.Text = label2.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "-")
            {
                label2.Text = label2.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "x")
            {
                label2.Text = label2.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "/")
            {
                label2.Text = label2.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));
            }
        }
    }
}
