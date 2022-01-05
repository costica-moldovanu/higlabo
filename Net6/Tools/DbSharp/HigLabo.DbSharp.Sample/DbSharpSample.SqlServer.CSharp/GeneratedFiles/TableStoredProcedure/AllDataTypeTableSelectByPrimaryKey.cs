﻿//Generated at 2022/01/05 08:55:34 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class AllDataTypeTableSelectByPrimaryKey : StoredProcedureWithResultSet<AllDataTypeTableSelectByPrimaryKey.ResultSet>
    {
        public const String Name = "AllDataTypeTableSelectByPrimaryKey";
        private Int64 _PK_PrimaryKeyColumn;

        public String DatabaseKey
        {
            get
            {
                return ((IDatabaseContext)this).DatabaseKey;
            }
            set
            {
                ((IDatabaseContext)this).DatabaseKey = value;
            }
        }
        public Int64 PK_PrimaryKeyColumn
        {
            get
            {
                return _PK_PrimaryKeyColumn;
            }
            set
            {
                _PK_PrimaryKeyColumn = value;
            }
        }

        public AllDataTypeTableSelectByPrimaryKey()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_SqlServer";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return AllDataTypeTableSelectByPrimaryKey.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@PK_PrimaryKeyColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_PrimaryKeyColumn;
            p.Value = p.Value ?? DBNull.Value;
            cm.Parameters.Add(p);
            
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override AllDataTypeTableSelectByPrimaryKey.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        protected override void SetResultSet(AllDataTypeTableSelectByPrimaryKey.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.PrimaryKeyColumn = reader.GetInt64(index);
                index += 1; r.TimestampColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.BigIntColumn = reader.GetInt64(index);
                index += 1; if (reader[index] != DBNull.Value) r.BinaryColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.ImageColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.VarBinaryColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.BitColumn = reader.GetBoolean(index);
                index += 1; if (reader[index] != DBNull.Value) r.CharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.NCharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.NTextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.NVarCharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.TextColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.VarCharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.XmlColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.DateTimeColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.SmallDateTimeColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.DateColumn = DateOnly.FromDateTime((DateTime)reader[index]);
                index += 1; if (reader[index] != DBNull.Value) r.TimeColumn = TimeOnly.FromTimeSpan((TimeSpan)reader[index]);
                index += 1; if (reader[index] != DBNull.Value) r.DateTime2Column = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.DecimalColumn = reader.GetDecimal(index);
                index += 1; if (reader[index] != DBNull.Value) r.MoneyColumn = reader.GetDecimal(index);
                index += 1; if (reader[index] != DBNull.Value) r.SmallMoneyColumn = reader.GetDecimal(index);
                index += 1; if (reader[index] != DBNull.Value) r.FloatColumn = reader.GetDouble(index);
                index += 1; if (reader[index] != DBNull.Value) r.IntColumn = reader.GetInt32(index);
                index += 1; if (reader[index] != DBNull.Value) r.RealColumn = reader.GetFloat(index);
                index += 1; if (reader[index] != DBNull.Value) r.UniqueIdentifierColumn = reader.GetGuid(index);
                index += 1; if (reader[index] != DBNull.Value) r.SmallIntColumn = reader.GetInt16(index);
                index += 1; if (reader[index] != DBNull.Value) r.TinyIntColumn = reader.GetByte(index);
                index += 1; if (reader[index] != DBNull.Value) r.DateTimeOffsetColumn = (DateTimeOffset)reader[index];
                index += 1; if (reader[index] != DBNull.Value) r.SqlVariantColumn = reader[index] as Object;
                index += 1; if (reader[index] != DBNull.Value) r.EnumColumn = StoredProcedure.ToEnum<MyEnum>(reader[index] as String) ?? r.EnumColumn;
                index += 1; r.NotNullBigIntColumn = reader.GetInt64(index);
                index += 1; r.NotNullBinaryColumn = reader[index] as Byte[];
                index += 1; r.NotNullImageColumn = reader[index] as Byte[];
                index += 1; r.NotNullVarBinaryColumn = reader[index] as Byte[];
                index += 1; r.NotNullBitColumn = reader.GetBoolean(index);
                index += 1; r.NotNullCharColumn = reader[index] as String;
                index += 1; r.NotNullNCharColumn = reader[index] as String;
                index += 1; r.NotNullNTextColumn = reader[index] as String;
                index += 1; r.NotNullNVarCharColumn = reader[index] as String;
                index += 1; r.NotNullTextColumn = reader[index] as String;
                index += 1; r.NotNullVarCharColumn = reader[index] as String;
                index += 1; r.NotNullXmlColumn = reader[index] as String;
                index += 1; r.NotNullDateTimeColumn = reader.GetDateTime(index);
                index += 1; r.NotNullSmallDateTimeColumn = reader.GetDateTime(index);
                index += 1; r.NotNullDateColumn = DateOnly.FromDateTime((DateTime)reader[index]);
                index += 1; r.NotNullTimeColumn = TimeOnly.FromTimeSpan((TimeSpan)reader[index]);
                index += 1; r.NotNullDateTime2Column = reader.GetDateTime(index);
                index += 1; r.NotNullDecimalColumn = reader.GetDecimal(index);
                index += 1; r.NotNullMoneyColumn = reader.GetDecimal(index);
                index += 1; r.NotNullSmallMoneyColumn = reader.GetDecimal(index);
                index += 1; r.NotNullFloatColumn = reader.GetDouble(index);
                index += 1; r.NotNullIntColumn = reader.GetInt32(index);
                index += 1; r.NotNullRealColumn = reader.GetFloat(index);
                index += 1; r.NotNullUniqueIdentifierColumn = reader.GetGuid(index);
                index += 1; r.NotNullSmallIntColumn = reader.GetInt16(index);
                index += 1; r.NotNullTinyIntColumn = reader.GetByte(index);
                index += 1; r.NotNullDateTimeOffsetColumn = (DateTimeOffset)reader[index];
                index += 1; r.NotNullSqlVariantColumn = reader[index] as Object;
                index += 1; r.NotNullEnumColumn = StoredProcedure.ToEnum<MyEnum>(reader[index] as String) ?? r.NotNullEnumColumn;
            }
            catch (Exception ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<AllDataTypeTableSelectByPrimaryKey>");
            sb.AppendFormat("PK_PrimaryKeyColumn={0}", this.PK_PrimaryKeyColumn); sb.AppendLine();
            return sb.ToString();
        }

        public partial class ResultSet : StoredProcedureResultSet, AllDataTypeTable.IRecord
        {
            private Int64 _PrimaryKeyColumn;
            private Byte[] _TimestampColumn;
            private Int64? _BigIntColumn;
            private Byte[] _BinaryColumn;
            private Byte[] _ImageColumn;
            private Byte[] _VarBinaryColumn;
            private Boolean? _BitColumn;
            private String _CharColumn = null;
            private String _NCharColumn = null;
            private String _NTextColumn = null;
            private String _NVarCharColumn = null;
            private String _TextColumn = null;
            private String _VarCharColumn = null;
            private String _XmlColumn = null;
            private DateTime? _DateTimeColumn;
            private DateTime? _SmallDateTimeColumn;
            private DateOnly? _DateColumn;
            private TimeOnly? _TimeColumn;
            private DateTime? _DateTime2Column;
            private Decimal? _DecimalColumn;
            private Decimal? _MoneyColumn;
            private Decimal? _SmallMoneyColumn;
            private Double? _FloatColumn;
            private Int32? _IntColumn;
            private Single? _RealColumn;
            private Guid? _UniqueIdentifierColumn;
            private Int16? _SmallIntColumn;
            private Byte? _TinyIntColumn;
            private DateTimeOffset? _DateTimeOffsetColumn;
            private Object _SqlVariantColumn;
            private MyEnum? _EnumColumn;
            private Int64 _NotNullBigIntColumn;
            private Byte[] _NotNullBinaryColumn;
            private Byte[] _NotNullImageColumn;
            private Byte[] _NotNullVarBinaryColumn;
            private Boolean _NotNullBitColumn;
            private String _NotNullCharColumn = "";
            private String _NotNullNCharColumn = "";
            private String _NotNullNTextColumn = "";
            private String _NotNullNVarCharColumn = "";
            private String _NotNullTextColumn = "";
            private String _NotNullVarCharColumn = "";
            private String _NotNullXmlColumn = "";
            private DateTime _NotNullDateTimeColumn;
            private DateTime _NotNullSmallDateTimeColumn;
            private DateOnly _NotNullDateColumn;
            private TimeOnly _NotNullTimeColumn;
            private DateTime _NotNullDateTime2Column;
            private Decimal _NotNullDecimalColumn;
            private Decimal _NotNullMoneyColumn;
            private Decimal _NotNullSmallMoneyColumn;
            private Double _NotNullFloatColumn;
            private Int32 _NotNullIntColumn;
            private Single _NotNullRealColumn;
            private Guid _NotNullUniqueIdentifierColumn;
            private Int16 _NotNullSmallIntColumn;
            private Byte _NotNullTinyIntColumn;
            private DateTimeOffset _NotNullDateTimeOffsetColumn;
            private Object _NotNullSqlVariantColumn;
            private MyEnum _NotNullEnumColumn;

            public Int64 PrimaryKeyColumn
            {
                get
                {
                    return _PrimaryKeyColumn;
                }
                set
                {
                    _PrimaryKeyColumn = value;
                }
            }
            public Byte[] TimestampColumn
            {
                get
                {
                    return _TimestampColumn;
                }
                set
                {
                    _TimestampColumn = value;
                }
            }
            public Int64? BigIntColumn
            {
                get
                {
                    return _BigIntColumn;
                }
                set
                {
                    _BigIntColumn = value;
                }
            }
            public Byte[] BinaryColumn
            {
                get
                {
                    return _BinaryColumn;
                }
                set
                {
                    _BinaryColumn = value;
                }
            }
            public Byte[] ImageColumn
            {
                get
                {
                    return _ImageColumn;
                }
                set
                {
                    _ImageColumn = value;
                }
            }
            public Byte[] VarBinaryColumn
            {
                get
                {
                    return _VarBinaryColumn;
                }
                set
                {
                    _VarBinaryColumn = value;
                }
            }
            public Boolean? BitColumn
            {
                get
                {
                    return _BitColumn;
                }
                set
                {
                    _BitColumn = value;
                }
            }
            public String CharColumn
            {
                get
                {
                    return _CharColumn;
                }
                set
                {
                    _CharColumn = value;
                }
            }
            public String NCharColumn
            {
                get
                {
                    return _NCharColumn;
                }
                set
                {
                    _NCharColumn = value;
                }
            }
            public String NTextColumn
            {
                get
                {
                    return _NTextColumn;
                }
                set
                {
                    _NTextColumn = value;
                }
            }
            public String NVarCharColumn
            {
                get
                {
                    return _NVarCharColumn;
                }
                set
                {
                    _NVarCharColumn = value;
                }
            }
            public String TextColumn
            {
                get
                {
                    return _TextColumn;
                }
                set
                {
                    _TextColumn = value;
                }
            }
            public String VarCharColumn
            {
                get
                {
                    return _VarCharColumn;
                }
                set
                {
                    _VarCharColumn = value;
                }
            }
            public String XmlColumn
            {
                get
                {
                    return _XmlColumn;
                }
                set
                {
                    _XmlColumn = value;
                }
            }
            public DateTime? DateTimeColumn
            {
                get
                {
                    return _DateTimeColumn;
                }
                set
                {
                    _DateTimeColumn = value;
                }
            }
            public DateTime? SmallDateTimeColumn
            {
                get
                {
                    return _SmallDateTimeColumn;
                }
                set
                {
                    _SmallDateTimeColumn = value;
                }
            }
            public DateOnly? DateColumn
            {
                get
                {
                    return _DateColumn;
                }
                set
                {
                    _DateColumn = value;
                }
            }
            public TimeOnly? TimeColumn
            {
                get
                {
                    return _TimeColumn;
                }
                set
                {
                    _TimeColumn = value;
                }
            }
            public DateTime? DateTime2Column
            {
                get
                {
                    return _DateTime2Column;
                }
                set
                {
                    _DateTime2Column = value;
                }
            }
            public Decimal? DecimalColumn
            {
                get
                {
                    return _DecimalColumn;
                }
                set
                {
                    _DecimalColumn = value;
                }
            }
            public Decimal? MoneyColumn
            {
                get
                {
                    return _MoneyColumn;
                }
                set
                {
                    _MoneyColumn = value;
                }
            }
            public Decimal? SmallMoneyColumn
            {
                get
                {
                    return _SmallMoneyColumn;
                }
                set
                {
                    _SmallMoneyColumn = value;
                }
            }
            public Double? FloatColumn
            {
                get
                {
                    return _FloatColumn;
                }
                set
                {
                    _FloatColumn = value;
                }
            }
            public Int32? IntColumn
            {
                get
                {
                    return _IntColumn;
                }
                set
                {
                    _IntColumn = value;
                }
            }
            public Single? RealColumn
            {
                get
                {
                    return _RealColumn;
                }
                set
                {
                    _RealColumn = value;
                }
            }
            public Guid? UniqueIdentifierColumn
            {
                get
                {
                    return _UniqueIdentifierColumn;
                }
                set
                {
                    _UniqueIdentifierColumn = value;
                }
            }
            public Int16? SmallIntColumn
            {
                get
                {
                    return _SmallIntColumn;
                }
                set
                {
                    _SmallIntColumn = value;
                }
            }
            public Byte? TinyIntColumn
            {
                get
                {
                    return _TinyIntColumn;
                }
                set
                {
                    _TinyIntColumn = value;
                }
            }
            public DateTimeOffset? DateTimeOffsetColumn
            {
                get
                {
                    return _DateTimeOffsetColumn;
                }
                set
                {
                    _DateTimeOffsetColumn = value;
                }
            }
            public Object SqlVariantColumn
            {
                get
                {
                    return _SqlVariantColumn;
                }
                set
                {
                    _SqlVariantColumn = value;
                }
            }
            public MyEnum? EnumColumn
            {
                get
                {
                    return _EnumColumn;
                }
                set
                {
                    _EnumColumn = value;
                }
            }
            public Int64 NotNullBigIntColumn
            {
                get
                {
                    return _NotNullBigIntColumn;
                }
                set
                {
                    _NotNullBigIntColumn = value;
                }
            }
            public Byte[] NotNullBinaryColumn
            {
                get
                {
                    return _NotNullBinaryColumn;
                }
                set
                {
                    _NotNullBinaryColumn = value;
                }
            }
            public Byte[] NotNullImageColumn
            {
                get
                {
                    return _NotNullImageColumn;
                }
                set
                {
                    _NotNullImageColumn = value;
                }
            }
            public Byte[] NotNullVarBinaryColumn
            {
                get
                {
                    return _NotNullVarBinaryColumn;
                }
                set
                {
                    _NotNullVarBinaryColumn = value;
                }
            }
            public Boolean NotNullBitColumn
            {
                get
                {
                    return _NotNullBitColumn;
                }
                set
                {
                    _NotNullBitColumn = value;
                }
            }
            public String NotNullCharColumn
            {
                get
                {
                    return _NotNullCharColumn;
                }
                set
                {
                    _NotNullCharColumn = value ?? "";
                }
            }
            public String NotNullNCharColumn
            {
                get
                {
                    return _NotNullNCharColumn;
                }
                set
                {
                    _NotNullNCharColumn = value ?? "";
                }
            }
            public String NotNullNTextColumn
            {
                get
                {
                    return _NotNullNTextColumn;
                }
                set
                {
                    _NotNullNTextColumn = value ?? "";
                }
            }
            public String NotNullNVarCharColumn
            {
                get
                {
                    return _NotNullNVarCharColumn;
                }
                set
                {
                    _NotNullNVarCharColumn = value ?? "";
                }
            }
            public String NotNullTextColumn
            {
                get
                {
                    return _NotNullTextColumn;
                }
                set
                {
                    _NotNullTextColumn = value ?? "";
                }
            }
            public String NotNullVarCharColumn
            {
                get
                {
                    return _NotNullVarCharColumn;
                }
                set
                {
                    _NotNullVarCharColumn = value ?? "";
                }
            }
            public String NotNullXmlColumn
            {
                get
                {
                    return _NotNullXmlColumn;
                }
                set
                {
                    _NotNullXmlColumn = value ?? "";
                }
            }
            public DateTime NotNullDateTimeColumn
            {
                get
                {
                    return _NotNullDateTimeColumn;
                }
                set
                {
                    _NotNullDateTimeColumn = value;
                }
            }
            public DateTime NotNullSmallDateTimeColumn
            {
                get
                {
                    return _NotNullSmallDateTimeColumn;
                }
                set
                {
                    _NotNullSmallDateTimeColumn = value;
                }
            }
            public DateOnly NotNullDateColumn
            {
                get
                {
                    return _NotNullDateColumn;
                }
                set
                {
                    _NotNullDateColumn = value;
                }
            }
            public TimeOnly NotNullTimeColumn
            {
                get
                {
                    return _NotNullTimeColumn;
                }
                set
                {
                    _NotNullTimeColumn = value;
                }
            }
            public DateTime NotNullDateTime2Column
            {
                get
                {
                    return _NotNullDateTime2Column;
                }
                set
                {
                    _NotNullDateTime2Column = value;
                }
            }
            public Decimal NotNullDecimalColumn
            {
                get
                {
                    return _NotNullDecimalColumn;
                }
                set
                {
                    _NotNullDecimalColumn = value;
                }
            }
            public Decimal NotNullMoneyColumn
            {
                get
                {
                    return _NotNullMoneyColumn;
                }
                set
                {
                    _NotNullMoneyColumn = value;
                }
            }
            public Decimal NotNullSmallMoneyColumn
            {
                get
                {
                    return _NotNullSmallMoneyColumn;
                }
                set
                {
                    _NotNullSmallMoneyColumn = value;
                }
            }
            public Double NotNullFloatColumn
            {
                get
                {
                    return _NotNullFloatColumn;
                }
                set
                {
                    _NotNullFloatColumn = value;
                }
            }
            public Int32 NotNullIntColumn
            {
                get
                {
                    return _NotNullIntColumn;
                }
                set
                {
                    _NotNullIntColumn = value;
                }
            }
            public Single NotNullRealColumn
            {
                get
                {
                    return _NotNullRealColumn;
                }
                set
                {
                    _NotNullRealColumn = value;
                }
            }
            public Guid NotNullUniqueIdentifierColumn
            {
                get
                {
                    return _NotNullUniqueIdentifierColumn;
                }
                set
                {
                    _NotNullUniqueIdentifierColumn = value;
                }
            }
            public Int16 NotNullSmallIntColumn
            {
                get
                {
                    return _NotNullSmallIntColumn;
                }
                set
                {
                    _NotNullSmallIntColumn = value;
                }
            }
            public Byte NotNullTinyIntColumn
            {
                get
                {
                    return _NotNullTinyIntColumn;
                }
                set
                {
                    _NotNullTinyIntColumn = value;
                }
            }
            public DateTimeOffset NotNullDateTimeOffsetColumn
            {
                get
                {
                    return _NotNullDateTimeOffsetColumn;
                }
                set
                {
                    _NotNullDateTimeOffsetColumn = value;
                }
            }
            public Object NotNullSqlVariantColumn
            {
                get
                {
                    return _NotNullSqlVariantColumn;
                }
                set
                {
                    _NotNullSqlVariantColumn = value;
                }
            }
            public MyEnum NotNullEnumColumn
            {
                get
                {
                    return _NotNullEnumColumn;
                }
                set
                {
                    _NotNullEnumColumn = value;
                }
            }

            public ResultSet()
            {
            }
            public ResultSet(AllDataTypeTable.IRecord resultSet)
            {
                var r = resultSet;
                PrimaryKeyColumn = r.PrimaryKeyColumn;
                TimestampColumn = r.TimestampColumn;
                BigIntColumn = r.BigIntColumn;
                BinaryColumn = r.BinaryColumn;
                ImageColumn = r.ImageColumn;
                VarBinaryColumn = r.VarBinaryColumn;
                BitColumn = r.BitColumn;
                CharColumn = r.CharColumn;
                NCharColumn = r.NCharColumn;
                NTextColumn = r.NTextColumn;
                NVarCharColumn = r.NVarCharColumn;
                TextColumn = r.TextColumn;
                VarCharColumn = r.VarCharColumn;
                XmlColumn = r.XmlColumn;
                DateTimeColumn = r.DateTimeColumn;
                SmallDateTimeColumn = r.SmallDateTimeColumn;
                DateColumn = r.DateColumn;
                TimeColumn = r.TimeColumn;
                DateTime2Column = r.DateTime2Column;
                DecimalColumn = r.DecimalColumn;
                MoneyColumn = r.MoneyColumn;
                SmallMoneyColumn = r.SmallMoneyColumn;
                FloatColumn = r.FloatColumn;
                IntColumn = r.IntColumn;
                RealColumn = r.RealColumn;
                UniqueIdentifierColumn = r.UniqueIdentifierColumn;
                SmallIntColumn = r.SmallIntColumn;
                TinyIntColumn = r.TinyIntColumn;
                DateTimeOffsetColumn = r.DateTimeOffsetColumn;
                SqlVariantColumn = r.SqlVariantColumn;
                EnumColumn = r.EnumColumn;
                NotNullBigIntColumn = r.NotNullBigIntColumn;
                NotNullBinaryColumn = r.NotNullBinaryColumn;
                NotNullImageColumn = r.NotNullImageColumn;
                NotNullVarBinaryColumn = r.NotNullVarBinaryColumn;
                NotNullBitColumn = r.NotNullBitColumn;
                NotNullCharColumn = r.NotNullCharColumn;
                NotNullNCharColumn = r.NotNullNCharColumn;
                NotNullNTextColumn = r.NotNullNTextColumn;
                NotNullNVarCharColumn = r.NotNullNVarCharColumn;
                NotNullTextColumn = r.NotNullTextColumn;
                NotNullVarCharColumn = r.NotNullVarCharColumn;
                NotNullXmlColumn = r.NotNullXmlColumn;
                NotNullDateTimeColumn = r.NotNullDateTimeColumn;
                NotNullSmallDateTimeColumn = r.NotNullSmallDateTimeColumn;
                NotNullDateColumn = r.NotNullDateColumn;
                NotNullTimeColumn = r.NotNullTimeColumn;
                NotNullDateTime2Column = r.NotNullDateTime2Column;
                NotNullDecimalColumn = r.NotNullDecimalColumn;
                NotNullMoneyColumn = r.NotNullMoneyColumn;
                NotNullSmallMoneyColumn = r.NotNullSmallMoneyColumn;
                NotNullFloatColumn = r.NotNullFloatColumn;
                NotNullIntColumn = r.NotNullIntColumn;
                NotNullRealColumn = r.NotNullRealColumn;
                NotNullUniqueIdentifierColumn = r.NotNullUniqueIdentifierColumn;
                NotNullSmallIntColumn = r.NotNullSmallIntColumn;
                NotNullTinyIntColumn = r.NotNullTinyIntColumn;
                NotNullDateTimeOffsetColumn = r.NotNullDateTimeOffsetColumn;
                NotNullSqlVariantColumn = r.NotNullSqlVariantColumn;
                NotNullEnumColumn = r.NotNullEnumColumn;
            }
            internal ResultSet(AllDataTypeTableSelectByPrimaryKey storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<AllDataTypeTableSelectByPrimaryKey.ResultSet>");
                sb.AppendFormat("PrimaryKeyColumn={0}", this.PrimaryKeyColumn); sb.AppendLine();
                sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
                sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
                sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
                sb.AppendFormat("ImageColumn={0}", this.ImageColumn); sb.AppendLine();
                sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
                sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
                sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
                sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
                sb.AppendFormat("NTextColumn={0}", this.NTextColumn); sb.AppendLine();
                sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
                sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
                sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
                sb.AppendFormat("XmlColumn={0}", this.XmlColumn); sb.AppendLine();
                sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
                sb.AppendFormat("SmallDateTimeColumn={0}", this.SmallDateTimeColumn); sb.AppendLine();
                sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
                sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
                sb.AppendFormat("DateTime2Column={0}", this.DateTime2Column); sb.AppendLine();
                sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
                sb.AppendFormat("MoneyColumn={0}", this.MoneyColumn); sb.AppendLine();
                sb.AppendFormat("SmallMoneyColumn={0}", this.SmallMoneyColumn); sb.AppendLine();
                sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
                sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
                sb.AppendFormat("RealColumn={0}", this.RealColumn); sb.AppendLine();
                sb.AppendFormat("UniqueIdentifierColumn={0}", this.UniqueIdentifierColumn); sb.AppendLine();
                sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
                sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
                sb.AppendFormat("DateTimeOffsetColumn={0}", this.DateTimeOffsetColumn); sb.AppendLine();
                sb.AppendFormat("SqlVariantColumn={0}", this.SqlVariantColumn); sb.AppendLine();
                sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBigIntColumn={0}", this.NotNullBigIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBinaryColumn={0}", this.NotNullBinaryColumn); sb.AppendLine();
                sb.AppendFormat("NotNullImageColumn={0}", this.NotNullImageColumn); sb.AppendLine();
                sb.AppendFormat("NotNullVarBinaryColumn={0}", this.NotNullVarBinaryColumn); sb.AppendLine();
                sb.AppendFormat("NotNullBitColumn={0}", this.NotNullBitColumn); sb.AppendLine();
                sb.AppendFormat("NotNullCharColumn={0}", this.NotNullCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullNCharColumn={0}", this.NotNullNCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullNTextColumn={0}", this.NotNullNTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullNVarCharColumn={0}", this.NotNullNVarCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTextColumn={0}", this.NotNullTextColumn); sb.AppendLine();
                sb.AppendFormat("NotNullVarCharColumn={0}", this.NotNullVarCharColumn); sb.AppendLine();
                sb.AppendFormat("NotNullXmlColumn={0}", this.NotNullXmlColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateTimeColumn={0}", this.NotNullDateTimeColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSmallDateTimeColumn={0}", this.NotNullSmallDateTimeColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateColumn={0}", this.NotNullDateColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTimeColumn={0}", this.NotNullTimeColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateTime2Column={0}", this.NotNullDateTime2Column); sb.AppendLine();
                sb.AppendFormat("NotNullDecimalColumn={0}", this.NotNullDecimalColumn); sb.AppendLine();
                sb.AppendFormat("NotNullMoneyColumn={0}", this.NotNullMoneyColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSmallMoneyColumn={0}", this.NotNullSmallMoneyColumn); sb.AppendLine();
                sb.AppendFormat("NotNullFloatColumn={0}", this.NotNullFloatColumn); sb.AppendLine();
                sb.AppendFormat("NotNullIntColumn={0}", this.NotNullIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullRealColumn={0}", this.NotNullRealColumn); sb.AppendLine();
                sb.AppendFormat("NotNullUniqueIdentifierColumn={0}", this.NotNullUniqueIdentifierColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSmallIntColumn={0}", this.NotNullSmallIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullTinyIntColumn={0}", this.NotNullTinyIntColumn); sb.AppendLine();
                sb.AppendFormat("NotNullDateTimeOffsetColumn={0}", this.NotNullDateTimeOffsetColumn); sb.AppendLine();
                sb.AppendFormat("NotNullSqlVariantColumn={0}", this.NotNullSqlVariantColumn); sb.AppendLine();
                sb.AppendFormat("NotNullEnumColumn={0}", this.NotNullEnumColumn); sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
