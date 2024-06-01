using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using static UABNotas.View;

namespace UABNotas
{
    internal class Controller
    {
        private Model model;
        private View view;
        private SqlConnection connection;
        private string connectionString;
        private List<ListagemSemestreAno> listaSemestreAno;

        public Controller()
        {
            // Define a string de conexão
            string baseDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string databasePath = System.IO.Path.Combine(baseDirectory, "database", "uabnotas.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";

            // Inicializa a View sem o Model, o Model será inicializado depois da conexão
            view = new View(null);
        }

        public void IniciarPrograma()
        {
            try
            {
                // Inicializa a conexão com o banco de dados
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Inicializa o Model com a conexão aberta e a View
                model = new Model(view, connection);
                view.SetModel(model); // Atualiza a View para ter referência ao Model

                // Conecta eventos
                view.CliqueNovaUC += CliqueNovaUC;


                view.PrecisoListaUCS += model.SolicitarListaUCS;

                model.ListaDeUCNovas += view.AtualizaListaUCS;


                view.AbaTabAlterada += OnAbaTabAlterada; // Conectar evento


                view.NovaUC += View_NovaUC; // Conectar evento
                


                // Inicia a aplicação
                view.IniciarAplicacao();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Falha na conexão com a base de dados.", ex);
            }
        }

        private void View_NovaUC(object sender, NovaUCEventArgs e)
        {
            
            model.CriarNovaUC(e.NomeUC);
        }

        private void CliqueNovaUC(object sender, System.EventArgs args)
        {
            model.CriarNovaUC();
        }

        // Método para tratar a alteração da aba do TabControl
        private void OnAbaTabAlterada(object sender, EventArgs e)
        {
            Console.WriteLine("Aba do TabControl alterada");
            // Lógica adicional para tratar a mudança de aba pode ser adicionada aqui
        }
    }
}
