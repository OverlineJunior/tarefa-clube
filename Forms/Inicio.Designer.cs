namespace TarefaClube.Forms
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            Cadastros = new ToolStripMenuItem();
            CadastroSocio = new ToolStripMenuItem();
            CadastroDependente = new ToolStripMenuItem();
            CadastroFornecedor = new ToolStripMenuItem();
            CadastroEspaco = new ToolStripMenuItem();
            CadastroAtividade = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Cadastros });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Cadastros
            // 
            Cadastros.DropDownItems.AddRange(new ToolStripItem[] { CadastroSocio, CadastroDependente, CadastroFornecedor, CadastroEspaco, CadastroAtividade });
            Cadastros.Name = "Cadastros";
            Cadastros.Size = new Size(71, 20);
            Cadastros.Text = "Cadastros";
            // 
            // CadastroSocio
            // 
            CadastroSocio.Name = "CadastroSocio";
            CadastroSocio.Size = new Size(180, 22);
            CadastroSocio.Text = "Sócio";
            // 
            // CadastroDependente
            // 
            CadastroDependente.Name = "CadastroDependente";
            CadastroDependente.Size = new Size(180, 22);
            CadastroDependente.Text = "Dependente";
            // 
            // CadastroFornecedor
            // 
            CadastroFornecedor.Name = "CadastroFornecedor";
            CadastroFornecedor.Size = new Size(180, 22);
            CadastroFornecedor.Text = "Fornecedor";
            // 
            // CadastroEspaco
            // 
            CadastroEspaco.Name = "CadastroEspaco";
            CadastroEspaco.Size = new Size(180, 22);
            CadastroEspaco.Text = "Espaço";
            // 
            // CadastroAtividade
            // 
            CadastroAtividade.Name = "CadastroAtividade";
            CadastroAtividade.Size = new Size(180, 22);
            CadastroAtividade.Text = "Atividade";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Cadastros;
        private ToolStripMenuItem CadastroSocio;
        private ToolStripMenuItem CadastroDependente;
        private ToolStripMenuItem CadastroFornecedor;
        private ToolStripMenuItem CadastroEspaco;
        private ToolStripMenuItem CadastroAtividade;
    }
}