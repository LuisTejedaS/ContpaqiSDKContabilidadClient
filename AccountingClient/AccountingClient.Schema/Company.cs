using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingClient.Schema
{
    public class Company
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DataPath { get; set; }
        public string BackupPath { get; set; }
        public DateTime LastBackup { get; set; }
        public DateTime LastRestore { get; set; }
        public string LastRestoreFile { get; set; }
        public string DBName { get; set; }
    }
}