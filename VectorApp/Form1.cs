namespace VectorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPointer_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Pointer;

        }

        private void btnElips_Click(object sender, EventArgs e)
        {

        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Cizgi;

        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Dortgen;

        }

        private void canvas1_Click(object sender, EventArgs e)
        {

        }

        private void btnRenk1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnRenk1.BackColor = dialog.Color;
            }
        }
    }
}
