using KingAOP.Aspects;
using System;

namespace KingAOPLab.MyAspects
{
    class IgnoreAspect : OnMethodBoundaryAspect
    {
        //public override void OnEntry(MethodExecutionArgs args) {
        //    Console.WriteLine($"{args.Method.Name}::OnEntry → Ignore");
        //}

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine($"{args.Method.Name}::OnException → Ignore");
            args.FlowBehavior = FlowBehavior.Continue; // ingore the exception
        }
    }
}
