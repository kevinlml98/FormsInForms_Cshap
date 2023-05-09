namespace FormsInForms_Csharp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void OpenForm<Forms>() where Forms : Form, new()
        {
            Form frm;
            frm = panelMain.Controls.OfType<Forms>().FirstOrDefault();

            if (frm == null)
            {
                frm = new Forms();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(frm);
                panelMain.Tag = frm;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                }
                frm.BringToFront();
            }

        }

        private void btnPantalla1_Click(object sender, EventArgs e)
        {
            OpenForm<frmPantalla_1>();
        }

        private void btnPantalla2_Click(object sender, EventArgs e)
        {
            OpenForm<frmPantalla_2>();
        }

        private void btnPantalla3_Click(object sender, EventArgs e)
        {
            OpenForm<frmPantalla_3>();
        }
    }
}