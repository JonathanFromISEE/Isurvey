Class SondagesWizard1
    Public MyParentNavigation As Sondages
    Public MethodeCreation As Int16 = 1
    Private Sub ButtonNext_Click(sender As Object, e As RoutedEventArgs)
        If MethodeCreation = 1 Then
            Dim WNext As New SondagesWizard2 With {.MyParentNavigation = MyParentNavigation}
            MyParentNavigation.Wizard.Navigate(WNext)
        Else
            MessageBox.Show("Désolé, la méthode de création que vous avez sélectionné n'est pas encore disponible.", "Votre attention", MessageBoxButton.OK, MessageBoxImage.Stop)
        End If

    End Sub

    Private Sub ButtonCreateNew_Click(sender As Object, e As RoutedEventArgs)
        ButtonCreateNew.Background = New BrushConverter().ConvertFrom("#FF1875D1")
        ButtonCreateNewFA.Foreground = Brushes.White
        ButtonCreateNewTB.Foreground = Brushes.White
        ButtonCreateFromModel.Background = Brushes.White
        ButtonCreateFromModelFA.Foreground = Brushes.Gray
        ButtonCreateFromModelTB.Foreground = Brushes.Gray
        MethodeCreation = 1
    End Sub

    Private Sub ButtonCreateFromModel_Click(sender As Object, e As RoutedEventArgs)
        ButtonCreateNew.Background = Brushes.White
        ButtonCreateNewFA.Foreground = Brushes.Gray
        ButtonCreateNewTB.Foreground = Brushes.Gray
        ButtonCreateFromModel.Background = New BrushConverter().ConvertFrom("#FF1875D1")
        ButtonCreateFromModelFA.Foreground = Brushes.White
        ButtonCreateFromModelTB.Foreground = Brushes.White
        MethodeCreation = 2
    End Sub
End Class
