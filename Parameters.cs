﻿using System;

namespace Herring
{
    static class Parameters
    {
        public static int LogTimeUnit = 300;           // [s]
        public static int LogSamplingRate = 100;       // how many samples are taken for one time unit (should be at least 3)

        public static int InactivityThreshold_Idle = 30;
        public static int InactivityThreshold_Away = 120;   // [s] after this time the user is assumed away of the computer

        public static bool AutoScroll = false;
    }
}