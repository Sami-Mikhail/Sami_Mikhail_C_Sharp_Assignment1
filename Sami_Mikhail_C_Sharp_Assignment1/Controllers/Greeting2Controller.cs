using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sami_Mikhail_C_Sharp_Assignment1.Controllers
{
    public class Greeting2Controller : ApiController
    {
        /// <summary>
        /// The bellow logic, class (functions), has an input integer and the
        /// output should be the text Greeting to <paramter passed> people!
        /// to enhance the functionlay I have addes a try catch, althought it is asked in the assignment
        /// but exception handeling is very importan in application as well as data validations 
        /// 1 cases to test my logic with
        /// Case 1 -    Input: http Get request: localhost/api/Greeting2/3
        ///    Output should be Greetings to 3 people
        /// Case 2 -    Input: http Get request: localhost/api/Greeting2/6
        ///   Output should be Greetings to 6 people
        /// Case 3 -    Input: http Get request: localhost/api/Greeting2/0
        ///   Output should be Greetings to 0 people
        /// <example> GET api/Gretting2</example>
        /// <param name> 1 intger Parameters for this function></param>
        /// <returns>The string Hellow work</returns>
        /// </summary>
        /// 
        public string GetGreeting2 (int id)
        {
            try
            {
                return 'Greeting to ' + id + 'people!';
            }
            catch (Exception)
            {
                return 'Error';
            }
        }
    }
}

