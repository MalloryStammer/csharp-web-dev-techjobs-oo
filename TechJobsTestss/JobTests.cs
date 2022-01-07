using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job Job3 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );
            Assert.IsTrue(Job3.Name == "Product tester");
            Assert.IsTrue(Job3.EmployerName.ToString() == "ACME");
            Assert.IsTrue(Job3.EmployerLocation.ToString() == "Desert");
            Assert.IsTrue(Job3.JobType.ToString() == "Quality control");
            Assert.IsTrue(Job3.JobCoreCompetency.ToString() == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job Job4 = new Job
               (
               "Product tester",
               new Employer("ACME"),
               new Location("Desert"),
               new PositionType("Quality control"),
               new CoreCompetency("Persistence")
               );

            Job Job5 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );
            Assert.IsFalse(Job4.Equals(Job5));
            //should be false because IDs should not be the same
        }

        [TestMethod]
        public void TestToStringFormattedOutput()
        {
            //string label (like "ID: ") each line...
            Job Job6 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );

            string job6Formatted =
                (
                $"\n" +
                $"ID: {Job6.Id}\n" +
                $"Name: {Job6.Name}\n" +
                $"Employer: {Job6.EmployerName.Value}\n" +
                $"Location: {Job6.EmployerLocation.Value}\n" +
                $"Position Type: {Job6.JobType.Value}\n" +
                $"Core Competency: {Job6.JobCoreCompetency.Value}\n" +
                $"\n"
                );
            Assert.IsTrue(Job6.ToString().Equals(job6Formatted));
            Assert.IsTrue(Job6.ToString().StartsWith("\n"));
            Assert.IsTrue(Job6.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestEmptyField()
        {
            Job Job8 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("")
                );
            Job Job9 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location(""),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );
            Assert.AreEqual(Job8.ToString(),
               $"\n" +
               $"ID: 7\n" +
               $"Name: Product tester\n" +
               $"Employer: ACME\n" +
               $"Location: Desert\n" +
               $"Position Type: Quality control\n" +
               $"Core Competency: Data not available\n" +
               $"\n"
               );

            Assert.AreEqual(Job9.ToString(),
               $"\n" +
               $"ID: 8\n" +
               $"Name: Product tester\n" +
               $"Employer: ACME\n" +
               $"Location: Data not available\n" +
               $"Position Type: Quality control\n" +
               $"Core Competency: Persistence\n" +
               $"\n"
               );
        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?redirectedfrom=MSDN&view=visualstudiosdk-2022&viewFallbackFrom=mstest-net-1.2.0