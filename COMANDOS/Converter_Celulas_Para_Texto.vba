'Converte todas as celulas da planilha selecionada para texto

Dim A As Excel.Worksheet 

A = CType(xlWorkbook.Worksheets("COLOCAR PLANINHA AQUI"), Excel.Worksheet)
A.UsedRange.Formula = A.UsedRange.Formula
A.Calculate()
