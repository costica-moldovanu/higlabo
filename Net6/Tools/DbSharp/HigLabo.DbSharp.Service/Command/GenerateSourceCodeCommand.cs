﻿using HigLabo.CodeGenerator;
using HigLabo.DbSharp.CodeGenerator;
using HigLabo.DbSharp.MetaData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HigLabo.DbSharp.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class GenerateSourceCodeCommand : DbSharpCommand
    {
        public event EventHandler<SourceCodeFileGeneratedEventArgs> FileGenerated;

        public String OutputDirectoryPath { get; set; }
        public String DatabaseKey { get; set; }
        public String NamespaceName { get; set; }
        public List<Table> Tables { get; private set; }
        public List<MetaData.StoredProcedure> StoredProcedures { get; private set; }
        public List<UserDefinedTableType> UserDefinedTableTypes { get; private set; }

        public GenerateSourceCodeCommand(String outputDirectoryPath, SchemaData schemaData)
            : this(outputDirectoryPath, schemaData.DatabaseKey, schemaData.NamespaceName)
        {
        }        
        public GenerateSourceCodeCommand(String outputDirectoryPath, String databaseKey, String namespaceName)
        {
            this.OutputDirectoryPath = outputDirectoryPath;
            this.DatabaseKey = databaseKey;
            this.NamespaceName = namespaceName;
            this.Tables = new List<Table>();
            this.StoredProcedures = new List<MetaData.StoredProcedure>();
            this.UserDefinedTableTypes = new List<UserDefinedTableType>();
        }

        protected override Task ExecuteAsync()
        {
            String path = this.OutputDirectoryPath;
            var tablePath = Path.Combine(path, "Table");
            var tableStoredProcedurePath = Path.Combine(path, "TableStoredProcedure");
            var storedProcedurePath = Path.Combine(path, "StoredProcedure");
            var userDefinedTableTypePath = Path.Combine(path, "UserDefinedTableType");

            ClassSourceCodeFileFactory f = null;
            var sc = new SourceCodeFileGenerator();
            foreach (var table in this.Tables)
            {
                f = new TableClassSourceCodeFileFactory(table, this.DatabaseKey);
                sc.SourceCodes.Add(f.Create(tablePath, this.NamespaceName));
                f = new TableRecordClassSourceCodeFileFactory(table);
                sc.SourceCodes.Add(f.Create(tablePath, this.NamespaceName));
                f = new TableIRecordClassSourceCodeFileFactory(table);
                sc.SourceCodes.Add(f.Create(tablePath, this.NamespaceName));
            }
            foreach (var sp in this.StoredProcedures.Where(el => el.StoredProcedureType != StoredProcedureType.Custom))
            {
                f = new StoredProcedureClassSourceCodeFileFactory(sp, this.DatabaseKey);
                sc.SourceCodes.Add(f.Create(tableStoredProcedurePath, this.NamespaceName));
            }
            foreach (var sp in this.StoredProcedures.Where(el => el.StoredProcedureType == StoredProcedureType.Custom))
            {
                f = new StoredProcedureClassSourceCodeFileFactory(sp, this.DatabaseKey);
                sc.SourceCodes.Add(f.Create(storedProcedurePath, this.NamespaceName));
            }
            foreach (var ut in this.UserDefinedTableTypes)
            {
                f = new UserDefinedTableTypeSourceCodeFileClassFactory(ut);
                sc.SourceCodes.Add(f.Create(userDefinedTableTypePath, this.NamespaceName));
            }

            var count = sc.SourceCodes.Count;
            for (int i = 0; i < count; i++)
            {
                var file = sc.SourceCodes[i];
                CSharpSourceCodeGenerator cs = null;

                using (var stm = new StreamWriter(file.FilePath, false, Encoding.UTF8))
                {
                    foreach (var c in String.Format("//Generated at {0} by DbSharpApplication."
                        , DateTimeOffset.Now.ToString("yyyy/MM/dd HH:mm:ss"), Environment.NewLine))
                    {
                        stm.Write(c);
                    }
                    stm.WriteLine();
                    stm.WriteLine("//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp");
                    cs = new CSharpSourceCodeGenerator(stm);
                    cs.Write(file.SourceCode);
                    this.OnProcessProgress(new ProcessProgressEventArgs(Path.GetFileName(file.FilePath), i / count));
                    this.OnFileGenerated(new SourceCodeFileGeneratedEventArgs(file, DateTime.Now));
                }
            }
            return Task.FromResult(0);
        }
        protected void OnFileGenerated(SourceCodeFileGeneratedEventArgs e)
        {
            var eh = this.FileGenerated;
            if (eh != null)
            {
                eh(this, e);
            }
        }

    }
}
