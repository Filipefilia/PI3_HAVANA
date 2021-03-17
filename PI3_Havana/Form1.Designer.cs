
namespace PI3_Havana
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
            this.listGames = new System.Windows.Forms.ListBox();
            this.btnListGames = new System.Windows.Forms.Button();
            this.listPlayers = new System.Windows.Forms.ListBox();
            this.btnListPlayers = new System.Windows.Forms.Button();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPasswordGame = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPasswordEnter = new System.Windows.Forms.Label();
            this.btnEnterGame = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listGames
            // 
            this.listGames.FormattingEnabled = true;
            this.listGames.Location = new System.Drawing.Point(30, 31);
            this.listGames.MultiColumn = true;
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(120, 95);
            this.listGames.TabIndex = 0;
            this.listGames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnListGames
            // 
            this.btnListGames.Location = new System.Drawing.Point(30, 169);
            this.btnListGames.Name = "btnListGames";
            this.btnListGames.Size = new System.Drawing.Size(120, 23);
            this.btnListGames.TabIndex = 1;
            this.btnListGames.Text = "ListaPartidas";
            this.btnListGames.UseVisualStyleBackColor = true;
            this.btnListGames.Click += new System.EventHandler(this.button1_Click);
            // 
            // listPlayers
            // 
            this.listPlayers.FormattingEnabled = true;
            this.listPlayers.Location = new System.Drawing.Point(173, 31);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(120, 95);
            this.listPlayers.TabIndex = 2;
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.Location = new System.Drawing.Point(173, 169);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(120, 23);
            this.btnListPlayers.TabIndex = 3;
            this.btnListPlayers.Text = "Lista Jogadores";
            this.btnListPlayers.UseVisualStyleBackColor = true;
            this.btnListPlayers.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(381, 31);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(100, 20);
            this.txtGameName.TabIndex = 4;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(488, 37);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(86, 13);
            this.lbGameName.TabIndex = 5;
            this.lbGameName.Text = "Nome da Partida";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(381, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(487, 60);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(38, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Senha";
            this.lbPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(381, 84);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(100, 23);
            this.btnCreateGame.TabIndex = 8;
            this.btnCreateGame.Text = "Criar Partida";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(381, 136);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 9;
            // 
            // txtPasswordGame
            // 
            this.txtPasswordGame.Location = new System.Drawing.Point(381, 162);
            this.txtPasswordGame.Name = "txtPasswordGame";
            this.txtPasswordGame.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordGame.TabIndex = 10;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(487, 139);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(91, 13);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "Nome do Jogador";
            // 
            // lblPasswordEnter
            // 
            this.lblPasswordEnter.AutoSize = true;
            this.lblPasswordEnter.Location = new System.Drawing.Point(488, 168);
            this.lblPasswordEnter.Name = "lblPasswordEnter";
            this.lblPasswordEnter.Size = new System.Drawing.Size(89, 13);
            this.lblPasswordEnter.TabIndex = 12;
            this.lblPasswordEnter.Text = "Senha da Partida";
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Location = new System.Drawing.Point(381, 189);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.Size = new System.Drawing.Size(100, 23);
            this.btnEnterGame.TabIndex = 13;
            this.btnEnterGame.Text = "Entrar na Partida";
            this.btnEnterGame.UseVisualStyleBackColor = true;
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(585, 227);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "label1";
            this.lblVersion.Click += new System.EventHandler(this.lvlVersion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 249);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnEnterGame);
            this.Controls.Add(this.lblPasswordEnter);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPasswordGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.listPlayers);
            this.Controls.Add(this.btnListGames);
            this.Controls.Add(this.listGames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListGames;
        public System.Windows.Forms.ListBox listGames;
        private System.Windows.Forms.ListBox listPlayers;
        private System.Windows.Forms.Button btnListPlayers;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPasswordGame;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPasswordEnter;
        private System.Windows.Forms.Button btnEnterGame;
        private System.Windows.Forms.Label lblVersion;
    }
}

