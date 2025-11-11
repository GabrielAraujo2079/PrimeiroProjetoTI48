namespace PrimeiroProjetoTI48
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.TextBox();
            this.n3 = new System.Windows.Forms.TextBox();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(109, 132);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(222, 30);
            this.n1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculadora";
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(421, 132);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(222, 30);
            this.n2.TabIndex = 5;
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(267, 246);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(222, 30);
            this.n3.TabIndex = 6;
            // 
            // Soma
            // 
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.Location = new System.Drawing.Point(189, 317);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 42);
            this.Soma.TabIndex = 7;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Subtracao
            // 
            this.Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtracao.Location = new System.Drawing.Point(291, 317);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(75, 42);
            this.Subtracao.TabIndex = 8;
            this.Subtracao.Text = "-";
            this.Subtracao.UseVisualStyleBackColor = true;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(398, 317);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 42);
            this.Mult.TabIndex = 9;
            this.Mult.Text = "X";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Divisao
            // 
            this.Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.Location = new System.Drawing.Point(505, 317);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(75, 42);
            this.Divisao.TabIndex = 10;
            this.Divisao.Text = "/";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox n3;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Divisao;
    }
}

