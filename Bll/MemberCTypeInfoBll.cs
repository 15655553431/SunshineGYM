using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class MemberCTypeInfoBll
    {
        MemberCTypeInfoDal mtiDal = new MemberCTypeInfoDal();
        public List<MemberCTypeInfo> GetList(int id)
        {
           return mtiDal.GetList(id);
        }

        public bool Add(MemberCTypeInfo mti)
        {
            return mtiDal.Insert(mti) > 0;
        }

        public bool Update(MemberCTypeInfo mti)
        {
            return mtiDal.Update(mti) > 0;
        }

        public bool Delete(int id)
        {
            return mtiDal.Delete(id) > 0;
        }
    }
}
