Imports System.ComponentModel
Public Class AsignaturasCollection

    Inherits BindingList(Of AsignaturaClass)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New AsignaturaClass  'DocenteCollection ?
    End Sub

End Class
