public class StringValidator
    {
        public bool IsValidString(string data)
        {
            if(string.IsNullOrEmpty(data))
            {
                return false;
            }
            if(data.Length > 8)
            {
                return false;
            }
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
    public class Entrypoint
    {
        static void Main()
        {
            StringValidator _validator = new StringValidator();
            string data = null;
           bool isValid= _validator.IsValidString(null);
          bool _isValid=  _validator.IsValidString("");
          bool _isValid=  _validator.IsValidString("excel");

        }
    }
