using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Medica_Third
{
    public partial class Medicamentos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nRight,
                int nLeft,
                int nTop,
                int nBotton,
                int nWidthEllipse,
                int nHeightEllipse
            );
        private Form formAtivo;
        public Medicamentos()
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAntipsicótico_Click(object sender, EventArgs e)
        {
            FormShow(new Antipsicótico());
        }

        private void btnAntidepressivo_Click(object sender, EventArgs e)
        {
            FormShow(new Antidepressivo());
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel2.Width, panel2.Height, 30, 30));
        }

        private void btnMaisInformações_Click(object sender, EventArgs e)
        {
            FormShow(new MaisInformações());
        }
    }
}
