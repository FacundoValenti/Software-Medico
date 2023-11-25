<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_Turnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABM_Turnos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmutual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnroafiliado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprestaciones = New System.Windows.Forms.TextBox()
        Me.txtmedicosolicitante = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.checksi = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkno = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.lblseñalturno = New System.Windows.Forms.Label()
        Me.txtminutos = New System.Windows.Forms.TextBox()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdTurno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora del turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paciente"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(15, 187)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(156, 20)
        Me.txttelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono"
        '
        'txtmutual
        '
        Me.txtmutual.Location = New System.Drawing.Point(15, 258)
        Me.txtmutual.Name = "txtmutual"
        Me.txtmutual.Size = New System.Drawing.Size(156, 20)
        Me.txtmutual.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prestaciones"
        '
        'txtnroafiliado
        '
        Me.txtnroafiliado.Location = New System.Drawing.Point(257, 258)
        Me.txtnroafiliado.Name = "txtnroafiliado"
        Me.txtnroafiliado.Size = New System.Drawing.Size(156, 20)
        Me.txtnroafiliado.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mutual"
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(15, 74)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(199, 20)
        Me.dtfecha.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nro de afiliado"
        '
        'txtprestaciones
        '
        Me.txtprestaciones.Location = New System.Drawing.Point(15, 323)
        Me.txtprestaciones.Multiline = True
        Me.txtprestaciones.Name = "txtprestaciones"
        Me.txtprestaciones.Size = New System.Drawing.Size(347, 104)
        Me.txtprestaciones.TabIndex = 12
        '
        'txtmedicosolicitante
        '
        Me.txtmedicosolicitante.Location = New System.Drawing.Point(16, 455)
        Me.txtmedicosolicitante.Name = "txtmedicosolicitante"
        Me.txtmedicosolicitante.Size = New System.Drawing.Size(156, 20)
        Me.txtmedicosolicitante.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Medico Solicitante"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(16, 508)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(347, 104)
        Me.txtobservaciones.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 492)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Observaciónes"
        '
        'checksi
        '
        Me.checksi.AutoSize = True
        Me.checksi.Location = New System.Drawing.Point(30, 23)
        Me.checksi.Name = "checksi"
        Me.checksi.Size = New System.Drawing.Size(35, 17)
        Me.checksi.TabIndex = 21
        Me.checksi.Text = "Si"
        Me.checksi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkno)
        Me.GroupBox1.Controls.Add(Me.checksi)
        Me.GroupBox1.Location = New System.Drawing.Point(560, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 60)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrego orden"
        Me.GroupBox1.Visible = False
        '
        'checkno
        '
        Me.checkno.AutoSize = True
        Me.checkno.Location = New System.Drawing.Point(129, 23)
        Me.checkno.Name = "checkno"
        Me.checkno.Size = New System.Drawing.Size(40, 17)
        Me.checkno.TabIndex = 22
        Me.checkno.Text = "No"
        Me.checkno.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 71)
        Me.ToolStrip1.TabIndex = 23
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
        'txtidpaciente
        '
        Me.txtidpaciente.Location = New System.Drawing.Point(16, 126)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(199, 20)
        Me.txtidpaciente.TabIndex = 3
        '
        'lblseñalturno
        '
        Me.lblseñalturno.AutoSize = True
        Me.lblseñalturno.BackColor = System.Drawing.Color.White
        Me.lblseñalturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalturno.ForeColor = System.Drawing.Color.Black
        Me.lblseñalturno.Location = New System.Drawing.Point(555, 85)
        Me.lblseñalturno.Name = "lblseñalturno"
        Me.lblseñalturno.Size = New System.Drawing.Size(70, 25)
        Me.lblseñalturno.TabIndex = 61
        Me.lblseñalturno.Text = "Label"
        '
        'txtminutos
        '
        Me.txtminutos.Location = New System.Drawing.Point(330, 124)
        Me.txtminutos.Name = "txtminutos"
        Me.txtminutos.Size = New System.Drawing.Size(41, 20)
        Me.txtminutos.TabIndex = 63
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(273, 124)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(41, 20)
        Me.txthora.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(314, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(268, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 20)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Hora"
        '
        'txtIdTurno
        '
        Me.txtIdTurno.Enabled = False
        Me.txtIdTurno.Location = New System.Drawing.Point(527, 254)
        Me.txtIdTurno.Name = "txtIdTurno"
        Me.txtIdTurno.Size = New System.Drawing.Size(84, 20)
        Me.txtIdTurno.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(524, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "IdTurno"
        '
        'ABM_Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 662)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdTurno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.txtminutos)
        Me.Controls.Add(Me.lblseñalturno)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtidpaciente)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtmedicosolicitante)
        Me.Controls.Add(Me.txtprestaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.txtnroafiliado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmutual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Turnos"
        Me.Text = "ABM_Turnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmutual As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnroafiliado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprestaciones As TextBox
    Friend WithEvents txtmedicosolicitante As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents checksi As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkno As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents txtidpaciente As TextBox
    Friend WithEvents lblseñalturno As Label
    Friend WithEvents txtminutos As TextBox
    Friend WithEvents txthora As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdTurno As TextBox
    Friend WithEvents Label7 As Label
End Class
