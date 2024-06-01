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

    public class LinhaUC
    {
        public int Id { get; set; }
        public byte Ano { get; set; }
        public string Obs { get; set; }
        public byte Semestre { get; set; }
        public string Descricao { get; set; }
        public decimal EfolioA { get; set; }
        public decimal EfolioB { get; set; }
        public decimal EfolioC { get; set; }
        public decimal PFolio { get; set; }
        public int CodigoUC { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Ano: {Ano}, Obs: {Obs}, Semestre: {Semestre}, Descricao: {Descricao}, EfolioA: {EfolioA}, EfolioB: {EfolioB}, EfolioC: {EfolioC}, PFolio: {PFolio}, CodigoUC: {CodigoUC}";
        }


        public LinhaUC Clone()
        {
            LinhaUC clone = new LinhaUC();
            clone.Id = this.Id;
            clone.Ano = this.Ano;
            clone.CodigoUC = this.CodigoUC;
            return clone;
        }

    }

    public interface IUCInfo
    {
        int CodigoUC { get; set; }
        string Descricao { get; set; }
    }
    public class UCInfo : IUCInfo
    {
        public int CodigoUC { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"CodigoUC: {CodigoUC}, Descricao: {Descricao}";
        }

        public UCInfo Clone()
        {
            return new UCInfo { CodigoUC = this.CodigoUC, Descricao = this.Descricao };
        }
    }


    public class FormAdicionaUCValores
    {
        public int CodigoUC { get; set; }
        public float NotaEfolioA { get; set; }
        public float NotaEfolioB { get; set; }
        public float NotaEfolioC { get; set; }
        public float NotaGlobal { get; set; }
        public float NotaExame { get; set; }
        public char tipoAvaliacao { get; set; }


    }



}