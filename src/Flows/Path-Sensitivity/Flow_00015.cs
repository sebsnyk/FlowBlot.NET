﻿namespace FlowBlot.Flows
{
    public class Flow_00015
    {
        public const string ID = "00015"; 
        public const string Description = "A complex if FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            int x = 1;
            int y = 2;

            string input2 = System.String.Empty;
            string input = System.String.Empty;

            if(x > y)
            {
                input = System.Console.ReadLine();
            }
            else
            {
                input = "Default";
            }

            input2 = input;

            /*FLOW:Flow_00015 - A complex if FP taint propagation:OS Command Injection:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input2);
        }

    }
}