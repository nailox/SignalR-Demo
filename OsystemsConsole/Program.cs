using Microsoft.AspNet.SignalR.Client;
using Osystems;
using System;

namespace OsystemsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //send message to hub
            Console.WriteLine("enter \"q\" to quit application");
            string body;
            do
            {
                Console.WriteLine("Enter message:");

                body = Console.ReadLine();

                if (body.ToLower() == "q")
                {
                    Environment.Exit(0);
                }
        
                    Message message = new Message(body, DateTime.Now, false);

              
                    var connection = new HubConnection("http://localhost:20135");

                    var proxy = connection.CreateHubProxy("chatHub");

                    connection.Start().Wait();



                    if (connection.State == ConnectionState.Connected)
                    {
                        proxy.Invoke("receiveNotification", message);

                    }

                    //insert message in database
                    using (var db = new MsgContext())
                    {

                        db.Messages.Add(new Message(body, DateTime.Now, false));
                        db.SaveChanges();
                        Console.WriteLine("Message saved to DB");

                    }
             
            }
            while (!String.IsNullOrWhiteSpace(body) || body.ToLower() != "q");
        }
    }
}
