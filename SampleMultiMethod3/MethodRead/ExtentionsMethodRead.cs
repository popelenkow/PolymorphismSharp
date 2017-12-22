﻿using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodRead
{
    static class ExtentionsMethodRead
    {
        private static DispatcherMultiMethod<IMethodRead<IA>, string> Dispatcher { get; set; }
        static ExtentionsMethodRead()
        {
            Dispatcher = new DispatcherMultiMethod<IMethodRead<IA>, string>();
        }
        public static string Read(this IA model)
        {
            return Dispatcher.GetMethod(model)
                             .Call(model);
        }
    }
}