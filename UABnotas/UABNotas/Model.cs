using System;
using System.Collections.Generic;


namespace UABNotas
{

    class Model
    {
        private View view;
        List<UnidadesCurriculares> UCS;

        public delegate void NotificarListaUCsAlteradas();
        public event NotificarListaUCsAlteradas ListaDeUCNovas;

        public Model(View v)
        {
            view = v;
            UCS = new List<UnidadesCurriculares>();
        }

        public void CriarNovaUC()
        {
            UnidadesCurriculares uc = new UnidadesCurriculares();
            //exemplo de teste
            uc.ID = 1;
            uc.Nome = "Nova Unidade Teste";
            UCS.Add(uc);
            ListaDeUCNovas();
        }


        public void SolicitarListaUCS(ref List<UnidadesCurriculares> listaUCS)
        {
            listaUCS = new List<UnidadesCurriculares>();
            foreach (UnidadesCurriculares fd in UCS)
            {
                listaUCS.Add(fd.Clone());
            }
        }

    
        public void SolicitaUltimosDados(ref List<ListagemSemestreAno> ListagemSAno)
        {
            ListagemSAno = new List<ListagemSemestreAno>
            {
                new ListagemSemestreAno { ID = 1, Nome = "Unidade Teste" },
                new ListagemSemestreAno { ID = 2, Nome = "Unidade Teste 2" },
                new ListagemSemestreAno { ID = 3, Nome = "Unidade Teste 3" }

            };
        }

    }
}
