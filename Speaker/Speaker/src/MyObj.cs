using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RedBlackTree;

namespace Speaker.src
{
    public class MyObj
    {
        private long intMyObjKey;
        private string myData;

        public long Key
        {
            get
            {
                return intMyObjKey;
            }

            set
            {
                intMyObjKey = value;
            }
        }
        public string Data
        {
            get
            {
                return myData;
            }

            set
            {
                myData = value;
            }
        }

        public MyObj(long key, string data)
        {
            this.Key = key;
            this.Data = data;
        }

        public override string ToString()
        {
            return intMyObjKey.ToString();
        }
    }
}
