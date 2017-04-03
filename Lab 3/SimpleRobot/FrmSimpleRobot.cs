using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ernesto Murillo C# Direct a simple robot

namespace SimpleRobot
{
    public partial class FrmSimpleRobot : Form
    {

        private Robot MrRobot = new Robot();   // called in the class called it MrRobot

        public FrmSimpleRobot()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSimpleRobot_Load(object sender, EventArgs e)
        {

            MrRobot.WallCrash += new Robot.Collision(IfItCrashes);  // added for event handler 

            // send whatever is currently as lblArrow.Text to ToString() method inside class and run method
            lblArrow.Text = MrRobot.ToString();    //------  brings it back.. was facing whatever   now facing what you pressed    on load  facing east  now facing north 
            MrRobot.Draw(pnlBox);      // call method Draw(pnlBox) from class and put lblArrow.Text in 100,100 on load  or  when we move the arrow  put it in its new coordinates
            lblPosition.Text = MrRobot.location.ToString();   // grab the location of default constructor 0,0 
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            MrRobot.Move(1);
            MrRobot.Draw(pnlBox);
            lblPosition.Text = MrRobot.location.ToString();
        }

        private void btnGo10_Click(object sender, EventArgs e)
        {
            MrRobot.Move(10);   // send 10 to .move function
            MrRobot.Draw(pnlBox);  // .draw function to move arrow to new coordinates
            lblPosition.Text = MrRobot.location.ToString();   // change lbl to new coordinates moved
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MrRobot.direction = Direction.West;    // change it to West
            lblArrow.Text = MrRobot.ToString();   //grab altcode char from enum and put it into lblArrow
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MrRobot.direction = Direction.South;
            lblArrow.Text = MrRobot.ToString();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MrRobot.direction = Direction.East;
            lblArrow.Text = MrRobot.ToString();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MrRobot.direction = Direction.North;
            lblArrow.Text = MrRobot.ToString();   //bring it back as lblArrow.Text
        }

        //function for event handler
        public void IfItCrashes()
        {
            lblPosition.Text = MrRobot.location.ToString();
            MessageBox.Show("Crash.  Gone too far!", "Boom");
        }

    }
}
