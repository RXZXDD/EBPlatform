using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBPlatform.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PName { get; set; }   
        public string PDescribe { get; set; }
        public Decimal PPrice { get; set; }
        public int PNum { get; set; }
    }
}
