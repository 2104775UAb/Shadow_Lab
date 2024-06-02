using System.Collections.Generic;
using System.Numerics;

namespace UABNotas
{
    public class LinhaUC
    {
        public int Id { get; set; }
        public byte Ano { get; set; }
        public string Obs { get; set; }
        public int Semestre { get; set; }
        public string Descricao { get; set; }
        public int CodigoUC { get; set; }
        public string TipoAvalicao { get; set; }

        public FormAdicionaUCValores UCValores { get; set; }

        public LinhaUC()
        {
            UCValores = new FormAdicionaUCValores();
        }

        public decimal CalcularNota()
        {
            return UCValores.CalcularNota();
        }

        public LinhaUC Clone()
        {
            LinhaUC clone = new LinhaUC();
            clone.Id = this.Id;
            clone.Ano = this.Ano;
            clone.CodigoUC = this.CodigoUC;
            return clone;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Ano: {Ano}, Obs: {Obs}, Semestre: {Semestre}, Descricao: {Descricao}, " +
                   $"CodigoUC: {CodigoUC}, TipoAvalicao: {TipoAvalicao}, " +
                   $"NotaEfolioA: {UCValores.NotaEfolioA}, NotaEfolioB: {UCValores.NotaEfolioB}, NotaEfolioC: {UCValores.NotaEfolioC}, " +
                   $"NotaGlobal: {UCValores.NotaGlobal}, NotaExame: {UCValores.NotaExame}, " +
                   $"Nota Calculada: {CalcularNota()}";
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


    public class FormAdicionaUCValores : INota
    {
        public int CodigoUC { get; set; }
        public float NotaEfolioA { get; set; }
        public float NotaEfolioB { get; set; }
        public float NotaEfolioC { get; set; }
        public float NotaGlobal { get; set; }
        public float NotaExame { get; set; }
        public char TipoAvaliacao { get; set; }

        public decimal CalcularNota()
        {
            if (TipoAvaliacao == 'c')
            {
                if ((NotaEfolioA > 0 && NotaEfolioB > 0) || NotaEfolioC > 0)
                {
                    if (NotaGlobal==0)
                        return 0; 
                    else
                        return (decimal)(NotaEfolioA + NotaEfolioB + NotaEfolioC + NotaGlobal);
                }
                else
                {
                    return (decimal)NotaGlobal;
                }
            }
            else
            {
                return (decimal)NotaExame;
            }
        }
    }






    public class Aluno
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }



}