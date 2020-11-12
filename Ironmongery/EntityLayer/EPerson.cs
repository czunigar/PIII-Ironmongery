using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public abstract class EPerson
    {
        public int Id { get; set; }
        public string Cid { get; set; }
        public string Name { get; set; }

        protected EPerson()
        {
        }

        protected EPerson(int id, string cid, string person_Name)
        {
            Id = id;
            Cid = cid;
            Name = person_Name;
        }

        public override string ToString()
        {
            return $"{Cid} - {Name}";
        }
    }
}
