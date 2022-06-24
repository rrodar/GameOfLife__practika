using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            rules = new Rules();
            startGame = new Form1();
        }
        Rules rules;
        Form1 startGame;

        private void BtContent_Click(object sender, EventArgs e)
        {
            rules.Size = new Size(810, 550);
            rules.Show();
            
            
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            startGame.Show();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
