using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sami_Mikhail_C_Sharp_Assignment1.Controllers
{
public class GreetingController : ApiController
{
        /// <summary>
        /// The bellow logic, class (functions), has no input and the
        /// output should be the text "Hellow Worl"
        /// to enhance the functionlay I have addes a try catch, althought it is asked in the assignment
        /// but exception handeling is very importan in application as well as data validations 
        /// 1 cases to test my logic with
        /// Case 1 -    Input: http Post request: localhost/api/Greeting
        ///   Output should be Hellow World
        /// <example> GET api/GrettingAddTen</example>
        /// <param name> No Parameters for this function></param>
        /// <returns>The string Hellow work</returns>
        /// </summary>
        /// 

        // Althought POST does not work here
        // the work around is the command Curl -d "<url>"
        private const string Return_txt = "Hello World";
        public string PostHello (string id)
    {
        try
        {
            return Return_txt;
        }
        catch (Exception)
        {
            return ("Error");
        }
    }
}
}

