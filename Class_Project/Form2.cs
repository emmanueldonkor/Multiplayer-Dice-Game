using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Project
{
    public partial class Form2 : Form
    {
        public static string pl1name;
        public static string pl2name;
        public static string pl3name;
        public static string pl4name;

        public PictureBox[] pl1AvailableIcons = new PictureBox[5];
        public PictureBox[] pl2AvailableIcons = new PictureBox[5];
        public PictureBox[] pl3AvailableIcons = new PictureBox[5];
        public PictureBox[] pl4AvailableIcons = new PictureBox[5];
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowGameStarter_Click(object sender, EventArgs e)
        {

            pl1name = txtPlname1.Text;
            pl2name = txtPlname2.Text;
            pl3name = txtPlname3.Text;
            pl4name = txtPlname4.Text;
            MessageBox.Show("Lets Start the game!!!");
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void btnExitForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBox1_pl1_Click(object sender, EventArgs e)
        {
            Common.ImgPath = picBoxShow_Selected_pl1.ImageLocation;
            PictureBox picBox = new PictureBox();
            picBox.Show();

        }

       public  void btnGame_In_Settings_Click(object sender, EventArgs e)
        {
            // Check the possibles errors if the number of rounds and number of players are inserted wrongly
            Common.getNumberofPlayers = int.Parse(txtNumber_Of_Players.Text);
            Common.getRounds = int.Parse(txtRound.Text);
            if (Common.getNumberofPlayers < 2 )
            {
                MessageBox.Show("The minimun number of players is 2 ", "Error");
                groupMain.Enabled = false;
            }
            else if( Common.getRounds < 5)
            {
                MessageBox.Show("The minimum number of rounds is 5");
                groupMain.Enabled = false;
            }
            else if( Common.getRounds > 30)
            {
                MessageBox.Show("The number of rounds cannot be greater than 30");
                groupMain.Enabled = false;
            }
           
            else if(Common.getNumberofPlayers > 4)
            {
                MessageBox.Show("The number of players cannot exceed four");
                groupMain.Enabled = false;
            }
            else if (Common.getNumberofPlayers == 0 && Common.getRounds == 0)
            {
                MessageBox.Show("Number of players and rounds  cannot be zero");
                groupMain.Enabled = false;
            }
            else
            {
                groupMain.Enabled = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Disable the the main group box when the form2 is loading
            // Player 1
            picBox1_pl1.Load("Avatars\\Icon1.png");
            picBox2_pl1.Load("Avatars\\Icon2.png");
            picBox3_pl1.Load("Avatars\\Icon3.png");
            picBox4_pl1.Load("Avatars\\Icon4.png");
            picBox5_pl1.Load("Avatars\\Icon5.png");

            pl1AvailableIcons[0] = picBox1_pl1;
            pl1AvailableIcons[1] = picBox2_pl1;
            pl1AvailableIcons[2] = picBox3_pl1;
            pl1AvailableIcons[3] = picBox4_pl1;
            pl1AvailableIcons[4] = picBox5_pl1;

            // Player 2
            picBox1_pl2.Load("Avatars\\Icon1.png");
            picBox2_pl2.Load("Avatars\\Icon2.png");
            picBox3_pl2.Load("Avatars\\Icon3.png");
            picBox4_pl2.Load("Avatars\\Icon4.png");
            picBox5_pl2.Load("Avatars\\Icon5.png");
            pl2AvailableIcons[0] = picBox1_pl2;
            pl2AvailableIcons[1] = picBox2_pl2;
            pl2AvailableIcons[2] = picBox3_pl2;
            pl2AvailableIcons[3] = picBox4_pl2;
            pl2AvailableIcons[4] = picBox5_pl2;

            // Player 3
            picBox1_pl3.Load("Avatars\\Icon1.png");
            picBox2_pl3.Load("Avatars\\Icon2.png");
            picBox3_pl3.Load("Avatars\\Icon3.png");
            picBox4_pl3.Load("Avatars\\Icon4.png");
            picBox5_pl3.Load("Avatars\\Icon5.png");
            pl3AvailableIcons[0] = picBox1_pl3;
            pl3AvailableIcons[1] = picBox2_pl3;
            pl3AvailableIcons[2] = picBox3_pl3;
            pl3AvailableIcons[3] = picBox4_pl3;
            pl3AvailableIcons[4] = picBox5_pl3;

            // Player4
            picBox1_pl4.Load("Avatars\\Icon1.png");
            picBox2_pl4.Load("Avatars\\Icon2.png");
            picBox3_pl4.Load("Avatars\\Icon3.png");
            picBox4_pl4.Load("Avatars\\Icon4.png");
            picBox5_pl4.Load("Avatars\\Icon5.png");
            pl4AvailableIcons[0] = picBox1_pl4;
            pl4AvailableIcons[1] = picBox2_pl4;
            pl4AvailableIcons[2] = picBox3_pl4;
            pl4AvailableIcons[3] = picBox4_pl4;
            pl4AvailableIcons[4] = picBox5_pl4;

            Common.allIcons[0] = new Icons("Avatars\\user.png", "Default User");
            Common.allIcons[1] = new Icons("Avatars\\user.png", "Default User");
            Common.allIcons[2] = new Icons("Avatars\\user.png", "Default User");
            Common.allIcons[3] = new Icons("Avatars\\user.png", "Default User");

            groupMain.Enabled = false;
        }

        private void groupMain_Enter(object sender, EventArgs e)
        {
            // Disable the the group box 4 if the number of players are 3
            if(Common.getNumberofPlayers == 3)
            {
               
                groupBox4.Enabled = false;
            }
            else if(Common.getNumberofPlayers == 2)
            {
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
           
            else { groupMain.Enabled = true; }
        }

        private void picBoxShow_Selected_pl1_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picBoxShow_Selected_pl1.ImageLocation = pic.ImageLocation;
            Common.allIcons[0] = new Icons(pic.ImageLocation, "Player 1");
            disableImage(pic, 1);
        }

        private void picBoxShow_SelectedPl2_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picBoxShow_SelectedPl2.ImageLocation = pic.ImageLocation;
            Common.allIcons[1] = new Icons(pic.ImageLocation, "Player 2");
            disableImage(pic, 2);
        }

        private void picBoxShow_Selectedpl3_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picBoxShow_Selectedpl3.ImageLocation = pic.ImageLocation;
            Common.allIcons[2] = new Icons(pic.ImageLocation, "Player 3");
            disableImage(pic, 3);
        }

        private void picBoxShow_Selectedpl4_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picBoxShow_Selectedpl4.ImageLocation = pic.ImageLocation;
            Common.allIcons[3] = new Icons(pic.ImageLocation, "Player 4");
            disableImage(pic, 4);
        }

        private void disableImage(PictureBox icon, int player)
        {
            for (int i = 0; i < 5; i++)
            {
                if (pl1AvailableIcons[i].Visible)
                    pl1AvailableIcons[i].Visible = pl2AvailableIcons[i].ImageLocation != icon.ImageLocation;
                if (pl2AvailableIcons[i].Visible)
                    pl2AvailableIcons[i].Visible = pl2AvailableIcons[i].ImageLocation != icon.ImageLocation;
                if (pl3AvailableIcons[i].Visible)
                    pl3AvailableIcons[i].Visible = pl3AvailableIcons[i].ImageLocation != icon.ImageLocation;
                if (pl4AvailableIcons[i].Visible)
                    pl4AvailableIcons[i].Visible = pl4AvailableIcons[i].ImageLocation != icon.ImageLocation;
            }
            
        }
    }
}
