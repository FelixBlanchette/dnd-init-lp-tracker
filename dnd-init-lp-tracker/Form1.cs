using System.ComponentModel;
using dnd_init_lp_tracker.models;

namespace dnd_init_lp_tracker;

public partial class _mainContainer : Form
{
    private string _nameInput;
    private int _initiativeCount;
    private int _lifePoints;
    private BindingList<Tracker> _listTrackers;

    public _mainContainer()
    {
        InitializeComponent();
        _nameInput = "";
        _initiativeCount = 0;
        _lifePoints = 0;
        _listTrackers = Program.Trackers;
        _listBox1.DisplayMember = "Name";
        _listBox1.DisplayMember = "InitiativeCount";
        _listBox1.DisplayMember = "LifePoints";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _listBox1.DataSource = _listTrackers;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string NameInput
    {
        get => _nameInput;
        private set => _nameInput = value;
    }

    public void AddTracker_Click(object sender, EventArgs e)
    {
        _listTrackers.Add(new Tracker(_nameInput, _initiativeCount, _lifePoints));
    }

    private void NameTB_TextChanged(object sender, EventArgs e)
    {
        TextBox? src = sender as TextBox;
        if (src != null)
        {
            _nameInput = src.Text;
        }
    }

    public void IntNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        NumericUpDown? src = sender as NumericUpDown;
        if (src != null)
        {
            if (src.Name.Equals("_lifePointsNumeric")) _lifePoints = (int)src.Value;
            else _initiativeCount = (int)src.Value;
        }
    }

    public void NextTurn_Click(object sender, EventArgs e)
    {
        if (_listTrackers == null) MessageBox.Show("You dont have any trackers...");
        MessageBox.Show("something's wrong");
    }
}