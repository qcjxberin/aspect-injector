﻿using System;

namespace AspectInjector.Broker
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class AdviceArgumentAttribute : Attribute
    {
        public AdviceArgumentSource Source { get; private set; }

        public AdviceArgumentAttribute(AdviceArgumentSource source)
        {
            Source = source;
        }
    }
}