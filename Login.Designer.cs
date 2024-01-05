namespace ProjetoInter
{
    partial class frmLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.btnValidaAcesso = new System.Windows.Forms.Button();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblFraseLogin = new System.Windows.Forms.Label();
            this.picEncerar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLogin.Location = new System.Drawing.Point(281, 171);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(174, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.InputLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Location = new System.Drawing.Point(284, 246);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(171, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.BackColor = System.Drawing.Color.Azure;
            this.cmbFuncao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cmbFuncao.Location = new System.Drawing.Point(284, 287);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(171, 21);
            this.cmbFuncao.TabIndex = 5;
            this.cmbFuncao.Text = "Selecione sua função";
            // 
            // btnValidaAcesso
            // 
            this.btnValidaAcesso.BackColor = System.Drawing.Color.DarkOrange;
            this.btnValidaAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnValidaAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidaAcesso.Location = new System.Drawing.Point(330, 339);
            this.btnValidaAcesso.Name = "btnValidaAcesso";
            this.btnValidaAcesso.Size = new System.Drawing.Size(75, 23);
            this.btnValidaAcesso.TabIndex = 6;
            this.btnValidaAcesso.Text = "Entrar";
            this.btnValidaAcesso.UseVisualStyleBackColor = false;
            this.btnValidaAcesso.Click += new System.EventHandler(this.Logar);
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.BackColor = System.Drawing.Color.Peru;
            this.lblAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.MintCream;
            this.lblAtendimento.Location = new System.Drawing.Point(12, 422);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(274, 16);
            this.lblAtendimento.TabIndex = 8;
            this.lblAtendimento.Text = "Central de atendimento:(11)95361-8539";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblFraseLogin
            // 
            this.lblFraseLogin.AutoSize = true;
            this.lblFraseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraseLogin.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFraseLogin.Location = new System.Drawing.Point(293, 112);
            this.lblFraseLogin.Name = "lblFraseLogin";
            this.lblFraseLogin.Size = new System.Drawing.Size(137, 13);
            this.lblFraseLogin.TabIndex = 9;
            this.lblFraseLogin.Text = "Sign in to Bella Napoli ";
            // 
            // picEncerar
            // 
            this.picEncerar.Image = global::ProjetoInter.Properties.Resources.fechar;
            this.picEncerar.Location = new System.Drawing.Point(660, 12);
            this.picEncerar.Name = "picEncerar";
            this.picEncerar.Size = new System.Drawing.Size(38, 36);
            this.picEncerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEncerar.TabIndex = 14;
            this.picEncerar.TabStop = false;
            this.picEncerar.Click += new System.EventHandler(this.picEncerar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ProjetoInter.Properties.Resources.WhatsApp_Image_2023_0__1_;
            this.pbLogo.Location = new System.Drawing.Point(305, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(116, 97);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUser.Location = new System.Drawing.Point(281, 152);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(174, 16);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Username or email address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPassword.Location = new System.Drawing.Point(281, 227);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(710, 467);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.picEncerar);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblFraseLogin);
            this.Controls.Add(this.lblAtendimento);
            this.Controls.Add(this.btnValidaAcesso);
            this.Controls.Add(this.cmbFuncao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.Button btnValidaAcesso;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.ImageList imageList1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblFraseLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox picEncerar;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
    }
}