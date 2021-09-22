
namespace Y4Hack_bespontovy_pirozhok_game
{
    partial class OneLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneLevel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carrot1 = new System.Windows.Forms.Label();
            this.score_carrot = new System.Windows.Forms.Label();
            this.carrot2 = new System.Windows.Forms.Label();
            this.carrot3 = new System.Windows.Forms.Label();
            this.carrot4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.forward = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clickyes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carrot1
            // 
            this.carrot1.BackColor = System.Drawing.Color.Transparent;
            this.carrot1.Image = ((System.Drawing.Image)(resources.GetObject("carrot1.Image")));
            this.carrot1.Location = new System.Drawing.Point(176, 382);
            this.carrot1.Name = "carrot1";
            this.carrot1.Size = new System.Drawing.Size(80, 121);
            this.carrot1.TabIndex = 13;
            this.carrot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carrot1.Click += new System.EventHandler(this.label1_Click);
            // 
            // score_carrot
            // 
            this.score_carrot.BackColor = System.Drawing.Color.Transparent;
            this.score_carrot.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_carrot.ForeColor = System.Drawing.Color.LimeGreen;
            this.score_carrot.Image = ((System.Drawing.Image)(resources.GetObject("score_carrot.Image")));
            this.score_carrot.Location = new System.Drawing.Point(518, 9);
            this.score_carrot.Name = "score_carrot";
            this.score_carrot.Size = new System.Drawing.Size(165, 134);
            this.score_carrot.TabIndex = 14;
            this.score_carrot.Text = "0";
            this.score_carrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrot2
            // 
            this.carrot2.BackColor = System.Drawing.Color.Transparent;
            this.carrot2.Image = ((System.Drawing.Image)(resources.GetObject("carrot2.Image")));
            this.carrot2.Location = new System.Drawing.Point(271, 270);
            this.carrot2.Name = "carrot2";
            this.carrot2.Size = new System.Drawing.Size(79, 112);
            this.carrot2.TabIndex = 15;
            this.carrot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carrot2.Click += new System.EventHandler(this.carrot2_Click);
            // 
            // carrot3
            // 
            this.carrot3.BackColor = System.Drawing.Color.Transparent;
            this.carrot3.Image = ((System.Drawing.Image)(resources.GetObject("carrot3.Image")));
            this.carrot3.Location = new System.Drawing.Point(425, 382);
            this.carrot3.Name = "carrot3";
            this.carrot3.Size = new System.Drawing.Size(80, 121);
            this.carrot3.TabIndex = 16;
            this.carrot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carrot3.Click += new System.EventHandler(this.carrot3_Click);
            // 
            // carrot4
            // 
            this.carrot4.BackColor = System.Drawing.Color.Transparent;
            this.carrot4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.carrot4.Image = ((System.Drawing.Image)(resources.GetObject("carrot4.Image")));
            this.carrot4.Location = new System.Drawing.Point(537, 261);
            this.carrot4.Name = "carrot4";
            this.carrot4.Size = new System.Drawing.Size(80, 121);
            this.carrot4.TabIndex = 17;
            this.carrot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carrot4.Click += new System.EventHandler(this.carrot4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 118);
            this.label1.TabIndex = 18;
            this.label1.Text = "Собери\r\nвсе морковки \r\nна лугу \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.Transparent;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.Location = new System.Drawing.Point(537, 536);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(119, 100);
            this.forward.TabIndex = 20;
            this.forward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forward.Visible = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 116);
            this.label2.TabIndex = 21;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(281, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 118);
            this.label3.TabIndex = 22;
            this.label3.Text = "Молодчина!\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clickyes
            // 
            this.clickyes.BackColor = System.Drawing.Color.Transparent;
            this.clickyes.Image = ((System.Drawing.Image)(resources.GetObject("clickyes.Image")));
            this.clickyes.Location = new System.Drawing.Point(12, 531);
            this.clickyes.Name = "clickyes";
            this.clickyes.Size = new System.Drawing.Size(128, 121);
            this.clickyes.TabIndex = 23;
            this.clickyes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickyes.Click += new System.EventHandler(this.clickyes_Click);
            // 
            // OneLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.clickyes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carrot4);
            this.Controls.Add(this.carrot3);
            this.Controls.Add(this.carrot2);
            this.Controls.Add(this.score_carrot);
            this.Controls.Add(this.carrot1);
            this.Name = "OneLevel";
            this.Text = "OneLevel";
            this.Load += new System.EventHandler(this.OneLevel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label carrot1;
        private System.Windows.Forms.Label score_carrot;
        private System.Windows.Forms.Label carrot2;
        private System.Windows.Forms.Label carrot3;
        private System.Windows.Forms.Label carrot4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clickyes;
    }
}