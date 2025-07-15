using System;

namespace dnd_init_lp_tracker.models;

public class LifePointsTracker
{
    private int _lifePoints;

    public LifePointsTracker(int lifePoints)
    {
        _lifePoints = lifePoints;
    }

    public int LifePoints
    {
        get => _lifePoints;
        private set => _lifePoints = value;
    }
}
