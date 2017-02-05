Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Results1.Text = String.Empty
        Results2.Text = String.Empty
        Results3.Text = String.Empty
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        '
        ' clear all the text boxes for the next calculation
        ' 
        placeRace1Boat1.Clear()
        placeRace1Boat2.Clear()
        placeRace1Boat3.Clear()
        '
        placeRace2Boat1.Clear()
        placeRace2Boat2.Clear()
        placeRace2Boat3.Clear()
        '
        placeRace3Boat1.Clear()
        placeRace3Boat2.Clear()
        placeRace3Boat3.Clear()
        '
        placeRace4Boat1.Clear()
        placeRace4Boat2.Clear()
        placeRace4Boat3.Clear() '
        '
        ' set focust to first race first boat
        placeRace1Boat1.Focus()
        '
        ' clear status window
        StatusStrip1.Text = String.Empty
    End Sub
End Class
