Public Class Login
    Public Shared logging As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoginBlue.Parent = PictureBox1
        LoginGreen.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label6.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label8.Parent = PictureBox1
        Label5.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        LabelFailedLog.Parent = PictureBox1
        LabelFailedLog.Hide()
    End Sub

    Private Sub LoginBlue_MouseEnter(sender As Object, e As EventArgs) Handles LoginBlue.MouseEnter
        LoginBlue.Image = My.Resources.button_03_hover
    End Sub

    Private Sub LoginBlue_MouseLeave(sender As Object, e As EventArgs) Handles LoginBlue.MouseLeave
        LoginBlue.Image = My.Resources.button_04
    End Sub

    Private Sub LoginGreen_MouseEnter(sender As Object, e As EventArgs) Handles LoginGreen.MouseEnter
        LoginGreen.Image = My.Resources.buttonGreen_06_05
    End Sub
    Private Sub LoginGreen_MouseLeave(sender As Object, e As EventArgs) Handles LoginGreen.MouseLeave
        LoginGreen.Image = My.Resources.button_05
    End Sub

    Private Sub LoginGreen_Click(sender As Object, e As EventArgs) Handles LoginGreen.Click
        logging = ("guest").ToString
        Me.Hide()
        DashboardWelcome.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        EmailText.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        PasswordText.Focus()
    End Sub

    Private Sub LoginBlue_Click(sender As Object, e As EventArgs) Handles LoginBlue.Click
        If EmailText.Text = "ekasapta@mathway.com" And PasswordText.Text = "123" Then
            logging = ("ekasapta").ToString
            Me.Hide()
            EmailText.Text = ""
            PasswordText.Text = ""
            DashboardWelcome.Show()
        ElseIf EmailText.Text = "dera.ananta@mathway.com" And PasswordText.Text = "123" Then
            logging = ("deraananta").ToString
            Me.Hide()
            EmailText.Text = ""
            PasswordText.Text = ""
            DashboardWelcome.Show()
        ElseIf EmailText.Text = "wahyudi@mathway.com" And PasswordText.Text = "123" Then
            logging = ("wahyudi").ToString
            Me.Hide()
            EmailText.Text = ""
            PasswordText.Text = ""
            DashboardWelcome.Show()
        ElseIf EmailText.Text = "jennykarmila@mathway.com" And PasswordText.Text = "123" Then
            logging = ("jennykarmila").ToString
            Me.Hide()
            EmailText.Text = ""
            PasswordText.Text = ""
            DashboardWelcome.Show()
        ElseIf EmailText.Text = "jaya.anggara@mathway.com" And PasswordText.Text = "123" Then
            logging = ("jayaanggara").ToString
            Me.Hide()
            EmailText.Text = ""
            PasswordText.Text = ""
            DashboardWelcome.Show()
        Else
            EmailText.Text = ""
            PasswordText.Text = ""
            LabelFailedLog.Show()
        End If
    End Sub

    Private Sub EmailText_TextChanged(sender As Object, e As EventArgs) Handles EmailText.TextChanged
        LabelFailedLog.Hide()
    End Sub

    Private Sub PasswordText_TextChanged(sender As Object, e As EventArgs) Handles PasswordText.TextChanged
        LabelFailedLog.Hide()
    End Sub
End Class
