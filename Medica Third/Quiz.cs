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
    public partial class Quiz : KryptonForm
    {
        private Form formAtivo;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        string r1, r2, r3, r4, r5, r6, r7, r8;

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

        public Quiz()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (KryptonButton)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == 1)
            {
                if(buttonTag == correctAnswer)
                    r1 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r1 = "ERROU";
            }
            if (questionNumber == 2)
            {
                if (buttonTag == correctAnswer)
                    r2 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r2 = "ERROU";
            }
            if (questionNumber == 3)
            {
                if (buttonTag == correctAnswer)
                    r3 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r3 = "ERROU";
            }
            if (questionNumber == 4)
            {
                if (buttonTag == correctAnswer)
                    r4 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r4 = "ERROU";
            }
            if (questionNumber == 5)
            {
                if (buttonTag == correctAnswer)
                    r5 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r5 = "ERROU";
            }
            if (questionNumber == 6)
            {
                if (buttonTag == correctAnswer)
                    r6 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r6 = "ERROU";
            }
            if (questionNumber == 7)
            {
                if (buttonTag == correctAnswer)
                    r7 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r7 = "ERROU";
            }
            if (questionNumber == 8)
            {
                if (buttonTag == correctAnswer)
                    r8 = "ACERTOU";
                if (buttonTag != correctAnswer)
                    r8 = "ERROU";
            }

            if (questionNumber == totalQuestions)
            {
                FormShow(new Pontuação(score, totalQuestions, r1, r2, r3, r4, r5, r6, r7, r8));
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    label1.Text = "1) Por que o analgésico não é indicado para idosos com problemas renais?";
                    label2.Text = "a) reduz a função renal e aumenta o risco de sangramentos.";
                    label3.Text = "b) reduz a função renal e a concentração de proteínas.";
                    label4.Text = "c) aumenta o risco de infarto.";
                    label5.Text = "d) aumenta o risco de sangramento.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 2;

                    break;
                case 2:
                    label1.Text = "2) Quais os cuidados ao receitar antidepressivos aos idosos?";
                    label2.Text = "a) os idosos têm um risco maior de ter parada cardíaca por conta do aumento da pressão arterial.";
                    label3.Text = "b) os idosos correm o risco porque o antidepressivo pode aumentar a libido deles.";
                    label4.Text = "c) os idosos têm mais chances se não tiverem o tratamento com remédio.";
                    label5.Text = "d) todas as alternativas.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 1;

                    break;
                case 3:
                    label1.Text = "3) Quais os riscos dos anticoagulantes nos idosos?";
                    label2.Text = "a) os anticoagulantes causam sangramentos que podem se tornar hemorragias graves nos idosos.";
                    label3.Text = "b) os anticoagulantes podem levar os idosos a ter uma parada cardíaca por conta do aumento da pressão.";
                    label4.Text = "c) os anticoagulantes afetam diretamente o sistema nervoso central dos idosos.";
                    label5.Text = "d) todas as alternativas estão erradas.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 1;

                    break;
                case 4:
                    label1.Text = "4) Os anticoagulantes servem para:";
                    label2.Text = "a) fazem com que o coração fique mais resistente.";
                    label3.Text = "b) deixam o sangue mais fino, impedindo que ele obstrua as veias.";
                    label4.Text = "c) o idoso fica com o coração mais acelerado, bombeando mais sangue.";
                    label5.Text = "d) aumenta a quantidade de hemoglobinas no sangue, facilitando, assim, a passagem entre as artérias.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 2;

                    break;
                case 5:
                    label1.Text = "5) O que o antidepressivo pode causar no idoso?";
                    label2.Text = "a) perda de cabelo.";
                    label3.Text = "b) falicita o ganho corporal ou acelera o metabolismo.";
                    label4.Text = "c) causa de taquicardia.";
                    label5.Text = "d) deixa o paciente desconexo.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 2;

                    break;
                case 6:
                    label1.Text = "6) Qual a função dos antipsicóticos?";
                    label2.Text = "a) causa alucionações que acalmam o paciente.";
                    label3.Text = "b) fazem com que o paciente tenha sono e durma.";
                    label4.Text = "c) afeta a região de sentimento e raciocínio do cérebro, cortando, assim, alucionações que o paciente possa ter.";
                    label5.Text = "d) corta qualquer tipo de sentimento do paciente";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 3;

                    break;
                case 7:
                    label1.Text = "7) Quais as melhores formas de lembrar de tomar os medicamentos?";
                    label2.Text = "a) auxiliares de memórias; recipientes para medicamentos; aplicativos de smartphone.";
                    label3.Text = "b) auxiliares de memória; anotar em alguma folha; tomar quando sentir que precisa.";
                    label4.Text = "c) tomar quando sentir que precisa; recipientes para medicamentos; anotar na geladeira.";
                    label5.Text = "d) aplicativos de celulares; automedicação; sempre que sentir necessidade.";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 1;

                    break;
                case 8:
                    label1.Text = "8) Os medicamentos para controlar a hipertensão arterial (anti-hipertensivos) ajudam a prevenir o quê?";
                    label2.Text = "a) acidente vascular cerebral e ataques cardíacos.";
                    label3.Text = "b) Insonia e ataques cardíacos.";
                    label4.Text = "c) dores no abdômen";
                    label5.Text = "d) náuseas e febre";

                    button1.Text = "a)";
                    button2.Text = "b)";
                    button3.Text = "c)";
                    button4.Text = "d)";

                    correctAnswer = 1;

                    break;
            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            label1.MaximumSize = new Size(750, 0);
            label1.AutoSize = true;

            label2.MaximumSize = new Size(750, 0);
            label2.AutoSize = true;

            label3.MaximumSize = new Size(750, 0);
            label3.AutoSize = true;

            label4.MaximumSize = new Size(750, 0);
            label4.AutoSize = true;

            label5.MaximumSize = new Size(750, 0);
            label5.AutoSize = true;
        }
    }
}
