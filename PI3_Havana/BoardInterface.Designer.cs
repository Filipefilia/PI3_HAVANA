
namespace PI3_Havana
{
    partial class BoardInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardInterface));
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.rollDice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.BackColor = System.Drawing.Color.Transparent;
            this.dice1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dice1.BackgroundImage")));
            this.dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice1.Location = new System.Drawing.Point(374, 538);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(54, 50);
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.Transparent;
            this.dice2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dice2.BackgroundImage")));
            this.dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice2.Location = new System.Drawing.Point(434, 538);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(54, 50);
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            // 
            // dice3
            // 
            this.dice3.BackColor = System.Drawing.Color.Transparent;
            this.dice3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dice3.BackgroundImage")));
            this.dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice3.Location = new System.Drawing.Point(494, 538);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(54, 50);
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            // 
            // dice4
            // 
            this.dice4.BackColor = System.Drawing.Color.Transparent;
            this.dice4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dice4.BackgroundImage")));
            this.dice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice4.Location = new System.Drawing.Point(554, 538);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(54, 50);
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(635, 538);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(75, 23);
            this.rollDice.TabIndex = 4;
            this.rollDice.Text = "Roll Dices";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // BoardInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI3_Havana.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(797, 636);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoardInterface";
            this.Text = "Cant Stop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoardInterface_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.Button rollDice;
    }
}