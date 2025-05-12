namespace MegaDesk;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void quotebutton_Click(object sender, EventArgs e) {
        AddQuote addQuote = new AddQuote();
        addQuote.Tag = this;
        addQuote.Show();
        Hide();
    }

    private void exitbutton_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void searchbutton_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }
}