using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        bool turnPlayer1 = true;
        bool turnPlayer2 = false;
        int Player2Class = 0;

        bool isKnightPlayer1 = false;
        bool isMagePlayer1 = false;
        bool isSpearmanPlayer1 = false;

        bool isKnightPlayer2 = false;
        bool isMagePlayer2 = false;
        bool isSpearmanPlayer2 = false;

        private static Random randomImage = null;
        Speler Player1 = null;
        Speler Player2 = null;

        public Form1()
        {
            InitializeComponent();
            tbcMakePlayer.Appearance = TabAppearance.FlatButtons;
            tbcMakePlayer.ItemSize = new Size(0, 1);
            tbcMakePlayer.SizeMode = TabSizeMode.Fixed;
            randomImage = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Change image to knight
        private void rbtSelectKnight_CheckedChanged(object sender, EventArgs e)
        {
            pbxCreatePlayer.Image = BattleSim.Properties.Resources.knight;
        }

        //Change image to mage
        private void rbtSelectSpear_CheckedChanged(object sender, EventArgs e)
        {
            pbxCreatePlayer.Image = BattleSim.Properties.Resources.spear;
        }


        //Change image to spearman
        private void rbtSelectMage_CheckedChanged(object sender, EventArgs e)
        {
            pbxCreatePlayer.Image = BattleSim.Properties.Resources.mage;
        }

        // Create Player 1 and Create a random enemy (knight, mage, Spearman); then set name and hp to labels.
        public void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            //Switch to tabpage 1
            tbcMakePlayer.SelectedIndex = 1;

            //if knight is selected make the player 1 a knight with 100 hp a knight image
            if(rbtSelectKnight.Checked == true) {
               Player1 = new Speler(tbxPlayerName.Text, 100);
                isKnightPlayer1 = true;
                pbxPlayer1.Image = Properties.Resources.knight;
            } else if(rbtSelectMage.Checked == true)
            { //if mage is selected make the player 1 a mage with 80 hp a mage image
                Player1 = new Speler(tbxPlayerName.Text, 80);
                isMagePlayer1 = true;
                pbxPlayer1.Image = Properties.Resources.mage;
            } else if(rbtSelectSpear.Checked == true)
            {//if spearman is selected make the player 1 a spearman with 120 hp a spearmanimage
                Player1 = new Speler(tbxPlayerName.Text, 120);
                isSpearmanPlayer1 = true;
                pbxPlayer1.Image = Properties.Resources.spear;
            }
            
            //Randomise the class of player 2
            Player2Class = randomImage.Next(1, 3);
            //If player2Class is 1, make player 2 a knight
            if(Player2Class == 1) {
                isKnightPlayer2 = true;
                Player2 = new Speler("Knight", 100);
                pbxPlayer2.Image = Properties.Resources.knight;
            } else if(Player2Class == 2) {
                //if player2Class is 2 make player 2 a mage
                isMagePlayer2 = true;
                Player2 = new Speler("Mage", 80);
                pbxPlayer2.Image = Properties.Resources.mage;
            } else if(Player2Class == 3) {
                //if player2Class is 3 make player 2 a spearman
                isSpearmanPlayer2 = true;
                Player2 = new Speler("Spearman", 120);
                pbxPlayer2.Image = Properties.Resources.spear;
            }

            //Set Names and Hp to label text
            lblPlayer1Name.Text = Player1.GetName();
            lblPlayer1Hp.Text = Convert.ToString(Player1.GetHitPoints());

            lblPlayer2Name.Text = Player2.GetName();
            lblPlayer2Hp.Text = Convert.ToString(Player2.GetHitPoints());
        }

        private void btnAttackPlayer1_Click(object sender, EventArgs e)
        {
            if (isKnightPlayer1 == true) {
                Player2.DealDamageKnight(Convert.ToInt32(lblPlayer1Hp.Text));
            } else if(isMagePlayer1 == true) {
                Player2.DealDamageMage();
            } else if(isSpearmanPlayer1 == true) {
                Player2.DealDamageSpearman();
            }
            
            if (turnPlayer1 == true)
            {
                turnPlayer1 = false;
                turnPlayer2 = true;
                btnAttackPlayer1.Enabled = false;
                btnAttackPlayer2.Enabled = true;
            }

            int player2HitPoints = Player2.GetHitPoints();
            lblPlayer2Hp.Text = Convert.ToString(player2HitPoints);
            if (player2HitPoints <= 0)
            {
                lblPlayer2Hp.Text = "0";
                MessageBox.Show(Player1.GetName() + " wins!");
            }
        }

        private void btnAttackPlayer2_Click(object sender, EventArgs e)
        {
            if (isKnightPlayer2 == true)
            {
                Player1.DealDamageKnight(Convert.ToInt32(lblPlayer2Hp.Text));
            }
            else if (isMagePlayer2 == true)
            {
                Player1.DealDamageMage();
            }
            else if (isSpearmanPlayer2 == true)
            {
                Player1.DealDamageSpearman();
            }
            if (turnPlayer2 == true)
            {
                turnPlayer2 = false;
                turnPlayer1 = true;
                btnAttackPlayer2.Enabled = false;
                btnAttackPlayer1.Enabled = true;
            }

            int player1HitPoints = Player1.GetHitPoints();
            lblPlayer1Hp.Text = Convert.ToString(player1HitPoints);
            if (player1HitPoints <= 0)
            {
                lblPlayer1Hp.Text = "0";
                MessageBox.Show(Player2.GetName() + " wins!");
            }
        }
    }
}
