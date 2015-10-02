<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignaturasGrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignaturasGrid))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AsignadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AsignaturasCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuAsig = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturasCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAsig.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.ModulosDataGridViewTextBoxColumn, Me.AsignadosDataGridViewTextBoxColumn, Me.IdDocenteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AsignaturasCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(690, 537)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        Me.IdCarreraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModulosDataGridViewTextBoxColumn
        '
        Me.ModulosDataGridViewTextBoxColumn.DataPropertyName = "Modulos"
        Me.ModulosDataGridViewTextBoxColumn.HeaderText = "Modulos"
        Me.ModulosDataGridViewTextBoxColumn.Name = "ModulosDataGridViewTextBoxColumn"
        Me.ModulosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignadosDataGridViewTextBoxColumn
        '
        Me.AsignadosDataGridViewTextBoxColumn.DataPropertyName = "Asignados"
        Me.AsignadosDataGridViewTextBoxColumn.HeaderText = "Asignados"
        Me.AsignadosDataGridViewTextBoxColumn.Name = "AsignadosDataGridViewTextBoxColumn"
        Me.AsignadosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDocenteDataGridViewTextBoxColumn
        '
        Me.IdDocenteDataGridViewTextBoxColumn.DataPropertyName = "IdDocente"
        Me.IdDocenteDataGridViewTextBoxColumn.HeaderText = "IdDocente"
        Me.IdDocenteDataGridViewTextBoxColumn.Name = "IdDocenteDataGridViewTextBoxColumn"
        Me.IdDocenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignaturasCollectionBindingSource
        '
        Me.AsignaturasCollectionBindingSource.DataSource = GetType(WindowsApplication1.AsignaturasCollection)
        '
        'MenuAsig
        '
        Me.MenuAsig.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuAsig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.ToolStripSeparator1, Me.Eliminar, Me.ToolStripSeparator2, Me.Salir, Me.Modificar})
        Me.MenuAsig.Location = New System.Drawing.Point(705, 0)
        Me.MenuAsig.Name = "MenuAsig"
        Me.MenuAsig.Size = New System.Drawing.Size(79, 561)
        Me.MenuAsig.TabIndex = 2
        Me.MenuAsig.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(76, 20)
        Me.Agregar.Text = "Agregar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(76, 6)
        '
        'Eliminar
        '
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(76, 20)
        Me.Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(76, 6)
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(76, 20)
        Me.Salir.Text = "Salir"
        '
        'Modificar
        '
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(76, 20)
        Me.Modificar.Text = "Modificar"
        '
        'AsignaturasGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuAsig)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AsignaturasGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AsignaturasGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturasCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAsig.ResumeLayout(False)
        Me.MenuAsig.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AsignaturasCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModulosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsignadosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDocenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuAsig As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
End Class
