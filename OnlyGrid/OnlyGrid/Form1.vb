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
        'Call LoadForm(fSL01001)

        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()
        Call Init_Salesperson(LEVEL0, True)
        Call Init_xAMPorcentaje(NOLEVEL, False)
        Call Init_xAMSeleccionar(NOLEVEL, False)

        ' Call Set Address for the tables that will have fields displayed on the scree,
        ' or that you would like customization manager to be able to use
        'Call SetAddr(LEVEL0, "bxSLSample", bxSLSample, nxSLSample)

        ' Define the cursors that are used by the application

        ' This is an example for a table in the System Database
        'Call SqlCursor(c1, LEVEL0 + SqlSystemDb)

        ' This is an example for a table in an Application Database
        'Call SqlCursor(c1, LEVEL0 )


        ' Call the screen init function
        Call ScreenInit()

        MH_Salesperson = DetailSetup(CSR_Salesperson, gvSalesperson, PNULL, bSalesperson, CNULL, CNULL, CNULL)
        Call DetailSetupExtend(gvSalesperson, bxAMSeleccionar) 'para decirle que es un unbound object
        Call MSet(chkSeleccionar_N, "0") 'se le pone al checkbox uncheck

        Call SetButton(TbInsertButton + TbDeleteButton, LEVEL0, False)

    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Call MSet(chkSeleccionar_N, "1")
        Call MDisplay(MH_Salesperson)
    End Sub

    Private Sub btnDeseleccionar_Click(sender As Object, e As EventArgs) Handles btnDeseleccionar.Click
        Call MSet(chkSeleccionar_N, "0")
        Call MDisplay(MH_Salesperson)
    End Sub

    Private Sub btnIniciarProceso_Click(sender As Object, e As EventArgs) Handles btnIniciarProceso.Click
        Call TranBeg(True)
        'Obtiene el número de renglón en el que está posicionado el usuario al momento de presionar el botón
        MH_Salesperson_Row = MGetRowNum(MH_Salesperson)

        'a nivel de la memoria posiciona el cursor en el primer renglón
        serr_Salesperson = MFirst(MH_Salesperson, MH_Salesperson_Flag)

        'serr_Salesperson será 0 cuando todavía haya reglones que recorrer
        While serr_Salesperson = 0

            If bxAMSeleccionar.Seleccionar = "1" Then
                'bSalesperson.Name = String.Format("{0} UPDATE", bSalesperson.Name.Trim())
                'bSalesperson.CmmnPct = bxAMPorcentaje.PercentChg
                'Call MUpdate(MH_Salesperson)
                'Call sql(c1, String.Format("UPDATE Salesperson SET CmmnPct = {0} WHERE slsperid = {1}", FParm(bxAMPorcentaje.PercentChg), SParm(bSalesperson.SlsperId)))

                bSalesperson.CmmnPct = FPAdd(bSalesperson.CmmnPct, bxAMPorcentaje.PercentChg, PERCENT)
                bSalesperson.LUpd_User = bpes.UserId
                bSalesperson.LUpd_Prog = bpes.ScrnNbr

                Call SUpdate1(CSR_Salesperson, "Salesperson", bSalesperson) 'Hace update en sql
            End If

            serr_Salesperson = MNext(MH_Salesperson, MH_Salesperson_Flag)
        End While

        'Se regresa al usuario en el renglón que estaba en un inicio
        Call MSetRow(MH_Salesperson, MH_Salesperson_Row)
        'Se despliega los cambios en memoria en el grid
        Call MDisplay(MH_Salesperson)
        Call SqlFree(c1)

        Call TranEnd() 'commit

        'Call TranAbort() 'rollback
    End Sub
End Class
