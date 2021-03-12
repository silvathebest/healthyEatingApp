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
    public partial class Calc : Form
    {
        private double[] cofActivity = new double[] { 1.2, 1.375, 1.55, 1.725, 1.9 };
        private string text = "Минимальный уровень активности - отсутствие физической нагрузки или небольшая легкая нагрузка \n" +
                                            "Слабый уровень активности - выполнение легких упражнений не менее 20 минут от 3 до 5 раз в неделю \n" +
                                            "Средний уровень активности - Интенсивные упражнения от 30 до 60 минут от 3 до 5 раз в неделю \n" +
                                            "Высокий уровень активности - Выполнение интенсивных упражнений не менее 60 минут от 5 до 7 дней в неделю или занятия 2 раза в день \n" +
                                            "Максимальынй Уровень активности - 7 или более часов в неделю очень интенсивных упражнени, интенсивные занятия 2 раза в день";
        public Calc()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double normalWeight = 0.0;
            double loseWeight = 0.0;
            double upWeight = 0.0;
            double bmr = 0.0;
            if (comboBoxSex.Text == "Мужской")
            {
                normalWeight = (10 * Convert.ToInt32(textBoxWeight.Text) + 6.25 * Convert.ToInt32(textBoxSizeY.Text) - 5 * Convert.ToInt32(textBoxAge.Text) + 5) * cofActivity[comboBox1.SelectedIndex];
                bmr = 88.36 + (13.4 * Convert.ToInt32(textBoxWeight.Text)) + (4.8 * Convert.ToInt32(textBoxSizeY.Text)) - (5.7 * Convert.ToInt32(textBoxAge.Text));
            }
            else if (comboBoxSex.Text == "Женский")
            {
                normalWeight = (10 * Convert.ToInt32(textBoxWeight.Text) + 6.25 * Convert.ToInt32(textBoxSizeY.Text) - 5 * Convert.ToInt32(textBoxAge.Text) - 161) * cofActivity[comboBox1.SelectedIndex];
                bmr = 447.6 + (9.2 * Convert.ToInt32(textBoxWeight.Text)) + (3.1 * Convert.ToInt32(textBoxSizeY.Text)) - (4.3 * Convert.ToInt32(textBoxAge.Text));
            }
            loseWeight = normalWeight * 0.8;
            upWeight = normalWeight * 1.2;
            if (loseWeight < bmr)
            {
                loseWeight = bmr;
            }
            labelLoseWeight.Text = Convert.ToInt32(loseWeight).ToString();
            labelNormalWeight.Text = Convert.ToInt32(normalWeight).ToString();
            labelUpWeight.Text = Convert.ToInt32(upWeight).ToString();
            labelBmr.Text = Convert.ToInt32(bmr).ToString();

        }

        private void buttonReturnInMenu_Click(object sender, EventArgs e)
        {
            Form f = new FormMenu();
            f.Visible = true;
            this.Close();
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            comboBoxSex.Items.Add("Мужской");
            comboBoxSex.Items.Add("Женский");
            comboBox1.Items.Add("Минимальный");
            comboBox1.Items.Add("Слабый");
            comboBox1.Items.Add("Средний");
            comboBox1.Items.Add("Высокий");
            comboBox1.Items.Add("Максимальный");
            toolTip1.SetToolTip(comboBox1, text);
            toolTip1.SetToolTip(buttonInfo, text);
            buttonCalc.FlatStyle = FlatStyle.Flat;
            buttonReturnInMenu.FlatStyle = FlatStyle.Flat;
            buttonInfo.FlatStyle = FlatStyle.Flat;
        }
    }
}
