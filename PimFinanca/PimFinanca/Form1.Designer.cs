namespace PimFinanca
{
    partial class frmRelatorios
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
            this.bntRelatorio = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntRelatorio
            // 
            this.bntRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.bntRelatorio.ForeColor = System.Drawing.Color.White;
            this.bntRelatorio.Location = new System.Drawing.Point(12, 66);
            this.bntRelatorio.Name = "bntRelatorio";
            this.bntRelatorio.Size = new System.Drawing.Size(245, 36);
            this.bntRelatorio.TabIndex = 0;
            this.bntRelatorio.Text = "Gerar relatório de Clientes";
            this.bntRelatorio.UseVisualStyleBackColor = false;
            this.bntRelatorio.Click += new System.EventHandler(this.bntRelatorio_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.bntFechar.Location = new System.Drawing.Point(248, 124);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(26, 24);
            this.bntFechar.TabIndex = 1;
            this.bntFechar.Text = "X";
            this.bntFechar.UseVisualStyleBackColor = false;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(15)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(286, 160);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.bntRelatorio);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntRelatorio;
        private System.Windows.Forms.Button bntFechar;
    }
}