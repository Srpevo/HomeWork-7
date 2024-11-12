using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7.Classes.job
{
    internal class Job
    {
        private static int _nextId;
        public int Id { get; set; }
        public string Description { get; set; }

        public Job(string description)
        {
            Id = _nextId++;
            Description = description;
        }
    }
}
