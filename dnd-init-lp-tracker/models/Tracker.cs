using System;

namespace dnd_init_lp_tracker.models;

public class Tracker
{
    private string _name;
    private InitiativeTracker _initiativeTracker;
    private LifePointsTracker _lifePointsTracker;

    public Tracker(string name, int initiativeCount, int lifePoints)
    {
        _name = name;
        _initiativeTracker = new InitiativeTracker(initiativeCount);
        _lifePointsTracker = new LifePointsTracker(lifePoints);
    }

    public string Name
    {
        get => _name;
        private set => _name = value;
    }

    public InitiativeTracker InitiativeTracker
    {
        get => _initiativeTracker;
        private set => _initiativeTracker = value;
    }

    public LifePointsTracker LifePointsTracker
    {
        get => _lifePointsTracker;
        private set => _lifePointsTracker = value;
    }
}
