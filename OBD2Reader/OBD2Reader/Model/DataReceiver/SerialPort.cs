﻿using System;

namespace OBD2Reader.Model.DataReceiver
{
    public class SerialPort : IByteSource
    {
        public int Read(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void Write(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public event EventHandler DataReceived;
    }
}