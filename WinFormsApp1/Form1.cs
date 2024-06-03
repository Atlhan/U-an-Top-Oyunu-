namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5 , can = 3;
        
        private void CarpmaOlay�()
        {
            // �st �arpma
            if (ball.Top <= �st.Bottom)
                yerY = yerY * -1;

            // kontrole �arpma olay�
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
                yerY = yerY * -1;

            // sa� kenara �arpma
            else if (ball.Right >= sa�.Left)
                yerX = yerX * -1;
            // sol kenara �arpma olay�
            else if (ball.Left <= sol.Right)
                yerX = yerX * -1;
        }
        private void YanmaOlay� (object sender,EventArgs e)
        {
            if (ball.Top >= sa�.Bottom)
            {
                if (can > 0 )
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yand�n kalan can >=" + can.ToString());
                    Form1_Load(sender, e);
                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti", "",MessageBoxButtons.OK);
                }
            }
            label1.Text = can.ToString();
        }
        private void TopBasa ()
        {
            ball.Location = new Point(252, 156);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TopBasa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlay�();
            YanmaOlay�(sender,e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}
