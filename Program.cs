using System.ServiceProcess;

namespace ServiceSample
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new LogService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
