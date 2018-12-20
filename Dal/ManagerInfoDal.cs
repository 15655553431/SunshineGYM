using Common;
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
    public class ManagerInfoDal
    {
        public List<ManagerInfo> GetList(ManagerInfo mi)
        {
            string sql = "select * from managerinfo";
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
            if (mi != null)
            {
                sql += " where mname=@name and mpwd=@pwd";
                listP.Add(new SQLiteParameter("@name", mi.MName));
                listP.Add(new SQLiteParameter("@pwd", Md5Helper.GetMd5(mi.MPwd)));
            }
            DataTable table = SqliteHelper.GetList(sql,listP.ToArray());

            List<ManagerInfo> list = new List<ManagerInfo>();
            foreach(DataRow row in table.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPwd = row["mpwd"].ToString(),
                    MType = Convert.ToInt32(row["mtype"])
                });
            }
            return list;
        }

        public int Insert(ManagerInfo mi)
        {
            string sql = "insert into managerinfo(mname,mpwd,mtype) values(@name,@pwd,@type)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@pwd",Md5Helper.GetMd5(mi.MPwd)),
                new SQLiteParameter("@type",mi.MType),
            };
            return SqliteHelper.ExecuteNonQuery(sql,ps);
        }

        public int Update(ManagerInfo mi)
        {
            List<SQLiteParameter> list = new List<SQLiteParameter>();

            string sql = "update managerinfo set mname=@name,";
            list.Add(new SQLiteParameter("@name",mi.MName));

            if (!mi.MPwd.Equals("******"))
            {
                sql += "mpwd=@pwd,";
                list.Add(new SQLiteParameter("@pwd", Md5Helper.GetMd5(mi.MPwd)));
            }
            sql += "mtype=@type where mid=@id";
            list.Add(new SQLiteParameter("@type", mi.MType));
            list.Add(new SQLiteParameter("@id", mi.MId));

            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }

        public int Delete(int id)
        {
            string sql = "delete from managerinfo where mid=@id";
            SQLiteParameter p = new SQLiteParameter("@id",id);
            return SqliteHelper.ExecuteNonQuery(sql,p);
        }
    }
}
