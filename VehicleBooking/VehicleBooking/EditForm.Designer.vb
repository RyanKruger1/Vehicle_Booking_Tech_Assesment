<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.model = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.notes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Please specify booking details"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(233, 122)
        Me.dtp.MaxDate = New Date(2020, 12, 11, 0, 0, 0, 0)
        Me.dtp.MinDate = New Date(2020, 1, 13, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 20)
        Me.dtp.TabIndex = 26
        Me.dtp.Value = New Date(2020, 1, 13, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 56)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Edit Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Car Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Name"
        '
        'model
        '
        Me.model.Location = New System.Drawing.Point(233, 91)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(100, 20)
        Me.model.TabIndex = 21
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(233, 64)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(100, 20)
        Me.Name.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 56)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Update Booking"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Notes"
        '
        'notes
        '
        Me.notes.Location = New System.Drawing.Point(233, 154)
        Me.notes.Name = "notes"
        Me.notes.Size = New System.Drawing.Size(100, 20)
        Me.notes.TabIndex = 30
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 294)
        Me.Controls.Add(Me.notes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.Name)
        '  Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents dtp As Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents model As Windows.Forms.TextBox
    Friend WithEvents Name As Windows.Forms.TextBox
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents notes As Windows.Forms.TextBox
End Class
