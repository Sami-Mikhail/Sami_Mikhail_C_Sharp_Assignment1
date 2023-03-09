using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sami_Mikhail_C_Sharp_Assignment1.Controllers
{ 
public class SquareController : ApiController
{
    /// <summary>
    /// The bellow logic, class (functions), the input parameter is an intger and the
    /// output is the square root of the paramter
    /// to enhance the functionlay I have addes a try catch, althought it is asked in the assignment
    /// but exception handeling is very importan in application as well as data validations 
    /// 3 cases to test my logic with
    /// Case 1 - 
    ///   Input: http Get request: localhost/api/Square/2
    ///   Output should be 4
    /// Case 2 - 
    ///   Onput: http Get request: localhost/api/Aquare/-2
    ///   Output should be 4
    /// Case 3 - 
    ///   Input: http Get request: localhost/api/Square/10
    ///   Output should be 100
    /// <example> GET api/AddTen</example>
    /// <param name="id"></param>
    /// <returns>The passed parameter squared</returns>
    /// </summary>
    public int Get(int id)
    {
        try
        {
            return id * id;
        }
        catch (Exception)
        {
            return (911);
        }
    }
}
}

