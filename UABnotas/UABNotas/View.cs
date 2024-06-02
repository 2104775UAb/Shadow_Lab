using System;
using System.Collections.Generic;

namespace UABNotas
{
    class View
    {
        private frmMain window;
        private Model model;
        private ViewNovo windowNovo;
        private List<LinhaUC> listaSemestreAno;

        public event EventHandler CliqueNovaUC;
        public event EventHandler CliquePDF;

        public delegate void AbaTabAlteradaEventHandler(object sender, EventArgs e);
        public event AbaTabAlteradaEventHandler AbaTabAlterada;

        // Delegado e evento para a validação do txtNome
        public delegate void TxtNomeValidatedEventHandler(object sender, EventArgs e);
        public event TxtNomeValidatedEventHandler TxtNomeValidated;



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
            // Conectar o evento de validação do txtNome
            window.txtNome.Validated += TxtNome_Validated;
            window.txtIDAluno.Validated += TxtNome_Validated;

            window.PDFexport.Click += OnCliquePDF;

            window.btnAdicionaUC1.Click += OnCliqueNovaUC;
            window.btnAdicionaUC2.Click += OnCliqueNovaUC2;
            // Mostra nas caixas de texto os dados do aluno
            MostraDadosAluno();
            window.ShowDialog();

        }

        // Actualiza a lista pelo ano e semestre, é chamado pelo modal quando existe novo unidade ou actualização de dados
        public void AtualizaListaUCS()
        {
            PreparaMostraListaAnoSemestre();
        }


        public void MostraDadosAluno()
        {
            List<Aluno> aluno_mostra = new List<Aluno>();
            model.ObterAluno(ref aluno_mostra);
            window.MostraAluno(aluno_mostra);
        }


        // Método para disparar o evento para actualizar o nome
        private void TxtNome_Validated(object sender, EventArgs e)
        {
            
            model.ActualizaAluno(window.txtIDAluno.Text, window.txtNome.Text  );
          //  TxtNomeValidated?.Invoke(sender, e);
        }

        private void TabAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disparar o evento AbaTabAlterada quando a aba for alterada
            PreparaMostraListaAnoSemestre();
        }

        //Abre novo form para adicionar uma nova unidade na lista, para o semestre 1
        protected virtual void OnCliqueNovaUC(object sender, EventArgs e)
        {
            windowNovo.AtivarViewNovo(window.tabAnos.SelectedIndex + 1, 1, model);
        }

        //Abre novo form para adicionar uma nova unidade na lista, para o semestre 2
        protected virtual void OnCliqueNovaUC2(object sender, EventArgs e)
        {
            windowNovo.AtivarViewNovo(window.tabAnos.SelectedIndex + 1, 2, model);
        }

        // Exporta PDF
        protected virtual void OnCliquePDF(object sender, EventArgs e)
        {
            List<LinhaUC> listaUnidades = new List<LinhaUC>();
            model.ObterLinhasPDF(ref listaUnidades);
            window.MostraPDF(listaUnidades);
        }



    }
}