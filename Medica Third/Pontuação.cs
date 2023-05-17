using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Medica_Third
{
    public partial class Pontuação : Form
    {
        int score;
        int totalQuestions;
        string r1, r2, r3, r4, r5, r6, r7, r8;

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
        public Pontuação()
        {
            InitializeComponent();
        }

        public Pontuação(int score, int totalQuestions, string r1, string r2, string r3, string r4, string r5, string r6, string r7, string r8) : this()
        {
            this.score = score;
            this.totalQuestions = totalQuestions;
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.r4 = r4;
            this.r5 = r5;
            this.r6 = r6;
            this.r7 = r7;
            this.r8 = r8;
        }

        private void Pontuação_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel2.Width, panel2.Height, 20, 20));

            label1.Text = $"Você acertou {score} das {totalQuestions} questões!";
            
            label2.MaximumSize = new Size(750, 0);
            label2.AutoSize = true;

            label3.MaximumSize = new Size(750, 0);
            label3.AutoSize = true;

            label4.MaximumSize = new Size(750, 0);
            label4.AutoSize = true;

            label5.MaximumSize = new Size(750, 0);
            label5.AutoSize = true;

            label6.MaximumSize = new Size(750, 0);
            label6.AutoSize = true;

            label7.MaximumSize = new Size(750, 0);
            label7.AutoSize = true;

            label8.MaximumSize = new Size(750, 0);
            label8.AutoSize = true;

            label9.MaximumSize = new Size(750, 0);
            label9.AutoSize = true;

            label2.Text = $"1) {r1}";
            label3.Text = $"2) {r2}";
            label4.Text = $"3) {r3}";
            label5.Text = $"4) {r4}";
            label6.Text = $"5) {r5}";
            label7.Text = $"6) {r6}";
            label8.Text = $"7) {r7}";
            label9.Text = $"8) {r8}";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
