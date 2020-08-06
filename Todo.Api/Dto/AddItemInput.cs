using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Dto
{
    /// <summary>
    /// 用于添加todo项的输入
    /// </summary>
    public class AddItemInput
    {
        /// <summary>
        /// 待添加的项所属的list
        /// </summary>
        public Guid Uid { get; set; }
        /// <summary>
        /// 代办事项的内容
        /// </summary>
        public string Content { get; set; }
    }
}
