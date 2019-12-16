using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Service;
using Ninject;
using Presentation.Forms;
using Presentation.Presentors;
using DAL;
using Model.Entity;

namespace Feeder
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<ITimer>().To<WinFormTimer>();
            kernel.Bind<IMainForm>().To<MainFrame>();
            kernel.Bind<IFeederControl>().To<FeederControl>();
            kernel.Bind<IAddFeeder>().To<AddFeeder>();
            kernel.Bind<ICheckState>().To<CheckState>();
            kernel.Bind<ICheckTimetable>().To<CheckTimetable>();
            kernel.Bind<ICreateUser>().To<CreateUser>();
            kernel.Bind<IGetLogs>().To<GetLogs>();
            kernel.Bind<ISetTimetable>().To<SetTimetable>();
            kernel.Bind<IPourFeed>().To<PourFeed>();
            kernel.Bind<ISwitchMode>().To<SwitchMode>();
            kernel.Bind<IMakeRequest>().To<MakeRequest>();


            kernel.Bind<MainFormPresenter>().ToSelf();
            kernel.Bind<FeederControlPresentor>().ToSelf();
            kernel.Bind<AddFeederPresentor>().ToSelf();
            kernel.Bind<CheckStatePresentor>().ToSelf();
            kernel.Bind<CheckTimetablePresentor>().ToSelf();
            kernel.Bind<CreateUserPresentor>().ToSelf();
            kernel.Bind<SetTimeTablePresentor>().ToSelf();
            kernel.Bind<MakeRequestPresentor>().ToSelf();
            kernel.Bind<PourFeedPresentor>().ToSelf();
            kernel.Bind<SwitchModePresentor>().ToSelf();

            kernel.Bind<IRepository<string>>().To<RequestRepository>().InSingletonScope();
            kernel.Bind<IRepository<User>>().To<UserRepository>();
            kernel.Bind<IRepository<Model.Entity.Feeder>>().To<FeederRepository>();

            kernel.Bind<IMainFrameService>().To<MainFrameService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<MainFormPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());

        }
        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}
