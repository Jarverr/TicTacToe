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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NickNameBox.Text.Length != 0)
            {
                if (ComboBoxCrossOrNought.Text == "Crosses" || ComboBoxCrossOrNought.Text == "Noughts")
                {
                    this.Hide();
                    TicTacToe window = new TicTacToe();
                    window.Closed += (s, args) => this.Close();
                    window.Nickname = NickNameBox.Text;
                    if (ComboBoxCrossOrNought.Text == "Crosses")
                    {
                        window.Cross = true;
                    }
                    else if (ComboBoxCrossOrNought.Text == "Noughts")
                        window.Cross = false;
                    window.ShowDialog();
                }
                else
                {
                    errorProvider1.SetError(ComboBoxCrossOrNought, "You have to choose one from two options.");
                }
            }
            else
            {
                errorProvider1.SetError(NickNameBox, "You have to state your nickname.");
            }
        }
    }
}
