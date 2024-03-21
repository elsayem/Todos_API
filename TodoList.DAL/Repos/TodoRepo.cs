using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Data.Context;
using TodoList.DAL.Data.Models;

namespace TodoList.DAL.Repos
{
    public class TodoRepo : ITodoRepo
    {
        private readonly TodosContext db;
        public TodoRepo(TodosContext _db)
        {
            db = _db;

        }

        public IEnumerable<Todo> GetAll()
        {
            var Todos = db.Todos.ToList();

            return Todos;
        }

        public Todo? GetById(int id)
        {
            return db.Todos.Find(id);

        }

        public void Create(Todo _todo)
        {
            db.Todos.Add(_todo);
            db.SaveChanges();

        }
        public void Update(Todo _todo)
        {
            db.Todos.Update(_todo);
            db.SaveChanges();

        }

        public void Delete(Todo _todo)
        {
            db.Todos.Remove(_todo);
            db.SaveChanges();
        }

    }
}
