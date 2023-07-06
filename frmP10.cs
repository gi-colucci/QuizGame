using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class frmP10 : Form
    {
        public frmP10()
        {
            InitializeComponent();
        }

        private void btnProx_Click_1(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta!", "Quiz");
                Final Final = new Final();
                VariaveisGlobais.Acertos += 1;
                Final.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Respota Incorreta", "!!!");
                Final Final = new Final();
                VariaveisGlobais.Erros += 1;
                Final.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa", "ERRO");
            }
        }
    }
}
