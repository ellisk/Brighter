using System;
using paramore.brighter.commandprocessor.timeoutpolicy.Handlers;

namespace paramore.brighter.commandprocessor.timeoutpolicy.Attributes
{
    public class TimeoutPolicyAttribute : RequestHandlerAttribute
    {
        private readonly int milliseconds;

        public TimeoutPolicyAttribute(int milliseconds, int step, HandlerTiming timing = HandlerTiming.Before) : base(step, timing)
        {
            this.milliseconds = milliseconds;
        }

        public override object[] InitializerParams()
        {
            return new object[] {milliseconds};
        }

        public override Type GetHandlerType()
        {
            return typeof (TimeoutPolicyHandler<>);
        }
    }
}