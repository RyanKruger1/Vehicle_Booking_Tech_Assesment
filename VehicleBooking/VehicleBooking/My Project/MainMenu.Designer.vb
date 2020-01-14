<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.bookings = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.completed = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Show bookings for date:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(184, 44)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 2
        '
        'bookings
        '
        Me.bookings.Location = New System.Drawing.Point(390, 14)
        Me.bookings.Name = "bookings"
        Me.bookings.Size = New System.Drawing.Size(373, 249)
        Me.bookings.TabIndex = 3
        Me.bookings.Text = ""
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(11, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Show upcomming bookings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'completed
        '
        Me.completed.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.completed.Location = New System.Drawing.Point(11, 100)
        Me.completed.Name = "completed"
        Me.completed.Size = New System.Drawing.Size(167, 23)
        Me.completed.TabIndex = 5
        Me.completed.Text = "Show completed bookings"
        Me.completed.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete booking"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(13, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button5.Size = New System.Drawing.Size(165, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Show All bookings"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(13, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Edit Booking"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.completed)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bookings)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents dtp1 As Windows.Forms.DateTimePicker
    Friend WithEvents bookings As Windows.Forms.RichTextBox
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents completed As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents Button6 As Windows.Forms.Button
End Class
