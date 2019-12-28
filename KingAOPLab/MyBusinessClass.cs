using KingAOP;
using KingAOPLab.MyAspects;
using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace KingAOPLab
{
    class MyBusinessClass : IDynamicMetaObjectProvider
    {
        [MyMethodAspect]
        public string HelloWorldCall()
        {
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            throw new ApplicationException("測試例外！");
            Console.WriteLine("Step 3");
            return "Success Result";
        }

        [MyPropertyAspect]
        public string Foo
        {
            get;
            set;
        }

        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new AspectWeaver(parameter, this);
        }
    }
}