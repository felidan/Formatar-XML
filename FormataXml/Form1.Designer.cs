namespace FormataXml
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
            this.odf = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnSelecionarDestino = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoSelecionar = new System.Windows.Forms.Label();
            this.btmFormatar = new System.Windows.Forms.Button();
            this.lblSelArqu = new System.Windows.Forms.Label();
            this.lblSalvaArqu = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.ckInputTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // odf
            // 
            this.odf.FileName = "openFileDialog";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(41, 62);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(341, 22);
            this.txtArquivo.TabIndex = 0;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(388, 61);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(116, 23);
            this.btnSelecionarArquivo.TabIndex = 1;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(41, 114);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(340, 22);
            this.txtDestino.TabIndex = 2;
            // 
            // btnSelecionarDestino
            // 
            this.btnSelecionarDestino.Location = new System.Drawing.Point(388, 114);
            this.btnSelecionarDestino.Name = "btnSelecionarDestino";
            this.btnSelecionarDestino.Size = new System.Drawing.Size(116, 23);
            this.btnSelecionarDestino.TabIndex = 3;
            this.btnSelecionarDestino.Text = "Selecionar";
            this.btnSelecionarDestino.UseVisualStyleBackColor = true;
            this.btnSelecionarDestino.Click += new System.EventHandler(this.btnSelecionarDestino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecionar local de salvamento";
            // 
            // lblInfoSelecionar
            // 
            this.lblInfoSelecionar.AutoSize = true;
            this.lblInfoSelecionar.Location = new System.Drawing.Point(8, 42);
            this.lblInfoSelecionar.Name = "lblInfoSelecionar";
            this.lblInfoSelecionar.Size = new System.Drawing.Size(230, 17);
            this.lblInfoSelecionar.TabIndex = 5;
            this.lblInfoSelecionar.Text = "Selecionar arquivo a ser formatado";
            // 
            // btmFormatar
            // 
            this.btmFormatar.Location = new System.Drawing.Point(11, 182);
            this.btmFormatar.Name = "btmFormatar";
            this.btmFormatar.Size = new System.Drawing.Size(493, 42);
            this.btmFormatar.TabIndex = 6;
            this.btmFormatar.Text = "FORMATAR";
            this.btmFormatar.UseVisualStyleBackColor = true;
            this.btmFormatar.Click += new System.EventHandler(this.btmFormatar_Click);
            // 
            // lblSelArqu
            // 
            this.lblSelArqu.AutoSize = true;
            this.lblSelArqu.Location = new System.Drawing.Point(12, 66);
            this.lblSelArqu.Name = "lblSelArqu";
            this.lblSelArqu.Size = new System.Drawing.Size(27, 17);
            this.lblSelArqu.TabIndex = 7;
            this.lblSelArqu.Text = "ER";
            // 
            // lblSalvaArqu
            // 
            this.lblSalvaArqu.AutoSize = true;
            this.lblSalvaArqu.Location = new System.Drawing.Point(12, 118);
            this.lblSalvaArqu.Name = "lblSalvaArqu";
            this.lblSalvaArqu.Size = new System.Drawing.Size(27, 17);
            this.lblSalvaArqu.TabIndex = 8;
            this.lblSalvaArqu.Text = "ER";
            // 
            // lblLog
            // 
            this.lblLog.Location = new System.Drawing.Point(15, 140);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(489, 39);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "X";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckInputTexto
            // 
            this.ckInputTexto.AutoSize = true;
            this.ckInputTexto.Location = new System.Drawing.Point(11, 13);
            this.ckInputTexto.Name = "ckInputTexto";
            this.ckInputTexto.Size = new System.Drawing.Size(128, 21);
            this.ckInputTexto.TabIndex = 10;
            this.ckInputTexto.Text = "Input por texto?";
            this.ckInputTexto.UseVisualStyleBackColor = true;
            this.ckInputTexto.CheckedChanged += new System.EventHandler(this.ckInputTexto_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 236);
            this.Controls.Add(this.ckInputTexto);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblSalvaArqu);
            this.Controls.Add(this.lblSelArqu);
            this.Controls.Add(this.btmFormatar);
            this.Controls.Add(this.lblInfoSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionarDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Formatar XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog odf;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSelecionarDestino;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoSelecionar;
        private System.Windows.Forms.Button btmFormatar;
        private System.Windows.Forms.Label lblSelArqu;
        private System.Windows.Forms.Label lblSalvaArqu;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.CheckBox ckInputTexto;
    }
}

