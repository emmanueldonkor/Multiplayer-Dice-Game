using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project
{
    class Icons
    {
        public string img, name;
        public Icons(string img, string name)
        {
            this.name = name;
            this.img = img;
        }
        public string getimg()
            {
              return this.img;
            }
        public string getName()
        {
            return this.name;
        }
    }
}
