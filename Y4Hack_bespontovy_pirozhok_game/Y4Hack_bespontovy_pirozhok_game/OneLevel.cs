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

    private void label1_Click(object sender, EventArgs e)
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

        private void carrot4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(score_carrot.Text);
            i++;
            score_carrot.Text = i.ToString();
            carrot4.Visible = carrot4.Text != "";

        }


        private void OneLevel_Load(object sender, EventArgs e)
        {
            

        }

        private void forward_Click(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void clickyes_Click(object sender, EventArgs e)
        {
            string four = "4";
            if (score_carrot.Text == four)
            {
                forward.Visible = true;
                label1.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                clickyes.BackColor = Color.FromArgb(0, 0,0, 0);

            }
            else
            {
                clickyes.BackColor = Color.FromArgb(225, 0, 0);
                label4.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
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
