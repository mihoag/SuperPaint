﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PaintWindow
{
    class FillColor
    {
        public string Name
        {
            get; set;
        }
        public Brush Value
        {
            get; set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
