using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen.WordGen {

    class HeaderGen {
        
        public void genHeader(AppContext ctx) {
            ctx.docWord.Sections[1].Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Select();
            ctx.applWord.Selection.TypeText("yoyoyo");
        }

    }
}
