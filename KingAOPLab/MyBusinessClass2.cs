﻿using KingAOP;
using KingAOPLab.MyAspects;
using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace KingAOPLab
{
    class MyBusinessClass2 : IDynamicMetaObjectProvider
    {
        [LogAspect(AspectPriority = 1)]
        [IgnoreAspect(AspectPriority = 2)]
        public MyFormData QryFormData(string a, int b, bool c)
        {
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            //throw new ApplicationException("例外測試");
            Console.WriteLine("Step 3");

            return new MyFormData() {
                a = a,
                b = b,
                c = c
            };
        }

        [LogAspect(AspectPriority = 1)]
        [IgnoreAspect(AspectPriority = 3)]
        public void SaveFormData(MyFormData formData)
        {
            Console.WriteLine("Step 1");
            Console.WriteLine("Step 2");
            throw new ApplicationException("例外測試");
            Console.WriteLine("Step 3");
        }

        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new AspectWeaver(parameter, this);
        }
    }

    class MyFormData
    {
        public string a { get; set; }
        public int b { get; set; }
        public bool c { get; set; }
    }
}