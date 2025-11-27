using Exercise_oops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_oops.Interface
{
    public interface IApplicationProvider
    {
        public void AddApplication(Application application);
        Application[] GetApplications();
    }
}
