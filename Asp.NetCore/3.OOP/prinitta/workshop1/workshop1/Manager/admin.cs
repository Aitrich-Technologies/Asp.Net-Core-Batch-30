using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.Models;

namespace workshop1.Manager
{
    internal class admin
    {
        private user[] users = new user[2];
        private int num_users = 0;
        jobmanager job = new jobmanager();
        bool _islogged = false;

        public void Register(string username,string password)
        {
            if (num_users == users.Length) {
                Console.WriteLine("Maximum number of users reached. please try again later.");
                return;
            }

            user newuser = new user(username, password);
            users[num_users] = newuser;
            num_users++;
            Console.WriteLine("Registration successfull");
        }

        public bool Login (string username,string password)
        {
            for(int i=0; i < num_users; i++)
            {
                if (users[i].Username==username && users[i].Password == password)
                {
                    Console.WriteLine("login successful");
                    _islogged = true;
                    string ch = "0";
                    if(_islogged)
                        while (ch != "3")
                        {
                            Console.WriteLine("1 post job\n");
                            Console.WriteLine("2. list job\n");
                            Console.WriteLine("3. Back to main menu\n");
                            ch = Console.ReadLine();

                            if (ch == "1")
                            {
                                job.addjob();
                            }
                            if (ch == "2")
                            {
                                job.ListJob();
                            }
                            if (ch == "3")
                            {
                                Console.WriteLine("exit");
                            }
                        }


                    return true;
                }
            }
            Console.WriteLine("Invalid username or password");
            return false;
        }
    }
}

