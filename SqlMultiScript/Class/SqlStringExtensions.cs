using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.IO;
// stackoverflow.com/questions/3276035/code-to-validate-sql-scripts
namespace SqlMultiScript.Class
{
    public static class SqlStringExtensions
    {
        public static bool IsValidSql(this string str)
        {
            return !str.ValidateSql().Any();
        }

        public static IEnumerable<string> ValidateSql(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return new[] { "SQL query should be non empty." };
            }
            var parser = new TSql120Parser(false);
            IList<ParseError> errors;
            using (var reader = new StringReader(str))
            {
                parser.Parse(reader, out errors);
            }
            return errors.Select(err => err.Message);
        }
    }
}
