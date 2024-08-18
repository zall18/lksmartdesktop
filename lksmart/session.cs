using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lksmart
{
    static class session
    {

        public static int user_id;
        public static string user_name;    

        public static void start(int id, string name)
        {
            user_id = id;
            user_name = name;
        }

    }
}
