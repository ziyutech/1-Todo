using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Api.Models;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // 依赖注入的写法
        private readonly todoContext todoContext;
        /// <summary>
        /// 注入数据库对象实例
        /// </summary>
        /// <param name="_todoContext">数据库</param>
        public TodoController(todoContext _todoContext)
        {
            todoContext = _todoContext; 
        }
        /// <summary>
        /// 请求所有的todo 列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            //显示所有todolist
            return Ok(todoContext.TodoList.ToList());
        }
        
        /// <summary>
        /// 添加一个 名为[name]的 todo列表
        /// </summary>
        /// <param name="name">待添加的todo 名称</param>
        /// <returns></returns>
        public ActionResult AddList(string name)
        {
            //添加一个todolist
            todoContext.TodoList.Add(new TodoList() { 
                Ctime=DateTime.Now,
                Name=name,
                Uid=Guid.NewGuid()
            });
            //将提交的数据库添加操作 提交到数据库
            todoContext.SaveChanges();
            //没有任何返回值表示添加成功
            return Ok();
        }

    }
}