using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacaoParalela.Core
{
    internal class SqlServerContext
    {
        internal string ConnectionString => @"Data Source=.\SQLEXPRESS;Initial Catalog=Recuperacao;Persist Security Info=True;User ID=sa;Password=sql2022;Trusted_Connection=False;TrustServerCertificate=True";
    }
}
