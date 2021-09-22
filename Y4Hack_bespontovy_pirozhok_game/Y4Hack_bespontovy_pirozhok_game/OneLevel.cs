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
            /* string four = "4";

              if (score_carrot.Text == four)
              {
                  forward.Visible = true;
              } */
         
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

            
        }
    }
}
