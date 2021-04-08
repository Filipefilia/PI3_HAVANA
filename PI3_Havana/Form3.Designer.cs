
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
            this.btnGenPawns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestBoard
            // 
            this.btnTestBoard.ForeColor = System.Drawing.Color.Black;
            this.btnTestBoard.Location = new System.Drawing.Point(12, 12);
            this.btnTestBoard.Name = "btnTestBoard";
            this.btnTestBoard.Size = new System.Drawing.Size(75, 23);
            this.btnTestBoard.TabIndex = 6;
            this.btnTestBoard.Text = "TRY";
            this.btnTestBoard.UseVisualStyleBackColor = true;
            this.btnTestBoard.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPawn2
            // 
            this.lblPawn2.AutoSize = true;
            this.lblPawn2.BackColor = System.Drawing.Color.Transparent;
            this.lblPawn2.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPawn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPawn2.Location = new System.Drawing.Point(643, 93);
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
            this.lblPawn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPawn1.Location = new System.Drawing.Point(582, 130);
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
            this.lblPawn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPawn3.Location = new System.Drawing.Point(692, 130);
            this.lblPawn3.Name = "lblPawn3";
            this.lblPawn3.Size = new System.Drawing.Size(43, 38);
            this.lblPawn3.TabIndex = 21;
            this.lblPawn3.Text = "l";
            // 
            // btnGenPawns
            // 
            this.btnGenPawns.Location = new System.Drawing.Point(12, 53);
            this.btnGenPawns.Name = "btnGenPawns";
            this.btnGenPawns.Size = new System.Drawing.Size(75, 23);
            this.btnGenPawns.TabIndex = 22;
            this.btnGenPawns.Text = "button1";
            this.btnGenPawns.UseVisualStyleBackColor = true;
            this.btnGenPawns.Click += new System.EventHandler(this.btnGenPawns_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 546);
            this.Controls.Add(this.btnGenPawns);
            this.Controls.Add(this.lblPawn3);
            this.Controls.Add(this.lblPawn1);
            this.Controls.Add(this.lblPawn2);
            this.Controls.Add(this.btnTestBoard);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTestBoard;
        public System.Windows.Forms.Label lblPawn2;
        public System.Windows.Forms.Label lblPawn1;
        public System.Windows.Forms.Label lblPawn3;
        private System.Windows.Forms.Button btnGenPawns;
    }
}