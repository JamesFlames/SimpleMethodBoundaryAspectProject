using System;
using MethodBoundaryAspect.Fody.Attributes;

namespace SimpleProject
{ 
    [AttributeUsage(AttributeTargets.Assembly)]
    public sealed class TrackAllExceptionsInThisAssemblyAttribute : OnMethodBoundaryAspect
    {

        public override void OnException(MethodExecutionArgs arg)
        {
            throw new Exception("MethodBoundaryAspect caught an exception");
        }
    }
}
