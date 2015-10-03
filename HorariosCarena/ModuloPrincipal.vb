Imports System.IO

Module ModuloPrincipal

    Public docentes_list As DocentesCollection
    Public asignaturas_list As AsignaturasCollection

    Sub Main()
        asignaturas_list = New AsignaturasCollection
        docentes_list = New DocentesCollection

        Application.EnableVisualStyles()
        Application.Run(MenuForm)
    End Sub

End Module
