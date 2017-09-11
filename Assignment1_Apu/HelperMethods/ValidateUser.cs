using System.Windows.Forms;

namespace Assignment1_Apu.HelperMethods
{
    /// <summary>
    ///     Helper method for validating input in the windows forms
    /// </summary>
    internal class ValidateUser
    {
        public bool validateUserEntry(Recipe rec)
        {
            if (string.IsNullOrEmpty(rec.Name))
            {
                var message = "Not all fields are provided with content. Please fill out every field.";
                var caption = "Error Detected in Input";
                var buttons = MessageBoxButtons.YesNo;
                MessageBox.Show(message, caption, buttons);
                return false;
            }
            if (string.IsNullOrEmpty(rec.Description))
            {
                var message = "Not all fields are provided with content. Please fill out every field.";
                var caption = "Error Detected in Input";
                var buttons = MessageBoxButtons.YesNo;
                MessageBox.Show(message, caption, buttons);
                return false;
            }

            return true;
        }
    }
}
