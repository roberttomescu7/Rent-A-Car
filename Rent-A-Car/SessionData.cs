using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    public static class SessionData
    {
        public static int UserID { get; set; }
        public static bool IsAdmin { get; set; }
        public static string UserFullName { get; set;}

        public static int branchID { get; set; }
    }
}
