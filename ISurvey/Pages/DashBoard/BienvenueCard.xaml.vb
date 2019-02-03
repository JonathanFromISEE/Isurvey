Public Class BienvenueCard
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim MyMW As MainWindow = My.Application.MainWindow
        MyMW.Navigation.Navigate(New Sondages)
    End Sub
End Class
