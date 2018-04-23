using System;
using System.Windows.Controls;
using System.ServiceModel.DomainServices.Client;
using DevExpress.Xpf.Grid;
using System.Windows;
using DevExpress.Xpf.Core;


namespace RIACervicesCRUD {
    public partial class MainPage : UserControl {

        public MainPage() {
            ThemeManager.ApplicationTheme = Theme.LightGray; 
            InitializeComponent();
        }

        void source_SubmittedChanges(object sender, SubmittedChangesEventArgs e){
            if (e.HasError) {
                e.MarkErrorAsHandled();
                ShowMessage("Error", e.Error.Message);
            }
            if(!e.Cancelled && !e.HasError){
                ShowMessage("Info", "All changes successfully accepted.");
            }
        }

        void ShowMessage(string title, string message) {
            messageBox.Title = title;
            messageText.Text = message;
            messageBox.ShowDialog();
            OKButton.Focus();
        }

        private void deletePerson_Click(object sender, System.Windows.RoutedEventArgs e) {
            view.DeleteRow(personsGrid.View.FocusedRowHandle);
        }

        private void OKButton_Click(object sender, RoutedEventArgs e) {
            messageBox.Hide();
        }
    }
}
