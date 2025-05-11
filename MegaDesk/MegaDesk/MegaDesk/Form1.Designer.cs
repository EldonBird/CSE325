namespace MegaDesk;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        quotebutton = new System.Windows.Forms.Button();
        viewbutton = new System.Windows.Forms.Button();
        searchbutton = new System.Windows.Forms.Button();
        exitbutton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // quotebutton
        // 
        quotebutton.Location = new System.Drawing.Point(12, 12);
        quotebutton.Name = "quotebutton";
        quotebutton.Size = new System.Drawing.Size(136, 57);
        quotebutton.TabIndex = 0;
        quotebutton.Text = "Add New Quote";
        quotebutton.UseVisualStyleBackColor = true;
        quotebutton.Click += quotebutton_Click;
        // 
        // viewbutton
        // 
        viewbutton.Location = new System.Drawing.Point(12, 75);
        viewbutton.Name = "viewbutton";
        viewbutton.Size = new System.Drawing.Size(136, 57);
        viewbutton.TabIndex = 1;
        viewbutton.Text = "View Quotes";
        viewbutton.UseVisualStyleBackColor = true;
        viewbutton.Click += button1_Click;
        // 
        // searchbutton
        // 
        searchbutton.Location = new System.Drawing.Point(12, 138);
        searchbutton.Name = "searchbutton";
        searchbutton.Size = new System.Drawing.Size(136, 57);
        searchbutton.TabIndex = 2;
        searchbutton.Text = "Search Button";
        searchbutton.UseVisualStyleBackColor = true;
        searchbutton.Click += searchbutton_Click;
        // 
        // exitbutton
        // 
        exitbutton.Location = new System.Drawing.Point(12, 201);
        exitbutton.Name = "exitbutton";
        exitbutton.Size = new System.Drawing.Size(136, 57);
        exitbutton.TabIndex = 3;
        exitbutton.Text = "Exit";
        exitbutton.UseVisualStyleBackColor = true;
        exitbutton.Click += exitbutton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(493, 279);
        Controls.Add(exitbutton);
        Controls.Add(searchbutton);
        Controls.Add(viewbutton);
        Controls.Add(quotebutton);
        Text = "MegaDesk";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button viewbutton;
    private System.Windows.Forms.Button searchbutton;

    private System.Windows.Forms.Button quotebutton;
    private System.Windows.Forms.Button exitbutton;

    #endregion
}