using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib1
{
    //interface içerisinde sadece metotlar ve propertyler olabilir
    //interface içerisinde ki metot ve propertyler class içerisinde tanımlanmalıdır.

    interface IHesap
    {
        int z {  get; set; }
        void topla(int sayi1, int sayi2);
        void carp(int sayi1, int sayi2);
    }
    public class Class4 : IHesap
    {
        public int z { get; set; }
        public int top {  get; set; }
        public void carp(int sayi1, int sayi2)
        {
            top = sayi1 * sayi2;
            z = 1;
        }

        public void topla(int sayi1, int sayi2)
        {
            top=sayi1 + sayi2;
            z = 2;
        }
    }
}
