namespace win_form_math_quiz;

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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        timeLabel = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        plusRightLabel = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        sum = new System.Windows.Forms.NumericUpDown();
        difference = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        minusRightLabel = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        minusLeftLabel = new System.Windows.Forms.Label();
        product = new System.Windows.Forms.NumericUpDown();
        label8 = new System.Windows.Forms.Label();
        timeRightLabel = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        timesLeftLabel = new System.Windows.Forms.Label();
        quotient = new System.Windows.Forms.NumericUpDown();
        label12 = new System.Windows.Forms.Label();
        divideRightLabel = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        divideLeftLabel = new System.Windows.Forms.Label();
        startButton = new System.Windows.Forms.Button();
        plusLeftLabel = new System.Windows.Forms.Label();
        dateLabel = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
        ((System.ComponentModel.ISupportInitialize)product).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
        SuspendLayout();
        // 
        // timeLabel
        // 
        timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
        timeLabel.Location = new System.Drawing.Point(273, 9);
        timeLabel.Name = "timeLabel";
        timeLabel.Size = new System.Drawing.Size(200, 30);
        timeLabel.TabIndex = 0;
        timeLabel.Click += label1_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
        label1.Location = new System.Drawing.Point(171, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(96, 30);
        label1.TabIndex = 1;
        label1.Text = "Time Left";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(116, 75);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(60, 50);
        label2.TabIndex = 3;
        label2.Text = "+";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // plusRightLabel
        // 
        plusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        plusRightLabel.Location = new System.Drawing.Point(182, 75);
        plusRightLabel.Name = "plusRightLabel";
        plusRightLabel.Size = new System.Drawing.Size(60, 50);
        plusRightLabel.TabIndex = 4;
        plusRightLabel.Text = "?";
        plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(248, 75);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(60, 50);
        label4.TabIndex = 5;
        label4.Text = "=";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // sum
        // 
        sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        sum.Location = new System.Drawing.Point(314, 82);
        sum.Name = "sum";
        sum.Size = new System.Drawing.Size(100, 39);
        sum.TabIndex = 1;
        sum.ValueChanged += answer_Enter;
        // 
        // difference
        // 
        difference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        difference.Location = new System.Drawing.Point(314, 127);
        difference.Name = "difference";
        difference.Size = new System.Drawing.Size(100, 39);
        difference.TabIndex = 2;
        difference.ValueChanged += answer_Enter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(248, 120);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(60, 50);
        label3.TabIndex = 10;
        label3.Text = "=";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // minusRightLabel
        // 
        minusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        minusRightLabel.Location = new System.Drawing.Point(182, 120);
        minusRightLabel.Name = "minusRightLabel";
        minusRightLabel.Size = new System.Drawing.Size(60, 50);
        minusRightLabel.TabIndex = 9;
        minusRightLabel.Text = "?";
        minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(116, 120);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(60, 50);
        label6.TabIndex = 8;
        label6.Text = "-";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // minusLeftLabel
        // 
        minusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        minusLeftLabel.Location = new System.Drawing.Point(50, 120);
        minusLeftLabel.Name = "minusLeftLabel";
        minusLeftLabel.Size = new System.Drawing.Size(60, 50);
        minusLeftLabel.TabIndex = 7;
        minusLeftLabel.Text = "?";
        minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // product
        // 
        product.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        product.Location = new System.Drawing.Point(314, 173);
        product.Name = "product";
        product.Size = new System.Drawing.Size(100, 39);
        product.TabIndex = 3;
        product.ValueChanged += answer_Enter;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(248, 166);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(60, 50);
        label8.TabIndex = 15;
        label8.Text = "=";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // timeRightLabel
        // 
        timeRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        timeRightLabel.Location = new System.Drawing.Point(182, 166);
        timeRightLabel.Name = "timeRightLabel";
        timeRightLabel.Size = new System.Drawing.Size(60, 50);
        timeRightLabel.TabIndex = 14;
        timeRightLabel.Text = "?";
        timeRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(116, 166);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(60, 50);
        label10.TabIndex = 13;
        label10.Text = "X";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // timesLeftLabel
        // 
        timesLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        timesLeftLabel.Location = new System.Drawing.Point(50, 166);
        timesLeftLabel.Name = "timesLeftLabel";
        timesLeftLabel.Size = new System.Drawing.Size(60, 50);
        timesLeftLabel.TabIndex = 12;
        timesLeftLabel.Text = "?";
        timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // quotient
        // 
        quotient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        quotient.Hexadecimal = true;
        quotient.Location = new System.Drawing.Point(314, 218);
        quotient.Name = "quotient";
        quotient.Size = new System.Drawing.Size(100, 39);
        quotient.TabIndex = 4;
        quotient.ValueChanged += answer_Enter;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(248, 211);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(60, 50);
        label12.TabIndex = 20;
        label12.Text = "=";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // divideRightLabel
        // 
        divideRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        divideRightLabel.Location = new System.Drawing.Point(182, 211);
        divideRightLabel.Name = "divideRightLabel";
        divideRightLabel.Size = new System.Drawing.Size(60, 50);
        divideRightLabel.TabIndex = 19;
        divideRightLabel.Text = "?";
        divideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label14
        // 
        label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label14.Location = new System.Drawing.Point(116, 211);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(60, 50);
        label14.TabIndex = 18;
        label14.Text = "÷";
        label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // divideLeftLabel
        // 
        divideLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        divideLeftLabel.Location = new System.Drawing.Point(50, 211);
        divideLeftLabel.Name = "divideLeftLabel";
        divideLeftLabel.Size = new System.Drawing.Size(60, 50);
        divideLeftLabel.TabIndex = 17;
        divideLeftLabel.Text = "?";
        divideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // startButton
        // 
        startButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        startButton.Location = new System.Drawing.Point(131, 289);
        startButton.Name = "startButton";
        startButton.Size = new System.Drawing.Size(210, 41);
        startButton.TabIndex = 0;
        startButton.Text = "Start the quiz";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButton_Click_1;
        // 
        // plusLeftLabel
        // 
        plusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        plusLeftLabel.Location = new System.Drawing.Point(50, 82);
        plusLeftLabel.Name = "plusLeftLabel";
        plusLeftLabel.Size = new System.Drawing.Size(60, 50);
        plusLeftLabel.TabIndex = 21;
        plusLeftLabel.Text = "?";
        plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dateLabel
        // 
        dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dateLabel.Location = new System.Drawing.Point(11, 14);
        dateLabel.Name = "dateLabel";
        dateLabel.Size = new System.Drawing.Size(138, 24);
        dateLabel.TabIndex = 22;
        dateLabel.Text = "?";
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(484, 361);
        Controls.Add(dateLabel);
        Controls.Add(plusLeftLabel);
        Controls.Add(startButton);
        Controls.Add(quotient);
        Controls.Add(label12);
        Controls.Add(divideRightLabel);
        Controls.Add(label14);
        Controls.Add(divideLeftLabel);
        Controls.Add(product);
        Controls.Add(label8);
        Controls.Add(timeRightLabel);
        Controls.Add(label10);
        Controls.Add(timesLeftLabel);
        Controls.Add(difference);
        Controls.Add(label3);
        Controls.Add(minusRightLabel);
        Controls.Add(label6);
        Controls.Add(minusLeftLabel);
        Controls.Add(sum);
        Controls.Add(label4);
        Controls.Add(plusRightLabel);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(timeLabel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Hunter Bird Math Quiz";
        ((System.ComponentModel.ISupportInitialize)sum).EndInit();
        ((System.ComponentModel.ISupportInitialize)difference).EndInit();
        ((System.ComponentModel.ISupportInitialize)product).EndInit();
        ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label dateLabel;

    private System.Windows.Forms.Label plusLeftLabel;

    private System.Windows.Forms.Button startButton;

    private System.Windows.Forms.NumericUpDown difference;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label minusRightLabel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label minusLeftLabel;
    private System.Windows.Forms.NumericUpDown product;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label timeRightLabel;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label timesLeftLabel;
    private System.Windows.Forms.NumericUpDown quotient;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label divideRightLabel;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label divideLeftLabel;

    private System.Windows.Forms.NumericUpDown sum;

    private System.Windows.Forms.Label plusRightLabel;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label timeLabel;

    #endregion
}