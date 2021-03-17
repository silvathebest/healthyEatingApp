﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthyEatingApp
{
    public partial class MainTest : Form
    {
        string[] questions = new string[]{      "Как часто вы завтракаете?",
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

        string[] answers = new string[] {       "Каждый день","Иногда","Не люблю завтракать",
                                                "Ем их реже чем раз в день","Достаточно много, Каждый день","Ем реже чем раз в 3 дня",
                                                "Газировкой, лимонадом или чем по крепче","Ничем","Водой или чаем",
                                                "Почти не ем или не ем совсем","Хлебобулочные изделия входят почти в каждый прием пищи","Иногда ем хлеб",
                                                "Никогда не посещаю фастфуды","Каждый день хожу в фастфуды и чувствую себя прекрасно","Могу сходить раз в неделю",
                                                "Ем менее 3х раз в день","Ем 3-4 раза в день","Ем 5-8 раз в день",
                                                "Лимонадом, газировкой","Водой","Чаем или соком",
                                                "Моя потребность. Организму нужна энергия чтобы функционировать","Удовольствие. Мне нравится есть, потому что вкусная еда делает меня счастливее","привычка, от которой я не могу отказаться",
                                                "Мой рацион состоит в основном из полуфабрикатов","Не ем совсем. Не люблю не натуральную еду","Иногда ем, потому что нет времени готовить",
                                                "Да, не могу уснуть пока не поем","Нет, не ем","Иногда, когда не ел весь день",
                                                "Один раз в неделю или реже","Раз в 3-4 дня","Каждый день"};
        int[] pointsAnswers = new int[]{2,1,0,
                                        1,2,0,
                                        0,2,1,
                                        2,0,1,
                                        2,0,1,
                                        0,1,2,
                                        0,2,1,
                                        2,1,0,
                                        0,2,1,
                                        0,2,1,
                                        2,1,0};

        string[] advices = new string[]{"Министерство здравоохранения РФ сообщает, что правильный завтрак это всегда порция цельнозерновой каши (гречка, овес, рис) и источник белка (яичница, творог или мясо) или яичный омлет с овощами, бутерброд из цельнозернового хлеба с кусочком мяса, как вариант.",
                                        "Овощи и фрукты — основа здорового питания, важный источник витаминов и минералов. Кроме того, в овощах и фруктах много полезной клетчатки. Клетчатка улучшает пищеварение и в целом хорошо влияет на организм. Исследования показывают, что люди, которые едят много свежих овощей и фруктов, меньше рискуют столкнуться с сердечно-сосудистыми заболеваниями, повышенным давлением, диабетом второго типа, с ухудшением зрения, с трудностями пищеварения, а также снижен риск возникновения некоторых видов рака.",
                                        "В разных источниках советуется по разному, где-то советуют запивать еду, где-то наоборот говорят, что это вредно, к единому мнению ученые не пришли. Так что запивать еду или нет вы должны на свое усмотрение, кто-то не может есть без запивания, а кому-то без разницы.",
                                        "Диетологи утверждают, что взрослый человек должен ежедневно употреблять 250–300 г хлеба. Для обычного, здорового человека, ведущего активный образ жизни, ежедневная норма употребления этого продукта составляет 300–350 г. Для людей умственного, интеллектуального труда достаточно съедать около 150 г в день. Тем, кто занят тяжёлым физическим трудом дневную порцию хлеба стоит увеличить до 500 г в день.",
                                        "Употребляя фастфуд, человек наносит огромный вред сердечнососудистой системе. В первое время это никак не отражается на здоровье. Исключением может стать быстрая утомляемость и головокружение. Но если фастфудом питаться очень часто – это прямая угроза атеросклероза или закупорки сосудов. \nИсследовательская группа ученых из Бостонского детского госпиталя во главе с доктором Давидом Людвигом пришла к выводу, что легкоусвояемые углеводы (которые содержатся в фастфуде) опаснее жира. Пища, которая содержит такие углеводы, способствует выработке инсулина, который «заставляет» организм запасать жир. ",
                                        "Мы считаем, что режим питания придуманный в СССР для детских садов - является самым сбалансированным режимом питания. \nВ него входят: завтрак, полдник, обед, ужин, второй ужин.",
                                        "Тело человека состоит из воды примерно на 70%. Нам постоянно необходимо пить, чтобы хорошо себя чувствовать и поддерживать жизненные процессы в норме. Учёные и врачи советуют потреблять в среднем по два литра воды в день.\nХорошо утоляют жажду вода, соки, морсы и нектары, если они натуральные(желательно свежевыжатые), с небольшим содержанием сахара, а лучше всего - наполовину разбавленные с водой. Сладкими напитками и газировками не рекомендуется утолять жажду, потому что они не только не утоляют жажду, а наоборот - усиливают ее.",
                                        "Однажды ученые првоели эксперимент. В две разные комнаты поместили две разные группы людей, у этих людей была возможность брать еду в любое время и без ограничений. Первой группе давали невкусную(безвкусную?) еду, в которой содержались все необходимые вещества для организма, а второй давали различную жирную, вкусную еду. В результате первая группа поддерживала здоровый для организма вес и не испытывала проблем со здоровьем, а вторая группа людей активно набирала вес, так как они употребляли пищу в большем количестве, чем необходимо организму. Еда - в первую очередь потребность организма, а не просто ваше желание покушать \"чего-нибудь вкусного\". Не следует лишний раз перекусывать, если вы не голодны, а потому что просто хочется \"вкусного\".",
                                        "Большая часть полуфабрикатов богата на жиры, соль, сахар и калории, поэтому употреблять их стоит в небольших количествах и нерегулярно. Еще один существенный недостаток — обилие искусственных пищевых добавок — это и консерванты, и красители, и усилители вкуса.",
                                        "Вовсе не обязательно ложиться спать на голодный желудок. Перед сном вы можете съесть небольшую порцию каши или несколько фруктов. Из напитков подойдут травяные чаи или нежирное молоко. Такой лёгкий ужин улучшает качество вашего сна без риска поправиться.",
                                        "У Человека нет необходимости в сахаре в чистом виде, так как его достаточное количество в других продуктах нашего питания. \nНапример: фрукты, каши(любые сложные углеводы)."};
        string location = Environment.CurrentDirectory;
        private int currentQuestion = 0;
        private int currentPicture = 1;
        private int currentAdvice = 0;
        private int points = 0;
        private int index = 0;
        private string resultat = "";
        public MainTest()
        {
            InitializeComponent();
        }

        public void result()
        {
            labelQuestionCount.Dispose();
            buttonFirstAnswer.Dispose();
            buttonSecondAnswer.Dispose();
            buttonThirdAnswer.Dispose();
            btnChanger(buttonInReturnMenu, true);
            richTextBoxAdvice.Visible = true;
            richTextBoxAdvice.Enabled = true;
            richTextBoxAdvice.Text = resultat;
        }
        private void btnChanger(Button btn, bool bo)
        {
            btn.Enabled = bo;
            btn.Visible = bo;
        }
        private void questionsUpdater(Object sender)
        {
           /* labelQuestionCount.Text = $"Вопрос {currentQuestion + 1} из 11";*/
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
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxAdvice.SelectionAlignment = HorizontalAlignment.Center;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBoxQuestion.TabStop = false;
            buttonFirstAnswer.FlatStyle = FlatStyle.Flat;
            buttonSecondAnswer.FlatStyle = FlatStyle.Flat;
            buttonThirdAnswer.FlatStyle = FlatStyle.Flat;
            buttonInReturnMenu.FlatStyle = FlatStyle.Flat;
            btnChanger(buttonNextQuestion, false);
            richTextBoxAdvice.Visible = false;
            questionsUpdater(sender);
        }
        public void update_Click(object sender, EventArgs e)
        {
            richTextBoxAdvice.Enabled = true;
            richTextBoxAdvice.Visible = true;
            richTextBoxAdvice.Text = advices[currentAdvice++];
            btnChanger(buttonFirstAnswer, false);
            btnChanger(buttonSecondAnswer, false);
            btnChanger(buttonThirdAnswer, false);
            btnChanger(buttonNextQuestion, true);
            questionsUpdater(sender);
        }
        private void buttonInReturnMenu_Click(object sender, EventArgs e)
        {
            Form f = new FormMenu();
            f.Visible = true;
            this.Dispose();
        }
        private void MainTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            btnChanger(buttonFirstAnswer, true);
            btnChanger(buttonSecondAnswer, true);
            btnChanger(buttonThirdAnswer, true);
            btnChanger(buttonNextQuestion, false);
            richTextBoxAdvice.Visible = false;
            pictureBox.Image = Image.FromFile(location + "/Resources/bgImages/" + currentPicture + ".jpg");
            currentPicture++;
        }
    }
}
