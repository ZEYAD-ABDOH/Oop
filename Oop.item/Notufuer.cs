using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.item
{
    internal class Notufuer : INotufuer
    {
        public Notufuer(string smtpSerre, int port, string senderAddrs, string senderPassWord)
        {
            SmtpSerre = smtpSerre;
            Port = port;
            SenderAddrs = senderAddrs;
            SenderPassWord = senderPassWord;
        }
        public string SmtpSerre { get; }
        public int Port { get; }
        public string SenderAddrs { get; }
        public string SenderPassWord { get; }
        void INotufuer.Notufuer(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Your Email Is'{SenderAddrs}'subject '{subject}'");
            Console.WriteLine($"'{body}'");
            Console.WriteLine($"PassWord IS :'{SenderPassWord}'");
            Console.WriteLine($"Meassge sent successfully to '{email}'");
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
