using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UABNotas
{
    internal class Model
    {
        private View view;
        private string connectionString;
        private SqlConnection connection;

        public delegate void NotificarListaUCsAlteradas();
        public event NotificarListaUCsAlteradas ListaDeUCNovas;

        public Model(View v, SqlConnection conn)
        {
            view = v;
            connection = conn;
        }



        public void ObterLinhasUCPorAno(int ano, ref List<LinhaUC> linhas)
        {
            try
            {
                string query = "SELECT id, linhasUC.ano, obs, semestre, descricao, efolioA, efolioB, efolioC, pFolio,exame, tipoAvaliacao, linhasUC.codigoUC " +
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
                            CodigoUC = !reader.IsDBNull(11) ? reader.GetInt32(11) : 0,
                            UCValores = new FormAdicionaUCValores
                            {
                                NotaEfolioA = !reader.IsDBNull(5) ? (float)reader.GetDecimal(5) : 0,
                                NotaEfolioB = !reader.IsDBNull(6) ? (float)reader.GetDecimal(6) : 0,
                                NotaEfolioC = !reader.IsDBNull(7) ? (float)reader.GetDecimal(7) : 0,
                                NotaGlobal = !reader.IsDBNull(8) ? (float)reader.GetDecimal(8) : 0,
                                NotaExame = !reader.IsDBNull(9) ? (float)reader.GetDecimal(9) : 0,
                                TipoAvaliacao = !reader.IsDBNull(10) ? reader.GetString(10)[0] : 'c'
                            }
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
                string query = "SELECT * FROM UC WHERE semestre=@semestre AND NOT EXISTS ( SELECT * FROM linhasUC WHERE linhasUC.codigoUC = UC.codigoUC and linhasUC.ano=@ano) ORDER BY descricao";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@semestre", semestre);
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
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao obter dados da tabela linhasUC.", ex);
            }
        }


        public bool InserirUCSemestre(int semestre, int ano, int codigoUC, float efolioA, float efolioB, float efolioC, float pFolio, char tipoAvaliacao)
        {

            //
            try
            {
                string query = "INSERT INTO linhasUC (codigoUC, ano, efolioA, efolioB, efolioC, pFolio,tipoAvaliacao  ) " +
                    "VALUES (@codigoUC, @ano, @efolioA, @efolioB, @efolioC, @pFolio, @tipoAvaliacao)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@codigoUC", codigoUC);
                    command.Parameters.AddWithValue("@ano", ano);
                    command.Parameters.AddWithValue("@efolioA", efolioA);
                    command.Parameters.AddWithValue("@efolioB", efolioB);
                    command.Parameters.AddWithValue("@efolioC", efolioC);
                    command.Parameters.AddWithValue("@pFolio", pFolio);
                    command.Parameters.AddWithValue("@tipoAvaliacao", tipoAvaliacao);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Notificar que a lista de UCs foi atualizada
                        ListaDeUCNovas?.Invoke();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao inserir dados na tabela.", ex);
                
            }

        }

        public void ObterAluno(ref List<Aluno> linhas)
        {
            try
            {
                string query = "SELECT * FROM aluno";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Aluno linha = new Aluno
                        {
                            Id = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : string.Empty,
                            Nome = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : string.Empty
                        };
                        linhas.Add(linha);
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao obter dados da tabela aluno.", ex);
            }
        }

        // Actualiza os dados do aluno, apaga tudo e insere novamente, precisa de optimização
        public bool ActualizaAluno(string Id, string nome)
        {
            try
            {
                string deleteQuery = "DELETE  FROM aluno";
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }
                string insertQuery = "INSERT INTO aluno (Id, nome) VALUES (@Id, @nome)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Id", Id);
                    insertCommand.Parameters.AddWithValue("@nome", nome);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Erro ao atualizar dados na tabela aluno.", ex);
            }
        }

        // Preparar dados para o PDF
        public void ObterLinhasPDF(ref List<LinhaUC> linhas)
        {
            try
            {
                string query = "SELECT id, linhasUC.ano, obs, semestre, descricao, efolioA, efolioB, efolioC, pFolio, exame, tipoAvaliacao, linhasUC.codigoUC " +
                        "FROM linhasUC " +
                        "LEFT JOIN UC ON linhasUC.codigoUC = UC.codigoUC " +
                        "ORDER BY linhasUC.ano, UC.semestre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                            CodigoUC = !reader.IsDBNull(11) ? reader.GetInt32(11) : 0,
                            UCValores = new FormAdicionaUCValores
                            {
                                NotaEfolioA = !reader.IsDBNull(5) ? (float)reader.GetDecimal(5) : 0,
                                NotaEfolioB = !reader.IsDBNull(6) ? (float)reader.GetDecimal(6) : 0,
                                NotaEfolioC = !reader.IsDBNull(7) ? (float)reader.GetDecimal(7) : 0,
                                NotaGlobal = !reader.IsDBNull(8) ? (float)reader.GetDecimal(8) : 0,
                                NotaExame = !reader.IsDBNull(9) ? (float)reader.GetDecimal(9) : 0,
                                TipoAvaliacao = !reader.IsDBNull(10) ? reader.GetString(10)[0] : 'c'
                            }
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




    }
}
