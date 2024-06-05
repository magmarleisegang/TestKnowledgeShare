using NUnit.Framework;

namespace TestKnowledgeShare
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        //given an order input, when it is invalid, throws exception
        [Test]
        public void Givenanorderinput_whenitisinvalid_thenthrowsexception()
        {
            
        }

        //given an order input store it in the db
        //given an order input, when store it in the db fails, dont create a waybill
        //given an order input, when user chose courier, then create waybil
        //given an order input, when user chose collection, then dont create waybill
        //given an order create, send email to user
        //given an order create, when send email to user fails, still notify the warehouse
        //given an order is created, send notification to warehouse
    }
}