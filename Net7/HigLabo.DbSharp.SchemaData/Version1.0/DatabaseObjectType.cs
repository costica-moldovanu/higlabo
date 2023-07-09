﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.DbSharp.MetaData
{
    public enum DatabaseObjectType
    {
        Unknown,
        Table,
        View,
        UserDefinedTableType,
        StoredProcedure,
        StoredFunction,
    }
}
