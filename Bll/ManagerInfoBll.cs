using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    
    public class ManagerInfoBll
    {
        ManagerInfoDal miDal = new ManagerInfoDal();
        public List<ManagerInfo> GetList()
        {

            return miDal.GetList(null);
        }

        public bool Add(ManagerInfo mi)
        {
            return miDal.Insert(mi) > 0;
        }

        public bool Update(ManagerInfo mi)
        {
            return miDal.Update(mi) > 0;
        }

        public bool Remove(int id)
        {
            return miDal.Delete(id) > 0;
        }

        public bool Load(ManagerInfo mi)
        {
            var list = miDal.GetList(mi);
            if (list.Count > 0)
            {
                mi.MType = list[0].MType;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
