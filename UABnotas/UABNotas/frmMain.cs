using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using static UABNotas.View;

namespace UABNotas {
    public partial class frmMain : Form {
        private View view;
        
        public frmMain() {
            InitializeComponent();
        }

        internal View View { get; set; }


        internal void MostrarListaUCS(ref List<UnidadesCurriculares> listaUCs) {

            // Exemplo de teste
            //textBox1.Clear();  
            foreach (UnidadesCurriculares uc in listaUCs)
            {
               // textBox2.AppendText(uc.ToString() + Environment.NewLine);
            }
                
        }
        
        internal void ConstruirAnoSemestre(ref List<LinhaUC> listaUCs)
        {
            Console.WriteLine("here");

            gridSemestre1.Rows.Clear();
            gridSemestre2.Rows.Clear();

            foreach (var item in listaUCs)
            {
                List<object> cellValues = new List<object>();
                
                //Console.WriteLine($"Id: {item.Id}, Ano: {item.Ano}, Obs: {item.Obs},
                //Semestre: {item.Semestre}, Descricao: {item.Descricao}, EfolioA: {item.EfolioA},
                //EfolioB: {item.EfolioB}, EfolioC: {item.EfolioC}, PFolio: {item.PFolio}, CodigoUC: {item.CodigoUC}");
             
                cellValues.Add(item.Id);
                cellValues.Add(item.Descricao);
                cellValues.Add(item.CodigoUC);
                cellValues.Add(item.EfolioA);
                cellValues.Add(item.EfolioB);
                cellValues.Add(item.EfolioC);
                cellValues.Add(item.PFolio);

                if (item.Semestre == 1)
                    gridSemestre1.Rows.Add(cellValues.ToArray());
                else
                    gridSemestre2.Rows.Add(cellValues.ToArray());
             
            }
        }

        private void BtnAdicionaUC_Click(object sender, EventArgs e)
        {




            /*    if (View != null)
                {


                    Console.WriteLine("View_NovaUC");
                    //   View.ClicouNovaUC(sender, e);
                }*/
        }

        private void btnAdicionaUC2_Click(object sender, EventArgs e)
        {

        }
    }
}
