using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MemberCTypeInfoDal
    {
        public List<MemberCTypeInfo> GetList(int id)
        {
            string sql = "select * from MemberCTypeInfo where mcisdelete=0";

            //条件查询
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
            if (id>0)
            {
                sql += " and mcid = @id";
                listP.Add(new SQLiteParameter("@id",id));
            }

            DataTable table = SqliteHelper.GetList(sql,listP.ToArray());

            List<MemberCTypeInfo> list = new List<MemberCTypeInfo>();

            foreach(DataRow row in table.Rows)
            {
                list.Add(new MemberCTypeInfo() 
                { 
                    MCId = Convert.ToInt32(row["mcid"]),
                    MCType = row["mctype"].ToString(),
                    MCDay = row["mcday"].ToString(),
                    MCBZ = row["mcbz"].ToString()
                });
            }
            return list;
        }

        public int Insert(MemberCTypeInfo mti)
        {
            string sql = "insert into MemberCTypeInfo(mctype,mcday,mcbz,mcisdelete) values(@type,@day,@bz,0)";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@type",mti.MCType),
                new SQLiteParameter("@day",mti.MCDay),
                new SQLiteParameter("@bz",mti.MCBZ)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Update(MemberCTypeInfo mti)
        {
            string sql = "update MemberCTypeInfo set mctype=@type,mcday=@day,mcbz=@bz where mcid=@id";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@type",mti.MCType),
                new SQLiteParameter("@day",mti.MCDay),
                new SQLiteParameter("@bz",mti.MCBZ),
                new SQLiteParameter("@id",mti.MCId)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(int id)
        {
            //逻辑删除，将misdelete删除标记改为1 表示删除
            string sql = "update MemberCTypeInfo set mcisdelete=1 where mcid=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);

            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}
