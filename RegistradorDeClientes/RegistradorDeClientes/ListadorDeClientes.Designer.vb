﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadorDeClientes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadorDeClientes))
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.dgListaDeUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxSeleccionar = New System.Windows.Forms.CheckBox()
        Me.pnlBuscar = New System.Windows.Forms.Panel()
        Me.cbFiltrador = New System.Windows.Forms.ComboBox()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgListaDeUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.AutoSize = True
        Me.btnAgregarCliente.BackgroundImage = CType(resources.GetObject("btnAgregarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarCliente.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(665, 11)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(33, 29)
        Me.btnAgregarCliente.TabIndex = 0
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Font = New System.Drawing.Font("JetBrains Mono NL", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(816, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'dgListaDeUsuarios
        '
        Me.dgListaDeUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgListaDeUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListaDeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaDeUsuarios.Location = New System.Drawing.Point(46, 70)
        Me.dgListaDeUsuarios.Name = "dgListaDeUsuarios"
        Me.dgListaDeUsuarios.Size = New System.Drawing.Size(827, 418)
        Me.dgListaDeUsuarios.TabIndex = 2
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(10, 10)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(477, 28)
        Me.txtBuscar.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cbxSeleccionar)
        Me.Panel1.Controls.Add(Me.pnlBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.cbFiltrador)
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.btnExpandir)
        Me.Panel1.Controls.Add(Me.btnAgregarCliente)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Location = New System.Drawing.Point(36, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 50)
        Me.Panel1.TabIndex = 5
        '
        'cbxSeleccionar
        '
        Me.cbxSeleccionar.Location = New System.Drawing.Point(628, 14)
        Me.cbxSeleccionar.Name = "cbxSeleccionar"
        Me.cbxSeleccionar.Size = New System.Drawing.Size(13, 22)
        Me.cbxSeleccionar.TabIndex = 10
        Me.cbxSeleccionar.Text = "CheckBox1"
        Me.cbxSeleccionar.UseVisualStyleBackColor = True
        '
        'pnlBuscar
        '
        Me.pnlBuscar.BackColor = System.Drawing.Color.White
        Me.pnlBuscar.BackgroundImage = CType(resources.GetObject("pnlBuscar.BackgroundImage"), System.Drawing.Image)
        Me.pnlBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBuscar.Location = New System.Drawing.Point(484, 10)
        Me.pnlBuscar.Name = "pnlBuscar"
        Me.pnlBuscar.Size = New System.Drawing.Size(31, 29)
        Me.pnlBuscar.TabIndex = 8
        '
        'cbFiltrador
        '
        Me.cbFiltrador.FormattingEnabled = True
        Me.cbFiltrador.Items.AddRange(New Object() {"Nombre ", "Email", "Telefono", "Apellido", "EstadoCivil"})
        Me.cbFiltrador.Location = New System.Drawing.Point(537, 15)
        Me.cbFiltrador.Name = "cbFiltrador"
        Me.cbFiltrador.Size = New System.Drawing.Size(85, 21)
        Me.cbFiltrador.TabIndex = 9
        Me.cbFiltrador.Tag = ""
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
        'ListadorDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 534)
        Me.Controls.Add(Me.dgListaDeUsuarios)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadorDeClientes"
        Me.Text = "ListadorDeClientes"
        CType(Me.dgListaDeUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dgListaDeUsuarios As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExpandir As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents pnlBuscar As Panel
    Friend WithEvents cbFiltrador As ComboBox
    Friend WithEvents cbxSeleccionar As CheckBox
    Friend WithEvents toolTip As ToolTip
End Class
