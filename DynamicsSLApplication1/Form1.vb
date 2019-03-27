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
Option Explicit On
Option Strict Off
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Load all the forms needed for this application
        '
        'Call LoadForm(fSL01001)

        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()
        Call Init_Customer(LEVEL0, True)
        Call Init_xBillableSRamirez(LEVEL1, True)
        ' Call Set Address for the tables that will have fields displayed on the scree,
        ' or that you would like customization manager to be able to use
        'Call SetAddr(LEVEL0, "bxSLSample", bCustomer, nCustomer)

        ' Define the cursors that are used by the application

        ' This is an example for a table in the System Database
        'Call SqlCursor(c1, LEVEL0 + SqlSystemDb)

        ' This is an example for a table in an Application Database
        'Call SqlCursor(c1, LEVEL0 )


        ' Call the screen init function
        Call ScreenInit()

        'Tiene que ser después del ScreenInit()
        MH_xBillableSRamirez = DetailSetup(CSR_xBillableSRamirez, gvxBillable, bxBillableSRamirez.AddressOf("LineNbr"), bxBillableSRamirez, CNULL, CNULL, CNULL)

        'Variables del skd
        'BPES: variable de 'sesión'
        'TemplateID: plantilla para mandar llamar a un reporte en específico
        'CuryInfo: todo lo relacionado con las monedas
        'Favorites: sección de favoritos del menú
        'ScreenEntry: información de la pantalla

    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub txtCustomer_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles txtCustomer_0.ChkEvent
        serr_Customer = PVChkFetch1(CNULL, CSR_Customer, ChkStrg, bCustomer) 'Se le manda CNULL porque queremos que sea del mismo txtCustomer_0
    End Sub

    Private Sub gvxBillable_LineGotFocusEvent(ByRef maintflg As Short, ByRef retval As Short) Handles gvxBillable.LineGotFocusEvent
        'al hacer focus en la línea
        'maintFlg: para saber si es un nuevo row, update, etc.
        If maintflg = NEWROW Then
            bxBillableSRamirez.CustID = bCustomer.CustId
        End If
    End Sub

    Private Sub gvxBillable_LineChkEvent(ByRef Action As Short, ByRef MaintFlg As Short, ByRef RetVal As Short) Handles gvxBillable.LineChkEvent
        'al dejar el focus de la línea
        Select Case Action
            Case INSERTED
                bxBillableSRamirez.Crtd_DateTime = GetAuditDateTime() 'Date and hours
                bxBillableSRamirez.Crtd_Prog = bpes.ScrnNbr
                bxBillableSRamirez.Crtd_User = bpes.UserId
            Case UPDATED
                bxBillableSRamirez.Lupd_DateTime = bpes.Today
                bxBillableSRamirez.Lupd_Prog = bpes.ScrnNbr
                bxBillableSRamirez.Lupd_User = bpes.UserId
        End Select
    End Sub

    Private Function GetAuditDateTime() As Integer
        Dim iTime As Integer
        Dim iDate As Integer
        Try
            Call GetSysDate(iDate)
            Call GetSysTime(iTime)

            GetAuditDateTime = iDate + iTime
        Catch ex As Exception
            GetAuditDateTime = 0
        End Try
    End Function

End Class
