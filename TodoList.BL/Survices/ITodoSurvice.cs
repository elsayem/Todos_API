using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BL.DTOs;
using TodoList.DAL.Data.Models;

namespace TodoList.BL.Survices
{
    public interface ITodoSurvice
    {
        IEnumerable<TodoReadDto> GetAll();
        TodoReadDto? GetById(int id);
        int Add(TodoCreateDto _dto);
        bool Update(int id,TodoUpdateDto _dto);
        bool Delete(int id);


    }
}
