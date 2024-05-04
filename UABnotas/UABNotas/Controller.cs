using System;
using System.Collections.Generic;

namespace UABNotas
{
    class Controller
    {
        Model model;
        View view;

        private List<ListagemSemestreAno> listaSemestreAno;
        public Controller()
        {
            view = new View(model);
            model = new Model(view);

            

            view.CliqueNovaUC += CliqueNovaUC;
            view.PrecisoListaUCS += model.SolicitarListaUCS;
            model.ListaDeFormasAlteradas += view.AtualizaListaUCS;

          /*  view.PrecisoListaAnoSemestre += model.SolicitaUltimosDados;
            model.ListaUltimosDados += view.AtualizaListaUCS;*/
            


        }

        public void IniciarPrograma()
        {
                try
                {
                    view.IniciarAplicacao();
                }
                catch (Exception e)
                {
                    //Verifica ligação a base dados, em caso de falha mostra erro e termina aplicação
                    Console.WriteLine("Erro abrir a Base Dados!");
                }
        }
        public void CliqueNovaUC(object sender, System.EventArgs args)
        {
            model.CriarNovaUC();
            

        }

    }
}