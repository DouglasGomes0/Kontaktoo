namespace Kontaktoo
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInfoRemover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.grbAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.AllowUserToResizeColumns = false;
            this.dgvContatos.AllowUserToResizeRows = false;
            this.dgvContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(12, 275);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.Size = new System.Drawing.Size(776, 163);
            this.dgvContatos.TabIndex = 0;
            this.dgvContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellDoubleClick);
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.lblEmail);
            this.grbAdicionar.Controls.Add(this.txbEmail);
            this.grbAdicionar.Controls.Add(this.btnAdicionar);
            this.grbAdicionar.Controls.Add(this.lblEndereco);
            this.grbAdicionar.Controls.Add(this.lblTelefone);
            this.grbAdicionar.Controls.Add(this.lblNome);
            this.grbAdicionar.Controls.Add(this.txbEndereco);
            this.grbAdicionar.Controls.Add(this.txbTelefone);
            this.grbAdicionar.Controls.Add(this.txbNome);
            this.grbAdicionar.Location = new System.Drawing.Point(12, 119);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(776, 150);
            this.grbAdicionar.TabIndex = 1;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(421, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 29);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(508, 66);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(262, 31);
            this.txbEmail.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::Kontaktoo.Properties.Resources.OrangePink;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(245, 104);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(363, 41);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(380, 19);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(128, 29);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(3, 66);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(110, 29);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 29);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "nome:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(508, 19);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(262, 31);
            this.txbEndereco.TabIndex = 2;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(116, 66);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(233, 31);
            this.txbTelefone.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(116, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(233, 31);
            this.txbNome.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(20, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Kontaktoo";
            // 
            // pibLogo
            // 
            this.pibLogo.BackColor = System.Drawing.Color.Transparent;
            this.pibLogo.Image = global::Kontaktoo.Properties.Resources.agenda;
            this.pibLogo.Location = new System.Drawing.Point(20, 26);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(109, 90);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 3;
            this.pibLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(612, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 25);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "name";
            // 
            // lblInfoRemover
            // 
            this.lblInfoRemover.AutoSize = true;
            this.lblInfoRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfoRemover.Location = new System.Drawing.Point(15, 441);
            this.lblInfoRemover.Name = "lblInfoRemover";
            this.lblInfoRemover.Size = new System.Drawing.Size(164, 13);
            this.lblInfoRemover.TabIndex = 5;
            this.lblInfoRemover.Text = "2 clicks para remover um contato";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblInfoRemover);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pibLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbAdicionar);
            this.Controls.Add(this.dgvContatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Kontaktoo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblInfoRemover;
    }
}