namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sol = new Label();
            üst = new Label();
            sağ = new Label();
            ball = new Button();
            kontrol = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // sol
            // 
            sol.BackColor = SystemColors.Highlight;
            sol.Location = new Point(24, 9);
            sol.Name = "sol";
            sol.Size = new Size(37, 439);
            sol.TabIndex = 0;
            sol.Text = "label1";
            // 
            // üst
            // 
            üst.BackColor = Color.Red;
            üst.Location = new Point(24, 9);
            üst.Name = "üst";
            üst.Size = new Size(710, 37);
            üst.TabIndex = 1;
            üst.Text = "label2";
            // 
            // sağ
            // 
            sağ.BackColor = Color.MediumTurquoise;
            sağ.Location = new Point(722, 9);
            sağ.Name = "sağ";
            sağ.Size = new Size(41, 439);
            sağ.TabIndex = 2;
            sağ.Text = "label3";
            sağ.Click += label3_Click;
            // 
            // ball
            // 
            ball.BackColor = SystemColors.ActiveCaptionText;
            ball.Location = new Point(401, 170);
            ball.Name = "ball";
            ball.Size = new Size(25, 25);
            ball.TabIndex = 3;
            ball.UseVisualStyleBackColor = false;
            // 
            // kontrol
            // 
            kontrol.BackColor = Color.Yellow;
            kontrol.Location = new Point(349, 424);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(105, 24);
            kontrol.TabIndex = 4;
            kontrol.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Location = new Point(814, 31);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.Location = new Point(848, 35);
            label1.Name = "label1";
            label1.Size = new Size(23, 29);
            label1.TabIndex = 6;
            label1.Text = "3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 597);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(kontrol);
            Controls.Add(ball);
            Controls.Add(sağ);
            Controls.Add(üst);
            Controls.Add(sol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Label sol;
        private Label üst;
        private Label sağ;
        private Button ball;
        private Button kontrol;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
