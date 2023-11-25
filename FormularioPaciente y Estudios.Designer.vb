<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPaciente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.GrillaPaciente = New System.Windows.Forms.DataGridView()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GrillaEstudios = New System.Windows.Forms.DataGridView()
        Me.Idinforme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estudios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Informe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mutual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.txtbuscarestudio = New System.Windows.Forms.TextBox()
        Me.lblbuscarestudio = New System.Windows.Forms.Label()
        Me.txtbuscarpaciente = New System.Windows.Forms.TextBox()
        Me.lblbuscarpaciente = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GrillaPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1323, 71)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
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
        'GrillaPaciente
        '
        Me.GrillaPaciente.AllowDrop = True
        Me.GrillaPaciente.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.GrillaPaciente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaPaciente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.Apellido, Me.Nombre, Me.Domicilio, Me.Localidad, Me.NroDocumento, Me.FechaNacimiento, Me.Telefono, Me.Celular, Me.Mail, Me.FechaAlta, Me.TipoDocumento, Me.TipoPaciente})
        Me.GrillaPaciente.Location = New System.Drawing.Point(11, 70)
        Me.GrillaPaciente.Name = "GrillaPaciente"
        Me.GrillaPaciente.Size = New System.Drawing.Size(876, 155)
        Me.GrillaPaciente.TabIndex = 3
        '
        'IdPaciente
        '
        Me.IdPaciente.HeaderText = "Idpaciente"
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.Visible = False
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 190
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 190
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Width = 150
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.Visible = False
        '
        'NroDocumento
        '
        Me.NroDocumento.HeaderText = "NroDocumento"
        Me.NroDocumento.Name = "NroDocumento"
        Me.NroDocumento.Width = 150
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.HeaderText = "FechaNacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Visible = False
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = False
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.Visible = False
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.Visible = False
        '
        'FechaAlta
        '
        Me.FechaAlta.HeaderText = "FechaAlta"
        Me.FechaAlta.Name = "FechaAlta"
        Me.FechaAlta.Width = 150
        '
        'TipoDocumento
        '
        Me.TipoDocumento.HeaderText = "TipoDocumento"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.Visible = False
        '
        'TipoPaciente
        '
        Me.TipoPaciente.HeaderText = "TipoPaciente"
        Me.TipoPaciente.Name = "TipoPaciente"
        Me.TipoPaciente.Visible = False
        '
        'GrillaEstudios
        '
        Me.GrillaEstudios.AllowDrop = True
        Me.GrillaEstudios.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.GrillaEstudios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GrillaEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaEstudios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaEstudios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idinforme, Me.paciente, Me.Fecha, Me.MedicoSolicitante, Me.Estudios, Me.Informe, Me.Mutual, Me.Importe})
        Me.GrillaEstudios.Location = New System.Drawing.Point(11, 323)
        Me.GrillaEstudios.Name = "GrillaEstudios"
        Me.GrillaEstudios.Size = New System.Drawing.Size(835, 155)
        Me.GrillaEstudios.TabIndex = 6
        '
        'Idinforme
        '
        Me.Idinforme.HeaderText = "Informe"
        Me.Idinforme.Name = "Idinforme"
        '
        'paciente
        '
        Me.paciente.HeaderText = "paciente"
        Me.paciente.Name = "paciente"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 150
        '
        'MedicoSolicitante
        '
        Me.MedicoSolicitante.HeaderText = "MedicoSolicitante"
        Me.MedicoSolicitante.Name = "MedicoSolicitante"
        Me.MedicoSolicitante.Width = 140
        '
        'Estudios
        '
        Me.Estudios.HeaderText = " Estudios"
        Me.Estudios.Name = "Estudios"
        Me.Estudios.Width = 200
        '
        'Informe
        '
        Me.Informe.HeaderText = "Informe"
        Me.Informe.Name = "Informe"
        Me.Informe.Visible = False
        '
        'Mutual
        '
        Me.Mutual.HeaderText = "Mutual"
        Me.Mutual.Name = "Mutual"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 481)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(1323, 71)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton5.Text = "ToolStripButton1"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton6.Text = "ToolStripButton2"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton7.Text = "ToolStripButton3"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton8.Text = "ToolStripButton4"
        '
        'txtbuscarestudio
        '
        Me.txtbuscarestudio.Location = New System.Drawing.Point(861, 458)
        Me.txtbuscarestudio.Name = "txtbuscarestudio"
        Me.txtbuscarestudio.Size = New System.Drawing.Size(362, 20)
        Me.txtbuscarestudio.TabIndex = 31
        '
        'lblbuscarestudio
        '
        Me.lblbuscarestudio.AutoSize = True
        Me.lblbuscarestudio.Location = New System.Drawing.Point(858, 442)
        Me.lblbuscarestudio.Name = "lblbuscarestudio"
        Me.lblbuscarestudio.Size = New System.Drawing.Size(29, 13)
        Me.lblbuscarestudio.TabIndex = 30
        Me.lblbuscarestudio.Text = "label"
        '
        'txtbuscarpaciente
        '
        Me.txtbuscarpaciente.Location = New System.Drawing.Point(908, 205)
        Me.txtbuscarpaciente.Name = "txtbuscarpaciente"
        Me.txtbuscarpaciente.Size = New System.Drawing.Size(241, 20)
        Me.txtbuscarpaciente.TabIndex = 33
        '
        'lblbuscarpaciente
        '
        Me.lblbuscarpaciente.AutoSize = True
        Me.lblbuscarpaciente.Location = New System.Drawing.Point(905, 189)
        Me.lblbuscarpaciente.Name = "lblbuscarpaciente"
        Me.lblbuscarpaciente.Size = New System.Drawing.Size(29, 13)
        Me.lblbuscarpaciente.TabIndex = 32
        Me.lblbuscarpaciente.Text = "label"
        '
        'FormularioPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 552)
        Me.Controls.Add(Me.txtbuscarpaciente)
        Me.Controls.Add(Me.lblbuscarpaciente)
        Me.Controls.Add(Me.txtbuscarestudio)
        Me.Controls.Add(Me.lblbuscarestudio)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GrillaEstudios)
        Me.Controls.Add(Me.GrillaPaciente)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormularioPaciente"
        Me.Text = "FormularioPaciente y Estudios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GrillaPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Public WithEvents GrillaPaciente As DataGridView
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Public WithEvents GrillaEstudios As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents txtbuscarestudio As TextBox
    Friend WithEvents lblbuscarestudio As Label
    Friend WithEvents txtbuscarpaciente As TextBox
    Friend WithEvents lblbuscarpaciente As Label
    Friend WithEvents Idinforme As DataGridViewTextBoxColumn
    Friend WithEvents paciente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents MedicoSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents Estudios As DataGridViewTextBoxColumn
    Friend WithEvents Informe As DataGridViewTextBoxColumn
    Friend WithEvents Mutual As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents NroDocumento As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents Mail As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents TipoPaciente As DataGridViewTextBoxColumn
End Class
