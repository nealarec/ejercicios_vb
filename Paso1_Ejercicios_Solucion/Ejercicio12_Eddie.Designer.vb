<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio12_Eddie
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio12_Eddie))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.pbxSaintZ = New System.Windows.Forms.PictureBox()
        Me.pbxSantM = New System.Windows.Forms.PictureBox()
        Me.pbxDragonZ = New System.Windows.Forms.PictureBox()
        Me.pbxDragonzM = New System.Windows.Forms.PictureBox()
        Me.pbxCuentos = New System.Windows.Forms.PictureBox()
        Me.pbxCuentosMin = New System.Windows.Forms.PictureBox()
        Me.wmIntro = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxSaintZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSantM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDragonZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDragonzM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCuentosMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.wmIntro)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.pbxSaintZ)
        Me.Panel1.Controls.Add(Me.pbxSantM)
        Me.Panel1.Controls.Add(Me.pbxDragonZ)
        Me.Panel1.Controls.Add(Me.pbxDragonzM)
        Me.Panel1.Controls.Add(Me.pbxCuentos)
        Me.Panel1.Controls.Add(Me.pbxCuentosMin)
        Me.Panel1.Location = New System.Drawing.Point(112, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 320)
        Me.Panel1.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Vivaldi", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.LightSalmon
        Me.lblInfo.Location = New System.Drawing.Point(208, 94)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(345, 44)
        Me.lblInfo.TabIndex = 15
        Me.lblInfo.Text = "acerque el puntero del Mouse por las miniaturas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para verlas mejor y escuchar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    ""
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBienvenido.Font = New System.Drawing.Font("Vivaldi", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(269, 23)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(201, 42)
        Me.lblBienvenido.TabIndex = 14
        Me.lblBienvenido.Text = "Bienvedid@..."
        '
        'pbxSaintZ
        '
        Me.pbxSaintZ.Image = CType(resources.GetObject("pbxSaintZ.Image"), System.Drawing.Image)
        Me.pbxSaintZ.Location = New System.Drawing.Point(211, 23)
        Me.pbxSaintZ.Name = "pbxSaintZ"
        Me.pbxSaintZ.Size = New System.Drawing.Size(342, 271)
        Me.pbxSaintZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSaintZ.TabIndex = 13
        Me.pbxSaintZ.TabStop = False
        Me.pbxSaintZ.Visible = False
        '
        'pbxSantM
        '
        Me.pbxSantM.Image = CType(resources.GetObject("pbxSantM.Image"), System.Drawing.Image)
        Me.pbxSantM.Location = New System.Drawing.Point(25, 212)
        Me.pbxSantM.Name = "pbxSantM"
        Me.pbxSantM.Size = New System.Drawing.Size(120, 75)
        Me.pbxSantM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSantM.TabIndex = 12
        Me.pbxSantM.TabStop = False
        '
        'pbxDragonZ
        '
        Me.pbxDragonZ.Image = CType(resources.GetObject("pbxDragonZ.Image"), System.Drawing.Image)
        Me.pbxDragonZ.Location = New System.Drawing.Point(211, 23)
        Me.pbxDragonZ.Name = "pbxDragonZ"
        Me.pbxDragonZ.Size = New System.Drawing.Size(342, 271)
        Me.pbxDragonZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDragonZ.TabIndex = 11
        Me.pbxDragonZ.TabStop = False
        Me.pbxDragonZ.Visible = False
        '
        'pbxDragonzM
        '
        Me.pbxDragonzM.Image = CType(resources.GetObject("pbxDragonzM.Image"), System.Drawing.Image)
        Me.pbxDragonzM.Location = New System.Drawing.Point(25, 121)
        Me.pbxDragonzM.Name = "pbxDragonzM"
        Me.pbxDragonzM.Size = New System.Drawing.Size(120, 75)
        Me.pbxDragonzM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDragonzM.TabIndex = 10
        Me.pbxDragonzM.TabStop = False
        '
        'pbxCuentos
        '
        Me.pbxCuentos.Image = CType(resources.GetObject("pbxCuentos.Image"), System.Drawing.Image)
        Me.pbxCuentos.Location = New System.Drawing.Point(211, 23)
        Me.pbxCuentos.Name = "pbxCuentos"
        Me.pbxCuentos.Size = New System.Drawing.Size(342, 271)
        Me.pbxCuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCuentos.TabIndex = 9
        Me.pbxCuentos.TabStop = False
        Me.pbxCuentos.Visible = False
        '
        'pbxCuentosMin
        '
        Me.pbxCuentosMin.Image = CType(resources.GetObject("pbxCuentosMin.Image"), System.Drawing.Image)
        Me.pbxCuentosMin.Location = New System.Drawing.Point(25, 23)
        Me.pbxCuentosMin.Name = "pbxCuentosMin"
        Me.pbxCuentosMin.Size = New System.Drawing.Size(120, 82)
        Me.pbxCuentosMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCuentosMin.TabIndex = 8
        Me.pbxCuentosMin.TabStop = False
        '
        'wmIntro
        '
        Me.wmIntro.Enabled = True
        Me.wmIntro.Location = New System.Drawing.Point(239, 121)
        Me.wmIntro.Name = "wmIntro"
        Me.wmIntro.OcxState = CType(resources.GetObject("wmIntro.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmIntro.Size = New System.Drawing.Size(277, 187)
        Me.wmIntro.TabIndex = 16
        '
        'Ejercicio12_Eddie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio12_Eddie"
        Me.Size = New System.Drawing.Size(844, 592)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxSaintZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSantM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDragonZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDragonzM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCuentosMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents pbxSaintZ As PictureBox
    Friend WithEvents pbxSantM As PictureBox
    Friend WithEvents pbxDragonZ As PictureBox
    Friend WithEvents pbxDragonzM As PictureBox
    Friend WithEvents pbxCuentos As PictureBox
    Friend WithEvents pbxCuentosMin As PictureBox
    Friend WithEvents wmIntro As AxWMPLib.AxWindowsMediaPlayer
End Class
