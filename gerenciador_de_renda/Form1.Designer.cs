namespace gerenciador_de_renda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.valorRenda = new System.Windows.Forms.TextBox();
            this.botaoForm = new System.Windows.Forms.Button();
            this.resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe sua Renda Mensal (Ex: 2500,75)";
            // 
            // valorRenda
            // 
            this.valorRenda.Font = new System.Drawing.Font("Arial", 12F);
            this.valorRenda.Location = new System.Drawing.Point(12, 61);
            this.valorRenda.Multiline = true;
            this.valorRenda.Name = "valorRenda";
            this.valorRenda.Size = new System.Drawing.Size(295, 31);
            this.valorRenda.TabIndex = 1;
            // 
            // botaoForm
            // 
            this.botaoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoForm.Location = new System.Drawing.Point(323, 61);
            this.botaoForm.Name = "botaoForm";
            this.botaoForm.Size = new System.Drawing.Size(148, 31);
            this.botaoForm.TabIndex = 2;
            this.botaoForm.Text = "Calcular";
            this.botaoForm.UseVisualStyleBackColor = true;
            this.botaoForm.Click += new System.EventHandler(this.OrganizarRenda);
            // 
            // resultados
            // 
            this.resultados.Font = new System.Drawing.Font("Arial", 12F);
            this.resultados.FormattingEnabled = true;
            this.resultados.ItemHeight = 18;
            this.resultados.Location = new System.Drawing.Point(12, 142);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(459, 94);
            this.resultados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.botaoForm);
            this.Controls.Add(this.valorRenda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Renda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorRenda;
        private System.Windows.Forms.Button botaoForm;
        private System.Windows.Forms.ListBox resultados;
    }
}

