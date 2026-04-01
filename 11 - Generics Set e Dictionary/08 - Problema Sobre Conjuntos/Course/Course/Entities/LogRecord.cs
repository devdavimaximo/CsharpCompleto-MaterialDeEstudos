using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord logRecord = (LogRecord)obj;
            return UserName.Equals(logRecord.UserName);
        }
    }
}
