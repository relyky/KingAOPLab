using KingAOP.Aspects;
using System;

namespace KingAOPLab.MyAspects
{
    class MyMethodAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("OnEntry");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("OnSuccess");
            // 可在此把執行結果換掉。
            args.ReturnValue = "I am God.";
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("OnException");
            args.ReturnValue = "我來自OnException。";
            args.FlowBehavior = FlowBehavior.Return;
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("OnExit");
        }
    }
}
