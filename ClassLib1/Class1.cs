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
    }
}