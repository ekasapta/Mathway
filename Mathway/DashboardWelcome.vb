Public Class DashboardWelcome
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub DashboardWelcome_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictCloseForm.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        Label5.Parent = PictureBox1
        PanelSatuanJarak.Parent = PictureBox1
        PanelKonversiSuhu.Parent = PictureBox1
        PanelSatuanJarak.Hide()
        PanelKonversiSuhu.Hide()

        If Login.logging = "ekasapta" Then
            profileLogging.Image = My.Resources.profile_02
            usernameLabelPict.Text = "Eka Sapta"
        ElseIf Login.logging = "deraananta" Then
            profileLogging.Image = My.Resources.profile_dera_06
            usernameLabelPict.Text = "Dera Ananta"
        ElseIf Login.logging = "wahyudi" Then
            usernameLabelPict.Text = "Wahyudi"
        ElseIf Login.logging = "jennykarmila" Then
            profileLogging.Image = My.Resources.profile_05
            usernameLabelPict.Text = "Jenny Karmila"
        ElseIf Login.logging = "jayaanggara" Then
            profileLogging.Image = My.Resources.profile_04
            usernameLabelPict.Text = "Jaya Anggara"
        Else
            profileLogging.Image = My.Resources.profile_01
            usernameLabelPict.Text = "Guest"
            LabelKSJSidebar.Hide()
        End If

        PanelDraggingTop.Parent = PictureBox1
    End Sub

    Private Sub LabelKKSidebar_MouseEnter(sender As Object, e As EventArgs) Handles LabelKSJSidebar.MouseEnter
        LabelKSJSidebar.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub LabelKKSidebar_MouseLeave(sender As Object, e As EventArgs) Handles LabelKSJSidebar.MouseLeave
        LabelKSJSidebar.ForeColor = Color.Black
    End Sub

    Private Sub LabelKSSidebar_MouseEnter(sender As Object, e As EventArgs) Handles LabelKSSidebar.MouseEnter
        LabelKSSidebar.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub LabelKSSidebar_MouseLeave(sender As Object, e As EventArgs) Handles LabelKSSidebar.MouseLeave
        LabelKSSidebar.ForeColor = Color.Black
    End Sub

    Private Sub LabelOPBSidebar_MouseEnter(sender As Object, e As EventArgs) Handles LabelOPBSidebar.MouseEnter
        LabelOPBSidebar.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub LabelOPBSidebar_MouseLeave(sender As Object, e As EventArgs) Handles LabelOPBSidebar.MouseLeave
        LabelOPBSidebar.ForeColor = Color.Black
    End Sub

    Private Sub pictLogout_Click(sender As Object, e As EventArgs) Handles pictLogout.Click
        Login.logging = ""
        Login.Show()
        Me.Close()
    End Sub

    Private Sub pictLogout_MouseEnter(sender As Object, e As EventArgs) Handles pictLogout.MouseEnter
        helplogout.Show()
    End Sub

    Private Sub pictLogout_MouseLeave(sender As Object, e As EventArgs) Handles pictLogout.MouseLeave
        helplogout.Hide()
    End Sub

    Private Sub PictCloseForm_Click(sender As Object, e As EventArgs) Handles PictCloseForm.Click
        End
    End Sub

    Private Sub LabelOPBSidebar_Click(sender As Object, e As EventArgs) Handles LabelOPBSidebar.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub PanelDraggingTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelDraggingTop.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub PanelDraggingTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelDraggingTop.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub PanelDraggingTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelDraggingTop.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If TextBox1.Text = "" Then
            labelvalidasiksj.Visible = True
            labelvalidasiksj.Text = "Inputan tidak boleh kosong"
        End If

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim hasil As Double
        Dim dari, ke As String

        If RadioButton1.Checked = True Then
            a = 1
            dari = "Kilometer"
        ElseIf RadioButton2.Checked = True Then
            a = 2
            dari = "Hektometer"
        ElseIf RadioButton3.Checked = True Then
            a = 3
            dari = "Dekameter"
        ElseIf RadioButton4.Checked = True Then
            a = 4
            dari = "Meter"
        ElseIf RadioButton5.Checked = True Then
            a = 5
            dari = "Desimeter"
        ElseIf RadioButton6.Checked = True Then
            a = 6
            dari = "Centimeter"
        ElseIf RadioButton7.Checked = True Then
            a = 7
            dari = "Milimeter"
        Else
            labelvalidasiksj.Visible = True
            labelvalidasiksj.Text = "Satuan jarak dari harus di pilih"
        End If

        If RadioButton14.Checked = True Then
            b = 1
            ke = "Kilometer"
        ElseIf RadioButton13.Checked = True Then
            b = 2
            ke = "Hektometer"
        ElseIf RadioButton12.Checked = True Then
            b = 3
            ke = "Dekameter"
        ElseIf RadioButton11.Checked = True Then
            b = 4
            ke = "Meter"
        ElseIf RadioButton10.Checked = True Then
            b = 5
            ke = "Desimeter"
        ElseIf RadioButton9.Checked = True Then
            b = 6
            ke = "Centimeter"
        ElseIf RadioButton8.Checked = True Then
            b = 7
            ke = "Milimeter"
        Else
            labelvalidasiksj.Visible = True
            labelvalidasiksj.Text = "Satuan jarak ke harus di pilih"
        End If

        If IsNumeric(TextBox1.Text) Then
            c = b - a
            hasil = Val(TextBox1.Text) * (10 ^ c)

            LabelHasilSatuanJarak.Visible = True
            LabelHasilSatuanJarak.Text = TextBox1.Text.ToString + " " + dari + " sama dengan " + hasil.ToString + " " + ke
            labelvalidasiksj.Visible = False
        Else
            labelvalidasiksj.Visible = True
            labelvalidasiksj.Text = "Inputan harus berupa angka"
        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If inputansuhu.Text = "" Then
            labelvalidasisuhu.Visible = True
            labelvalidasisuhu.Text = "Inputan tidak boleh kosong"
        End If

        If IsNumeric(inputansuhu.Text) Then
            If suhufahrenheit.Checked = True Then
                Dim cel, rhe, kel As Integer
                hasilsuhufahrenheit.Text = " - "
                cel = Val((inputansuhu.Text) - 32) * 5 / 9
                hasilsuhucelcius.Text = FormatNumber(cel, 2, vbFalse, vbFalse, vbFalse)
                rhe = Val((inputansuhu.Text) - 32) * 4 / 9
                hasilsuhureamur.Text = FormatNumber(rhe, 2, vbFalse, vbFalse, vbFalse)
                kel = Val(((inputansuhu.Text) - 32) * 5 / 9) + 273
                hasilsuhukelvin.Text = FormatNumber(kel, 2, vbFalse, vbFalse, vbFalse)
            ElseIf suhucelcius.Checked = True Then
                Dim fah, rhe, kel As Integer
                hasilsuhucelcius.Text = " - "
                fah = Val((inputansuhu.Text) * 9 / 5) + 32
                hasilsuhufahrenheit.Text = FormatNumber(fah, 2, vbFalse, vbFalse, vbFalse)
                rhe = Val(inputansuhu.Text) * 4 / 5
                hasilsuhureamur.Text = FormatNumber(rhe, 2, vbFalse, vbFalse, vbFalse)
                kel = Val(inputansuhu.Text) + 273
                hasilsuhukelvin.Text = FormatNumber(kel, 2, vbFalse, vbFalse, vbFalse)
            ElseIf suhureamur.Checked = True Then
                Dim fah, cel, kel As Integer
                hasilsuhureamur.Text = " - "
                fah = Val((inputansuhu.Text) * 9 / 4) + 32
                hasilsuhufahrenheit.Text = FormatNumber(fah, 2, vbFalse, vbFalse, vbFalse)
                cel = Val(inputansuhu.Text) * 5 / 4
                hasilsuhucelcius.Text = FormatNumber(cel, 2, vbFalse, vbFalse, vbFalse)
                kel = Val((inputansuhu.Text) * 5 / 4) + 273
                hasilsuhukelvin.Text = FormatNumber(kel, 2, vbFalse, vbFalse, vbFalse)
            ElseIf suhukelvin.Checked = True Then
                Dim fah, cel, rhe As Integer
                hasilsuhukelvin.Text = " - "
                fah = Val((((inputansuhu.Text) - 273) * 9 / 5)) + 32
                hasilsuhufahrenheit.Text = FormatNumber(fah, 2, vbFalse, vbFalse, vbFalse)
                cel = Val(inputansuhu.Text) - 273
                hasilsuhucelcius.Text = FormatNumber(cel, 2, vbFalse, vbFalse, vbFalse)
                rhe = Val((inputansuhu.Text) - 273) * 4 / 5
                hasilsuhureamur.Text = FormatNumber(rhe, 2, vbFalse, vbFalse, vbFalse)
            Else
                labelvalidasisuhu.Visible = True
                labelvalidasisuhu.Text = "Satuan Suhu harus dipilih"
            End If
            labelvalidasisuhu.Visible = False
        Else
            labelvalidasisuhu.Visible = True
            labelvalidasisuhu.Text = "Inputan harus berupa angka"
        End If
    End Sub

    Private Sub PictureBox10_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox10.MouseEnter
        PictureBox10.Image = My.Resources.button_hitung_hover
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        PictureBox10.Image = My.Resources.button_hitung
    End Sub

    Private Sub LabelKSSidebar_Click(sender As Object, e As EventArgs) Handles LabelKSSidebar.Click
        PictureBox2.Hide()
        PanelSatuanJarak.Hide()
        PanelKonversiSuhu.Show()
    End Sub

    Private Sub LabelKSJSidebar_Click(sender As Object, e As EventArgs) Handles LabelKSJSidebar.Click
        PictureBox2.Hide()
        PanelSatuanJarak.Show()
        PanelKonversiSuhu.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = My.Resources.button_hitung_hover
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.button_hitung
    End Sub
End Class
