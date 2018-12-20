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
    public class MemberInfoDal
    {
        public List<MemberInfo> GetList(MemberInfo mi)
        {
            string sql = "select mi.*,mti.mctype,mti.mcbz from memberinfo mi" +
            " inner join memberctypeinfo mti" +
            " on mi.mtypeid=mti.mcid" +
            " where mi.misdelete=0";

            //条件查询
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
            if (!string.IsNullOrEmpty(mi.MName))
            {
                sql += " and mi.mname like @name";
                listP.Add(new SQLiteParameter("@name", "%" + mi.MName + "%"));//"%%" 表示模糊查询（不精确）
            }
            if (!string.IsNullOrEmpty(mi.MPhone))
            {
                sql += " and mi.mphone like @phone";
                listP.Add(new SQLiteParameter("@phone", "%" + mi.MPhone + "%"));
            }
            if (!string.IsNullOrEmpty(mi.MCId))
            {
                sql += " and mi.mcid = @mcid";
                listP.Add(new SQLiteParameter("@mcid",mi.MCId ));
            }
            if (mi.MId > 0)
            {
                sql += " and mi.mid=@id";
                listP.Add(new SQLiteParameter("@id", mi.MId));
            }
            if (mi.MTag > 0)
            { 
                switch(mi.MTag)
                {
                    case 1:
                        sql += " and mi.menddate < datetime('now','7 day')";
                        break;
                    case 2:
                        sql += " and mi.menddate < datetime('now','30 day')";
                        break;
                    case 3:
                        sql += " and mi.mstartdate > datetime('now','-7 day')";
                        break;
                    case 4:
                        sql += " and mi.mstartdate > datetime('now','-30 day')";
                        break;
                    case 5:
                        sql += " and mi.menddate < datetime('now')";
                        break;
                }
            }

            sql += " order by mi.mid desc";//倒叙

            DataTable dt = SqliteHelper.GetList(sql, listP.ToArray());

            List<MemberInfo> list = new List<MemberInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPhone = row["mphone"].ToString(),
                    MAdress = row["madress"].ToString(),
                    MCId = row["mcid"].ToString(),
                    MSex = row["msex"].ToString(),
                    MTypeId = Convert.ToInt32(row["mtypeid"]),
                    MCount = Convert.ToInt32(row["mcount"]),                   
                    MStartDate = Convert.ToDateTime(row["mstartdate"]),
                    MEndDate = Convert.ToDateTime(row["menddate"]),
                    MDate = Convert.ToDateTime(row["mdate"]),
                    MBZ = row["mbz"].ToString(),
                    MPhoto = row["mphoto"].ToString(),
                    TypeTitle =  row["mctype"].ToString(),
                    TypeBz = row["mcbz"].ToString(),
                });
            }
            return list;
        }

        public int Insert(MemberInfo mi)
        {
            string sql = "insert into memberinfo(mtypeId,mname,mphone,mcid,madress,msex,mstartdate,menddate,mcount,mdate,mbz,mphoto,misdelete) values(@typeid,@name,@phone,@cid,@adress,@sex,@startdate,@enddate,@count,@date,@bz,@photo,0)";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@typeid",mi.MTypeId),
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@phone",mi.MPhone),
                new SQLiteParameter("@cid",mi.MCId),
                new SQLiteParameter("@adress",mi.MAdress),
                new SQLiteParameter("@sex",mi.MSex),
                new SQLiteParameter("@count",mi.MCount),
                new SQLiteParameter("@bz",mi.MBZ),
                new SQLiteParameter("@date",mi.MDate),
                new SQLiteParameter("@photo",mi.MPhoto),
                new SQLiteParameter("@startdate",mi.MStartDate),
                new SQLiteParameter("@enddate",mi.MEndDate)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        //public int Update(MemberInfo mi)
        //{
        //    string sql = "update memberinfo set mname=@name,mphone=@phone,mtypeid=@typeid,mcid=@cid where mid=@id";
        //    SQLiteParameter[] ps = 
        //    {
        //        new SQLiteParameter("@typeid",mi.MTypeId),
        //        new SQLiteParameter("@name",mi.MName),
        //        new SQLiteParameter("@phone",mi.MPhone),
        //        new SQLiteParameter("@cid",mi.MCId),
        //        new SQLiteParameter("@id",mi.MId)
        //    };
        //    return SqliteHelper.ExecuteNonQuery(sql, ps);
        //}

        public int Delete(int id)
        {
            string sql = "delete from memberinfo where mid=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        //public List<MemberInfo> GetList(MemberInfo mi)
        //{
        //    string sql = "select mi.*,mti.mctype from memberinfo mi" +
        //   " inner join memberctypeinfo mti" +
        //   " on mi.mdtypeid=mti.mcid" +
        //   " where mi.mcid=@mcid";

        //    SQLiteParameter p = new SQLiteParameter("@mcid", mi.MCId);

        //    DataTable dt = SqliteHelper.GetList(sql, p);

        //    List<MemberInfo> list = new List<MemberInfo>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        list.Add(new MemberInfo()
        //        {
        //            MId = Convert.ToInt32(row["mid"]),
        //            MName = row["mname"].ToString(),
        //            MPhone = row["mphone"].ToString(),
        //            MAdress = row["madress"].ToString(),
        //            MCId = row["mcid"].ToString(),
        //            MSex = row["msex"].ToString(),
        //            MTypeId = Convert.ToInt32(row["mtypeid"]),
        //            MIDCard = row["midcard"].ToString(),
        //            MStartDate = Convert.ToDateTime(row["mstartdate"]),
        //            MEndDate = Convert.ToDateTime(row["menddate"]),
        //        });
        //    }
        //    return list;
        //}

        public int Update(MemberInfo mi)
        {
            string sql = "update memberinfo set mname=@name,mphone=@phone,madress=@adress,msex=@sex,mcid=@mcid,mbz=@bz where mid=@mid";

            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@phone",mi.MPhone),
                new SQLiteParameter("@adress",mi.MAdress),
                new SQLiteParameter("@sex",mi.MSex),
                new SQLiteParameter("@mcid",mi.MCId),            
                new SQLiteParameter("@mid",mi.MId),
                new SQLiteParameter("@bz",mi.MBZ),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int UpdateCount(MemberInfo mi)
        {
            string sql = "update memberinfo set mcount=mcount+1,mdate=datetime('now','localtime') where mcid=@mcid";
            SQLiteParameter p = new SQLiteParameter("@mcid",mi.MCId);

            return SqliteHelper.ExecuteNonQuery(sql,p);
        }

        public int UpdateNewCId(MemberInfo mi)
        {
            string sql = "update  memberinfo set mcid=@cid where mid=@mid";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@cid",mi.MCId),
                new SQLiteParameter("@mid",mi.MId),
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        //续卡操作
        public int UpdateEndtime(MemberInfo mi)
        {
            string sql = "update memberinfo set menddate=@enddate,mbz=@bz where mid=@mid ";
            string bzstr="";
            if (mi.MBZ != "无")
            {
                bzstr += mi.MBZ;
            }
            bzstr += "《于"+DateTime.Now.ToShortDateString() +"办理了续卡业务！续卡类型为："+mi.MSex+"》;";
            
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@enddate",mi.MEndDate),
                new SQLiteParameter("@mid",mi.MId),
                new SQLiteParameter("@bz",bzstr),
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int UpdatePhoto(MemberInfo mi)
        {
            string sql = "update memberinfo set mphoto=@photo where mid=@mid";

            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@photo",mi.MPhoto),
                new SQLiteParameter("@mid",mi.MId),
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

    }
}
