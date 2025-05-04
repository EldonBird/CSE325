namespace win_form_math_quiz;

public partial class Form1 : Form {
    
    
    
    private Random rand = new Random();

    int addend1;
    int addend2;

    int minuend;
    int subtrahend;

    int multiplicand;
    int multiplier;

    int dividend;
    int divisor;

    private int timeLeft;
    
    private bool CheckTheAnswer()
    {
        if ((addend1 + addend2 == sum.Value)
            && (minuend - subtrahend == difference.Value)
            && (multiplicand * multiplier == product.Value)
            && (dividend / divisor == quotient.Value))
            return true;
        else
            return false;
    }

    public void StartTheQuiz() {


        addend1 = rand.Next(51);
        addend2 = rand.Next(51);

        plusLeftLabel.Text = addend1.ToString();
        plusRightLabel.Text = addend2.ToString();

        sum.Value = 0;

        minuend = rand.Next(1, 101);
        subtrahend = rand.Next(1, minuend);
        minusLeftLabel.Text = minuend.ToString();
        minusRightLabel.Text = subtrahend.ToString();
        difference.Value = 0;

        multiplicand = rand.Next(2, 11);
        multiplier = rand.Next(2, 11);
        timesLeftLabel.Text = multiplicand.ToString();
        timeRightLabel.Text = multiplier.ToString();
        product.Value = 0;

        divisor = rand.Next(2, 11);
        int temporaryQuotient = rand.Next(2, 11);
        dividend = divisor * temporaryQuotient;
        divideLeftLabel.Text = dividend.ToString();
        divideRightLabel.Text = divisor.ToString();
        quotient.Value = 0;
        
        timeLeft = 30;
        timeLabel.Text = "30 seconds"; 
        timer1.Start();
        
    }
    
    private void startButton_Click(object sender, EventArgs e)
    {
        StartTheQuiz();
        startButton.Enabled = false;           
    }
    
    public Form1() {
        InitializeComponent();
        
        dateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }
    

    private void label1_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void startButton_Click_1(object sender, EventArgs e) {
        StartTheQuiz();
        startButton.Enabled = false;
    }

    private void timer1_Tick_1(object sender, EventArgs e) {
        if (CheckTheAnswer())
        {
            // If CheckTheAnswer() returns true, then the user 
            // got the answer right. Stop the timer  
            // and show a MessageBox.
            timer1.Stop();
            MessageBox.Show("You got all the answers right!",
                "Congratulations!");
            startButton.Enabled = true;
        }
        else if (timeLeft > 0)
        {
            // If CheckTheAnswer() returns false, keep counting
            // down. Decrease the time left by one second and 
            // display the new time left by updating the 
            // Time Left label.
            timeLeft = timeLeft - 1;
            timeLabel.Text = timeLeft + " seconds";
        }
        else
        {
            // If the user ran out of time, stop the timer, show
            // a MessageBox, and fill in the answers.
            timer1.Stop();
            timeLabel.Text = "Time's up!";
            MessageBox.Show("You didn't finish in time.", "Sorry!");
            sum.Value = addend1 + addend2;
            difference.Value = minuend - subtrahend;
            product.Value = multiplicand * multiplier;
            quotient.Value = dividend / divisor;
            startButton.Enabled = true;
        }
    }

    private void answer_Enter(object sender, EventArgs e) {
        NumericUpDown answerBox = sender as NumericUpDown;

        if (answerBox != null)
        {
            int lengthOfAnswer = answerBox.Value.ToString().Length;
            answerBox.Select(0, lengthOfAnswer);
        }
    }
}