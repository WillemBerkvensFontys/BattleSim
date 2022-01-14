namespace BattleSim
{
    partial class Form1
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
            this.tbcMakePlayer = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.pbxCreatePlayer = new System.Windows.Forms.PictureBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.rbtSelectSpear = new System.Windows.Forms.RadioButton();
            this.rbtSelectMage = new System.Windows.Forms.RadioButton();
            this.rbtSelectKnight = new System.Windows.Forms.RadioButton();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.lblCreatePlayerName = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAttackPlayer2 = new System.Windows.Forms.Button();
            this.btnAttackPlayer1 = new System.Windows.Forms.Button();
            this.lblPlayer2Hp = new System.Windows.Forms.Label();
            this.lblPlayer1Hp = new System.Windows.Forms.Label();
            this.lblPlayerHp2 = new System.Windows.Forms.Label();
            this.lblPlayerHP1 = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.pbxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.tbcMakePlayer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCreatePlayer)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMakePlayer
            // 
            this.tbcMakePlayer.Controls.Add(this.tabPage3);
            this.tbcMakePlayer.Controls.Add(this.tabPage4);
            this.tbcMakePlayer.Location = new System.Drawing.Point(0, 0);
            this.tbcMakePlayer.Name = "tbcMakePlayer";
            this.tbcMakePlayer.SelectedIndex = 0;
            this.tbcMakePlayer.Size = new System.Drawing.Size(944, 569);
            this.tbcMakePlayer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSelectClass);
            this.tabPage3.Controls.Add(this.pbxCreatePlayer);
            this.tabPage3.Controls.Add(this.btnCreatePlayer);
            this.tabPage3.Controls.Add(this.rbtSelectSpear);
            this.tabPage3.Controls.Add(this.rbtSelectMage);
            this.tabPage3.Controls.Add(this.rbtSelectKnight);
            this.tabPage3.Controls.Add(this.tbxPlayerName);
            this.tabPage3.Controls.Add(this.lblCreatePlayerName);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(936, 540);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tbpCreatePlayer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Location = new System.Drawing.Point(49, 105);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(89, 17);
            this.lblSelectClass.TabIndex = 7;
            this.lblSelectClass.Text = "Select Class:";
            // 
            // pbxCreatePlayer
            // 
            this.pbxCreatePlayer.InitialImage = global::BattleSim.Properties.Resources.spear;
            this.pbxCreatePlayer.Location = new System.Drawing.Point(545, 7);
            this.pbxCreatePlayer.Name = "pbxCreatePlayer";
            this.pbxCreatePlayer.Size = new System.Drawing.Size(385, 413);
            this.pbxCreatePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCreatePlayer.TabIndex = 6;
            this.pbxCreatePlayer.TabStop = false;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(52, 353);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(130, 44);
            this.btnCreatePlayer.TabIndex = 5;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // rbtSelectSpear
            // 
            this.rbtSelectSpear.AutoSize = true;
            this.rbtSelectSpear.Location = new System.Drawing.Point(52, 179);
            this.rbtSelectSpear.Name = "rbtSelectSpear";
            this.rbtSelectSpear.Size = new System.Drawing.Size(94, 21);
            this.rbtSelectSpear.TabIndex = 4;
            this.rbtSelectSpear.TabStop = true;
            this.rbtSelectSpear.Text = "Spearman";
            this.rbtSelectSpear.UseVisualStyleBackColor = true;
            this.rbtSelectSpear.CheckedChanged += new System.EventHandler(this.rbtSelectSpear_CheckedChanged);
            // 
            // rbtSelectMage
            // 
            this.rbtSelectMage.AutoSize = true;
            this.rbtSelectMage.Location = new System.Drawing.Point(52, 152);
            this.rbtSelectMage.Name = "rbtSelectMage";
            this.rbtSelectMage.Size = new System.Drawing.Size(64, 21);
            this.rbtSelectMage.TabIndex = 3;
            this.rbtSelectMage.TabStop = true;
            this.rbtSelectMage.Text = "Mage";
            this.rbtSelectMage.UseVisualStyleBackColor = true;
            this.rbtSelectMage.CheckedChanged += new System.EventHandler(this.rbtSelectMage_CheckedChanged);
            // 
            // rbtSelectKnight
            // 
            this.rbtSelectKnight.AutoSize = true;
            this.rbtSelectKnight.Location = new System.Drawing.Point(52, 125);
            this.rbtSelectKnight.Name = "rbtSelectKnight";
            this.rbtSelectKnight.Size = new System.Drawing.Size(69, 21);
            this.rbtSelectKnight.TabIndex = 2;
            this.rbtSelectKnight.TabStop = true;
            this.rbtSelectKnight.Text = "Knight";
            this.rbtSelectKnight.UseVisualStyleBackColor = true;
            this.rbtSelectKnight.CheckedChanged += new System.EventHandler(this.rbtSelectKnight_CheckedChanged);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(52, 59);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(100, 22);
            this.tbxPlayerName.TabIndex = 1;
            // 
            // lblCreatePlayerName
            // 
            this.lblCreatePlayerName.AutoSize = true;
            this.lblCreatePlayerName.Location = new System.Drawing.Point(49, 39);
            this.lblCreatePlayerName.Name = "lblCreatePlayerName";
            this.lblCreatePlayerName.Size = new System.Drawing.Size(93, 17);
            this.lblCreatePlayerName.TabIndex = 0;
            this.lblCreatePlayerName.Text = "Player Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAttackPlayer2);
            this.tabPage4.Controls.Add(this.btnAttackPlayer1);
            this.tabPage4.Controls.Add(this.lblPlayer2Hp);
            this.tabPage4.Controls.Add(this.lblPlayer1Hp);
            this.tabPage4.Controls.Add(this.lblPlayerHp2);
            this.tabPage4.Controls.Add(this.lblPlayerHP1);
            this.tabPage4.Controls.Add(this.lblPlayer2Name);
            this.tabPage4.Controls.Add(this.lblPlayer1Name);
            this.tabPage4.Controls.Add(this.pbxPlayer2);
            this.tabPage4.Controls.Add(this.pbxPlayer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(936, 540);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tbpPlayGame";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAttackPlayer2
            // 
            this.btnAttackPlayer2.Location = new System.Drawing.Point(579, 414);
            this.btnAttackPlayer2.Name = "btnAttackPlayer2";
            this.btnAttackPlayer2.Size = new System.Drawing.Size(235, 43);
            this.btnAttackPlayer2.TabIndex = 9;
            this.btnAttackPlayer2.Text = "Attack!";
            this.btnAttackPlayer2.UseVisualStyleBackColor = true;
            this.btnAttackPlayer2.Click += new System.EventHandler(this.btnAttackPlayer2_Click);
            // 
            // btnAttackPlayer1
            // 
            this.btnAttackPlayer1.Location = new System.Drawing.Point(154, 414);
            this.btnAttackPlayer1.Name = "btnAttackPlayer1";
            this.btnAttackPlayer1.Size = new System.Drawing.Size(235, 43);
            this.btnAttackPlayer1.TabIndex = 8;
            this.btnAttackPlayer1.Text = "Attack";
            this.btnAttackPlayer1.UseVisualStyleBackColor = true;
            this.btnAttackPlayer1.Click += new System.EventHandler(this.btnAttackPlayer1_Click);
            // 
            // lblPlayer2Hp
            // 
            this.lblPlayer2Hp.AutoSize = true;
            this.lblPlayer2Hp.Location = new System.Drawing.Point(613, 380);
            this.lblPlayer2Hp.Name = "lblPlayer2Hp";
            this.lblPlayer2Hp.Size = new System.Drawing.Size(20, 17);
            this.lblPlayer2Hp.TabIndex = 7;
            this.lblPlayer2Hp.Text = "...";
            // 
            // lblPlayer1Hp
            // 
            this.lblPlayer1Hp.AutoSize = true;
            this.lblPlayer1Hp.Location = new System.Drawing.Point(191, 380);
            this.lblPlayer1Hp.Name = "lblPlayer1Hp";
            this.lblPlayer1Hp.Size = new System.Drawing.Size(20, 17);
            this.lblPlayer1Hp.TabIndex = 6;
            this.lblPlayer1Hp.Text = "...";
            // 
            // lblPlayerHp2
            // 
            this.lblPlayerHp2.AutoSize = true;
            this.lblPlayerHp2.Location = new System.Drawing.Point(576, 380);
            this.lblPlayerHp2.Name = "lblPlayerHp2";
            this.lblPlayerHp2.Size = new System.Drawing.Size(31, 17);
            this.lblPlayerHp2.TabIndex = 5;
            this.lblPlayerHp2.Text = "HP:";
            // 
            // lblPlayerHP1
            // 
            this.lblPlayerHP1.AutoSize = true;
            this.lblPlayerHP1.Location = new System.Drawing.Point(154, 380);
            this.lblPlayerHP1.Name = "lblPlayerHP1";
            this.lblPlayerHP1.Size = new System.Drawing.Size(31, 17);
            this.lblPlayerHP1.TabIndex = 4;
            this.lblPlayerHP1.Text = "HP:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(576, 348);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(20, 17);
            this.lblPlayer2Name.TabIndex = 3;
            this.lblPlayer2Name.Text = "...";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(154, 348);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(20, 17);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "...";
            // 
            // pbxPlayer2
            // 
            this.pbxPlayer2.Location = new System.Drawing.Point(579, 28);
            this.pbxPlayer2.Name = "pbxPlayer2";
            this.pbxPlayer2.Size = new System.Drawing.Size(235, 300);
            this.pbxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer2.TabIndex = 1;
            this.pbxPlayer2.TabStop = false;
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.Location = new System.Drawing.Point(154, 28);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(235, 300);
            this.pbxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer1.TabIndex = 0;
            this.pbxPlayer1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(947, 612);
            this.Controls.Add(this.tbcMakePlayer);
            this.Name = "Form1";
            this.tbcMakePlayer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCreatePlayer)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMakePlayer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblCreatePlayerName;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.RadioButton rbtSelectSpear;
        private System.Windows.Forms.RadioButton rbtSelectMage;
        private System.Windows.Forms.RadioButton rbtSelectKnight;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.PictureBox pbxCreatePlayer;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.PictureBox pbxPlayer2;
        private System.Windows.Forms.PictureBox pbxPlayer1;
        private System.Windows.Forms.Label lblPlayerHP1;
        private System.Windows.Forms.Label lblPlayer1Hp;
        private System.Windows.Forms.Label lblPlayerHp2;
        private System.Windows.Forms.Label lblPlayer2Hp;
        private System.Windows.Forms.Button btnAttackPlayer2;
        private System.Windows.Forms.Button btnAttackPlayer1;
    }
}

