using System;
using System.Drawing;
using System.Windows.Forms;

namespace healthyEatingApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonBeginTest_Click(object sender, EventArgs e)
        {
            Form f = new MainTest();
            f.Show();
            this.Visible = false;
        }
        private void buttonBeginCalc_Click(object sender, EventArgs e)
        {
            Form f = new Calc();
            f.Show();
            this.Visible = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            buttonBeginTest.FlatStyle = FlatStyle.Flat;
            buttonBeginCalc.FlatStyle = FlatStyle.Flat;
            richTextBoxStart.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxStart.Text = "Правильное питание предполагает, что в организм регулярно, в необходимом количестве и оптимальных соотношениях должны поступать многие питательные вещества — белки, углеводы, жиры, вода, минеральные вещества и витамины. Недостаток или избыток некоторых питательных элементов становятся причинами сначала временных неудобств, а затем и риска развития различных заболеваний.Здоровое питание даeт возможность стабилизировать вес без насильственных ограничений, помогает избавиться от заболеваний и предотвратить их развитие, содействует восстановлению интеллектуальной и физической энергии.Здоровое питание — важная составляющая здорового образа жизни.Чтобы правильно питаться, нужно не только желание, но и знания.";
            FormMenu_SizeChanged(sender, e);
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_SizeChanged(object sender, EventArgs e)
        {
            richTextBoxStart.Width = this.Width - 20;
            richTextBoxStart.Height = this.Height / 2 + this.Height / 8;
            buttonBeginCalc.Left = (this.Width / 2) - (buttonBeginCalc.Width / 2);
            buttonBeginTest.Left = (this.Width / 2) - (buttonBeginCalc.Width / 2);
            buttonBeginCalc.Top = this.Height - buttonBeginCalc.Height * 2;
            buttonBeginTest.Top = this.Height - (int)(buttonBeginCalc.Height * 3.3);
            int fontSize = this.Width / 50;
            richTextBoxStart.Font = new Font(richTextBoxStart.Font.FontFamily, (float)fontSize);
        }
    }
}
