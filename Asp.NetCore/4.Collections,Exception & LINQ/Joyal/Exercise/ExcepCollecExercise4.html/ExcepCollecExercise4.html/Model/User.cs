using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Model
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public long Phone {  get; set; }
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
