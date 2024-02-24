<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorDeClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorDeClientes))
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.pnlDireccion = New System.Windows.Forms.Panel()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.pnlTelefono = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.pnlApellido = New System.Windows.Forms.Panel()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.pnlNombre = New System.Windows.Forms.Panel()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.lblAlerts = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnMinimizarVentana = New System.Windows.Forms.Button()
        Me.btnExpandirVentana = New System.Windows.Forms.Button()
        Me.btnCerrarVentana = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbVisualizador = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.pbVisualizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaDeNacimiento.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtpFechaDeNacimiento.Checked = False
        Me.dtpFechaDeNacimiento.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(649, 148)
        Me.dtpFechaDeNacimiento.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaDeNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.RightToLeftLayout = True
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(173, 20)
        Me.dtpFechaDeNacimiento.TabIndex = 53
        Me.dtpFechaDeNacimiento.UseWaitCursor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(623, 225)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(29, 21)
        Me.Panel4.TabIndex = 50
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstadoCivil.DropDownHeight = 120
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.IntegralHeight = False
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Casado", "Soltero"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(649, 225)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(173, 21)
        Me.cbEstadoCivil.TabIndex = 49
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(623, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(29, 21)
        Me.Panel3.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(623, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(29, 21)
        Me.Panel2.TabIndex = 47
        '
        'cbGenero
        '
        Me.cbGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbGenero.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Hombre", "Mujer", "Goku"})
        Me.cbGenero.Location = New System.Drawing.Point(649, 186)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(173, 21)
        Me.cbGenero.TabIndex = 46
        '
        'pnlDireccion
        '
        Me.pnlDireccion.BackgroundImage = CType(resources.GetObject("pnlDireccion.BackgroundImage"), System.Drawing.Image)
        Me.pnlDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlDireccion.Location = New System.Drawing.Point(51, 275)
        Me.pnlDireccion.Name = "pnlDireccion"
        Me.pnlDireccion.Size = New System.Drawing.Size(29, 24)
        Me.pnlDireccion.TabIndex = 44
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.Location = New System.Drawing.Point(76, 276)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(173, 24)
        Me.txtDireccion.TabIndex = 60
        Me.txtDireccion.Text = "Direccion"
        Me.txtDireccion.WordWrap = False
        '
        'pnlTelefono
        '
        Me.pnlTelefono.BackgroundImage = CType(resources.GetObject("pnlTelefono.BackgroundImage"), System.Drawing.Image)
        Me.pnlTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTelefono.Location = New System.Drawing.Point(51, 227)
        Me.pnlTelefono.Name = "pnlTelefono"
        Me.pnlTelefono.Size = New System.Drawing.Size(29, 24)
        Me.pnlTelefono.TabIndex = 42
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(76, 227)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(173, 24)
        Me.txtTelefono.TabIndex = 43
        Me.txtTelefono.Text = "Telefono"
        Me.txtTelefono.WordWrap = False
        '
        'pnlEmail
        '
        Me.pnlEmail.BackgroundImage = CType(resources.GetObject("pnlEmail.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlEmail.Location = New System.Drawing.Point(51, 181)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(29, 24)
        Me.pnlEmail.TabIndex = 40
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(76, 181)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 24)
        Me.txtEmail.TabIndex = 41
        Me.txtEmail.Text = "Email"
        Me.txtEmail.WordWrap = False
        '
        'pnlApellido
        '
        Me.pnlApellido.BackgroundImage = CType(resources.GetObject("pnlApellido.BackgroundImage"), System.Drawing.Image)
        Me.pnlApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlApellido.Location = New System.Drawing.Point(51, 137)
        Me.pnlApellido.Name = "pnlApellido"
        Me.pnlApellido.Size = New System.Drawing.Size(29, 24)
        Me.pnlApellido.TabIndex = 38
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtApellido.Location = New System.Drawing.Point(76, 137)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(173, 24)
        Me.txtApellido.TabIndex = 39
        Me.txtApellido.Text = "Apellido"
        Me.txtApellido.WordWrap = False
        '
        'pnlNombre
        '
        Me.pnlNombre.BackgroundImage = CType(resources.GetObject("pnlNombre.BackgroundImage"), System.Drawing.Image)
        Me.pnlNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlNombre.Location = New System.Drawing.Point(51, 94)
        Me.pnlNombre.Name = "pnlNombre"
        Me.pnlNombre.Size = New System.Drawing.Size(29, 24)
        Me.pnlNombre.TabIndex = 36
        '
        'btnListo
        '
        Me.btnListo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListo.BackColor = System.Drawing.Color.Transparent
        Me.btnListo.BackgroundImage = CType(resources.GetObject("btnListo.BackgroundImage"), System.Drawing.Image)
        Me.btnListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListo.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.Location = New System.Drawing.Point(786, 466)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(36, 34)
        Me.btnListo.TabIndex = 35
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'lblAlerts
        '
        Me.lblAlerts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlerts.AutoEllipsis = True
        Me.lblAlerts.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblAlerts.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerts.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAlerts.Location = New System.Drawing.Point(220, 454)
        Me.lblAlerts.Name = "lblAlerts"
        Me.lblAlerts.Size = New System.Drawing.Size(420, 62)
        Me.lblAlerts.TabIndex = 34
        Me.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNombre.Location = New System.Drawing.Point(76, 94)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 24)
        Me.txtNombre.TabIndex = 37
        Me.txtNombre.Text = "Nombre"
        Me.txtNombre.WordWrap = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.btnMinimizarVentana)
        Me.Panel5.Controls.Add(Me.btnExpandirVentana)
        Me.Panel5.Controls.Add(Me.btnCerrarVentana)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Location = New System.Drawing.Point(718, -8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(128, 52)
        Me.Panel5.TabIndex = 8
        '
        'btnMinimizarVentana
        '
        Me.btnMinimizarVentana.AutoSize = True
        Me.btnMinimizarVentana.BackgroundImage = CType(resources.GetObject("btnMinimizarVentana.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizarVentana.Enabled = False
        Me.btnMinimizarVentana.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizarVentana.Location = New System.Drawing.Point(22, 21)
        Me.btnMinimizarVentana.Name = "btnMinimizarVentana"
        Me.btnMinimizarVentana.Size = New System.Drawing.Size(26, 19)
        Me.btnMinimizarVentana.TabIndex = 10
        Me.btnMinimizarVentana.UseVisualStyleBackColor = True
        '
        'btnExpandirVentana
        '
        Me.btnExpandirVentana.AutoSize = True
        Me.btnExpandirVentana.BackgroundImage = CType(resources.GetObject("btnExpandirVentana.BackgroundImage"), System.Drawing.Image)
        Me.btnExpandirVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpandirVentana.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandirVentana.Location = New System.Drawing.Point(54, 21)
        Me.btnExpandirVentana.Name = "btnExpandirVentana"
        Me.btnExpandirVentana.Size = New System.Drawing.Size(23, 19)
        Me.btnExpandirVentana.TabIndex = 9
        Me.btnExpandirVentana.UseVisualStyleBackColor = True
        '
        'btnCerrarVentana
        '
        Me.btnCerrarVentana.AutoSize = True
        Me.btnCerrarVentana.BackgroundImage = CType(resources.GetObject("btnCerrarVentana.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarVentana.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarVentana.Location = New System.Drawing.Point(83, 20)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(24, 19)
        Me.btnCerrarVentana.TabIndex = 8
        Me.btnCerrarVentana.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(746, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(781, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(814, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 29)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 522)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(858, 0)
        Me.FlowLayoutPanel1.TabIndex = 61
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(858, 0)
        Me.FlowLayoutPanel2.TabIndex = 62
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarImagen.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarImagen.BackgroundImage = CType(resources.GetObject("btnBuscarImagen.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarImagen.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscarImagen.Location = New System.Drawing.Point(372, 324)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(121, 35)
        Me.btnBuscarImagen.TabIndex = 33
        Me.btnBuscarImagen.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(858, 0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(0, 522)
        Me.FlowLayoutPanel5.TabIndex = 65
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(0, 522)
        Me.FlowLayoutPanel3.TabIndex = 66
        '
        'pbVisualizador
        '
        Me.pbVisualizador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbVisualizador.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pbVisualizador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbVisualizador.Location = New System.Drawing.Point(289, 74)
        Me.pbVisualizador.Name = "pbVisualizador"
        Me.pbVisualizador.Size = New System.Drawing.Size(298, 235)
        Me.pbVisualizador.TabIndex = 0
        Me.pbVisualizador.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.AutoSize = True
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(34, 467)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(36, 34)
        Me.btnRegresar.TabIndex = 54
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(0, 522)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(858, 0)
        Me.FlowLayoutPanel6.TabIndex = 67
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(286, 64)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(302, 366)
        Me.FlowLayoutPanel4.TabIndex = 68
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel7.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel7.Controls.Add(Me.lblCode)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(858, 522)
        Me.FlowLayoutPanel7.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editor de cliente"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(3, 30)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(0, 13)
        Me.lblCode.TabIndex = 0
        '
        'EditorDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 522)
        Me.Controls.Add(Me.pbVisualizador)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cbEstadoCivil)
        Me.Controls.Add(Me.Panel3)
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
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel6)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel7)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditorDeClientes"
        Me.Text = "EditorDeClientes"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pbVisualizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbEstadoCivil As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents pnlDireccion As Panel
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents pnlTelefono As Panel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pnlApellido As Panel
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents pnlNombre As Panel
    Friend WithEvents btnListo As Button
    Friend WithEvents lblAlerts As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnMinimizarVentana As Button
    Friend WithEvents btnExpandirVentana As Button
    Friend WithEvents btnCerrarVentana As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnBuscarImagen As Button
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents pbVisualizador As PictureBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents lblCode As Label
    Friend WithEvents Label1 As Label
End Class
