<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ST1_Modbus_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnWriteMultipleReg = New System.Windows.Forms.Button()
        Me.btnWriteMultipleCoils = New System.Windows.Forms.Button()
        Me.btnWriteSingleReg = New System.Windows.Forms.Button()
        Me.grpExchange = New System.Windows.Forms.GroupBox()
        Me.btnWriteSingleCoil = New System.Windows.Forms.Button()
        Me.btnReadInpReg = New System.Windows.Forms.Button()
        Me.btnReadHoldReg = New System.Windows.Forms.Button()
        Me.btnReadDisInp = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtStartAdress = New System.Windows.Forms.TextBox()
        Me.btnReadCoils = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.grpStart = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Data_Write = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGV_Write = New System.Windows.Forms.DataGridView()
        Me.DGV_Read = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clm_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpExchange.SuspendLayout()
        Me.grpStart.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Write, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Read, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(93, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(87, 20)
        Me.txtIP.TabIndex = 5
        Me.txtIP.Text = "127.0.0.1"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(13, 27)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(74, 14)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(87, 25)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(50, 20)
        Me.txtUnit.TabIndex = 24
        Me.txtUnit.Text = "0"
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnWriteMultipleReg
        '
        Me.btnWriteMultipleReg.Location = New System.Drawing.Point(573, 76)
        Me.btnWriteMultipleReg.Name = "btnWriteMultipleReg"
        Me.btnWriteMultipleReg.Size = New System.Drawing.Size(87, 35)
        Me.btnWriteMultipleReg.TabIndex = 23
        Me.btnWriteMultipleReg.Text = "Write multiple register"
        '
        'btnWriteMultipleCoils
        '
        Me.btnWriteMultipleCoils.Location = New System.Drawing.Point(573, 28)
        Me.btnWriteMultipleCoils.Name = "btnWriteMultipleCoils"
        Me.btnWriteMultipleCoils.Size = New System.Drawing.Size(87, 34)
        Me.btnWriteMultipleCoils.TabIndex = 22
        Me.btnWriteMultipleCoils.Text = "Write multiple coils"
        '
        'btnWriteSingleReg
        '
        Me.btnWriteSingleReg.Location = New System.Drawing.Point(473, 76)
        Me.btnWriteSingleReg.Name = "btnWriteSingleReg"
        Me.btnWriteSingleReg.Size = New System.Drawing.Size(87, 35)
        Me.btnWriteSingleReg.TabIndex = 21
        Me.btnWriteSingleReg.Text = "Write single register"
        '
        'grpExchange
        '
        Me.grpExchange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExchange.Controls.Add(Me.txt_Data_Write)
        Me.grpExchange.Controls.Add(Me.label4)
        Me.grpExchange.Controls.Add(Me.txtUnit)
        Me.grpExchange.Controls.Add(Me.btnWriteMultipleReg)
        Me.grpExchange.Controls.Add(Me.btnWriteMultipleCoils)
        Me.grpExchange.Controls.Add(Me.btnWriteSingleReg)
        Me.grpExchange.Controls.Add(Me.btnWriteSingleCoil)
        Me.grpExchange.Controls.Add(Me.btnReadInpReg)
        Me.grpExchange.Controls.Add(Me.btnReadHoldReg)
        Me.grpExchange.Controls.Add(Me.btnReadDisInp)
        Me.grpExchange.Controls.Add(Me.Label5)
        Me.grpExchange.Controls.Add(Me.label3)
        Me.grpExchange.Controls.Add(Me.txtSize)
        Me.grpExchange.Controls.Add(Me.label2)
        Me.grpExchange.Controls.Add(Me.txtStartAdress)
        Me.grpExchange.Controls.Add(Me.btnReadCoils)
        Me.grpExchange.Location = New System.Drawing.Point(9, 70)
        Me.grpExchange.Name = "grpExchange"
        Me.grpExchange.Size = New System.Drawing.Size(740, 118)
        Me.grpExchange.TabIndex = 18
        Me.grpExchange.TabStop = False
        Me.grpExchange.Text = "Data exhange"
        Me.grpExchange.Visible = False
        '
        'btnWriteSingleCoil
        '
        Me.btnWriteSingleCoil.Location = New System.Drawing.Point(473, 28)
        Me.btnWriteSingleCoil.Name = "btnWriteSingleCoil"
        Me.btnWriteSingleCoil.Size = New System.Drawing.Size(87, 34)
        Me.btnWriteSingleCoil.TabIndex = 19
        Me.btnWriteSingleCoil.Text = "Write single coil"
        '
        'btnReadInpReg
        '
        Me.btnReadInpReg.Location = New System.Drawing.Point(373, 76)
        Me.btnReadInpReg.Name = "btnReadInpReg"
        Me.btnReadInpReg.Size = New System.Drawing.Size(87, 35)
        Me.btnReadInpReg.TabIndex = 18
        Me.btnReadInpReg.Text = "Read input register"
        '
        'btnReadHoldReg
        '
        Me.btnReadHoldReg.Location = New System.Drawing.Point(373, 28)
        Me.btnReadHoldReg.Name = "btnReadHoldReg"
        Me.btnReadHoldReg.Size = New System.Drawing.Size(87, 34)
        Me.btnReadHoldReg.TabIndex = 17
        Me.btnReadHoldReg.Text = "Read holding register"
        '
        'btnReadDisInp
        '
        Me.btnReadDisInp.Location = New System.Drawing.Point(273, 76)
        Me.btnReadDisInp.Name = "btnReadDisInp"
        Me.btnReadDisInp.Size = New System.Drawing.Size(87, 35)
        Me.btnReadDisInp.TabIndex = 16
        Me.btnReadDisInp.Text = "Read discrete inputs"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(13, 78)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(74, 14)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(87, 78)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(50, 20)
        Me.txtSize.TabIndex = 14
        Me.txtSize.Text = "32"
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(13, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 14)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Start Adress"
        '
        'txtStartAdress
        '
        Me.txtStartAdress.Location = New System.Drawing.Point(87, 51)
        Me.txtStartAdress.Name = "txtStartAdress"
        Me.txtStartAdress.Size = New System.Drawing.Size(50, 20)
        Me.txtStartAdress.TabIndex = 12
        Me.txtStartAdress.Text = "0"
        Me.txtStartAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReadCoils
        '
        Me.btnReadCoils.Location = New System.Drawing.Point(273, 28)
        Me.btnReadCoils.Name = "btnReadCoils"
        Me.btnReadCoils.Size = New System.Drawing.Size(87, 34)
        Me.btnReadCoils.TabIndex = 11
        Me.btnReadCoils.Text = "Read coils"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(13, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 14)
        Me.label1.TabIndex = 7
        Me.label1.Text = "IP Address"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(187, 21)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(86, 28)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        '
        'grpStart
        '
        Me.grpStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStart.Controls.Add(Me.label1)
        Me.grpStart.Controls.Add(Me.btnConnect)
        Me.grpStart.Controls.Add(Me.txtIP)
        Me.grpStart.Location = New System.Drawing.Point(9, 8)
        Me.grpStart.Name = "grpStart"
        Me.grpStart.Size = New System.Drawing.Size(740, 55)
        Me.grpStart.TabIndex = 17
        Me.grpStart.TabStop = False
        Me.grpStart.Text = "Start communication"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV_Read)
        Me.GroupBox1.Controls.Add(Me.DGV_Write)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 508)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'txt_Data_Write
        '
        Me.txt_Data_Write.Location = New System.Drawing.Point(187, 25)
        Me.txt_Data_Write.Name = "txt_Data_Write"
        Me.txt_Data_Write.Size = New System.Drawing.Size(57, 20)
        Me.txt_Data_Write.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(152, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Data"
        '
        'DGV_Write
        '
        Me.DGV_Write.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Write.Location = New System.Drawing.Point(16, 44)
        Me.DGV_Write.Name = "DGV_Write"
        Me.DGV_Write.Size = New System.Drawing.Size(240, 447)
        Me.DGV_Write.TabIndex = 1
        '
        'DGV_Read
        '
        Me.DGV_Read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Read.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_No, Me.clm_Data})
        Me.DGV_Read.Location = New System.Drawing.Point(320, 44)
        Me.DGV_Read.Name = "DGV_Read"
        Me.DGV_Read.ReadOnly = True
        Me.DGV_Read.Size = New System.Drawing.Size(240, 447)
        Me.DGV_Read.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(13, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 14)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Write Data"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(317, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Read Data"
        '
        'clm_No
        '
        Me.clm_No.HeaderText = "No"
        Me.clm_No.Name = "clm_No"
        Me.clm_No.ReadOnly = True
        '
        'clm_Data
        '
        Me.clm_Data.HeaderText = "Data MW"
        Me.clm_Data.Name = "clm_Data"
        Me.clm_Data.ReadOnly = True
        '
        'ST1_Modbus_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpExchange)
        Me.Controls.Add(Me.grpStart)
        Me.Name = "ST1_Modbus_Form"
        Me.Text = "ST1_Modbus"
        Me.grpExchange.ResumeLayout(False)
        Me.grpExchange.PerformLayout()
        Me.grpStart.ResumeLayout(False)
        Me.grpStart.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_Write, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Read, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtIP As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtUnit As TextBox
    Private WithEvents btnWriteMultipleReg As Button
    Private WithEvents btnWriteMultipleCoils As Button
    Private WithEvents btnWriteSingleReg As Button
    Private WithEvents grpExchange As GroupBox
    Private WithEvents btnWriteSingleCoil As Button
    Private WithEvents btnReadInpReg As Button
    Private WithEvents btnReadHoldReg As Button
    Private WithEvents btnReadDisInp As Button
    Private WithEvents label3 As Label
    Private WithEvents txtSize As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtStartAdress As TextBox
    Private WithEvents btnReadCoils As Button
    Private WithEvents label1 As Label
    Private WithEvents btnConnect As Button
    Private WithEvents grpStart As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Data_Write As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents DGV_Read As DataGridView
    Friend WithEvents DGV_Write As DataGridView
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents clm_No As DataGridViewTextBoxColumn
    Friend WithEvents clm_Data As DataGridViewTextBoxColumn
End Class
