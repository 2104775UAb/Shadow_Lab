using System;
using System.Collections.Generic;


namespace UABNotas
{
    public class View
    {
        private frmMain window;
        private Model model;

        private List<UnidadesCurriculares> listaUCs;

        private List<ListagemSemestreAno> listaSemestreAno;

        public event EventHandler CliqueNovaUC;
        public delegate void SolicitacaoListaUCS(ref List<UnidadesCurriculares> listadeUCS);
        public event SolicitacaoListaUCS PrecisoListaUCS;
        

        internal View(Model m)
        {
            model = m;
        }

        public void IniciarAplicacao()
        {
            window = new frmMain();
            window.View = this;
            model = new Model(this);
            model.SolicitaUltimosDados(ref listaSemestreAno);
            window.ConstruirAnoSemestre(ref listaSemestreAno);

/*            foreach (var item in listaSemestreAno)
            {
                Console.WriteLine($"ID: {item.ID}, Nome: {item.Nome}");
            }*/
           
            window.ShowDialog();
           

        }

        public void AtualizaListaUCS()
        {
            PrecisoListaUCS(ref listaUCs);
            MostraListaUCs();
        }

        void MostraListaUCs()
        {
            window.MostrarListaUCS(ref listaUCs);
        }


        public void ClicouNovaUC(object sender, EventArgs e)
        {
            CliqueNovaUC(this, e);
        }

    }
}
