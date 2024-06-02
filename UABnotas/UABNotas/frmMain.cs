using System;
using System.Collections.Generic;
using System.Windows.Forms;

using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;

namespace UABNotas {
    public partial class frmMain : Form {
        private View view;
        
        public frmMain() {
            InitializeComponent();
        }

        internal View View { get; set; }

        // Construi a listas por ano e ambos os semestres com a estrutura de dados LinhaUC
        internal void ConstruirAnoSemestre(ref List<LinhaUC> listaUCs)
        {
            // Configurando o DataGridView para selecionar células individuais
            gridSemestre1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridSemestre2.SelectionMode = DataGridViewSelectionMode.CellSelect;

            gridSemestre1.Rows.Clear();
            gridSemestre2.Rows.Clear();

            NotaCalculada notasSemestre1 = new NotaCalculada();
            NotaCalculada notasSemestre2 = new NotaCalculada();

            foreach (var item in listaUCs)
            {
                List<object> cellValues = new List<object>();
           
                cellValues.Add(item.Id);
                cellValues.Add(item.Descricao);
                cellValues.Add(item.CodigoUC);
                cellValues.Add(item.UCValores.NotaEfolioA);
                cellValues.Add(item.UCValores.NotaEfolioB);
                cellValues.Add(item.UCValores.NotaEfolioC);
                cellValues.Add(item.UCValores.NotaGlobal);

                if (item.UCValores.TipoAvaliacao=='c')
                    cellValues.Add("");
                else
                    cellValues.Add(item.UCValores.NotaExame);
                
                var notaCalculada = item.UCValores.CalcularNota();
                cellValues.Add(notaCalculada);
                
                DataGridViewRow row;

                if (item.Semestre == 1)
                {
                    row = gridSemestre1.Rows[gridSemestre1.Rows.Add(cellValues.ToArray())];
                    notasSemestre1.AdicionarNota(notaCalculada);
                }
                else
                {
                    row = gridSemestre2.Rows[gridSemestre2.Rows.Add(cellValues.ToArray())];
                    notasSemestre2.AdicionarNota(notaCalculada);
                }
                    
                //  Coluna da nota calculada, mete a verde
                if (notaCalculada >= 9.5m)
                {
                    row.Cells[8].Style.BackColor = System.Drawing.Color.Green;
                    row.Cells[8].Style.ForeColor = System.Drawing.Color.White;
                }

            }

            // Atualizando os labels com as médias calculadas
            lblMediaSemestre1.Text = "Média : " + (notasSemestre1.GetQuantidade() > 0 ? notasSemestre1.CalcularMedia().ToString("F2") : "N/A");
            lblMediaSemestre2.Text = "Média : " + (notasSemestre2.GetQuantidade() > 0 ? notasSemestre2.CalcularMedia().ToString("F2") : "N/A");
            
        }

        private void BtnAdicionaUC_Click(object sender, EventArgs e)
        {
            // Código criado por Windows forms
        }

        private void btnAdicionaUC2_Click(object sender, EventArgs e)
        {
            // Código criado por Windows forms
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        internal void MostraAluno(List<Aluno> listaUCs)
        {
            foreach (var item in listaUCs)
            {
                txtIDAluno.Text = item.Id;
                txtNome.Text = item.Nome;   
                break;
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtIDAluno_Validated(object sender, EventArgs e)
        {

        }

        internal void MostraPDF(List<LinhaUC> listaUCs)
        {
            // Cria novo PDF
            PdfDocument pdfDocument = new PdfDocument();
            pdfDocument.Info.Title = "ShadowLAB";

            // Cria a págiona branca
            PdfPage pdfPage = pdfDocument.AddPage();
            XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Arial", 17);

            double PAGEwidth = pdfPage.Width.Point;
            double PAGEheight = pdfPage.Height.Point;

            // Draw the text
            xGraphics.DrawString("PDF DEMO", font, XBrushes.Black, new XRect(0, 0, PAGEwidth, 220), XStringFormats.Center);
                                 

            // Todas as linhas
            int ano = 0;
            int semestre = 0;
            int altura = 110; // inicio para escrever

            XPen corlinha = new XPen(XColors.DarkGray, 1);
            NotaCalculada notasMedia = new NotaCalculada();

            foreach (var item in listaUCs)
            {
                
                if (ano!= item.Ano)
                {
                    ano = item.Ano;
                    semestre = 0; //força o semestre quando muda de ano
                    font = new XFont("Arial", 14);
                    xGraphics.DrawString("Ano " + ano.ToString() , font, XBrushes.Black, new XRect(0, altura, PAGEwidth, 50), XStringFormats.Center);
                    altura += 20;
                }
                
                if (semestre != item.Semestre)
                {
                    semestre = item.Semestre;
                    font = new XFont("Arial", 12);
                    xGraphics.DrawString("Semestre " + semestre.ToString(), font, XBrushes.Black, new XRect(0, altura, PAGEwidth, 45), XStringFormats.Center);
                    altura += 50;
                }

                // Mostras as unidades                
                var notaCalculada = item.UCValores.CalcularNota();
                font = new XFont("Arial", 12);
                xGraphics.DrawString(item.Descricao.ToString(), font, XBrushes.Black, new XRect(60, altura, PAGEwidth, 0), new XStringFormat { Alignment = XStringAlignment.Near, LineAlignment = XLineAlignment.BaseLine });
                xGraphics.DrawString(notaCalculada.ToString("00.00"), font, XBrushes.Black, new XRect(500, altura, PAGEwidth, 0), new XStringFormat { Alignment = XStringAlignment.Near, LineAlignment = XLineAlignment.BaseLine });
                xGraphics.DrawLine(corlinha, 50, altura+5, PAGEwidth - 50, altura+5);
                altura += 25;
                notasMedia.AdicionarNota(notaCalculada);
            }

            string mediaFinal="Média Final: " + (notasMedia.GetQuantidade() > 0 ? notasMedia.CalcularMedia().ToString("F2") : "N/A");
            altura += 50;
            font = new XFont("Arial", 15);
            corlinha = new XPen(XColors.DarkGray, 4);
            xGraphics.DrawLine(corlinha, 50, altura+5, PAGEwidth - 50, altura+5);
            xGraphics.DrawString(mediaFinal, font, XBrushes.Black, new XRect(410, altura, PAGEwidth, 0), new XStringFormat { Alignment = XStringAlignment.Near, LineAlignment = XLineAlignment.BaseLine });

                        
            // Grava o ficheiro pdf na pasta da Aplicação e abre no program predefino para PDFs

            string baseDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            XImage image = XImage.FromFile(baseDirectory + "\\assets\\imgs\\shadow_small.jpg");
            xGraphics.DrawImage(image, 270, 20, 50, 72);

            string tempFile = baseDirectory + "UABNotas_ShadowLAB.pdf";
            pdfDocument.Save(tempFile);

            System.Diagnostics.Process.Start(tempFile);


        }




    }
}
