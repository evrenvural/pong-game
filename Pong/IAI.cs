﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    interface IAI
    {
        void Think(int coordinateY, int coordinateX);
    }
}
