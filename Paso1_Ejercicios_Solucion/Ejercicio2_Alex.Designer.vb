<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2_Alex
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Edad = New System.Windows.Forms.Label()
        Me.Lbl_Apellido = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lstb_Usuarios = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtb_telefono = New System.Windows.Forms.TextBox()
        Me.Txtb_Apellido = New System.Windows.Forms.TextBox()
        Me.Txtb_Edad = New System.Windows.Forms.TextBox()
        Me.Txtb_Nombre = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Btn_Salir)
        Me.Panel1.Controls.Add(Me.Btn_Eliminar)
        Me.Panel1.Controls.Add(Me.Btn_Agregar)
        Me.Panel1.Controls.Add(Me.Lbl_Telefono)
        Me.Panel1.Controls.Add(Me.Lbl_Edad)
        Me.Panel1.Controls.Add(Me.Lbl_Apellido)
        Me.Panel1.Controls.Add(Me.Lbl_Nombre)
        Me.Panel1.Controls.Add(Me.Lstb_Usuarios)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtb_telefono)
        Me.Panel1.Controls.Add(Me.Txtb_Apellido)
        Me.Panel1.Controls.Add(Me.Txtb_Edad)
        Me.Panel1.Controls.Add(Me.Txtb_Nombre)
        Me.Panel1.Location = New System.Drawing.Point(178, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 253)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Enabled = False
        Me.Btn_Salir.Location = New System.Drawing.Point(353, 200)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 20
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(272, 200)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 19
        Me.Btn_Eliminar.Text = "ELIMINAR"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(191, 200)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 18
        Me.Btn_Agregar.Text = "AGREGAR"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(3, 156)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Telefono.TabIndex = 26
        Me.Lbl_Telefono.Text = "Telefono"
        '
        'Lbl_Edad
        '
        Me.Lbl_Edad.AutoSize = True
        Me.Lbl_Edad.Location = New System.Drawing.Point(3, 123)
        Me.Lbl_Edad.Name = "Lbl_Edad"
        Me.Lbl_Edad.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Edad.TabIndex = 25
        Me.Lbl_Edad.Text = "Edad"
        '
        'Lbl_Apellido
        '
        Me.Lbl_Apellido.AutoSize = True
        Me.Lbl_Apellido.Location = New System.Drawing.Point(3, 90)
        Me.Lbl_Apellido.Name = "Lbl_Apellido"
        Me.Lbl_Apellido.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Apellido.TabIndex = 24
        Me.Lbl_Apellido.Text = "Apellido"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(3, 57)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Nombre.TabIndex = 23
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Lstb_Usuarios
        '
        Me.Lstb_Usuarios.FormattingEnabled = True
        Me.Lstb_Usuarios.Location = New System.Drawing.Point(184, 30)
        Me.Lstb_Usuarios.Name = "Lstb_Usuarios"
        Me.Lstb_Usuarios.Size = New System.Drawing.Size(244, 147)
        Me.Lstb_Usuarios.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Registro de Usuarios:"
        '
        'Txtb_telefono
        '
        Me.Txtb_telefono.Location = New System.Drawing.Point(68, 153)
        Me.Txtb_telefono.Name = "Txtb_telefono"
        Me.Txtb_telefono.Size = New System.Drawing.Size(100, 20)
        Me.Txtb_telefono.TabIndex = 17
        '
        'Txtb_Apellido
        '
        Me.Txtb_Apellido.Location = New System.Drawing.Point(68, 87)
        Me.Txtb_Apellido.Name = "Txtb_Apellido"
        Me.Txtb_Apellido.Size = New System.Drawing.Size(100, 20)
        Me.Txtb_Apellido.TabIndex = 15
        '
        'Txtb_Edad
        '
        Me.Txtb_Edad.Location = New System.Drawing.Point(68, 120)
        Me.Txtb_Edad.Name = "Txtb_Edad"
        Me.Txtb_Edad.Size = New System.Drawing.Size(100, 20)
        Me.Txtb_Edad.TabIndex = 16
        '
        'Txtb_Nombre
        '
        Me.Txtb_Nombre.Location = New System.Drawing.Point(68, 54)
        Me.Txtb_Nombre.Name = "Txtb_Nombre"
        Me.Txtb_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.Txtb_Nombre.TabIndex = 14
        '
        'Ejercicio2_Alex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio2_Alex"
        Me.Size = New System.Drawing.Size(786, 512)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Edad As Label
    Friend WithEvents Lbl_Apellido As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lstb_Usuarios As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtb_telefono As TextBox
    Friend WithEvents Txtb_Apellido As TextBox
    Friend WithEvents Txtb_Edad As TextBox
    Friend WithEvents Txtb_Nombre As TextBox
End Class
