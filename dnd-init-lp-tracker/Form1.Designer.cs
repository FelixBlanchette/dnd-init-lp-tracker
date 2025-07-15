namespace dnd_init_lp_tracker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Button _addTrackerButton;
    private Button _resetButton;

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
        _addTrackerButton = new Button();
        _resetButton = new Button();
        SuspendLayout();
        // 
        // _addTrackerButton
        // 
        _addTrackerButton.Location = new Point(100, 50);
        _addTrackerButton.Name = "AddTracker";
        _addTrackerButton.Size = new Size(100, 25);
        _addTrackerButton.TabIndex = 0;
        _addTrackerButton.Text = "Add a Tracker";
        _addTrackerButton.UseVisualStyleBackColor = true;
        //
        // _resetButton
        //
        _resetButton.Location = new Point(100, 100);
        _resetButton.Name = "Reset";
        _resetButton.Size = new Size(100, 25);
        _resetButton.TabIndex = 0;
        _resetButton.Text = "Reset";
        _resetButton.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 439);
        Controls.AddRange(_addTrackerButton, _resetButton);
        Name = "Initiative & Life points Tracker";
        Text = "Initiative & Life points Tracker";
        ResumeLayout(false);
    }

    #endregion
}
