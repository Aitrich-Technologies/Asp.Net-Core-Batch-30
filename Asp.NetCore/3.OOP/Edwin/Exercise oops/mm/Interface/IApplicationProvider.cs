using mm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm.Interface
{
    public interface IApplicationProvider
    {
        void AddApplication(Application application);
        Application[] GetApplications();
    }
}
