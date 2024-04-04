namespace Do_An_Tuyen_Dung
{
    partial class FDangBai_NTD
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangBai_NTD));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pan_ThongTin = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel7 = new Panel();
            btn_TK = new Button();
            panel6 = new Panel();
            btn_LichSu = new Button();
            panel5 = new Panel();
            btn_UV = new Button();
            panel4 = new Panel();
            btn_DangBai = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            panel9 = new Panel();
            txtTenTK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            openFileDialog1 = new OpenFileDialog();
            guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(components);
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(pan_ThongTin);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.ForeColor = Color.FromArgb(0, 74, 173);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 725);
            panel1.TabIndex = 0;
            // 
            // pan_ThongTin
            // 
            pan_ThongTin.Anchor = AnchorStyles.None;
            pan_ThongTin.CustomizableEdges = customizableEdges4;
            pan_ThongTin.Location = new Point(188, 145);
            pan_ThongTin.Name = "pan_ThongTin";
            pan_ThongTin.ShadowDecoration.CustomizableEdges = customizableEdges5;
            pan_ThongTin.Size = new Size(962, 500);
            pan_ThongTin.TabIndex = 1;
            pan_ThongTin.Paint += pan_ThongTin_Paint;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_TK);
            panel7.Location = new Point(8, 346);
            panel7.Name = "panel7";
            panel7.Size = new Size(174, 52);
            panel7.TabIndex = 4;
            // 
            // btn_TK
            // 
            btn_TK.FlatStyle = FlatStyle.Flat;
            btn_TK.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TK.ForeColor = SystemColors.ButtonFace;
            btn_TK.Location = new Point(3, 0);
            btn_TK.Name = "btn_TK";
            btn_TK.Size = new Size(168, 49);
            btn_TK.TabIndex = 2;
            btn_TK.Text = "Tài Khoản";
            btn_TK.UseVisualStyleBackColor = true;
            btn_TK.Click += btn_TK_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_LichSu);
            panel6.Location = new Point(8, 288);
            panel6.Name = "panel6";
            panel6.Size = new Size(174, 52);
            panel6.TabIndex = 3;
            // 
            // btn_LichSu
            // 
            btn_LichSu.FlatStyle = FlatStyle.Flat;
            btn_LichSu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LichSu.ForeColor = SystemColors.ButtonFace;
            btn_LichSu.Location = new Point(3, 0);
            btn_LichSu.Name = "btn_LichSu";
            btn_LichSu.Size = new Size(168, 49);
            btn_LichSu.TabIndex = 1;
            btn_LichSu.Text = "Lịch Sử";
            btn_LichSu.UseVisualStyleBackColor = true;
            btn_LichSu.Click += btn_LichSu_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_UV);
            panel5.Location = new Point(8, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(174, 52);
            panel5.TabIndex = 2;
            // 
            // btn_UV
            // 
            btn_UV.FlatStyle = FlatStyle.Flat;
            btn_UV.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UV.ForeColor = SystemColors.ButtonFace;
            btn_UV.Location = new Point(3, 0);
            btn_UV.Name = "btn_UV";
            btn_UV.Size = new Size(168, 49);
            btn_UV.TabIndex = 0;
            btn_UV.Text = "Ứng Viên";
            btn_UV.UseVisualStyleBackColor = true;
            btn_UV.Click += btn_UV_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_DangBai);
            panel4.Location = new Point(8, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 52);
            panel4.TabIndex = 1;
            // 
            // btn_DangBai
            // 
            btn_DangBai.FlatStyle = FlatStyle.Flat;
            btn_DangBai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangBai.ForeColor = SystemColors.ButtonFace;
            btn_DangBai.Location = new Point(3, 3);
            btn_DangBai.Name = "btn_DangBai";
            btn_DangBai.Size = new Size(168, 49);
            btn_DangBai.TabIndex = 0;
            btn_DangBai.Text = "Đăng Bài";
            btn_DangBai.UseVisualStyleBackColor = true;
            btn_DangBai.Click += btn_DangBai_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(8, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 113);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Thiết_kế_chưa_có_tên1;
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(183, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(1151, 656);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 74, 173);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(183, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1139, 69);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(guna2CircleButton1);
            panel8.Location = new Point(1074, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(62, 60);
            panel8.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.BackColor = Color.Transparent;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageSize = new Size(66, 62);
            guna2CircleButton1.Location = new Point(0, 5);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(56, 55);
            guna2CircleButton1.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtTenTK);
            panel9.Location = new Point(871, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(197, 66);
            panel9.TabIndex = 2;
            panel9.Paint += panel9_Paint;
            // 
            // txtTenTK
            // 
            txtTenTK.BackColor = Color.Transparent;
            txtTenTK.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenTK.ForeColor = SystemColors.ButtonHighlight;
            txtTenTK.Location = new Point(13, 9);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(77, 25);
            txtTenTK.TabIndex = 1;
            txtTenTK.Text = "Xin Chào, ";
            txtTenTK.Click += guna2HtmlLabel1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2ColorTransition1
            // 
            guna2ColorTransition1.ColorArray = new Color[]
    {
    Color.Red,
    Color.Blue,
    Color.Orange
    };
            // 
            // FDangBai_NTD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 721);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FDangBai_NTD";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
       //private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Button btn_TK;
        private Button btn_LichSu;
        private Button btn_DangBai;
        private OpenFileDialog openFileDialog1;
        private Panel panel8;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Panel panel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenTK;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Panel panel5;
        private Button btn_UV;
        private Guna.UI2.WinForms.Guna2GradientPanel pan_ThongTin;
    }
}
