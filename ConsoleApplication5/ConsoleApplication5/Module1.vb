Module Module1

    Sub Main()
        While Not False
            Console.Clear()
            Console.WriteLine("The Roman <> Arabic Text Converter")
            Console.Write("Input here : ")
            Dim input As String = Console.ReadLine()
            Dim arabic As Integer
            Dim roman As String
            Dim angka As Integer


            Try
                arabic = input
                If arabic >= 4000 Then
                    Console.WriteLine("Input cannot bigger than 4000")
                ElseIf arabic <= 0 Then
                    Console.WriteLine("Input cannot lower than 0")
                Else
                    While arabic >= 1000
                        Console.Write("M")
                        arabic = arabic - 1000
                    End While
                    If arabic >= 900 Then
                        Console.Write("CM")
                        arabic = arabic - 900
                    End If
                    If arabic >= 500 Then
                        Console.Write("D")
                        arabic = arabic - 500
                    End If
                    If arabic >= 400 Then
                        Console.Write("CD")
                        arabic = arabic - 400
                    End If
                    While arabic >= 100
                        Console.Write("C")
                        arabic = arabic - 100
                    End While
                    If arabic >= 90 Then
                        Console.Write("XC")
                        arabic = arabic - 90
                    End If
                    If arabic >= 50 Then
                        Console.Write("L")
                        arabic = arabic - 50
                    End If
                    If arabic >= 40 Then
                        Console.Write("XL")
                        arabic = arabic - 40
                    End If
                    While arabic >= 10
                        Console.Write("X")
                        arabic = arabic - 10
                    End While
                    If arabic >= 9 Then
                        Console.Write("IX")
                        arabic = arabic - 9
                    End If
                    If arabic >= 5 Then
                        Console.Write("V")
                        arabic = arabic - 5
                    End If
                    If arabic >= 4 Then
                        Console.Write("IV")
                        arabic = arabic - 4
                    End If
                    While arabic >= 1
                        Console.Write("I")
                        arabic = arabic - 1
                    End While

                End If
            Catch ex As Exception
                roman = input + "  "

                While roman(0) = "M"
                    roman = roman.Substring(1)
                    angka = angka + 1000
                End While

                If roman(0) = "C" And roman(1) = "M" Then
                    roman = roman.Substring(2)
                    angka = angka + 900
                End If
                If roman(0) = "D" Then
                    roman = roman.Substring(1)
                    angka = angka + 500
                End If
                If roman(0) = "C" And roman(1) = "D" Then
                    roman = roman.Substring(2)
                    angka = angka + 400
                End If
                While roman(0) = "C"
                    roman = roman.Substring(1)
                    angka = angka + 100
                End While
                If roman(0) = "X" And roman(1) = "C" Then
                    roman = roman.Substring(2)
                    angka = angka + 90
                End If
                If roman(0) = "L" Then
                    roman = roman.Substring(1)
                    angka = angka + 50
                End If
                If roman(0) = "X" And roman(1) = "L" Then
                    roman = roman.Substring(2)
                    angka = angka + 40
                End If
                While roman(0) = "X"
                    roman = roman.Substring(1)
                    angka = angka + 10
                End While
                If roman(0) = "I" And roman(1) = "X" Then
                    roman = roman.Substring(2)
                    angka = angka + 9
                End If
                If roman(0) = "V" Then
                    roman = roman.Substring(1)
                    angka = angka + 5
                End If
                If roman(0) = "I" And roman(1) = "V" Then
                    roman = roman.Substring(2)
                    angka = angka + 4
                End If
                While roman(0) = "I"
                    roman = roman.Substring(1)
                    angka = angka + 1
                End While


                'If roman(0) = "M" Then
                '    angka = angka + 1000
                '    roman = roman.Substring(1)

                'ElseIf roman(0) = "D" Then
                '    angka = angka + 500
                '    roman = roman.Substring(1)

                'ElseIf roman(0) = "C" Then
                '    angka = angka + 100
                '    roman = roman.Substring(1)

                'ElseIf roman(0) = "L" Then
                '    angka = angka + 50
                '    roman = roman.Substring(1)

                'ElseIf roman(0) = "V" Then
                '    angka = angka + 5
                '    roman = roman.Substring(1)

                'ElseIf roman(0) = "I" Then
                '    angka = angka + 1
                '    roman = roman.Substring(1)
                'End If
                Console.Write(angka)



            End Try
            'Dim jarak As String = "MMMDCCCLXXXIVIII"
            'Console.Write(jarak.Length)
            Console.ReadKey()
            angka = 0
        End While


    End Sub

End Module