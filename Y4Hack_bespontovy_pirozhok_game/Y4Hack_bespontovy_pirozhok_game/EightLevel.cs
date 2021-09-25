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
    public partial class EightLevel : Form
    {
        public EightLevel()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            {

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
            }
        }

        

        private void carrot1_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot1.Visible = carrot1.Text != "";
            }
        }

        private void carrot2_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot2.Visible = carrot2.Text != "";
            }
        }

        private void carrot3_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot3.Visible = carrot3.Text != "";
            }
        }

        private void carrot8_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot8.Visible = carrot8.Text != "";
            }
        }

        private void carrot5_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot5.Visible = carrot5.Text != "";
            }
        }

        private void carrot7_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot7.Visible = carrot7.Text != "";
            }
        }

        private void carrot6_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot6.Visible = carrot6.Text != "";
            }
        }

        private void carrot4_Click(object sender, EventArgs e)
        {

            {
                int i = Convert.ToInt32(score_carrot.Text);
                i++;
                score_carrot.Text = i.ToString();
                carrot4.Visible = carrot4.Text != "";
            }
        }
        
        private void clickyes1_Click(object sender, EventArgs e)
        {

            {

                {
                    string num1 = "7";
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
                        carrot7.Visible = true; // вернуть 7 морковь на поле                               
                        carrot8.Visible = true; // вернуть 8 морковь на поле                               
                        example2.Visible = true; // открыть 2 пример
                        clickyes2.Visible = true; // появляем кнопка для 2-го примера

                    }
                    else // не верный ответ
                    {
                        score_carrot.Text = "0"; // обнулим морковь
                        start.Visible = false; // уберем коммент привет
                        yes.Visible = false; // уберем коммент выигрыша
                        carrot1.Visible = true; // вернем морковь
                        carrot2.Visible = true; // вернем морковь
                        carrot3.Visible = true; // вернем морковь
                        carrot4.Visible = true; // вернем морковь
                        carrot5.Visible = true; // вернем морковь
                        carrot6.Visible = true; // вернем морковь
                        carrot7.Visible = true; // вернуть 7 морковь на поле                               
                        carrot8.Visible = true; // вернуть 8 морковь на поле

                        fail.Visible = true; // покажем коммент с проигрышем
                    }
                }
            }
        }

        private void clickyes2_Click(object sender, EventArgs e)
        {

            {

                {
                    string num2 = "0";

                    if (score_carrot.Text == num2) // верный ответ
                    {
                        start.Visible = false; // убираем задание
                        fail.Visible = false; // закрыть комент с проигрышем, если такой был
                        example2.Visible = false; // закрыть 2 пример
                        clickyes2.Visible = false; // убираем кнопка для 2-го примера
                        yes.Visible = true; // показываем коммент выигрыша
                        score_carrot.Text = "0"; // обнулить морковь на солнце
                        carrot1.Visible = true; // вернуть 1 морковь на поле
                        carrot2.Visible = true; // вернуть 2 морковь на поле
                        carrot3.Visible = true; // вернуть 3 морковь на поле
                        carrot4.Visible = true; // вернуть 4 морковь на поле
                        carrot5.Visible = true; // вернуть 5 морковь на поле
                        carrot6.Visible = true; // вернуть 6 морковь на поле                               
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле

                        example3.Visible = true; // открыть 3 пример
                        clickyes3.Visible = true; // появляем кнопка для 3-го примера

                    }
                    else // не верный ответ
                    {
                        score_carrot.Text = "0"; // обнулим морковь
                        start.Visible = false; // уберем коммент привет
                        yes.Visible = false; // уберем коммент выигрыша
                        carrot1.Visible = true; // вернем морковь
                        carrot2.Visible = true; // вернем морковь
                        carrot3.Visible = true; // вернем морковь
                        carrot4.Visible = true; // вернем морковь
                        carrot5.Visible = true; // вернем морковь
                        carrot6.Visible = true; // вернем морковь
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле

                        fail.Visible = true; // покажем коммент с проигрышем
                    }
                }
            }
        }

        private void clickyes3_Click(object sender, EventArgs e)
        {

            {

                {
                    string num3 = "2";

                    if (score_carrot.Text == num3) // верный ответ
                    {
                        start.Visible = false; // убираем задание
                        fail.Visible = false; // закрыть комент с проигрышем, если такой был
                        example3.Visible = false; // закрыть 3 пример
                        clickyes3.Visible = false; // убираем кнопка для 3-го примера
                        yes.Visible = true; // показываем коммент выигрыша
                        score_carrot.Text = "0"; // обнулить морковь на солнце
                        carrot1.Visible = true; // вернуть 1 морковь на поле
                        carrot2.Visible = true; // вернуть 2 морковь на поле
                        carrot3.Visible = true; // вернуть 3 морковь на поле
                        carrot4.Visible = true; // вернуть 4 морковь на поле
                        carrot5.Visible = true; // вернуть 5 морковь на поле
                        carrot6.Visible = true; // вернуть 6 морковь на поле
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле   
                        example4.Visible = true; // открыть 4 пример
                        clickyes4.Visible = true; // появляем кнопка для 4-го примера

                    }
                    else // не верный ответ
                    {
                        score_carrot.Text = "0"; // обнулим морковь
                        start.Visible = false; // уберем коммент привет
                        yes.Visible = false; // уберем коммент выигрыша
                        carrot1.Visible = true; // вернем морковь
                        carrot2.Visible = true; // вернем морковь
                        carrot3.Visible = true; // вернем морковь
                        carrot4.Visible = true; // вернем морковь
                        carrot5.Visible = true; // вернем морковь
                        carrot6.Visible = true; // вернем морковь
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле   
                        fail.Visible = true; // покажем коммент с проигрышем
                    }
                }
            }
        }

        private void clickyes4_Click(object sender, EventArgs e)
        {

            {

                {
                    string num4 = "2";

                    if (score_carrot.Text == num4) // верный ответ
                    {
                        start.Visible = false; // убираем задание
                        fail.Visible = false; // закрыть комент с проигрышем, если такой был
                        example4.Visible = false; // закрыть 4 пример
                        clickyes4.Visible = false; // убираем кнопка для 4-го примера
                        yes.Visible = true; // показываем коммент выигрыша
                        score_carrot.Text = "0"; // обнулить морковь на солнце
                        carrot1.Visible = true; // вернуть 1 морковь на поле
                        carrot2.Visible = true; // вернуть 2 морковь на поле
                        carrot3.Visible = true; // вернуть 3 морковь на поле
                        carrot4.Visible = true; // вернуть 4 морковь на поле
                        carrot5.Visible = true; // вернуть 5 морковь на поле
                        carrot6.Visible = true; // вернуть 6 морковь на поле
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле   
                        example5.Visible = true; // открыть 5 пример
                        clickyes5.Visible = true; // появляем кнопка для 5-го примера

                    }
                    else // не верный ответ
                    {
                        score_carrot.Text = "0"; // обнулим морковь
                        start.Visible = false; // уберем коммент привет
                        yes.Visible = false; // уберем коммент выигрыша
                        carrot1.Visible = true; // вернем морковь
                        carrot2.Visible = true; // вернем морковь
                        carrot3.Visible = true; // вернем морковь
                        carrot4.Visible = true; // вернем морковь
                        carrot5.Visible = true; // вернем морковь
                        carrot6.Visible = true; // вернем морковь
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле   
                        fail.Visible = true; // покажем коммент с проигрышем
                    }
                }
            }
        }

        private void clickyes5_Click(object sender, EventArgs e)
        {

            {

                {
                    string num5 = "2";

                    if (score_carrot.Text == num5) // верный ответ
                    {
                        start.Visible = false; // убираем задание
                        fail.Visible = false; // закрыть комент с проигрышем, если такой был

                        yes.Visible = true; // показываем коммент выигрыша

                        forward.Visible = true; // появляем кнопка для перехода на новый уровень

                    }
                    else // не верный ответ
                    {
                        score_carrot.Text = "0"; // обнулим морковь
                        start.Visible = false; // уберем коммент привет
                        yes.Visible = false; // уберем коммент выигрыша
                        carrot1.Visible = true; // вернем морковь
                        carrot2.Visible = true; // вернем морковь
                        carrot3.Visible = true; // вернем морковь
                        carrot4.Visible = true; // вернем морковь
                        carrot5.Visible = true; // вернем морковь
                        carrot6.Visible = true; // вернем морковь
                        carrot7.Visible = true; // вернуть 7 морковь на поле 
                        carrot8.Visible = true; // вернуть 8 морковь на поле   
                        fail.Visible = true; // покажем коммент с проигрышем
                    }
                }
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {

            {

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
            }
        }
    }
}
