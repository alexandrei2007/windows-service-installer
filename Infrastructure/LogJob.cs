using log4net;
using Quartz;

namespace ServiceSample.Infrastructure
{
    [PersistJobDataAfterExecution()]
    [DisallowConcurrentExecution()]
    public class LogJob : IJob
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogJob).FullName);

        public void Execute(IJobExecutionContext context)
        {
            log.Info("Job executed");
        }
    }
}
