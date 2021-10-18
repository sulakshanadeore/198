using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class CategoryBAL
    {
        int _catid;
        public int CategoryID
        {
            get
            {
                return _catid;

            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentNullException("category id cannot be null or zero");
                }
                else
                {
                    _catid = value;
                }
            }
        }
        string _name;
        public string CatName
        { get { return _name; }
            set
            {
                if (value.Length > 0)
                {
                    _name = value;

                }
                else
                {
                    throw new ArgumentNullException("Name cannot be blank or null");
                }
            }
        }
        public string CatDesc { get; set; }
    }
}
