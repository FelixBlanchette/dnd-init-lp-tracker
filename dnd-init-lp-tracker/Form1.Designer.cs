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
        ((System.ComponentModel.ISupportInitialize)_lifePointsNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_initiativeCountNumeric).BeginInit();
        _controlPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _nextTurnButton
        // 
        _nextTurnButton.Location = new Point(70, 33);
        _nextTurnButton.Margin = new Padding(4, 5, 4, 5);
        _nextTurnButton.Name = "_nextTurnButton";
        _nextTurnButton.Size = new Size(140, 38);
        _nextTurnButton.TabIndex = 0;
        _nextTurnButton.Text = "Next Turn";
        _nextTurnButton.UseVisualStyleBackColor = true;
        // 
        // _nameTB
        // 
        _nameTB.Location = new Point(78, 207);
        _nameTB.Margin = new Padding(4, 5, 4, 5);
        _nameTB.Name = "_nameTB";
        _nameTB.Size = new Size(141, 31);
        _nameTB.TabIndex = 1;
        _nameTB.TextChanged += NameTB_TextChanged;
        // 
        // _nameLbl
        // 
        _nameLbl.AutoSize = true;
        _nameLbl.Location = new Point(11, 213);
        _nameLbl.Margin = new Padding(4, 0, 4, 0);
        _nameLbl.Name = "_nameLbl";
        _nameLbl.Size = new Size(59, 25);
        _nameLbl.TabIndex = 2;
        _nameLbl.Text = "Name";
        // 
        // _lifePointsNumeric
        // 
        _lifePointsNumeric.Location = new Point(123, 292);
        _lifePointsNumeric.Margin = new Padding(4, 5, 4, 5);
        _lifePointsNumeric.Name = "_lifePointsNumeric";
        _lifePointsNumeric.Size = new Size(84, 31);
        _lifePointsNumeric.TabIndex = 3;
        _lifePointsNumeric.ValueChanged += IntNumericUpDown_ValueChanged;
        // 
        // _lifePointsLbl
        // 
        _lifePointsLbl.AutoSize = true;
        _lifePointsLbl.Location = new Point(11, 294);
        _lifePointsLbl.Margin = new Padding(4, 0, 4, 0);
        _lifePointsLbl.Name = "_lifePointsLbl";
        _lifePointsLbl.Size = new Size(94, 25);
        _lifePointsLbl.TabIndex = 4;
        _lifePointsLbl.Text = "Life points";
        // 
        // _initiativeCountNumeric
        // 
        _initiativeCountNumeric.Location = new Point(110, 248);
        _initiativeCountNumeric.Margin = new Padding(4, 5, 4, 5);
        _initiativeCountNumeric.Name = "_initiativeCountNumeric";
        _initiativeCountNumeric.Size = new Size(57, 31);
        _initiativeCountNumeric.TabIndex = 5;
        _initiativeCountNumeric.ValueChanged += IntNumericUpDown_ValueChanged;
        // 
        // _initiativeCountLbl
        // 
        _initiativeCountLbl.AutoSize = true;
        _initiativeCountLbl.Location = new Point(11, 254);
        _initiativeCountLbl.Margin = new Padding(4, 0, 4, 0);
        _initiativeCountLbl.Name = "_initiativeCountLbl";
        _initiativeCountLbl.Size = new Size(78, 25);
        _initiativeCountLbl.TabIndex = 6;
        _initiativeCountLbl.Text = "Initiative";
        // 
        // _resetButton
        // 
        _resetButton.Location = new Point(70, 93);
        _resetButton.Name = "_resetButton";
        _resetButton.Size = new Size(140, 34);
        _resetButton.TabIndex = 7;
        _resetButton.Text = "Reset";
        _resetButton.UseVisualStyleBackColor = true;
        // 
        // _addTracker
        // 
        _addTracker.Location = new Point(70, 150);
        _addTracker.Name = "_addTracker";
        _addTracker.Size = new Size(140, 34);
        _addTracker.TabIndex = 8;
        _addTracker.Text = "Add a tracker";
        _addTracker.UseVisualStyleBackColor = true;
        _addTracker.Click += AddTracker_Click;
        // 
        // _trackerContainer
        // 
        _trackerContainer.BackColor = SystemColors.Info;
        _trackerContainer.ForeColor = SystemColors.ControlText;
        _trackerContainer.Location = new Point(270, 38);
        _trackerContainer.Name = "_trackerContainer";
        _trackerContainer.Size = new Size(815, 658);
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
        _controlPanel.Location = new Point(12, 105);
        _controlPanel.Name = "_controlPanel";
        _controlPanel.Size = new Size(260, 356);
        _controlPanel.TabIndex = 10;
        // 
        // _controlContainerLbl
        // 
        _controlContainerLbl.AutoSize = true;
        _controlContainerLbl.Location = new Point(12, 75);
        _controlContainerLbl.Name = "_controlContainerLbl";
        _controlContainerLbl.Size = new Size(79, 25);
        _controlContainerLbl.TabIndex = 11;
        _controlContainerLbl.Text = "Controls";
        // 
        // _trackerContainerLbl
        // 
        _trackerContainerLbl.AutoSize = true;
        _trackerContainerLbl.Location = new Point(270, 10);
        _trackerContainerLbl.Name = "_trackerContainerLbl";
        _trackerContainerLbl.Size = new Size(74, 25);
        _trackerContainerLbl.TabIndex = 12;
        _trackerContainerLbl.Text = "Trackers";
        // 
        // _mainContainer
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1143, 732);
        Controls.Add(_trackerContainerLbl);
        Controls.Add(_controlContainerLbl);
        Controls.Add(_controlPanel);
        Controls.Add(_trackerContainer);
        Margin = new Padding(4, 5, 4, 5);
        NameInput = "_mainContainer";
        Text = "Initiative & Life points Tracker";
        ((System.ComponentModel.ISupportInitialize)_lifePointsNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)_initiativeCountNumeric).EndInit();
        _controlPanel.ResumeLayout(false);
        _controlPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button _resetButton;
    private Button _addTracker;
    private Panel _trackerContainer;
    private Panel _controlPanel;
    private Label _controlContainerLbl;
    private Label _trackerContainerLbl;
}
