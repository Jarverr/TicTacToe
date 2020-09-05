using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public string Nickname { get; set; }
        public bool Cross;
        List<string> ClickedValues;
        public TicTacToe()
        {
            InitializeComponent();
            ClickedValues = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 OpeningWindow = new Form1();
            OpeningWindow.ShowDialog();
            OpeningWindow.Closed += (s, args) => this.Close();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            NickNameLabel.Text = Nickname;
            MovmentOfEnemy();
        }


        private void Mesh_Clicked(object sender, EventArgs e)
        {
            Control clicked = (Control)sender;
            if (clicked.Text == "")
            {
                if (Cross)
                    clicked.Text = " X ";
                else
                    clicked.Text = " O ";
                ClickedValues.Add(clicked.Name[4].ToString());
                if (!CheckWinner())
                {
                    MovmentOfEnemy();
                    if(!CheckWinner())
                    {
                        if (ClickedValues.Count == 9)
                            MessageBox.Show("PAT", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Error1.Visible = true;
                var t = new Timer();
                t.Interval = 1500;
                t.Tick += (s, w) =>
                {
                    Error1.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
            
        }
        Random rnd = new Random();
        string number;
        bool findEmptyField;
        string toCompare;
        void MovmentOfEnemy()
        {
            if ((ClickedValues.Count != 9 && Cross && ClickedValues.Count != 0) || (!Cross))
            {
                toCompare = "";
                findEmptyField = true;
                foreach (var item in ClickedValues)
                {
                    toCompare += item;

                }
                while (findEmptyField)
                {
                    number = rnd.Next(1, 10).ToString();

                    if (!toCompare.Contains(number))
                    {
                        findEmptyField = false;
                        ClickedValues.Add(number);
                        if (Mesh1.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh1.Text = " O ";
                            else
                                Mesh1.Text = " X ";
                        }
                        if (Mesh2.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh2.Text = " O ";
                            else
                                Mesh2.Text = " X ";
                        }
                        if (Mesh3.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh3.Text = " O ";
                            else
                                Mesh3.Text = " X ";
                        }
                        if (Mesh4.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh4.Text = " O ";
                            else
                                Mesh4.Text = " X ";
                        }
                        if (Mesh5.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh5.Text = " O ";
                            else
                                Mesh5.Text = " X ";
                        }
                        if (Mesh6.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh6.Text = " O ";
                            else
                                Mesh6.Text = " X ";
                        }
                        if (Mesh7.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh7.Text = " O ";
                            else
                                Mesh7.Text = " X ";
                        }
                        if (Mesh8.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh8.Text = " O ";
                            else
                                Mesh8.Text = " X ";
                        }
                        if (Mesh9.Name[4].ToString() == number)
                        {
                            if (Cross)
                                Mesh9.Text = " O ";
                            else
                                Mesh9.Text = " X ";
                        }

                    }

                }
            }
        }

        bool CheckWinner()
        {
            if ((Mesh1.Text == " X " && Mesh4.Text == " X " && Mesh7.Text == " X ") || (Mesh1.Text == " O " && Mesh4.Text == " O " && Mesh7.Text == " O "))
            {
                if (Mesh1.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }

            }
            else if ((Mesh2.Text == " X " && Mesh5.Text == " X " && Mesh8.Text == " X ") || (Mesh2.Text == " O " && Mesh5.Text == " O " && Mesh8.Text == " O "))
            {
                if (Mesh2.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    RemoveEvents();
                    return true;
                }
            }
            else if ((Mesh3.Text == " X " && Mesh6.Text == " X " && Mesh9.Text == " X ") || (Mesh3.Text == " O " && Mesh6.Text == " O " && Mesh9.Text == " O "))
            {
                if (Mesh3.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }

            }
            else if ((Mesh1.Text == " X " && Mesh2.Text == " X " && Mesh3.Text == " X ") || (Mesh1.Text == " O " && Mesh2.Text == " O " && Mesh3.Text == " O "))
            {
                if (Mesh1.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
            }
            else if ((Mesh4.Text == " X " && Mesh5.Text == " X " && Mesh6.Text == " X ") || (Mesh4.Text == " O " && Mesh5.Text == " O " && Mesh6.Text == " O "))
            {
                if (Mesh4.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
            }
            else if ((Mesh7.Text == " X " && Mesh8.Text == " X " && Mesh9.Text == " X ") || (Mesh7.Text == " O " && Mesh8.Text == " O " && Mesh9.Text == " O "))
            {
                if (Mesh7.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
            }
            else if ((Mesh1.Text == " X " && Mesh5.Text == " X " && Mesh9.Text == " X ") || (Mesh1.Text == " O " && Mesh5.Text == " O " && Mesh9.Text == " O "))
            {
                if (Mesh1.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
            }
            else if ((Mesh3.Text == " X " && Mesh5.Text == " X " && Mesh7.Text == " X ") || (Mesh3.Text == " O " && Mesh5.Text == " O " && Mesh7.Text == " O "))
            {
                if (Mesh3.Text == " X ")
                {
                    MessageBox.Show("CROSSES HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
                else
                {
                    MessageBox.Show("NOUGHTS HAS WON", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEvents();
                    return true;
                }
            }
            return false;
            void RemoveEvents() 
            {
                Mesh1.Click -= Mesh_Clicked;
                Mesh2.Click -= Mesh_Clicked;
                Mesh3.Click -= Mesh_Clicked;
                Mesh4.Click -= Mesh_Clicked;
                Mesh5.Click -= Mesh_Clicked;
                Mesh6.Click -= Mesh_Clicked;
                Mesh7.Click -= Mesh_Clicked;
                Mesh8.Click -= Mesh_Clicked;
                Mesh9.Click -= Mesh_Clicked;
            }
        }
    }
}
