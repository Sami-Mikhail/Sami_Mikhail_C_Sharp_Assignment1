using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sami_Mikhail_C_Sharp_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// The bellow logic, class (functions), the input parameter is an intger and the
        /// output is the paramter + 10
        /// to enhance the functionlay I have addes a try catch, althought it is asked in the assignment
        /// but exception handeling is very importan in application as well as data validations 
        /// 3 cases to test my logic with
        /// Case 1 - 
        ///   Input: http Get request: localhost/api/AddTen/21
        ///   Output should be 31
        /// Case 2 - 
        ///   Onput: http Get request: localhost/Api/AddTen/0
        ///   Output should be 10
        /// Case 3 - 
        ///   Input: http Get request: localhost/api/AddTen/-9
        ///   Output should be 1
        /// <example> GET api/AddTen/{id}</example>
        /// <param name="id"></param>
        /// <returns>The passed parameter + 10</returns>
        /// </summary>
        public int Get(int id)
        {
            // I have added exception functionality, althouht its not in the assignment requirements
            // I added this code to show and prove my skills, any good aplication its only important that it works ok
            // But also exception hadeling, data validation, also commenting and indenting is very important for readabily
            try
            {
                return id + 10;
            }
            catch (Exception)
            {
                return (911);
            }
        }
    }
}
