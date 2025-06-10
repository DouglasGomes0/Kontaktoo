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
    public partial class TelaInicial : Form
    {
        //usuario global:
        Model.Usuarios usuario;
        public TelaInicial(Model.Usuarios usuarios)
        {
            InitializeComponent();
            this.usuario = usuarios;
            lblUsuario.Text = $"Olá, {usuarios.Nome}";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //verificar se o nome está vazio:
            if(txbNome.Text.Length < 3)
            {
                MessageBox.Show("O nome é obrigatório!", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //instanciar um obj do tipo contato
                Model.Contato contato = new Model.Contato();
                contato.Nome = txbNome.Text;
                contato.Email = txbEmail.Text;
                contato.Endereco = txbEndereco.Text;
                contato.Telefone = txbTelefone.Text;
                contato.idResponsavel = usuario.Id;

                if(contato.cadastrar() == 1)
                {
                    MessageBox.Show("Contato Cadastrado!", "sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar contato!", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
