using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportGen;

namespace ReportGenWrapper
{
    public class Application
    {
        public static int Main(String[] args) {
            new GenProcess().process();
            return 0;
        }
    }
}
