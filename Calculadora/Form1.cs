﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void boato3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void botaoPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            // O metodo "CultureInfo.InvariantCulture" transforma o texto com pontuação
            // em deciamal com a pontuação correta.
             
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                if (txtResultado.Text == "0")
                {
                    MessageBox.Show("Insira um valor diferente de ZERO!", "Atenção!",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    txtResultado.Text = "";
                }
                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }

            }
        
    }

        private void botaoApagaTudo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void botaoAdicao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma! ", "Atenção!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void botaoSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração! ", "Atenção!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação! ", "Atenção!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void boatoDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão! ", "Atenção!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }

        private void botaoApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
        
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Não é permitido LETRAS! ", "Atenção!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void botaoZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
    }
}
