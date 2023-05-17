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
    public partial class Antipsicótico : Form
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
        public Antipsicótico()
        {
            InitializeComponent();
        }

        private void Antipsicótico_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel2.Width, panel2.Height, 30, 30));
        }
    }
}
