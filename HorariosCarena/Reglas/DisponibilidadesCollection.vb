Imports System.ComponentModel
Public Class DisponibilidadesCollection
    Inherits BindingList(Of DisponibilidadClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DisponibilidadClass


    End Sub

End Class
