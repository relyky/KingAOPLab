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
            // 可在此把取回的值換掉。
            args.Value = "I am god!"; 
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            Console.WriteLine("OnSetValue" + args.Value ?? "Nil");
            // 可在此把欲設定的值換掉。
            args.Value = "I am deamon.";
            base.OnSetValue(args);
        }
    }
}