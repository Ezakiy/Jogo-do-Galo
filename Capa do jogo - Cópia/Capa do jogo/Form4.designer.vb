<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblWord = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lstLetters = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblWord.Location = New System.Drawing.Point(151, 144)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(270, 93)
        Me.lblWord.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(213, 9)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 39)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Nivel 1"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "3.png")
        Me.ImageList.Images.SetKeyName(1, "3.1.png")
        Me.ImageList.Images.SetKeyName(2, "3.2.png")
        Me.ImageList.Images.SetKeyName(3, "4.png")
        Me.ImageList.Images.SetKeyName(4, "4.1.png")
        Me.ImageList.Images.SetKeyName(5, "5.png")
        '
        'lstLetters
        '
        Me.lstLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLetters.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lstLetters.FormattingEnabled = True
        Me.lstLetters.ItemHeight = 24
        Me.lstLetters.Location = New System.Drawing.Point(14, 22)
        Me.lstLetters.Name = "lstLetters"
        Me.lstLetters.Size = New System.Drawing.Size(71, 316)
        Me.lstLetters.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(346, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Nivel 2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(474, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Nivel 3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(661, 75)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(246, 263)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicture.TabIndex = 2
        Me.picPicture.TabStop = False
        Me.picPicture.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capa_do_jogo.My.Resources.Resources.x
        Me.PictureBox1.Location = New System.Drawing.Point(832, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lstLetters)
        Me.Controls.Add(Me.picPicture)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents picPicture As PictureBox
    Friend WithEvents ImageList As ImageList
    Friend WithEvents lstLetters As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
