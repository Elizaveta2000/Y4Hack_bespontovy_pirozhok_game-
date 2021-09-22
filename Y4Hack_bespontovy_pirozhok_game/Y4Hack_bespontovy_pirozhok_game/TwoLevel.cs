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

        private void exit_Click(object sender, EventArgs e)
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

        private void clickyes_Click(object sender, EventArgs e)
        {
            string num = "3";
            if (score_carrot.Text == num)
            {
                clickyes.BackColor = Color.FromArgb(0, 225, 0);
                fail.Visible = false;

            }
            else
            {
                score_carrot.Text = "0";
                label4.Visible = true;
                carrot1.Visible = true;
                carrot2.Visible = true;
                carrot3.Visible = true;
                carrot4.Visible = true;
                carrot5.Visible = true;
                carrot6.Visible = true;
                fail.Visible = true;
            }
            /*string four = "3";
            if (score_carrot.Text == four)
            {
                forward.Visible = true;

                clickyes.BackColor = Color.FromArgb(0, 0, 0, 0);

            }
            else
            {
                clickyes.BackColor = Color.FromArgb(225, 0, 0);
                label4.Visible = true;

            }*/
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
