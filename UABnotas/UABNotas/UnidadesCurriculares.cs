using System.Collections.Generic;
using System.Numerics;

namespace UABNotas
{

    // Classe está relactionado com componente Model
    public class UnidadesCurriculares 
    {
        string nome; // Adicionado para armazenar o nome da unidade curricular
        int id; // Adicionado para armazenar o ID da unidade curricular

        // Adicionado para manipular o nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Adicionado para manipular o ID
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        // Método para retornar dados de nome e id como uma lista de strings
        public List<string> ObterDados()
        {
            return new List<string> { $"Nome: {nome}", $"ID: {id}" };
        }

        public UnidadesCurriculares Clone()
        {
            UnidadesCurriculares clone = new UnidadesCurriculares();
            clone.nome = this.nome;
            clone.id = this.id;
            return clone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, ID: {ID}";
        }

        // Método para retornar uma lista de dados de exemplo
        public static List<string> ObterDadosExemplo()
        {
            return new List<string>
            {
                "Nome: Matemática, ID: 101",
                "Nome: História, ID: 102",
                "Nome: Biologia, ID: 103",
                "Nome: Química, ID: 104"
            };
        }

    }


    public class ListagemSemestreAno
    {
        string nome; // Adicionado para armazenar o nome da unidade curricular
        int id; // Adicionado para armazenar o ID da unidade curricular

        // Adicionado para manipular o nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Adicionado para manipular o ID
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Método para retornar dados de nome e id como uma lista de strings
        public List<string> ObterDados()
        {
            return new List<string> { $"Nome: {nome}", $"ID: {id}" };
        }

        public ListagemSemestreAno Clone()
        {
            ListagemSemestreAno clone = new ListagemSemestreAno();
            clone.nome = this.nome;
            clone.id = this.id;
            return clone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, ID: {ID}";
        }


    }


}