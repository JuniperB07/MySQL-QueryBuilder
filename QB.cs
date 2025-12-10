using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;

namespace MySQL_QueryBuilder
{
    internal static class QB
    {
        internal const string MBOX_CAPTION = "MySQL QueryBuilder";

        internal static string ConnSTR { get; set; }
        internal static bool ConnStatus { get; set; }
        internal static string Database { get; set; }
        internal static string Server { get; set; }

        internal static DBConnect DBC { get; set; }
    }
}
