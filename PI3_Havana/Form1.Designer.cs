
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
            this.components = new System.ComponentModel.Container();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.txtInputPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPasswordGame = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPasswordEnter = new System.Windows.Forms.Label();
            this.btnEnterGame = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.dgrLobby = new System.Windows.Forms.DataGridView();
            this.btnSelectGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.txtPlayerCollor = new System.Windows.Forms.TextBox();
            this.txtGameId = new System.Windows.Forms.TextBox();
            this.lblCollor = new System.Windows.Forms.Label();
            this.lblGameId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetBoard = new System.Windows.Forms.Button();
            this.OS = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tb_botName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrLobby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(384, 285);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(100, 20);
            this.txtGameName.TabIndex = 4;
            this.txtGameName.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(490, 288);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(35, 13);
            this.lbGameName.TabIndex = 5;
            this.lbGameName.Text = "Name";
            this.lbGameName.Click += new System.EventHandler(this.lbGameName_Click);
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(384, 308);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.PasswordChar = '*';
            this.txtInputPassword.Size = new System.Drawing.Size(100, 20);
            this.txtInputPassword.TabIndex = 6;
            this.txtInputPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(490, 311);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            this.lbPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(384, 334);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(100, 49);
            this.btnCreateGame.TabIndex = 8;
            this.btnCreateGame.Text = "Create New Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(385, 412);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 9;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // txtPasswordGame
            // 
            this.txtPasswordGame.Location = new System.Drawing.Point(385, 438);
            this.txtPasswordGame.Name = "txtPasswordGame";
            this.txtPasswordGame.PasswordChar = '*';
            this.txtPasswordGame.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordGame.TabIndex = 10;
            this.txtPasswordGame.TextChanged += new System.EventHandler(this.txtPasswordGame_TextChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(491, 419);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(36, 13);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "Player";
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click);
            // 
            // lblPasswordEnter
            // 
            this.lblPasswordEnter.AutoSize = true;
            this.lblPasswordEnter.Location = new System.Drawing.Point(491, 445);
            this.lblPasswordEnter.Name = "lblPasswordEnter";
            this.lblPasswordEnter.Size = new System.Drawing.Size(84, 13);
            this.lblPasswordEnter.TabIndex = 12;
            this.lblPasswordEnter.Text = "Game Password";
            this.lblPasswordEnter.Click += new System.EventHandler(this.lblPasswordEnter_Click);
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Location = new System.Drawing.Point(385, 464);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.Size = new System.Drawing.Size(100, 49);
            this.btnEnterGame.TabIndex = 13;
            this.btnEnterGame.Text = "Enter Game";
            this.btnEnterGame.UseVisualStyleBackColor = true;
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(783, 539);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(27, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "DLL";
            this.lblVersion.Click += new System.EventHandler(this.lvlVersion_Click);
            // 
            // dgrLobby
            // 
            this.dgrLobby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLobby.Location = new System.Drawing.Point(33, 12);
            this.dgrLobby.Name = "dgrLobby";
            this.dgrLobby.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrLobby.Size = new System.Drawing.Size(496, 248);
            this.dgrLobby.TabIndex = 15;
            this.dgrLobby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLobby_CellContentClick);
            // 
            // btnSelectGame
            // 
            this.btnSelectGame.Location = new System.Drawing.Point(33, 284);
            this.btnSelectGame.Name = "btnSelectGame";
            this.btnSelectGame.Size = new System.Drawing.Size(100, 67);
            this.btnSelectGame.TabIndex = 16;
            this.btnSelectGame.Text = "Select";
            this.btnSelectGame.UseVisualStyleBackColor = true;
            this.btnSelectGame.Click += new System.EventHandler(this.btnSelectGame_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(153, 284);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 67);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(175, 411);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.ReadOnly = true;
            this.txtPlayerPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerPassword.TabIndex = 18;
            this.txtPlayerPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.Location = new System.Drawing.Point(172, 395);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(85, 13);
            this.lblPlayerPassword.TabIndex = 19;
            this.lblPlayerPassword.Text = "Player Password";
            this.lblPlayerPassword.Click += new System.EventHandler(this.lblPlayerPassword_Click);
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(33, 411);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.ReadOnly = true;
            this.txtPlayerId.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerId.TabIndex = 20;
            this.txtPlayerId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(33, 395);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerID.TabIndex = 22;
            this.lblPlayerID.Text = "Player ID";
            this.lblPlayerID.Click += new System.EventHandler(this.lblPlayerID_Click);
            // 
            // txtPlayerCollor
            // 
            this.txtPlayerCollor.Location = new System.Drawing.Point(33, 493);
            this.txtPlayerCollor.Name = "txtPlayerCollor";
            this.txtPlayerCollor.ReadOnly = true;
            this.txtPlayerCollor.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerCollor.TabIndex = 23;
            this.txtPlayerCollor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGameId
            // 
            this.txtGameId.Location = new System.Drawing.Point(175, 493);
            this.txtGameId.Name = "txtGameId";
            this.txtGameId.ReadOnly = true;
            this.txtGameId.Size = new System.Drawing.Size(100, 20);
            this.txtGameId.TabIndex = 24;
            this.txtGameId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblCollor
            // 
            this.lblCollor.AutoSize = true;
            this.lblCollor.Location = new System.Drawing.Point(33, 477);
            this.lblCollor.Name = "lblCollor";
            this.lblCollor.Size = new System.Drawing.Size(31, 13);
            this.lblCollor.TabIndex = 25;
            this.lblCollor.Text = "Color";
            this.lblCollor.Click += new System.EventHandler(this.lblCollor_Click);
            // 
            // lblGameId
            // 
            this.lblGameId.AutoSize = true;
            this.lblGameId.Location = new System.Drawing.Point(172, 477);
            this.lblGameId.Name = "lblGameId";
            this.lblGameId.Size = new System.Drawing.Size(49, 13);
            this.lblGameId.TabIndex = 26;
            this.lblGameId.Text = "Game ID";
            this.lblGameId.Click += new System.EventHandler(this.lblGameId_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 247);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetBoard);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(558, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 325);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Game";
            // 
            // btnGetBoard
            // 
            this.btnGetBoard.Location = new System.Drawing.Point(20, 284);
            this.btnGetBoard.Name = "btnGetBoard";
            this.btnGetBoard.Size = new System.Drawing.Size(240, 23);
            this.btnGetBoard.TabIndex = 28;
            this.btnGetBoard.Text = "Check Board";
            this.btnGetBoard.UseVisualStyleBackColor = true;
            this.btnGetBoard.Click += new System.EventHandler(this.btnGetBoard_Click);
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Location = new System.Drawing.Point(783, 514);
            this.OS.Name = "";
            this.OS.Size = new System.Drawing.Size(22, 13);
            this.OS.TabIndex = 29;
            this.OS.Text = "OS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(267, 284);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 67);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tb_botName
            // 
            this.tb_botName.Location = new System.Drawing.Point(750, 363);
            this.tb_botName.Name = "tb_botName";
            this.tb_botName.Size = new System.Drawing.Size(87, 20);
            this.tb_botName.TabIndex = 33;
            this.tb_botName.Text = "pc";
            this.tb_botName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_botName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_botName_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "User";
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(PI3_Havana.Session);
            this.sessionBindingSource.CurrentChanged += new System.EventHandler(this.sessionBindingSource_CurrentChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PI3_Havana.Form1);
            this.form1BindingSource.CurrentChanged += new System.EventHandler(this.form1BindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(871, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_botName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGameId);
            this.Controls.Add(this.lblCollor);
            this.Controls.Add(this.txtGameId);
            this.Controls.Add(this.txtPlayerCollor);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.txtPlayerId);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectGame);
            this.Controls.Add(this.dgrLobby);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnEnterGame);
            this.Controls.Add(this.lblPasswordEnter);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPasswordGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtInputPassword);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.txtGameName);
            this.Name = "Form1";
            this.Text = "Grupo Havana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrLobby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.TextBox txtInputPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPasswordGame;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPasswordEnter;
        private System.Windows.Forms.Button btnEnterGame;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.DataGridView dgrLobby;
        private System.Windows.Forms.Button btnSelectGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.TextBox txtPlayerCollor;
        private System.Windows.Forms.TextBox txtGameId;
        private System.Windows.Forms.Label lblCollor;
        private System.Windows.Forms.Label lblGameId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetBoard;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tb_botName;
        private System.Windows.Forms.Label label1;
    }
}

