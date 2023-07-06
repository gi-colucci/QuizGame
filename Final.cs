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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
