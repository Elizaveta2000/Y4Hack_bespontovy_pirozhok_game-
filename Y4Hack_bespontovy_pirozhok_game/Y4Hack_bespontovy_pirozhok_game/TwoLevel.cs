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

        private void TwoLevel_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e) // выход в меню
        {
            bool create = false;

            foreach (Form form in Application.OpenForms) // переход на 3 уровень
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

        private void clickyes_Click(object sender, EventArgs e) // обработка кнопки "готово"
        {
            string num = "3";
            if (score_carrot.Text == num) // верный ответ
            {
                start.Visible = false;
                fail.Visible = false;
                yes.Visible = true;
                example1.Visible = false;
                example2.Visible = true;
                score_carrot.Text = "0";
                carrot1.Visible = true;
                carrot2.Visible = true;
                carrot3.Visible = true;
                carrot4.Visible = true;
                carrot5.Visible = true;
                carrot6.Visible = true;
                string num2 = "5";

                if (score_carrot.Text == num2) // верный ответ
                {
                    start.Visible = false;
                    fail.Visible = false;
                    yes.Visible = true;
                    example2.Visible = false;
                    score_carrot.Text = "0";
                    carrot1.Visible = true;
                    carrot2.Visible = true;
                    carrot3.Visible = true;
                    carrot4.Visible = true;
                    carrot5.Visible = true;
                    carrot6.Visible = true;
                }
                else // не верный ответ
                {
                    score_carrot.Text = "0"; // обнулим морковь
                    fail.Visible = true; // покажем коммент с проигрышем
                    yes.Visible = false; // уберем коммент с выигрышем
                    start.Visible = false; // уберем коммент привет
                    carrot1.Visible = true; // вернем морковь
                    carrot2.Visible = true; // вернем морковь
                    carrot3.Visible = true; // вернем морковь
                    carrot4.Visible = true; // вернем морковь
                    carrot5.Visible = true; // вернем морковь
                    carrot6.Visible = true; // вернем морковь
                }
            }
            else // не верный ответ
            {
                score_carrot.Text = "0"; // обнулим морковь
                fail.Visible = true; // покажем коммент с проигрышем
                yes.Visible = false; // уберем коммент с выигрышем
                start.Visible = false; // уберем коммент привет
                carrot1.Visible = true; // вернем морковь
                carrot2.Visible = true; // вернем морковь
                carrot3.Visible = true; // вернем морковь
                carrot4.Visible = true; // вернем морковь
                carrot5.Visible = true; // вернем морковь
                carrot6.Visible = true; // вернем морковь
            }

        }

        private void carrot1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot1.Visible = carrot1.Text != "";
        }

        private void carrot2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot2.Visible = carrot2.Text != "";
        }

        private void carrot3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot3.Visible = carrot3.Text != "";
        }

        private void carrot5_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot5.Visible = carrot5.Text != "";
        }

        private void carrot4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot4.Visible = carrot4.Text != "";
        }

        private void carrot6_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot6.Visible = carrot6.Text != "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
