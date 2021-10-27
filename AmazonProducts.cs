using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp.Models
{
    public class AmazonProducts
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public float Price { get; set; }
        public int Catid { get; set; }
    }
}