using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;

namespace DASPClient.Utility
{
    public class SpringUtils
    {
        //单例模式
        private static IApplicationContext _context;

        public static IApplicationContext Context
        {
            get
            {
               return _context;
            }
        }

        static SpringUtils()
        {
            _context = ContextRegistry.GetContext();
        }
    }
}
