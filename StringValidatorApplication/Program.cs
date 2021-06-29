using System;

namespace StringValidatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "excel";
            StringValidator nullorempty = new StringValidator( new IsNullOrEmpty());
            nullorempty.IsValidString(data);

            StringValidator lengthcheck = new StringValidator(new LengthCheck());
            lengthcheck.IsValidString(data);

            StringValidator startwith = new StringValidator(new StartWithCheck());
            startwith.IsValidString(data);
           
        }
    }
  
}
