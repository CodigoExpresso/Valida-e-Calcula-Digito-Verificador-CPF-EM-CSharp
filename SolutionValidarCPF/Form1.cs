using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolutionValidarCPF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            // Declara variaveis
            string mensagem;
            MessageBoxIcon mIcon;

            // Verifica se CPF e valido
            if (ValidaDigitoCPF.ValidaCPF(txtCPF.Text))
            {
                mensagem = "CPF informado é valido";
                mIcon = MessageBoxIcon.Information;
            }
            else
            {
                mensagem = "CPF informado não é valido";
                mIcon = MessageBoxIcon.Error;
       
            }

            // Exibe mensagem da validade do CPF
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, mIcon);
            txtCPF.Focus();
        }
    }
}
