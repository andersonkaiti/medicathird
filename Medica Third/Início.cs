using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Medica_Third
{
    public partial class Início : KryptonForm
    {
        private Form formAtivo;
        public Início()
        {
            InitializeComponent();
        }

        private void FormShow(Form form)
        {
            ActiveFormClose();
            formAtivo = form;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ActiveFormClose()
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
        }

        private void btnMedicação_Click(object sender, EventArgs e)
        {
            FormShow(new Medicação());
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            FormShow(new Jogo());
        }

        private void btnCréditos_Click(object sender, EventArgs e)
        {
            FormShow(new Créditos());
        }
    }
}
