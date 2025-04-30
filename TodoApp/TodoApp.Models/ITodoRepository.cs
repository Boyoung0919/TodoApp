using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model); // input
        List<Todo> GetAll();  // output
    }
}
