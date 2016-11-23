using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Gift_Giver
{
    class Participant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Recipient { get; set; }
        public string DontMatchList { get; set; }
        private string[] DontMatch;
        public int EventID { get; set; }

        public Participant()
        {
        }

        public Participant(int id, string name, string recip, string dontmatch)
        {
            ID = id;
            Name = name;
            if (recip != null)
                Recipient = recip;
            if (dontmatch != null)
            {
                DontMatch = dontmatch.Split(',');
            }
        }
    }
}
