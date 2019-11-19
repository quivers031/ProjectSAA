Module Module1

    Sub Main()
        Dim tictac(3, 3) As String
        Dim menang As String = ""
        Dim giliran As Integer = 0
        Dim kosong As Boolean
        Dim simpan As Boolean = False
        Dim x1 As Integer
        Dim y1 As Integer
        Dim countx As Integer = 0
        Dim county As Integer = 1
        Dim main As Integer = 0
        While menang = ""
            Console.Clear()
            'ini baris
            If tictac(1, 1) = "O" And tictac(1, 2) = "O" And tictac(1, 3) = "O" Then
                menang = "O"
                Exit While
            ElseIf tictac(2, 1) = "O" And tictac(2, 2) = "O" And tictac(2, 3) = "O" Then
                menang = "O"
                Exit While
            ElseIf tictac(3, 1) = "O" And tictac(3, 2) = "O" And tictac(3, 3) = "O" Then
                menang = "O"
                Exit While
                'ini kolom
            ElseIf tictac(1, 1) = "O" And tictac(2, 1) = "O" And tictac(3, 1) = "O" Then
                menang = "O"
                Exit While
            ElseIf tictac(1, 2) = "O" And tictac(2, 2) = "O" And tictac(3, 2) = "O" Then
                menang = "O"
                Exit While
            ElseIf tictac(1, 3) = "O" And tictac(2, 3) = "O" And tictac(3, 3) = "O" Then
                menang = "O"
                Exit While
                'ini diagonal
            ElseIf tictac(1, 1) = "O" And tictac(2, 2) = "O" And tictac(3, 3) = "O" Then
                menang = "O"
                Exit While
            ElseIf tictac(3, 1) = "O" And tictac(2, 2) = "O" And tictac(1, 3) = "O" Then
                menang = "O"
                Exit While
                'ini X
            ElseIf tictac(1, 1) = "X" And tictac(1, 2) = "X" And tictac(1, 3) = "X" Then
                menang = "X"
                Exit While
            ElseIf tictac(2, 1) = "X" And tictac(2, 2) = "X" And tictac(2, 3) = "X" Then
                menang = "X"
                Exit While
            ElseIf tictac(3, 1) = "X" And tictac(3, 2) = "X" And tictac(3, 3) = "X" Then
                menang = "X"
                Exit While
                'ini kolom
            ElseIf tictac(1, 1) = "X" And tictac(2, 1) = "X" And tictac(3, 1) = "X" Then
                menang = "X"
                Exit While
            ElseIf tictac(1, 2) = "X" And tictac(2, 2) = "X" And tictac(3, 2) = "X" Then
                menang = "X"
                Exit While
            ElseIf tictac(1, 3) = "X" And tictac(2, 3) = "X" And tictac(3, 3) = "X" Then
                menang = "X"
                Exit While
                'ini diagonal
            ElseIf tictac(1, 1) = "X" And tictac(2, 2) = "X" And tictac(3, 3) = "X" Then
                menang = "X"
                Exit While
            ElseIf tictac(3, 1) = "X" And tictac(2, 2) = "X" And tictac(1, 3) = "X" Then
                menang = "X"
                Exit While
            ElseIf main = 9 Then
                menang = "NO"
                Exit While
            End If
            giliran += 1
            For j = 1 To 7
                For i = 1 To 7
                    If i Mod 2 = 1 And j Mod 2 = 1 Then
                        Console.Write("+")
                    ElseIf i = 1 Or i = 7 Or i Mod 2 = 1 Then
                        Console.Write("|")
                    ElseIf i Mod 2 = 0 And j Mod 2 = 0 Then
                        countx += 1
                        If tictac(countx, county) = "X" Then
                            Console.Write("X")
                        ElseIf tictac(countx, county) = "O" Then
                            Console.Write("O")
                        Else
                            kosong = True
                        End If
                        If kosong = True Then
                            Console.Write(" ")
                        End If
                        kosong = False
                    Else
                        Console.Write("-")
                    End If
                Next
                Console.WriteLine()
                If j Mod 2 = 0 Then
                    county += 1
                End If
                countx = 0
            Next
            If giliran Mod 2 = 1 Then
                While simpan = False
                    Console.WriteLine("Giliran Pemain 1 (O)")
                    Console.Write("Masukkan baris : ")
                    y1 = Console.ReadLine()
                    Console.Write("Masukkan kolom : ")
                    x1 = Console.ReadLine()
                    If tictac(x1, y1) <> "" Then
                        Console.WriteLine("Posisi telah terisi. Silahkan pilih posisi yang lain.")
                    Else
                        tictac(x1, y1) = "O"
                        simpan = True
                    End If

                End While
                main += 1
            Else
                While simpan = False
                    Console.WriteLine("Giliran Pemain 2 (X)")
                    Console.Write("Masukkan baris : ")
                    y1 = Console.ReadLine()
                    Console.Write("Masukkan kolom : ")
                    x1 = Console.ReadLine()
                    If tictac(x1, y1) <> "" Then
                        Console.WriteLine("Posisi telah terisi. Silahkan pilih posisi yang lain.")
                    Else
                        tictac(x1, y1) = "X"
                        simpan = True
                    End If
                End While
                main += 1
            End If
            simpan = False
            county = 1
        End While
        For j = 1 To 7
            For i = 1 To 7
                If i Mod 2 = 1 And j Mod 2 = 1 Then
                    Console.Write("+")
                ElseIf i = 1 Or i = 7 Or i Mod 2 = 1 Then
                    Console.Write("|")
                ElseIf i Mod 2 = 0 And j Mod 2 = 0 Then
                    countx += 1
                    If tictac(countx, county) = "X" Then
                        Console.Write("X")
                    ElseIf tictac(countx, county) = "O" Then
                        Console.Write("O")
                    Else
                        kosong = True
                    End If
                    If kosong = True Then
                        Console.Write(" ")
                    End If
                    kosong = False
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
            If j Mod 2 = 0 Then
                county += 1
            End If
            countx = 0
        Next
        If menang = "O" Then
            Console.WriteLine("Selamat Pemenangnya adalah pemain pertama!")
        ElseIf menang = "X" Then
            Console.WriteLine("Selamat Pemenangnya adalah pemain kedua!")
        ElseIf menang = "NO" Then
            Console.WriteLine("Tidak ada pemenang karena papan sudah penuh!")
        End If
        Console.ReadKey()
    End Sub

End Module
