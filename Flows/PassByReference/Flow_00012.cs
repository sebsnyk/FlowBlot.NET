﻿using FlowBlot.Model;
using System;

namespace FlowBlot.Flows
{
    public class Flow_00012
    {
        public const string ID = "00012";
        public const string Description = "A pass by reference taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Blot blot = new Blot() { Name = String.Empty };
            Color(blot);
            System.Diagnostics.Process.Start(blot.Name);
        }

        public void Color(Blot blot)
        {
            blot.Name = System.Console.ReadLine();
        }
    }
}