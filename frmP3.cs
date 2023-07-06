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
    public partial class frmP3 : Form
    {
        public frmP3()
        {
            InitializeComponent();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta!", "Quiz");
                frmP4 p4 = new frmP4();
                VariaveisGlobais.Acertos += 1;
                p4.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Respota Incorreta", "!!!");
                frmP4 p4 = new frmP4();
                VariaveisGlobais.Erros += 1;
                p4.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa", "ERRO");
            }
        }
    }
}
