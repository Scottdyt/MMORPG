﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{

    [Serializable]
    public class Message
    {
        public const int MsgHeaderSize = 4;

        public Message(Command c)
        {
            command = c;
        }

        public Command command;
    }
}
