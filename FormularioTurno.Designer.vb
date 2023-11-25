<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioTurno))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.grillaturno = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mutual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minutos1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtmutual1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumerodeafiliado1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.check2 = New System.Windows.Forms.CheckBox()
        Me.check1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmedicosolicitante1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprestaciones1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtobservaciones1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbuscarturno = New System.Windows.Forms.TextBox()
        Me.lblbuscarturno = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grillaturno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1831, 71)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 3
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
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'grillaturno
        '
        Me.grillaturno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grillaturno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillaturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaturno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Hora, Me.Minutos, Me.Mutual, Me.Paciente, Me.MedicoSolicitante, Me.Observaciones, Me.Prestaciones, Me.NroAfiliado, Me.IdTurno, Me.Telefono, Me.Hora1, Me.Minutos1})
        Me.grillaturno.Location = New System.Drawing.Point(1, 74)
        Me.grillaturno.Name = "grillaturno"
        Me.grillaturno.Size = New System.Drawing.Size(453, 534)
        Me.grillaturno.TabIndex = 4
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = False
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.Width = 80
        '
        'Minutos
        '
        Me.Minutos.HeaderText = "Minutos"
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Visible = False
        Me.Minutos.Width = 50
        '
        'Mutual
        '
        Me.Mutual.HeaderText = "Mutual"
        Me.Mutual.Name = "Mutual"
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.Width = 230
        '
        'MedicoSolicitante
        '
        Me.MedicoSolicitante.HeaderText = "MedicoSolicitante"
        Me.MedicoSolicitante.Name = "MedicoSolicitante"
        Me.MedicoSolicitante.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Visible = False
        '
        'Prestaciones
        '
        Me.Prestaciones.HeaderText = "Prestaciones"
        Me.Prestaciones.Name = "Prestaciones"
        Me.Prestaciones.Visible = False
        '
        'NroAfiliado
        '
        Me.NroAfiliado.HeaderText = "NroAfiliado"
        Me.NroAfiliado.Name = "NroAfiliado"
        Me.NroAfiliado.Visible = False
        '
        'IdTurno
        '
        Me.IdTurno.HeaderText = "IdTurno"
        Me.IdTurno.Name = "IdTurno"
        Me.IdTurno.Visible = False
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = False
        '
        'Hora1
        '
        Me.Hora1.HeaderText = "Hora1"
        Me.Hora1.Name = "Hora1"
        Me.Hora1.Visible = False
        '
        'Minutos1
        '
        Me.Minutos1.HeaderText = "Minutos1"
        Me.Minutos1.Name = "Minutos1"
        Me.Minutos1.Visible = False
        '
        'txtmutual1
        '
        Me.txtmutual1.Enabled = False
        Me.txtmutual1.Location = New System.Drawing.Point(484, 93)
        Me.txtmutual1.Name = "txtmutual1"
        Me.txtmutual1.Size = New System.Drawing.Size(156, 20)
        Me.txtmutual1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mutual"
        '
        'txtnumerodeafiliado1
        '
        Me.txtnumerodeafiliado1.Enabled = False
        Me.txtnumerodeafiliado1.Location = New System.Drawing.Point(484, 142)
        Me.txtnumerodeafiliado1.Name = "txtnumerodeafiliado1"
        Me.txtnumerodeafiliado1.Size = New System.Drawing.Size(156, 20)
        Me.txtnumerodeafiliado1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nro de afiliado"
        '
        'check2
        '
        Me.check2.AutoSize = True
        Me.check2.Enabled = False
        Me.check2.Location = New System.Drawing.Point(129, 23)
        Me.check2.Name = "check2"
        Me.check2.Size = New System.Drawing.Size(40, 17)
        Me.check2.TabIndex = 22
        Me.check2.Text = "No"
        Me.check2.UseVisualStyleBackColor = True
        '
        'check1
        '
        Me.check1.AutoSize = True
        Me.check1.Enabled = False
        Me.check1.Location = New System.Drawing.Point(39, 24)
        Me.check1.Name = "check1"
        Me.check1.Size = New System.Drawing.Size(35, 17)
        Me.check1.TabIndex = 21
        Me.check1.Text = "Si"
        Me.check1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.check2)
        Me.GroupBox1.Controls.Add(Me.check1)
        Me.GroupBox1.Location = New System.Drawing.Point(784, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 60)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrego orden"
        Me.GroupBox1.Visible = False
        '
        'txtmedicosolicitante1
        '
        Me.txtmedicosolicitante1.Enabled = False
        Me.txtmedicosolicitante1.Location = New System.Drawing.Point(484, 274)
        Me.txtmedicosolicitante1.Name = "txtmedicosolicitante1"
        Me.txtmedicosolicitante1.Size = New System.Drawing.Size(288, 20)
        Me.txtmedicosolicitante1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Medico Solicitante"
        '
        'txtprestaciones1
        '
        Me.txtprestaciones1.Enabled = False
        Me.txtprestaciones1.Location = New System.Drawing.Point(484, 330)
        Me.txtprestaciones1.Multiline = True
        Me.txtprestaciones1.Name = "txtprestaciones1"
        Me.txtprestaciones1.Size = New System.Drawing.Size(347, 104)
        Me.txtprestaciones1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Prestaciones"
        '
        'txtobservaciones1
        '
        Me.txtobservaciones1.Enabled = False
        Me.txtobservaciones1.Location = New System.Drawing.Point(484, 457)
        Me.txtobservaciones1.Multiline = True
        Me.txtobservaciones1.Name = "txtobservaciones1"
        Me.txtobservaciones1.Size = New System.Drawing.Size(347, 104)
        Me.txtobservaciones1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Observaciónes"
        '
        'txttelefono1
        '
        Me.txttelefono1.Enabled = False
        Me.txttelefono1.Location = New System.Drawing.Point(484, 203)
        Me.txttelefono1.Name = "txttelefono1"
        Me.txttelefono1.Size = New System.Drawing.Size(156, 20)
        Me.txttelefono1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(481, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Telefono"
        '
        'txtbuscarturno
        '
        Me.txtbuscarturno.Location = New System.Drawing.Point(1092, 519)
        Me.txtbuscarturno.Name = "txtbuscarturno"
        Me.txtbuscarturno.Size = New System.Drawing.Size(362, 20)
        Me.txtbuscarturno.TabIndex = 29
        '
        'lblbuscarturno
        '
        Me.lblbuscarturno.AutoSize = True
        Me.lblbuscarturno.Location = New System.Drawing.Point(1089, 503)
        Me.lblbuscarturno.Name = "lblbuscarturno"
        Me.lblbuscarturno.Size = New System.Drawing.Size(29, 13)
        Me.lblbuscarturno.TabIndex = 28
        Me.lblbuscarturno.Text = "label"
        '
        'FormularioTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1831, 608)
        Me.Controls.Add(Me.txtbuscarturno)
        Me.Controls.Add(Me.lblbuscarturno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttelefono1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtobservaciones1)
        Me.Controls.Add(Me.txtprestaciones1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtmedicosolicitante1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnumerodeafiliado1)
        Me.Controls.Add(Me.txtmutual1)
        Me.Controls.Add(Me.grillaturno)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormularioTurno"
        Me.Text = "FormularioTurno"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grillaturno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents grillaturno As DataGridView
    Friend WithEvents txtmutual1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumerodeafiliado1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents check2 As CheckBox
    Friend WithEvents check1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtmedicosolicitante1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprestaciones1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtobservaciones1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Minutos As DataGridViewTextBoxColumn
    Friend WithEvents Mutual As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents MedicoSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Prestaciones As DataGridViewTextBoxColumn
    Friend WithEvents NroAfiliado As DataGridViewTextBoxColumn
    Friend WithEvents IdTurno As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Hora1 As DataGridViewTextBoxColumn
    Friend WithEvents Minutos1 As DataGridViewTextBoxColumn
    Friend WithEvents txtbuscarturno As TextBox
    Friend WithEvents lblbuscarturno As Label
End Class
