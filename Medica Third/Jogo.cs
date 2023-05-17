using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medica_Third
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirJogo_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
        }
    }
}
