using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinger
{
    class Machine
    {
        public State state { get; set; }
        public string cluster { get; set; }
        public string address { get; set; }
        public string machineName { get; set; }
        public int id { get; set; }
        public Machine(string cluster,string add, string name, int id)
        {
            this.state = State.Unknown;
            this.cluster = cluster;
            this.address = add;
            this.machineName = name;
            this.id = id;
        }
        public override string ToString()
        {
            return machineName + " : " + address;
        }
    }
    enum State
    {
        Unknown,
        OK,
        Error
    }
}
