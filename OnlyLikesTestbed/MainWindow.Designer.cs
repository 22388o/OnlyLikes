namespace OnlyLikesTestbed
{
    partial class MainWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            timelineView = new DataGridView();
            readButton = new Button();
            connectButton = new Button();
            deserializeButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timelineView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(timelineView, 1, 0);
            tableLayoutPanel1.Controls.Add(readButton, 0, 1);
            tableLayoutPanel1.Controls.Add(connectButton, 0, 0);
            tableLayoutPanel1.Controls.Add(deserializeButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // timelineView
            // 
            timelineView.AllowUserToAddRows = false;
            timelineView.AllowUserToDeleteRows = false;
            timelineView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timelineView.Dock = DockStyle.Fill;
            timelineView.Location = new Point(203, 3);
            timelineView.Name = "timelineView";
            timelineView.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(timelineView, 4);
            timelineView.RowTemplate.Height = 25;
            timelineView.Size = new Size(594, 444);
            timelineView.TabIndex = 1;
            // 
            // readButton
            // 
            readButton.Location = new Point(3, 33);
            readButton.Name = "readButton";
            readButton.Size = new Size(75, 23);
            readButton.TabIndex = 0;
            readButton.Text = "&Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(3, 3);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 2;
            connectButton.Text = "&Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // deserializeButton
            // 
            deserializeButton.Location = new Point(3, 63);
            deserializeButton.Name = "deserializeButton";
            deserializeButton.Size = new Size(75, 23);
            deserializeButton.TabIndex = 3;
            deserializeButton.Text = "&Deserialize";
            deserializeButton.UseVisualStyleBackColor = true;
            deserializeButton.Click += deserializeButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainWindow";
            Text = "OnlyLikes Testbed";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timelineView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button readButton;
        private DataGridView timelineView;
        private Button connectButton;
        private Button deserializeButton;
    }
}