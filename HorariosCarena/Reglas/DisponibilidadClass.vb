Public Class DisponibilidadClass
    Dim id_ As Integer
    Dim IdDocente_ As Integer
    Dim IdModulo_ As Integer
    Public ReadOnly Property Id()
        Get
            Return id_



        End Get
    End Property
    Public Property IdDocente()
        Get
            Return IdDocente_
        End Get
        Set(ByVal value)

        End Set
    End Property

    Public Property IdModulo()
        Get
            Return IdModulo_
        End Get
        Set(ByVal value)

        End Set
    End Property
End Class
