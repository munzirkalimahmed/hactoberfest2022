namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            LblDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}