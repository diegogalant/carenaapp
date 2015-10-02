Imports System.IO

Module ModuloPrincipal

    Public lst As DocentesCollection
    Public Asig_list As AsignaturasCollection

    Sub Main()
        Asig_list = New AsignaturasCollection
        lst = New DocentesCollection

        Application.EnableVisualStyles()
        Application.Run(MenuForm)
    End Sub

End Module
