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
    public partial class Tabela : Form
    {
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
        public Tabela()
        {
            InitializeComponent();
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            TabelaMedicação.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, TabelaMedicação.Width, TabelaMedicação.Height, 20, 20));

            this.TabelaMedicação.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;

            TabelaMedicação.ReadOnly = true;
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Ácido etacrínico",
                    "Apresenta potencial para hipertensão."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Cimetidina",
                    "Efeito adversos no Sistema Nervoso Central, incluindo confusão."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Clonidina",
                    "Apresenta potencial para hipotensão ortostática e efeitos adversos no Sistema Nervoso Central."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Digoxina",
                    "No idoso com clearance renal diminuído pode aumentar o risco de efeitos tóxicos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Dipiramidol",
                    "Pode causar hipotensão ortostática."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Estrógenos de uso oral",
                    "Potencial carcinogênico (câncer de mama e endométrio). Sem efeito cardioprotetor em idosas."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Propoxifeno",
                    "Oferece poucas vantagens analgésifcas em relação aos outros opióides."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Reserpina\nDose maior que 0,25mg",
                    "Pode induzir a depressão, impotência sexual, sedação e hipotensão ortostática."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Sulfato ferroso\nDose maior que 325 mg/d",
                    "Não aumenta a quantidade absorvida, mas eleva significativamente a uncidência de constipação."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Amiodarona",
                    "Associado com o prolongamento do intervalo QT e riscos cardíacos graves para o idoso."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Anfetaminas e anorexígenos",
                    "Potencial para causar dependência, hipertensão, angina e infarto do miocárdio."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Anti-histamínicos (clorfeniramina, difenidramina, hidroxizina, prometazina, dexclorfeniramina",
                    "Podem ter potentes propriedades anticolinérgias. Para tratar reações alérgicas em idosos, os anti-histamínicos não-anticolinérgicos são preferidos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Barbitúricos",
                    "Causam dependência e mais efeitos adversos que a maioria dos sedativos e hipnóticos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "BZD de curta ação em doses maiores de:\n3 mg de lorazepam\n60 mg de oxazepam\n2 mg de alprozolam\n15 mg de temazepan\n0,25 mg de triazolam",
                    "Os idosos são mais sensíveis aos BZD, portanto doses menores podem ser efetivas e seguras. A dose diária total deve raramente exceder o máximo permitido."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "BZD de longa ação: clordiazepóxido, diazepam, halazepam e clorazepato",
                    "Em idosos, essas drogas apresentam meia-vida maior, produzindo sedação prolongada e aumentando o risco de quedas e fraturas."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Clorpropamida",
                    "Tem meia-vida aumentada em idosos e pode causar hipoglicemia prolongada. O único hipoglicemiante oral que causa SIADH."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Difenidramina",
                    "Pode causar confusão e sedação."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Disopiramida",
                    "Efeito inotrópico negativo acentuado e pode causar falência cardíaca em idosos. Anticolinérgico potente."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Flurazepam",
                    "Possui meia-vida longo em idosos, produzindo sedação prolongada e aumentando a incidência de quedas e fraturas."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Quanetidina",
                    "Pode causar hipotensão ortostática."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Indometacina",
                    "Entre o AINES é o que produz os efeitos adversos mais significativos no Sistema Nervoso Central."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Meperidina",
                    "Não é um analgésico oral efetivo nas doses usadas comumente. Pode causar confusão."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Meprobamato",
                    "Muito sedativo e capz de causar dependências."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Metildopa",
                    "Pode causar bradicardia e exacerbar depressão."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Metiltestosterona",
                    "Risco potencial para hipertrofia prostática e problemas cardíacos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Nifedipina de curta ação",
                    "Potencial para hipotensão e constipação."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Nitrofurantoína",
                    "Por causa das propriedades anticolinérgicas acentuadas e sedativas é raramente o antidepressivo de escolha em idosos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Óleo mineral",
                    "Potencial para a aspiração e efeitos adversos."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Pentazocina",
                    "Entre os opióides é o que causa confusão e alucionações."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Relaxantes musculares e drogas antiespasmódicas",
                    "Causam efeitos anticolinérgicos, sedação e fraqueza. Em idosos, a eficácia nas doses toleradas é questionada."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Ticlopidina",
                    "O efeito antiplaquetário não é superior ao ASS. Pode ser considerada mais tóxica."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Uso contínuo de laxativos (bisacodil e cáscara sagrada)",
                    "Pode exacerbar disfunção intestinal."
                }
                );
            TabelaMedicação.Rows.Add(
                new object[]
                {
                    "Uso prolongado de AINE mais seletivo para CDX-2 (naproxeno e piroxicam)",
                    "Potencial de produzir sangramento GI, falência renal e cardíaca, aumento da pressão sanguínea."
                }
                );
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
