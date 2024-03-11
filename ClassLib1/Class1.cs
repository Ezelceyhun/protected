namespace ClassLib1
{
    public class Class1
    {
        //protected kendi class'ın içindeyse doğrudan erişilebiliyor.
        public int Property { get; set; }
        public int b {  get; set; }

        protected internal int a = 5;
        protected string islem()
        {
            a++;
            return a.ToString();            
        }
        public void ver()
        {
            islem();
            b = a;
        }
        class Class2 : Class1
        {
            void gonder()
            {
                islem();
                a = 2;
            }
        }
        class Class3 : Class2
        {
            void al()
            {
                islem();
                a = 1;
            }
        }
    }
}