Imports System.Diagnostics
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Public Class Form4
    Inherits System.Windows.Forms.Form

    Private stopwatchRunning As Boolean = False
    Private stopwatch As New Stopwatch()
    Private timer As New Timer()


    Public Sub New()
        InitializeComponent()
        timer.Interval = 1000 ' 1 second
        AddHandler timer.Tick, AddressOf UpdateStopwatchLabel
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check if Ctrl+T is pressed for toggling the stopwatch
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleStopwatch(Nothing, Nothing) ' Toggle the stopwatch
            Return True ' Indicate that the keystroke was handled
        End If

        ' Check if Ctrl+S is pressed for saving the form
        If keyData = (Keys.Control Or Keys.S) Then
            SubmitForm(Nothing, Nothing) ' Save the form
            Return True ' Indicate that the keystroke was handled
        End If

        Return MyBase.ProcessCmdKey(msg, keyData) ' Allow normal processing of keystrokes
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btnToggleStopwatch IsNot Nothing AndAlso btnSubmit IsNot Nothing Then
            AddHandler btnToggleStopwatch.Click, AddressOf ToggleStopwatch
            AddHandler btnSubmit.Click, AddressOf SubmitForm
        Else
            MessageBox.Show("One or both buttons are not initialized.")
        End If
    End Sub

    Private Sub ToggleStopwatch(sender As Object, e As EventArgs)
        stopwatchRunning = Not stopwatchRunning

        If stopwatchRunning Then
            stopwatch.Start()
            timer.Start()
            btnToggleStopwatch.Text = "STOP STOPWATCH (CTRL + T)"
        Else
            stopwatch.Stop()
            timer.Stop()
            btnToggleStopwatch.Text = "START STOPWATCH (CTRL + T)"
        End If
    End Sub

    Private Sub UpdateStopwatchLabel(sender As Object, e As EventArgs)
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Me.lblStopwatch.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                              CInt(elapsed.TotalHours),
                                              elapsed.Minutes,
                                              elapsed.Seconds)
    End Sub

    Private Async Sub SubmitForm(sender As Object, e As EventArgs)
        Dim client As New HttpClient()
        Dim apiUrl As String = "http://localhost:3000/submit"
        Dim formData As New Dictionary(Of String, String) From {
        {"name", txtName.Text},
        {"email", txtEmail.Text},
        {"phone", txtPhone.Text},
        {"github_link", txtGitHub.Text},
        {"stopwatch_time", lblStopwatch.Text}
    }

        Dim content As New StringContent(JsonConvert.SerializeObject(formData), Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Form submitted successfully!")
        Else
            MessageBox.Show("Failed to submit form. Error: " & response.ReasonPhrase)
        End If
    End Sub


    Private Sub lblTitle_Click(sender As Object, e As EventArgs)
        ' Code to handle the Click event for lblTitle
    End Sub

End Class