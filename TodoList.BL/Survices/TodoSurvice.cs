using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BL.DTOs;
using TodoList.DAL.Data.Models;
using TodoList.DAL.Repos;

namespace TodoList.BL.Survices
{
    public class TodoSurvice : ITodoSurvice
    {
        private readonly ITodoRepo db;
        public TodoSurvice(ITodoRepo _db)
        {
            db = _db;
        }
        public IEnumerable<TodoReadDto> GetAll()
        {
            var Todos = db.GetAll();
            return Todos.Select(todo => new TodoReadDto
            {
                Id = todo.Id,
                Name = todo.Name,
                Description = todo.Description,
                DeadLine = todo.DeadLine,

            });
        }
        public TodoReadDto? GetById(int id)
        {
            var todo = db.GetById(id);
            return new TodoReadDto()
            {
                Id = todo.Id,
                Name = todo.Name,
                Description = todo.Description,
                DeadLine = todo.DeadLine
            };
        }


        public int Add(TodoCreateDto _dto)
        {
            Todo todo = new Todo()
            {
                Name = _dto.Name,
                Description = _dto.Description,
                DeadLine = _dto.DeadLine,

            };
            db.Create(todo);
            return todo.Id;
        }
        public bool Update(int id,TodoUpdateDto _dto)
        {
            var todo = db.GetById(id);
            if (todo == null) return false;
            todo.Name = _dto.Name;
            todo.Description = _dto.Description;
            todo.DeadLine = _dto.DeadLine;

            return true;



        }
        public bool Delete(int id)
        {
            var todo = db.GetById(id);
            if (todo == null) return false;
            db.Delete(todo);
            return true;
        }
    }
}
