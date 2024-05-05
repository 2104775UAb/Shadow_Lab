using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UABNotas {
    public partial class frmMain : Form {
        private View view;

        public frmMain() {
            InitializeComponent();
        }

        public View View { get => view; set => view = value; }

        private void botaoNovaUC_Click(object sender, EventArgs e) {
            view.ClicouNovaUC(sender, e);
        }

        internal void MostrarListaUCS(ref List<UnidadesCurriculares> listaUCs) {

            // Exemplo de teste
            //textBox1.Clear();  
            foreach (UnidadesCurriculares uc in listaUCs)
            {
                textBox2.AppendText(uc.ToString() + Environment.NewLine);
            }
                
        }

        internal void ConstruirAnoSemestre(ref List<ListagemSemestreAno> listaUCs)
        {

            // Exemplo de teste
            textBox2.Clear();
            foreach (ListagemSemestreAno uc in listaUCs)
            {
                textBox2.AppendText(uc.ToString() + Environment.NewLine);
            }

        }


    }
}
