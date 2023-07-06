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
    public partial class frmP8 : Form
    {
        public frmP8()
        {
            InitializeComponent();
        }

        private void btnProx_Click_1(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta!", "Quiz");
                frmP9 p9 = new frmP9();
                VariaveisGlobais.Acertos += 1;
                p9.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Respota Incorreta", "!!!");
                frmP9 p9 = new frmP9();
                VariaveisGlobais.Erros += 1;
                p9.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa", "ERRO");
            }
        }
    }
}
