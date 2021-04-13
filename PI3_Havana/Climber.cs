using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PI3_Havana
{
    class Climber
    {
        public Label genClimber = new Label();

        public Climber ()
        {
            this.genClimber.Text = "l";
            this.genClimber.Font = new Font("Wingdings", 10);
            this.genClimber.Visible = true;
            this.genClimber.ForeColor = Color.White;
            this.genClimber.BackColor = Color.Transparent;
            this.genClimber.Size = new System.Drawing.Size(43, 38);
            //genClimber.Location = new Point(0, 0);
            //Form3.ActiveForm.Controls.Add(this.genClimber);
        }

        public Point setClimberLocation (int posX, int posY)
        {
            this.genClimber.Location = new Point(posX, posY);
            //board.ActiveForm.Controls.Add(this.genClimber);
            //this.genClimber.Show();
            return this.genClimber.Location;
        }
    }
}
