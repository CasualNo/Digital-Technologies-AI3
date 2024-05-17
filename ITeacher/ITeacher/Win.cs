using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITeacher
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLvl_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Size = this.Owner.Size;
            this.Owner.Owner.Location = this.Owner.Location;
            this.Owner.Owner.Show();
            this.Owner.Close();
            this.Close();
        }

        private void Win_Shown(object sender, EventArgs e)
        {
            lblCode.Text = "";
            int b = 1;
            List<string> allCode = Game.allCode;
            for (int i = 0; i < allCode.Count; i++)
            {
                string block = allCode[i];
                //these aren't the problem
                //they are now. Label has nothing on first load
                //bringing it back from the initialise to the shown event fixed it. Huh.
                if (block.Contains("Move"))
                {
                    lblCode.Text += b + ". Move;\n";
                    b++;
                }
                else if (block.Contains("Turn"))
                {
                    lblCode.Text += b + ". Turn " + allCode[i + 1] + ";\n";
                    b++;
                }
                else if (block.Contains("While"))
                {
                    lblCode.Text += b + ". While (" + allCode[i + 1];
                    if (allCode[i + 1] != "True")
                    {
                        lblCode.Text += " " + allCode[i + 2] + " " + allCode[i + 3];
                    }
                    lblCode.Text += ") {\n";
                    b++;
                }
                else if (block.Contains("EndLoop"))
                {
                    lblCode.Text += b + ". }\n";
                    b++;
                }
                else if (block.Contains("Define"))
                {
                    lblCode.Text += b + ". int " + allCode[i + 1] + " " + allCode[i + 2] + " " + allCode[i + 3] + ";\n";
                    b++;
                }
                else if (block.Contains("Set"))
                {
                    lblCode.Text += b + ". " + allCode[i + 1] + " " + allCode[i + 2] + " " + allCode[i + 3] + ";\n";
                }
            }
            lblCode.Text.Trim();
        }
    }
}
