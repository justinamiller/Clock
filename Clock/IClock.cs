using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public interface IClock
    {
        DateTimeOffset Time { get; }
    }

}
