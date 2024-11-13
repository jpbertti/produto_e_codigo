using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produto_e_codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor;
            int codigo;

            valor = double.Parse(txtValor.Text);
            codigo = int.Parse(txtCodigo.Text);

            if (codigo == 1)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Sul");
            }

            else if (codigo == 2)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Norte");
            }

            else if (codigo == 3)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Leste");
            }

            else if (codigo == 4)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Oeste");
            }

            else if (codigo == 5)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Nordeste ");
            }

            else if (codigo == 6)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Nordeste ");
            }

            else if (codigo == 7)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Centro-Oeste");
            }

            else if (codigo == 8)
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nRegião Centro-Oeste");
            }

            else
            {
                MessageBox.Show("Valor do Produto: " + valor + "\nImportado");
            }
        }
    }
}
    