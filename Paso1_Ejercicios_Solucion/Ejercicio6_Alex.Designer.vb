<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio6_Alex
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnContar = New System.Windows.Forms.Button()
        Me.LblIngresar = New System.Windows.Forms.Label()
        Me.TxtIngresar = New System.Windows.Forms.TextBox()
        Me.LstNumeros = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.TxtCuenta)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnContar)
        Me.Panel1.Controls.Add(Me.LblIngresar)
        Me.Panel1.Controls.Add(Me.TxtIngresar)
        Me.Panel1.Controls.Add(Me.LstNumeros)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Location = New System.Drawing.Point(174, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 310)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Elaboro: Alex Mauricio Ossa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(29, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Ejercicio # 6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(29, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Programa que cuente la Cantidad de Numeros Ingresados"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(172, 219)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 18
        Me.LblTotal.Text = "Total:"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.TxtCuenta.Location = New System.Drawing.Point(175, 235)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(107, 20)
        Me.TxtCuenta.TabIndex = 17
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Enabled = False
        Me.BtnSalir.Location = New System.Drawing.Point(32, 235)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnContar
        '
        Me.BtnContar.BackColor = System.Drawing.Color.Aqua
        Me.BtnContar.Location = New System.Drawing.Point(32, 195)
        Me.BtnContar.Name = "BtnContar"
        Me.BtnContar.Size = New System.Drawing.Size(75, 23)
        Me.BtnContar.TabIndex = 15
        Me.BtnContar.Text = "Contar"
        Me.BtnContar.UseVisualStyleBackColor = False
        '
        'LblIngresar
        '
        Me.LblIngresar.AutoSize = True
        Me.LblIngresar.Location = New System.Drawing.Point(29, 75)
        Me.LblIngresar.Name = "LblIngresar"
        Me.LblIngresar.Size = New System.Drawing.Size(97, 13)
        Me.LblIngresar.TabIndex = 14
        Me.LblIngresar.Text = "Ingresa un Numero"
        '
        'TxtIngresar
        '
        Me.TxtIngresar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtIngresar.Location = New System.Drawing.Point(32, 91)
        Me.TxtIngresar.Name = "TxtIngresar"
        Me.TxtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.TxtIngresar.TabIndex = 13
        '
        'LstNumeros
        '
        Me.LstNumeros.BackColor = System.Drawing.Color.Plum
        Me.LstNumeros.FormattingEnabled = True
        Me.LstNumeros.Location = New System.Drawing.Point(175, 75)
        Me.LstNumeros.Name = "LstNumeros"
        Me.LstNumeros.Size = New System.Drawing.Size(107, 134)
        Me.LstNumeros.TabIndex = 12
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAgregar.Location = New System.Drawing.Point(32, 151)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Ejercicio6_Alex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio6_Alex"
        Me.Size = New System.Drawing.Size(686, 472)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtCuenta As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnContar As Button
    Friend WithEvents LblIngresar As Label
    Friend WithEvents TxtIngresar As TextBox
    Friend WithEvents LstNumeros As ListBox
    Friend WithEvents BtnAgregar As Button
End Class
