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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstTest = New System.Windows.Forms.ListBox()
        Me.lstTranslation = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtDefinition = New System.Windows.Forms.TextBox()
        Me.txtNewLine = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(657, 693)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 60)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(657, 53)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(178, 72)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstTest
        '
        Me.lstTest.FormattingEnabled = True
        Me.lstTest.ItemHeight = 25
        Me.lstTest.Location = New System.Drawing.Point(918, 165)
        Me.lstTest.Name = "lstTest"
        Me.lstTest.Size = New System.Drawing.Size(388, 404)
        Me.lstTest.TabIndex = 2
        '
        'lstTranslation
        '
        Me.lstTranslation.FormattingEnabled = True
        Me.lstTranslation.ItemHeight = 25
        Me.lstTranslation.Location = New System.Drawing.Point(216, 165)
        Me.lstTranslation.Name = "lstTranslation"
        Me.lstTranslation.Size = New System.Drawing.Size(361, 404)
        Me.lstTranslation.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(508, 615)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 31)
        Me.TextBox1.TabIndex = 4
        '
        'txtDefinition
        '
        Me.txtDefinition.Location = New System.Drawing.Point(866, 785)
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(279, 31)
        Me.txtDefinition.TabIndex = 5
        '
        'txtNewLine
        '
        Me.txtNewLine.Location = New System.Drawing.Point(343, 785)
        Me.txtNewLine.Name = "txtNewLine"
        Me.txtNewLine.Size = New System.Drawing.Size(260, 31)
        Me.txtNewLine.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1463, 1042)
        Me.Controls.Add(Me.txtNewLine)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstTranslation)
        Me.Controls.Add(Me.lstTest)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents lstTest As ListBox
    Friend WithEvents lstTranslation As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtDefinition As TextBox
    Friend WithEvents txtNewLine As TextBox
End Class