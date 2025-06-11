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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //instanciar um objeto do tipo usuario\\
            Model.Usuarios usuarios = new Model.Usuarios();
            //verificar se os campos estão vazios
            if(txbEmail.Text.Length < 6 )
            {
                MessageBox.Show("Email inválido" , "error" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length == 0 )
            {
                MessageBox.Show("campo de senha não deve estar vazio", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usuarios.Email = txbEmail.Text;
                usuarios.Senha = txbSenha.Text;
                //tabela para receber o resultado da consulta de login
                DataTable resultado = usuarios.Logar();

                //verificar se a consulta teve resultado
                if (resultado.Rows.Count == 1)
                {
                    MessageBox.Show($"Seja bem vindo, {resultado.Rows[0]["nome"]}!", "sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //atribuir no novo objeto as informações vindas do bd
                    usuarios.Nome = resultado.Rows[0]["nome"].ToString();
                    usuarios.Id = int.Parse(resultado.Rows[0]["id"].ToString());

                    //abrir a nova janela
                    TelaInicial telaInicial = new TelaInicial(usuarios);
                    this.Hide();
                    telaInicial.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!" , "error" ,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llaCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }
    }
}
