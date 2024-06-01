using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UABNotas
{
    public class ViewNovo
    {
        frmNovo formNovo;
        Form pai;
        int ano;

        public ViewNovo(Form origem)
        {
            pai = origem;
        }

        internal void AtivarViewLog(int ano)
        {
            this.ano = ano;
            if (formNovo == null) formNovo = new frmNovo();
        }
        internal void AlterarLog(string log)
        {
            if (formNovo == null)
                return;
            // formLog.EscreverLog(log);
            formNovo.ShowDialog(pai);
        }
    }
}
