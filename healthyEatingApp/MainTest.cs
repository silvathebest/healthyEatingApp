using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthyEatingApp
{
    public partial class MainTest : Form
    {
        string[] questions = new string[]{ "Как часто вы завтракаете?",
                                                "Сколько овощей и фруктов у вас в рационе?",
                                                "Чем вы запиваете еду?",
                                                "Как много хлебобулочных изделий вы едите?",
                                                "Как часто вы ходите в фастфуд?",
                                                "Сколько приемов пищи у вас в день (включая перекусы)?",
                                                "Чем вы утоляете жажду?",
                                                "Для вас еда это в первую очередь?",
                                                "Как часто вы едите полуфабрикаты?",
                                                "Вы едите перед сном?",
                                                "Как часто вы едите продукты, содержащие большое количество сахара?"};

        string[] answers = new string[] {  "каждый день","иногда","не люблю завтракать",
                                                "ем их реже чем раз в день","достаточно много, каждый день","ем реже чем раз в 3 дня",
                                                "Газировкой, лимонадом или чем по крепче","Ничем","Водой или чаем",
                                                "почти не ем или не ем совсем","хлебобулочные изделия входят почти в каждый прием пищи","иногда ем хлеб",
                                                "никогда не посещаю фастфуды","каждый день хожу в фастфуды и чувствую себя прекрасно","могу сходить раз в неделю",
                                                "ем менее 3х раз в день","ем 3-4 раза в день","ем 5-8 раз в день",
                                                "лимонадом, газировкой","Водой","чаем или соком",
                                                "Моя потребность. Организму нужна энергия чтобы функционировать","Удовольствие. Мне нравится есть, потому что вкусная еда делает меня счастливее","привычка, от которой я не могу отказаться",
                                                "мой рацион состоит в основном из полуфабрикатов","Не ем совсем. Не люблю не натуральную еду","Иногда ем, потому что нет времени готовить",
                                                "Да, не могу уснуть пока не поем","Нет, не ем, не могу уснуть если поем перед сном","Иногда, когда не ел весь день",
                                                "Один раз в неделю или реже","Раз в 3-4 дня","Каждый день"};
        int[] pointsAnswers = new int[] {2,1,0,
                                            1,2,0,
                                            0,2,1,
                                            2,0,1,
                                            2,0,1,
                                            0,1,2,
                                            0,2,1,
                                            2,1,0,
                                            0,2,1,
                                            2,0,1,
                                            2,1,0};
        private int currentQuestion = 0;
        private int points = 0;
        private int index = 0;
        private string resultat = "";
        public MainTest()
        {
            InitializeComponent();
        }
        public void update_Click(object sender, EventArgs e)
        {
            labelQuestionCount.Text = currentQuestion + 1 + " из 11";
            for (int i = 0; i < answers.Length; i++)
            {
                if (sender.ToString().Substring(35) == answers[i])
                    points += pointsAnswers[i];
            }
            if (currentQuestion < questions.Length)
            {
                richTextBoxQuestion.Text = questions[currentQuestion];
                currentQuestion++;
                buttonFirstAnswer.Text = answers[index];
                index++;
                buttonSecondAnswer.Text = answers[index];
                index++;
                buttonThirdAnswer.Text = answers[index];
                index++;
            }
            else
            {
                if (points >= 19)
                    resultat = "Вы молодец! Вы питаетесь правильно и следите за своим организмом и здоровьем. Вы долго и здорово проживете эту жизнь.";
                if (points >= 15 && points < 19)
                    resultat = "Вы пытаетесь питаться правильно и все - таки не убиваете свой организм \"той отравой\", что продают нам в магазинах маркетологи. Скорее всего вы мало болеете и неплохо себя чувствуете";
                if (points >= 11 && points < 15)
                    resultat = "Вы вряд ли что-то слышали о правильном питании, но вы едите так как чувствует ваш организм";
                if (points < 11)
                    resultat = "Вам стоит пересмотреть свои привычки и рацион питания, у вас могут быть проблемы со здоровьем или они только начинают появляться. Обратитесь к диетологу или просто начните следите за тем, что вы едите."
                            + "Старайтесь есть больше овощей, исключить из рациона сладкое, мучное и газировку, кушать не менее 3 - х раз в день и тогда вы почувствуете, как ваш организм говорит вам спасибо";
                result();
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxQuestion.TabStop = false;
            buttonFirstAnswer.FlatStyle = FlatStyle.Flat;
            buttonSecondAnswer.FlatStyle = FlatStyle.Flat;
            buttonThirdAnswer.FlatStyle = FlatStyle.Flat;
            buttonInReturnMenu.FlatStyle = FlatStyle.Flat;
            update_Click(sender, e);
        }
        public void result()
        {
            labelQuestionCount.Dispose();
            buttonFirstAnswer.Dispose();
            buttonSecondAnswer.Dispose();
            buttonThirdAnswer.Dispose();
            buttonInReturnMenu.Enabled = true;
            buttonInReturnMenu.Visible = true;
            richTextBoxQuestion.Text = resultat;
        }

        private void buttonInReturnMenu_Click(object sender, EventArgs e)
        {
            Form f = new FormMenu();
            f.Visible = true;
            this.Close();
        }
    }
}
