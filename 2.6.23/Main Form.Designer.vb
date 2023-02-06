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
        Me.lbFlavors = New System.Windows.Forms.ListBox()
        Me.picFlavors = New System.Windows.Forms.PictureBox()
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbFlavors
        '
        Me.lbFlavors.FormattingEnabled = True
        Me.lbFlavors.Items.AddRange(New Object() {"Vanilla", "Chocolate ", "Strawberry", "Mint Chocolate Chip", "Birthday Cake"})
        Me.lbFlavors.Location = New System.Drawing.Point(272, 77)
        Me.lbFlavors.Name = "lbFlavors"
        Me.lbFlavors.Size = New System.Drawing.Size(150, 82)
        Me.lbFlavors.TabIndex = 2
        '
        'picFlavors
        '
        Me.picFlavors.Location = New System.Drawing.Point(34, 31)
        Me.picFlavors.Name = "picFlavors"
        Me.picFlavors.Size = New System.Drawing.Size(201, 188)
        Me.picFlavors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlavors.TabIndex = 1
        Me.picFlavors.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 268)
        Me.Controls.Add(Me.lbFlavors)
        Me.Controls.Add(Me.picFlavors)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picFlavors As PictureBox
    Friend WithEvents lbFlavors As ListBox
End Class
