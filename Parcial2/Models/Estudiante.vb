Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Estudiante
        Public Property Id As Long

        Public Property Cedula As String

        Public Property Nombre As String

        Public Property Apellido As String

        Public Property Parcial1 As Integer

        Public Property Parcial2 As Integer

        Public Property Parcial3 As Integer

        Public Property ExamenFinal As Integer
        Public ReadOnly Property PromedioParcial As Integer
            Get
                Dim pesoParcial = 100 / 3
                Return ((Parcial1 + Parcial2 + Parcial3) * pesoParcial) / (pesoParcial * 3)
            End Get
        End Property
        Public ReadOnly Property CalificacionFinal As Double
            Get
                Dim pesoFinal = 100 / 2
                Return ((PromedioParcial + ExamenFinal) * pesoFinal) / (pesoFinal * 2)
            End Get
        End Property
        Public ReadOnly Property CalificacionFinalLetra As String
            Get
                Dim letra = ""

                Select Case CalificacionFinal
                    Case 0 To 60.6
                        letra = "F"
                    Case 60.7 To 70.5
                        letra = "D"
                    Case 70.6 To 80.5
                        letra = "C"
                    Case 80.6 To 90.5
                        letra = "B"
                    Case 90.6 To 100
                        letra = "A"
                    Case Else
                        Throw New Exception("Calificacion final invalida: " & CalificacionFinal)
                End Select

                Return letra & " (" & CalificacionFinal & ")"
            End Get
        End Property
    End Class
End Namespace
