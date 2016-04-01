using Autofac;
using Serilog;

namespace Psibr.Platform.Logging.Serilog
{
    public class SerilogPlatformLoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAdapter<ILogger, IPlatformLogger>(serilogLogger =>
                new SerilogLoggingAdapter(serilogLogger));
        }
    }
}