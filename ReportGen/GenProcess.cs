using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen {

    public class GenProcess {

        private AppContext ctx;

        public GenProcess() {
            ctx = new AppContext();
        }

        public void process() {
            ctx.docWord = ctx.applWord.Documents.Add();
            ctx.applWord.Selection.TypeText("hello.");
            String filename = @"D:\yo2.docx";

            ctx.header.genHeader(ctx);
            

            // save document
            object missing = System.Reflection.Missing.Value;
            ctx.applWord.ActiveDocument.SaveAs(filename, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);
            ctx.applWord.ActiveDocument.Close();

        }
    }
}
