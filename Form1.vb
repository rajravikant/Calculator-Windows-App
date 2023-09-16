Public Class Form1

    Dim temp As Double

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtValue.Text += btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtValue.Text += btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtValue.Text += btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtValue.Text = txtValue.Text + btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtValue.Text = txtValue.Text + btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtValue.Text = txtValue.Text + btnSix.Text
    End Sub

    Private Sub btxSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtValue.Text = txtValue.Text + btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtValue.Text = txtValue.Text + btnEight.Text
    End Sub

    Private Sub btnNine_Click_1(sender As Object, e As EventArgs) Handles btnNine.Click
        txtValue.Text = txtValue.Text + btnNine.Text
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtValue.Text = txtValue.Text + btnZero.Text
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        txtValue.Text = ""
        Lbltemp.Text = ""
        TextBox1.Text = ""


    End Sub

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click

        temp = Val(txtValue.Text)
        txtValue.Text = ""
        Lbltemp.Text = "+"
        TextBox1.Text = temp & "+"

    End Sub
    Private Sub btnDiff_Click(sender As Object, e As EventArgs) Handles btnDiff.Click

        temp = Val(txtValue.Text)
        txtValue.Text = ""
        Lbltemp.Text = "-"
        TextBox1.Text = temp & "-"

    End Sub
    
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click

        temp = Val(txtValue.Text)
        txtValue.Text = ""
        Lbltemp.Text = "*"
        TextBox1.Text = temp & "*"
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click

        temp = Val(txtValue.Text)
        txtValue.Text = ""
        Lbltemp.Text = "/"
        TextBox1.Text = temp & "/"
    End Sub


    Private Sub Btn_result_Click(sender As Object, e As EventArgs) Handles Btn_result.Click

        If Lbltemp.Text = "+" Then
            TextBox1.Text = TextBox1.Text + txtValue.Text
            txtValue.Text = temp + Val(txtValue.Text)
            Lbltemp.Text = ""

        ElseIf Lbltemp.Text = "-" Then
            TextBox1.Text = TextBox1.Text + txtValue.Text
            txtValue.Text = temp - Val(txtValue.Text)
            Lbltemp.Text = ""
        ElseIf Lbltemp.Text = "*" Then
            TextBox1.Text = TextBox1.Text + txtValue.Text
            txtValue.Text = temp * Val(txtValue.Text)
            Lbltemp.Text = ""
        ElseIf Lbltemp.Text = "/" Then
            TextBox1.Text = TextBox1.Text + txtValue.Text
            txtValue.Text = temp / Val(txtValue.Text)
            Lbltemp.Text = ""
        ElseIf Lbltemp.Text = "%" Then
            TextBox1.Text = TextBox1.Text + txtValue.Text
            txtValue.Text = temp Mod Val(txtValue.Text)
            Lbltemp.Text = ""

        End If

    End Sub

    Private Sub BtnOFF_Click(sender As Object, e As EventArgs) Handles BtnOFF.Click
        Me.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Dim temp2 As Integer
        temp2 = Len(txtValue.Text)
        If temp2 <> 0 Then
            txtValue.Text = txtValue.Text.Remove(temp2 - 1)
        End If

    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        temp = 0
        temp = Val(txtValue.Text)
        txtValue.Text = ""
        Lbltemp.Text = "%"
    End Sub

    Private Sub BtnRoot_Click(sender As Object, e As EventArgs) Handles BtnRoot.Click
        temp = 0
        temp = Val(txtValue.Text)
        txtValue.Text = Math.Sqrt(temp)

    End Sub

    Private Sub BtnSqr_Click(sender As Object, e As EventArgs) Handles BtnSqr.Click
        temp = 0
        temp = Val(txtValue.Text)
        txtValue.Text = temp * temp
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDot.Click
        txtValue.Text += BtnDot.Text
    End Sub

    Private Sub BtnDblzero_Click(sender As Object, e As EventArgs) Handles BtnDblzero.Click
        txtValue.Text += "00"
    End Sub
End Class
