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
    public partial class OneLevel : Form
    {
        public OneLevel()
        {
            InitializeComponent();
    }

        private void OneLevel_Load(object sender, EventArgs e) { }
   
        private void label1_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 1 морковки 
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
        private void carrot4_Click(object sender, EventArgs e) // вывод числа морковок на солнце для 4 морковки
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot4.Visible = carrot4.Text != "";

        }
      
        private void forward_Click(object sender, EventArgs e) // переход на 2 уровень
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "twoLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                TwoLevel gameT = new TwoLevel();
                this.Hide();
                gameT.Show();

            }
        }  
       
        private void clickyes_Click(object sender, EventArgs e) // обработка клика на "готово"
        {
            string num = "4"; // число морковок на поле
            if (score_carrot.Text == num) // все ли морковки собраны?
            {
                forward.Visible = true; // показываем кнопку далее
                start.Visible = false; // убираем задание
                yes.Visible = true; // показываем коммент выигрыша
                attention.Visible = false; // убираем коммент если ранее не все морковки были собраны
            }
            else
            {
                attention.Visible = true; // говорим смотреть внимательнее
            }
        }

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
    }

}
