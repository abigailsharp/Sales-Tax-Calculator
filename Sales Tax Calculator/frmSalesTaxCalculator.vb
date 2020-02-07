' Program:  City Bike Rental
' Author:   Corinne Hoisington
' Date:     April 14, 2017
' Purpose:  This application calculates and displays 
'           the total cost of renting multiple bikes for a 24-hour period.

Option Strict On

Public Class frmSalesTaxCalculator

    Const _cdecTax As Decimal = 0.0875D

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim ItemCost As Decimal
        Dim SalesTax As Decimal
        Dim TotalCost As Decimal

        ' Input
        Decimal.TryParse(txtItemCost.Text, ItemCost)

        ' Processing
        SalesTax = CDec(ItemCost * 0.0875)
        TotalCost = SalesTax + ItemCost

        ' Output
        lblSalesTax.Text = SalesTax.ToString("C")
        lblTotalCost.Text = TotalCost.ToString("C")
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear values
        txtItemName.Clear()
        txtItemCost.Clear()
        lblSalesTax.Text = ""
        lblTotalCost.Text = ""
        txtItemName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmSalesTaxCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub lblCost_Click(sender As Object, e As EventArgs) Handles lblItemCost.Click

    End Sub
End Class
