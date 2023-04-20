using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Leaderboard
{
    internal class Squares
    {
        Random rnd = new Random();
        Color color;
        System.Timers.Timer TTL;
        public Squares(Game game) {
            CreateSquare(game);
            //TODO change colors
            //color = Colors.UpdateColor();
        }
        void CreateSquare(Game game) { 
            Panel p = new Panel();
            p.Size = GenerateSize();
            p.Location = GeneratePoint(game, p);
            p.BackColor = Color.Red;
            game.panel_gamePanel.Controls.Add(p);
            
        }
        Point GeneratePoint(Game game, Panel p) { 
            int x = rnd.Next(0, game.Width - p.Width);
            int y = rnd.Next(0, game.Height - p.Height);
            return new Point(x, y);
        }
        Size GenerateSize() {
            int width = rnd.Next(20, 50);
            int height = rnd.Next(20, 50);
            return new Size(width, height);
        }
    }
}
