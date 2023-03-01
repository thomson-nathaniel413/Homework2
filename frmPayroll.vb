Imports System.CodeDom

Public Class frmPayroll
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' when clicked, this button should exit the program
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' when clicked, this should clear all output labels and clear + refocus input text box
        lblFICATax.Text = ""
        lblFederalTax.Text = ""
        lblStateTax.Text = ""
        lblNetPay.Text = ""
        txtGrossPay.Text = ""
        txtGrossPay.Focus()
    End Sub

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' when form loads, same events as btnClear_Click should occur
        btnClear.PerformClick()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' when clicked, this should calculate tax and net pay

        ' variable definitions
        Const cdecFica = 0.0765D
        Const cdecFederal = 0.22D
        Const cdecState = 0.04D
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        ' get gross pay and convert to decimal
        strIncome = txtGrossPay.Text
        If IsNumeric(txtGrossPay.Text) Then
            decIncome = Convert.ToInt32(strIncome)
        Else
            decIncome = 0D
        End If

        ' perform tax calculations
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFederal
        decState = decIncome * cdecState

        decNet = decIncome - decFica - decFederal - decState

        ' display results in appropriate labels
        lblFICATax.Text = decFica.ToString("C")
        lblFederalTax.Text = decFederal.ToString("C")
        lblStateTax.Text = decState.ToString("C")

        lblNetPay.Text = decNet.ToString("C")

    End Sub
End Class
