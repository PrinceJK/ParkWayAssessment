using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionApp.Models
{
    public class JsonResult
    {
        public List<FileResult> Files { get; set; }
    }

    public class FileResult
    {
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal FeeAmount { get; set; }
    }
}
