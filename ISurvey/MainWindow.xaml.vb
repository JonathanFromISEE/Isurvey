Class MainWindow

    Private Sub Menu_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If Not IsNothing(Navigation) Then
            If Menu.SelectedIndex = 0 Then
                Navigation.Navigate(New DashBoard)
            ElseIf Menu.SelectedIndex = 1 Then
                Navigation.Navigate(New Sondages)
            End If
        End If

    End Sub
End Class
