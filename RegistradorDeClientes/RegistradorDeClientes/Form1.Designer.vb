﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombreDeEmpresa = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMinimizarVentana = New System.Windows.Forms.Button()
        Me.btnExpandirVentana = New System.Windows.Forms.Button()
        Me.btnCerrarVentana = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlCamposDeAutenticacion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCamposDeAutenticacion
        '
        Me.pnlCamposDeAutenticacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Panel4)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.txtEmail)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Panel2)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.Panel1)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.lblNombreDeEmpresa)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.btnAceptar)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.txtPassword)
        Me.pnlCamposDeAutenticacion.Controls.Add(Me.txtUsuario)
        Me.pnlCamposDeAutenticacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlCamposDeAutenticacion.Location = New System.Drawing.Point(170, 73)
        Me.pnlCamposDeAutenticacion.Name = "pnlCamposDeAutenticacion"
        Me.pnlCamposDeAutenticacion.Size = New System.Drawing.Size(456, 301)
        Me.pnlCamposDeAutenticacion.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(95, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(24, 20)
        Me.Panel4.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(115, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 22)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Text = "Email"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(95, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 20)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(95, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 20)
        Me.Panel1.TabIndex = 4
        '
        'lblNombreDeEmpresa
        '
        Me.lblNombreDeEmpresa.Font = New System.Drawing.Font("JetBrains Mono NL", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeEmpresa.ForeColor = System.Drawing.Color.White
        Me.lblNombreDeEmpresa.Location = New System.Drawing.Point(90, 28)
        Me.lblNombreDeEmpresa.Name = "lblNombreDeEmpresa"
        Me.lblNombreDeEmpresa.Size = New System.Drawing.Size(255, 33)
        Me.lblNombreDeEmpresa.TabIndex = 3
        Me.lblNombreDeEmpresa.Text = "Sistema de Registros"
        Me.lblNombreDeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(190, 235)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPassword.Location = New System.Drawing.Point(116, 170)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(234, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Contrasena"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUsuario.Location = New System.Drawing.Point(115, 114)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(234, 22)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = "Usuario"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnMinimizarVentana)
        Me.Panel3.Controls.Add(Me.btnExpandirVentana)
        Me.Panel3.Controls.Add(Me.btnCerrarVentana)
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnExpandir)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Location = New System.Drawing.Point(666, -6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(128, 50)
        Me.Panel3.TabIndex = 7
        '
        'btnMinimizarVentana
        '
        Me.btnMinimizarVentana.AutoSize = True
        Me.btnMinimizarVentana.BackgroundImage = CType(resources.GetObject("btnMinimizarVentana.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizarVentana.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizarVentana.Location = New System.Drawing.Point(25, 15)
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
        Me.btnExpandirVentana.Location = New System.Drawing.Point(57, 15)
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
        Me.btnCerrarVentana.Location = New System.Drawing.Point(86, 14)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(24, 19)
        Me.btnCerrarVentana.TabIndex = 8
        Me.btnCerrarVentana.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.Location = New System.Drawing.Point(746, 10)
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
        Me.btnExpandir.Location = New System.Drawing.Point(781, 10)
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
        Me.btnCerrar.Location = New System.Drawing.Point(814, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAlerta
        '
        Me.lblAlerta.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblAlerta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAlerta.Location = New System.Drawing.Point(170, 390)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(456, 44)
        Me.lblAlerta.TabIndex = 8
        Me.lblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-1, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inicio de sesion "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(806, 455)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAlerta)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlCamposDeAutenticacion)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Store Express"
        Me.pnlCamposDeAutenticacion.ResumeLayout(False)
        Me.pnlCamposDeAutenticacion.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCamposDeAutenticacion As Panel
    Friend WithEvents lblNombreDeEmpresa As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMinimizarVentana As Button
    Friend WithEvents btnExpandirVentana As Button
    Friend WithEvents btnCerrarVentana As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnExpandir As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAlerta As Label
    Friend WithEvents Label1 As Label
End Class
