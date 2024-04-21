using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dummy dummy = new Dummy(10, 0);
            Axe axe = new Axe(2, 2);
            Hero hero = new Hero("SuperPuperHero", axe);

            hero.Attack(dummy);

            var a = 1;


            Assert.AreEqual(dummy.Health, 8);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Dummy dummy = new Dummy(10, 0);
            Axe axe = new Axe(2, 2);
            Hero hero = new Hero("SuperPuperHero", axe);

            hero.Attack(dummy);

            Assert.AreEqual(1, axe.DurabilityPoints);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Dummy dummy = new Dummy(10, 0);
            Axe axe = new Axe(2, 1);
            Hero hero = new Hero("SuperPuperHero", axe);
            hero.Attack(dummy);

            Assert.ThrowsException<InvalidOperationException>(() => axe.Attack(dummy), "Axe is broken.");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))] 
        public void TestMethod4()
        {
            Axe axe = new Axe(2, 2);
            Hero hero = new Hero("SuperPuperHero", axe);

            hero.Attack(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod5()
        {
            Dummy dummy = new Dummy(10, 5);

            int experience = dummy.GiveExperience();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod6()
        {
            Dummy dummy = new Dummy(0, 0);

            dummy.TakeAttack(1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod7()
        {
            Dummy dummy = new Dummy(10, 0);
            Axe axe = new Axe(2, 0);
            Hero hero = new Hero("SuperPuperHero", axe);

            hero.Attack(dummy);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod8()
        {
            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(2, 2);
            Hero hero = new Hero("SuperPuperHero", axe);

            hero.Attack(dummy);
        }

    }
}
