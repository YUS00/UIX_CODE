using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaCR
{
    class OrderModel
    {
        private static string _OrderCode;
        public static string OrderCode
        {
            get { return _OrderCode; }
            set { _OrderCode = value; }
        }


    }
}
