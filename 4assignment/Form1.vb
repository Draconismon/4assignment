Public Class frmSalesTaxCalculator
    'declare the variable
    Const tax As Double = 0.0875 'declare the constant value 8.75% for tax
    'form load event
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen() 'center on the screen
        txtItemName.Enabled = False
        txtItemCost.Enabled = False
        txtTax.Enabled = False
        txtTotalCost.Enabled = False
    End Sub
    'button calculate event
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim totalSales As Double
        Dim cost As Double
        Dim toalTax As Double
        If txtName.Text = "" Then
            MessageBox.Show("Enter item name.")
        ElseIf (Not Double.TryParse(txtCost.Text, cost)) Then
            MessageBox.Show("Enter the correct value for cost")
        Else
            toalTax = tax * cost 'calculate the cost
            totalSales = cost + toalTax 'calculate the total cost
            'display the item name, tax, cost and total cost to the textbox
            txtItemName.Text = txtName.Text
            txtItemCost.Text = cost.ToString("c2")
            txtTax.Text = toalTax.ToString("c2")
            txtTotalCost.Text = totalSales.ToString("c2")
        End If
    End Sub

    'Exit event
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'close the form
    End Sub

    'clear button event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the textbox
        txtName.Clear()
        txtCost.Clear()
        txtItemName.Clear()
        txtItemCost.Clear()
        txtTax.Clear()
        txtTotalCost.Clear()
    End Sub
End Class
