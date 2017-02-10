Public Class SailBoatRaceResults
    Private Sub SailBoatRaceResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' clear the results label when loading the form
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
        R1B1.Clear()            ' Race 1 Boat 1 - Clearing the textboxes for another calculation
        R1B2.Clear()            ' 
        R1B3.Clear()
        '
        R2B1.Clear()
        R2B2.Clear()
        R2B3.Clear()
        '
        R3B1.Clear()
        R3B2.Clear()
        R3B3.Clear()
        '
        R4B1.Clear()            ' Race 4 Boat 1
        R4B2.Clear()
        R4B3.Clear()
        '
        ' Clear the Results labels
        Results1.Text = String.Empty
        Results2.Text = String.Empty
        Results3.Text = String.Empty
        '
        ' set focus to first race first boat
        R1B1.Focus()

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Declare variables to use in calculating the total points each boat earns over four races
        '
        ' Variables for Boat one finishes
        Dim R1B1Finish As Byte = 0
        Dim R2B1Finish As Byte = 0
        Dim R3B1Finish As Byte = 0
        Dim R4B1Finish As Byte = 0
        '
        ' Variables for Boat two finishes
        Dim R1B2Finish As Byte = 0
        Dim R2B2Finish As Byte = 0
        Dim R3B2Finish As Byte = 0
        Dim R4B2Finish As Byte = 0
        '
        ' Variables for Boat three finishes
        Dim R1B3Finish As Byte = 0
        Dim R2B3Finish As Byte = 0
        Dim R3B3Finish As Byte = 0
        Dim R4B3Finish As Byte = 0
        ' Clear any existing errors
        ' first race
        ErrorProvider1.SetError(R1B1, String.Empty)
        ErrorProvider1.SetError(R1B2, String.Empty)
        ErrorProvider1.SetError(R1B3, String.Empty)
        ' Clear errors second race
        ErrorProvider1.SetError(R2B1, String.Empty)
        ErrorProvider1.SetError(R2B2, String.Empty)
        ErrorProvider1.SetError(R2B3, String.Empty)
        ' Clear errors third race
        ErrorProvider1.SetError(R3B1, String.Empty)
        ErrorProvider1.SetError(R3B2, String.Empty)
        ErrorProvider1.SetError(R3B3, String.Empty)
        ' Clear erros fourth race
        ErrorProvider1.SetError(R4B1, String.Empty)
        ErrorProvider1.SetError(R4B2, String.Empty)
        ErrorProvider1.SetError(R4B3, String.Empty)
        ' Convert text box inputs to integers and catch input errors
        '
        ' Race one results entry
        '
        Try
            R1B1Finish = Convert.ToInt16(R1B1.Text)
            Try
                R1B2Finish = Convert.ToInt16(R1B2.Text)
                Try
                    R1B3Finish = Convert.ToInt16(R1B3.Text)
                    ' End Of race One results 

                    ' Begin race two results
                    Try
                        R2B1Finish = Convert.ToInt16(R2B1.Text)
                        Try
                            R2B2Finish = Convert.ToInt16(R2B2.Text)
                            Try
                                R2B3Finish = Convert.ToInt16(R2B3.Text)
                                ' End Of race Two results 

                                ' Begin race Three results
                                Try
                                    R3B1Finish = Convert.ToInt16(R3B1.Text)
                                    Try
                                        R3B2Finish = Convert.ToInt16(R3B2.Text)
                                        Try
                                            R3B3Finish = Convert.ToInt16(R3B3.Text)
                                            ' End of race three results

                                            ' Beginning of race four results
                                            Try
                                                R4B1Finish = Convert.ToInt16(R4B1.Text)
                                                Try
                                                    R4B2Finish = Convert.ToInt16(R4B2.Text)
                                                    Try
                                                        R4B3Finish = Convert.ToInt16(R4B3.Text)
                                                        ' calculate the totals for each boat
                                                        Results1.Text = Convert.ToString(R1B1Finish + R2B1Finish + R3B1Finish + R4B1Finish)
                                                        Results2.Text = Convert.ToString(R1B2Finish + R2B2Finish + R3B2Finish + R4B2Finish)
                                                        Results3.Text = Convert.ToString(R1B3Finish + R2B3Finish + R3B3Finish + R4B3Finish)
                                                        ' race four error trapping
                                                    Catch ex As Exception
                                                        ErrorProvider1.SetError(R4B3, "Please try again, and enter an integer.")
                                                    End Try
                                                Catch ex As Exception
                                                    ErrorProvider1.SetError(R4B2, "Please try again, and enter an integer.")
                                                End Try
                                            Catch ex As Exception
                                                ErrorProvider1.SetError(R4B1, "Please try again, and enter an integer.")
                                            End Try
                                            ' end of race four error trapping

                                            ' beginning of race three error trapping
                                        Catch ex As Exception
                                            ErrorProvider1.SetError(R3B3, "Please try again, and enter an integer.")
                                        End Try
                                    Catch ex As Exception
                                        ErrorProvider1.SetError(R3B2, "Please try again, and enter an integer.")
                                    End Try
                                Catch ex As Exception
                                    ErrorProvider1.SetError(R3B1, "Please try again, and enter an integer.")
                                End Try
                                ' end of race three error trapping

                                ' Begin Race two error trapping
                            Catch ex As Exception
                                ErrorProvider1.SetError(R2B3, "Please try again, and enter an integer.")
                            End Try
                        Catch ex As Exception
                            ErrorProvider1.SetError(R2B2, "Please try again, and enter an integer.")
                        End Try
                    Catch ex As Exception
                        ErrorProvider1.SetError(R2B1, "Please try again, and enter an integer.")
                    End Try
                    ' End race two error trapping

                    ' Begin race one error trapping
                Catch ex As Exception
                    ErrorProvider1.SetError(R1B3, "Please try again, and enter an integer.")
                End Try
            Catch ex As Exception
                ErrorProvider1.SetError(R1B2, "Please try again, and enter an integer.")
            End Try
        Catch ex As Exception
            ErrorProvider1.SetError(R1B1, "Please try again, and enter an integer.")
        End Try
    End Sub
End Class
