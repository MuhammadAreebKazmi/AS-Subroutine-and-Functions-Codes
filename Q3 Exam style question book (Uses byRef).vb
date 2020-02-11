Module Module1

    Sub Main()
        'Question 3 of Exam style book questions
        Dim eggnumbers, boxnumber, eggsleft As Integer
        'Number of egss could've been input as well
        eggnumbers = 567
        boxnumber = 0
        eggsleft = 0

        Call EggsIntoBoxes(eggnumbers, boxnumber, eggsleft)

        Console.WriteLine("Eggs = " & eggnumbers)
        Console.WriteLine("Full boxes = " & boxnumber)
        Console.WriteLine("Eggs leftovers = " & eggsleft)
        Console.ReadKey()
    End Sub

    Sub EggsintoBoxes(ByVal NoOfEggs As Integer, ByRef NoOfBoxes As Integer, _
                      ByRef EggsLeftOver As Integer)
        NoOfBoxes = NoOfEggs \ 6
        EggsLeftOver = NoOfEggs Mod 6
    End Sub

End Module
