using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktoo
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text.Length < 3)
            {
                MessageBox.Show("verifique o nome informado!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("verifique o email informado!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length == 0)
            {
                MessageBox.Show("verifique a senha!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuarios usuarios = new Model.Usuarios();
                usuarios.Nome = txbNome.Text;
                usuarios.Email = txbEmail.Text;
                usuarios.Senha = txbSenha.Text;
                if (usuarios.Cadastrar() == 1)
                {
                    MessageBox.Show("Conta criada!", "sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
