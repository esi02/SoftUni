﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        string Start();
        string Stop();

    }
}
