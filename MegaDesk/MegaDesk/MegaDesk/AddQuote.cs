namespace MegaDesk;

public partial class AddQuote : Form {
    public AddQuote() {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void label5_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void label2_Click(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_name_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_width_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_rush_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_depth_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_drawers_TextChanged(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void text_rush_TextChanged_1(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }

    private void submitbutton_Click(object sender, EventArgs e) {
        
        // I Should have a validation here, I am waiting for the next portion as I know I do infact need to validate everything at some point, I will most likely include them by bit,
        // and I would call myself rather lazy, I appologise.
        
        Desk.Material mat = new Desk.Material();
        Desk.Material.TryParse(text_material.Text, out mat);
        DeskQuote deskQuote = new DeskQuote(mat, Double.Parse(text_width.Text), Double.Parse(text_depth.Text), 1, int.Parse(text_drawers.Text), text_width.Text, int.Parse(text_rush.Text));

        Form1 form1 = (Form1)Tag;
        form1.Show();
        Close();



    }

    private void text_name_TextChanged_1(object sender, EventArgs e) {
        throw new System.NotImplementedException();
    }
}