'Formata a Borda da celula onde o primeiro parametro(XlBordersIndex) define a orientação da formatação e o 
'segundo parametro define o estilo da borda.

xlWorkSheet.Range("COLOCAR RANGE DE CELULAS AQUI").Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlDot
