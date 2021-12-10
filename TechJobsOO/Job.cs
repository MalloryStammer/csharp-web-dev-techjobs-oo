using System;
namespace TechJobsOO
{
    public class Job
        //thanks, Sally
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++
        }

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
