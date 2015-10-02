Imports System.ComponentModel

Public Class DocentesCollection

    Inherits BindingList(Of DocenteClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New DocenteClass 'DocenteCollection ?
    End Sub

End Class
