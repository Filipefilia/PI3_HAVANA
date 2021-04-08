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
            this.genClimber.Font = new Font("Wingdings", 26);
            this.genClimber.Visible = true;
            this.genClimber.ForeColor = Color.White;
            this.genClimber.BackColor = Color.Transparent;
            this.genClimber.Size = new System.Drawing.Size(43, 38);
            //genClimber.Location = new Point(0, 0);
            //Form3.ActiveForm.Controls.Add(this.genClimber);
        }

        public void generateNewClimbers (int posX, int posY)
        {
            this.genClimber.Location = new Point(posX, posY);
            Form3.ActiveForm.Controls.Add(this.genClimber);
            this.genClimber.Show();
        }
    }
}
