using System;
using System.Collections.Generic;

namespace Todo.Api.Models
{
    public partial class TodoItem
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public bool Iscomplete { get; set; }
        public DateTime Ctime { get; set; }
        public DateTime Etime { get; set; }
    }
}
