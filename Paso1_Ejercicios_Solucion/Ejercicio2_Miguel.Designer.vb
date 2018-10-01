<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2_Miguel
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lbxRecopilado = New System.Windows.Forms.ListBox()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.FallaEdad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FallaTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FallaNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FallaApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.gbxDatos.SuspendLayout()
        CType(Me.FallaEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FallaTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FallaNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FallaApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lbxRecopilado)
        Me.Panel1.Controls.Add(Me.gbxDatos)
        Me.Panel1.Location = New System.Drawing.Point(226, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 252)
        Me.Panel1.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(141, 158)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lbxRecopilado
        '
        Me.lbxRecopilado.FormattingEnabled = True
        Me.lbxRecopilado.Location = New System.Drawing.Point(64, 187)
        Me.lbxRecopilado.MultiColumn = True
        Me.lbxRecopilado.Name = "lbxRecopilado"
        Me.lbxRecopilado.Size = New System.Drawing.Size(255, 43)
        Me.lbxRecopilado.TabIndex = 8
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblTelefono)
        Me.gbxDatos.Controls.Add(Me.lblEdad)
        Me.gbxDatos.Controls.Add(Me.lblApellido)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Controls.Add(Me.txtTelefono)
        Me.gbxDatos.Controls.Add(Me.txtApellido)
        Me.gbxDatos.Controls.Add(Me.txtEdad)
        Me.gbxDatos.Location = New System.Drawing.Point(64, 23)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(255, 129)
        Me.gbxDatos.TabIndex = 7
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos del usuario"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(17, 100)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(17, 74)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 6
        Me.lblEdad.Text = "Edad"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(16, 48)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 5
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(77, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(77, 97)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(150, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(77, 45)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(150, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(77, 71)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(150, 20)
        Me.txtEdad.TabIndex = 2
        '
        'FallaEdad
        '
        Me.FallaEdad.ContainerControl = Me
        '
        'FallaTelefono
        '
        Me.FallaTelefono.ContainerControl = Me
        '
        'FallaNombre
        '
        Me.FallaNombre.ContainerControl = Me
        '
        'FallaApellido
        '
        Me.FallaApellido.ContainerControl = Me
        '
        'Ejercicio2_Miguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio2_Miguel"
        Me.Size = New System.Drawing.Size(856, 536)
        Me.Panel1.ResumeLayout(False)
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.FallaEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FallaTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FallaNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FallaApellido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lbxRecopilado As ListBox
    Friend WithEvents gbxDatos As GroupBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents FallaEdad As ErrorProvider
    Friend WithEvents FallaTelefono As ErrorProvider
    Friend WithEvents FallaNombre As ErrorProvider
    Friend WithEvents FallaApellido As ErrorProvider
End Class
