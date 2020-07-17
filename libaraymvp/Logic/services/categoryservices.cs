using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libaraymvp.Logic.services
{
   static class categoryservices
    {
        public static bool categoryinsert(int id,string name)
        {
            return dbhelper.excutedata("categoryinsert", ()=> categoryparameterinsert(id, name,dbhelper.command));
        }
        //this method to add insert parameter into stored proceder
        private static void categoryparameterinsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
//--------------------------------------------------------------------------------------------
        public static bool categorydelete(int id)
        {
            return dbhelper.excutedata("categorydelete", () => categoryparameterdelete(id,dbhelper.command));
        }
        //this method to delete parameter into stored proceder
        private static void categoryparameterdelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
//-------------------------------------------------------------------------------------------
        public static bool categoryupdate(int id, string name)
        {
            return dbhelper.excutedata("categoryupdate", () => categoryparameterupdate(id,name, dbhelper.command));
             
        }
        //this method to update parameter into stored proceder
        private static void categoryparameterupdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

        }

    }
}
