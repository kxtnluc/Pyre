namespace Pyre.Dev.Components.Pages
{
    public partial class Overview
    {
        #region Buttons
        string buttonText = "No Value";

        // Button Click Test Function
        private void ButtonClick()
        {
            buttonText = "No DI Click!";
        }
        // Button Click with Dependency Inject Test Function
        private void ButtonClick_DI(string message)
        {
            buttonText = (message);
        }
        #endregion
        #region input
        string inputText = "";
        private void OnInputChange()
        {
            // TODO
        }
        #endregion
        #region Dropdown
        string inputDropdown = "Exact";
        private void OnDropdownChange()
        {
            // TODO
        }
        #endregion
        #region Checkbox
        private bool inputCheckbox = false;
        #endregion
        #region Modal
        private bool showModalOne;
        private bool showModalTwo;
        private void OpenModal() => showModalOne = true;
        private void CloseModal() => showModalOne = false;
        private void OpenModalTwo() => showModalTwo = true;
        private void CloseModalTwo() => showModalTwo = false;
        #endregion
    }
}
