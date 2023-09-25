using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolenMoonee_Leave_Managment_System
{
    internal class FinalViewTable
    {
        string fullname, reason,comment ,apprej;
        DateTime start, end;

        public FinalViewTable()
        {

        }

        public FinalViewTable(string fullname, string reason, string comment, string apprej, DateTime start, DateTime end)
        {
            this.Fullname = fullname;
            this.Reason = reason;
            this.Comment = comment;
            this.Apprej = apprej;
            this.Start = start;
            this.End = end;
        }

        public string Fullname { get => fullname; set => fullname = value; }
        public string Reason { get => reason; set => reason = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Apprej { get => apprej; set => apprej = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
    }
}
