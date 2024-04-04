namespace Do_An_Tuyen_Dung
{
    partial class FYeuThich
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
            label13 = new Label();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AllowDrop = true;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(367, 15);
            label13.Name = "label13";
            label13.Size = new Size(472, 41);
            label13.TabIndex = 0;
            label13.Text = "Các Công Việc Mà Bạn Yêu Thích";
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label13);
            panel3.Location = new Point(1, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 80);
            panel3.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1180, 643);
            flowLayoutPanel1.TabIndex = 47;
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 721);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Name = "FYeuThich";
            Text = "FYeuThich";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label13;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}