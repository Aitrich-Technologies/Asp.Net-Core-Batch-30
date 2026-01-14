using collectionException.Exceptions;
using collectionException.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Services
{
    public class InterviewService
    {
        private static List<Interview> _interviews = new();
        private static int _counter = 1;

        public Interview ScheduleInterview(int jobId, string seeker, string provider, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(seeker))
                throw new PortalException("Seeker name required.");
            if (string.IsNullOrWhiteSpace(provider))
                throw new PortalException("Provider name required.");
            if (date < DateTime.Now)
                throw new PortalException("Date cannot be in the past.");

            var interview = new Interview
            {
                Id = _counter++,
                JobId = jobId,
                SeekerName = seeker,
                ProviderName = provider,
                InterviewDate = date
            };
            interview.Validate();
            _interviews.Add(interview);
            return interview;
        }

        public List<Interview> GetAll() => _interviews;

        public List<Interview> GetByJobId(int jobId)
        {
            var res = _interviews.Where(i => i.JobId == jobId).ToList();
            if (res.Count == 0) throw new PortalException("No interviews for this job.");
            return res;
        }

        public List<Interview> GetBySeeker(string seeker)
        {
            var res = _interviews.Where(i => i.SeekerName.Equals(seeker, System.StringComparison.OrdinalIgnoreCase)).ToList();
            if (res.Count == 0) throw new PortalException("No interviews for this seeker.");
            return res;
        }

        public void Reschedule(int interviewId, DateTime newDate)
        {
            var interview = _interviews.FirstOrDefault(i => i.Id == interviewId);
            if (interview == null) throw new PortalException("Interview not found.");
            interview.Reschedule(newDate);
        }

        public void CancelInterview(int interviewId)
        {
            var interview = _interviews.FirstOrDefault(i => i.Id == interviewId);
            if (interview == null) throw new PortalException("Interview not found.");
            _interviews.Remove(interview);
        }
    }
}
