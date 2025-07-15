using System;

namespace dnd_init_lp_tracker.models;

public class InitiativeTracker
{
    private int _initiative;

    public InitiativeTracker(int initiativeCount)
    {
        _initiative = initiativeCount;
    }

    public int Initiative
    {
        get => _initiative;
        private set => _initiative = value;
    }
}
