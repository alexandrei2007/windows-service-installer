using log4net;
using ServiceSample.Infrastructure;
using System.ServiceProcess;

namespace ServiceSample
{
    public partial class LogService : ServiceBase
    {
        public LogService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var log = LogManager.GetLogger(typeof(LogService).FullName);
            log.Info("Service started");

            new JobsBootLoader().Start();
        }

        protected override void OnStop()
        {
            var log = LogManager.GetLogger(typeof(LogService).FullName);
            log.Info("Service stopped");
        }
    }
}
