using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EOrder
    {
        public int Id { get; set; }
        public string Cid { get; set; }
        public string ClientName { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }

        public EOrder()
        {
        }

        public EOrder(int id, string cid, string client_Name, DateTime? date, string status)
        {
            Id = id;
            Cid = cid;
            ClientName = client_Name;
            Date = date;
            Status = status;
        }
    }
}
