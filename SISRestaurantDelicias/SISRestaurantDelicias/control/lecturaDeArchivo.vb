Imports System.IO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser

Module lecturaDeArchivo
    Public Function leerArchivo(ByVal ruta As String) As Dictionary(Of String, Collection)
        Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ruta)
        MyReader.TextFieldType = FileIO.FieldType.Delimited
        MyReader.SetDelimiters(",")

        Dim claves As String()
        Dim retorno As New Dictionary(Of String, Collection)

        While Not MyReader.EndOfData
            Try
                Dim claves2 As New List(Of String)
                Dim usuarios As New Collection
                claves = MyReader.ReadFields()
                For i = 0 To (claves.Length - 2)
                    claves2.Add(claves(i))
                Next
                usuarios.Add(claves2)
                retorno.Add(claves2(0), usuarios)
            Catch ex As Exception

            End Try
        End While

        Return retorno
    End Function

End Module
