Public Class DocentesForm
    Dim operacion_ As String
    Dim MiDocente As New DocenteClass
    Dim indice_ As Integer
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As Integer
        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)
            indice_ = value
        End Set
    End Property
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then Exit Sub
        If TextBox3.Text = "" Then Exit Sub
        If TextBox4.Text = "" Then Exit Sub
        MiDocente.Nombres = TextBox2.Text
        MiDocente.Apellidos = TextBox3.Text
        MiDocente.Correo = TextBox4.Text
        Select Case operacion_
            Case "Agregar"
                docentes_list.Add(MiDocente)
            Case "Eliminar"
                docentes_list.RemoveAt(indice_)
            Case "Modificar"
                docentes_list.Item(indice_).Nombres = MiDocente.Nombres
                docentes_list.Item(indice_).Apellidos = MiDocente.Apellidos
                docentes_list.Item(indice_).Correo = MiDocente.Correo
                DocentesGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class