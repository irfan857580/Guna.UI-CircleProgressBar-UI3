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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaWinSwitch1 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.GunaCircleProgressBar1.Font = New System.Drawing.Font("Segoe UI Semilight", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaCircleProgressBar1.IdleOffset = 21
        Me.GunaCircleProgressBar1.IdleThickness = 10
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(139, 57)
        Me.GunaCircleProgressBar1.Maximum = 300
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.Cyan
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.ProgressThickness = 40
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(300, 300)
        Me.GunaCircleProgressBar1.TabIndex = 0
        Me.GunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.GunaCircleProgressBar1.UseProgressPercentText = True
        Me.GunaCircleProgressBar1.Value = 200
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(251, 394)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 21
        Me.GunaButton1.Size = New System.Drawing.Size(94, 42)
        Me.GunaButton1.TabIndex = 1
        Me.GunaButton1.Text = "START"
        '
        'GunaWinSwitch1
        '
        Me.GunaWinSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaWinSwitch1.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GunaWinSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GunaWinSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaWinSwitch1.Location = New System.Drawing.Point(476, 200)
        Me.GunaWinSwitch1.Name = "GunaWinSwitch1"
        Me.GunaWinSwitch1.Size = New System.Drawing.Size(40, 22)
        Me.GunaWinSwitch1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 492)
        Me.Controls.Add(Me.GunaWinSwitch1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaCircleProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaWinSwitch1 As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents Timer1 As Timer
End Class
