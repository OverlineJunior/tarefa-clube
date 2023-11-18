namespace TarefaClube.Forms
{
    partial class Base
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
            Aplicar = new Button();
            SuspendLayout();
            // 
            // Aplicar
            // 
            Aplicar.DialogResult = DialogResult.OK;
            Aplicar.Location = new Point(713, 415);
            Aplicar.Name = "Aplicar";
            Aplicar.Size = new Size(75, 23);
            Aplicar.TabIndex = 0;
            Aplicar.Text = "Aplicar";
            Aplicar.UseVisualStyleBackColor = true;
            Aplicar.Click += Aplicar_Click;
            // 
            // Base
            // 
            AcceptButton = Aplicar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Aplicar);
            Name = "Base";
            Text = "Base";
            ResumeLayout(false);
        }

        #endregion

        private Button Aplicar;
    }
}