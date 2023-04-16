using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;


namespace DataVisualizerWinUI
{
    public partial class Form1 : Form
    {
        #region FormSettings
        // Give Forms Rounded Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        // To move window when loaded, must click on very top corner
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHomePnl.Visible = true;
            ViewsPnl.Visible = false;
            AnalysePnl.Visible = false;
            SettingsPnl.Visible = false;
        }

        #region NavigationButtons
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(45, 52, 76);
            this.Close();
        }

        private void DataHomeBtn_Click(object sender, EventArgs e)
        {
            DataHomeBtn.BackColor = Color.FromArgb(45, 52, 76);
            DataHomePnl.Visible = true;
            ViewsPnl.Visible = false;
            AnalysePnl.Visible = false;
            SettingsPnl.Visible = false;
        }

        private void ViewsBtn_Click(object sender, EventArgs e)
        {
            ViewsBtn.BackColor = Color.FromArgb(45, 52, 76);
            DataHomePnl.Visible = false;
            ViewsPnl.Visible = true;
            AnalysePnl.Visible = false;
            SettingsPnl.Visible = false;
        }

        private void AnalyseBtn_Click(object sender, EventArgs e)
        {
            AnalyseBtn.BackColor = Color.FromArgb(45, 52, 76);
            DataHomePnl.Visible = false;
            ViewsPnl.Visible = false;
            AnalysePnl.Visible = true;
            SettingsPnl.Visible = false;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.FromArgb(45, 52, 76);
            DataHomePnl.Visible = false;
            ViewsPnl.Visible = false;
            AnalysePnl.Visible = false;
            SettingsPnl.Visible = true;
        }

        private void DataHomeBtn_Leave(object sender, EventArgs e)
        {
            DataHomeBtn.BackColor = Color.FromArgb(25, 31, 53);
        }

        private void ViewsBtn_Leave(object sender, EventArgs e)
        {
            ViewsBtn.BackColor = Color.FromArgb(25, 31, 53);
        }

        private void AnalyseBtn_Leave(object sender, EventArgs e)
        {
            AnalyseBtn.BackColor = Color.FromArgb(25, 31, 53);
        }

        private void SettingsBtn_Leave(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.FromArgb(25, 31, 53);
        }
        #endregion


        private void cartesianChart1_Load(object sender, EventArgs e)
        {


            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] {2,1,3,5,3,4,6,2,5,4,9,1},
                    Fill = null
                }
            };
        }
    }
}