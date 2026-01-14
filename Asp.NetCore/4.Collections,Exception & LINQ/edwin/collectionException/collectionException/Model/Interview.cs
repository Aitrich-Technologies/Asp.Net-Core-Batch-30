using collectionException.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Model
{
    public class Interview
    {
        public int Id;
        public int JobId;
        public string SeekerName;
        public string ProviderName;
        public DateTime InterviewDate;

        public void Validate()
        {
            if (JobId <= 0) throw new PortalException("Invalid Job ID.");

            if (string.IsNullOrWhiteSpace(SeekerName)) throw new PortalException("Seeker name required.");

            if (string.IsNullOrWhiteSpace(ProviderName)) throw new PortalException("Provider name required.");

            if (InterviewDate == default) throw new PortalException("Interview date required.");

            if (InterviewDate < DateTime.Now) throw new PortalException("Interview cannot be in the past.");

        }

        public void Reschedule(DateTime newDate)
        {
            if (newDate < DateTime.Now) throw new PortalException("New date cannot be in the past.");
            InterviewDate = newDate;
        }

        public string GetSummary()
        {
            return $"Interview {Id} for Job {JobId} on {InterviewDate:yyyy-MM-dd HH:mm}";
        }

        public override string ToString()
        {
            return $"{Id}. Job {JobId} | Seeker: {SeekerName} | Provider: {ProviderName} | {InterviewDate:yyyy-MM-dd HH:mm}";
        }
    }
}
