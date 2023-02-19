Imports EasyModbus

Public Class ST1_Modbus_Form

    Dim modbusClient As ModbusClient

    Private Sub ST1_Modbus_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modbusClient = New ModbusClient(txtIP.Text, 502)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            modbusClient.Connect()
            grpExchange.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnReadHoldReg_Click(sender As Object, e As EventArgs) Handles btnReadHoldReg.Click
        Dim readHoldingRegister() As Integer = modbusClient.ReadHoldingRegisters(txtStartAdress.Text, txtSize.Text)
        Dim index As Integer = 0

        ' Mengkonversi array integer menjadi objek anonim dengan dua properti "Data" dan "Kuadrat"
        Dim data = readHoldingRegister.Select(Function(x) New With {.Data = x, .Kuadrat = x * x}).ToList()
        DGV_Read.DataSource = data
        ' Menentukan nama kolom
        DGV_Read.Columns("clm_No").HeaderText = "Address MW"
        DGV_Read.Columns("clm_Data").HeaderText = "Data"

    End Sub
End Class