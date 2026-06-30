using LibrarySystem.MainScreen;
using LibrarySystem.MainScreen.Books;
using LibrarySystem.MainScreen.Fines;
using LibrarySystem.MainScreen.Loans;
using LibrarySystem.MainScreen.Members;
using LibrarySystem.MainScreen.Reports;
using LibrarySystem.MainScreen.Settings;

namespace LibrarySystem
{
    public partial class fmMain : Form
    {
        //DBDEE0

        public enum enMode { Dashboard = 1 , Book = 2 , Loan = 3, Fines = 4 , Reports = 5 , Settings = 6 };
        public enMode _Mode = enMode.Dashboard;
        public enMode Mode {  
            set
            {
                _Mode = value;
                pMain.Controls.Clear();
                pMain.Controls.Add(value switch
                {
                    enMode.Dashboard => new ctrlDashboard() { Dock = DockStyle.Fill },
                    enMode.Book => new ctrlMainBook() { Dock = DockStyle.Fill },
                    enMode.Loan => new ctrlMainLoan() {Dock = DockStyle.Fill},
                    enMode.Reports => new ctrlMainReport() { Dock = DockStyle.Fill },
                    enMode.Fines => new ctrlMainFines() { Dock = DockStyle.Fill },
                    enMode.Settings => new ctrlMainSettings() { Dock = DockStyle.Fill },
                    _ => new ctrlDashboard() { Dock = DockStyle.Fill }
                });
            }
            get { return _Mode; }
        }
        public fmMain()
        {
            InitializeComponent();
        }

        private void ctrlMainLoan1_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void dashboradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlDashboard() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainBook() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainMember() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainLoan() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void finesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainFines() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainReport() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Clear();
            pMain.Controls.Add(new ctrlMainSettings() { Dock = DockStyle.Fill});
            pMain.ResumeLayout();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            pMain.SuspendLayout();
            pMain.Controls.Add(new ctrlDashboard() { Dock = DockStyle.Fill });
            pMain.ResumeLayout();
        }
    }
}
