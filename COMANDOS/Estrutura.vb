Imports System
Imports System.Data
Imports System.Math
Imports Microsoft.SqlServer.Dts.Runtime
Imports Microsoft.Office.Interop
Imports System.Xml
Imports ADODB

Public Class ScriptMain

    
    Public xlApp As Excel.Application
    Public xlWorkbook As Excel.Workbook
    Public xlWorkSheet As Excel.Worksheet

    Public Sub Main()
        Dim CaminhoArquivo As String
        Dim Rows As Integer
        Dim a As Excel.Worksheet


		'Digitar as instruções aqui
		'Adicionar as referencias adodb e Microsoft.Office.Interop.Excel

        'SaveExcel(CaminhoArquivo)
        lWorkbook.Close(True)

        CloseExcel()


        Dts.TaskResult = Dts.Results.Success

    End Sub
    Public Sub OpenExcel(ByVal strCaminho As String)

        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open(strCaminho)

    End Sub
    Public Sub ActiveSheet(ByVal intSheet As Integer)
        xlWorkSheet = CType(xlWorkbook.Worksheets(intSheet), Excel.Worksheet)
        xlWorkSheet.Activate()
    End Sub
    Public Sub SaveExcel(ByVal strCaminho As String)
        'Salva Excel
        xlApp.DisplayAlerts = False
        If (Not xlWorkbook Is Nothing) Then xlWorkbook.SaveAs(strCaminho)
        If (Not xlApp Is Nothing) Then xlApp.Quit()
    End Sub
    Public Sub CloseExcel()

        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkbook)
        releaseObject(xlWorkSheet)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
