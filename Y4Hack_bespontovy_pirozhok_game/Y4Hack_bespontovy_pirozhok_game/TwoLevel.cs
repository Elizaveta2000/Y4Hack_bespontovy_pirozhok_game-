using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y4Hack_bespontovy_pirozhok_game
{
    public partial class TwoLevel : Form
    {
        public TwoLevel()
        {
            InitializeComponent();
        }

        private void TwoLevel_Load(object sender, EventArgs e) { }

        private void exit_Click(object sender, EventArgs e) // выход в меню
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Game_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                GameMenu_form gameG = new GameMenu_form();
                this.Hide();
                gameG.Show();

            }
        }

        private void carrot1_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 1 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot1.Visible = carrot1.Text != "";
        }
        private void carrot2_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 2 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot2.Visible = carrot2.Text != "";
        }
        private void carrot3_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 3 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot3.Visible = carrot3.Text != "";
        }
        private void carrot5_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 5 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot5.Visible = carrot5.Text != "";
        }
        private void carrot4_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 4 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot4.Visible = carrot4.Text != "";
        }
        private void carrot6_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 6 морковки 
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot6.Visible = carrot6.Text != "";
        }

        private void clickyes1_Click(object sender, EventArgs e) // обработка кнопки "готово 1 пример"
        {
            string num1 = "3";
             //string num2 = "5";
          //  string num3 = "1";
           // string num4 = "7";
          //  string num5 = "4";

            if (score_carrot.Text == num1) // верный ответ
            {
                start.Visible = false; // убираем задание
                fail.Visible = false; // закрыть комент с проигрышем, если такой был
                example1.Visible = false; // закрыть 1 пример
                clickyes1.Visible = false; // убираем кнопка для 1-го примера
                yes.Visible = true; // показываем коммент выигрыша
                score_carrot.Text = "0"; // обнулить морковь на солнце
                carrot1.Visible = true; // вернуть 1 морковь на поле
                carrot2.Visible = true; // вернуть 2 морковь на поле
                carrot3.Visible = true; // вернуть 3 морковь на поле
                carrot4.Visible = true; // вернуть 4 морковь на поле
                carrot5.Visible = true; // вернуть 5 морковь на поле
                carrot6.Visible = true; // вернуть 6 морковь на поле                               
                example2.Visible = true; // открыть 2 пример
                clickyes2.Visible = true; // появляем кнопка для 2-го примера

            }
            else // не верный ответ
            {
                score_carrot.Text = "0"; // обнулим морковь
                start.Visible = false; // уберем коммент привет
                carrot1.Visible = true; // вернем морковь
                carrot2.Visible = true; // вернем морковь
                carrot3.Visible = true; // вернем морковь
                carrot4.Visible = true; // вернем морковь
                carrot5.Visible = true; // вернем морковь
                carrot6.Visible = true; // вернем морковь
                fail.Visible = true; // покажем коммент с проигрышем
            }
        }
    }
}
