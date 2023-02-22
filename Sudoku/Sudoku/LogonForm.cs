namespace Sudoku
{
    public partial class LogonForm : Form
    {
        public LogonForm()
        {
            InitializeComponent();
            this.Text = "1234";
            Label label1 = new Label();
            label1.Text = "First text in project";
            label1.Location = new Point(20, 20);
            label1.AutoSize = true;
            Controls.Add(label1);

        }
    }
}