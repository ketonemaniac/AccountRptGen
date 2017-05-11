using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen {

    public class Program {

        int i = 1;

        public async Task<object> Main(String location) {
            new GenProcess().process();
            return "OK";
        }

        public async Task<object> One(String s) {
            return i++;
        }
    }
}
