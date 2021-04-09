
namespace PI3_Havana
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnTestBoard = new System.Windows.Forms.Button();
            this.lblPawn2 = new System.Windows.Forms.Label();
            this.lblPawn1 = new System.Windows.Forms.Label();
            this.lblPawn3 = new System.Windows.Forms.Label();
            this.btnViewBoard = new System.Windows.Forms.Button();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.grBoxClimbers = new System.Windows.Forms.GroupBox();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblDie3 = new System.Windows.Forms.Label();
            this.lblDie4 = new System.Windows.Forms.Label();
            this.grBoxClimbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestBoard
            // 
            this.btnTestBoard.BackColor = System.Drawing.Color.White;
            this.btnTestBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestBoard.ForeColor = System.Drawing.Color.Black;
            this.btnTestBoard.Location = new System.Drawing.Point(12, 12);
            this.btnTestBoard.Name = "btnTestBoard";
            this.btnTestBoard.Size = new System.Drawing.Size(75, 23);
            this.btnTestBoard.TabIndex = 6;
            this.btnTestBoard.Text = "TRY";
            this.btnTestBoard.UseVisualStyleBackColor = false;
            this.btnTestBoard.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPawn2
            // 
            this.lblPawn2.AutoSize = true;
            this.lblPawn2.BackColor = System.Drawing.Color.Transparent;
            this.lblPawn2.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPawn2.ForeColor = System.Drawing.Color.Black;
            this.lblPawn2.Location = new System.Drawing.Point(79, 28);
            this.lblPawn2.Name = "lblPawn2";
            this.lblPawn2.Size = new System.Drawing.Size(43, 38);
            this.lblPawn2.TabIndex = 19;
            this.lblPawn2.Text = "l";
            // 
            // lblPawn1
            // 
            this.lblPawn1.AutoSize = true;
            this.lblPawn1.BackColor = System.Drawing.Color.Transparent;
            this.lblPawn1.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPawn1.ForeColor = System.Drawing.Color.Black;
            this.lblPawn1.Location = new System.Drawing.Point(46, 66);
            this.lblPawn1.Name = "lblPawn1";
            this.lblPawn1.Size = new System.Drawing.Size(43, 38);
            this.lblPawn1.TabIndex = 20;
            this.lblPawn1.Text = "l";
            this.lblPawn1.Click += new System.EventHandler(this.lblPawn1_Click);
            // 
            // lblPawn3
            // 
            this.lblPawn3.AutoSize = true;
            this.lblPawn3.BackColor = System.Drawing.Color.Transparent;
            this.lblPawn3.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPawn3.ForeColor = System.Drawing.Color.Black;
            this.lblPawn3.Location = new System.Drawing.Point(95, 66);
            this.lblPawn3.Name = "lblPawn3";
            this.lblPawn3.Size = new System.Drawing.Size(43, 38);
            this.lblPawn3.TabIndex = 21;
            this.lblPawn3.Text = "l";
            // 
            // btnViewBoard
            // 
            this.btnViewBoard.BackColor = System.Drawing.Color.White;
            this.btnViewBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewBoard.ForeColor = System.Drawing.Color.Black;
            this.btnViewBoard.Location = new System.Drawing.Point(12, 53);
            this.btnViewBoard.Name = "btnViewBoard";
            this.btnViewBoard.Size = new System.Drawing.Size(75, 37);
            this.btnViewBoard.TabIndex = 22;
            this.btnViewBoard.Text = "VIEW BOARD";
            this.btnViewBoard.UseVisualStyleBackColor = false;
            this.btnViewBoard.Click += new System.EventHandler(this.btnGenPawns_Click);
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.White;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRollDice.ForeColor = System.Drawing.Color.Black;
            this.btnRollDice.Location = new System.Drawing.Point(13, 107);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 23;
            this.btnRollDice.Text = "ROLL DICE";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // grBoxClimbers
            // 
            this.grBoxClimbers.BackColor = System.Drawing.Color.White;
            this.grBoxClimbers.Controls.Add(this.lblPawn3);
            this.grBoxClimbers.Controls.Add(this.lblPawn1);
            this.grBoxClimbers.Controls.Add(this.lblPawn2);
            this.grBoxClimbers.Location = new System.Drawing.Point(608, 53);
            this.grBoxClimbers.Name = "grBoxClimbers";
            this.grBoxClimbers.Size = new System.Drawing.Size(190, 119);
            this.grBoxClimbers.TabIndex = 24;
            this.grBoxClimbers.TabStop = false;
            this.grBoxClimbers.Text = "Available Climbers";
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.BackColor = System.Drawing.Color.Transparent;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(608, 252);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(91, 29);
            this.lblDie1.TabIndex = 25;
            this.lblDie1.Text = "______";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.BackColor = System.Drawing.Color.Transparent;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(608, 287);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(91, 29);
            this.lblDie2.TabIndex = 26;
            this.lblDie2.Text = "______";
            // 
            // lblDie3
            // 
            this.lblDie3.AutoSize = true;
            this.lblDie3.BackColor = System.Drawing.Color.Transparent;
            this.lblDie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie3.Location = new System.Drawing.Point(608, 324);
            this.lblDie3.Name = "lblDie3";
            this.lblDie3.Size = new System.Drawing.Size(91, 29);
            this.lblDie3.TabIndex = 27;
            this.lblDie3.Text = "______";
            // 
            // lblDie4
            // 
            this.lblDie4.AutoSize = true;
            this.lblDie4.BackColor = System.Drawing.Color.Transparent;
            this.lblDie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie4.Location = new System.Drawing.Point(608, 364);
            this.lblDie4.Name = "lblDie4";
            this.lblDie4.Size = new System.Drawing.Size(91, 29);
            this.lblDie4.TabIndex = 28;
            this.lblDie4.Text = "______";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 546);
            this.Controls.Add(this.lblDie4);
            this.Controls.Add(this.lblDie3);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.grBoxClimbers);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.btnViewBoard);
            this.Controls.Add(this.btnTestBoard);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.grBoxClimbers.ResumeLayout(false);
            this.grBoxClimbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTestBoard;
        public System.Windows.Forms.Label lblPawn2;
        public System.Windows.Forms.Label lblPawn1;
        public System.Windows.Forms.Label lblPawn3;
        private System.Windows.Forms.Button btnViewBoard;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.GroupBox grBoxClimbers;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblDie3;
        private System.Windows.Forms.Label lblDie4;
    }
}