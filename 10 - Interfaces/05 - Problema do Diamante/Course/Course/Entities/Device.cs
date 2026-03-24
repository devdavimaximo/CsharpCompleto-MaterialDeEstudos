using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
