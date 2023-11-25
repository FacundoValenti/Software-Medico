<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABM_Paciente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txtlocalidad = New System.Windows.Forms.TextBox()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnrodocumento = New System.Windows.Forms.TextBox()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtfechaalta = New System.Windows.Forms.DateTimePicker()
        Me.txttipodocumento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblseñalPaciente = New System.Windows.Forms.Label()
        Me.txtIdpaciente = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 71)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton1.Text = "Alumnos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton2.Text = "Profesores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(15, 104)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(297, 20)
        Me.txtapellido.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NroDocumento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Telefono"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(15, 146)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(297, 20)
        Me.txtnombre.TabIndex = 26
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Location = New System.Drawing.Point(15, 193)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(297, 20)
        Me.txtdomicilio.TabIndex = 27
        '
        'txtlocalidad
        '
        Me.txtlocalidad.Location = New System.Drawing.Point(15, 240)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtlocalidad.TabIndex = 28
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(186, 386)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(100, 20)
        Me.txtcelular.TabIndex = 29
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(12, 386)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono.TabIndex = 30
        '
        'txtnrodocumento
        '
        Me.txtnrodocumento.Location = New System.Drawing.Point(15, 291)
        Me.txtnrodocumento.Name = "txtnrodocumento"
        Me.txtnrodocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtnrodocumento.TabIndex = 31
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(108, 334)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(80, 20)
        Me.dtFechaNacimiento.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "FechaNacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Mail"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(12, 442)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(300, 20)
        Me.txtmail.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 480)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "FechaAlta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 518)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "TpoDocumento"
        '
        'dtfechaalta
        '
        Me.dtfechaalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaalta.Location = New System.Drawing.Point(73, 480)
        Me.dtfechaalta.Name = "dtfechaalta"
        Me.dtfechaalta.Size = New System.Drawing.Size(80, 20)
        Me.dtfechaalta.TabIndex = 40
        '
        'txttipodocumento
        '
        Me.txttipodocumento.Location = New System.Drawing.Point(15, 535)
        Me.txttipodocumento.Name = "txttipodocumento"
        Me.txttipodocumento.Size = New System.Drawing.Size(173, 20)
        Me.txttipodocumento.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(597, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "IdPaciente"
        '
        'lblseñalPaciente
        '
        Me.lblseñalPaciente.AutoSize = True
        Me.lblseñalPaciente.BackColor = System.Drawing.Color.White
        Me.lblseñalPaciente.ForeColor = System.Drawing.Color.Red
        Me.lblseñalPaciente.Location = New System.Drawing.Point(713, 58)
        Me.lblseñalPaciente.Name = "lblseñalPaciente"
        Me.lblseñalPaciente.Size = New System.Drawing.Size(33, 13)
        Me.lblseñalPaciente.TabIndex = 60
        Me.lblseñalPaciente.Text = "Label"
        '
        'txtIdpaciente
        '
        Me.txtIdpaciente.Enabled = False
        Me.txtIdpaciente.Location = New System.Drawing.Point(600, 104)
        Me.txtIdpaciente.Name = "txtIdpaciente"
        Me.txtIdpaciente.Size = New System.Drawing.Size(99, 20)
        Me.txtIdpaciente.TabIndex = 61
        '
        'ABM_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.txtIdpaciente)
        Me.Controls.Add(Me.lblseñalPaciente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttipodocumento)
        Me.Controls.Add(Me.dtfechaalta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtFechaNacimiento)
        Me.Controls.Add(Me.txtnrodocumento)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ABM_Paciente"
        Me.Text = "ABM_Paciente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdomicilio As TextBox
    Friend WithEvents txtlocalidad As TextBox
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtnrodocumento As TextBox
    Friend WithEvents dtFechaNacimiento As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtfechaalta As DateTimePicker
    Friend WithEvents txttipodocumento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblseñalPaciente As Label
    Friend WithEvents txtIdpaciente As TextBox
End Class
