Public Class HOME
    Private Sub ST1Tracking(sender As Object, e As EventArgs) Handles RibbonButtonST1Tracking.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(ST1_Tracking_form)
    End Sub

    Private Sub btn_Login(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem1.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(Login_form)
    End Sub

    Private Sub DatabaseST1(sender As Object, e As EventArgs) Handles RibbonButtonST1Database.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(ST1_Database_form)
    End Sub

    Private Sub ST1_Trace(sender As Object, e As EventArgs) Handles RibbonButtonST1Traceability.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(ST1_Traceability_form)
    End Sub

    Private Sub ST1_Proccess(sender As Object, e As EventArgs) Handles RibbonButtonST1Proccess.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(ST1_Proccess_form)
    End Sub

    Private Sub Btn_EXIT(sender As Object, e As EventArgs) Handles RibbonOrbOptionButtonExit.Click
        Me.Close()
    End Sub

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ST1_Modbus(sender As Object, e As EventArgs) Handles RibbonButtonST1Modbus.Click
        'If globVar.hakAkses = "ADMIN" Then
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(ST1_Modbus_Form)
    End Sub
End Class
