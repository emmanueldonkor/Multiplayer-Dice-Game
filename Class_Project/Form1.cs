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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_the_game_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the game", "Exiting");
            Application.Exit();
        }

        private void btnGameStarter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening the game settings");
            this.Hide();
            Form2 form2= new Form2();
            form2.ShowDialog(); 
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
