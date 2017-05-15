using System;
using System.Diagnostics;

namespace System
{
    class Clock : IClock
    {
        private static readonly DateTimeOffset s_InitialTimeStamp;
        private static readonly Stopwatch s_OffsetStopwatch;
        private static IClock instance;

        public static IClock Instance
        {
            get
            {
                return instance;
            }
            protected set
            {
                instance = value ?? new Clock();
            }
        }

        public DateTimeOffset Time
        {
            get
            {
                return s_InitialTimeStamp.Add(s_OffsetStopwatch.Elapsed);
            }
        }

        static Clock()
        {
            s_InitialTimeStamp = DateTimeOffset.Now;
            s_OffsetStopwatch = Stopwatch.StartNew();
            instance = new Clock();
        }

        protected Clock()
        {
        }

        public override string ToString()
        {
            return s_InitialTimeStamp.ToString();
        }
    }
}
