namespace EditDistancesApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        labelInput1 = new Label();
        textBoxInput1 = new TextBox();
        labelInput2 = new Label();
        textBoxInput2 = new TextBox();
        labelLcs = new Label();
        labelLevenshtein = new Label();
        labelDamerauLevenshtein = new Label();
        SuspendLayout();
        // 
        // labelInput1
        // 
        labelInput1.AutoSize = true;
        labelInput1.Location = new Point(24, 24);
        labelInput1.Name = "labelInput1";
        labelInput1.Size = new Size(119, 15);
        labelInput1.TabIndex = 0;
        labelInput1.Text = "Erste Zeichenkette:";
        // 
        // textBoxInput1
        // 
        textBoxInput1.Location = new Point(24, 42);
        textBoxInput1.Name = "textBoxInput1";
        textBoxInput1.Size = new Size(420, 23);
        textBoxInput1.TabIndex = 1;
        textBoxInput1.TextChanged += InputTextChanged;
        // 
        // labelInput2
        // 
        labelInput2.AutoSize = true;
        labelInput2.Location = new Point(24, 82);
        labelInput2.Name = "labelInput2";
        labelInput2.Size = new Size(123, 15);
        labelInput2.TabIndex = 2;
        labelInput2.Text = "Zweite Zeichenkette:";
        // 
        // textBoxInput2
        // 
        textBoxInput2.Location = new Point(24, 100);
        textBoxInput2.Name = "textBoxInput2";
        textBoxInput2.Size = new Size(420, 23);
        textBoxInput2.TabIndex = 3;
        textBoxInput2.TextChanged += InputTextChanged;
        // 
        // labelLcs
        // 
        labelLcs.AutoSize = true;
        labelLcs.Location = new Point(24, 150);
        labelLcs.Name = "labelLcs";
        labelLcs.Size = new Size(49, 15);
        labelLcs.TabIndex = 4;
        labelLcs.Text = "LCS: 0";
        // 
        // labelLevenshtein
        // 
        labelLevenshtein.AutoSize = true;
        labelLevenshtein.Location = new Point(24, 180);
        labelLevenshtein.Name = "labelLevenshtein";
        labelLevenshtein.Size = new Size(104, 15);
        labelLevenshtein.TabIndex = 5;
        labelLevenshtein.Text = "Levenshtein: 0";
        // 
        // labelDamerauLevenshtein
        // 
        labelDamerauLevenshtein.AutoSize = true;
        labelDamerauLevenshtein.Location = new Point(24, 210);
        labelDamerauLevenshtein.Name = "labelDamerauLevenshtein";
        labelDamerauLevenshtein.Size = new Size(160, 15);
        labelDamerauLevenshtein.TabIndex = 6;
        labelDamerauLevenshtein.Text = "Damerau-Levenshtein: 0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 260);
        Controls.Add(labelDamerauLevenshtein);
        Controls.Add(labelLevenshtein);
        Controls.Add(labelLcs);
        Controls.Add(textBoxInput2);
        Controls.Add(labelInput2);
        Controls.Add(textBoxInput1);
        Controls.Add(labelInput1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Edit-Distanzen";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelInput1;
    private TextBox textBoxInput1;
    private Label labelInput2;
    private TextBox textBoxInput2;
    private Label labelLcs;
    private Label labelLevenshtein;
    private Label labelDamerauLevenshtein;
}
