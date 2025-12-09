using ExcepCollecExercise4.html.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Interface
{
    public interface IJobService
    {
        void ListJobs();
        void PostJob(User user);
        void ApplyJob(User user);
        void SaveJob(User user);
        void ShowSavedJobs(User user);
        void ShowAppliedJobs(User user);
    }
}
