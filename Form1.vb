﻿Public Class Form1
    Dim PlayerTurns As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerTurns += 1
        lblPlayerTurn.Text = PlayerTurns
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub lblTicTacToe_Click(sender As Object, e As EventArgs) Handles lblSquareOne.Click
        If Not PlayerTurns Mod 2 = 0 Then
            lblSquareOne.Image = My.Resources.symbol_X
        ElseIf PlayerTurns Mod 2 = 0 Then
            lblSquareOne.Image = My.Resources.cirlce

        End If

        PlayerTurns += 1
        lblPlayerTurn.Text = PlayerTurns.ToString()






    End Sub

    Private Sub lblSquareTwo_Click(sender As Object, e As EventArgs) Handles lblSquareTwo.Click
        If Not PlayerTurns Mod 2 = 0 Then
            lblSquareTwo.Image = My.Resources.symbol_X
        ElseIf PlayerTurns Mod 2 = 0 Then
            lblSquareTwo.Image = My.Resources.cirlce
        End If
        PlayerTurns += 1
        lblPlayerTurn.Text = PlayerTurns.ToString()


    End Sub
End Class
