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
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta!", "Quiz");
                frmP2 p2 = new frmP2();
                VariaveisGlobais.Acertos+=1;
                p2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Respota Incorreta", "!!!");
                frmP2 p2 = new frmP2();
                VariaveisGlobais.Erros += 1;
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa", "ERRO");
            }
        }
    }
}
