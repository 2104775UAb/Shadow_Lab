using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace UABNotas
{
    internal class Model
    {
        private View view;
        private List<UnidadesCurriculares> UCS;
        private string connectionString;
        private SqlConnection connection;

        public delegate void NotificarListaUCsAlteradas();
        public event NotificarListaUCsAlteradas ListaDeUCNovas;

        public Model(View v, SqlConnection conn)
        {
            view = v;
            UCS = new List<UnidadesCurriculares>();
            connection = conn;
        }

        private void CarregarDados()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Nome FROM UnidadesCurriculares";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnidadesCurriculares uc = new UnidadesCurriculares
                        {
                            ID = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        };
                        UCS.Add(uc);
                    }
                }
            }
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

        public void CriarNovaUC(string nomeUC)
        {
            UnidadesCurriculares uc = new UnidadesCurriculares();
            //exemplo de teste
            uc.ID = 1;
            uc.Nome = nomeUC;
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

        public void SolicitaUltimosDados(ref List<LinhaUC> ListagemSAno)
        {
            Console.WriteLine("SolicitaUltimosDados");
            ListagemSAno = new List<LinhaUC>
            {
                /*  new ListagemSemestreAno { ID = 1, Nome = "Unidade Teste" },
                  new ListagemSemestreAno { ID = 2, Nome = "Unidade Teste 2" },
                  new ListagemSemestreAno { ID = 3, Nome = "Unidade Teste 3" }*/
            };
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

        public void ObterLinhasUCPorAno(int ano, ref List<LinhaUC> linhas)
        {
            try
            {
                string query = "SELECT id, linhasUC.ano, obs, semestre, descricao, efolioA, efolioB, efolioC, pFolio, linhasUC.codigoUC " +
                               "FROM linhasUC " +
                               "LEFT JOIN UC ON linhasUC.codigoUC=UC.codigoUC " +
                               "WHERE linhasUC.ano=@ano";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ano", ano);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        LinhaUC linha = new LinhaUC
                        {
                            Id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                            Ano = !reader.IsDBNull(1) ? reader.GetByte(1) : (byte)0,
                            Obs = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : string.Empty,
                            Semestre = !reader.IsDBNull(1) ? reader.GetByte(3) : (byte)0,
                            Descricao = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : string.Empty,
                            EfolioA = !reader.IsDBNull(5) ? reader.GetDecimal(5) : 0,
                            EfolioB = !reader.IsDBNull(6) ? reader.GetDecimal(6) : 0,
                            EfolioC = !reader.IsDBNull(7) ? reader.GetDecimal(7) : 0,
                            PFolio = !reader.IsDBNull(8) ? reader.GetDecimal(8) : 0,
                            CodigoUC = !reader.IsDBNull(9) ? reader.GetInt32(9) : 0
                        };
                        linhas.Add(linha);
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao obter dados da tabela linhasUC.", ex);
            }
        }




        public void ObterUCCombox(int ano, int semestre, ref List<UCInfo> listaUCInfo)
        {
            try
            {
                string query = "SELECT codigoUC, descricao FROM linhasUC WHERE ano=@ano";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ano", ano);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UCInfo ucInfo = new UCInfo
                        {
                            CodigoUC = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                            Descricao = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : string.Empty
                        };
                        listaUCInfo.Add(ucInfo);
                    }
                    reader.Close();
                }

                // Notificar que a lista de UCs foi atualizada
                ListaDeUCNovas?.Invoke();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao obter dados da tabela linhasUC.", ex);
            }
        }






    }
}
