Imports System.ComponentModel

Public Class BindingExample
    Implements INotifyPropertyChanged

    'We can create a separate ViewModel class to implement the INotifyPropertyChanged and bind to that class

    Private mVindaloo As String = "Initial"

    Public Property Vindaloo As String
        Get
            Return mVindaloo
        End Get
        Set(value As String)
            mVindaloo = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Vindaloo"))
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Vindaloo = "Later"
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'Me.DataContext = Me
    End Sub
End Class
