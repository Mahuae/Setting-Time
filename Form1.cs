
namespace Setting_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeShow();
            timer1.Enabled = true;
        }

        private void TimeShow()
        {
            label1.Text = "NTP ʱ��ͬ��";
            DateTime dt = DateTime.Now;
            label2.Text = $"����ʱ�䣺{dt.ToString("yyyy-MM-dd HH:mm:ss")}";
            string? errorMessage = null;
            GetTime.Synchronization("ntp.aliyun.com", out dt, out errorMessage);
            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                label3.Text = $"ͬ��ʱ�䣺{dt.ToString("yyyy-MM-dd HH:mm:ss")}";
            }
        }

        private int fo = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (3 >= fo)
            {
                TimeShow();
                fo++;
            }
            else
            {
                Application.Exit();
            }

        }
    }
}