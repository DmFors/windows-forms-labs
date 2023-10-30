namespace lab_5_temp
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(string infoText) : this()
        {
            infoLabel.Text = infoText;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
