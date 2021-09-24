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

        private void label3_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "threeLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                ThreeLevel gameTh = new ThreeLevel();
                this.Hide();
                gameTh.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "fourLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                FourLevel gameF = new FourLevel();
                this.Hide();
                gameF.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "fiveLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                FiveLevel gameF = new FiveLevel();
                this.Hide();
                gameF.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "SixLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                SixLevel gameSx = new SixLevel();
                this.Hide();
                gameSx.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "threeLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                SevenLevel gameS = new SevenLevel();
                this.Hide();
                gameS.Show();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "threeLevel_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                EightLevel gameE = new EightLevel();
                this.Hide();
                gameE.Show();
            }
        }
    }
    }

