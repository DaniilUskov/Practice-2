﻿using System.ServiceModel;

namespace Client_server_chat
{
    public class ServerUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext operationContext { get; set; }
    }
}