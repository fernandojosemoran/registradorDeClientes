<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateClient))
        Me.pbVisualizador = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.lblAlerts = New System.Windows.Forms.Label()
        Me.btnListo = New System.Windows.Forms.Button()
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
        Me.lblAlerts.Location = New System.Drawing.Point(223, 423)
        Me.lblAlerts.Name = "lblAlerts"
        Me.lblAlerts.Size = New System.Drawing.Size(392, 50)
        Me.lblAlerts.TabIndex = 9
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
        'CreateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 512)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.lblAlerts)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbVisualizador)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateClient"
        Me.Text = "CreateClient"
        CType(Me.pbVisualizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbVisualizador As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnExpandir As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBuscarImagen As Button
    Friend WithEvents lblAlerts As Label
    Friend WithEvents btnListo As Button
End Class
