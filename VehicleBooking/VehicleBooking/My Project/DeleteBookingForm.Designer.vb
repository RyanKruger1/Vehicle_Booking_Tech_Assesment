<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBookingForm
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
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.model = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(263, 123)
        Me.dtp.MaxDate = New Date(2020, 12, 11, 0, 0, 0, 0)
        Me.dtp.MinDate = New Date(2020, 1, 13, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 20)
        Me.dtp.TabIndex = 18
        Me.dtp.Value = New Date(2020, 1, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Car Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name"
        '
        'model
        '
        Me.model.Location = New System.Drawing.Point(263, 92)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(100, 20)
        Me.model.TabIndex = 11
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(263, 65)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(100, 20)
        Me.Name.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 56)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Delete Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Please specify booking details"
        '
        'DeleteBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(470, 263)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.Name)
        ' Me.Name = "DeleteBookingForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents model As Windows.Forms.TextBox
    Friend WithEvents Name As Windows.Forms.TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
