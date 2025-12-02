namespace PrimeiroProjetoTI48
{
    partial class Vendas
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn
            // 
            this.btn.ForeColor = System.Drawing.Color.Coral;
            this.btn.Location = new System.Drawing.Point(9, 396);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(58, 42);
            this.btn.TabIndex = 27;
            this.btn.Text = "Mostrar Dados";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ForeColor = System.Drawing.Color.Coral;
            this.btnConsultar.Location = new System.Drawing.Point(238, 363);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 27);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Coral;
            this.btnExcluir.Location = new System.Drawing.Point(157, 363);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 27);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.Color.Coral;
            this.btnAlterar.Location = new System.Drawing.Point(76, 363);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 27);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ForeColor = System.Drawing.Color.Coral;
            this.btnAdicionar.Location = new System.Drawing.Point(9, 363);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 27);
            this.btnAdicionar.TabIndex = 23;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 166);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(290, 182);
            this.dg.TabIndex = 22;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.Coral;
            this.lblDescricao.Location = new System.Drawing.Point(9, 85);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(102, 61);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(200, 20);
            this.txtEstoque.TabIndex = 19;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.ForeColor = System.Drawing.Color.Coral;
            this.lblEstoque.Location = new System.Drawing.Point(6, 61);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 14;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.ForeColor = System.Drawing.Color.Coral;
            this.lblPreco.Location = new System.Drawing.Point(6, 35);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "Preco";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Coral;
            this.lblNome.Location = new System.Drawing.Point(6, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(102, 35);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(200, 20);
            this.txtPreco.TabIndex = 28;
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(102, 85);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(200, 20);
            this.textDesc.TabIndex = 29;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.ForeColor = System.Drawing.Color.Coral;
            this.Categoria.Location = new System.Drawing.Point(9, 119);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 30;
            this.Categoria.Text = "Categoria";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(102, 119);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(200, 20);
            this.textCategoria.TabIndex = 31;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 461);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox textCategoria;
    }
}