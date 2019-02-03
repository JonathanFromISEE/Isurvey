Class SondagesWizard2
    Public MyParentNavigation As Sondages
    Public TypeSondage As Int16 = 1
    Public NomSondage As String = ""
    Private Sub ButtonNext_Click(sender As Object, e As RoutedEventArgs)
        If TBNomSondage.Text.Trim.Length > 2 Then
            NomSondage = TBNomSondage.Text.Trim
        Else
            MessageBox.Show("Vous devez impérativement saisir un nom pour votre sondage (2 caractères minimum) !", "Votre attention", MessageBoxButton.OK, MessageBoxImage.Stop)
            TBNomSondage.Focus()
        End If
    End Sub

    Private Sub ButtonFaceToFace_Click(sender As Object, e As RoutedEventArgs)
        ButtonFaceToFace.Background = New BrushConverter().ConvertFrom("#FF1875D1")
        ButtonFaceToFaceFA.Foreground = Brushes.White
        ButtonFaceToFaceTB1.Foreground = Brushes.White
        ButtonFaceToFaceTB2.Foreground = Brushes.White
        ButtonFaceToFaceTB3.Foreground = Brushes.White
        ButtonMobile.Background = Brushes.White
        ButtonMobileFA.Foreground = Brushes.Gray
        ButtonMobileTB1.Foreground = Brushes.Gray
        ButtonMobileTB2.Foreground = Brushes.Gray
        ButtonMobileTB3.Foreground = Brushes.Gray
        ButtonWeb.Background = Brushes.White
        ButtonWebFA.Foreground = Brushes.Gray
        ButtonWebTB1.Foreground = Brushes.Gray
        ButtonWebTB2.Foreground = Brushes.Gray
        ButtonWebTB3.Foreground = Brushes.Gray
        TypeSondage = 1
    End Sub

    Private Sub ButtonMobile_Click(sender As Object, e As RoutedEventArgs)
        ButtonFaceToFace.Background = Brushes.White
        ButtonFaceToFaceFA.Foreground = Brushes.Gray
        ButtonFaceToFaceTB1.Foreground = Brushes.Gray
        ButtonFaceToFaceTB2.Foreground = Brushes.Gray
        ButtonFaceToFaceTB3.Foreground = Brushes.Gray
        ButtonMobile.Background = New BrushConverter().ConvertFrom("#FF1875D1")
        ButtonMobileFA.Foreground = Brushes.White
        ButtonMobileTB1.Foreground = Brushes.White
        ButtonMobileTB2.Foreground = Brushes.White
        ButtonMobileTB3.Foreground = Brushes.White
        ButtonWeb.Background = Brushes.White
        ButtonWebFA.Foreground = Brushes.Gray
        ButtonWebTB1.Foreground = Brushes.Gray
        ButtonWebTB2.Foreground = Brushes.Gray
        ButtonWebTB3.Foreground = Brushes.Gray
    End Sub

    Private Sub ButtonWeb_Click(sender As Object, e As RoutedEventArgs)
        ButtonFaceToFace.Background = Brushes.White
        ButtonFaceToFaceFA.Foreground = Brushes.Gray
        ButtonFaceToFaceTB1.Foreground = Brushes.Gray
        ButtonFaceToFaceTB2.Foreground = Brushes.Gray
        ButtonFaceToFaceTB3.Foreground = Brushes.Gray
        ButtonMobile.Background = Brushes.White
        ButtonMobileFA.Foreground = Brushes.Gray
        ButtonMobileTB1.Foreground = Brushes.Gray
        ButtonMobileTB2.Foreground = Brushes.Gray
        ButtonMobileTB3.Foreground = Brushes.Gray
        ButtonWeb.Background = New BrushConverter().ConvertFrom("#FF1875D1")
        ButtonWebFA.Foreground = Brushes.White
        ButtonWebTB1.Foreground = Brushes.White
        ButtonWebTB2.Foreground = Brushes.White
        ButtonWebTB3.Foreground = Brushes.White
    End Sub
End Class
