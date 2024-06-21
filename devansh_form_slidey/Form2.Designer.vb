Partial Class Form2
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Devansh Gulati, Slidely Task 2"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblName.Location = New System.Drawing.Point(15, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 19)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(15, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 19)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhone.Location = New System.Drawing.Point(15, 105)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(90, 19)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGitHub
        '
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGitHub.Location = New System.Drawing.Point(15, 135)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(128, 19)
        Me.lblGitHub.TabIndex = 4
        Me.lblGitHub.Text = "GitHub Link For Task 2"
        Me.lblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStopwatch.Location = New System.Drawing.Point(15, 165)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(113, 19)
        Me.lblStopwatch.TabIndex = 5
        Me.lblStopwatch.Text = "Stopwatch Time"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 25)
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.TabIndex = 6
        Me.txtName.ReadOnly = True
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 25)
        Me.txtEmail.BackColor = System.Drawing.Color.LightGray
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 25)
        Me.txtPhone.BackColor = System.Drawing.Color.LightGray
        Me.txtPhone.TabIndex = 8
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(150, 130)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(200, 25)
        Me.txtGitHub.TabIndex = 9
        Me.txtGitHub.BackColor = System.Drawing.Color.LightGray
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(150, 160)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.Size = New System.Drawing.Size(200, 25)
        Me.txtStopwatch.BackColor = System.Drawing.Color.LightGray
        Me.txtStopwatch.TabIndex = 10
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(15, 200)
        Me.btnPrevious.Size = New System.Drawing.Size(165, 35)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.BackColor = System.Drawing.Color.LightYellow
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnPrevious.UseVisualStyleBackColor = False
        AddHandler Me.btnPrevious.Click, AddressOf Me.btnPrevious_Click
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(190, 200)
        Me.btnNext.Size = New System.Drawing.Size(160, 35)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnNext.UseVisualStyleBackColor = False
        AddHandler Me.btnNext.Click, AddressOf Me.btnNext_Click
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 280)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
