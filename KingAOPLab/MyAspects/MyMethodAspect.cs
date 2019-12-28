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
            args.ReturnValue = "I am God.";
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("OnException");
            args.ReturnValue = "ABC";
            args.FlowBehavior = FlowBehavior.Continue;
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("OnExit");
        }
    }
}
