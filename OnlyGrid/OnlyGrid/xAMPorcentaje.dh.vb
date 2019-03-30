'------------------------------------------------------------------------------
' <copyright file="xAMPorcentaje.sdo.vb" company="Apps Mexico">
'     Todos los derechos reservados - Juan Carlos Navarro Ramirez.
'     Site: www.appsmexico.mx
'     Product: Dynamics SL
' </copyright>
'------------------------------------------------------------------------------
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxAMPorcentaje
	Public Class xAMPorcentaje
		Inherits SolomonDataObject

		< _
		DataBinding(PropertyIndex:=0) _
		> _
		Public Property PercentChg() As Double
			Get
				Return Me.GetPropertyValue("PercentChg")
			End Get
			Set(ByVal setval As Double)
				Me.SetPropertyValue("PercentChg", setval)
			End Set
		End Property

	End Class
	Public bxAMPorcentaje As xAMPorcentaje = New xAMPorcentaje, nxAMPorcentaje As xAMPorcentaje = New xAMPorcentaje, txAMPorcentaje As xAMPorcentaje = New xAMPorcentaje
	Public CSR_xAMPorcentaje As Short

	Public serr_xAMPorcentaje As Short

	Public MH_xAMPorcentaje As Short
	Public MH_xAMPorcentaje_Flag As Short
	Public MH_xAMPorcentaje_Row As Short

	Sub Init_xAMPorcentaje(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
		Call SetAddr(x_Level, "bxAMPorcentaje", bxAMPorcentaje, nxAMPorcentaje)
		If x_Cursor = True Then
			Call SqlCursor(CSR_xAMPorcentaje, x_Level)
		End If
	End Sub
End Module
