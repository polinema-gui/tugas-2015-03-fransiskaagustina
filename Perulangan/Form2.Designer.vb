<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Cbpilih = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cbpilih
        '
        Me.Cbpilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbpilih.FormattingEnabled = True
        Me.Cbpilih.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Inverted Hollow Pyramid"})
        Me.Cbpilih.Location = New System.Drawing.Point(68, 15)
        Me.Cbpilih.Name = "Cbpilih"
        Me.Cbpilih.Size = New System.Drawing.Size(353, 21)
        Me.Cbpilih.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baris"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(68, 48)
        Me.txtinput.Multiline = True
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(275, 25)
        Me.txtinput.TabIndex = 3
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(357, 48)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(64, 26)
        Me.BtnOk.TabIndex = 4
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(22, 89)
        Me.txthasil.Multiline = True
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(419, 310)
        Me.txthasil.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbpilih)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbpilih As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtinput As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
End Class
