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
            model.ListaDeUCNovas += view.AtualizaListaUCS;   
        }



        public void IniciarPrograma()
        {
                try
                {
                    //Tenta abrir a base dados sqlserver localdb
                    view.IniciarAplicacao();
                }
                catch (ExceptionDataBase ex)
                {
                    //Verifica ligação a base dados, em caso de falha mostra erro e termina aplicação
                    throw new ExceptionDataBase("Falha na conexão com a base de dados.", ex);
                    
                }
        }
        public void CliqueNovaUC(object sender, System.EventArgs args)
        {
            model.CriarNovaUC();
            

        }

    }
}