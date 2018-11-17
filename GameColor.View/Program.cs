using GameColor.Core.Constants;
using GameColor.Core.Interfaces;
using GameColor.Core.Services;
using Ninject;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GameColor.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var kernel = new StandardKernel().ConfigureDependencies();
            var isWindowsInitialization = args.Contains(MainArgs.IS_WIN_INITIALIZATION);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.GameColor(kernel.Get<IUserPresetService>(), 
                                                kernel.Get<IGamePresetService>(), 
                                                kernel.Get<ICommunicationService>(), 
                                                kernel.Get<IUserLoggingService>(), 
                                                kernel.Get<IConfigurationService>(),
                                                isWindowsInitialization));
        }

        static StandardKernel ConfigureDependencies(this StandardKernel kernel)
        {
            kernel.Bind<IConfigurationService>()
                  .To<ConfigurationService>()
                  .InSingletonScope()
                  .WithConstructorArgument("applicationExecutablePath", Application.ExecutablePath);

            kernel.Bind<ICommunicationService>()
                  .To<CommunicationService>()
                  .InSingletonScope();

            kernel.Bind<IUserPresetService>()
                  .To<UserPresetService>()
                  .InSingletonScope();

            kernel.Bind<IGamePresetService>()
                  .To<GamePresetService>()
                  .InSingletonScope();

            kernel.Bind<IUserLoggingService>()
                  .To<UserLoggingService>()
                  .InSingletonScope();

            return kernel;
        }
    }
}
