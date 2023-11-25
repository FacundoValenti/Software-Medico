<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Estudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABM_Estudio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.dtFechaestudio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmutual = New System.Windows.Forms.TextBox()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmedicosolicitante = New System.Windows.Forms.TextBox()
        Me.txtEstudios = New System.Windows.Forms.TextBox()
        Me.txtinforme = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblseñalEstudio = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.txtidinforme = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paciente"
        '
        'txtpaciente
        '
        Me.txtpaciente.Location = New System.Drawing.Point(173, 183)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(100, 20)
        Me.txtpaciente.TabIndex = 1
        '
        'dtFechaestudio
        '
        Me.dtFechaestudio.Location = New System.Drawing.Point(28, 106)
        Me.dtFechaestudio.Name = "dtFechaestudio"
        Me.dtFechaestudio.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaestudio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mutual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Estudios"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Importe"
        '
        'txtmutual
        '
        Me.txtmutual.Location = New System.Drawing.Point(28, 183)
        Me.txtmutual.Name = "txtmutual"
        Me.txtmutual.Size = New System.Drawing.Size(100, 20)
        Me.txtmutual.TabIndex = 7
        '
        'txtimporte
        '
        Me.txtimporte.Location = New System.Drawing.Point(25, 241)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(100, 20)
        Me.txtimporte.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "MedicoSolicitante"
        '
        'txtmedicosolicitante
        '
        Me.txtmedicosolicitante.Location = New System.Drawing.Point(25, 310)
        Me.txtmedicosolicitante.Name = "txtmedicosolicitante"
        Me.txtmedicosolicitante.Size = New System.Drawing.Size(210, 20)
        Me.txtmedicosolicitante.TabIndex = 10
        '
        'txtEstudios
        '
        Me.txtEstudios.Location = New System.Drawing.Point(28, 369)
        Me.txtEstudios.Name = "txtEstudios"
        Me.txtEstudios.Size = New System.Drawing.Size(100, 20)
        Me.txtEstudios.TabIndex = 11
        '
        'txtinforme
        '
        Me.txtinforme.Location = New System.Drawing.Point(25, 421)
        Me.txtinforme.Multiline = True
        Me.txtinforme.Name = "txtinforme"
        Me.txtinforme.Size = New System.Drawing.Size(508, 188)
        Me.txtinforme.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Informe"
        '
        'lblseñalEstudio
        '
        Me.lblseñalEstudio.AutoSize = True
        Me.lblseñalEstudio.BackColor = System.Drawing.Color.White
        Me.lblseñalEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalEstudio.ForeColor = System.Drawing.Color.Black
        Me.lblseñalEstudio.Location = New System.Drawing.Point(688, 79)
        Me.lblseñalEstudio.Name = "lblseñalEstudio"
        Me.lblseñalEstudio.Size = New System.Drawing.Size(70, 25)
        Me.lblseñalEstudio.TabIndex = 60
        Me.lblseñalEstudio.Text = "Label"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1270, 71)
        Me.ToolStrip1.TabIndex = 61
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
        'txtidinforme
        '
        Me.txtidinforme.Enabled = False
        Me.txtidinforme.Location = New System.Drawing.Point(658, 183)
        Me.txtidinforme.Name = "txtidinforme"
        Me.txtidinforme.Size = New System.Drawing.Size(100, 20)
        Me.txtidinforme.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(655, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "IdInforme"
        '
        'ABM_Estudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 668)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtidinforme)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblseñalEstudio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtinforme)
        Me.Controls.Add(Me.txtEstudios)
        Me.Controls.Add(Me.txtmedicosolicitante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.txtmutual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtFechaestudio)
        Me.Controls.Add(Me.txtpaciente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Estudio"
        Me.Text = "ABM_Estudio"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents dtFechaestudio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmutual As TextBox
    Friend WithEvents txtimporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmedicosolicitante As TextBox
    Friend WithEvents txtEstudios As TextBox
    Friend WithEvents txtinforme As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblseñalEstudio As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents txtidinforme As TextBox
    Friend WithEvents Label8 As Label
End Class
