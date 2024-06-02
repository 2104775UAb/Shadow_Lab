namespace UABNotas
{
    public interface INota
    {
        decimal CalcularNota();
    }


    // Para caculo das médias adiciona a nota e verifica se >=9.5 e soma a quantidade de items para dar a média certa
    public interface ICalculadoraNota
    {
        void AdicionarNota(decimal nota);
        decimal CalcularMedia();
        decimal GetSomatorio();
        int GetQuantidade();
    }

    public class NotaCalculada : ICalculadoraNota
    {
        private decimal somatorio;
        private int quantidade;

        public NotaCalculada()
        {
            somatorio = 0;
            quantidade = 0;
        }

        public void AdicionarNota(decimal nota)
        {
            //if (nota >= 9.5m)
            if (nota > 0)
            {
                somatorio += nota;
                quantidade++;
            }
        }

        public decimal CalcularMedia()
        {
            if (quantidade == 0)
            {
                return 0;
            }
            return somatorio / quantidade;
        }

        public decimal GetSomatorio()
        {
            return somatorio;
        }

        public int GetQuantidade()
        {
            return quantidade;
        }
    }
}
