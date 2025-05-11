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
        text_drawers = new System.Windows.Forms.RichTextBox();
        text_material = new System.Windows.Forms.RichTextBox();
        text_rush = new System.Windows.Forms.RichTextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        submitbutton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(32, 55);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(262, 33);
        label1.TabIndex = 1;
        label1.Text = "Order Name";
        label1.Click += label1_Click;
        // 
        // text_name
        // 
        text_name.Location = new System.Drawing.Point(302, 55);
        text_name.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_name.Name = "text_name";
        text_name.Size = new System.Drawing.Size(377, 32);
        text_name.TabIndex = 2;
        text_name.Text = "";
        // 
        // text_width
        // 
        text_width.Location = new System.Drawing.Point(301, 105);
        text_width.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_width.Name = "text_width";
        text_width.Size = new System.Drawing.Size(377, 32);
        text_width.TabIndex = 4;
        text_width.Text = "";
        // 
        // text_depth
        // 
        text_depth.Location = new System.Drawing.Point(302, 161);
        text_depth.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_depth.Name = "text_depth";
        text_depth.Size = new System.Drawing.Size(377, 32);
        text_depth.TabIndex = 12;
        text_depth.Text = "";
        // 
        // text_drawers
        // 
        text_drawers.Location = new System.Drawing.Point(302, 221);
        text_drawers.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_drawers.Name = "text_drawers";
        text_drawers.Size = new System.Drawing.Size(377, 32);
        text_drawers.TabIndex = 13;
        text_drawers.Text = "";
        // 
        // text_material
        // 
        text_material.Location = new System.Drawing.Point(302, 284);
        text_material.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_material.Name = "text_material";
        text_material.Size = new System.Drawing.Size(377, 32);
        text_material.TabIndex = 14;
        text_material.Text = "";
        // 
        // text_rush
        // 
        text_rush.Location = new System.Drawing.Point(301, 345);
        text_rush.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
        text_rush.Name = "text_rush";
        text_rush.Size = new System.Drawing.Size(377, 32);
        text_rush.TabIndex = 15;
        text_rush.Text = "";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(32, 105);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(262, 33);
        label2.TabIndex = 16;
        label2.Text = "Width (inch)";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(32, 161);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(262, 33);
        label3.TabIndex = 17;
        label3.Text = "Depth (inch)";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(32, 221);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(262, 33);
        label4.TabIndex = 18;
        label4.Text = "Amount of Drawers";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(32, 284);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(262, 33);
        label5.TabIndex = 19;
        label5.Text = "Material";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(32, 345);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(262, 33);
        label6.TabIndex = 20;
        label6.Text = "Rush Order Delay";
        // 
        // submitbutton
        // 
        submitbutton.Location = new System.Drawing.Point(204, 435);
        submitbutton.Name = "submitbutton";
        submitbutton.Size = new System.Drawing.Size(290, 59);
        submitbutton.TabIndex = 21;
        submitbutton.Text = "Submit";
        submitbutton.UseVisualStyleBackColor = true;
        // 
        // AddQuote
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(812, 630);
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
        Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
        Text = "Add Quote";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button submitbutton;

    private System.Windows.Forms.RichTextBox text_rush;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.RichTextBox text_width;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox text_depth;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox text_drawers;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox text_material;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox text_name;

    #endregion
}