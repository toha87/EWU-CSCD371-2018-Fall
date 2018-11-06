using System;
using System.Collections.Generic;
using System.Text;


namespace UniversityCourseWork
{

    public struct Test : ITest
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

    };


    public static class TestClassAndStruct
    {
        public static void ChangeValue(Test test)
        {
            test.MyProperty1 = 1;
            test.MyProperty2 = 2;
            test.MyProperty3 = 3;
        }

        public static void ChangeValueSuccess(ref Test test)
        {
            test.MyProperty1 = 99;
            test.MyProperty2 = 93;
            test.MyProperty3 = 94;
        }

        public static void ClassTaker(TheClass c)
        {
            c.willIChange = "Changed";
        }

        public static TheClass ClassInstanceCreate(TheClass c)
        {
            c = new TheClass() {ClassProperty = 42 };

            return c;

        }

        public static ITest ChangeValueInterface(ITest test)
        {
            test.MyProperty1 = 1;
            test.MyProperty2 = 2;
            test.MyProperty3 = 3;

            return test;
        }
    }

    public class TheClass
    {
        public string willIChange;
        public int ClassProperty { get; set; }
    }
}
