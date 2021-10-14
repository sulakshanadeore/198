using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBALLayer
{
  public  class ProductsBAL
    {

        public int Prodid { get; set; }
        string _productname;
        public string Prodname
        {
            get { return _productname; }
            set
            {
                if (value.Length>0)
                {
                    _productname = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
            }
        }

        float _price;
        public float Price { get { return _price; } set {
                if (value>0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentNullException("Price must be greater than 0");
                }
            } }
        string _uom;
        public string UOM
        {
            get { return _uom; }
            set
            {
                if (value.Length>0)
                {
                    _uom = value;

                }
                else
                {
                    throw new ArgumentNullException(" UOM cannot be null");
                }
            } }
    }
}
