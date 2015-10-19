<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.matriks1Text = New System.Windows.Forms.TextBox()
        Me.operasiCombo = New System.Windows.Forms.ComboBox()
        Me.matriks2Text = New System.Windows.Forms.TextBox()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hitungButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrix 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matrix 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operasi"
        '
        'matriks1Text
        '
        Me.matriks1Text.Location = New System.Drawing.Point(78, 20)
        Me.matriks1Text.Multiline = True
        Me.matriks1Text.Name = "matriks1Text"
        Me.matriks1Text.Size = New System.Drawing.Size(316, 87)
        Me.matriks1Text.TabIndex = 3
        '
        'operasiCombo
        '
        Me.operasiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.operasiCombo.FormattingEnabled = True
        Me.operasiCombo.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.operasiCombo.Location = New System.Drawing.Point(78, 119)
        Me.operasiCombo.Name = "operasiCombo"
        Me.operasiCombo.Size = New System.Drawing.Size(316, 21)
        Me.operasiCombo.TabIndex = 4
        '
        'matriks2Text
        '
        Me.matriks2Text.Location = New System.Drawing.Point(78, 151)
        Me.matriks2Text.Multiline = True
        Me.matriks2Text.Name = "matriks2Text"
        Me.matriks2Text.Size = New System.Drawing.Size(316, 91)
        Me.matriks2Text.TabIndex = 5
        '
        'hasilText
        '
        Me.hasilText.Location = New System.Drawing.Point(77, 257)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.Size = New System.Drawing.Size(317, 91)
        Me.hasilText.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hasil"
        '
        'hitungButton
        '
        Me.hitungButton.Location = New System.Drawing.Point(324, 364)
        Me.hitungButton.Name = "hitungButton"
        Me.hitungButton.Size = New System.Drawing.Size(69, 26)
        Me.hitungButton.TabIndex = 8
        Me.hitungButton.Text = "Hitung"
        Me.hitungButton.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.hitungButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.matriks2Text)
        Me.Controls.Add(Me.operasiCombo)
        Me.Controls.Add(Me.matriks1Text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents matriks1Text As System.Windows.Forms.TextBox
    Friend WithEvents operasiCombo As System.Windows.Forms.ComboBox
    Friend WithEvents matriks2Text As System.Windows.Forms.TextBox
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hitungButton As System.Windows.Forms.Button
End Class
