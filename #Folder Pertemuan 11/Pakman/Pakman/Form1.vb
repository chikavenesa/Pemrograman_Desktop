Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    'map (peta papan permainan)
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 9 'musuh itu di petak x berapa
    Dim enmy = 7 ' petak y
    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0
    'deklarasi sprite citra yang digunakan
    Dim folder = Application.StartupPath
    Dim wall As Image = Image.FromFile(folder + "\aset\bata.png")
    Dim way As Image = Image.FromFile(folder + "\aset\rumput.png")
    Dim pac As Image = Image.FromFile(folder + "\aset\pakman.png")
    Dim enm As Image = Image.FromFile(folder + "\aset\hantu3.png")
    Dim goal As Image = Image.FromFile(folder + "\aset\omah.jpg")

    Dim pacBawah As Image = Image.FromFile(folder + "\aset\pakman2.png")
    Dim pacKiri As Image = Image.FromFile(folder + "\aset\pakman3.png")
    Dim pacAtas As Image = Image.FromFile(folder + "\aset\pakman4.png")

    Dim nyawa As Integer = 3
    Dim sprite As Image = Image.FromFile(folder + "\aset\nyawa.png")

    Dim enm2 As Image = Image.FromFile(folder + "\aset\hantu1.png")
    Dim enm3 As Image = Image.FromFile(folder + "\aset\hantu2.png")
    Dim enmx2 = 1, enmy2 = 7
    Dim enmx3 = 9, enmy3 = 1



    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        'gambarkan background (jalan dan tembok)

        'For y = 0 To 8 '0 to 8 yaitu tinggi map - 1
        '    For x = 0 To 10 '0 to 10 yaitu lebar map - 1
        '        If map(y, x) = 0 Then
        '            g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
        '        Else
        '            g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
        '        End If
        '    Next
        'Next

        For y = 0 To map.GetUpperBound(0)
            For x = 0 To map.GetUpperBound(1)
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        'gambarkan pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        'gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)

        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)
        g.DrawImage(enm3, enmx3 * tsz, enmy3 * tsz, tsz, tsz)

        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        For i = 0 To nyawa - 1
            g.DrawImage(sprite, i * 45, PictureBox1.Height - 30, 40, 30) 'posisi bawah kanan
        Next

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    pac = pacAtas
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    pac = pacBawah
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    pac = Image.FromFile(folder + "\aset\pakman.png")
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    pac = pacKiri
                End If
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''engine untuk musuh
        'Dim jarakx, jaraky As Integer
        'Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        ''cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        ''kalau lebih dekat di sb y, kejar ke sb y dulu
        'jarakx = Math.Abs(pacx - enmx)
        'jaraky = Math.Abs(pacy - enmy)
        'If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
        '    If (pacx - enmx > 0) Then 'jika pakman di kanan
        '        arah = 1 'arah kanan
        '    Else 'jika tidak
        '        arah = 3 'arah kiri
        '    End If
        'End If
        'If jarakx < jaraky Then
        '    If (pacy - enmy > 0) Then 'jika pakman di bawah
        '        arah = 2 'arah bawah
        '    Else 'jika tidak
        '        arah = 0 'arah atas
        '    End If
        'End If
        'If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
        '    arah = Math.Floor(Rnd() * 4)
        'End If
        'Select Case arah
        '    Case 0
        '        If map(enmy - 1, enmx) = 1 Then
        '            enmy = enmy - 1
        '        End If
        '    Case 2
        '        If map(enmy + 1, enmx) = 1 Then
        '            enmy = enmy + 1
        '        End If
        '    Case 1
        '        If map(enmy, enmx + 1) = 1 Then
        '            enmx = enmx + 1
        '        End If
        '    Case 3
        '        If map(enmy, enmx - 1) = 1 Then
        '            enmx = enmx - 1
        '        End If
        'End Select

        ''HANTU 2
        'jarakx = Math.Abs(pacx - enmx2)
        'jaraky = Math.Abs(pacy - enmy2)
        'If jarakx > jaraky Then
        '    arah = If(pacx > enmx2, 1, 3)
        'ElseIf jaraky > jarakx Then
        '    arah = If(pacy > enmy2, 2, 0)
        'Else
        '    arah = Math.Floor(Rnd() * 4)
        'End If
        'Select Case arah
        '    Case 0 : If map(enmy2 - 1, enmx2) = 1 Then enmy2 -= 1
        '    Case 1 : If map(enmy2, enmx2 + 1) = 1 Then enmx2 += 1
        '    Case 2 : If map(enmy2 + 1, enmx2) = 1 Then enmy2 += 1
        '    Case 3 : If map(enmy2, enmx2 - 1) = 1 Then enmx2 -= 1
        'End Select

        ''HANTU 3
        'jarakx = Math.Abs(pacx - enmx3)
        'jaraky = Math.Abs(pacy - enmy3)
        'If jarakx > jaraky Then
        '    arah = If(pacx > enmx3, 1, 3)
        'ElseIf jaraky > jarakx Then
        '    arah = If(pacy > enmy3, 2, 0)
        'Else
        '    arah = Math.Floor(Rnd() * 4)
        'End If

        'HANTU 1
        Dim nextBlock As Point = BFSearch(enmx, enmy, pacx, pacy)
        enmx = nextBlock.X
        enmy = nextBlock.Y

        'HANTU 2
        nextBlock = BFSearch(enmx2, enmy2, pacx, pacy)
        enmx2 = nextBlock.X
        enmy2 = nextBlock.Y

        'HANTU 3
        nextBlock = BFSearch(enmx3, enmy3, pacx, pacy)
        enmx3 = nextBlock.X
        enmy3 = nextBlock.Y




        'oldpacx = pacx
        'oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        'If (pacx = enmx) And (pacy = enmy) Then
        '    Timer1.Enabled = False
        '    MsgBox("Pakman Dies!")
        'End If
        If (pacx = enmx And pacy = enmy) Or (pacx = enmx2 And pacy = enmy2) Or (pacx = enmx3 And pacy = enmy3) Then
            nyawa -= 1
            If nyawa = 0 Then
                Timer1.Enabled = False
                MsgBox("Pakman Dies!")
            Else
                pacx = 1 : pacy = 1
                enmx = 9 : enmy = 7
                enmx2 = 1 : enmy2 = 7
                enmx3 = 9 : enmy3 = 1
            End If
            Redraw()
        End If



        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub

    Private Function BFSearch(startX As Integer, startY As Integer, goalX As Integer, goalY As Integer) As Point
        Dim visited(map.GetLength(0) - 1, map.GetLength(1) - 1) As Boolean
        Dim queue As New Queue(Of Point)
        Dim parent(map.GetLength(0) - 1, map.GetLength(1) - 1) As Point

        queue.Enqueue(New Point(startX, startY))
        visited(startY, startX) = True

        Dim arah = {New Point(0, -1), New Point(1, 0), New Point(0, 1), New Point(-1, 0)}

        While queue.Count > 0
            Dim p = queue.Dequeue()
            If p.X = goalX And p.Y = goalY Then
                Exit While
            End If

            For Each d In arah
                Dim nx = p.X + d.X
                Dim ny = p.Y + d.Y
                If nx >= 0 AndAlso nx <= map.GetUpperBound(1) AndAlso ny >= 0 AndAlso ny <= map.GetUpperBound(0) Then
                    If map(ny, nx) = 1 AndAlso Not visited(ny, nx) Then
                        queue.Enqueue(New Point(nx, ny))
                        visited(ny, nx) = True
                        parent(ny, nx) = p
                    End If
                End If
            Next
        End While

        Dim langkah = New List(Of Point)
        Dim cur As New Point(goalX, goalY)

        While Not (cur.X = startX And cur.Y = startY)
            langkah.Insert(0, cur)
            cur = parent(cur.Y, cur.X)
        End While

        If langkah.Count > 0 Then
            Return langkah(0)
        Else
            Return New Point(startX, startY)
        End If
    End Function

End Class
