using System;
using System.Collections.Generic;
using System.Text;

namespace ClubBeykersStreet.DomainObjects
{
    public class ClubBeykerStreet : DomainObject
    {
        public string Name { get; set; }
        public string Address { get; set; }
   
        public string Datatime { get; set; }
        public string Time { get; set; }
    }
}
