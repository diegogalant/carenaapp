Imports System.ComponentModel
Public Class ModuloCollection
    Inherits BindingList(Of ModuloClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New ModuloClass
    End Sub
End Class
