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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalesPersonId_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lblSalesPersonID_1 = New System.Windows.Forms.Label()
        Me.txtComision_0 = New Microsoft.Dynamics.SL.Controls.DSLFloat()
        Me.txtName_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lblComision_1 = New System.Windows.Forms.Label()
        Me.lblNombre_1 = New System.Windows.Forms.Label()
        Me.gvSalesperson = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Salesperson;D"
        Me.Update1.Location = New System.Drawing.Point(855, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalesPersonId_0)
        Me.GroupBox1.Controls.Add(Me.lblSalesPersonID_1)
        Me.GroupBox1.Controls.Add(Me.txtComision_0)
        Me.GroupBox1.Controls.Add(Me.txtName_0)
        Me.GroupBox1.Controls.Add(Me.lblComision_1)
        Me.GroupBox1.Controls.Add(Me.lblNombre_1)
        Me.GroupBox1.Controls.Add(Me.gvSalesperson)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 406)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtSalesPersonId_0
        '
        Me.txtSalesPersonId_0.Blankerr = True
        Me.txtSalesPersonId_0.FieldName = """bSalesperson.SlsperId""; 0; 0; 0"
        Me.txtSalesPersonId_0.Heading = "SalesPerson ID"
        Me.txtSalesPersonId_0.Level = "0,k"
        Me.txtSalesPersonId_0.Location = New System.Drawing.Point(158, 41)
        Me.txtSalesPersonId_0.Mask = "xxxxxxxxxx"
        Me.txtSalesPersonId_0.Name = "txtSalesPersonId_0"
        Me.txtSalesPersonId_0.PV = """xSalespersonID_PV_sramirez"", "
        Me.txtSalesPersonId_0.Size = New System.Drawing.Size(252, 26)
        Me.txtSalesPersonId_0.TabIndex = 1
        Me.txtSalesPersonId_0.TextLength = 10
        '
        'lblSalesPersonID_1
        '
        Me.lblSalesPersonID_1.AutoSize = True
        Me.lblSalesPersonID_1.Location = New System.Drawing.Point(44, 44)
        Me.lblSalesPersonID_1.Name = "lblSalesPersonID_1"
        Me.lblSalesPersonID_1.Size = New System.Drawing.Size(103, 17)
        Me.lblSalesPersonID_1.TabIndex = 20
        Me.lblSalesPersonID_1.Text = "Salesperson ID:"
        '
        'txtComision_0
        '
        Me.txtComision_0.Enabled = False
        Me.txtComision_0.FieldName = """bSalesperson.CmmnPct""; 0; 0; 0"
        Me.txtComision_0.Heading = "% comisión"
        Me.txtComision_0.Location = New System.Drawing.Point(158, 125)
        Me.txtComision_0.Min = 0.0R
        Me.txtComision_0.Name = "txtComision_0"
        Me.txtComision_0.Size = New System.Drawing.Size(119, 22)
        Me.txtComision_0.TabIndex = 19
        Me.txtComision_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtName_0
        '
        Me.txtName_0.Enabled = False
        Me.txtName_0.FieldName = """bSalesperson.Name""; 0; 0; 0"
        Me.txtName_0.Heading = "Nombre vendedor"
        Me.txtName_0.Location = New System.Drawing.Point(158, 85)
        Me.txtName_0.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.txtName_0.Name = "txtName_0"
        Me.txtName_0.Size = New System.Drawing.Size(213, 22)
        Me.txtName_0.TabIndex = 18
        Me.txtName_0.TextLength = 37
        '
        'lblComision_1
        '
        Me.lblComision_1.AutoSize = True
        Me.lblComision_1.Location = New System.Drawing.Point(63, 125)
        Me.lblComision_1.Name = "lblComision_1"
        Me.lblComision_1.Size = New System.Drawing.Size(84, 17)
        Me.lblComision_1.TabIndex = 17
        Me.lblComision_1.Text = "% comisión:"
        '
        'lblNombre_1
        '
        Me.lblNombre_1.AutoSize = True
        Me.lblNombre_1.Location = New System.Drawing.Point(85, 85)
        Me.lblNombre_1.Name = "lblNombre_1"
        Me.lblNombre_1.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre_1.TabIndex = 16
        Me.lblNombre_1.Text = "Nombre:"
        '
        'gvSalesperson
        '
        Me.gvSalesperson.Location = New System.Drawing.Point(660, 321)
        Me.gvSalesperson.Name = "gvSalesperson"
        Me.gvSalesperson.OcxState = CType(resources.GetObject("gvSalesperson.OcxState"), System.Windows.Forms.AxHost.State)
        Me.gvSalesperson.Size = New System.Drawing.Size(139, 56)
        Me.gvSalesperson.SetSLDBNav(Me.gvSalesperson, """xSalespersonID_PV_sramirez"", ""bSalesperson.SlsperId""; 0; 0; 0; 1, ")
        Me.gvSalesperson.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(892, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gvSalesperson As Microsoft.Dynamics.SL.Controls.DSLGrid
    Friend WithEvents txtSalesPersonId_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lblSalesPersonID_1 As System.Windows.Forms.Label
    Friend WithEvents txtComision_0 As Microsoft.Dynamics.SL.Controls.DSLFloat
    Friend WithEvents txtName_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lblComision_1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre_1 As System.Windows.Forms.Label
#End Region
End Class
