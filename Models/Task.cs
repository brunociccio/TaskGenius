using System.Collections.Generic;

namespace TaskGenius.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        // Construtor
        public Task(int id, string title, string description, DateTime dueDate)
        {
            TaskId = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        // Override do método ToString() para fornecer uma representação em string detalhada da tarefa
        public override string ToString()
        {
            string status = IsCompleted ? "Concluída" : "Pendente";
            return $"ID: {TaskId}, Título: {Title}, Descrição: {Description}, Data de Vencimento: {DueDate}, Status: {status}";
        }
    }
}
