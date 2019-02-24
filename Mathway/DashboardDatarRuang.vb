Public Class Dashboard
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub DashboardDatarRuang_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox47.Parent = PictureBox1
        Label72.Parent = PictureBox1
        MinimizedImg.Parent = PictureBox1
        CloseBtnTop.Parent = PictureBox1
        PanelBangunDatar.Parent = PictureBox1
        PanelDragging.Parent = PictureBox1
        PanelBangunRuang.Parent = PictureBox1
        LabelOptDatar.ForeColor = Color.DodgerBlue
        PanelBangunRuang.Hide()
        PanelLingkaran.Parent = PictureBox1
        PanelBola.Parent = PictureBox1
        LabelValidasiLingkaran2.Hide()
        LabelValidasiLingkaran1.Hide()
        PanelSegitiga.Parent = PictureBox1
        PanelKerucut.Parent = PictureBox1
        PanelPersegiPanjang.Parent = PictureBox1
        PanelTabung.Parent = PictureBox1
        PanelSegitiga.Parent = PictureBox1
        PanelPersegi.Parent = PictureBox1
        PanelBalok.Parent = PictureBox1
        PanelKubus.Parent = PictureBox1
        PanelBelahKetupat.Parent = PictureBox1
        'HIDE ALL PANEL'
        PanelLingkaran.Hide()
        PanelBola.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelSegitiga.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
        'CHECK WHO IS LOGIN'
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
        End If
    End Sub

    Private Sub CloseBtnTop_Click(sender As Object, e As EventArgs) Handles CloseBtnTop.Click
        End
    End Sub

    Private Sub MinimizedImg_Click(sender As Object, e As EventArgs) Handles MinimizedImg.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LabelOptDatar_Click(sender As Object, e As EventArgs) Handles LabelOptDatar.Click
        LabelOptDatar.ForeColor = Color.DodgerBlue
        LabelOptRuang.ForeColor = Color.Black
        PanelBangunDatar.Show()
        PanelBangunRuang.Hide()
    End Sub

    Private Sub LabelOptRuang_Click(sender As Object, e As EventArgs) Handles LabelOptRuang.Click
        LabelOptDatar.ForeColor = Color.Black
        LabelOptRuang.ForeColor = Color.DodgerBlue
        PanelBangunDatar.Hide()
        PanelBangunRuang.Show()
    End Sub

    Private Sub PanelDragging_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelDragging.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub PanelDragging_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelDragging.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub PanelDragging_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelDragging.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextInputLingkaran.TextChanged
        If IsNumeric(TextInputLingkaran.Text) Then
            LabelValidasiLingkaran2.Hide()
        Else
            LabelValidasiLingkaran2.Show()
            LabelValidasiLingkaran1.Hide()
        End If
    End Sub

    Private Sub HitungHasilLingkaranButton_Click(sender As Object, e As EventArgs) Handles HitungHasilLingkaranButton.Click
        If IsNumeric(TextInputLingkaran.Text) Then
            Dim luas As Double
            Dim keliling As Double

            luas = 3.14 * (TextInputLingkaran.Text * TextInputLingkaran.Text)
            keliling = 3.14 * 2 * TextInputLingkaran.Text

            InputLingkaranHasilLuas.Text = luas
            InputLingkaranHasilKeliling.Text = keliling
            PanelGroupKurungLuas.Hide()
            'RUMUS'
            'LUAS LINGKARAN'            
            LabelHasilKurung.Visible = True
            LabelHasilKurung.Text = "(" + TextInputLingkaran.Text.ToString() + " x " + TextInputLingkaran.Text.ToString() + ")"
            LabelHasilLuasInRumus.Text = "L = " + luas.ToString()
            'KELILING LINGKARAN'
            LabelkelilingJariJari.Text = TextInputLingkaran.Text.ToString()
            LabelHasilKelilingInRumus.Text = "kll = " + keliling.ToString()
        End If

        If IsInputChar(TextInputLingkaran.Text) Then
            LabelValidasiLingkaran2.Show()
        End If

        If TextInputLingkaran.Text = "" Then
            LabelValidasiLingkaran1.Show()
            LabelValidasiLingkaran2.Hide()
        End If
    End Sub

    Private Sub LabelLingkaranWhy_Click(sender As Object, e As EventArgs) Handles LabelLingkaranWhy.Click
        LabelLingkaranWhy.Text = "- Tampilkan Rumus"
        LabelLingkaranWhy.Cursor = Cursors.Arrow
        PanelLingkaranHasilWhy.Visible = True
    End Sub

    Private Sub HitungHasilLingkaranButton_MouseEnter(sender As Object, e As EventArgs) Handles HitungHasilLingkaranButton.MouseEnter
        HitungHasilLingkaranButton.Image = My.Resources.button_hitung
    End Sub

    Private Sub HitungHasilLingkaranButton_MouseLeave(sender As Object, e As EventArgs) Handles HitungHasilLingkaranButton.MouseLeave
        HitungHasilLingkaranButton.Image = My.Resources.button_hitung_hover
    End Sub

    Private Sub LabelSidebarLingkaran_Click(sender As Object, e As EventArgs) Handles LabelSidebarLingkaran.Click
        PanelLingkaran.Show()
        PanelBola.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
    End Sub

    Private Sub LabelSidebarBola_Click(sender As Object, e As EventArgs) Handles LabelSidebarBola.Click
        PanelBola.Show()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles buttonBackHome.Click
        DashboardWelcome.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles buttonHitungBola.Click
        If IsNumeric(TextBoxJariJariBola.Text) Then
            Dim volume As Double
            Dim luas_permukaan As Double

            volume = 4 / 3 * 3.14 * Val(TextBoxJariJariBola.Text) ^ 3
            luas_permukaan = 4 * 3.14 * Val(TextBoxJariJariBola.Text) ^ 2

            TextBoxHasilVolume.Text = volume
            TextBoxHasilLuasPermukaan.Text = luas_permukaan
            'RUMUS'
            'Volume Bola'            
            LabelRumusVolumebola.Text = "V = 4 / 3 x 3.14 x " + TextBoxJariJariBola.Text.ToString + "^3"
            LabelHasilVolumeBola.Text = "V = " + volume.ToString
            'Luas Permukaan Bola'            
            LabelLPRBola.Text = "L = 4 x 3.14 x  " + TextBoxJariJariBola.Text.ToString + "^2"
            LabelHasilLPRBola.Text = "L = " + luas_permukaan.ToString
        Else
            validasiBolaKosong.Visible = False
            validasiBolaHarusAngka.Visible = True
        End If

        If TextBoxJariJariBola.Text = "" Then
            validasiBolaKosong.Visible = True
            validasiBolaHarusAngka.Visible = False
        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        Label33.Text = "- Tampilkan Rumus"
        Label33.Cursor = Cursors.Arrow
        PanelRumusBola.Visible = True
    End Sub

    Private Sub buttonHitungBola_MouseEnter(sender As Object, e As EventArgs) Handles buttonHitungBola.MouseEnter
        buttonHitungBola.Image = My.Resources.button_hitung_hover
    End Sub

    Private Sub buttonHitungBola_MouseLeave(sender As Object, e As EventArgs) Handles buttonHitungBola.MouseLeave
        buttonHitungBola.Image = My.Resources.button_hitung
    End Sub

    Private Sub LabelSidebarSegitiga_Click(sender As Object, e As EventArgs) Handles LabelSidebarSegitiga.Click
        PanelSegitiga.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles ButtonHitungSegitiga.Click
        If IsNumeric(TextboxAlasSegitiga.Text) And IsNumeric(TextboxTinggiSegitiga.Text) Then
            Dim luas_segitiga As Double


            luas_segitiga = 0.5 * Val(TextboxAlasSegitiga.Text) * Val(TextboxTinggiSegitiga.Text)

            TextboxHasilLuasSegitiga.Text = luas_segitiga
            'RUMUS'
            'Luas Segitiga'            
            LabelRumusSegitiga.Text = "L = 0.5 x " + TextboxAlasSegitiga.Text.ToString + " x " + TextboxTinggiSegitiga.Text.ToString
            LabelHasilLuasSegitiga.Text = "L = " + luas_segitiga.ToString
            ValidasiLuasSegitiga.Visible = False
        Else
            ValidasiLuasSegitiga.Text = "Inputan harus berupa angka"
            ValidasiLuasSegitiga.Visible = True
        End If

        If TextboxAlasSegitiga.Text = "" And TextboxTinggiSegitiga.Text = "" Then
            ValidasiLuasSegitiga.Text = "Inputan tidak boleh kosong"
            ValidasiLuasSegitiga.Visible = True
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Label24.Text = "- Tampilkan Rumus"
        Label24.Cursor = Cursors.Arrow
        PanelRumusSegitiga.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If IsNumeric(TextboxSisiPertamaSegitiga.Text) And IsNumeric(TextboxSisiKeduaSegitiga.Text) Then
            If IsNumeric(TextboxSisiKetigaSegitiga.Text) Then
                Dim kll_segitiga As Double


                kll_segitiga = Val(TextboxSisiPertamaSegitiga.Text) + Val(TextboxSisiKeduaSegitiga.Text) + Val(TextboxSisiKetigaSegitiga.Text)

                TextboxHasilKelilingSegitiga.Text = kll_segitiga
                'RUMUS'
                'Luas Segitiga'            
                Label21.Text = "kll = " + TextboxSisiPertamaSegitiga.Text.ToString + " + " + TextboxSisiKeduaSegitiga.Text.ToString + " + " + TextboxSisiKetigaSegitiga.Text
                Label7.Text = "kll = " + kll_segitiga.ToString
                ValidasiKelilingSegitiga.Visible = False
            Else
                ValidasiKelilingSegitiga.Text = "Inputan harus berupa angka"
                ValidasiKelilingSegitiga.Visible = True
            End If
        Else
            ValidasiKelilingSegitiga.Text = "Inputan harus berupa angka"
            ValidasiKelilingSegitiga.Visible = True
        End If

        If TextboxSisiPertamaSegitiga.Text = "" And TextboxSisiKeduaSegitiga.Text = "" Then
            ValidasiKelilingSegitiga.Text = "Inputan tidak boleh kosong"
            ValidasiKelilingSegitiga.Visible = True
        ElseIf TextboxSisiKetigaSegitiga.Text = "" Then
            ValidasiKelilingSegitiga.Text = "Inputan tidak boleh kosong"
            ValidasiKelilingSegitiga.Visible = True
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If IsNumeric(inputjarikerucut.Text) And IsNumeric(inputtinggikerucut.Text) Then
            Dim alaskerucut As Double
            Dim volumekecurut As Double


            alaskerucut = 3.14 * Val(inputtinggikerucut.Text) ^ 2
            volumekecurut = 1 / 3 * 3.14 * Val(inputtinggikerucut.Text) ^ 2 * Val(inputjarikerucut.Text)
            hasilalaskerucut.Text = alaskerucut
            hasilvolumekerucut.Text = volumekecurut
            'RUMUS'
            'KERUCUT'            
            labelrumusalaskerucut.Text = "L = 3,14 x " + inputtinggikerucut.Text.ToString + " ^ 2 "
            labelhasilalaskerucut.Text = "L = " + alaskerucut.ToString
            labelrumusvolumekerucut.Text = "V = 1/3 x 3.14 x " + inputtinggikerucut.Text.ToString + " ^ 2 x " + inputjarikerucut.Text.ToString
            labelhasilvolumekerucut.Text = "V = " + volumekecurut.ToString
            ValidasiInputKerucut.Visible = False
        Else
            ValidasiInputKerucut.Text = "Inputan harus berupa angka"
            ValidasiInputKerucut.Visible = True
        End If

        If inputjarikerucut.Text = "" And inputtinggikerucut.Text = "" Then
            ValidasiInputKerucut.Text = "Inputan tidak boleh kosong"
            ValidasiInputKerucut.Visible = True
        End If
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click
        Label53.Text = "- Tampilkan Rumus"
        Label53.Cursor = Cursors.Arrow
        PanelRumusKerucut.Show()
    End Sub

    Private Sub LabelSidebarKerucut_Click(sender As Object, e As EventArgs) Handles LabelSidebarKerucut.Click
        PanelKerucut.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If IsNumeric(inputpanjangpersegipanjang.Text) And IsNumeric(inputlebarpersegipanjang.Text) Then
            Dim luaspersegipanjang As Double
            Dim kelilingpersegipanjang As Double


            luaspersegipanjang = Val(inputpanjangpersegipanjang.Text) * Val(inputlebarpersegipanjang.Text)
            kelilingpersegipanjang = 2 * (Val(inputpanjangpersegipanjang.Text) + Val(inputlebarpersegipanjang.Text))
            hasilluaspersegipanjang.Text = luaspersegipanjang
            hasilkelilingpersegipanjang.Text = kelilingpersegipanjang
            'RUMUS'
            'PERSEGI PANJANG'            
            panelrumusluaspersegipanjang.Text = "L = " + inputpanjangpersegipanjang.Text.ToString + " x " + inputlebarpersegipanjang.Text.ToString
            panelhasilluas.Text = "L = " + luaspersegipanjang.ToString
            panelrumuskelilingpersegipanjang.Text = "K = 2 x (" + inputpanjangpersegipanjang.Text.ToString + " + " + inputlebarpersegipanjang.Text.ToString + " )"
            panelhasilkeliling.Text = "K = " + kelilingpersegipanjang.ToString
            validasiinputpersegipanjang.Visible = False
        Else
            validasiinputpersegipanjang.Text = "Inputan harus berupa angka"
            validasiinputpersegipanjang.Visible = True
        End If

        If inputpanjangpersegipanjang.Text = "" And inputlebarpersegipanjang.Text = "" Then
            validasiinputpersegipanjang.Text = "Inputan tidak boleh kosong"
            validasiinputpersegipanjang.Visible = True
        End If
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        PanelRumusPersegiPanjang.Show()
    End Sub

    Private Sub LabelSidebarPersegiPanjang_Click(sender As Object, e As EventArgs) Handles LabelSidebarPersegiPanjang.Click
        PanelPersegiPanjang.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If IsNumeric(inputjaritabung.Text) And IsNumeric(inputtinggitabung.Text) Then
            Dim volumetabung As Double
            Dim selimuttabung As Double


            volumetabung = 3.14 * Val(inputjaritabung.Text) ^ 2 * Val(inputtinggitabung.Text)
            selimuttabung = 2 * 3.14 * Val(inputjaritabung.Text) * Val(inputtinggitabung.Text)
            hasilvolumetabung.Text = volumetabung
            hasilselimuttabung.Text = selimuttabung
            'RUMUS'
            'TABUNG'            
            labelrumusvolumetabung.Text = "V = 3,14 x " + inputjaritabung.Text.ToString + "^2 x " + inputtinggitabung.Text.ToString
            labelhasilvolumetabung.Text = "V = " + volumetabung.ToString
            labelrumusluastabung.Text = "L = 2 x 3,14 x " + inputjaritabung.Text.ToString + " x " + inputtinggitabung.Text.ToString
            labelhasilvolumetabung.Text = "L = " + selimuttabung.ToString
            validasitabung.Visible = False
        Else
            validasitabung.Text = "Inputan harus berupa angka"
            validasitabung.Visible = True
        End If

        If inputjaritabung.Text = "" And inputtinggitabung.Text = "" Then
            validasitabung.Text = "Inputan tidak boleh kosong"
            validasitabung.Visible = True
        End If
    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click
        Label64.Text = "- Tampilkan Rumus"
        Label64.Cursor = Cursors.Arrow
        PanelRumusTabung.Show()
    End Sub

    Private Sub LabelSidebarTabung_Click(sender As Object, e As EventArgs) Handles LabelSidebarTabung.Click
        PanelTabung.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        Label73.Text = "- Tampilkan Rumus"
        Label73.Cursor = Cursors.Arrow
        PanelRumusPersegi.Show()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        If IsNumeric(TextboxSisiPersegi.Text) Then
            Dim luaspersegi As Double
            Dim kelilingpersegi As Double


            luaspersegi = Val(TextboxSisiPersegi.Text) * Val(TextboxSisiPersegi.Text)
            kelilingpersegi = 4 * Val(TextboxSisiPersegi.Text)
            TextboxHasilLuasPersegi.Text = luaspersegi
            TextBoxHasilKelilingPersegi.Text = kelilingpersegi
            'RUMUS'
            'PERSEGI'            
            LabelRumusLuasPersegi.Text = "L = " + TextboxSisiPersegi.Text.ToString + " x " + TextboxSisiPersegi.Text.ToString
            LabelHasilLuasPersegi.Text = "L = " + luaspersegi.ToString
            LabelRumusKelilingPersegi.Text = "Kll = 4 x " + TextboxSisiPersegi.Text.ToString
            LabelHasilKelilingPersegi.Text = "Kll = " + kelilingpersegi.ToString
            LabelValidasiPersegi.Visible = False
        Else
            LabelValidasiPersegi.Text = "Inputan harus berupa angka"
            LabelValidasiPersegi.Visible = True
        End If

        If TextboxSisiPersegi.Text = "" Then
            LabelValidasiPersegi.Text = "Inputan tidak boleh kosong"
            LabelValidasiPersegi.Visible = True
        End If
    End Sub

    Private Sub LabelSidebarPersegi_Click(sender As Object, e As EventArgs) Handles LabelSidebarPersegi.Click
        PanelPersegi.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        If IsNumeric(TextBoxPanjangBalok.Text) And IsNumeric(TextBoxLebarBalok.Text) Then
            If IsNumeric(TextBoxTinggiBalok.Text) Then
                Dim luas_balok As Double
                Dim volume_balok As Decimal

                Dim panjang As Decimal = TextBoxPanjangBalok.Text
                Dim lebar As Decimal = TextBoxLebarBalok.Text
                Dim tinggi As Decimal = TextBoxTinggiBalok.Text

                luas_balok = 2 * (Val(TextBoxPanjangBalok.Text) * Val(TextBoxLebarBalok.Text) + Val(TextBoxPanjangBalok.Text) * Val(TextBoxTinggiBalok.Text) + Val(TextBoxLebarBalok.Text) * Val(TextBoxTinggiBalok.Text))
                TextBoxHasilLuasBalok.Text = luas_balok
                TextBoxHasilVolumeBalok.Text = panjang * lebar * tinggi
                volume_balok = panjang * lebar * tinggi
                'RUMUS'
                'Luas Balok'            
                LabelRumusLuasBalok.Text = "L = 2 x " + "(" + TextBoxPanjangBalok.Text.ToString + " x " + TextBoxLebarBalok.Text.ToString + " + " + TextBoxPanjangBalok.Text.ToString + " x " + TextBoxTinggiBalok.Text.ToString + " + " + TextBoxLebarBalok.Text.ToString + " x " + TextBoxTinggiBalok.Text.ToString + ")"
                LabelHasilLuasBalok.Text = "L = " + luas_balok.ToString
                LabelRumusVolumeBalok.Text = "V = " + panjang.ToString + " x " + lebar.ToString + " x " + tinggi.ToString
                LabelHasilVolumeBalok.Text = "V = " + volume_balok.ToString
                LabelValidasiBalok.Visible = False
            Else
                LabelValidasiBalok.Text = "Inputan harus berupa angka"
                LabelValidasiBalok.Visible = True
            End If
        Else
            LabelValidasiBalok.Text = "Inputan harus berupa angka"
            LabelValidasiBalok.Visible = True
        End If

        If TextBoxPanjangBalok.Text = "" And TextBoxLebarBalok.Text = "" Then
            LabelValidasiBalok.Text = "Inputan tidak boleh kosong"
            LabelValidasiBalok.Visible = True
        ElseIf TextBoxTinggiBalok.Text = "" Then
            LabelValidasiBalok.Text = "Inputan tidak boleh kosong"
            LabelValidasiBalok.Visible = True
        End If
    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click
        Label80.Text = "- Tampilkan Rumus"
        Label80.Cursor = Cursors.Arrow
        PanelRumusBalok.Show()
    End Sub

    Private Sub LabelSidebarBalok_Click(sender As Object, e As EventArgs) Handles LabelSidebarBalok.Click
        PanelBalok.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelKubus.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub Label92_Click(sender As Object, e As EventArgs) Handles Label92.Click
        Label92.Text = "- Tampilkan Rumus"
        Label92.Cursor = Cursors.Arrow
        PanelRumusKubus.Show()
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        If IsNumeric(TextBoxSisiKubus.Text) Then
            Dim luasPermukaanKubus As Double
            Dim VolumeKubus As Double


            luasPermukaanKubus = 6 * Val(TextBoxSisiKubus.Text) * Val(TextBoxSisiKubus.Text)
            VolumeKubus = Val(TextBoxSisiKubus.Text) * Val(TextBoxSisiKubus.Text) * Val(TextBoxSisiKubus.Text)
            TextBoxHasilLuasKubus.Text = luasPermukaanKubus
            TextBoxHasilVolumeKubus.Text = VolumeKubus
            'RUMUS'
            'Kubus'            
            LabelRumusLuasKubus.Text = "L = 6 x " + TextBoxSisiKubus.Text.ToString + " x " + TextBoxSisiKubus.Text.ToString
            LabelHasilLuasKubus.Text = "L = " + luasPermukaanKubus.ToString
            LabelRumusVolumeKubus.Text = "V = " + TextBoxSisiKubus.Text.ToString + " x " + TextBoxSisiKubus.Text.ToString + " x " + TextBoxSisiKubus.Text.ToString
            LabelHasilVolumeKubus.Text = "V = " + VolumeKubus.ToString
            LabelValidasiKubus.Visible = False
        Else
            LabelValidasiKubus.Text = "Inputan harus berupa angka"
            LabelValidasiKubus.Visible = True
        End If

        If TextBoxSisiKubus.Text = "" Then
            LabelValidasiKubus.Text = "Inputan tidak boleh kosong"
            LabelValidasiKubus.Visible = True
        End If
    End Sub

    Private Sub LabelSidebarKubus_Click(sender As Object, e As EventArgs) Handles LabelSidebarKubus.Click
        PanelKubus.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelBelahKetupat.Hide()
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If IsNumeric(TextboxSisiBelahKetupat.Text) Then
            Dim kelilingBelahKetupat As Double

            kelilingBelahKetupat = 4 * Val(TextboxSisiBelahKetupat.Text)
            TextboxHasilKelilingBelahKetupat.Text = kelilingBelahKetupat
            'RUMUS'
            'Kubus'            
            LabelRumusKelilingBelahKetupat.Text = "Kll = 4 x " + TextboxSisiBelahKetupat.Text.ToString
            LabelHasilKelilingBelahKetupat.Text = "Kll = " + kelilingBelahKetupat.ToString
            LabelValidasiBelahKetupat.Visible = False
        Else
            LabelValidasiBelahKetupat.Text = "Inputan harus berupa angka"
            LabelValidasiBelahKetupat.Visible = True
        End If

        If TextboxSisiBelahKetupat.Text = "" Then
            LabelValidasiBelahKetupat.Text = "Inputan tidak boleh kosong"
            LabelValidasiBelahKetupat.Visible = True
        End If
    End Sub

    Private Sub Label93_Click(sender As Object, e As EventArgs) Handles Label93.Click
        Label93.Text = "- Tampilkan Rumus"
        Label93.Cursor = Cursors.Arrow
        PanelRumusBelahKetupat.Show()
    End Sub

    Private Sub LabelSidebarBelahKetupat_Click(sender As Object, e As EventArgs) Handles LabelSidebarBelahKetupat.Click
        PanelBelahKetupat.Show()
        PanelBola.Hide()
        PanelLingkaran.Hide()
        PanelSegitiga.Hide()
        PanelKerucut.Hide()
        PanelPersegiPanjang.Hide()
        PanelTabung.Hide()
        PanelPersegi.Hide()
        PanelBalok.Hide()
        PanelKubus.Hide()
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        DashboardWelcome.Show()
        Me.Close()
    End Sub
End Class