using System;
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
            NomeUC = txtNomeUC.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmNovo_Load(object sender, EventArgs e)
        {

        }
    }
}
