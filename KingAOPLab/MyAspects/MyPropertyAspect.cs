using KingAOP.Aspects;
using System;

namespace KingAOPLab
{
    class MyPropertyAspect : LocationInterceptionAspect
    {
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            Console.WriteLine("OnGetValue" + args.Value ?? "Nil");
            base.OnGetValue(args);
            args.Value = "I am god!";
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            Console.WriteLine("OnSetValue" + args.Value ?? "Nil");
            args.Value = "I am deamon.";
            base.OnSetValue(args);
        }
    }
}