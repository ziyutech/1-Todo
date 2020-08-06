using System;
using System.Collections.Generic;

namespace Todo.Api.Models
{
    public partial class TodoList
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public DateTime Ctime { get; set; }
    }
}
