﻿//Generated by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net7
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient.Server;
using HigLabo.DbSharp;

namespace HigLabo.DbSharp
{
    public partial class Nvarchar400Table : UserDefinedTableType<Nvarchar400Table.Record>
    {
        public partial class Record : UserDefinedTableTypeRecord
        {
            private String? _Value;

            public String? Value
            {
                get
                {
                    return _Value;
                }
                set
                {
                    _Value = value;
                }
            }

            public Record()
            {
            }

            public override Object?[] GetValues()
            {
                Object?[] oo = new Object[1];
                oo[0] = this.Value;
                return oo;
            }
        }

        public override SqlDataRecord CreateSqlDataRecord()
        {
            SqlMetaData[] metaData = new SqlMetaData[1];
            metaData[0] = new SqlMetaData("Value", SqlDbType.NVarChar, 400);
            return new SqlDataRecord(metaData);
        }
    }
}
