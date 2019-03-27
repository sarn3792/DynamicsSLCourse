'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		m_IsInitializing = true
		InitializeComponent()
		m_IsInitializing = False
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.lblCustomer_0 = New System.Windows.Forms.Label()
        Me.txtCustomer_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.txtName_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lblName_0 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDescription_1 = New System.Windows.Forms.Label()
        Me.txtDescription = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lblHoursWorked_1 = New System.Windows.Forms.Label()
        Me.txtHours_1 = New Microsoft.Dynamics.SL.Controls.DSLFloat()
        Me.lblWorkDate_1 = New System.Windows.Forms.Label()
        Me.txtWorkedDate_1 = New Microsoft.Dynamics.SL.Controls.DSLDate()
        Me.txtSalesPersonId = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lblSalesPersonID_1 = New System.Windows.Forms.Label()
        Me.gvxBillable = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvxBillable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Customer;N,xBillableSRamirez;D"
        Me.Update1.Location = New System.Drawing.Point(757, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'lblCustomer_0
        '
        Me.lblCustomer_0.AutoSize = True
        Me.lblCustomer_0.Location = New System.Drawing.Point(39, 44)
        Me.lblCustomer_0.Name = "lblCustomer_0"
        Me.lblCustomer_0.Size = New System.Drawing.Size(95, 17)
        Me.lblCustomer_0.TabIndex = 1
        Me.lblCustomer_0.Text = "Customer ID: "
        '
        'txtCustomer_0
        '
        Me.txtCustomer_0.Blankerr = True
        Me.txtCustomer_0.FieldName = """bCustomer.CustId""; 0; 0; 0"
        Me.txtCustomer_0.Level = "0,k"
        Me.txtCustomer_0.Location = New System.Drawing.Point(150, 41)
        Me.txtCustomer_0.Mask = "xxxxxxxxxxxxxxxx"
        Me.txtCustomer_0.Name = "txtCustomer_0"
        Me.txtCustomer_0.PV = """Customer_all"", "
        Me.txtCustomer_0.Size = New System.Drawing.Size(223, 22)
        Me.txtCustomer_0.TabIndex = 2
        Me.txtCustomer_0.TextLength = 16
        '
        'txtName_0
        '
        Me.txtName_0.Blankerr = True
        Me.txtName_0.FieldName = """bCustomer.Name""; 0; 0; 0"
        Me.txtName_0.Location = New System.Drawing.Point(150, 93)
        Me.txtName_0.Mask = "xxxxxxxxxxxxxxxx"
        Me.txtName_0.Name = "txtName_0"
        Me.txtName_0.Size = New System.Drawing.Size(351, 22)
        Me.txtName_0.TabIndex = 4
        Me.txtName_0.TextLength = 16
        '
        'lblName_0
        '
        Me.lblName_0.AutoSize = True
        Me.lblName_0.Location = New System.Drawing.Point(82, 96)
        Me.lblName_0.Name = "lblName_0"
        Me.lblName_0.Size = New System.Drawing.Size(52, 17)
        Me.lblName_0.TabIndex = 3
        Me.lblName_0.Text = "Name: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDescription_1)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblHoursWorked_1)
        Me.GroupBox1.Controls.Add(Me.txtHours_1)
        Me.GroupBox1.Controls.Add(Me.lblWorkDate_1)
        Me.GroupBox1.Controls.Add(Me.txtWorkedDate_1)
        Me.GroupBox1.Controls.Add(Me.txtSalesPersonId)
        Me.GroupBox1.Controls.Add(Me.lblSalesPersonID_1)
        Me.GroupBox1.Controls.Add(Me.gvxBillable)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 322)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hours worked - (F4 para tabla / forma)"
        '
        'lblDescription_1
        '
        Me.lblDescription_1.AutoSize = True
        Me.lblDescription_1.Location = New System.Drawing.Point(36, 186)
        Me.lblDescription_1.Name = "lblDescription_1"
        Me.lblDescription_1.Size = New System.Drawing.Size(81, 17)
        Me.lblDescription_1.TabIndex = 8
        Me.lblDescription_1.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Blankerr = True
        Me.txtDescription.FieldName = """bxBillableSRamirez.Descr""; 0; 0; 0"
        Me.txtDescription.Heading = "Description"
        Me.txtDescription.Level = "1"
        Me.txtDescription.Location = New System.Drawing.Point(128, 183)
        Me.txtDescription.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(444, 22)
        Me.txtDescription.TabIndex = 7
        Me.txtDescription.TextLength = 60
        '
        'lblHoursWorked_1
        '
        Me.lblHoursWorked_1.AutoSize = True
        Me.lblHoursWorked_1.Location = New System.Drawing.Point(19, 135)
        Me.lblHoursWorked_1.Name = "lblHoursWorked_1"
        Me.lblHoursWorked_1.Size = New System.Drawing.Size(98, 17)
        Me.lblHoursWorked_1.TabIndex = 6
        Me.lblHoursWorked_1.Text = "Hours worked:"
        '
        'txtHours_1
        '
        Me.txtHours_1.Blankerr = True
        Me.txtHours_1.DecimalPlaces = 0
        Me.txtHours_1.FieldName = """bxBillableSRamirez.Hours""; 0; 0; 0"
        Me.txtHours_1.Heading = "Hours worked"
        Me.txtHours_1.Level = "1"
        Me.txtHours_1.Location = New System.Drawing.Point(128, 132)
        Me.txtHours_1.Max = 24.0R
        Me.txtHours_1.Min = 0.0R
        Me.txtHours_1.Name = "txtHours_1"
        Me.txtHours_1.Size = New System.Drawing.Size(100, 22)
        Me.txtHours_1.TabIndex = 5
        Me.txtHours_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWorkDate_1
        '
        Me.lblWorkDate_1.AutoSize = True
        Me.lblWorkDate_1.Location = New System.Drawing.Point(40, 86)
        Me.lblWorkDate_1.Name = "lblWorkDate_1"
        Me.lblWorkDate_1.Size = New System.Drawing.Size(78, 17)
        Me.lblWorkDate_1.TabIndex = 4
        Me.lblWorkDate_1.Text = "Work date:"
        '
        'txtWorkedDate_1
        '
        Me.txtWorkedDate_1.Blankerr = True
        Me.txtWorkedDate_1.Default = "0; ""bpes.Today""; 0; 0; 0"
        Me.txtWorkedDate_1.FieldName = """bxBillableSRamirez.WorkDate""; 0; 0; 0"
        Me.txtWorkedDate_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.8!)
        Me.txtWorkedDate_1.Heading = "Work date"
        Me.txtWorkedDate_1.Level = "1"
        Me.txtWorkedDate_1.Location = New System.Drawing.Point(128, 86)
        Me.txtWorkedDate_1.Name = "txtWorkedDate_1"
        Me.txtWorkedDate_1.Size = New System.Drawing.Size(200, 20)
        Me.txtWorkedDate_1.TabIndex = 3
        '
        'txtSalesPersonId
        '
        Me.txtSalesPersonId.Blankerr = True
        Me.txtSalesPersonId.FieldName = """bxBillableSRamirez.SlsperId""; 0; 0; 0"
        Me.txtSalesPersonId.Heading = "SalesPerson ID"
        Me.txtSalesPersonId.Level = "1"
        Me.txtSalesPersonId.Location = New System.Drawing.Point(128, 32)
        Me.txtSalesPersonId.Mask = "xxxxxxxxxx"
        Me.txtSalesPersonId.Name = "txtSalesPersonId"
        Me.txtSalesPersonId.PV = """xSalespersonID_PV_sramirez"", "
        Me.txtSalesPersonId.Size = New System.Drawing.Size(252, 26)
        Me.txtSalesPersonId.TabIndex = 2
        Me.txtSalesPersonId.TextLength = 10
        '
        'lblSalesPersonID_1
        '
        Me.lblSalesPersonID_1.AutoSize = True
        Me.lblSalesPersonID_1.Location = New System.Drawing.Point(19, 35)
        Me.lblSalesPersonID_1.Name = "lblSalesPersonID_1"
        Me.lblSalesPersonID_1.Size = New System.Drawing.Size(103, 17)
        Me.lblSalesPersonID_1.TabIndex = 1
        Me.lblSalesPersonID_1.Text = "Salesperson ID:"
        '
        'gvxBillable
        '
        Me.gvxBillable.Location = New System.Drawing.Point(486, 243)
        Me.gvxBillable.Name = "gvxBillable"
        Me.gvxBillable.OcxState = CType(resources.GetObject("gvxBillable.OcxState"), System.Windows.Forms.AxHost.State)
        Me.gvxBillable.Size = New System.Drawing.Size(198, 61)
        Me.gvxBillable.SetSLDBNav(Me.gvxBillable, """xBillableSRamirez_All"", ""bCustomer.CustId""; 0; 0; 0; 0, ""bxBillableSRamirez.Line" & _
        "Nbr""; 0; 0; 0; 1, ")
        Me.gvxBillable.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtName_0)
        Me.Controls.Add(Me.lblName_0)
        Me.Controls.Add(Me.txtCustomer_0)
        Me.Controls.Add(Me.lblCustomer_0)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "First project (XU.N001)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvxBillable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents lblCustomer_0 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents txtName_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lblName_0 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gvxBillable As Microsoft.Dynamics.SL.Controls.DSLGrid
    Friend WithEvents txtSalesPersonId As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lblSalesPersonID_1 As System.Windows.Forms.Label
    Friend WithEvents txtHours_1 As Microsoft.Dynamics.SL.Controls.DSLFloat
    Friend WithEvents lblWorkDate_1 As System.Windows.Forms.Label
    Friend WithEvents txtWorkedDate_1 As Microsoft.Dynamics.SL.Controls.DSLDate
    Friend WithEvents lblHoursWorked_1 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lblDescription_1 As System.Windows.Forms.Label
#End Region
End Class
