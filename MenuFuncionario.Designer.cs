namespace ProjetoInter
{
    partial class frmMenuFuncionario
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.picEstoque = new System.Windows.Forms.PictureBox();
            this.picPedidos = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.bgPicPedidosFunc = new System.Windows.Forms.Label();
            this.bgPicEstoque = new System.Windows.Forms.Label();
            this.lblSairMenuFunc = new System.Windows.Forms.Label();
            this.lblOpçãoMenuF = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.picCadCliente = new System.Windows.Forms.PictureBox();
            this.lblPanelCadCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.Wheat;
            this.lblFuncionario.Location = new System.Drawing.Point(289, 48);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(177, 26);
            this.lblFuncionario.TabIndex = 25;
            this.lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoInter.Properties.Resources.atendente;
            this.pictureBox1.Location = new System.Drawing.Point(217, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.DimGray;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEstoque.Location = new System.Drawing.Point(519, 279);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(76, 20);
            this.lblEstoque.TabIndex = 23;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.DimGray;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPedidos.Location = new System.Drawing.Point(310, 279);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(73, 20);
            this.lblPedidos.TabIndex = 22;
            this.lblPedidos.Text = "Pedidos";
            // 
            // picEstoque
            // 
            this.picEstoque.BackColor = System.Drawing.Color.DimGray;
            this.picEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstoque.Image = global::ProjetoInter.Properties.Resources.despensa__1_;
            this.picEstoque.Location = new System.Drawing.Point(504, 191);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(100, 85);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstoque.TabIndex = 21;
            this.picEstoque.TabStop = false;
            this.picEstoque.Click += new System.EventHandler(this.picEstoque_Click);
            // 
            // picPedidos
            // 
            this.picPedidos.BackColor = System.Drawing.Color.DimGray;
            this.picPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidos.Image = global::ProjetoInter.Properties.Resources.pedido;
            this.picPedidos.Location = new System.Drawing.Point(294, 191);
            this.picPedidos.Name = "picPedidos";
            this.picPedidos.Size = new System.Drawing.Size(100, 85);
            this.picPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedidos.TabIndex = 20;
            this.picPedidos.TabStop = false;
            this.picPedidos.Click += new System.EventHandler(this.picPedidos_Click);
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::ProjetoInter.Properties.Resources.sair;
            this.picLogout.Location = new System.Drawing.Point(12, 368);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(51, 52);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 19;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // bgPicPedidosFunc
            // 
            this.bgPicPedidosFunc.BackColor = System.Drawing.Color.DimGray;
            this.bgPicPedidosFunc.Location = new System.Drawing.Point(267, 172);
            this.bgPicPedidosFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bgPicPedidosFunc.Name = "bgPicPedidosFunc";
            this.bgPicPedidosFunc.Size = new System.Drawing.Size(153, 142);
            this.bgPicPedidosFunc.TabIndex = 26;
            // 
            // bgPicEstoque
            // 
            this.bgPicEstoque.BackColor = System.Drawing.Color.DimGray;
            this.bgPicEstoque.Location = new System.Drawing.Point(474, 172);
            this.bgPicEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bgPicEstoque.Name = "bgPicEstoque";
            this.bgPicEstoque.Size = new System.Drawing.Size(153, 142);
            this.bgPicEstoque.TabIndex = 27;
            // 
            // lblSairMenuFunc
            // 
            this.lblSairMenuFunc.AutoSize = true;
            this.lblSairMenuFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSairMenuFunc.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSairMenuFunc.Location = new System.Drawing.Point(69, 381);
            this.lblSairMenuFunc.Name = "lblSairMenuFunc";
            this.lblSairMenuFunc.Size = new System.Drawing.Size(55, 26);
            this.lblSairMenuFunc.TabIndex = 28;
            this.lblSairMenuFunc.Text = "Sair";
            // 
            // lblOpçãoMenuF
            // 
            this.lblOpçãoMenuF.AutoSize = true;
            this.lblOpçãoMenuF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpçãoMenuF.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOpçãoMenuF.Location = new System.Drawing.Point(266, 139);
            this.lblOpçãoMenuF.Name = "lblOpçãoMenuF";
            this.lblOpçãoMenuF.Size = new System.Drawing.Size(166, 20);
            this.lblOpçãoMenuF.TabIndex = 29;
            this.lblOpçãoMenuF.Text = "Escolha uma opção";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.DimGray;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCliente.Location = new System.Drawing.Point(81, 285);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(143, 20);
            this.lblCliente.TabIndex = 39;
            this.lblCliente.Text = "Cadastro Cliente";
            // 
            // picCadCliente
            // 
            this.picCadCliente.BackColor = System.Drawing.Color.DimGray;
            this.picCadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCadCliente.Image = global::ProjetoInter.Properties.Resources.cliente;
            this.picCadCliente.Location = new System.Drawing.Point(98, 197);
            this.picCadCliente.Name = "picCadCliente";
            this.picCadCliente.Size = new System.Drawing.Size(100, 85);
            this.picCadCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadCliente.TabIndex = 38;
            this.picCadCliente.TabStop = false;
            this.picCadCliente.Click += new System.EventHandler(this.picCadCliente_Click);
            // 
            // lblPanelCadCliente
            // 
            this.lblPanelCadCliente.BackColor = System.Drawing.Color.DimGray;
            this.lblPanelCadCliente.Location = new System.Drawing.Point(71, 172);
            this.lblPanelCadCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPanelCadCliente.Name = "lblPanelCadCliente";
            this.lblPanelCadCliente.Size = new System.Drawing.Size(153, 142);
            this.lblPanelCadCliente.TabIndex = 40;
            // 
            // frmMenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(699, 432);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.picCadCliente);
            this.Controls.Add(this.lblPanelCadCliente);
            this.Controls.Add(this.lblOpçãoMenuF);
            this.Controls.Add(this.lblSairMenuFunc);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.picEstoque);
            this.Controls.Add(this.picPedidos);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.bgPicPedidosFunc);
            this.Controls.Add(this.bgPicEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.PictureBox picEstoque;
        private System.Windows.Forms.PictureBox picPedidos;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label bgPicPedidosFunc;
        private System.Windows.Forms.Label bgPicEstoque;
        private System.Windows.Forms.Label lblSairMenuFunc;
        private System.Windows.Forms.Label lblOpçãoMenuF;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.PictureBox picCadCliente;
        private System.Windows.Forms.Label lblPanelCadCliente;
    }
}