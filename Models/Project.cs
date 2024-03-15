using System;
using System.Collections.Generic;

namespace TaskGenius.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public List<Task> Tasks { get; set; }

        // Propriedade internal para descrição interna do projeto
        internal string InternalDescription { get; set; }

        // Construtor
        public Project(int id, string title, string internalDescription)
        {
            ProjectId = id;
            Title = title;
            Tasks = new List<Task>();
            InternalDescription = internalDescription;
        }

        // Adicionar tarefa ao projeto
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        // Remover tarefa do projeto
        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }
    }
}

