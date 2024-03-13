using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib1
{
    public class Class7
    {
        public string message;
        public string alert;
        public virtual void Insert(string data)
        {
            message += data + " Üye Kaydedildi!";
        }
    }
    public class User:Class7
    {
        public override void Insert(string data)
        {
            if(data == "ceyhun")
            {
                message = data + " Üyesi Zaten Eklenmiş!";
            }
            else
            {
                base.Insert(data);
            }
        }
    }
}