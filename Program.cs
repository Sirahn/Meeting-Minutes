using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Meeting_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SO CONVOLUTED, OMG  Im sure there was a cleaner way to do this, I started with these stupid nested cases and couldn't stop :(

            Dictionary<string, string> teamMember = new Dictionary<string, string>();
            teamMember.Add("Arnold Palmer", "Marketing");
            teamMember.Add("Ghost Dini", "Marketing");
            teamMember.Add("Boo Dini", "Marketing");
            teamMember.Add("Reggie Valentine", "Administration");
            teamMember.Add("Al Frieght", "Administration");
            teamMember.Add("Mac Tonight", "Administration");

            List<string> pickType = new List<string>() { "Marketing Team", "All Team", "Admin Team" };
            pickType.Add("1. Marketing Team");
            pickType.Add("2. Administration Team");
            pickType.Add("3. All Team");

            



            Console.WriteLine("Meeting Minutes Management Software");
            Console.WriteLine("\n***********************************");
            Console.WriteLine("\nMENU");
            Console.WriteLine("1.CREATE MEETING");
            Console.WriteLine("2.VIEW TEAM");
            Console.WriteLine("3.EXIT");
            Console.Write("Please make menu selection(Ex. Enter -> 1 or 2):  ");

            int pickOne = 0;
            pickOne = int.Parse(Console.ReadLine());
            switch (pickOne)
            {
                case 1:
                    Console.WriteLine("Create Meeting");
                    Console.WriteLine("What is the current date? EX.DDMMYY: ");
                    int meetingDate = int.Parse(Console.ReadLine());
                    StreamWriter writerInfo = new StreamWriter("Minutes" + meetingDate + ".txt");
                    using (writerInfo)
                    {
                        writerInfo.WriteLine("Butler Brokerage LLC. \r\n419 Lafayette Street \r\n\"Meeting Minutes\"");
                        Console.WriteLine("What is the name of team member recording minutes?  ");
                        string memberMinutes = Console.ReadLine();
                        writerInfo.WriteLine("Member recording minutes  " + memberMinutes);
                        Console.WriteLine("What team member is leading the meeting?  ");
                        string memberLeading = Console.ReadLine();
                        writerInfo.WriteLine("Member leading meeting " + memberLeading);
                        Console.WriteLine("What is the meeting type?\n1. Marketing Team\n2. All Team\n3. Admin Team");
                        string whichMeeting = Console.ReadLine();

                        switch (whichMeeting)
                        {
                            case "1":
                                writerInfo.WriteLine("Marketing Team");
                                writerInfo.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string topic = Console.ReadLine();
                                writerInfo.WriteLine("Meeting topic is: " + topic);
                                Console.WriteLine("Enter meeting notes here:");
                                string notes = Console.ReadLine();
                                writerInfo.WriteLine("Notes Taken: " + notes);
                                string notes2 = "";
                                break;
                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    notes2 = Console.ReadLine();
                                    notes2 = notes2.ToUpper();
                                    if (notes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newTopic = Console.ReadLine();
                                        writerInfo.WriteLine("Added Topic: " + newTopic);
                                        Console.WriteLine("Enter meeting notes here:");
                                        string newNotes = Console.ReadLine();
                                        writerInfo.WriteLine("Added Notes: " + newNotes);
                                    }

                                }
                                while (notes2 == "Y");
                                Console.WriteLine("All text has been written to file");
                            case "2":
                                writerInfo.WriteLine("All Team");
                                writerInfo.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string allTopic = Console.ReadLine();
                                writerInfo.WriteLine("Meeting topic is: " + allTopic);
                                Console.WriteLine("Enter meeting notes here:");
                                string allNotes = Console.ReadLine();
                                writerInfo.WriteLine("Notes Taken: " + allNotes);
                                string allNotes2 = "";
                                break;
                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    allNotes2 = Console.ReadLine();
                                    allNotes2 = notes2.ToUpper();
                                    if (notes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newTopic = Console.ReadLine();
                                        writerInfo.WriteLine("Added Topic: " + newTopic);
                                        Console.WriteLine("Enter meeting notes here:");
                                        string newNotes = Console.ReadLine();
                                        writerInfo.WriteLine("Added Notes: " + newNotes);
                                    }

                                }
                                while (notes2 == "Y");
                                Console.WriteLine("All text has been written to file");

                            case "3":
                                writerInfo.WriteLine("Admin Team");
                                writerInfo.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string adminTopic = Console.ReadLine();
                                writerInfo.WriteLine("Meeting topic is: " + adminTopic);
                                Console.WriteLine("Enter meeting notes here:");
                                string adminNotes = Console.ReadLine();
                                writerInfo.WriteLine("Notes Taken: " + adminNotes);
                                string adminNotes2 = "";
                                break;

                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    adminNotes2 = Console.ReadLine();
                                    adminNotes2 = notes2.ToUpper();
                                    if (notes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newTopic = Console.ReadLine();
                                        writerInfo.WriteLine("Added Topic: " + newTopic);
                                        Console.WriteLine("Enter meeting notes here:");
                                        string newNotes = Console.ReadLine();
                                        writerInfo.WriteLine("Added Notes: " + newNotes);
                                    }

                                }
                                while (notes2 == "Y");
                                Console.WriteLine("All text has been written to file");







                        }
                    }

                        break;
                       
                        
                        case 2:
                    Console.WriteLine("View Team");
                    Console.WriteLine("Which team would you like to view?");
                    foreach (string teamList in pickType)
                    {
                        Console.WriteLine(teamList);
                    }
                    string userTeamView = Console.ReadLine();
                    switch (userTeamView)
                    {
                        case "1":

                            foreach (KeyValuePair<string, string> printMarketing in teamMember)
                            {
                                if (printMarketing.Value == "Marketing")
                                {
                                    Console.WriteLine(printMarketing.Key);
                                }
                            }
                            break;

                        case "2":
                            foreach (KeyValuePair<string, string> printAdmin in teamMember)
                            {
                                if (printAdmin.Value == "Administration")
                                {
                                    Console.WriteLine(printAdmin.Key);
                                }
                            }
                            break;
                        case "3":
                            foreach (KeyValuePair<string, string> printChoice in teamMember)
                            {
                                Console.WriteLine(printChoice.Key + " (" + printChoice.Value + ")");
                            }
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Goodbye");
                    break;
                   

            }



            }
        }
    }

