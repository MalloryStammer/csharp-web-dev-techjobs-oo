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
            Job Job1 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );

            Assert.IsTrue(Job1.Name == "Product tester");
            Assert.IsTrue(Job1.EmployerName.ToString() == "ACME");
            Assert.IsTrue(Job1.EmployerLocation.ToString() == "Desert");
            Assert.IsTrue(Job1.JobType.ToString() == "Quality control");
            Assert.IsTrue(Job1.JobCoreCompetency.ToString() == "Persistence");
            Assert.IsNotNull(Job1.Id);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job Job1 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );

            Job Job2 = new Job
                (
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
                );

            Assert.IsFalse(Job1.Equals(Job2));
            //should be false because IDs should not be the same
        }


    }
}
