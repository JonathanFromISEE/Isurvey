Class Sondages
    Private Sub ButtonCreate_Click(sender As Object, e As RoutedEventArgs)
        Dim MyMW As MainWindow = My.Application.MainWindow
        MyMW.Menu.IsEnabled = False
        ButtonCreate.Visibility = Visibility.Collapsed
        HeplText.Visibility = Visibility.Collapsed
        Dim WNext As New SondagesWizard1 With {.MyParentNavigation = Me}
        Wizard.Navigate(WNext)
    End Sub
End Class
