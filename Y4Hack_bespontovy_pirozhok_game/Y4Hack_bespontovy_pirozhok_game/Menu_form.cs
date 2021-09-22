using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Y4Hack_bespontovy_pirozhok_game
{
    public partial class Menu_form : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Menu_form()
        {
            InitializeComponent();
        }

        /* private void playSimpleSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Liza\source\repos\Y4Hack\music\untro_menu.wav");
            player.Play();
        } */

        private void button1_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if(form.Name.ToString() == "Game_form")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                GameMenu_form gameC = new GameMenu_form();
                this.Hide();
                gameC.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                Exit gameE = new Exit();
                this.Hide();
        gameE.Show();

            }
}

        private void Menu_form_Load(object sender, EventArgs e)
        {
            SoundPlayer sndPlayer = new SoundPlayer(@"C:\Users\Liza\source\repos\Y4Hack\music\intro_menu.wav");
            sndPlayer.Play();

        }
    }
}
