using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberInfo
    {
        public int MId { get; set; }
        public string MName { get; set; }
        public string MPhone { get; set; }
        public DateTime MStartDate { get; set; }
        public DateTime MEndDate { get; set; }
        public int MTypeId{ get; set; }
        public bool MIsDelete { get; set; }
        public string MCId { get; set; }
        public string MAdress { get; set; }
        public string MSex { get; set; }
        public int MCount { get; set; }
        public DateTime MDate { get; set; }
        public string MBZ { get; set; }
        public string MPhoto { get; set; }

        public string TypeTitle { get; set; }
        public int MTag { get; set; }
        public string TypeBz { get; set; }
    }
}
