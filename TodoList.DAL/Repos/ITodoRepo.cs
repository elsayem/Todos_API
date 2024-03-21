using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Data.Models;

namespace TodoList.DAL.Repos
{
    public interface ITodoRepo
    {
        IEnumerable<Todo> GetAll();
        Todo? GetById(int id);
        void Create(Todo _todo);
        void Update(Todo _todo);
        void Delete(Todo _todo);
    }
}
