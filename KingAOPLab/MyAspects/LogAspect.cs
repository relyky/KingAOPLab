using KingAOP.Aspects;
using System;

namespace KingAOPLab.MyAspects
{
    class LogAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnEntry");
            int num = 1;
            foreach (object arg in args.Arguments)
            {
                Console.WriteLine($"  參數[{num++}] {arg.GetType().Name} {arg.ToString()}");
            }
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnSuccess");
            if (args.ReturnValue == null)
                Console.WriteLine($"  執行結果 Nil");
            else
                Console.WriteLine($"  執行結果 {args.ReturnValue.GetType().Name} {args.ReturnValue.ToString()}");
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
