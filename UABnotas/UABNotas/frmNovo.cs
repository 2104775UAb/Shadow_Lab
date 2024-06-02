using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UABNotas
{



    public partial class frmNovo : Form
    {
        public string NomeUC { get; private set; }

        public frmNovo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
          //  this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void frmNovo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        internal void ConstruirListaCombobox(List<UCInfo> listaUCs)
        {
            Dictionary<string, string> itensComId = new Dictionary<string, string>();
            foreach (var item in listaUCs)
            {
//                Console.WriteLine($"Id: {item.CodigoUC}, Ano: {item.Descricao} ");
                itensComId.Add(item.CodigoUC.ToString(), item.Descricao.ToString());
            }
            cmbUC.DataSource = new BindingSource(itensComId, null);
            cmbUC.DisplayMember = "Value"; // Exibe o texto associado ao valor
            cmbUC.ValueMember = "Key"; // Define o valor associado ao ID, que ficará oculto*/
        }


        internal void RetornaValoresForm(ref List<FormAdicionaUCValores> listaValores)
        {
            char tipoAvaliacao = 'c';

            if (selExame.Checked)
                tipoAvaliacao = 'e';

            FormAdicionaUCValores valores = new FormAdicionaUCValores
            {
                CodigoUC = int.Parse(cmbUC.SelectedValue.ToString()),
                NotaEfolioA = (float)notaEfolioA.Value,
                NotaEfolioB = (float)notaEfolioB.Value,
                NotaEfolioC = (float)notaEfolioC.Value,
                NotaGlobal = (float)notaGlobal.Value,
                TipoAvaliacao = tipoAvaliacao
            };

            listaValores.Add(valores);

        }


        internal void FechaNovoForm()
        {
            this.Close();
        }


    }
}
