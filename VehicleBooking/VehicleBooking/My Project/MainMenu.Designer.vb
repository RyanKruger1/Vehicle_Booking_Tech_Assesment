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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.completed = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Show bookings for date:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(182, 162)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(9, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Show upcomming bookings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'completed
        '
        Me.completed.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.completed.Location = New System.Drawing.Point(9, 218)
        Me.completed.Name = "completed"
        Me.completed.Size = New System.Drawing.Size(167, 23)
        Me.completed.TabIndex = 5
        Me.completed.Text = "Show completed bookings"
        Me.completed.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(11, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete booking"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button5.Size = New System.Drawing.Size(165, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Show All bookings"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(11, 278)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Edit Booking"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GridView1
        '
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(388, 91)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.Size = New System.Drawing.Size(400, 258)
        Me.GridView1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Welcome to Vehicle Booking Application"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Please make your selection:"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.completed)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents dtp1 As Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents completed As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents Button6 As Windows.Forms.Button
    Friend WithEvents GridView1 As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
