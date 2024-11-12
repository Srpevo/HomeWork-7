using HomeWork_7.Classes.job;

namespace HomeWork_7.Classes.Printer
{
    internal class Printer
    {
        private Queue<Job> Jobs = new Queue<Job>();

        public void AddJob(Job value)
        {
            Jobs.Enqueue(value);
        }
        public Job GetJob()
        {

            if (Jobs.Count > 0)
            {
                return Jobs.Dequeue();
            }
            else
            {
                throw new InvalidOperationException("there are no works left");
            }
            
        }
    }
}
