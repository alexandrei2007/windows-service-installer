using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;
using System;

namespace ServiceSample.Infrastructure
{
    public class JobsBootLoader
    {
        #region "Attributes"

        private ISchedulerFactory factory;
        private IScheduler scheduler;

        #endregion

        #region "Constructor"

        /// <summary>
        /// Constructor.
        /// </summary>
        public JobsBootLoader()
        {
            factory = new StdSchedulerFactory();

            scheduler = factory.GetScheduler();
            scheduler.ListenerManager.AddJobListener(new JobListener());
            scheduler.Start();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            // 1 minute trigger
            ITrigger trigger = new SimpleTriggerImpl("log-job-trigger", -1, new TimeSpan(0, 1, 0));

            // job
            IJobDetail jobDetail = new JobDetailImpl("log-job", typeof(LogJob));

            // schedule
            scheduler.ScheduleJob(jobDetail, trigger);
        }

        #endregion
    }
}
