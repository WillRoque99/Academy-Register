
namespace CFB_acabdemia
{
    partial class F_login
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tnb_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(3, 29);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(124, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "borsa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(3, 75);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(124, 20);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.Text = "123";
            // 
            // tnb_logar
            // 
            this.tnb_logar.Location = new System.Drawing.Point(3, 101);
            this.tnb_logar.Name = "tnb_logar";
            this.tnb_logar.Size = new System.Drawing.Size(124, 28);
            this.tnb_logar.TabIndex = 4;
            this.tnb_logar.Text = "Logar";
            this.tnb_logar.UseVisualStyleBackColor = true;
            this.tnb_logar.Click += new System.EventHandler(this.tnb_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(3, 135);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 29);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 171);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tnb_logar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button tnb_logar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}