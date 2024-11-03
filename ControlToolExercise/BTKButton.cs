using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlToolExercise
{
    public class BTKButton : Button
    {
        public BTKButton()
        {
            BackColor = Color.ForestGreen;
            ForeColor = Color.Fuchsia;
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BackColor = Color.Yellow;
            ForeColor = Color.Black;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = Color.ForestGreen;
            ForeColor = Color.Fuchsia;

        }
    }
}
