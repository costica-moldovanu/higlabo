﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public class ToolChoice
    {
        public string Type { get; set; } = "";
        public object? Function { get; set; }
    }
}
