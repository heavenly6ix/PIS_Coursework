using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Session
    {
        public static int CurrentSessionID { get; set; }
        public static string CurrentSessionName { get; set; }

        public static void Reset()
        {
            CurrentSessionID = 0;
            CurrentSessionName = null;
        }
    }
}
