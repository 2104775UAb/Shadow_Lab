using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UABNotas
{
    class View
    {
        private frmMain window;
        private Model model;
        private ViewNovo windowNovo;

        private List<UnidadesCurriculares> listaUCs;
        private List<LinhaUC> listaSemestreAno;
        
        public event EventHandler CliqueNovaUC;


        public delegate void SolicitacaoListaUCS(ref List<UnidadesCurriculares> listadeUCS);
        public event SolicitacaoListaUCS PrecisoListaUCS;




        public delegate void AbaTabAlteradaEventHandler(object sender, EventArgs e);
        public event AbaTabAlteradaEventHandler AbaTabAlterada;

        //Novo Form para inserir novas unidades
        public delegate void NovaUCEventHandler(object sender, NovaUCEventArgs e);
        public event NovaUCEventHandler NovaUC;


        internal View(Model m)
        {
            model = m;
        }

        public void SetModel(Model m)
        {
            //console.writeline("SetModel");
            model = m;
            windowNovo = new ViewNovo(window);
        }

        private void PreparaMostraListaAnoSemestre()
        {
            listaSemestreAno = new List<LinhaUC>(); // Inicializar a lista
            model.ObterLinhasUCPorAno(window.tabAnos.SelectedIndex + 1, ref listaSemestreAno);
            window.ConstruirAnoSemestre(ref listaSemestreAno);
        }

        public void IniciarAplicacao()
        {
            window = new frmMain();
            window.View = this;
            PreparaMostraListaAnoSemestre();
            // Conectar evento de alteração de aba
            window.tabAnos.SelectedIndexChanged += TabAnos_SelectedIndexChanged;
            window.btnAdicionaUC.Click += OnCliqueNovaUC;

            window.ShowDialog();
;
        }

        public void AtualizaListaUCS()
        {
            Console.WriteLine("AtualizaListaUCS");
            PrecisoListaUCS(ref listaUCs);
            MostraListaUCs();
        }

        private void MostraListaUCs()
        {
            window.MostrarListaUCS(ref listaUCs);
        }

        private void TabAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disparar o evento AbaTabAlterada quando a aba for alterada
            PreparaMostraListaAnoSemestre();
            AbaTabAlterada?.Invoke(sender, e);
        }


        public class NovaUCEventArgs : EventArgs
        {
            public string NomeUC { get; set; }
        }

        public void BtnNovaUC_Click(object sender, EventArgs e)
        {
            frmNovo formNovo = new frmNovo();
            if (formNovo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OnNovaUC(new NovaUCEventArgs { NomeUC = formNovo.NomeUC });
            }
        }

        protected virtual void OnNovaUC(NovaUCEventArgs e)
        {
            NovaUC?.Invoke(this, e);
        }

 
        protected virtual void OnCliqueNovaUC(object sender, EventArgs e)
        {
            Console.WriteLine("View_NovaUC");
            windowNovo.AtivarViewLog(window.tabAnos.SelectedIndex + 1);
            windowNovo.AlterarLog("teste");

            CliqueNovaUC?.Invoke(sender, e);
        }

 
    }
}