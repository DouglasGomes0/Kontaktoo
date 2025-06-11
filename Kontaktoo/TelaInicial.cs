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
            AtualizarDgvContatos();
        }

        public void AtualizarDgvContatos()
        {
            Model.Contato contato = new Model.Contato();

            contato.idResponsavel = usuario.Id;
            //colocar o resultado do select dentro do DataGridView
            dgvContatos.DataSource = contato.ListarTudo();
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
                    AtualizarDgvContatos();
                    //limpar os textBox
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbTelefone.Clear();
                    txbEmail.Clear();
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar contato!", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter o numero da linha que está selecionada
            int ls = dgvContatos.SelectedCells[0].RowIndex;
            //obter o valor (id) da primeira coluna (0) da linha selecionada (ls)
            int idSelecionado = int.Parse(dgvContatos.Rows[ls].Cells[0].Value.ToString());
            //obter nome da pessoa selecionada
            string nome = dgvContatos.Rows[ls].Cells[1].Value.ToString();
            //mensagem para confirmar exclusão
            DialogResult r = MessageBox.Show($"Quer realmente apagar {idSelecionado} - {nome}?",
                "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if( r == DialogResult.Yes )
            {
                Model.Contato contato = new Model.Contato();
                contato.Id = idSelecionado;

                if(contato.Apagar() == 1)
                {
                    MessageBox.Show("Contato Removido!", "sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvContatos();
                }
            }
        }
    }
}
