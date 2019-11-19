Imports System.Console
Module Module1

    Sub Main()
        Dim inputan As Integer
        Dim inputan2 As Integer = 1
        Dim ukurankotak As Integer
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim N As Integer = 0
        Dim cekgenap As String = "false"
        Dim cekprima As String = "False"
        WriteLine("Menu Penggambaran")
        WriteLine("1. Komponen Gambar")
        WriteLine("2. Gambar Bangun")
        WriteLine("3. Keluar")
        inputan = ReadLine()

        While inputan <> 3
            If inputan = 1 Then
                WriteLine("Menu Komponen")
                WriteLine("1. Bintang")
                WriteLine("2. Bilangan Genap")
                WriteLine("3. Bilangan Prima")
                inputan2 = ReadLine()
            ElseIf inputan = 2 Then
                Write("Ukuran Kotak")
                ukurankotak = ReadLine()

                If inputan2 = 1 Then
                    For i = 1 To ukurankotak
                        For j = 1 To ukurankotak
                            If j = 1 Or j = ukurankotak Then
                                Write("*")
                            ElseIf i = 1 Or i = ukurankotak Then
                                Write("*")
                            Else
                                Write(" ")
                            End If
                        Next
                        WriteLine()
                    Next

                ElseIf inputan2 = 2 Then
                    A = 0
                    B = 0
                    For i = 1 To ukurankotak
                        For j = 1 To ukurankotak
                            If j = 1 Or j = ukurankotak Then
                                While cekgenap = "false"
                                    If A Mod 2 = 0 Then
                                        If A >= 10 Then
                                            B = A Mod 10
                                        Else
                                            B = A
                                        End If
                                        cekgenap = "True"
                                    End If
                                    A = A + 1
                                End While
                                cekgenap = "false"
                                Write(B)
                            ElseIf i = 1 Or i = ukurankotak Then
                                While cekgenap = "false"

                                    If A Mod 2 = 0 Then
                                        If A >= 10 Then
                                            B = A Mod 10
                                        Else
                                            B = A
                                        End If
                                        cekgenap = "True"
                                    End If
                                    A = A + 1
                                End While
                                cekgenap = "false"
                                Write(B)
                            Else
                                Write(" ")
                            End If
                        Next
                        WriteLine()
                    Next

                ElseIf inputan2 = 3 Then
                    A = 0
                    B = 0
                    N = 0
                    For i = 1 To ukurankotak
                        For j = 1 To ukurankotak
                            If j = 1 Or j = ukurankotak Then
                                While cekprima = "False"
                                    N = N + 1
                                    A = 0
                                    For k = 1 To N
                                        If N Mod k = 0 Then
                                            A = A + 1
                                        End If
                                    Next
                                    If A = 2 Then
                                        cekprima = "true"
                                        If N >= 10 Then
                                            B = N Mod 10
                                        Else
                                            B = N
                                        End If
                                    End If
                                End While
                                Write(B)
                                cekprima = "False"
                            ElseIf i = 1 Or i = ukurankotak Then
                                While cekprima = "False"
                                    N = N + 1
                                    A = 0
                                    For k = 1 To N
                                        If N Mod k = 0 Then
                                            A = A + 1
                                        End If
                                    Next
                                    If A = 2 Then
                                        cekprima = "true"
                                        If N >= 10 Then
                                            B = N Mod 10
                                        Else
                                            B = N
                                        End If
                                    End If
                                End While
                                Write(B)
                                cekprima = "False"
                            Else
                                Write(" ")
                            End If
                        Next
                        WriteLine()
                    Next
                End If

            End If

            WriteLine("Menu Penggambaran")
            WriteLine("1. Komponen Gambar")
            WriteLine("2. Gambar Bangun")
            WriteLine("3. Keluar")
            inputan = ReadLine()
        End While


    End Sub

End Module
