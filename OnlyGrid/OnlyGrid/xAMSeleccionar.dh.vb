'------------------------------------------------------------------------------
' <copyright file="xAMSeleccionar.sdo.vb" company="Apps Mexico">
'     Todos los derechos reservados - Juan Carlos Navarro Ramirez.
'     Site: www.appsmexico.mx
'     Product: Dynamics SL
' </copyright>
'------------------------------------------------------------------------------
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxAMSeleccionar
	Public Class xAMSeleccionar
		Inherits SolomonDataObject

		< _
		DataBinding(PropertyIndex:=0, StringSize:=1) _
		> _
		Public Property Seleccionar() As String
			Get
				Return Me.GetPropertyValue("Seleccionar")
			End Get
			Set(ByVal setval As String)
				Me.SetPropertyValue("Seleccionar", setval)
			End Set
		End Property

	End Class
	Public bxAMSeleccionar As xAMSeleccionar = New xAMSeleccionar, nxAMSeleccionar As xAMSeleccionar = New xAMSeleccionar, txAMSeleccionar As xAMSeleccionar = New xAMSeleccionar
	Public CSR_xAMSeleccionar As Short

	Public serr_xAMSeleccionar As Short

	Public MH_xAMSeleccionar As Short
	Public MH_xAMSeleccionar_Flag As Short
	Public MH_xAMSeleccionar_Row As Short

	Sub Init_xAMSeleccionar(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
		Call SetAddr(x_Level, "bxAMSeleccionar", bxAMSeleccionar, nxAMSeleccionar)
		If x_Cursor = True Then
			Call SqlCursor(CSR_xAMSeleccionar, x_Level)
		End If
	End Sub
End Module
