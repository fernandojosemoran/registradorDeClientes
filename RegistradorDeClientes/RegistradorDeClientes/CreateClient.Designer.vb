﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateClient))
        Me.pbVisualizador = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.lblAlerts = New System.Windows.Forms.Label()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.pnlNombre = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.pnlApellido = New System.Windows.Forms.Panel()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.pnlTelefono = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.pnlDireccion = New System.Windows.Forms.Panel()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtpFechaDeRegistro = New System.Windows.Forms.DateTimePicker()
        CType(Me.pbVisualizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbVisualizador
        '
        Me.pbVisualizador.BackColor = System.Drawing.Color.DimGray
        Me.pbVisualizador.Location = New System.Drawing.Point(277, 86)
        Me.pbVisualizador.Name = "pbVisualizador"
        Me.pbVisualizador.Size = New System.Drawing.Size(295, 205)
        Me.pbVisualizador.TabIndex = 0
        Me.pbVisualizador.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.btnExpandir)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Location = New System.Drawing.Point(749, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 50)
        Me.Panel1.TabIndex = 7
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.Location = New System.Drawing.Point(13, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(29, 29)
        Me.btnMinimizar.TabIndex = 7
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnExpandir
        '
        Me.btnExpandir.BackColor = System.Drawing.Color.Transparent
        Me.btnExpandir.BackgroundImage = CType(resources.GetObject("btnExpandir.BackgroundImage"), System.Drawing.Image)
        Me.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpandir.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandir.Location = New System.Drawing.Point(48, 12)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(29, 29)
        Me.btnExpandir.TabIndex = 6
        Me.btnExpandir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(83, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.BackgroundImage = CType(resources.GetObject("btnBuscarImagen.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarImagen.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscarImagen.Location = New System.Drawing.Point(359, 297)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(121, 35)
        Me.btnBuscarImagen.TabIndex = 8
        Me.btnBuscarImagen.UseVisualStyleBackColor = True
        '
        'lblAlerts
        '
        Me.lblAlerts.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerts.Location = New System.Drawing.Point(223, 423)
        Me.lblAlerts.Name = "lblAlerts"
        Me.lblAlerts.Size = New System.Drawing.Size(394, 62)
        Me.lblAlerts.TabIndex = 9
        Me.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.Transparent
        Me.btnListo.BackgroundImage = CType(resources.GetObject("btnListo.BackgroundImage"), System.Drawing.Image)
        Me.btnListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListo.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.Location = New System.Drawing.Point(825, 451)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(36, 34)
        Me.btnListo.TabIndex = 10
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'pnlNombre
        '
        Me.pnlNombre.BackgroundImage = CType(resources.GetObject("pnlNombre.BackgroundImage"), System.Drawing.Image)
        Me.pnlNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlNombre.Location = New System.Drawing.Point(54, 86)
        Me.pnlNombre.Name = "pnlNombre"
        Me.pnlNombre.Size = New System.Drawing.Size(29, 24)
        Me.pnlNombre.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNombre.Location = New System.Drawing.Point(79, 86)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 24)
        Me.txtNombre.TabIndex = 12
        Me.txtNombre.Text = "Nombre"
        Me.txtNombre.WordWrap = False
        '
        'pnlApellido
        '
        Me.pnlApellido.BackgroundImage = CType(resources.GetObject("pnlApellido.BackgroundImage"), System.Drawing.Image)
        Me.pnlApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlApellido.Location = New System.Drawing.Point(54, 129)
        Me.pnlApellido.Name = "pnlApellido"
        Me.pnlApellido.Size = New System.Drawing.Size(29, 24)
        Me.pnlApellido.TabIndex = 13
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtApellido.Location = New System.Drawing.Point(79, 129)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(173, 24)
        Me.txtApellido.TabIndex = 14
        Me.txtApellido.Text = "Apellido"
        Me.txtApellido.WordWrap = False
        '
        'pnlEmail
        '
        Me.pnlEmail.BackgroundImage = CType(resources.GetObject("pnlEmail.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlEmail.Location = New System.Drawing.Point(54, 173)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(29, 24)
        Me.pnlEmail.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(79, 173)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 24)
        Me.txtEmail.TabIndex = 16
        Me.txtEmail.Text = "Email"
        Me.txtEmail.WordWrap = False
        '
        'pnlTelefono
        '
        Me.pnlTelefono.BackgroundImage = CType(resources.GetObject("pnlTelefono.BackgroundImage"), System.Drawing.Image)
        Me.pnlTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTelefono.Location = New System.Drawing.Point(54, 219)
        Me.pnlTelefono.Name = "pnlTelefono"
        Me.pnlTelefono.Size = New System.Drawing.Size(29, 24)
        Me.pnlTelefono.TabIndex = 17
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(79, 219)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(173, 24)
        Me.txtTelefono.TabIndex = 18
        Me.txtTelefono.Text = "Telefono"
        Me.txtTelefono.WordWrap = False
        '
        'pnlDireccion
        '
        Me.pnlDireccion.BackgroundImage = CType(resources.GetObject("pnlDireccion.BackgroundImage"), System.Drawing.Image)
        Me.pnlDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlDireccion.Location = New System.Drawing.Point(54, 267)
        Me.pnlDireccion.Name = "pnlDireccion"
        Me.pnlDireccion.Size = New System.Drawing.Size(29, 24)
        Me.pnlDireccion.TabIndex = 19
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(79, 267)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(173, 24)
        Me.txtDireccion.TabIndex = 20
        Me.txtDireccion.Text = "Direccion"
        Me.txtDireccion.WordWrap = False
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbGenero.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Hombre", "Mujer", "Goku", "Transformer"})
        Me.cbGenero.Location = New System.Drawing.Point(628, 125)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(173, 21)
        Me.cbGenero.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(602, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(29, 21)
        Me.Panel2.TabIndex = 22
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaDeNacimiento.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtpFechaDeNacimiento.Checked = False
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(628, 86)
        Me.dtpFechaDeNacimiento.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.RightToLeftLayout = True
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(173, 20)
        Me.dtpFechaDeNacimiento.TabIndex = 23
        Me.dtpFechaDeNacimiento.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(602, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(29, 21)
        Me.Panel3.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(602, 164)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(29, 21)
        Me.Panel4.TabIndex = 26
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownHeight = 120
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.IntegralHeight = False
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Casado", "Soltero"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(628, 164)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(173, 21)
        Me.cbEstadoCivil.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(602, 203)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(29, 21)
        Me.Panel5.TabIndex = 28
        '
        'dtpFechaDeRegistro
        '
        Me.dtpFechaDeRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaDeRegistro.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtpFechaDeRegistro.Checked = False
        Me.dtpFechaDeRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeRegistro.Location = New System.Drawing.Point(628, 203)
        Me.dtpFechaDeRegistro.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro"
        Me.dtpFechaDeRegistro.RightToLeftLayout = True
        Me.dtpFechaDeRegistro.Size = New System.Drawing.Size(173, 20)
        Me.dtpFechaDeRegistro.TabIndex = 27
        Me.dtpFechaDeRegistro.UseWaitCursor = True
        '
        'CreateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 512)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dtpFechaDeRegistro)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cbEstadoCivil)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.pnlDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.pnlTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.pnlEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.pnlApellido)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.pnlNombre)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.lblAlerts)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbVisualizador)
        Me.Controls.Add(Me.txtNombre)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateClient"
        Me.Text = "CreateClient"
        CType(Me.pbVisualizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbVisualizador As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnExpandir As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBuscarImagen As Button
    Friend WithEvents lblAlerts As Label
    Friend WithEvents btnListo As Button
    Friend WithEvents pnlNombre As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents pnlApellido As Panel
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pnlTelefono As Panel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents pnlDireccion As Panel
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbEstadoCivil As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpFechaDeRegistro As DateTimePicker
End Class
