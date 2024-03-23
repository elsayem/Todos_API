using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Data.Context;
using TodoList.DAL.Repos;

namespace TodoList.DAL.Validators
{
    public class UniqueTodoNameAttribute : ValidationAttribute
    {       
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var name = value as string;
            //Get the the database to check if the name is exist before
            var db = validationContext.GetService<TodosContext>();
            var s = db.Todos.FirstOrDefault(t => t.Name == name);
            if (s != null)
            {
                return new ValidationResult("This Todo already exists !");
            }
            return ValidationResult.Success;

        }
    }
}
