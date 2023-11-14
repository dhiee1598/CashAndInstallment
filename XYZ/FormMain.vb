Public Class FormMain


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        FormHome.MdiParent = Me
        FormHome.Show()
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormHome.MdiParent = Me
        FormHome.Show()
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        FormCustomer.MdiParent = Me
        FormCustomer.Show()
    End Sub

    Private Sub btnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        FormItem.MdiParent = Me
        FormItem.Show()
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        FormSale.MdiParent = Me
        FormSale.Show()
    End Sub
End Class
