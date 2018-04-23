using DevExpress.ExpressApp;
using WinWebSolution.Module;

namespace WinWebSolution.Win {
    partial class WinWebSolutionWindowsFormsApplication: ISupportChangeDatabaseAtRuntime {
        public void ChangeTo(string newConnectionString) {
            IXpoDataStoreProvider dataStoreProvider = new ConnectionStringDataStoreProvider(newConnectionString);
            Setup(new ExpressApplicationSetupParameters(ApplicationName, CreateDefaultObjectSpaceProvider(dataStoreProvider), ControllersManager, DetailViewItemsFactory, Model, Modules));
            ShowViewStrategy.CloseAllWindows();
            ShowViewStrategy.ShowStartupWindow();
        }
    }
}
