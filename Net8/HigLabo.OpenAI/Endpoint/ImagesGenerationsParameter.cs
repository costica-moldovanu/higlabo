﻿using HigLabo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public partial class ImagesGenerationsParameter
    {
        public void SetResponseFormat(ImageResponseFormat format)
        {
            this.Response_Format = format.ToStringFromEnum().ToLower();
        }
        public void SetStyle(ImageGenerationStyle style)
        {
            this.Style = style.ToString().ToLower();
        }
    }
}
