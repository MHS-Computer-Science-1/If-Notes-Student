Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Relational operators are used to compare two
        'values. They give a BOOLEAN (true/false) result
        'Relational operators: <, >, =, <>, <=, >=
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If-Then
        '**********
        'If-thens use a BOOLEAN expression to make a choice
        'and then act based on that choice
        Dim temp As Integer
        temp = TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If/Else
        '**********
        'The ELSE clause represents an alternative action
        'for when the BOOLEAN expression is false
        'You can only have one 'else'
        Dim temp As Integer
        temp = TextBox1.Text


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If/Else If/Else
        '***************
        'In addition to IF and ELSE, the optional ELSE IF
        'clause allows us to check additional conditions

        'The code will work from top to bottom and will stop as
        'soon as it finds one condition that is true

        'You can have 0 to infinite else ifs

        Dim temp As Integer
        temp = TextBox1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'The LOGICAL OPERATORS let you look at two
        'or more conditions in a single if
        Dim temp As Integer
        temp = TextBox1.Text

        'AND checks to see if both (all) conditions are true
        'Let's see if the temperature is in the 0-800 range


        'OR checks to see if any of the conditions are true
        'Let's see if the temperature is out of the expected range
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'make some numbers at random
        '****************************
        '1. Make the random number generator


        '2. Create two random numbers
        Dim num1, num2 As Integer


        'Note: the 2nd number in the range is NON-INCLUSIVE

        MsgBox(num1 & " " & num2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Write a program that takes input from the textbox
        'and uses an if/else to determine if the number is
        'positive or negative (zero counts as positive for this)
        'Display "positive" or "negative" in the label

        Dim num As Integer
        num = TextBox1.Text

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Write a program that takes input from the textbox
        'representing a restaurant check. Display the tip in the
        'label. The tip should be 15% of the check, with a minimum 
        'of $3. 

        'The code is mostly done. Add an if statement
        'that changes the tip to 3 if necessary

        Dim check, tip As Double
        check = TextBox1.Text 'Input
        tip = check * 0.15 'Compute

        Label2.Text = tip 'Output
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Write a program where the user will enter the percentage
        'of cloud cover in the sky (e.g. 50 means 50% cloudy)
        'In the label, display the sky conditions as follows:
        '0-30 clear, 31-70 partly cloudy, 71-99 cloudy, 100 overcast

        Dim clouds As Integer
        clouds = TextBox1.Text


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'We can use if-statements to determine if checkboxes
        'and radiobuttons are checked


    End Sub
End Class

