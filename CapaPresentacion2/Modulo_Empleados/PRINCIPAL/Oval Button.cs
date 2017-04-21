﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoP
{
    public class Oval_Button : Button
    {

        public Oval_Button()
        {
            this.BackColor = Color.DarkGray;
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
                {
                    gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                    this.Region = new Region(gp);
                }
        }
    }
}
