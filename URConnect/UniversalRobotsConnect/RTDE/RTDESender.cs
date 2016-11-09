﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UniversalRobotsConnect
{
    class RTDESender
    {
        private List<byte[]> _dataToSend = new List<byte[]>();
        private NetworkStream _stream;
        private Thread _thread;
        List<KeyValuePair<string, string>> _rtdeOutputConfiguration;

        internal void SendData(byte[] data)
        {
            _dataToSend.Add(data);
        }

        internal RTDESender(NetworkStream stream, List<KeyValuePair<string, string>> rtdeOutputConfiguration)
        {
            _stream = stream;
            _rtdeOutputConfiguration = rtdeOutputConfiguration;
            _thread = new Thread(Run);
            _thread.Start();
        }

        private void Run()
        {
            while (true)
            {
                if (_dataToSend.Count > 0)
                {
                    Thread.Sleep(130);              //From experience we know the Universal Robotics robot doesnt like to recieve quicker than 125 ms
                    _stream.Write(_dataToSend[0], 0, _dataToSend[0].Length);
                    _dataToSend.RemoveAt(0);
                }

            }
        }
    }
}