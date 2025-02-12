﻿Option Strict On
Option Explicit On
Option Compare Text
'Jason Permann
'Spring 2025
'RCET2265
'Array Exampel
'https://github.com/JaceFoxman/ArrayExampels.git

Imports System.Security.Cryptography

Module ArrayExampel

    Sub Main()

        'Arrays
        Dim fruits(5) As String 'must specify length desired in (). starts at 0 goes to x
        Dim names() As String = {"John", "Paul", "ringo", "jeff"} 'creates length based on number of items put in the {}
        Dim beanCounts = New Integer() {12342, 343, 1234, 4646}

        'stores item based on index number, must fall in the range of 0 to x
        fruits(0) = "bannana"
        fruits(1) = "apple"
        fruits(2) = "orange"
        fruits(3) = "grape"
        fruits(4) = "mango"
        fruits(5) = "pinapple"

        Console.WriteLine($"{fruits(1)}") 'calls stored item based on index number, must fall in the range of 0 to x

        Console.WriteLine($"{names(3)}") 'calls name as long as it falls into array size no need to index

        For i = LBound(beanCounts) To UBound(beanCounts) 'displays whole array 
            Console.WriteLine(beanCounts(i))
        Next

        MultiDimensionalArrays()
        TestRandomness()


    End Sub
    Sub SimpleArrays()

    End Sub

    Sub MultiDimensionalArrays()

        Dim students(14, 2) As Single 'rows and collums, still 0 to x. total length should be 15 X 3
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}} 'need a comma after something else to show that its 2 dimensions
        Dim threeDimensionArray(,,) As Integer = {{{1, 2, 3}}, {{4, 5, 6}}, {{7, 8, 9}}} 'need 2 comma inside paranthises to show 3 dimesnsions

        students(3, 0) = 75.43
        students(3, 1) = 85.66
        students(3, 2) = 94.7

        Console.WriteLine(students)

    End Sub
    Sub TestRandomness()
        Dim numberCounter(20) As Integer

        For i = 1 To 100
            numberCounter(RandomNumberBetween(3, 10)) += 1
        Next

        For i = LBound(numberCounter) To UBound(numberCounter)
            Console.WriteLine($"{CStr(i).PadLeft(4)} hit {CStr(numberCounter(i)).PadLeft(4)}")
        Next

    End Sub
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function

End Module
