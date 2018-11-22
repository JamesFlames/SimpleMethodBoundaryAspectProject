using System;
using System.Collections.Generic;
using System.Text;
using SimpleProject;

[assembly:TrackAllExceptionsInThisAssembly]

namespace SimpleProject
{
    class SimpleClass
    {
        public void SimpleMethod()
        {
            throw new Exception("thrown Exception");
        }
    }
}
