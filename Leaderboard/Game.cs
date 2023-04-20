using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaderboard
{
    public partial class Game : Form
    {
        int lives = 3;
        public Game()
        {
            InitializeComponent();
            GenerateLives();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new Squares(this);
        }
        void GenerateLives()
        {
            for (int i = 0; i < lives; i++)
            {
                PictureBox p = new PictureBox();
                p.Load("./images/favicon-16x16.png");
                //TODO moves lives to not being spawned on themselfs
                this.panel_livesFav.Controls.Add(p);
            }
        }
    }
}