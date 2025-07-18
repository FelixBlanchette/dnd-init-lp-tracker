using dnd_init_lp_tracker.models;

namespace dnd_init_lp_tracker;

static class Program
{
    [STAThread]
    static void Main()
    {
        Trackers = [];
        ApplicationConfiguration.Initialize();
        Application.Run(new _mainContainer());
    }

    public static List<Tracker> Trackers { get; set; }
}