Public Class Form1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check if Ctrl+V is pressed for View Submissions
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmissions.PerformClick() ' Simulate a click on the View Submissions button
            Return True ' Indicate that the keystroke was handled
        End If

        ' Check if Ctrl+N is pressed for Create New Submission
        If keyData = (Keys.Control Or Keys.N) Then
            btnCreateNewSubmission.PerformClick() ' Simulate a click on the Create New Submission button
            Return True ' Indicate that the keystroke was handled
        End If

        Return MyBase.ProcessCmdKey(msg, keyData) ' Allow normal processing of keystrokes
    End Function

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New Form2()
        AddHandler viewForm.FormClosed, AddressOf HandleViewFormClosed
        viewForm.ShowDialog() ' Use ShowDialog to ensure modal behavior
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New Form4()
        AddHandler createForm.FormClosed, AddressOf HandleCreateFormClosed
        createForm.ShowDialog() ' Use ShowDialog to ensure modal behavior
    End Sub

    Private Sub HandleViewFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Handle actions after Form2 is closed, if needed
        ' For example, refresh data in Form1 after changes in Form2
    End Sub

    Private Sub HandleCreateFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Handle actions after Form4 is closed, if needed
        ' For example, refresh data in Form1 after new submission in Form4
    End Sub

End Class
