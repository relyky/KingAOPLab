using KingAOP.Aspects;
using System;

namespace KingAOPLab.MyAspects
{
    /// <summary>
    /// Ignore Exception Aspect
    /// </summary>
    class IgnoreAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnEntry");
            int num = 1;
            foreach(object arg in args.Arguments)
            {
                Console.WriteLine($"\t參數[{num++}] {arg.GetType().Name} {arg.ToString()}");
            }
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnSuccess");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnException");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnExit");
        }
    }
}
