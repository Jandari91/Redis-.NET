using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_WPF.Models
{
    public class QueueItem
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public QueueItem(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
