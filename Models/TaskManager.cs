using System;
using System.Collections.Generic;

namespace TaskGenius.Models
{
    public class TaskManager : Task
    {
        public List<Project> AllProjects { get; set; }

        // Construtor
        public TaskManager(int id, string title, string description, DateTime dueDate)
            : base(id, title, description, dueDate)
        {
            AllProjects = new List<Project>();
        }

        // Adicionar novo projeto
        public void AddProject(Project project)
        {
            AllProjects.Add(project);
        }

        // Remover projeto
        public void RemoveProject(Project project)
        {
            AllProjects.Remove(project);
        }
    }
}
