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
    public partial class GuidGuidTable : UserDefinedTableType<GuidGuidTable.Record>
    {
        public partial class Record : UserDefinedTableTypeRecord
        {
            private Guid _Value0;
            private Guid _Value1;

            public Guid Value0
            {
                get
                {
                    return _Value0;
                }
                set
                {
                    _Value0 = value;
                }
            }
            public Guid Value1
            {
                get
                {
                    return _Value1;
                }
                set
                {
                    _Value1 = value;
                }
            }

            public Record()
            {
            }

            public override Object?[] GetValues()
            {
                Object?[] oo = new Object[2];
                oo[0] = this.Value0;
                oo[1] = this.Value1;
                return oo;
            }
        }

        public override SqlDataRecord CreateSqlDataRecord()
        {
            SqlMetaData[] metaData = new SqlMetaData[2];
            metaData[0] = new SqlMetaData("Value0", SqlDbType.UniqueIdentifier);
            metaData[1] = new SqlMetaData("Value1", SqlDbType.UniqueIdentifier);
            return new SqlDataRecord(metaData);
        }
    }
}
