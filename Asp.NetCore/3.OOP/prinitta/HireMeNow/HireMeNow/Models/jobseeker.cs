<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace HireMeNow.models
    {
        public class JobSeeker
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string Email;
            public string Phone;
            public string Location;
            public string AboutMe;
            public string Qualification;
            public Experiencelevel ExperienceLevel;
            public string Password;

            private List<Job> appliedJobs = new List<Job>();
            private List<Job> savedJobs = new List<Job>();

            public void addAppliedJob(Job job)
            {
                appliedJobs.Add(job);
            }

            public List<Job> GetAppliedJobs()
            {
                return appliedJobs;
            }

            public void addSavedJob(Job job)
            {
                savedJobs.Add(job);
            }

            public List<Job> GetSavedJobs()
            {
                return savedJobs;
            }
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace HireMeNow.models
    {
        public class JobSeeker
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string Email;
            public string Phone;
            public string Location;
            public string AboutMe;
            public string Qualification;
            public Experiencelevel ExperienceLevel;
            public string Password;

            private List<Job> appliedJobs = new List<Job>();
            private List<Job> savedJobs = new List<Job>();

            public void addAppliedJob(Job job)
            {
                appliedJobs.Add(job);
            }

            public List<Job> GetAppliedJobs()
            {
                return appliedJobs;
            }

            public void addSavedJob(Job job)
            {
                savedJobs.Add(job);
            }

            public List<Job> GetSavedJobs()
            {
                return savedJobs;
            }
        }
    }
>>>>>>> c65346a8715ef5f84b526c46ede8030b3555f835
