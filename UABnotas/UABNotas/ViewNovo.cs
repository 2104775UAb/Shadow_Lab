using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UABNotas
{
   

    public class ViewNovo
    {
        frmNovo formNovo;
        Form pai;
        Model model;
        private int guardaAno;
        private int guardaSemestre;

        public event EventHandler CliqueSalvar;
        private List<UCInfo> listaUCs;

        public ViewNovo(Form origem)
        {
            pai = origem;
        }
        internal void AtivarViewNovo(int ano, int semestre,Model m)
        {
            //if (formNovo == null) formNovo = new frmNovo();
            formNovo = new frmNovo();
            guardaAno = ano;
            guardaSemestre = semestre;
            model = m;
            listaUCs = new List<UCInfo>(); // Inicializar a lista
            model.ObterUCCombox(ano, semestre, ref listaUCs);
            formNovo.btnSalvar.Click += OnCliqueSalvar;
            formNovo.ConstruirListaCombobox(listaUCs);
            MostraFrmNovo();
        }

        protected virtual void OnCliqueSalvar(object sender, EventArgs e)
        {

            /*foreach (var valores in listaValores)
{
    Console.WriteLine($"CodigoUC: {valores.CodigoUC}, NotaEfolioA: {valores.NotaEfolioA}");
}*/
            
            System.Windows.Forms.Button btnSalvar = sender as System.Windows.Forms.Button;
            if (btnSalvar != null)
            {
                btnSalvar.Enabled = false;
            }


            List<FormAdicionaUCValores> listaValores = new List<FormAdicionaUCValores>();
            formNovo.RetornaValoresForm(ref listaValores);
            var valores = listaValores[0];

            
            if (model.InserirUCSemestre(guardaSemestre, guardaAno, valores.CodigoUC, valores.NotaEfolioA, valores.NotaEfolioB, valores.NotaEfolioC, valores.NotaGlobal, valores.TipoAvaliacao))
            {
                if (btnSalvar != null)
                {
                    btnSalvar.Enabled = true;
                }
                formNovo.FechaNovoForm();
            }
            else 
            {
                Console.WriteLine("Erro  a gravar");
            }




        }


        internal void MostraFrmNovo()
        {
            if (formNovo == null)
                return;

            formNovo.StartPosition = FormStartPosition.Manual;

            // Posição do rato no x,y
            Point mousePosition = Cursor.Position;

            // Mostra o novo form na posição do rato
            formNovo.Location = mousePosition;

            // Ajustar quando sai fora do ecran
            Screen screen = Screen.FromPoint(mousePosition);
            Rectangle workingArea = screen.WorkingArea;
            if (mousePosition.X + formNovo.Width > workingArea.Right)
            {
                formNovo.Left = workingArea.Right - formNovo.Width;
            }
            if (mousePosition.Y + formNovo.Height > workingArea.Bottom)
            {
                formNovo.Top = workingArea.Bottom - formNovo.Height;
            }

            formNovo.ShowDialog(pai);
        }
    }
}
