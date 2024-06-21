Partial Class Form4
    Private lblTitle As Label
    Private lblName As Label
    Private lblEmail As Label
    Private lblPhone As Label
    Private lblGitHub As Label
    Private lblStopwatch As Label
    Private txtName As TextBox
    Private txtEmail As TextBox
    Private txtPhone As TextBox
    Private txtGitHub As TextBox
    Private btnToggleStopwatch As Button
    Private btnSubmit As Button

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
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(239, 21)
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
        Me.lblPhone.Size = New System.Drawing.Size(84, 19)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGitHub
        '
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGitHub.Location = New System.Drawing.Point(15, 135)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(136, 19)
        Me.lblGitHub.TabIndex = 4
        Me.lblGitHub.Text = "GitHub Link For Task 2"
        Me.lblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopwatch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStopwatch.Location = New System.Drawing.Point(280, 163)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(70, 25)
        Me.lblStopwatch.TabIndex = 5
        Me.lblStopwatch.Text = "00:00:00"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 25)
        Me.txtName.TabIndex = 6
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 25)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 25)
        Me.txtPhone.TabIndex = 8
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(150, 130)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(200, 25)
        Me.txtGitHub.TabIndex = 9
        Me.txtGitHub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.LightYellow
        Me.btnToggleStopwatch.ForeColor = System.Drawing.Color.Black
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(10, 160)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(260, 30)
        Me.btnToggleStopwatch.TabIndex = 10
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(10, 200)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(340, 30)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 250)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form4"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
