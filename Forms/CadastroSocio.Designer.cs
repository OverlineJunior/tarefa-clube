namespace TarefaClube.Forms
{
    partial class CadastroSocio
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
            TiposSocio = new ComboBox();
            RGDependentes = new TextBox();
            SuspendLayout();
            // 
            // TiposSocio
            // 
            TiposSocio.FormattingEnabled = true;
            TiposSocio.Items.AddRange(new object[] { "Fundador", "Proprietário", "Cotista", "Voluntário" });
            TiposSocio.Location = new Point(118, 12);
            TiposSocio.Name = "TiposSocio";
            TiposSocio.Size = new Size(213, 23);
            TiposSocio.TabIndex = 10;
            TiposSocio.Text = "Tipo de Sócio";
            // 
            // RGDependentes
            // 
            RGDependentes.Location = new Point(118, 41);
            RGDependentes.Multiline = true;
            RGDependentes.Name = "RGDependentes";
            RGDependentes.PlaceholderText = "Dependentes (RGs separados por linha)";
            RGDependentes.Size = new Size(213, 226);
            RGDependentes.TabIndex = 11;
            // 
            // CadastroSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RGDependentes);
            Controls.Add(TiposSocio);
            Name = "CadastroSocio";
            Text = "CadastroSocio";
            Controls.SetChildIndex(Nome, 0);
            Controls.SetChildIndex(Celular, 0);
            Controls.SetChildIndex(Email, 0);
            Controls.SetChildIndex(DataNascimento, 0);
            Controls.SetChildIndex(Endereco, 0);
            Controls.SetChildIndex(Complemento, 0);
            Controls.SetChildIndex(Cidade, 0);
            Controls.SetChildIndex(RG, 0);
            Controls.SetChildIndex(CEP, 0);
            Controls.SetChildIndex(TiposSocio, 0);
            Controls.SetChildIndex(RGDependentes, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox TiposSocio;
        public TextBox RGDependentes;
    }
}