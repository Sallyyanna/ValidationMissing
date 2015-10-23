using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationTask
{
    public class DataProcessor
    {
        public void SetUserName(string name)
        {
            if (name.Length == 0)
            {
                throw new Exception("Invalid username");
            }
        }
    }
}