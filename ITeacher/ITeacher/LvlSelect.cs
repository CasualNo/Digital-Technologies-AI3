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
    public partial class LvlSelect : Form
    {
        public static int lim;
        public static int[] ppos = new int[5];
        public LvlSelect()
        {
            InitializeComponent();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            this.Owner.Location = this.Location;
            this.Owner.Size = this.Size;
            this.Owner.Show();
            this.Close();
        }

        private void btnOpts_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.Owner = this;
            opt.StartPosition = FormStartPosition.Manual;
            opt.Location = this.Location;
            opt.Size = this.Size;
            opt.Show();
            this.Hide();
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            lim = 3;
            ppos[0] = 3;
            ppos[1] = 4;
            ppos[2] = 0;
            ppos[3] = 6;
            ppos[4] = 4;
            Game game = new Game();
            game.Owner = this;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = this.Location;
            game.Size = this.Size;
            game.Show();
            this.Hide();
        }

        private void btn1_s_Click(object sender, EventArgs e)
        {
            lim = 100;
            ppos[0] = 4;
            ppos[1] = 4;
            ppos[2] = 1;
            ppos[3] = 9;
            ppos[4] = 9;
            Game game = new Game();
            game.Owner = this;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = this.Location;
            game.Size = this.Size;
            game.Show();
            this.Hide();
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            lim = 11;
            ppos[0] = 3;
            ppos[1] = 5;
            ppos[2] = 0;
            ppos[3] = 5;
            ppos[4] = 3;
            Game game = new Game();
            game.Owner = this;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = this.Location;
            game.Size = this.Size;
            game.Show();
            this.Hide();
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            lim = 3;
            ppos[0] = 0;
            ppos[1] = 4;
            ppos[2] = 0;
            ppos[3] = 8;
            ppos[4] = 4;
            Game game = new Game();
            game.Owner = this;
            game.StartPosition = FormStartPosition.Manual;
            game.Location = this.Location;
            game.Size = this.Size;
            game.Show();
            this.Hide();
        }
    }
}
