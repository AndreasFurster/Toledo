using Toledo.Desktop.Helpers;

namespace Toledo.Desktop.Forms
{
    public partial class Bevestiging : CustomMetroForm
    {
        public Bevestiging(string message)
        {
            InitializeComponent();
            metroLabel1.Text = message;
        }
    }
}
