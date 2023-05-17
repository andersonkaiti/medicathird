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
    public partial class Créditos : Form
    {
        private Form formAtivo;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nRight,
                int nBotton,
                int nTop,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public Créditos()
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
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
        }

        private void Créditos_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel2.Width, panel2.Height, 75, 75));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReferências_Click(object sender, EventArgs e)
        {
            FormShow(new Referências());
        }
    }
}
