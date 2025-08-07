namespace dnd_init_lp_tracker;

partial class _mainContainer
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private Button _nextTurnButton;
    private TextBox _nameTB;
    private Label _nameLbl;
    private NumericUpDown _lifePointsNumeric;
    private Label _lifePointsLbl;
    private NumericUpDown _initiativeCountNumeric;
    private Label _initiativeCountLbl;
    private Button _resetButton;
    private Button _addTracker;
    private Panel _trackerContainer;
    private Panel _controlPanel;
    private Label _controlContainerLbl;
    private Label _trackerContainerLbl;
    private ListBox _listBox1;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _nextTurnButton = new Button();
        _nameTB = new TextBox();
        _nameLbl = new Label();
        _lifePointsNumeric = new NumericUpDown();
        _lifePointsLbl = new Label();
        _initiativeCountNumeric = new NumericUpDown();
        _initiativeCountLbl = new Label();
        _resetButton = new Button();
        _addTracker = new Button();
        _trackerContainer = new Panel();
        _controlPanel = new Panel();
        _controlContainerLbl = new Label();
        _trackerContainerLbl = new Label();
        _listBox1 = new ListBox();
        ((System.ComponentModel.ISupportInitialize)_lifePointsNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_initiativeCountNumeric).BeginInit();
        _trackerContainer.SuspendLayout();
        _controlPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _nextTurnButton
        // 
        _nextTurnButton.Location = new Point(49, 20);
        _nextTurnButton.Name = "_nextTurnButton";
        _nextTurnButton.Size = new Size(98, 23);
        _nextTurnButton.TabIndex = 0;
        _nextTurnButton.Text = "Next Turn";
        _nextTurnButton.UseVisualStyleBackColor = true;
        _nextTurnButton.Click += NextTurn_Click;
        // 
        // _nameTB
        // 
        _nameTB.Location = new Point(55, 124);
        _nameTB.Name = "_nameTB";
        _nameTB.Size = new Size(100, 23);
        _nameTB.TabIndex = 1;
        _nameTB.TextChanged += NameTB_TextChanged;
        // 
        // _nameLbl
        // 
        _nameLbl.AutoSize = true;
        _nameLbl.Location = new Point(8, 128);
        _nameLbl.Name = "_nameLbl";
        _nameLbl.Size = new Size(39, 15);
        _nameLbl.TabIndex = 2;
        _nameLbl.Text = "Name";
        // 
        // _lifePointsNumeric
        // 
        _lifePointsNumeric.Location = new Point(86, 175);
        _lifePointsNumeric.Name = "_lifePointsNumeric";
        _lifePointsNumeric.Size = new Size(59, 23);
        _lifePointsNumeric.TabIndex = 3;
        _lifePointsNumeric.ValueChanged += IntNumericUpDown_ValueChanged;
        // 
        // _lifePointsLbl
        // 
        _lifePointsLbl.AutoSize = true;
        _lifePointsLbl.Location = new Point(8, 176);
        _lifePointsLbl.Name = "_lifePointsLbl";
        _lifePointsLbl.Size = new Size(62, 15);
        _lifePointsLbl.TabIndex = 4;
        _lifePointsLbl.Text = "Life points";
        // 
        // _initiativeCountNumeric
        // 
        _initiativeCountNumeric.Location = new Point(77, 149);
        _initiativeCountNumeric.Name = "_initiativeCountNumeric";
        _initiativeCountNumeric.Size = new Size(40, 23);
        _initiativeCountNumeric.TabIndex = 5;
        _initiativeCountNumeric.ValueChanged += IntNumericUpDown_ValueChanged;
        // 
        // _initiativeCountLbl
        // 
        _initiativeCountLbl.AutoSize = true;
        _initiativeCountLbl.Location = new Point(8, 152);
        _initiativeCountLbl.Name = "_initiativeCountLbl";
        _initiativeCountLbl.Size = new Size(52, 15);
        _initiativeCountLbl.TabIndex = 6;
        _initiativeCountLbl.Text = "Initiative";
        // 
        // _resetButton
        // 
        _resetButton.Location = new Point(49, 56);
        _resetButton.Margin = new Padding(2);
        _resetButton.Name = "_resetButton";
        _resetButton.Size = new Size(98, 20);
        _resetButton.TabIndex = 7;
        _resetButton.Text = "Reset";
        _resetButton.UseVisualStyleBackColor = true;
        // 
        // _addTracker
        // 
        _addTracker.Location = new Point(49, 90);
        _addTracker.Margin = new Padding(2);
        _addTracker.Name = "_addTracker";
        _addTracker.Size = new Size(98, 20);
        _addTracker.TabIndex = 8;
        _addTracker.Text = "Add a tracker";
        _addTracker.UseVisualStyleBackColor = true;
        _addTracker.Click += AddTracker_Click;
        // 
        // _trackerContainer
        // 
        _trackerContainer.BackColor = SystemColors.Info;
        _trackerContainer.Controls.Add(_listBox1);
        _trackerContainer.ForeColor = SystemColors.ControlText;
        _trackerContainer.Location = new Point(189, 23);
        _trackerContainer.Margin = new Padding(2);
        _trackerContainer.Name = "_trackerContainer";
        _trackerContainer.Size = new Size(570, 395);
        _trackerContainer.TabIndex = 9;
        // 
        // _controlPanel
        // 
        _controlPanel.BackColor = SystemColors.Info;
        _controlPanel.Controls.Add(_addTracker);
        _controlPanel.Controls.Add(_resetButton);
        _controlPanel.Controls.Add(_initiativeCountLbl);
        _controlPanel.Controls.Add(_initiativeCountNumeric);
        _controlPanel.Controls.Add(_lifePointsLbl);
        _controlPanel.Controls.Add(_lifePointsNumeric);
        _controlPanel.Controls.Add(_nameLbl);
        _controlPanel.Controls.Add(_nameTB);
        _controlPanel.Controls.Add(_nextTurnButton);
        _controlPanel.Location = new Point(8, 63);
        _controlPanel.Margin = new Padding(2);
        _controlPanel.Name = "_controlPanel";
        _controlPanel.Size = new Size(182, 214);
        _controlPanel.TabIndex = 10;
        // 
        // _controlContainerLbl
        // 
        _controlContainerLbl.AutoSize = true;
        _controlContainerLbl.Location = new Point(8, 45);
        _controlContainerLbl.Margin = new Padding(2, 0, 2, 0);
        _controlContainerLbl.Name = "_controlContainerLbl";
        _controlContainerLbl.Size = new Size(52, 15);
        _controlContainerLbl.TabIndex = 11;
        _controlContainerLbl.Text = "Controls";
        // 
        // _trackerContainerLbl
        // 
        _trackerContainerLbl.AutoSize = true;
        _trackerContainerLbl.Location = new Point(189, 6);
        _trackerContainerLbl.Margin = new Padding(2, 0, 2, 0);
        _trackerContainerLbl.Name = "_trackerContainerLbl";
        _trackerContainerLbl.Size = new Size(49, 15);
        _trackerContainerLbl.TabIndex = 12;
        _trackerContainerLbl.Text = "Trackers";
        // 
        // listBox1
        // 
        _listBox1.FormattingEnabled = true;
        _listBox1.Location = new Point(6, 5);
        _listBox1.Name = "listBox1";
        _listBox1.Size = new Size(561, 379);
        _listBox1.TabIndex = 0;
        // 
        // _mainContainer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 439);
        Controls.Add(_trackerContainerLbl);
        Controls.Add(_controlContainerLbl);
        Controls.Add(_controlPanel);
        Controls.Add(_trackerContainer);
        Name = "_mainContainer";
        Text = "Initiative & Life points Tracker";
        ((System.ComponentModel.ISupportInitialize)_lifePointsNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)_initiativeCountNumeric).EndInit();
        _trackerContainer.ResumeLayout(false);
        _controlPanel.ResumeLayout(false);
        _controlPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

}
