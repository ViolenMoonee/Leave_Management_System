using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolenMoonee_Leave_Managment_System
{
    internal class RequestLeave
    {
        string fullname, reason;
        DateTime start , end;

        public RequestLeave()
        {

        }

        public RequestLeave(string fullname, string reason, DateTime start, DateTime end)
        {
            this.Fullname = fullname;
            this.Reason = reason;
            this.Start = start;
            this.End = end;
        }

        public string Fullname { get => fullname; set => fullname = value; }
        public string Reason { get => reason; set => reason = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
    }
}
