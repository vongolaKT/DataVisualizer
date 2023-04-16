using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace DataVisualizerWinUI
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
            panel1 = new Panel();
            SettingsBtn = new Button();
            ExitBtn = new Button();
            AnalyseBtn = new Button();
            ViewsBtn = new Button();
            DataHomeBtn = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            DataHomePnl = new Panel();
            label1 = new Label();
            ViewsPnl = new Panel();
            label3 = new Label();
            AnalysePnl = new Panel();
            label4 = new Label();
            SettingsPnl = new Panel();
            label5 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DataHomePnl.SuspendLayout();
            ViewsPnl.SuspendLayout();
            AnalysePnl.SuspendLayout();
            SettingsPnl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 31, 53);
            panel1.Controls.Add(SettingsBtn);
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(AnalyseBtn);
            panel1.Controls.Add(ViewsBtn);
            panel1.Controls.Add(DataHomeBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 600);
            panel1.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackgroundImageLayout = ImageLayout.None;
            SettingsBtn.Dock = DockStyle.Top;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsBtn.ForeColor = Color.FromArgb(0, 127, 250);
            SettingsBtn.Image = Properties.Resources.setting;
            SettingsBtn.ImageAlign = ContentAlignment.MiddleRight;
            SettingsBtn.Location = new Point(0, 288);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(190, 46);
            SettingsBtn.TabIndex = 5;
            SettingsBtn.Text = "Settings";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            SettingsBtn.Leave += SettingsBtn_Leave;
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImageLayout = ImageLayout.None;
            ExitBtn.Dock = DockStyle.Bottom;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = Color.FromArgb(0, 127, 250);
            ExitBtn.Image = Properties.Resources.logout;
            ExitBtn.ImageAlign = ContentAlignment.MiddleRight;
            ExitBtn.Location = new Point(0, 554);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(190, 46);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Close";
            ExitBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExitBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // AnalyseBtn
            // 
            AnalyseBtn.BackgroundImageLayout = ImageLayout.None;
            AnalyseBtn.Dock = DockStyle.Top;
            AnalyseBtn.FlatAppearance.BorderSize = 0;
            AnalyseBtn.FlatStyle = FlatStyle.Flat;
            AnalyseBtn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AnalyseBtn.ForeColor = Color.FromArgb(0, 127, 250);
            AnalyseBtn.Image = Properties.Resources.data;
            AnalyseBtn.ImageAlign = ContentAlignment.MiddleRight;
            AnalyseBtn.Location = new Point(0, 242);
            AnalyseBtn.Name = "AnalyseBtn";
            AnalyseBtn.Size = new Size(190, 46);
            AnalyseBtn.TabIndex = 3;
            AnalyseBtn.Text = "Analyse";
            AnalyseBtn.TextAlign = ContentAlignment.MiddleLeft;
            AnalyseBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            AnalyseBtn.UseVisualStyleBackColor = true;
            AnalyseBtn.Click += AnalyseBtn_Click;
            AnalyseBtn.Leave += AnalyseBtn_Leave;
            // 
            // ViewsBtn
            // 
            ViewsBtn.BackgroundImageLayout = ImageLayout.None;
            ViewsBtn.Dock = DockStyle.Top;
            ViewsBtn.FlatAppearance.BorderSize = 0;
            ViewsBtn.FlatStyle = FlatStyle.Flat;
            ViewsBtn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ViewsBtn.ForeColor = Color.FromArgb(0, 127, 250);
            ViewsBtn.Image = Properties.Resources.bar_chart1;
            ViewsBtn.ImageAlign = ContentAlignment.MiddleRight;
            ViewsBtn.Location = new Point(0, 196);
            ViewsBtn.Name = "ViewsBtn";
            ViewsBtn.Size = new Size(190, 46);
            ViewsBtn.TabIndex = 2;
            ViewsBtn.Text = "Views";
            ViewsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ViewsBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ViewsBtn.UseVisualStyleBackColor = true;
            ViewsBtn.Click += ViewsBtn_Click;
            ViewsBtn.Leave += ViewsBtn_Leave;
            // 
            // DataHomeBtn
            // 
            DataHomeBtn.BackgroundImageLayout = ImageLayout.None;
            DataHomeBtn.Dock = DockStyle.Top;
            DataHomeBtn.FlatAppearance.BorderSize = 0;
            DataHomeBtn.FlatStyle = FlatStyle.Flat;
            DataHomeBtn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            DataHomeBtn.ForeColor = Color.FromArgb(0, 127, 250);
            DataHomeBtn.Image = Properties.Resources.home_button1;
            DataHomeBtn.ImageAlign = ContentAlignment.MiddleRight;
            DataHomeBtn.Location = new Point(0, 150);
            DataHomeBtn.Name = "DataHomeBtn";
            DataHomeBtn.Size = new Size(190, 46);
            DataHomeBtn.TabIndex = 1;
            DataHomeBtn.Text = "Data Home";
            DataHomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            DataHomeBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            DataHomeBtn.UseVisualStyleBackColor = true;
            DataHomeBtn.Click += DataHomeBtn_Click;
            DataHomeBtn.Leave += DataHomeBtn_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 150);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(74, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 2;
            label2.Text = "Guest";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.default_profile_picture;
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DataHomePnl
            // 
            DataHomePnl.Controls.Add(label1);
            DataHomePnl.Location = new Point(196, 12);
            DataHomePnl.Name = "DataHomePnl";
            DataHomePnl.Size = new Size(772, 576);
            DataHomePnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Panel";
            // 
            // ViewsPnl
            // 
            ViewsPnl.Controls.Add(cartesianChart1);
            ViewsPnl.Controls.Add(label3);
            ViewsPnl.Location = new Point(196, 12);
            ViewsPnl.Name = "ViewsPnl";
            ViewsPnl.Size = new Size(772, 576);
            ViewsPnl.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 533);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Views Panel";
            // 
            // AnalysePnl
            // 
            AnalysePnl.Controls.Add(label4);
            AnalysePnl.Location = new Point(196, 12);
            AnalysePnl.Name = "AnalysePnl";
            AnalysePnl.Size = new Size(772, 576);
            AnalysePnl.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 190);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 0;
            label4.Text = "Analyse Panel";
            // 
            // SettingsPnl
            // 
            SettingsPnl.Controls.Add(label5);
            SettingsPnl.Location = new Point(196, 12);
            SettingsPnl.Name = "SettingsPnl";
            SettingsPnl.Size = new Size(772, 576);
            SettingsPnl.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 190);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 0;
            label5.Text = "Settings Panel";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(0, 3);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(772, 527);
            cartesianChart1.TabIndex = 1;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 52, 72);
            ClientSize = new Size(980, 600);
            Controls.Add(panel1);
            Controls.Add(ViewsPnl);
            Controls.Add(DataHomePnl);
            Controls.Add(AnalysePnl);
            Controls.Add(SettingsPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DataHomePnl.ResumeLayout(false);
            DataHomePnl.PerformLayout();
            ViewsPnl.ResumeLayout(false);
            ViewsPnl.PerformLayout();
            AnalysePnl.ResumeLayout(false);
            AnalysePnl.PerformLayout();
            SettingsPnl.ResumeLayout(false);
            SettingsPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button DataHomeBtn;
        private Label label2;
        private Button ExitBtn;
        private Button AnalyseBtn;
        private Button ViewsBtn;
        private Button SettingsBtn;
        private Panel DataHomePnl;
        private Panel ViewsPnl;
        private Label label3;
        private Label label1;
        private Panel AnalysePnl;
        private Panel SettingsPnl;
        private Label label5;
        private Label label4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}