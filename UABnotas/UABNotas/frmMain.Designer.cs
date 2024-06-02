using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace UABNotas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PDFexport = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabAnos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridSemestre1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSemestre2 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFolioA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFolioB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFolioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exames2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMediaSemestre1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdicionaUC1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMediaSemestre2 = new System.Windows.Forms.Label();
            this.btnAdicionaUC2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAnos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSemestre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSemestre2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txtIDAluno);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PDFexport);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 91);
            this.panel1.TabIndex = 0;
            // 
            // txtIDAluno
            // 
            this.txtIDAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDAluno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtIDAluno.Location = new System.Drawing.Point(288, 55);
            this.txtIDAluno.Name = "txtIDAluno";
            this.txtIDAluno.Size = new System.Drawing.Size(91, 20);
            this.txtIDAluno.TabIndex = 17;
            this.txtIDAluno.Validated += new System.EventHandler(this.txtIDAluno_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(230, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Aluno:";
            // 
            // PDFexport
            // 
            this.PDFexport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PDFexport.Location = new System.Drawing.Point(1039, 47);
            this.PDFexport.Name = "PDFexport";
            this.PDFexport.Size = new System.Drawing.Size(143, 32);
            this.PDFexport.TabIndex = 13;
            this.PDFexport.Text = "Exportar para PDF";
            this.PDFexport.UseVisualStyleBackColor = true;
            this.PDFexport.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(444, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(385, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(383, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(230, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Licenciatura em Engenharia Informática";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = global::UABNotas.Properties.Resources.uab;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 522);
            this.panel3.TabIndex = 6;
            // 
            // tabAnos
            // 
            this.tabAnos.Controls.Add(this.tabPage1);
            this.tabAnos.Controls.Add(this.tabPage2);
            this.tabAnos.Controls.Add(this.tabPage3);
            this.tabAnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabAnos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabAnos.ItemSize = new System.Drawing.Size(50, 20);
            this.tabAnos.Location = new System.Drawing.Point(24, 91);
            this.tabAnos.Name = "tabAnos";
            this.tabAnos.SelectedIndex = 0;
            this.tabAnos.Size = new System.Drawing.Size(1419, 26);
            this.tabAnos.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1411, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "1";
            this.tabPage1.Text = "1º Ano";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1411, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2º Ano";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1411, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3º Ano";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(24, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 10);
            this.panel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.59929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.40071F));
            this.tableLayoutPanel1.Controls.Add(this.gridSemestre1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridSemestre2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1419, 450);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gridSemestre1
            // 
            this.gridSemestre1.AllowUserToAddRows = false;
            this.gridSemestre1.AllowUserToDeleteRows = false;
            this.gridSemestre1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSemestre1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSemestre1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.exame,
            this.hnota});
            this.gridSemestre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSemestre1.Location = new System.Drawing.Point(3, 66);
            this.gridSemestre1.MultiSelect = false;
            this.gridSemestre1.Name = "gridSemestre1";
            this.gridSemestre1.ReadOnly = true;
            this.gridSemestre1.RowHeadersVisible = false;
            this.gridSemestre1.RowTemplate.Height = 25;
            this.gridSemestre1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSemestre1.ShowCellToolTips = false;
            this.gridSemestre1.ShowEditingIcon = false;
            this.gridSemestre1.Size = new System.Drawing.Size(697, 381);
            this.gridSemestre1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Unidade Curricular";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "eFolioA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "eFolioB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "eFolioC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "pFolio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // exame
            // 
            this.exame.HeaderText = "Exame";
            this.exame.Name = "exame";
            this.exame.ReadOnly = true;
            this.exame.Width = 50;
            // 
            // hnota
            // 
            this.hnota.HeaderText = "Nota";
            this.hnota.Name = "hnota";
            this.hnota.ReadOnly = true;
            this.hnota.Width = 80;
            // 
            // gridSemestre2
            // 
            this.gridSemestre2.AllowUserToAddRows = false;
            this.gridSemestre2.AllowUserToDeleteRows = false;
            this.gridSemestre2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSemestre2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSemestre2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.Column1,
            this.colCodigoUC,
            this.eFolioA,
            this.eFolioB,
            this.eFolioC,
            this.pFolio,
            this.exames2,
            this.nota2});
            this.gridSemestre2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSemestre2.Location = new System.Drawing.Point(706, 66);
            this.gridSemestre2.MultiSelect = false;
            this.gridSemestre2.Name = "gridSemestre2";
            this.gridSemestre2.ReadOnly = true;
            this.gridSemestre2.RowHeadersVisible = false;
            this.gridSemestre2.RowTemplate.Height = 25;
            this.gridSemestre2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSemestre2.ShowCellToolTips = false;
            this.gridSemestre2.ShowEditingIcon = false;
            this.gridSemestre2.Size = new System.Drawing.Size(710, 381);
            this.gridSemestre2.TabIndex = 12;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Unidade Curricular";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 280;
            // 
            // colCodigoUC
            // 
            this.colCodigoUC.HeaderText = "Código";
            this.colCodigoUC.Name = "colCodigoUC";
            this.colCodigoUC.ReadOnly = true;
            this.colCodigoUC.Width = 50;
            // 
            // eFolioA
            // 
            this.eFolioA.HeaderText = "eFolioA";
            this.eFolioA.Name = "eFolioA";
            this.eFolioA.ReadOnly = true;
            this.eFolioA.Width = 50;
            // 
            // eFolioB
            // 
            this.eFolioB.HeaderText = "eFolioB";
            this.eFolioB.Name = "eFolioB";
            this.eFolioB.ReadOnly = true;
            this.eFolioB.Width = 50;
            // 
            // eFolioC
            // 
            this.eFolioC.HeaderText = "eFolioC";
            this.eFolioC.Name = "eFolioC";
            this.eFolioC.ReadOnly = true;
            this.eFolioC.Width = 50;
            // 
            // pFolio
            // 
            this.pFolio.HeaderText = "pFolio";
            this.pFolio.Name = "pFolio";
            this.pFolio.ReadOnly = true;
            this.pFolio.Width = 50;
            // 
            // exames2
            // 
            this.exames2.HeaderText = "Exame";
            this.exames2.Name = "exames2";
            this.exames2.ReadOnly = true;
            this.exames2.Width = 50;
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Nota";
            this.nota2.Name = "nota2";
            this.nota2.ReadOnly = true;
            this.nota2.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(706, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo Semestre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Primeiro Semestre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lblMediaSemestre1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.btnAdicionaUC1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(697, 39);
            this.panel4.TabIndex = 15;
            // 
            // lblMediaSemestre1
            // 
            this.lblMediaSemestre1.AutoSize = true;
            this.lblMediaSemestre1.BackColor = System.Drawing.Color.White;
            this.lblMediaSemestre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaSemestre1.Location = new System.Drawing.Point(581, 10);
            this.lblMediaSemestre1.Name = "lblMediaSemestre1";
            this.lblMediaSemestre1.Size = new System.Drawing.Size(58, 18);
            this.lblMediaSemestre1.TabIndex = 17;
            this.lblMediaSemestre1.Text = "Média:";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(36, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 33);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sign-add-icon.png");
            this.imageList1.Images.SetKeyName(1, "sign-error-icon.png");
            this.imageList1.Images.SetKeyName(2, "Pencil-icon.png");
            // 
            // btnAdicionaUC1
            // 
            this.btnAdicionaUC1.FlatAppearance.BorderSize = 0;
            this.btnAdicionaUC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionaUC1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionaUC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionaUC1.ImageIndex = 0;
            this.btnAdicionaUC1.ImageList = this.imageList1;
            this.btnAdicionaUC1.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionaUC1.Name = "btnAdicionaUC1";
            this.btnAdicionaUC1.Size = new System.Drawing.Size(37, 33);
            this.btnAdicionaUC1.TabIndex = 11;
            this.btnAdicionaUC1.Tag = "1";
            this.btnAdicionaUC1.UseVisualStyleBackColor = true;
            this.btnAdicionaUC1.Click += new System.EventHandler(this.BtnAdicionaUC_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.lblMediaSemestre2);
            this.panel5.Controls.Add(this.btnAdicionaUC2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(706, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(710, 39);
            this.panel5.TabIndex = 16;
            // 
            // lblMediaSemestre2
            // 
            this.lblMediaSemestre2.AutoSize = true;
            this.lblMediaSemestre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaSemestre2.Location = new System.Drawing.Point(586, 10);
            this.lblMediaSemestre2.Name = "lblMediaSemestre2";
            this.lblMediaSemestre2.Size = new System.Drawing.Size(58, 18);
            this.lblMediaSemestre2.TabIndex = 15;
            this.lblMediaSemestre2.Text = "Média:";
            // 
            // btnAdicionaUC2
            // 
            this.btnAdicionaUC2.FlatAppearance.BorderSize = 0;
            this.btnAdicionaUC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionaUC2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionaUC2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionaUC2.ImageIndex = 0;
            this.btnAdicionaUC2.ImageList = this.imageList1;
            this.btnAdicionaUC2.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionaUC2.Name = "btnAdicionaUC2";
            this.btnAdicionaUC2.Size = new System.Drawing.Size(37, 33);
            this.btnAdicionaUC2.TabIndex = 12;
            this.btnAdicionaUC2.Tag = "2";
            this.btnAdicionaUC2.UseVisualStyleBackColor = true;
            this.btnAdicionaUC2.Click += new System.EventHandler(this.btnAdicionaUC2_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(73, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 33);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(70, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 33);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(35, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 33);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabAnos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "UAB Notas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAnos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSemestre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSemestre2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private Button btnAdicionaUC1;
        private Button btnAdicionaUC2;
        private System.Windows.Forms.TabControl tabAnos; // Público
        private Button PDFexport;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private ImageList imageList1;
        private Label label3;
        private Label label2;
        private DataGridView gridSemestre2;
        private DataGridView gridSemestre1_;
        private DataGridView gridSemestre1;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        
        private Label label4;
        private Label label7;
        private Label lblMediaSemestre2;

        public TextBox txtIDAluno;
        public TextBox txtNome;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn exame;
        private DataGridViewTextBoxColumn hnota;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colCodigoUC;
        private DataGridViewTextBoxColumn eFolioA;
        private DataGridViewTextBoxColumn eFolioB;
        private DataGridViewTextBoxColumn eFolioC;
        private DataGridViewTextBoxColumn pFolio;
        private DataGridViewTextBoxColumn exames2;
        private DataGridViewTextBoxColumn nota2;
        private Label lblMediaSemestre1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}