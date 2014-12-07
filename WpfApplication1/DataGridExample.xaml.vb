Imports System.Data

Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim dt As New DataTable("EMP")
        dt.Columns.Add("ENAME")
        dt.Columns.Add("SAL")

        dt.Rows.Add({"HUEY", 100})
        dt.Rows.Add({"LUEY", 100})
        dt.Rows.Add({"DUEY", 100})

        'dgrid.DataContext = dt
        dgrid.ItemsSource = dt.AsDataView()
    End Sub
End Class
