

namespace task13feb
{
    public class Calculator
    {
        public int n1 {  get; set; }
        public int n2 {  get; set; }
        int res;

        public int sub() 
        {
            res=n1 + n2;
            return res;
        }
        public int mul()
        {
            res=n1 * n2;
            return res;
        }
        public int div()
        {
            res=n1 / n2;
            return res;
        }

        
    }
}
