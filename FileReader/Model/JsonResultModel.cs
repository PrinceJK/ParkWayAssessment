using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileReader.Model
{
    public class JsonResultModel
    {
        public List<Fees> Fees { get; set; }
    }

    public class Fees
    {
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal FeeAmount { get; set; }
    }
}
