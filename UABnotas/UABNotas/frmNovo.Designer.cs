namespace UABNotas
{
    partial class frmNovo
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.Button btnSalvar;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovo));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbUC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selExame = new System.Windows.Forms.RadioButton();
            this.selContinua = new System.Windows.Forms.RadioButton();
            this.notaEfolioA = new System.Windows.Forms.NumericUpDown();
            this.notaEfolioB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notaGlobal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.notaEfolioC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageIndex = 0;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(121, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 43);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-icon.png");
            // 
            // cmbUC
            // 
            this.cmbUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUC.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUC.FormattingEnabled = true;
            this.cmbUC.Location = new System.Drawing.Point(12, 41);
            this.cmbUC.Name = "cmbUC";
            this.cmbUC.Size = new System.Drawing.Size(357, 24);
            this.cmbUC.TabIndex = 2;
            this.cmbUC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selExame);
            this.groupBox1.Controls.Add(this.selContinua);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regime de avaliação";
            // 
            // selExame
            // 
            this.selExame.AutoSize = true;
            this.selExame.Location = new System.Drawing.Point(207, 30);
            this.selExame.Name = "selExame";
            this.selExame.Size = new System.Drawing.Size(121, 20);
            this.selExame.TabIndex = 5;
            this.selExame.Text = "Avaliação Final";
            this.selExame.UseVisualStyleBackColor = true;
            // 
            // selContinua
            // 
            this.selContinua.AutoSize = true;
            this.selContinua.Checked = true;
            this.selContinua.Location = new System.Drawing.Point(16, 30);
            this.selContinua.Name = "selContinua";
            this.selContinua.Size = new System.Drawing.Size(147, 20);
            this.selContinua.TabIndex = 4;
            this.selContinua.TabStop = true;
            this.selContinua.Text = "Avaliação Continua";
            this.selContinua.UseVisualStyleBackColor = true;
            // 
            // notaEfolioA
            // 
            this.notaEfolioA.DecimalPlaces = 2;
            this.notaEfolioA.Location = new System.Drawing.Point(105, 175);
            this.notaEfolioA.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.notaEfolioA.Name = "notaEfolioA";
            this.notaEfolioA.Size = new System.Drawing.Size(70, 20);
            this.notaEfolioA.TabIndex = 5;
            // 
            // notaEfolioB
            // 
            this.notaEfolioB.DecimalPlaces = 2;
            this.notaEfolioB.Location = new System.Drawing.Point(105, 215);
            this.notaEfolioB.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.notaEfolioB.Name = "notaEfolioB";
            this.notaEfolioB.Size = new System.Drawing.Size(70, 20);
            this.notaEfolioB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "efolioB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "efolioA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Global:";
            // 
            // notaGlobal
            // 
            this.notaGlobal.DecimalPlaces = 2;
            this.notaGlobal.Location = new System.Drawing.Point(105, 257);
            this.notaGlobal.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.notaGlobal.Name = "notaGlobal";
            this.notaGlobal.Size = new System.Drawing.Size(70, 20);
            this.notaGlobal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "efolioC:";
            // 
            // notaEfolioC
            // 
            this.notaEfolioC.DecimalPlaces = 2;
            this.notaEfolioC.Location = new System.Drawing.Point(270, 209);
            this.notaEfolioC.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.notaEfolioC.Name = "notaEfolioC";
            this.notaEfolioC.Size = new System.Drawing.Size(70, 20);
            this.notaEfolioC.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Escolha a Unidade Curricular:";
            // 
            // frmNovo
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(381, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notaEfolioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notaGlobal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notaEfolioB);
            this.Controls.Add(this.notaEfolioA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUC);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNovo";
            this.Text = "Nova Unidade Curricular";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaEfolioC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selExame;
        private System.Windows.Forms.RadioButton selContinua;
        private System.Windows.Forms.NumericUpDown notaEfolioA;
        private System.Windows.Forms.NumericUpDown notaEfolioB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown notaGlobal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown notaEfolioC;
        private System.Windows.Forms.Label label5;
    }
}
