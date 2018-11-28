using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeAuditableDocument
{
    public sealed class Core
    {
        private string user { get; set; }
        private static Core instance = null;

        private Core()
        {
        }

        public static Core Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Core();
                }
                return instance;
            }
        }

        public bool login(string user)
        {
            return true;
        }
    }
}
