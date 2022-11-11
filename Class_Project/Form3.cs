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
    public partial class Form3 : Form
    {
        int[] dice = new int[5];
        int diceResult = 0;
        int roundCounter = 0;
        int maxRounds = 0;
        GamePlayers[] players;
        Label[] pointViews = new Label[4];
        Label[] bankViews = new Label[4];
        GroupBox[] containerViews = new GroupBox[4];
        int currentPlayerIndex = 0;
        int maxPlayers;
        Random rand = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            RollDice();
            GetResult();
            DisplayResult();
            

        }
        // Create a method Roll Dice
        private void RollDice()
        {
            for(int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 7);

                switch (dice[i])
                {
                    case 1:
                        picBoxChangeDice.Load("Dice\\dice1.png");
                        diceResult = 1;
                        break; 
                    case 2: 
                        picBoxChangeDice.Load("Dice\\dice2.png");
                        diceResult = 2;
                        break;
                    case 3: 
                        picBoxChangeDice.Load("Dice\\dice3.png");
                        diceResult = 3;
                        break;
                    case 4:
                        picBoxChangeDice.Load("Dice\\dice4.png");
                        diceResult = 4;
                        break;
                    case 5: 
                        picBoxChangeDice.Load("Dice\\dice5.png");
                        diceResult = 5;
                        break;
                    case 6: 
                        picBoxChangeDice.Load("Dice\\dice6.png"); 
                        diceResult = 6; 
                        break;
                }
            }
        }
        // Create a method to get the dice result
        private void GetResult()
        {
            // Add the point
            players[currentPlayerIndex].bank = diceResult;
            // Update UI
            bankViews[currentPlayerIndex].Text = diceResult.ToString();
            // Move to next player
            currentPlayerIndex++;
            // Check if last player;
            // Do round logic
            if (currentPlayerIndex >= maxPlayers)
            {
                currentPlayerIndex = 0;
                roundCounter++;
                calculatePoints();
                
            }
            // Check if last round;
            if (roundCounter >= maxRounds)
            {
                int tempHighScore = 0;
                int winnerIndex = 0;
                string winnerName = "";
                for (int a = 0; a < maxPlayers; a++)
                {
                    if (players[a].points >= tempHighScore)
                    {
                        tempHighScore = players[a].points;
                        winnerIndex = a;
                    }
                }

                winnerName = players[winnerIndex].name;
                DialogResult dialog = MessageBox.Show(
                    "Game over, Winner is " + players[winnerIndex].name + " with " + players[winnerIndex].points + " points.",
                    "Restart?",
                    MessageBoxButtons.YesNo
                );
                
                if(dialog == DialogResult.Yes)
                {
                    for (int i = 0; i < maxPlayers; i++)
                    {
                        players[i].bank = 0;
                        players[i].points = 0;
                    }
                    roundCounter = 0;
                    diceResult = 0;
                    currentPlayerIndex = 0;
                    DisplayResult();
                }
                else
                {
                    this.Close();
                }
            }
        }
        // Create a method load player point and bank from logic
        private void DisplayResult()
        {
            for (int j = 0; j < maxPlayers; j++)
            {
                pointViews[j].Text = players[j].points.ToString();
                bankViews[j].Text = players[j].bank.ToString();
                if (currentPlayerIndex == j)
                {
                    containerViews[j].BackColor = Color.Green;
                } 
                else
                {
                    containerViews[j].BackColor = Color.FromArgb(192, 192, 255);
                }
                
             }
            roundTextLbl.Text = (roundCounter + 1).ToString();
        }
        private void Form3_Load(object sender, EventArgs e)
        { 
            // Check the visibility of the group box in form3 if the number of players are entered
            // Load necessary views to arrays so that access by index is easy
            if(Common.getNumberofPlayers == 3)
            {
                players = new GamePlayers[3];
                maxPlayers = 3;
                pictureBox1.Load(Common.allIcons[0].img);
                pictureBox2.Load(Common.allIcons[1].img);
                pictureBox3.Load(Common.allIcons[2].img);
                groupBoxPl4_Start.Visible = false;
            }
            else if(Common.getNumberofPlayers == 2)
            {
                players = new GamePlayers[2];
                maxPlayers = 2;
                pictureBox1.Load(Common.allIcons[0].img);
                pictureBox2.Load(Common.allIcons[1].img);
                groupBoxPl3_Start.Visible = false;
                groupBoxPl4_Start.Visible = false;
            }
            else
            {
                // For 4 Players
                players = new GamePlayers[4];
                maxPlayers = 4;
                pictureBox1.Load(Common.allIcons[0].img);
                pictureBox2.Load(Common.allIcons[1].img);
                pictureBox3.Load(Common.allIcons[2].img);
                pictureBox4.Load(Common.allIcons[3].img);
                groupBoxPl1_Start.Visible = true;
                groupBoxPl2_Start.Visible = true;
                groupBoxPl3_Start.Visible = true;
                groupBoxPl4_Start.Visible = true;
            }
            lblshowpl1Name.Text = Form2.pl1name;
            lblshowpl2name.Text = Form2.pl2name;
            lblshowpl3name.Text = Form2.pl3name;
            lblshowpl4name.Text = Form2.pl4name;



            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new GamePlayers();
                switch (i)
                {
                    case 0:
                        players[0].name = Form2.pl1name;
                        break;
                    case 1:
                        players[1].name = Form2.pl2name;
                        break;
                    case 2:
                        players[2].name = Form2.pl3name;
                        break;
                    case 3:
                        players[3].name = Form2.pl4name;
                        break;
                }
            }
            

            pointViews[0] = lblshowpl1points;
            pointViews[1] = lblshowpl2points;
            pointViews[2] = lblshowpl3points;
            pointViews[3] = lblshowpl4points;

            bankViews[0] = lblshowpl1bank;
            bankViews[1] = lblshowpl2bank;
            bankViews[2] = lblshowpl3bank;
            bankViews[3] = lblshowpl4bank;

            containerViews[0] = groupBoxPl1_Start;
            containerViews[1] = groupBoxPl2_Start;
            containerViews[2] = groupBoxPl3_Start;
            containerViews[3] = groupBoxPl4_Start;

            maxRounds = Common.getRounds;

            for (int j = 0; j < maxPlayers; j++)
            {
                if (currentPlayerIndex == j)
                {
                    containerViews[j].BackColor = Color.Green;
                }
                else
                {
                    containerViews[j].BackColor = Color.FromArgb(192, 192, 255);
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatePoints()
        {
            for (int x = 0; x < maxPlayers; x++)
            {
                int bankToCheck = players[x].bank; //5
                for(int y = 0; y < maxPlayers; y++)
                {
                    if (x == y) continue;
                    if(players[y].bank == bankToCheck)
                    {
                        players[x].bank = 0;
                        players[y].bank = 0;
                    }
                }
            }
            for (int x = 0; x < maxPlayers; x++)
            {
                players[x].points += players[x].bank;
                players[x].bank = 0;
            }

        }
    }
}
