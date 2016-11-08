﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RobotServer.Types
{
    public class Vector6D
    {
        private double _x;

        /// <summary>
        /// X component
        /// </summary>
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y { get; set; }

        public double Z { get; set; }

        public double RX { get; set; }

        public double RY { get; set; }

        public double RZ { get; set; }

        

        /// <summary>
        /// Vector in 6 dimentions describing a Universal Robotics Robot value
        /// </summary>
        /// <param name="x">X component in mm</param>
        /// <param name="y">Y component in mm</param>
        /// <param name="z">Z component in mm</param>
        /// <param name="rx"></param>
        /// <param name="ry"></param>
        /// <param name="rz"></param>
        public Vector6D(double x, double y, double z, double rx, double ry, double rz)
        {
            X = x;
            Y = y;
            Z = z;
            RX = rx;
            RY = ry;
            RZ = rz; 
        }
        
    }
}