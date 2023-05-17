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
    public partial class Medicação : Form
    {
        private Form formAtivo; 
        public Medicação()
        {
            InitializeComponent();
        }

        private void FormShow(Form form)
        {
            ActiveFormClose();
            formAtivo = form;
            form.TopLevel = false;
            Painel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void ActiveFormClose()
        {
            if(formAtivo != null)
            {
                formAtivo.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            FormShow(new Tabela());
        }

        private void btnMedicações_Click(object sender, EventArgs e)
        {
            FormShow(new Medicamentos());
        }

        private void Medicação_Load(object sender, EventArgs e)
        {
        }
    }
}
