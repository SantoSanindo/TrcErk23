Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Public Class ST1_Database_form
    Dim _SaveFileDialog As New SaveFileDialog
    Private Sub ST1_Database_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tick_dateTime.Enabled = True
    End Sub

    Private Sub Tick_dateTime_Tick(sender As Object, e As EventArgs) Handles Tick_dateTime.Tick
        LabelDate.Text = Date.Now.ToString("dd-MM-yyyy")
        LabelTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim range1 As String = DateTimePickerStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim range2 As String = DateTimePickerEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

        Call DatabaseConnection.connection_DB()
        ' Try
        Dim sc As New SqlCommand("SELECT * FROM tb_tcer23 WHERE [DATETIME] BETWEEN '" + range1 + "' AND '" + range2 + "' ORDER BY [NO] ASC", DatabaseConnection.connection)
        Dim adapter As New SqlDataAdapter(sc)
        Dim ds As New DataSet

        adapter.Fill(ds)
        DGV_Report.DataSource = ds.Tables(0)

        If DGV_Report.Rows.Count > 0 Then
            btn_export.Enabled = True
        End If

        RTB_Status.AppendText("Notice => " + "Data search was successful" + Environment.NewLine)
        RTB_Status.ScrollToCaret()
    End Sub
End Class