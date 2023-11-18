namespace TarefaClube.Forms
{
    partial class CadastroPessoa
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
            Nome = new TextBox();
            Celular = new TextBox();
            Email = new TextBox();
            DataNascimento = new TextBox();
            Endereco = new TextBox();
            Complemento = new TextBox();
            Cidade = new TextBox();
            RG = new TextBox();
            CEP = new TextBox();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.Location = new Point(12, 12);
            Nome.Name = "Nome";
            Nome.PlaceholderText = "Nome";
            Nome.Size = new Size(100, 23);
            Nome.TabIndex = 1;
            // 
            // Celular
            // 
            Celular.Location = new Point(12, 41);
            Celular.Name = "Celular";
            Celular.PlaceholderText = "Celular";
            Celular.Size = new Size(100, 23);
            Celular.TabIndex = 2;
            // 
            // Email
            // 
            Email.Location = new Point(12, 70);
            Email.Name = "Email";
            Email.PlaceholderText = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 3;
            // 
            // DataNascimento
            // 
            DataNascimento.Location = new Point(12, 99);
            DataNascimento.Name = "DataNascimento";
            DataNascimento.PlaceholderText = "Data de Nascimento";
            DataNascimento.Size = new Size(100, 23);
            DataNascimento.TabIndex = 4;
            // 
            // Endereco
            // 
            Endereco.Location = new Point(12, 128);
            Endereco.Name = "Endereco";
            Endereco.PlaceholderText = "Endereço";
            Endereco.Size = new Size(100, 23);
            Endereco.TabIndex = 5;
            // 
            // Complemento
            // 
            Complemento.Location = new Point(12, 157);
            Complemento.Name = "Complemento";
            Complemento.PlaceholderText = "Complemento";
            Complemento.Size = new Size(100, 23);
            Complemento.TabIndex = 6;
            // 
            // Cidade
            // 
            Cidade.Location = new Point(12, 186);
            Cidade.Name = "Cidade";
            Cidade.PlaceholderText = "Cidade";
            Cidade.Size = new Size(100, 23);
            Cidade.TabIndex = 7;
            // 
            // RG
            // 
            RG.Location = new Point(12, 215);
            RG.Name = "RG";
            RG.PlaceholderText = "RG";
            RG.Size = new Size(100, 23);
            RG.TabIndex = 8;
            // 
            // CEP
            // 
            CEP.Location = new Point(12, 244);
            CEP.Name = "CEP";
            CEP.PlaceholderText = "CEP";
            CEP.Size = new Size(100, 23);
            CEP.TabIndex = 9;
            // 
            // CadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CEP);
            Controls.Add(RG);
            Controls.Add(Cidade);
            Controls.Add(Complemento);
            Controls.Add(Endereco);
            Controls.Add(DataNascimento);
            Controls.Add(Email);
            Controls.Add(Celular);
            Controls.Add(Nome);
            Name = "CadastroPessoa";
            Text = "CadastroPessoa";
            Controls.SetChildIndex(Nome, 0);
            Controls.SetChildIndex(Celular, 0);
            Controls.SetChildIndex(Email, 0);
            Controls.SetChildIndex(DataNascimento, 0);
            Controls.SetChildIndex(Endereco, 0);
            Controls.SetChildIndex(Complemento, 0);
            Controls.SetChildIndex(Cidade, 0);
            Controls.SetChildIndex(RG, 0);
            Controls.SetChildIndex(CEP, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox Nome;
        public TextBox Celular;
        public TextBox Email;
        public TextBox DataNascimento;
        public TextBox Endereco;
        public TextBox Complemento;
        public TextBox Cidade;
        public TextBox RG;
        public TextBox CEP;
    }
}