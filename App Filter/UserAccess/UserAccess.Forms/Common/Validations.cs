namespace UserAccess.Forms.Common
{
    using System;
    using System.Windows.Forms;
    public class Validations
    {
        public static bool DiscriptionLengths(string discriptionBox, bool ifSubmitBtnIsClickedWhenIsInUserCheker)
        {
            bool isEmpty = false;

            if (discriptionBox.Length < GlobalConstants.PlaceholderLength && discriptionBox == GlobalConstants.PlaceholderDescription)
            {
                MessageBox.Show(GlobalConstants.DescriptionMoreThen10SymbolsOrCanNotEmpty);
            }
            else if ((discriptionBox.Length < GlobalConstants.MinimumLengthOfDiscription && discriptionBox != GlobalConstants.PlaceholderDescription) || string.IsNullOrEmpty(discriptionBox) == true)
            {
                MessageBox.Show(GlobalConstants.DescriptionMoreThen10SymbolsOrCanNotEmpty);
            }
            else if (discriptionBox.Length > GlobalConstants.MaximumLengthOfDiscription)
            {
                MessageBox.Show(GlobalConstants.DescriptionCanNotBeMoreThen1000Symbols);
            }
            else
            {
                isEmpty = true;
            }


            return isEmpty;
        }

        public static void ClearDiscriptionText(TextBox discriptionBox)
        {
            discriptionBox.Clear();
            
        }

    }
}
