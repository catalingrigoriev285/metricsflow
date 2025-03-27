namespace metricsflow.resources.interfaces.welcome
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            label_welcome = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.Font = new Font("Segoe UI", 12F);
            label_welcome.Location = new Point(12, 9);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(1012, 63);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "A digital platform for testing and assessing company employees. It offers customizable tests, automated scoring, performance tracking, and secure access, streamlining the evaluation process.";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Snow;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(871, 335);
            button1.Name = "button1";
            button1.Size = new Size(153, 59);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1036, 406);
            Controls.Add(button1);
            Controls.Add(label_welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcome";
            Text = "MetricsFlow";
            Load += Welcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label_welcome;
        private Button button1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}