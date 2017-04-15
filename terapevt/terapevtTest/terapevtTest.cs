using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace terapevtTest
{
    [TestClass]
    public class terapevtTest
    {
        [TestMethod]
        public void Test_get_question_about_visit()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Здравствуйте");
            String expected = "Что Вас беспокоит? Зубная боль?";
            Assert.AreEqual(expected, actyal);
        }
    }
}
