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

        [TestMethod]
        public void Test_get_question_about_pain()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Да");
            String expected = "Боль какая? Острая, тупая, приступообразная или постоянная?";
            Assert.AreEqual(expected, actyal);
        }

        [TestMethod]
        public void Test_get_question_about_acute_pain()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Острая");
            String expected = "Боли когда начинаются? Во время приема пищи, ночью или постоянные?";
            Assert.AreEqual(expected, actyal);
        }

        [TestMethod]
        public void Test_get_question_about_blunt_pain()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Тупая");
            String expected = "Предварительный диагноз: хронический периодонтит.Для уточнения диагноза нужно сделать рентген и провести осмотр.";
            Assert.AreEqual(expected, actyal);
        }

        [TestMethod]
        public void Test_get_question_about_periodic_pain()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Приступообразная");
            String expected = "Предварительный диагноз: обострение хронического периодонтита.Для уточнения диагноза нужно сделать рентген и провести осмотр.";
            Assert.AreEqual(expected, actyal);
        }

        [TestMethod]
        public void Test_get_question_about_constant_pain()
        {
            terapevt_stom visit = new terapevt_stom();
            String actyal = visit.get_question("Постоянная");
            String expected = "Предварительный диагноз: периодонтит.Для уточнения диагноза нужно сделать рентген и провести осмотр.";
            Assert.AreEqual(expected, actyal);
        }
    }
}
