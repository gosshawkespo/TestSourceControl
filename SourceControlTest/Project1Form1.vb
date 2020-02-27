Public Class Project1_Form1
    Private Sub btnTEST1_Click(sender As Object, e As EventArgs) Handles btnTEST1.Click
        stsLabel1.Text = "Loading List......"
        Cursor = Cursors.WaitCursor
        Refresh()
        Dim App As New TestApplication.frmRTFTest
        'SourceControlTest.Project2Form1
        App.Visible = False
        'App.GetParms(GlobalSession, GlobalParms)
        App.Show()
        'App.Visible = True
        StsLabel1.Text = ""
        'App.PopulateForm("", "", "", True)
        Cursor = Cursors.Default

    End Sub
End Class
