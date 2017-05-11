using ReportGen.WordGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGen {

    class AppContext {

        public Microsoft.Office.Interop.Word.Application applWord;
        public Microsoft.Office.Interop.Word.Document docWord;

        // Word generators
        public HeaderGen header;

        // Excel readers
        

        public AppContext() {
            applWord = new Microsoft.Office.Interop.Word.Application();
            applWord.Visible = false;
            header = new HeaderGen();
        }

    }
}
