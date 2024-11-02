using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1191536.DataLayer
{
    internal interface IDataAccess
    {
        object GetSingleAnswer(string sql);
        DataTable GetManyRowsCols(string sql);
        int InsertUpdateDelete(string sql);
    }
}
