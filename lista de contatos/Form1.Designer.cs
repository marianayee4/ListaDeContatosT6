namespace lista_de_contatos
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
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsobrenome = new System.Windows.Forms.TextBox();
            this.textBoxtelefone = new System.Windows.Forms.TextBox();
            this.buttonincluircontatos = new System.Windows.Forms.Button();
            this.listBoxcontatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(152, 86);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(100, 20);
            this.textBoxnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // textBoxsobrenome
            // 
            this.textBoxsobrenome.Location = new System.Drawing.Point(152, 133);
            this.textBoxsobrenome.Name = "textBoxsobrenome";
            this.textBoxsobrenome.Size = new System.Drawing.Size(100, 20);
            this.textBoxsobrenome.TabIndex = 4;
            // 
            // textBoxtelefone
            // 
            this.textBoxtelefone.Location = new System.Drawing.Point(152, 182);
            this.textBoxtelefone.Name = "textBoxtelefone";
            this.textBoxtelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxtelefone.TabIndex = 5;
            // 
            // buttonincluircontatos
            // 
            this.buttonincluircontatos.Location = new System.Drawing.Point(62, 276);
            this.buttonincluircontatos.Name = "buttonincluircontatos";
            this.buttonincluircontatos.Size = new System.Drawing.Size(190, 120);
            this.buttonincluircontatos.TabIndex = 6;
            this.buttonincluircontatos.Text = "button1";
            this.buttonincluircontatos.UseVisualStyleBackColor = true;
            // 
            // listBoxcontatos
            // 
            this.listBoxcontatos.FormattingEnabled = true;
            this.listBoxcontatos.Location = new System.Drawing.Point(373, 86);
            this.listBoxcontatos.Name = "listBoxcontatos";
            this.listBoxcontatos.Size = new System.Drawing.Size(284, 303);
            this.listBoxcontatos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxcontatos);
            this.Controls.Add(this.buttonincluircontatos);
            this.Controls.Add(this.textBoxtelefone);
            this.Controls.Add(this.textBoxsobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsobrenome;
        private System.Windows.Forms.TextBox textBoxtelefone;
        private System.Windows.Forms.Button buttonincluircontatos;
        private System.Windows.Forms.ListBox listBoxcontatos;
    }
}

