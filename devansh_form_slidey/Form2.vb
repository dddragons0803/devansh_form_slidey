Imports System.Diagnostics
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class Form2
    Inherits System.Windows.Forms.Form

    Private lblTitle As Label
    Private lblIndex As Label
    Private lblName As Label
    Private lblEmail As Label
    Private lblPhone As Label
    Private lblGitHub As Label
    Private lblStopwatch As Label
    Private txtName As TextBox
    Private txtEmail As TextBox
    Private txtPhone As TextBox
    Private txtGitHub As TextBox
    Private txtStopwatch As TextBox
    Private btnToggleStopwatch As Button
    Private btnSubmit As Button
    Private btnPrevious As Button
    Private btnNext As Button
    Private index As Integer
    Private dataCount As Integer
    Private btnDelete As Button

    Public Sub New()
        InitializeComponent()
        btnDelete = New Button()
        btnDelete.Text = "DELETE FORM (CTRL + D)"
        btnDelete.Location = New Point(15, 240)
        btnDelete.Size = New Size(330, 30)
        btnDelete.Font = New Font("Microsoft Sans Serif", 10.0!)
        btnDelete.BackColor = Color.LightCoral
        btnDelete.ForeColor = Color.Black
        AddHandler btnDelete.Click, AddressOf DeleteForm
        Controls.Add(btnDelete)
        ' Create and configure the lblIndex label
        lblIndex = New Label()
        lblIndex.AutoSize = True
        lblIndex.Font = New Font("Microsoft Sans Serif", 10.0!)
        lblIndex.Location = New Point(15, 90) ' Adjust the location as needed
        Controls.Add(lblIndex)


        index = 0 ' Initial index
        FetchData()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check if Ctrl+P is pressed for Previous
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick() ' Simulate a click on the Previous button
            Return True ' Indicate that the keystroke was handled
        End If

        ' Check if Ctrl+N is pressed for Next
        If keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick() ' Simulate a click on the Next button
            Return True ' Indicate that the keystroke was handled
        End If

        ' Check if Ctrl+D is pressed for Delete
        If keyData = (Keys.Control Or Keys.D) Then
            DeleteForm(Nothing, Nothing) ' Simulate a click on the Delete button
            Return True ' Indicate that the keystroke was handled
        End If


        Return MyBase.ProcessCmdKey(msg, keyData) ' Allow normal processing of keystrokes


    End Function

    Private Sub DeleteForm(sender As Object, e As EventArgs)
        Try
            ' Send a DELETE request to the API to delete the current form
            Dim client As New HttpClient()
            Dim apiUrl As String = "http://localhost:3000/delete?index=" & index
            Dim response As HttpResponseMessage = client.DeleteAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Form deleted successfully!")
                ' Reset the form fields or navigate to a different form
                FetchData()
            Else
                MessageBox.Show("Failed to delete form. Error: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub FetchData()
        Try
            ' Fetch data from API based on index
            Dim client As New HttpClient()
            Dim countUrl As String = "http://localhost:3000/count"
            Dim countResponse As HttpResponseMessage = client.GetAsync(countUrl).Result

            If countResponse.IsSuccessStatusCode Then
                Dim countData As String = countResponse.Content.ReadAsStringAsync().Result
                dataCount = Convert.ToInt32(countData.Count)
            Else
                MessageBox.Show("Failed to fetch data count from API. Error: " & countResponse.ReasonPhrase)
            End If

            Dim apiUrl As String = "http://localhost:3000/read?index=" & index
            Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

            If response.IsSuccessStatusCode Then
                Dim responseData As String = response.Content.ReadAsStringAsync().Result
                Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseData)

                If data.ContainsKey("name") Then
                    Me.txtName.Text = data("name")
                End If

                If data.ContainsKey("email") Then
                    Me.txtEmail.Text = data("email")
                End If

                If data.ContainsKey("phone") Then
                    Me.txtPhone.Text = data("phone")
                End If

                If data.ContainsKey("github_link") Then
                    Me.txtGitHub.Text = data("github_link")
                End If

                If data.ContainsKey("stopwatch_time") Then
                    Me.txtStopwatch.Text = data("stopwatch_time")
                End If


            Else
                MessageBox.Show("No More Data Available")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try



    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        If index > 0 Then
            index -= 1
            FetchData()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        If index < dataCount - 1 Then
            index += 1
            FetchData()
        End If
    End Sub
End Class
