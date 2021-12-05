﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ChatHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Client_server_chat.ServiceChat))) 
            {
                host.Open();
                Console.WriteLine("Хостинг стартовал");
                Console.ReadLine();
            }
        }
    }
}