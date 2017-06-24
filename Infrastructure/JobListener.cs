using log4net;
using Quartz;

namespace ServiceSample.Infrastructure
{
    public class JobListener : IJobListener
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(JobListener).FullName);

        public string Name
        {
            get
            {
                return "Job listener";
            }
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            return;
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            log.Info("Job to be executed");
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            if (jobException != null)
            {
                log.Error("Job failed", jobException);
            }
            else
            {
                log.Info("Job executed");
            }
        }
    }
}
