Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports System.ServiceModel.DomainServices.Client
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.Core


Namespace RIACervicesCRUD
	Partial Public Class MainPage
		Inherits UserControl

		Public Sub New()
			ThemeManager.ApplicationTheme = Theme.LightGray
			InitializeComponent()
		End Sub

		Private Sub source_SubmittedChanges(ByVal sender As Object, ByVal e As SubmittedChangesEventArgs)
			If e.HasError Then
				e.MarkErrorAsHandled()
				ShowMessage("Error", e.Error.Message)
			End If
			If (Not e.Cancelled) AndAlso (Not e.HasError) Then
				ShowMessage("Info", "All changes successfully accepted.")
			End If
		End Sub

		Private Sub ShowMessage(ByVal title As String, ByVal message As String)
			messageBox.Title = title
			messageText.Text = message
			messageBox.ShowDialog()
			OKButton.Focus()
		End Sub

		Private Sub deletePerson_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			view.DeleteRow(personsGrid.View.FocusedRowHandle)
		End Sub

		Private Sub OKButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			messageBox.Hide()
		End Sub
	End Class
End Namespace
