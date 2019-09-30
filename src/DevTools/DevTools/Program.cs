using BusinessLayer.ServiceLayer;
using System;

namespace DevTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "My Name is Rahul";
            var obj = new EncodingDecoding();
            string encodedStr = obj.Base64Encoding(str);
        }
    }
}
