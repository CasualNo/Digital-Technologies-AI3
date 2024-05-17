using ITeacher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace ITeacher
{
    public partial class Game : Form
    {
        PictureBox[] lines = new PictureBox[LvlSelect.lim];
        public static List<string> allCode = new List<string>();
        List<string> blocks = new List<string>();
        List<int> loops = new List<int>();
        List<int> values = new List<int>();
        List<string> vars = new List<string>();
        int size = 9;
        bool stop = false;
        int px = LvlSelect.ppos[0];
        int py = LvlSelect.ppos[1];
        int pr = LvlSelect.ppos[2];
        int cx = LvlSelect.ppos[3];
        int cy = LvlSelect.ppos[4];
        PictureBox[,] pos = new PictureBox[9, 9];

        string picFree = Directory.GetCurrentDirectory() + "/images/land.png";
        string picCap = Directory.GetCurrentDirectory() + "/images/goal.png";
        string whileend = Directory.GetCurrentDirectory() + "/Resources/End.png";
        String[] guy = {
            Directory.GetCurrentDirectory() + "/images/guyR.png",
            Directory.GetCurrentDirectory() + "/images/guy.png", 
            Directory.GetCurrentDirectory() + "/images/guyL.png", 
            Directory.GetCurrentDirectory() + "/images/guyB.png" 
        };


        public Game()
        {
            InitializeComponent();

            for (int i = 0; i < LvlSelect.lim; i++)
            {
                lines[i] = new PictureBox();
                lines[i].SizeMode = PictureBoxSizeMode.StretchImage;
                lines[i].Width = 110;
                lines[i].Height = 82;
                lines[i].AllowDrop = true;
                lines[i].DragEnter += new DragEventHandler(lines_DragEnter);
                lines[i].DragDrop += new DragEventHandler(lines_DragDrop);
            }
            FreshLines();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pos[i, j] = new PictureBox();
                    pos[i, j].Image = Image.FromFile(picFree);
                    pos[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    tblLvl.Controls.Add(pos[i, j]);
                }
            }

            pos[py, px].Image = Image.FromFile(guy[pr]);
            if ((cx < 9 && cx >= 0) && (cy < 9 && cy >= 0))
            {
                pos[cy, cx].Image = Image.FromFile(picCap);
            }
        }
        private void FreshLines ()
        {
            for (int i = 0; i < LvlSelect.lim; i++)
            {
                tblBlocks.Controls.Add(lines[i], 0, i);
            }
        }
        private void btnLvls_Click(object sender, EventArgs e)
        {
            this.Owner.Location = this.Location;
            this.Owner.Size = this.Size;
            this.Owner.Show();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.Owner = this;
            tut.StartPosition = FormStartPosition.Manual;
            tut.Location = this.Location;
            tut.Show();
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox codeBlock = sender as PictureBox;

            //Making a data object to send the image and tag together
            DataObject dragImage = new DataObject();
            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);
            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);

            DoDragDrop(dragImage, DragDropEffects.Copy);
        }
        //While loop is the sole reason I need this
        //And the sole reason its a comment
        //private void lineBlock_MouseDown (object sender, MouseEventArgs e)
        //{
        //    PictureBox lineBlock = sender as PictureBox;

        //    DataObject dragImage = new DataObject();
        //    dragImage.SetData(DataFormats.Bitmap, true, lineBlock.Image);
        //    dragImage.SetData(DataFormats.Text, true, lineBlock.Tag);
        //    lineBlock.Image = null;
        //    lineBlock.Tag = null;
        //    DoDragDrop(dragImage, DragDropEffects.Copy);
        //}
        private void lines_DragEnter (object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void lines_DragDrop (object sender, DragEventArgs e)
        {
            PictureBox line = sender as PictureBox;

            line.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            line.Tag = e.Data.GetData(TextDataFormat.Text.ToString());
            if (line.Tag.ToString() == "Turn")
            {
                MakeTurn(line);
            } else if (line.Tag.ToString() == "While")
            {
                MakeWhile(line);
            } else if (line.Tag.ToString() == "Define")
            {
                MakeInt(line);
            } else if (line.Tag.ToString() == "Set")
            {
                MakeSet(line);
            }
            blocks.Clear();
            for (int i = 0; i < LvlSelect.lim; i++)
            {
                blocks.Add(String.Format("{0}", lines[i].Tag));
            }
        }
        //adds a listbox that contains Left and Right as available controls, to 1 column left of the Turn block sending the function
        private void MakeTurn (PictureBox line)
        {
            ListBox lbxTurn = new ListBox();
            lbxTurn.Items.Add("Left");
            lbxTurn.Items.Add("Right");
            lbxTurn.Height = 82;
            lbxTurn.Width = 110;
            lbxTurn.SelectedIndex = 0;
            tblBlocks.Controls.Add(lbxTurn, 1, tblBlocks.GetRow(line));
        }
        //I need so many different things for this one by god
        private void MakeWhile (PictureBox line)
        {
            ListBox lbxVars = new ListBox();
            lbxVars.Items.Add("True");
            lbxVars.Items.AddRange(vars.ToArray());
            lbxVars.SelectedIndex = 0;
            lbxVars.Height = 82;
            lbxVars.Width = 110;
            lbxVars.Tag = "Vars";
            ListBox lbxComp = new ListBox();
            lbxComp.Items.Add("==");
            lbxComp.Items.Add("!=");
            lbxComp.Items.Add("<");
            lbxComp.Items.Add(">");
            lbxComp.SelectedIndex = 0;
            lbxComp.Height = 82;
            lbxComp.Width = 110;
            NumericUpDown nudInt = new NumericUpDown();
            nudInt.Maximum = 1000;
            nudInt.Minimum = -1000;
            nudInt.Accelerations.Add(new NumericUpDownAcceleration(2, 5));
            nudInt.Height = 82;
            nudInt.Width = 110;
            //gave up on being able to move different lines of code
            NumericUpDown nudLength = new NumericUpDown();
            nudLength.Maximum = LvlSelect.lim - tblBlocks.GetRow(line) - 1;
            nudLength.Minimum = 1;
            nudLength.Height = 82;
            nudLength.Width = 110;
            nudLength.ValueChanged += nudLength_ValueChanged;
            nudLength.Tag = 1;
            tblBlocks.Controls.Add(lbxVars, 1, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(lbxComp, 2, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(nudInt, 3, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(nudLength, 4, tblBlocks.GetRow(line));
            //adding EndLoop box
            lines[tblBlocks.GetRow(line) + 1].Image = Image.FromFile(whileend);
            lines[tblBlocks.GetRow(line) + 1].Tag = "EndLoop";
        }
        //adds a textbox for the name, a listbox just for =, and a NUD for the starting int
        private void MakeInt (PictureBox line)
        {
            TextBox tbxDef = new TextBox();
            tbxDef.Height = 82;
            tbxDef.Width = 110;
            tbxDef.TextChanged += tbxDef_TextChanged;
            vars.Add(tbxDef.Text);
            tbxDef.Tag = "";
            ListBox lbxDef = new ListBox();
            lbxDef.Height = 82;
            lbxDef.Width = 110;
            lbxDef.Items.Add("=");
            lbxDef.SelectedIndex = 0;
            NumericUpDown nudVar = new NumericUpDown();
            nudVar.Height = 82;
            nudVar.Width = 110;
            nudVar.Maximum = 1000;
            nudVar.Minimum = -1000;
            values.Add((int)nudVar.Value);
            nudVar.ValueChanged += NudVar_ValueChanged;
            tblBlocks.Controls.Add(tbxDef, 1, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(lbxDef, 2, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(nudVar, 3, tblBlocks.GetRow(line));
        }
        private void MakeSet (PictureBox line)
        {
            ListBox lbxVars = new ListBox();
            lbxVars.Items.AddRange(vars.ToArray());
            if (lbxVars.Items.Count != 0)
            {
                lbxVars.SelectedIndex = 0;
            }
            lbxVars.Height = 82;
            lbxVars.Width = 110;
            lbxVars.Tag = "Vars";
            //lbxVars.SelectedIndexChanged += lbxVars_SelectedIndexChanged;
            ListBox lbxChange = new ListBox();
            lbxChange.Items.Add("=");
            //This guy used to be "= " + the variable + " +", and it caused SO MUCH PAIN (see bottom)
            lbxChange.Items.Add("+=");
            lbxChange.SelectedIndex = 0;
            NumericUpDown nudInc = new NumericUpDown();
            nudInc.Height = 82;
            nudInc.Width = 110;
            nudInc.Minimum = -1000;
            nudInc.Maximum = 1000;
            tblBlocks.Controls.Add(lbxVars, 1, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(lbxChange, 2, tblBlocks.GetRow(line));
            tblBlocks.Controls.Add(nudInc, 3, tblBlocks.GetRow(line));
        }
        private async void btnStart_Click (object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            stop = false;
            pos[py, px].Image = Image.FromFile(picFree);
            //start checking variable at -1, so that first while loop adds its position to list and sets index to check to 0
            int check = -1;
            py = LvlSelect.ppos[1];
            px = LvlSelect.ppos[0];
            pr = LvlSelect.ppos[2];
            loops.Clear();
            for (int i = 0; i < LvlSelect.lim; i++)
            {
                if (lines[i].Tag != null && lines[i].Tag.ToString() == "Define")
                {
                    TextBox tbxDef = tblBlocks.GetControlFromPosition(1, i) as TextBox;
                    NumericUpDown nudVar = tblBlocks.GetControlFromPosition(3, i) as NumericUpDown;
                    values[vars.IndexOf(tbxDef.Text)] = (int)nudVar.Value;
                }
            }
            pos[py, px].Image = Image.FromFile(guy[pr]);
            if ((cx < 9 && cx >= 0) && (cy < 9 && cy >= 0))
            {
                pos[cy, cx].Image = Image.FromFile(picCap);
            }
            for (int r = 0; r < blocks.Count; r++)
            {
                if (blocks[r] != "" || blocks[r] != "While" || blocks[r] != "EndLoop")
                {
                    await Task.Delay(250);
                }
                if (stop == true)
                {
                    break;
                }
                if (blocks[r].Contains("Move"))
                {
                    Go();
                }
                else if (blocks[r].Contains("Turn"))
                {
                    Turn(r);
                } else if (blocks[r].Contains("While"))
                {
                    //add the row of the while block, and increment the index being referred to
                    loops.Add(r);
                    check++;
                }
                else if (blocks[r].Contains("EndLoop"))
                {
                    //endloop function, had to split calling it and decrementing r for some weird reason
                    r = EndLoop(check, r);
                    r--;
                    //removes the latest row to check and decrements the referred index
                    loops.RemoveAt(check);
                    check--;
                } else if (blocks[r].Contains("Set"))
                {
                    Set(r);
                }
                if ((cx < 9 && cx >= 0) && (cy < 9 && cy >= 0) && pos[py, px] == pos[cy, cx])
                {
                    Win win = new Win();
                    win.Owner = this;
                    win.StartPosition = FormStartPosition.Manual;
                    win.Location = this.Location;
                    allCode.Clear();
                    //for writing out winning code interpretation, something is breaking though
                    //it has to be a foreach loop somewhere
                    //Above were when it was a tblBlocks.Controls foreach loop, this area is fine now
                    foreach (PictureBox block in lines)
                    {
                        if (block.Tag != null)
                        {
                            allCode.Add(block.Tag.ToString());
                            if (block.Tag.ToString() == "Turn")
                            {
                                ListBox lbox = tblBlocks.GetControlFromPosition(1, tblBlocks.GetRow(block)) as ListBox;
                                allCode.Add(lbox.SelectedItem.ToString());
                            }
                            else if (block.Tag.ToString() == "While")
                            {
                                ListBox lbxVar = tblBlocks.GetControlFromPosition(1, tblBlocks.GetRow(block)) as ListBox;
                                ListBox lbxComp = tblBlocks.GetControlFromPosition(2, tblBlocks.GetRow(block)) as ListBox;
                                NumericUpDown nudInt = tblBlocks.GetControlFromPosition(3, tblBlocks.GetRow(block)) as NumericUpDown;
                                allCode.Add(lbxVar.SelectedItem.ToString());
                                allCode.Add(lbxComp.SelectedItem.ToString());
                                allCode.Add(nudInt.Value.ToString());
                            }
                            else if (block.Tag.ToString() == "Define")
                            {
                                TextBox tbxDef = tblBlocks.GetControlFromPosition(1, tblBlocks.GetRow(block)) as TextBox;
                                ListBox lbxDef = tblBlocks.GetControlFromPosition(2, tblBlocks.GetRow(block)) as ListBox;
                                NumericUpDown nudVar = tblBlocks.GetControlFromPosition(3, tblBlocks.GetRow(block)) as NumericUpDown;
                                allCode.Add(tbxDef.Text.ToString());
                                allCode.Add(lbxDef.SelectedItem.ToString());
                                allCode.Add(nudVar.Value.ToString());
                            }
                            else if (block.Tag.ToString() == "Set")
                            {
                                ListBox lbxVars = tblBlocks.GetControlFromPosition(1, tblBlocks.GetRow(block)) as ListBox;
                                ListBox lbxChange = tblBlocks.GetControlFromPosition(2, tblBlocks.GetRow(block)) as ListBox;
                                NumericUpDown nudInc = tblBlocks.GetControlFromPosition(3, tblBlocks.GetRow(block)) as NumericUpDown;
                                allCode.Add(lbxVars.SelectedItem.ToString()) ;
                                allCode.Add(lbxChange.SelectedItem.ToString());
                                allCode.Add(nudInc.Value.ToString());
                            }
                        }
                    }
                    win.Show();
                    break;
                }
            }
            btnStart.Enabled = true;
        }

        private void Go ()
        {
            // 0 to px++, 1 to py++, 2 to px--, 3 to py--
            // if pr - 2 < 0 (right/down), set an int to 1 and another int to size -1
            // if pr -2 > 0 (up/left), set the int to -1 and the other int to 0
            // give up on mathematically checking for left/right and up/down
            // if (px or py, depends) * first int < second int, move is valid; multiply by first int, because otherwise up/left scenarios would check if px/py was < 0
            int change;
            int bounds;
            if (pr < 2)
            {
                change = 1;
                bounds = size - 1;
            } else
            {
                change = -1;
                bounds = 0;
            }
            if ((pr == 0 || pr == 2) && px * change < bounds)
            {
                pos[py, px].Image = Image.FromFile(picFree);
                px += change;
            } else if ((pr == 1 || pr == 3) && py * change < bounds)
            {
                pos[py, px].Image = Image.FromFile(picFree);
                py += change;
            }
            pos[py, px].Image = Image.FromFile(guy[pr]);
        }
        //maybe improve later? (if i can think of something)
        private void Turn (int row)
        {
            ListBox select = tblBlocks.GetControlFromPosition(1, row) as ListBox;
            if (select.SelectedIndex == 0)
            {
                if (pr != 0)
                {
                    pr--;
                } else
                {
                    pr = 3;
                }
            } else
            {
                if (pr != 3)
                {
                    pr++;
                } else
                {
                    pr = 0;
                }
            }
            pos[py, px].Image = Image.FromFile(guy[pr]);
        }
        private int EndLoop (int check, int cldrow)
        {
            //sucks, but literally nothing else worked
            //Takes a while to do
            //defines return variable
            int ret;
            ListBox lbxVars = tblBlocks.GetControlFromPosition(1, loops[check]) as ListBox;
            //If set to true, always return referred row
            if (lbxVars.SelectedIndex == 0)
            {
                ret = loops[check];
            } else
            {
                ListBox lbxComp = tblBlocks.GetControlFromPosition(2, loops[check]) as ListBox;
                NumericUpDown nudInt = tblBlocks.GetControlFromPosition(3, loops[check]) as NumericUpDown;
                //wish I could think of a better way that isn't weirdly blocked
                if (lbxComp.SelectedIndex == 0 && values[lbxVars.SelectedIndex - 1] == nudInt.Value)
                {
                    ret = loops[check];
                } else if ((lbxComp.SelectedIndex == 1 || lbxComp.SelectedIndex == 3) && values[lbxVars.SelectedIndex - 1] - nudInt.Value > 0)
                {
                    ret = loops[check];
                } else if ((lbxComp.SelectedIndex == 1 || lbxComp.SelectedIndex == 2) && values[lbxVars.SelectedIndex - 1] - nudInt.Value < 0)
                {
                    ret = loops[check];
                } else
                {
                    ret = cldrow + 1;
                }
            }
            return ret;
        }
        private void Set (int line)
        {
            ListBox lbxVar = tblBlocks.GetControlFromPosition(1, line) as ListBox;
            ListBox lbxChange = tblBlocks.GetControlFromPosition(2, line) as ListBox;
            NumericUpDown nudInc = tblBlocks.GetControlFromPosition(3, line) as NumericUpDown;
            if (lbxChange.SelectedIndex == 0)
            {
                values[lbxVar.SelectedIndex] = (int)nudInc.Value;
            } else
            {
                values[lbxVar.SelectedIndex] += (int)nudInc.Value;
            }

        }
        //Changing While loop length
        private void nudLength_ValueChanged (object sender, EventArgs e)
        {
            NumericUpDown nudLength = sender as NumericUpDown;
            //Can't just cast the tag as an int, so i need to convert to a string to an int
            lines[tblBlocks.GetRow(nudLength) + Int32.Parse(nudLength.Tag.ToString())].Image = null;
            lines[tblBlocks.GetRow(nudLength) + Int32.Parse(nudLength.Tag.ToString())].Tag = null;
            lines[(int)(tblBlocks.GetRow(nudLength) + nudLength.Value)].Image = Image.FromFile(whileend);
            lines[(int)(tblBlocks.GetRow(nudLength) + nudLength.Value)].Tag = "EndLoop";
            //storing previous row position to delete old EndLoop
            nudLength.Tag = nudLength.Value;
        }
        private void tbxDef_TextChanged (object sender, EventArgs e)
        {
            TextBox tbxDef = sender as TextBox;
            int place = vars.IndexOf(tbxDef.Tag.ToString());
            tbxDef.Text.Replace(" ", "");
            vars[place] = tbxDef.Text;
            tbxDef.Tag = tbxDef.Text;
            for (int i = 0; i < LvlSelect.lim; i++)
            {
                if (tblBlocks.GetControlFromPosition(1, i) != null && tblBlocks.GetControlFromPosition(1, i).Tag != null && tblBlocks.GetControlFromPosition(1, i).Tag.ToString() == "Vars")
                {
                    ListBox VarChoice = tblBlocks.GetControlFromPosition(1, i) as ListBox;
                    int select = VarChoice.SelectedIndex;
                    VarChoice.Items.Clear();
                    if (tblBlocks.GetControlFromPosition(0, i).Tag == "While")
                    {
                        VarChoice.Items.Add("True");
                    }
                    VarChoice.Items.AddRange(vars.ToArray());
                    VarChoice.SelectedIndex = select;
                }
            }
        }
        private void NudVar_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudVar = sender as NumericUpDown;
            TextBox tbxDef = tblBlocks.GetControlFromPosition(1, tblBlocks.GetRow(nudVar)) as TextBox;
            values[vars.IndexOf(tbxDef.Text)] = (int)nudVar.Value;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tblBlocks.Controls.Clear();
            foreach (PictureBox line in lines)
            {
                line.Tag = null;
                line.Image = null;
            }
            blocks.Clear();
            FreshLines();
        }
        //the solution to not being able to use GetRow, Tags, and not wanting ANOTHER GODDAMN LIST: making it += instead. Life is pain, I hate
        //private void lbxVars_SelectedIndexChanged (object sender, EventArgs e)
        //{
        //    ListBox lbxVars = sender as ListBox;
        //    int line = tblBlocks.GetRow(lbxVars);
        //    ListBox lbxChange = tblBlocks.GetControlFromPosition(2, line) as ListBox;
        //    lbxChange.Items[1] = "= " + lbxVars.Text + " +";
        //}
    }
}