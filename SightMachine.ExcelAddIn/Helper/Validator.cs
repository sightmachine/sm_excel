using System.Windows.Forms;
using ExcelAddIn.Exception;

namespace ExcelAddIn.Helper
{
    public static class Validator
    {
        public static void HandleNullOrWhiteSpaceRequired(Control control, string controlName)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.Focus();
                throw new ValidationException($@"Please enter value for {controlName}");
            }
        }
    }
}