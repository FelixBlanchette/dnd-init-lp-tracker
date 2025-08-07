using System.ComponentModel;
using dnd_init_lp_tracker.models;

namespace dnd_init_lp_tracker;

static class Program
{

    public static BindingList<Tracker> Trackers { get; set; }
    [STAThread]
    static void Main()
    {
        Trackers = [];
        ApplicationConfiguration.Initialize();
        Application.Run(new _mainContainer());
    }
}