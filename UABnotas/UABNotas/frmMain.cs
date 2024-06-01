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

        private void botaoNovaUC_Click(object sender, EventArgs e) {

/*            frmNovo formNovo = new frmNovo();
            if (formNovo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
             //   OnNovaUC(new NovaUCEventArgs { NomeUC = formNovo.NomeUC });
            }*/

           // view.BtnNovaUC_Click(null,null);
            //view.ClicouNovaUC(sender, e);
        }

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


            // Criar uma lista de objetos para armazenar os valores das células


            // Adicionar os valores das células à lista de objetos
            // Adicionar uma nova linha à DataGridView com os valores das células



            // Exemplo de teste
            /* textBox2.Clear();
             foreach (ListagemSemestreAno uc in listaUCs)
             {
                 textBox2.AppendText(uc.ToString() + Environment.NewLine);
             }*/

        }

        private void BtnAdicionaUC_Click(object sender, EventArgs e)
        {
            if (View != null)
            {


                Console.WriteLine("View_NovaUC");
                //   View.ClicouNovaUC(sender, e);
            }
        }


    }
}
