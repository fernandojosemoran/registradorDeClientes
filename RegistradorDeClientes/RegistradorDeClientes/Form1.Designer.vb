<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlCamposDeAutenticacion = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombreDeEmpresa = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlCamposDeAutenticacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCamposDeAutenticacion
        '
        Me.pnlCamposDeAutenticacion.BackColor = System.Drawing.Color.Black
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Panel2)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Panel1)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.lblNombreDeEmpresa)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.TextBox2)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.TextBox1)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Button1)
        Me.pnlCamposDeAutenticacion.Location = New System.Drawing.Point(170, 73)
        Me.pnlCamposDeAutenticacion.Name = "pnlCamposDeAutenticacion"
        Me.pnlCamposDeAutenticacion.Size = New System.Drawing.Size(456, 309)
        Me.pnlCamposDeAutenticacion.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(90, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 20)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(90, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 20)
        Me.Panel1.TabIndex = 4
        '
        'lblNombreDeEmpresa
        '
        Me.lblNombreDeEmpresa.Font = New System.Drawing.Font("JetBrains Mono NL", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeEmpresa.ForeColor = System.Drawing.Color.White
        Me.lblNombreDeEmpresa.Location = New System.Drawing.Point(110, 17)
        Me.lblNombreDeEmpresa.Name = "lblNombreDeEmpresa"
        Me.lblNombreDeEmpresa.Size = New System.Drawing.Size(235, 33)
        Me.lblNombreDeEmpresa.TabIndex = 3
        Me.lblNombreDeEmpresa.Text = "Store Express"
        Me.lblNombreDeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(234, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(185, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(806, 455)
        Me.Controls.Add(Me.pnlCamposDeAutenticacion)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Store Express"
        Me.pnlCamposDeAutenticacion.ResumeLayout(False)
        Me.pnlCamposDeAutenticacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCamposDeAutenticacion As Panel
    Friend WithEvents lblNombreDeEmpresa As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
