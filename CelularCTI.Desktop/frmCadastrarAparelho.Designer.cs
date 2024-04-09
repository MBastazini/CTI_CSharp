namespace CelularCTI.Desktop
{
    partial class frmCadastrarAparelho
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
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.gpbEspecifi = new System.Windows.Forms.GroupBox();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.lblPeso = new System.Windows.Forms.Label();
            this.numEspessura = new System.Windows.Forms.NumericUpDown();
            this.lblEspessura = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.lblAltura = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.lblLargura = new System.Windows.Forms.Label();
            this.gpbValores = new System.Windows.Forms.GroupBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.lblPreço = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbEspecifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            this.gpbValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(45, 31);
            this.lblFabricante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(69, 15);
            this.lblFabricante.TabIndex = 1;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(45, 77);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 15);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(131, 31);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(234, 21);
            this.cmbFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(131, 77);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(234, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // gpbEspecifi
            // 
            this.gpbEspecifi.Controls.Add(this.numPeso);
            this.gpbEspecifi.Controls.Add(this.lblPeso);
            this.gpbEspecifi.Controls.Add(this.numEspessura);
            this.gpbEspecifi.Controls.Add(this.lblEspessura);
            this.gpbEspecifi.Controls.Add(this.numAltura);
            this.gpbEspecifi.Controls.Add(this.lblAltura);
            this.gpbEspecifi.Controls.Add(this.numLargura);
            this.gpbEspecifi.Controls.Add(this.lblLargura);
            this.gpbEspecifi.Location = new System.Drawing.Point(48, 135);
            this.gpbEspecifi.Name = "gpbEspecifi";
            this.gpbEspecifi.Size = new System.Drawing.Size(535, 143);
            this.gpbEspecifi.TabIndex = 5;
            this.gpbEspecifi.TabStop = false;
            this.gpbEspecifi.Text = "Especificações:";
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Location = new System.Drawing.Point(377, 104);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(133, 20);
            this.numPeso.TabIndex = 13;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPeso.ThousandsSeparator = true;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(276, 105);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(56, 15);
            this.lblPeso.TabIndex = 12;
            this.lblPeso.Text = "Peso (g):";
            // 
            // numEspessura
            // 
            this.numEspessura.DecimalPlaces = 2;
            this.numEspessura.Location = new System.Drawing.Point(377, 42);
            this.numEspessura.Name = "numEspessura";
            this.numEspessura.Size = new System.Drawing.Size(133, 20);
            this.numEspessura.TabIndex = 11;
            this.numEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEspessura.ThousandsSeparator = true;
            // 
            // lblEspessura
            // 
            this.lblEspessura.AutoSize = true;
            this.lblEspessura.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspessura.Location = new System.Drawing.Point(276, 43);
            this.lblEspessura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspessura.Name = "lblEspessura";
            this.lblEspessura.Size = new System.Drawing.Size(94, 15);
            this.lblEspessura.TabIndex = 10;
            this.lblEspessura.Text = "Espessura (cm):";
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Location = new System.Drawing.Point(97, 104);
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(133, 20);
            this.numAltura.TabIndex = 9;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAltura.ThousandsSeparator = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(7, 105);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(76, 15);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "Altura (cm):";
            // 
            // numLargura
            // 
            this.numLargura.DecimalPlaces = 2;
            this.numLargura.Location = new System.Drawing.Point(97, 42);
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(133, 20);
            this.numLargura.TabIndex = 7;
            this.numLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLargura.ThousandsSeparator = true;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargura.Location = new System.Drawing.Point(7, 43);
            this.lblLargura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(83, 15);
            this.lblLargura.TabIndex = 6;
            this.lblLargura.Text = "Largura (cm):";
            // 
            // gpbValores
            // 
            this.gpbValores.Controls.Add(this.numQuantidade);
            this.gpbValores.Controls.Add(this.label1);
            this.gpbValores.Controls.Add(this.numDesconto);
            this.gpbValores.Controls.Add(this.lblDesconto);
            this.gpbValores.Controls.Add(this.numPreco);
            this.gpbValores.Controls.Add(this.lblPreço);
            this.gpbValores.Location = new System.Drawing.Point(48, 310);
            this.gpbValores.Name = "gpbValores";
            this.gpbValores.Size = new System.Drawing.Size(535, 96);
            this.gpbValores.TabIndex = 14;
            this.gpbValores.TabStop = false;
            // 
            // numQuantidade
            // 
            this.numQuantidade.DecimalPlaces = 2;
            this.numQuantidade.Location = new System.Drawing.Point(97, 65);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(133, 20);
            this.numQuantidade.TabIndex = 13;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuantidade.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade:";
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 2;
            this.numDesconto.Location = new System.Drawing.Point(377, 29);
            this.numDesconto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(133, 20);
            this.numDesconto.TabIndex = 11;
            this.numDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDesconto.ThousandsSeparator = true;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(276, 30);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(64, 15);
            this.lblDesconto.TabIndex = 10;
            this.lblDesconto.Text = "Desconto:";
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Location = new System.Drawing.Point(97, 29);
            this.numPreco.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPreco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(133, 20);
            this.numPreco.TabIndex = 7;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPreco.ThousandsSeparator = true;
            this.numPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.Location = new System.Drawing.Point(7, 30);
            this.lblPreço.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(42, 15);
            this.lblPreço.TabIndex = 6;
            this.lblPreço.Text = "Preço:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(58, 412);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 37);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(463, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastrarAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbValores);
            this.Controls.Add(this.gpbEspecifi);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblFabricante);
            this.Name = "frmCadastrarAparelho";
            this.Text = "Cadastrar Aparelho";
            this.Load += new System.EventHandler(this.frmCadastrarAparelho_Load);
            this.gpbEspecifi.ResumeLayout(false);
            this.gpbEspecifi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            this.gpbValores.ResumeLayout(false);
            this.gpbValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox gpbEspecifi;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.GroupBox gpbValores;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown numEspessura;
        private System.Windows.Forms.Label lblEspessura;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label1;
    }
}