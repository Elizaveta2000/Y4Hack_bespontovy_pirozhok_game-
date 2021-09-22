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
    public partial class GameMenu_form : Form
    {
        public GameMenu_form()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
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
                OneLevel gameOneLevel = new OneLevel();
                this.Hide();
                gameOneLevel.Show();

            }
        }

        private void label9_Click(object sender, EventArgs e)
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
                Menu_form gameM = new Menu_form();
                this.Hide();
                gameM.Show();

            }
        }

        private void label2_Click(object sender, EventArgs e)
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
                TwoLevel gameTwoLevel = new TwoLevel();
                this.Hide();
                gameTwoLevel.Show();

            }
        }
    }
    }

