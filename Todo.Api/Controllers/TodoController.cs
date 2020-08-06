using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        /// <summary>
        /// 请求所有的todo 列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return Ok();
        }
        
        /// <summary>
        /// 添加一个 名为[name]的 todo列表
        /// </summary>
        /// <param name="name">待添加的todo 名称</param>
        /// <returns></returns>
        public ActionResult AddList(string name)
        {
            return Ok();
        }
    }
}