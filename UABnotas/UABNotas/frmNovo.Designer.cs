namespace UABNotas
{
    partial class frmNovo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNomeUC;
        private System.Windows.Forms.Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNomeUC = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeUC
            // 
            this.txtNomeUC.Location = new System.Drawing.Point(12, 12);
            this.txtNomeUC.Name = "txtNomeUC";
            this.txtNomeUC.Size = new System.Drawing.Size(271, 20);
            this.txtNomeUC.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(208, 274);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNovo
            // 
            this.ClientSize = new System.Drawing.Size(317, 309);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeUC);
            this.Name = "frmNovo";
            this.Text = "Nova Unidade Curricular";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
