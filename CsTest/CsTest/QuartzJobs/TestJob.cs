using System;
using System.Threading;
using Quartz;
using Spring.Scheduling.Quartz;

namespace CsTest.QuartzJobs
{
    public class TestJob : QuartzJobObject
    {
        private int time = 0;

        protected override void ExecuteInternal(IJobExecutionContext context)
        {
            Console.WriteLine(time);
            time++;

            Thread.Sleep(1000 * 60);


        }
    }
}
