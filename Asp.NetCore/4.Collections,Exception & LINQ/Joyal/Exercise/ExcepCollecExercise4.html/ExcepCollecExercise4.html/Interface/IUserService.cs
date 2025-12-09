using ExcepCollecExercise4.html.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Interface
{
    public interface IUserService
    {
        void Register();
        User Login();
    }
}
