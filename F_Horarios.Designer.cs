
namespace CFB_acabdemia
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_idhorario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Horario = new System.Windows.Forms.DataGridView();
            this.Btn_NovoHorario = new System.Windows.Forms.Button();
            this.Btn_SalvarHorario = new System.Windows.Forms.Button();
            this.Btn_ExcluirHorario = new System.Windows.Forms.Button();
            this.Btn_FecharHorario = new System.Windows.Forms.Button();
            this.Mtb_DscHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Tb_idhorario
            // 
            this.Tb_idhorario.Location = new System.Drawing.Point(12, 25);
            this.Tb_idhorario.Name = "Tb_idhorario";
            this.Tb_idhorario.ReadOnly = true;
            this.Tb_idhorario.Size = new System.Drawing.Size(57, 20);
            this.Tb_idhorario.TabIndex = 1;
            this.Tb_idhorario.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horarios";
            // 
            // Dgv_Horario
            // 
            this.Dgv_Horario.AllowUserToAddRows = false;
            this.Dgv_Horario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Horario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horario.EnableHeadersVisualStyles = false;
            this.Dgv_Horario.Location = new System.Drawing.Point(12, 58);
            this.Dgv_Horario.Name = "Dgv_Horario";
            this.Dgv_Horario.ReadOnly = true;
            this.Dgv_Horario.RowHeadersVisible = false;
            this.Dgv_Horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Horario.Size = new System.Drawing.Size(317, 252);
            this.Dgv_Horario.TabIndex = 4;
            this.Dgv_Horario.SelectionChanged += new System.EventHandler(this.Dgv_Horario_SelectionChanged);
            // 
            // Btn_NovoHorario
            // 
            this.Btn_NovoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovoHorario.Location = new System.Drawing.Point(3, 3);
            this.Btn_NovoHorario.Name = "Btn_NovoHorario";
            this.Btn_NovoHorario.Size = new System.Drawing.Size(75, 23);
            this.Btn_NovoHorario.TabIndex = 7;
            this.Btn_NovoHorario.Text = "Novo Horario";
            this.Btn_NovoHorario.UseVisualStyleBackColor = true;
            this.Btn_NovoHorario.Click += new System.EventHandler(this.Btn_NovoHorario_Click);
            // 
            // Btn_SalvarHorario
            // 
            this.Btn_SalvarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarHorario.Location = new System.Drawing.Point(85, 3);
            this.Btn_SalvarHorario.Name = "Btn_SalvarHorario";
            this.Btn_SalvarHorario.Size = new System.Drawing.Size(75, 23);
            this.Btn_SalvarHorario.TabIndex = 8;
            this.Btn_SalvarHorario.Text = "Salvar horario";
            this.Btn_SalvarHorario.UseVisualStyleBackColor = true;
            this.Btn_SalvarHorario.Click += new System.EventHandler(this.Btn_SalvarHorario_Click);
            // 
            // Btn_ExcluirHorario
            // 
            this.Btn_ExcluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExcluirHorario.Location = new System.Drawing.Point(166, 3);
            this.Btn_ExcluirHorario.Name = "Btn_ExcluirHorario";
            this.Btn_ExcluirHorario.Size = new System.Drawing.Size(75, 23);
            this.Btn_ExcluirHorario.TabIndex = 9;
            this.Btn_ExcluirHorario.Text = "Excluir Horario";
            this.Btn_ExcluirHorario.UseVisualStyleBackColor = true;
            this.Btn_ExcluirHorario.Click += new System.EventHandler(this.Btn_ExcluirHorario_Click);
            // 
            // Btn_FecharHorario
            // 
            this.Btn_FecharHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FecharHorario.Location = new System.Drawing.Point(255, 3);
            this.Btn_FecharHorario.Name = "Btn_FecharHorario";
            this.Btn_FecharHorario.Size = new System.Drawing.Size(74, 23);
            this.Btn_FecharHorario.TabIndex = 10;
            this.Btn_FecharHorario.Text = "Fechar";
            this.Btn_FecharHorario.UseVisualStyleBackColor = true;
            this.Btn_FecharHorario.Click += new System.EventHandler(this.Bt_FecharHorario_Click);
            // 
            // Mtb_DscHorario
            // 
            this.Mtb_DscHorario.Location = new System.Drawing.Point(74, 25);
            this.Mtb_DscHorario.Mask = "00:00  \\até  00:00";
            this.Mtb_DscHorario.Name = "Mtb_DscHorario";
            this.Mtb_DscHorario.Size = new System.Drawing.Size(94, 20);
            this.Mtb_DscHorario.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_NovoHorario);
            this.panel1.Controls.Add(this.Btn_SalvarHorario);
            this.panel1.Controls.Add(this.Btn_FecharHorario);
            this.panel1.Controls.Add(this.Btn_ExcluirHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 33);
            this.panel1.TabIndex = 12;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Mtb_DscHorario);
            this.Controls.Add(this.Dgv_Horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_idhorario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_idhorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Horario;
        private System.Windows.Forms.Button Btn_NovoHorario;
        private System.Windows.Forms.Button Btn_SalvarHorario;
        private System.Windows.Forms.Button Btn_ExcluirHorario;
        private System.Windows.Forms.Button Btn_FecharHorario;
        private System.Windows.Forms.MaskedTextBox Mtb_DscHorario;
        private System.Windows.Forms.Panel panel1;
    }
}