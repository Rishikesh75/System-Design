using System;
namespace ChainResponsiblityPattern
{

    public abstract class SupportHandler
    {
        public SupportHandler nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(int request);
    }


    public class LowLevelSupportHandler : SupportHandler
    {
        public  override void HandleRequest(int request)
        {
            Console.WriteLine("LowLevel support Event Handler");
        }

    }

    public class MidLevelSupportHandler : SupportHandler
    {

        public override void HandleRequest(int request)
        {
            Console.WriteLine("MiddleLevel support Event Handler");
        }
    }


    public class HighLevelSupportHandler : SupportHandler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine("HighLevel support Event Handler");
        }
    }



}


