using System.ComponentModel;

namespace MegaDesk;

partial class AddQuote {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        text_name = new System.Windows.Forms.RichTextBox();
        text_width = new System.Windows.Forms.RichTextBox();
        text_depth = new System.Windows.Forms.RichTextBox();
        text_material = new System.Windows.Forms.RichTextBox();
        text_rush = new System.Windows.Forms.RichTextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        text_height = new System.Windows.Forms.RichTextBox();
        label7 = new System.Windows.Forms.Label();
        text_drawers = new System.Windows.Forms.RichTextBox();
        submitbutton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(48, 72);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(177, 30);
        label1.TabIndex = 1;
        label1.Text = "Customer Name";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label1.Click += label1_Click;
        // 
        // text_name
        // 
        text_name.Location = new System.Drawing.Point(232, 72);
        text_name.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_name.Name = "text_name";
        text_name.Size = new System.Drawing.Size(215, 28);
        text_name.TabIndex = 2;
        text_name.Text = "";
        // 
        // text_width
        // 
        text_width.Location = new System.Drawing.Point(232, 132);
        text_width.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_width.Name = "text_width";
        text_width.Size = new System.Drawing.Size(215, 28);
        text_width.TabIndex = 4;
        text_width.Text = "";
        // 
        // text_depth
        // 
        text_depth.Location = new System.Drawing.Point(232, 192);
        text_depth.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_depth.Name = "text_depth";
        text_depth.Size = new System.Drawing.Size(215, 28);
        text_depth.TabIndex = 12;
        text_depth.Text = "";
        // 
        // text_material
        // 
        text_material.Location = new System.Drawing.Point(232, 320);
        text_material.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_material.Name = "text_material";
        text_material.Size = new System.Drawing.Size(215, 28);
        text_material.TabIndex = 14;
        text_material.Text = "";
        // 
        // text_rush
        // 
        text_rush.Location = new System.Drawing.Point(232, 380);
        text_rush.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_rush.Name = "text_rush";
        text_rush.Size = new System.Drawing.Size(215, 28);
        text_rush.TabIndex = 15;
        text_rush.Text = "";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(48, 132);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(177, 30);
        label2.TabIndex = 16;
        label2.Text = "Width Inch.";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(48, 192);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(177, 30);
        label3.TabIndex = 17;
        label3.Text = "Depth Inch.";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(48, 440);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(177, 30);
        label4.TabIndex = 18;
        label4.Text = "Number of Drawers";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(48, 312);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(177, 30);
        label5.TabIndex = 19;
        label5.Text = "Material Type";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(48, 380);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(177, 30);
        label6.TabIndex = 20;
        label6.Text = "Rush Time";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // text_height
        // 
        text_height.Location = new System.Drawing.Point(232, 252);
        text_height.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_height.Name = "text_height";
        text_height.Size = new System.Drawing.Size(215, 28);
        text_height.TabIndex = 22;
        text_height.Text = "";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(48, 252);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(177, 30);
        label7.TabIndex = 23;
        label7.Text = "Height Inch.";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // text_drawers
        // 
        text_drawers.Location = new System.Drawing.Point(232, 440);
        text_drawers.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
        text_drawers.Name = "text_drawers";
        text_drawers.Size = new System.Drawing.Size(215, 28);
        text_drawers.TabIndex = 13;
        text_drawers.Text = "";
        // 
        // submitbutton
        // 
        submitbutton.Location = new System.Drawing.Point(232, 507);
        submitbutton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
        submitbutton.Name = "submitbutton";
        submitbutton.Size = new System.Drawing.Size(215, 64);
        submitbutton.TabIndex = 21;
        submitbutton.Text = "Submit";
        submitbutton.UseVisualStyleBackColor = true;
        // 
        // AddQuote
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(505, 624);
        Controls.Add(label7);
        Controls.Add(text_height);
        Controls.Add(submitbutton);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(text_rush);
        Controls.Add(text_material);
        Controls.Add(text_drawers);
        Controls.Add(text_depth);
        Controls.Add(text_width);
        Controls.Add(text_name);
        Controls.Add(label1);
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox text_name;
    private System.Windows.Forms.RichTextBox text_width;
    private System.Windows.Forms.RichTextBox text_depth;
    private System.Windows.Forms.RichTextBox text_material;
    private System.Windows.Forms.RichTextBox text_rush;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RichTextBox text_height;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.RichTextBox text_drawers;
    private System.Windows.Forms.Button submitbutton;

    #endregion
}