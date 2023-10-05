using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ContaDAL
    {
        private SqlConnection conn;
        private Categoria categoria;

        public ContaDAL(SqlConnection conn) 
        {
            this.conn = conn;
            string strConn = Db.Conexao.GetStringConnection();
            this.categoria = new Categoria(new SqlConnection(strConn));
        }
    }

}
