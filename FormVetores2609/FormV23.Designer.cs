namespace FormVetores2609
{
    partial class FormV23
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
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe um produto:";
            // 
            // tbxProduto
            // 
            this.tbxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxProduto.Location = new System.Drawing.Point(22, 43);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(390, 24);
            this.tbxProduto.TabIndex = 2;
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 18;
            this.lbxProdutos.Location = new System.Drawing.Point(240, 90);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(172, 220);
            this.lbxProdutos.TabIndex = 3;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimparLista.Location = new System.Drawing.Point(22, 271);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(172, 37);
            this.btnLimparLista.TabIndex = 5;
            this.btnLimparLista.Text = "LIMPAR LISTA";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemover.Location = new System.Drawing.Point(22, 215);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(172, 37);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdicionar.Location = new System.Drawing.Point(22, 156);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(172, 39);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informe o preço:";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxPreco.Location = new System.Drawing.Point(22, 106);
            this.tbxPreco.MaxLength = 8;
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(172, 24);
            this.tbxPreco.TabIndex = 10;
            // 
            // FormV23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 343);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.lbxProdutos);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.label1);
            this.Name = "FormV23";
            this.Text = "Lista de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPreco;
    }
}

