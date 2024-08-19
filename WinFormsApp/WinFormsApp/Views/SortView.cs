using WinFormsApp.Controllers;
using WinFormsApp.Models;
using WinFormsApp.Models.Enums;

namespace WinFormsApp
{
    public partial class SortView : Form
    {
        public SortView()
        {
            InitializeComponent();
            cmbSortType.DataSource = Enum.GetValues(typeof(SortType));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            if (string.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Invalid Text Value.");
                return;
            }

            if(!Enum.TryParse(cmbSortType.SelectedValue?.ToString(), out SortType type))
            {
                MessageBox.Show("Invalid Sort Type Value.");
                return;
            }

            var controller = new SortController();
            var result = controller.ProcessSort(new SortDto(txtValue.Text, type));
            lblOutput.Text = result;
        }
    }
}
