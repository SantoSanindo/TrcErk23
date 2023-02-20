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
        Dim start_addrs As Integer = Convert.ToDecimal(txtStartAdress.Text)
        'Dim myArray(,) As Integer

        Dim dt As New DataTable()
        dt.Columns.Add("AddresMW")
        dt.Columns.Add("Data")

        For i As Integer = 0 To readHoldingRegister.Length - 1
            dt.Rows.Add(i + start_addrs, readHoldingRegister(i))
        Next
        DGV_Read.DataSource = dt

    End Sub

    Private Sub btnWriteReg_Click(sender As Object, e As EventArgs) Handles btnWriteReg.Click
        modbusClient.WriteSingleRegister(txtStartAdress.Text, txt_Data_Write.Text)
    End Sub
End Class