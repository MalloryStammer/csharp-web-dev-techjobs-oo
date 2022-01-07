using System;
using System.Collections.Generic;

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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.


        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override string ToString()
        {
            string jobOutput =
                
                $"\n" +
                $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Employer: {EmployerName.ToString()}\n" +
                $"Location: {EmployerLocation.ToString()}\n" +
                $"Position Type: {JobType.ToString()}\n" +
                $"Core Competency: {JobCoreCompetency.ToString()}\n" +
                $"\n"
                ;


            return jobOutput;
        }
    }
}
