using DanceNotes.UI.Views;
using DanceNotes.UI.Views.Ballroom;
using DanceNotes.UI.Views.Latin;

namespace DanceNotes.Core
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("ChaChaCha", typeof(ChaChaChaPage));
            Routing.RegisterRoute("Rhumba", typeof(RhumbaPage));
            Routing.RegisterRoute("PasoDoble", typeof(PasoDoblePage));
            Routing.RegisterRoute("Samba", typeof(SambaPage));
            Routing.RegisterRoute("Jive", typeof(JivePage));
            Routing.RegisterRoute("Waltz", typeof(WaltzPage));
            Routing.RegisterRoute("Tango", typeof(TangoPage));
            Routing.RegisterRoute("QuickStep", typeof(QuickStepPage));
            Routing.RegisterRoute("Vienesse Waltz", typeof(VienesseWaltzPage));
            Routing.RegisterRoute("Foxtrot", typeof(FoxtrotPage));
            InitializeComponent();
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);
        }
    }
}