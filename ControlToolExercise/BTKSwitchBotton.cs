﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlToolExercise
{
    internal class BTKSwitchBotton : Control
    {
        public BTKSwitchBotton() { }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Green, new Rectangle(0, 0, Width-1, Height-1));
            e.Graphics.FillRectangle(Brushes.Gold, new Rectangle(0, 0, Width - 1, Height - 1));

            Pen p = new Pen(Color.Black, 4);
            e.Graphics.DrawRectangle(p, new Rectangle(30,30,60,60));

            SolidBrush b = new SolidBrush(Color.Tomato);
            e.Graphics.FillEllipse(b, new Rectangle(100, 30, 50, 50));

        }
    }
    
}