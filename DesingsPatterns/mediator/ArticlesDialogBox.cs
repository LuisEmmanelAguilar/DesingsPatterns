using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mediator
{
    public class ArticlesDialogBox
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {

        }

        public void simulateUserInteraction()
        {
            articlesListBox.setSelection("Article 1");
            Console.WriteLine("TextBox: " + titleTextBox.getContent());
            Console.WriteLine("Button: " + saveButton.getEnabled());
        }


        private void titleCahnged()
        {
            var content = titleTextBox.getContent();
            var isEmpty = String.IsNullOrEmpty(content);
            saveButton.setEnabled(!isEmpty);
        }
        private void articleSelected()
        {
            titleTextBox.setContent(articlesListBox.getSelection());
            saveButton.setEnabled(true);
        }
    }
}
