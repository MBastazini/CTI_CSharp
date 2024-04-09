namespace CelularCTI.Desktop
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnPesquisarModelo = new System.Windows.Forms.Button();
            this.btnPesquisarPreco = new System.Windows.Forms.Button();
            this.numMaximo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numMinimo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFabricante);
            this.groupBox1.Controls.Add(this.btnFabricante);
            this.groupBox1.Controls.Add(this.btnPesquisarModelo);
            this.groupBox1.Controls.Add(this.btnPesquisarPreco);
            this.groupBox1.Controls.Add(this.numMaximo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.numMinimo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(461, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(82, 151);
            this.cmbFabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(310, 23);
            this.cmbFabricante.TabIndex = 10;
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(399, 152);
            this.btnFabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(55, 23);
            this.btnFabricante.TabIndex = 9;
            this.btnFabricante.Text = ">>";
            this.btnFabricante.UseVisualStyleBackColor = true;
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // btnPesquisarModelo
            // 
            this.btnPesquisarModelo.Location = new System.Drawing.Point(399, 95);
            this.btnPesquisarModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarModelo.Name = "btnPesquisarModelo";
            this.btnPesquisarModelo.Size = new System.Drawing.Size(55, 23);
            this.btnPesquisarModelo.TabIndex = 8;
            this.btnPesquisarModelo.Text = ">>";
            this.btnPesquisarModelo.UseVisualStyleBackColor = true;
            this.btnPesquisarModelo.Click += new System.EventHandler(this.btnPesquisarModelo_Click);
            // 
            // btnPesquisarPreco
            // 
            this.btnPesquisarPreco.Location = new System.Drawing.Point(399, 27);
            this.btnPesquisarPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisarPreco.Name = "btnPesquisarPreco";
            this.btnPesquisarPreco.Size = new System.Drawing.Size(55, 23);
            this.btnPesquisarPreco.TabIndex = 7;
            this.btnPesquisarPreco.Text = ">>";
            this.btnPesquisarPreco.UseVisualStyleBackColor = true;
            this.btnPesquisarPreco.Click += new System.EventHandler(this.btnPesquisarPreco_Click);
            // 
            // numMaximo
            // 
            this.numMaximo.DecimalPlaces = 2;
            this.numMaximo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaximo.Location = new System.Drawing.Point(250, 27);
            this.numMaximo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numMaximo.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numMaximo.Name = "numMaximo";
            this.numMaximo.Size = new System.Drawing.Size(141, 23);
            this.numMaximo.TabIndex = 6;
            this.numMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaximo.ThousandsSeparator = true;
            this.numMaximo.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "a";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(82, 95);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(310, 23);
            this.txtModelo.TabIndex = 4;
            // 
            // numMinimo
            // 
            this.numMinimo.DecimalPlaces = 2;
            this.numMinimo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinimo.Location = new System.Drawing.Point(80, 27);
            this.numMinimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numMinimo.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numMinimo.Name = "numMinimo";
            this.numMinimo.Size = new System.Drawing.Size(141, 23);
            this.numMinimo.TabIndex = 3;
            this.numMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinimo.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCelulares);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(454, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celulares:";
            // 
            // lstCelulares
            // 
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.ItemHeight = 15;
            this.lstCelulares.Location = new System.Drawing.Point(7, 22);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(440, 184);
            this.lstCelulares.TabIndex = 0;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(25, 441);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 46);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(191, 441);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 46);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(362, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 46);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 489);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.Text = "ok";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.Button btnPesquisarModelo;
        private System.Windows.Forms.Button btnPesquisarPreco;
        private System.Windows.Forms.NumericUpDown numMaximo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
    }
}

