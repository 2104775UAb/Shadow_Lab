using System;
using System.Data.SqlClient;
using System.IO;


namespace UABNotas
{
    internal class Controller
    {
        private Model model;
        private View view;
        private SqlConnection connection;
        private string connectionString;
 

        public Controller()
        {
            // Define a string de conexão
            string baseDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string databasePath = System.IO.Path.Combine(baseDirectory, "database", "uabnotas.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
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
                view = new View(null);
                view.SetModel(model); // Atualiza a View para ter referência ao Model


                // Conecta eventos
                view.CliqueNovaUC += CliquePDF;
                view.CliqueNovaUC += CliqueNovaUC;

                model.ListaDeUCNovas += view.AtualizaListaUCS;
                view.AbaTabAlterada += OnAbaTabAlterada;
                // Conectar o evento para mostrar o nome
                view.TxtNomeValidated += NomeID_Validated;


                // Inicia a aplicação
                view.IniciarAplicacao();

            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Falha na conexão com a base de dados.", ex);
            }
        }

 
        private void CliqueNovaUC(object sender, System.EventArgs args)
        {
            Console.WriteLine("View_NovaUC2");
         //   model.CriarNovaUC("tste");
        }

        private void CliquePDF(object sender, System.EventArgs args)
        {
            Console.WriteLine("View_NovaUC2");
            //   model.CriarNovaUC("tste");
        }

        private void NomeID_Validated(object sender, EventArgs e)
        {
            // Implementação do que deve ocorrer quando txtNome é validado
           
        }

        // Método para tratar a alteração da aba do TabControl
        private void OnAbaTabAlterada(object sender, EventArgs e)
        {
         
        }
    }
}
