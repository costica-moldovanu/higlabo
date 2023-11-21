﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public interface IJsonConverter
    {
        string SerializeObject(object obj);
        T DeserializeObject<T>(String json);
    }
}
