using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Model
{
    public class Protokoll
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Bearbeiter { get; set; }
        public TicketStatus Status { get; set; }
        public int TicketId { get; set; }

        public Protokoll()
        {
        }
    }
}
