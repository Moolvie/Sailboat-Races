Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' clear the results label when loading the form
        Results1.Text = String.Empty
        Results2.Text = String.Empty
        Results3.Text = String.Empty
        ' clear the status strip 
        StatusStripErrorMessage.Text = String.Empty
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
        placeRace4Boat3.Clear()
        '
        ' Clear the Results labels
        Results1.Text = String.Empty
        Results2.Text = String.Empty
        Results3.Text = String.Empty
        '
        ' set focus to first race first boat
        placeRace1Boat1.Focus()
        '
        ' clear status window
        StatusStripErrorMessage.Text = String.Empty
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Declare variables to use in calculating the total points each boat earns over four races
        '
        ' Variables for Boat one finishes
        Dim boat1Race1Finish As Byte = 0
        Dim boat1Race2Finish As Byte = 0
        Dim boat1Race3Finish As Byte = 0
        Dim boat1Race4Finish As Byte = 0
        '
        ' Variables for Boat two finishes
        Dim boat2Race1Finish As Byte = 0
        Dim boat2Race2Finish As Byte = 0
        Dim boat2Race3Finish As Byte = 0
        Dim boat2Race4Finish As Byte = 0
        '
        ' Variables for Boat three finishes
        Dim boat3Race1Finish As Byte = 0
        Dim boat3Race2Finish As Byte = 0
        Dim boat3Race3Finish As Byte = 0
        Dim boat3Race4Finish As Byte = 0

        ' Convert text box inputs to integers and catch input errors
        '
        ' Race one results entry
        '
        Try
            boat1Race1Finish = Convert.ToInt16(placeRace1Boat1.Text)
            ' clear the status strip if input is correct
            StatusStripErrorMessage.Text = String.Empty
            ' and set the back color to white
            placeRace1Boat1.BackColor = Color.White
            Try
                boat2Race1Finish = Convert.ToInt16(placeRace1Boat2.Text)
                ' clear the status strip if imput is correct
                StatusStripErrorMessage.Text = String.Empty
                ' and set the back color to white
                placeRace1Boat2.BackColor = Color.White
                Try
                    boat3Race1Finish = Convert.ToInt16(placeRace1Boat3.Text)
                    ' clear the status strip if input is correct
                    StatusStripErrorMessage.Text = String.Empty
                    ' and set the back color to white
                    placeRace1Boat3.BackColor = Color.White
                    '
                    ' End Of race One results 
                    ' ******
                    ' Begin race two results
                    '
                    Try
                        boat1Race2Finish = Convert.ToInt16(placeRace2Boat1.Text)
                        ' clear the status strip if input is correct
                        StatusStripErrorMessage.Text = String.Empty
                        ' and set the back color to white
                        placeRace2Boat1.BackColor = Color.White
                        Try
                            boat2Race2Finish = Convert.ToInt16(placeRace2Boat2.Text)
                            ' clear the status strip if imput is correct
                            StatusStripErrorMessage.Text = String.Empty
                            ' and set the back color to white
                            placeRace2Boat2.BackColor = Color.White
                            Try
                                boat3Race2Finish = Convert.ToInt16(placeRace2Boat3.Text)
                                ' clear the status strip if input is correct
                                StatusStripErrorMessage.Text = String.Empty
                                ' and set the back color to white
                                placeRace2Boat3.BackColor = Color.White
                                '
                                ' End Of race Two results 
                                ' ******
                                ' Begin race Three results
                                Try
                                    boat1Race3Finish = Convert.ToInt16(placeRace3Boat1.Text)
                                    ' clear the status strip if input is correct
                                    StatusStripErrorMessage.Text = String.Empty
                                    ' and set the back color to white
                                    placeRace3Boat1.BackColor = Color.White
                                    Try
                                        boat2Race3Finish = Convert.ToInt16(placeRace3Boat2.Text)
                                        ' clear the status strip if imput is correct
                                        StatusStripErrorMessage.Text = String.Empty
                                        ' and set the back color to white
                                        placeRace3Boat2.BackColor = Color.White
                                        Try
                                            boat3Race3Finish = Convert.ToInt16(placeRace3Boat3.Text)
                                            ' clear the status strip if imput is correct
                                            StatusStripErrorMessage.Text = String.Empty
                                            ' and set the back color to white
                                            placeRace3Boat3.BackColor = Color.White
                                            ' End of race three results
                                            ' Beginning of race four results
                                            Try
                                                boat1Race4Finish = Convert.ToInt16(placeRace4Boat1.Text)
                                                ' clear the status strip if input is correct
                                                StatusStripErrorMessage.Text = String.Empty
                                                ' and set the back color to white
                                                placeRace4Boat1.BackColor = Color.White
                                                Try
                                                    boat2Race4Finish = Convert.ToInt16(placeRace4Boat2.Text)
                                                    ' clear the status strip if imput is correct
                                                    StatusStripErrorMessage.Text = String.Empty
                                                    ' and set the back color to white
                                                    placeRace4Boat2.BackColor = Color.White
                                                    Try
                                                        boat3Race4Finish = Convert.ToInt16(placeRace4Boat3.Text)
                                                        ' clear the status strip if imput is correct
                                                        StatusStripErrorMessage.Text = String.Empty
                                                        ' and set the back color to white
                                                        placeRace4Boat3.BackColor = Color.White
                                                        ' calculate the totals for each boat
                                                        Results1.Text = Convert.ToString(boat1Race1Finish + boat1Race2Finish + boat1Race3Finish + boat1Race4Finish)
                                                        Results2.Text = Convert.ToString(boat2Race1Finish + boat2Race2Finish + boat2Race3Finish + boat2Race4Finish)
                                                        Results3.Text = Convert.ToString(boat3Race1Finish + boat3Race2Finish + boat3Race3Finish + boat3Race4Finish)
                                                    Catch ex As Exception
                                                        ' Display the error message, move focus to the bad input and change background color
                                                        StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                                        placeRace4Boat3.Focus()
                                                        placeRace4Boat3.BackColor = Color.Red
                                                    End Try
                                                Catch ex As Exception
                                                    ' Display the error message, move focus to the bad input and change background color
                                                    StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                                    placeRace4Boat2.Focus()
                                                    placeRace4Boat2.BackColor = Color.Red
                                                End Try
                                            Catch ex As Exception
                                                ' Display the error message, move focus to the bad input and change background color
                                                StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                                placeRace4Boat1.Focus()
                                                placeRace4Boat1.BackColor = Color.Red
                                            End Try
                                            ' beginning of race three error trapping
                                        Catch ex As Exception
                                            ' Display the error message, move focus to the bad input and change background color
                                            StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                            placeRace3Boat3.Focus()
                                            placeRace3Boat3.BackColor = Color.Red
                                        End Try
                                    Catch ex As Exception
                                        ' Display the error message, move focus to the bad input and change background color
                                        StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                        placeRace3Boat2.Focus()
                                        placeRace3Boat2.BackColor = Color.Red
                                    End Try
                                Catch ex As Exception
                                    ' Display the error message, move focus to the bad input and change background color
                                    StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                    placeRace3Boat1.Focus()
                                    placeRace3Boat1.BackColor = Color.Red
                                End Try
                                ' Begin Race two error trapping
                            Catch ex As Exception
                                ' Display the error message, move focus to the bad input and change background color
                                StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                                placeRace2Boat3.Focus()
                                placeRace2Boat3.BackColor = Color.Red
                            End Try
                        Catch ex As Exception
                            ' Display the error message, move focus to the bad input and change background color
                            StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                            placeRace2Boat2.Focus()
                            placeRace2Boat2.BackColor = Color.Red
                        End Try
                    Catch ex As Exception
                        ' Display the error message, move focus to the bad input and change background color
                        StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                        placeRace2Boat1.Focus()
                        placeRace2Boat1.BackColor = Color.Red
                    End Try
                    ' End race two error trapping
                    ' Begin race one error trapping
                Catch ex As Exception
                    ' Display the error message, move focus to the bad input and change background color
                    StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                    placeRace1Boat3.Focus()
                    placeRace1Boat3.BackColor = Color.Red
                End Try
            Catch ex As Exception
                ' Display the error message, move focus to the bad input and change background color
                StatusStripErrorMessage.Text = "Please try again, and enter an integer."
                placeRace1Boat2.Focus()
                placeRace1Boat2.BackColor = Color.Red
            End Try
        Catch ex As Exception
            ' Display the error message, move focus to the bad input and change background color
            StatusStripErrorMessage.Text = "Please try again, and enter an integer."
            placeRace1Boat1.Focus()
            placeRace1Boat1.BackColor = Color.Red
        End Try
    End Sub
End Class
