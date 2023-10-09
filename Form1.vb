Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices


Public Class Form1
    Dim Panel1New As Panel
    Dim tubes_count_Label As Label
    Dim tubes_capacity_Label As Label
    Dim colors_count_label As Label
    Dim tubes_count_textBox As TextBox
    Dim tubes_capacity_textBox As TextBox
    Dim colors_count_textBox As TextBox
    Dim Panel1Submit As Button
    Dim Panel1Reset As Button
    Dim Tube_Count_New As Integer
    Dim Tube_Capacity_New As Integer
    Dim Colors_Count_New As Integer

    Dim Panel2New As Panel
    Dim subpanel(9) As Panel
    Dim lab(9) As Label
    Dim buttons(9, 6) As Button
    Dim Panel2Submit As Button
    Dim Panel2Reset As Button

    Dim Panel3New As Panel
    Dim colorLabels(14) As Button
    Dim colorPick As Color = Color.Transparent


    Dim Panel4New As Panel
    Dim Solution As ListBox


    Public Class tube
        Public data(6) As Integer
        Public filled As Integer
        Public complete As Integer
    End Class

    Public Class transactionClass
        Public fromIndex As Integer
        Public toIndex As Integer
        Public color As Integer
        Public quantity As Integer
    End Class

    Dim successPath(2047) As transactionClass
    Dim successPathLength As Integer = 0


    Dim tubeHistory(2047, 69) As Integer
    Dim historyCount As Integer = 0






    Private Sub Loader(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1_Load()
        Panel2_Load()
        Panel3_load()
        Panel4_load()
    End Sub














    Public Sub Panel1_Load()
        Panel1New = New Panel
        Me.Controls.Add(Panel1New)
        Panel1New.Height = 270
        Panel1New.Width = 320
        Panel1New.Left = 25
        Panel1New.Top = 50
        Panel1New.Enabled = True
        Panel1New.Visible = True
        Panel1New.BackColor = Color.Yellow

        tubes_count_Label = New Label
        Panel1New.Controls.Add(tubes_count_Label)
        tubes_count_Label.Height = 30
        tubes_count_Label.Width = 110
        tubes_count_Label.Left = 25
        tubes_count_Label.Top = 30
        tubes_count_Label.Text = "Tube Count"
        tubes_count_Label.TextAlign = ContentAlignment.MiddleLeft
        tubes_count_Label.Enabled = True
        tubes_count_Label.Visible = True
        tubes_count_Label.BackColor = Color.Gray


        tubes_capacity_Label = New Label
        Panel1New.Controls.Add(tubes_capacity_Label)
        tubes_capacity_Label.Height = 30
        tubes_capacity_Label.Width = 110
        tubes_capacity_Label.Left = 25
        tubes_capacity_Label.Top = 90
        tubes_capacity_Label.Text = "Tube Capacity"
        tubes_capacity_Label.TextAlign = ContentAlignment.MiddleLeft
        tubes_capacity_Label.Enabled = True
        tubes_capacity_Label.Visible = True
        tubes_capacity_Label.BackColor = Color.Gray

        colors_count_label = New Label
        Panel1New.Controls.Add(colors_count_label)
        colors_count_label.Height = 30
        colors_count_label.Width = 110
        colors_count_label.Left = 25
        colors_count_label.Top = 150
        colors_count_label.Text = "Colors Count"
        colors_count_label.TextAlign = ContentAlignment.MiddleLeft
        colors_count_label.Enabled = True
        colors_count_label.Visible = True
        colors_count_label.BackColor = Color.Gray


        tubes_count_textBox = New TextBox
        Panel1New.Controls.Add(tubes_count_textBox)
        tubes_count_textBox.Height = 30
        tubes_count_textBox.Width = 110
        tubes_count_textBox.Left = 160
        tubes_count_textBox.Top = 30
        tubes_count_textBox.Text = "0"
        tubes_count_textBox.Enabled = True
        tubes_count_textBox.Visible = True
        tubes_count_textBox.BackColor = Color.White

        tubes_capacity_textBox = New TextBox
        Panel1New.Controls.Add(tubes_capacity_textBox)
        tubes_capacity_textBox.Height = 30
        tubes_capacity_textBox.Width = 110
        tubes_capacity_textBox.Left = 160
        tubes_capacity_textBox.Top = 90
        tubes_capacity_textBox.Text = "0"
        tubes_capacity_textBox.Enabled = True
        tubes_capacity_textBox.Visible = True
        tubes_capacity_textBox.BackColor = Color.White

        colors_count_textBox = New TextBox
        Panel1New.Controls.Add(colors_count_textBox)
        colors_count_textBox.Height = 30
        colors_count_textBox.Width = 110
        colors_count_textBox.Left = 160
        colors_count_textBox.Top = 150
        colors_count_textBox.Text = "0"
        colors_count_textBox.Enabled = True
        colors_count_textBox.Visible = True
        colors_count_textBox.BackColor = Color.White

        Panel1Submit = New Button
        Panel1New.Controls.Add(Panel1Submit)
        Panel1Submit.Height = 35
        Panel1Submit.Width = 110
        Panel1Submit.Left = 25
        Panel1Submit.Top = 220
        Panel1Submit.Text = "Submit"
        Panel1Submit.Enabled = True
        Panel1Submit.Visible = True
        Panel1Submit.BackColor = Color.Red
        AddHandler Panel1Submit.Click, AddressOf Panel1Submit_click

        Panel1Reset = New Button
        Panel1New.Controls.Add(Panel1Reset)
        Panel1Reset.Height = 35
        Panel1Reset.Width = 110
        Panel1Reset.Left = 160
        Panel1Reset.Top = 220
        Panel1Reset.Text = "Reset"
        Panel1Reset.Enabled = True
        Panel1Reset.Visible = True
        Panel1Reset.BackColor = Color.Red
        AddHandler Panel1Reset.Click, AddressOf Panel1Reset_click
    End Sub


    Public Sub Panel1Submit_click()
        For i As Integer = 0 To 14
            colorLabels(i).Visible = True
            colorLabels(i).Enabled = True
        Next
        Panel3New.Visible = True
        Panel3New.Enabled = True

        Tube_Count_New = Convert.ToInt16(tubes_count_textBox.Text)
        Tube_Capacity_New = Convert.ToInt16(tubes_capacity_textBox.Text)
        Colors_Count_New = Convert.ToInt16(colors_count_textBox.Text)


        For i As Integer = 0 To (Tube_Count_New - 1)
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                buttons(i, j).Visible = True
                buttons(i, j).Enabled = True
            Next
        Next

        For i As Integer = 0 To (Tube_Count_New - 1)
            subpanel(i).Visible = True
            subpanel(i).Enabled = True

            lab(i).Visible = True
            lab(i).Enabled = True
        Next

        Panel2Submit.Visible = True
        Panel2Submit.Enabled = True

        Panel2Reset.Visible = True
        Panel2Reset.Enabled = True

        Panel2New.Visible = True
        Panel2New.Enabled = True
    End Sub

    Public Sub Panel1Reset_click()
        tubes_count_textBox.Text = "0"
        tubes_capacity_textBox.Text = "0"
        colors_count_textBox.Text = "0"

        Panel2Reset_click()
        For i As Integer = 0 To Tube_Count_New
            For j As Integer = 0 To Tube_Capacity_New
                buttons(i, j).Visible = False
                buttons(i, j).Enabled = False
            Next

            lab(i).Visible = False
            lab(i).Enabled = False

            subpanel(i).Visible = False
            subpanel(i).Enabled = False
        Next

        Panel2New.Visible = False
        Panel2New.Enabled = False

        Panel3New.Visible = False
        Panel3New.Enabled = False

        Solution.Items.Clear()
        Panel4New.Visible = False
        Panel4New.Enabled = False
    End Sub





































    Public Sub Panel2_Load()
        Panel2New = New Panel
        Me.Controls.Add(Panel2New)
        Panel2New.Height = 420
        Panel2New.Width = 1000
        Panel2New.Left = 380
        Panel2New.Top = 20
        Panel2New.Enabled = False
        Panel2New.Visible = False
        Panel2New.BackColor = Color.Green

        For i As Integer = 0 To 9
            subpanel(i) = New Panel
            Panel2New.Controls.Add(subpanel(i))

            subpanel(i).Height = 330
            subpanel(i).Width = 90
            subpanel(i).Left = 5 + i * 100
            subpanel(i).Top = 10

            subpanel(i).Enabled = False
            subpanel(i).Visible = False
            subpanel(i).BackColor = Color.Blue


            lab(i) = New Label
            subpanel(i).Controls.Add(lab(i))
            lab(i).Height = 20
            lab(i).Width = 70
            lab(i).Left = 10
            lab(i).Top = 10
            lab(i).Text = "Tube" + Str(i + 1)
            lab(i).TextAlign = ContentAlignment.MiddleCenter

            lab(i).Enabled = False
            lab(i).Visible = False
            lab(i).BackColor = Color.Yellow


            For j As Integer = 0 To 6
                buttons(i, j) = New Button
                subpanel(i).Controls.Add(buttons(i, j))
                buttons(i, j).Height = 30
                buttons(i, j).Width = 80
                buttons(i, j).Left = 6
                buttons(i, j).Top = 290 - j * 40

                buttons(i, j).Enabled = False
                buttons(i, j).Visible = False
                buttons(i, j).BackColor = Color.White
                buttons(i, j).Tag = "False"

                AddHandler buttons(i, j).Click, AddressOf button_click_new
            Next
        Next

        Dim N = New Button
        Panel2Submit = N
        Panel2New.Controls.Add(Panel2Submit)
        Panel2Submit.Left = 300
        Panel2Submit.Top = 360
        Panel2Submit.Height = 40
        Panel2Submit.Width = 100
        Panel2Submit.Enabled = False
        Panel2Submit.Visible = False
        Panel2Submit.Text = "Submit"
        Panel2Submit.TextAlign = ContentAlignment.MiddleCenter
        Panel2Submit.BackColor = Color.Red
        AddHandler Panel2Submit.Click, AddressOf Panel2Submit_click


        Dim M = New Button
        Panel2Reset = M
        Panel2New.Controls.Add(Panel2Reset)
        Panel2Reset.Left = 600
        Panel2Reset.Top = 360
        Panel2Reset.Height = 40
        Panel2Reset.Width = 100
        Panel2Reset.Enabled = False
        Panel2Reset.Visible = False
        Panel2Reset.Text = "Reset"
        Panel2Reset.TextAlign = ContentAlignment.MiddleCenter
        Panel2Reset.BackColor = Color.Red
        AddHandler Panel2Reset.Click, AddressOf Panel2Reset_click
    End Sub

    Public Sub button_click_new(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim B As Button = sender

        If (B.Tag = "False") Then
            B.BackColor = colorPick
            B.Tag = "True"
        Else
            B.BackColor = Color.Transparent
            B.Tag = "False"
        End If
    End Sub

    Public Sub Panel2Submit_click()
        find_solution()
    End Sub

    Public Sub Panel2Reset_click()
        For i As Integer = 0 To (Tube_Count_New - 1)
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                buttons(i, j).BackColor = Color.Transparent
                buttons(i, j).Tag = "False"
                buttons(i, j).Visible = True
                buttons(i, j).Enabled = True
            Next
        Next

        Solution.Items.Clear()
        Solution.Visible = False
        Solution.Enabled = False

        Panel4New.Visible = False
        Panel4New.Enabled = False
    End Sub

































    Public Sub Panel3_load()
        Panel3New = New Panel
        Me.Controls.Add(Panel3New)
        Panel3New.Height = 330
        Panel3New.Width = 320
        Panel3New.Left = 25
        Panel3New.Top = 350

        Panel3New.Enabled = False
        Panel3New.Visible = False
        Panel3New.BackColor = Color.Violet


        For i As Integer = 0 To 14
            Dim B As Button = New Button
            colorLabels(i) = B
            Panel3New.Controls.Add(colorLabels(i))
            colorLabels(i).Width = 40
            colorLabels(i).Height = 40
            colorLabels(i).Left = 50 + (i Mod 3) * 90
            colorLabels(i).Top = 25 + (i \ 3) * 60
            colorLabels(i).Enabled = False
            colorLabels(i).Visible = False
            AddHandler colorLabels(i).Click, AddressOf pick_color
        Next

        colorLabels(0).BackColor = Color.Red
        colorLabels(1).BackColor = Color.OrangeRed
        colorLabels(2).BackColor = Color.ForestGreen
        colorLabels(3).BackColor = Color.Cyan
        colorLabels(4).BackColor = Color.Fuchsia
        colorLabels(5).BackColor = Color.Black
        colorLabels(6).BackColor = Color.Brown
        colorLabels(7).BackColor = Color.Yellow
        colorLabels(8).BackColor = Color.Blue
        colorLabels(9).BackColor = Color.Orange
        colorLabels(10).BackColor = Color.Pink
        colorLabels(11).BackColor = Color.LawnGreen
        colorLabels(12).BackColor = Color.SpringGreen
        colorLabels(13).BackColor = Color.BlueViolet
        colorLabels(14).BackColor = Color.Crimson
    End Sub


    Public Sub pick_color(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim B As Button = sender
        colorPick = B.BackColor
    End Sub


    Public Function colorValue(tube_space As Button)
        Dim spaceColor As Color = tube_space.BackColor

        If (spaceColor = Color.Transparent) Then
            Return 0
        ElseIf (spaceColor = Color.Red) Then
            Return 1
        ElseIf (spaceColor = Color.OrangeRed) Then
            Return 2
        ElseIf (spaceColor = Color.ForestGreen) Then
            Return 3
        ElseIf (spaceColor = Color.Cyan) Then
            Return 4
        ElseIf (spaceColor = Color.Fuchsia) Then
            Return 5
        ElseIf (spaceColor = Color.Black) Then
            Return 6
        ElseIf (spaceColor = Color.Brown) Then
            Return 7
        ElseIf (spaceColor = Color.Yellow) Then
            Return 8
        ElseIf (spaceColor = Color.Blue) Then
            Return 9
        ElseIf (spaceColor = Color.Orange) Then
            Return 10
        ElseIf (spaceColor = Color.Pink) Then
            Return 11
        ElseIf (spaceColor = Color.LawnGreen) Then
            Return 12
        ElseIf (spaceColor = Color.SpringGreen) Then
            Return 13
        ElseIf (spaceColor = Color.BlueViolet) Then
            Return 14
        ElseIf (spaceColor = Color.Crimson) Then
            Return 15
        End If

        Return 0
    End Function
























    Public Sub Panel4_load()
        Dim L = New Panel
        Panel4New = L
        Me.Controls.Add(Panel4New)
        Panel4New.Height = 240
        Panel4New.Width = 1000
        Panel4New.Left = 380
        Panel4New.Top = 470
        Panel4New.Enabled = False
        Panel4New.Visible = False
        Panel4New.BackColor = Color.Brown


        Dim M = New ListBox
        Solution = M
        Panel4New.Controls.Add(Solution)
        Solution.Height = 200
        Solution.Width = 800
        Solution.Left = 100
        Solution.Top = 20
        Solution.Enabled = False
        Solution.Visible = False
        Solution.BackColor = Color.White
    End Sub






















    Public Sub get_tube_data(tubes(,) As Integer)
        For i As Integer = 0 To 9
            For j As Integer = 0 To 6
                tubes(i, j) = 0
            Next
        Next

        For i As Integer = 0 To (Tube_Count_New - 1)
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                tubes(i, j) = colorValue(buttons(i, j))
            Next
        Next
    End Sub

    Public Sub find_solution()
        Dim tubesArray(9, 6) As Integer
        get_tube_data(tubesArray)

        Dim tubes(Tube_Count_New - 1) As tube
        For i As Integer = 0 To (Tube_Count_New - 1)
            Dim N As tube = New tube
            tubes(i) = N
            tubes(i).filled = 0
            tubes(i).complete = 0
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                push(tubes(i), 1, tubesArray(i, j))
            Next
        Next

        Dim permutations(Tube_Count_New * (Tube_Count_New - 1) - 1, 1) As Integer
        Dim k As Integer = 0

        For i As Integer = 0 To Tube_Count_New - 1
            For j As Integer = 0 To Tube_Count_New - 1
                If (i <> j) Then
                    permutations(k, 0) = i
                    permutations(k, 1) = j

                    k += 1
                End If
            Next
        Next

        successPathLength = 0
        For i As Integer = 0 To 2047
            successPath(i) = New transactionClass
        Next

        historyCount = 0
        For i As Integer = 0 To 2047
            For j As Integer = 0 To 69
                tubeHistory(i, j) = New Integer
            Next
        Next

        BuildSuccessPath(tubes, permutations, Tube_Count_New * (Tube_Count_New - 1))

        For i As Integer = 0 To (successPathLength - 1)
            Solution.Items.Add((i + 1) & "). " & successPath(i).fromIndex + 1 & " -> " & successPath(i).toIndex + 1)
        Next
        Panel4New.Enabled = True
        Panel4New.Visible = True

        Solution.Visible = True
        Solution.Enabled = True
    End Sub















    Public Sub push(tubeObj As tube, quantity As Integer, element As Integer)
        If (element <> 0) Then
            If (tubeObj.filled = 0) Then
                tubeObj.complete = quantity
            ElseIf (tubeObj.filled = tubeObj.complete And tubeObj.data(tubeObj.filled - 1) = element) Then
                tubeObj.complete += quantity
            End If

            For i As Integer = 1 To quantity
                tubeObj.data(tubeObj.filled) = element
                tubeObj.filled += 1
            Next
        End If
    End Sub

    Public Sub pop(tubeObj As tube, quantity As Integer)
        For i As Integer = 1 To quantity
            If (tubeObj.filled = tubeObj.complete) Then
                tubeObj.complete = tubeObj.complete - 1
            End If
            tubeObj.data(tubeObj.filled - 1) = 0
            tubeObj.filled -= 1
        Next
    End Sub

    Public Function complete(tubes() As tube) As Boolean
        Dim completed As Integer = 0

        For i As Integer = 0 To Tube_Count_New - 1
            If (tubes(i).complete = Tube_Capacity_New) Then
                completed += 1
            End If
        Next

        If (completed = Colors_Count_New) Then
            Return True
        End If

        Return False
    End Function

    Public Function top_color(tube_obj As tube) As Integer
        If (tube_obj.filled = 0) Then
            Return 0
        Else
            Return (tube_obj.data(tube_obj.filled - 1))
        End If
    End Function

    Public Sub build_tubestate(tubeState() As Integer, tubes_obj() As tube)
        For i As Integer = 0 To 69
            tubeState(i) = 0
        Next

        Dim k As Integer = 0
        For i As Integer = 0 To (Tube_Count_New - 1)
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                tubeState(k) = tubes_obj(i).data(j)
                k += 1
            Next
        Next
    End Sub

    Public Sub copy_tubes(duplicate_tubes() As tube, tubes() As tube)
        For i As Integer = 0 To (Tube_Count_New - 1)
            duplicate_tubes(i).filled = tubes(i).filled
            duplicate_tubes(i).complete = tubes(i).complete
            For j As Integer = 0 To (Tube_Capacity_New - 1)
                duplicate_tubes(i).data(j) = tubes(i).data(j)
            Next
        Next
    End Sub












    Public Sub build_transaction(current_transaction As transactionClass, tubes() As tube, permutation() As Integer)
        current_transaction.fromIndex = permutation(0)
        current_transaction.toIndex = permutation(1)
        current_transaction.color = top_color(tubes(permutation(0)))
        current_transaction.quantity = 0

        If current_transaction.color <> 0 Then
            Dim i As Integer = tubes(permutation(0)).filled
            While i > 0
                If (tubes(permutation(0)).data(i - 1) = current_transaction.color) Then
                    current_transaction.quantity += 1
                Else
                    Exit While
                End If

                i -= 1
            End While
        End If

    End Sub


    Public Function valid_transaction(current_transaction As transactionClass, tubes() As tube) As Boolean
        If (current_transaction.quantity = 0) Or ((tubes(current_transaction.toIndex).filled > 0) And (current_transaction.color <> top_color(tubes(current_transaction.toIndex)))) Or (current_transaction.quantity + tubes(current_transaction.toIndex).filled > Tube_Capacity_New) Or ((tubes(current_transaction.fromIndex).complete = tubes(current_transaction.fromIndex).filled) And (tubes(current_transaction.toIndex).filled = 0)) Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Sub process_transaction(current_transaction As transactionClass, tubes() As tube)
        pop(tubes(current_transaction.fromIndex), current_transaction.quantity)
        push(tubes(current_transaction.toIndex), current_transaction.quantity, current_transaction.color)
    End Sub


    Public Function repeating(tubeState() As Integer) As Boolean
        If (historyCount = 0) Then
            For i As Integer = 0 To 69
                tubeHistory(0, i) = tubeState(i)
            Next
            historyCount = 1

            Return False
        Else
            Dim flag As Boolean

            For i As Integer = 0 To (historyCount - 1)
                flag = True
                For j As Integer = 0 To 69
                    If (tubeHistory(i, j) <> tubeState(j)) Then
                        flag = False
                        Exit For
                    End If
                Next

                If flag Then
                    Return True
                End If
            Next


            For i As Integer = 0 To 69
                tubeHistory(historyCount, i) = tubeState(i)
            Next
            historyCount += 1

            Return False
        End If
    End Function


    Public Sub addPath(current_transaction As transactionClass)
        successPath(successPathLength).fromIndex = current_transaction.fromIndex
        successPath(successPathLength).toIndex = current_transaction.toIndex
        successPath(successPathLength).color = current_transaction.color
        successPath(successPathLength).quantity = current_transaction.quantity
        successPathLength += 1
    End Sub


    Public Function BuildSuccessPath(tubes() As tube, permutations(,) As Integer, permutations_count As Integer) As Boolean
        Dim value As Boolean = complete(tubes)
        If (value) Then
            Return True
        Else
            Dim Current_successPathLength As Integer = successPathLength
            Dim duplicate_tubes_history_count As Integer = historyCount

            Dim current_transaction As New transactionClass
            Dim permutation(1) As Integer
            Dim tubeState(69) As Integer

            Dim duplicate_tubes(Tube_Count_New - 1) As tube
            For i As Integer = 0 To (Tube_Count_New - 1)
                duplicate_tubes(i) = New tube
            Next

            For i As Integer = 0 To permutations_count - 1
                permutation = {permutations(i, 0), permutations(i, 1)}
                build_transaction(current_transaction, tubes, permutation)
                If (valid_transaction(current_transaction, tubes)) Then
                    copy_tubes(duplicate_tubes, tubes)
                    process_transaction(current_transaction, duplicate_tubes)
                    build_tubestate(tubeState, duplicate_tubes)
                    historyCount = duplicate_tubes_history_count

                    If (Not repeating(tubeState)) Then
                        successPathLength = Current_successPathLength
                        addPath(current_transaction)
                        If (BuildSuccessPath(duplicate_tubes, permutations, permutations_count)) Then
                            Return True
                        End If
                    End If
                End If
            Next

            Return False
        End If
    End Function


End Class
