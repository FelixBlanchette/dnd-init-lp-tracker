using System;

namespace dnd_init_lp_tracker.models;

public class Tracker
{
    private string _name;
    private int _initiativeCount;
    private int _lifePoints;
    private bool _isTurnChar;

    public Tracker(string name, int initiativeCount, int lifePoints)
    {
        _name = name;
        _initiativeCount = initiativeCount;
        _lifePoints = lifePoints;
        _isTurnChar = false;
    }

    public string Name { get; set; }
    public int InitiativeCount { get; set; }
    public int LifePoints { get; set; }
    public bool IsTurnChar { get; set; }
}
