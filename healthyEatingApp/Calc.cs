using System;
using System.Windows.Forms;

namespace healthyEatingApp
{
    public partial class Calc : Form
    {
        private readonly double[] cofActivity = new double[] { 1.2, 1.375, 1.55, 1.725, 1.9 };
        private readonly string text = "Минимальный уровень активности - отсутствие физической нагрузки или небольшая легкая нагрузка \n" +
                            "Слабый уровень активности - выполнение легких упражнений не менее 20 минут от 3 до 5 раз в неделю \n" +
                            "Средний уровень активности - Интенсивные упражнения от 30 до 60 минут от 3 до 5 раз в неделю \n" +
                            "Высокий уровень активности - Выполнение интенсивных упражнений не менее 60 минут от 5 до 7 дней в неделю или занятия 2 раза в день \n" +
                            "Максимальынй Уровень активности - 7 или более часов в неделю очень интенсивных упражнени, интенсивные занятия 2 раза в день";
        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            comboBoxSex.Items.Add("Мужской");
            comboBoxSex.Items.Add("Женский");

            comboBoxActivity.Items.Add("Минимальный");
            comboBoxActivity.Items.Add("Слабый");
            comboBoxActivity.Items.Add("Средний");
            comboBoxActivity.Items.Add("Высокий");
            comboBoxActivity.Items.Add("Максимальный");

            toolTipActivity.SetToolTip(comboBoxActivity, text);
            toolTipActivity.SetToolTip(buttonInfo, text);
            buttonCalc.FlatStyle = FlatStyle.Flat;
            buttonReturnInMenu.FlatStyle = FlatStyle.Flat;
            buttonInfo.FlatStyle = FlatStyle.Flat;

            comboBoxSex.SelectedIndex = 0;
            comboBoxActivity.SelectedIndex = 0;
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double normalWeight = 0.0;
            double loseWeight = 0.0;
            double upWeight = 0.0;
            double bmr = 0.0;
            double activity = cofActivity[comboBoxActivity.SelectedIndex];
            int weight;
            int age;
            int height;
            try
            {
                weight = Int32.Parse(textBoxWeight.Text.Trim());
                height = Int32.Parse(textBoxSizeY.Text.Trim());
                age = Int32.Parse(textBoxAge.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Введен неверный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxSex.Text == "Мужской")
            {
                normalWeight = (10 * weight + 6.25 * height - 5 * age + 5) * activity;
                bmr = 88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age);
            }
            else if (comboBoxSex.Text == "Женский")
            {
                normalWeight = (10 * weight + 6.25 * height - 5 * age - 161) * activity;
                bmr = 447.6 + (9.2 * weight) + (3.1 * height) - (4.3 * age);
            }

            loseWeight = normalWeight * 0.8;
            upWeight = normalWeight * 1.2;

            // if (loseWeight < bmr) loseWeight = bmr;

            labelLoseWeight.Text = Convert.ToInt32(loseWeight).ToString();
            labelNormalWeight.Text = Convert.ToInt32(normalWeight).ToString();
            labelUpWeight.Text = Convert.ToInt32(upWeight).ToString();
            labelBmr.Text = Convert.ToInt32(bmr).ToString();
        }

        private void buttonReturnInMenu_Click(object sender, EventArgs e)
        {
            Form f = new FormMenu();
            f.Visible = true;
            this.Dispose();
        }

        private void Calc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
