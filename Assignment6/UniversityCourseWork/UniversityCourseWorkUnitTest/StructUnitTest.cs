using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using UniversityCourseWork;
using static UniversityCourseWork.Schedule;


namespace UniversityCourseWorkUnitTest
{   
   [TestClass]
    public class StructUnitTest
    {
        [TestMethod]
        public void ParseStringForOneDaysOfTheWeekAndSetsEnumProperly()
        {
            Enum.TryParse("Monday", out WeekDays myStatus);
            Assert.AreEqual("Monday", myStatus.ToString());

        }

        [TestMethod]
        public void ParseStringForMultipleDaysOfTheWeekAndSetsEnumProperly()
        {
            string res = (WeekDays.Monday | WeekDays.Tuesday).ToString();

            Enum.TryParse(res, out WeekDays myStatus);
            Assert.AreEqual("Monday, Tuesday", myStatus.ToString());

        }


        [TestMethod]
        public void ParseStringToEnumQuarters()
        {
            Enum.TryParse("Spring", out Quarters myStatus);
            Assert.AreEqual("Spring", myStatus.ToString());
        }

        [TestMethod]
        public void GetStructSize()
        {
            int len = Marshal.SizeOf(typeof(Time));
            Assert.AreEqual(12, len);
        }

        [TestMethod]
        public void PassingStructToMethodAndChangingPropertyValue()
        {
            Test testStruct = new Test
            {
                MyProperty1 = 0,
                MyProperty2 = 0,
                MyProperty3 = 0
            };

            TestClassAndStruct.ChangeValue(testStruct);

            Assert.AreEqual(testStruct.MyProperty1, 0);

        }

        [TestMethod]
        public void PassingClassToMethodAndChangingPropertyValue()
        {
            TheClass testClass = new TheClass
            {
                willIChange = "Not Changed"
            };

            TestClassAndStruct.ClassTaker(testClass);

            Assert.AreEqual("Changed", testClass.willIChange);
        }

        [TestMethod]
        public void PassingStructToMethodChangeSuccesss()
        {
            Test testStruct = new Test
            {
                MyProperty1 = 42,
                MyProperty2 = 42,
                MyProperty3 = 42
            };

            TestClassAndStruct.ChangeValueSuccess(ref testStruct);

            Assert.AreEqual(testStruct.MyProperty1, 99);
        }

        [TestMethod]
        public void PassingClassToMethodAndCreatingNewInstanceOfClass_ThePassedInClassIsChangedInOriginalCallingMethod()
        {
            TheClass testClass = new TheClass();

            var res = TestClassAndStruct.ClassInstanceCreate(testClass);

            Assert.AreEqual(42, res.ClassProperty);
        }

        [TestMethod]
        public void CastingStructToInterfaceThenPassingThatInterfaceToMethodThatChangesPropertyValue()
        {
            ITest test = new Test();
            var res = TestClassAndStruct.ChangeValueInterface(test);
            Assert.AreEqual(res.MyProperty1, 1);
        }


    }
}
