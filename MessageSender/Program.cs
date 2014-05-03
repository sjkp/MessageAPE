using System;
using Microsoft.WindowsAzure.Jobs;
using MessageAPE.Model;

namespace MessageSender
{
    class Program
    {
        static void Main(string[] args)
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        public static void ProcessMessage([QueueInput("textmessages")] TextMessage message)
        {
            Console.WriteLine("Message type: {0}, recipient: {1}, message: {2}", message.Type, message.Recipient, message.Text);
        }
    }
}
