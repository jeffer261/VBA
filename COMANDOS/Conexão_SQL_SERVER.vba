Dim strSQL As String
Dim cnn As New ADODB.Connection
Dim rs As ADODB.Recordset

'Abre conexão
cnn.Open(Data Source="COLOCAR O SERVER NAME SEM ASPAS";User ID="COLOCAR O USUARIO SEM ASPAS";Password="COLOCAR A SENHA SEM ASPAS";Initial Catalog=DB_ADMIX_IN;Provider=SQLNCLI.1;Auto Translate=False;)

strSQL = "SELECT ..." 

rs = cnn.Execute(strSQL)

'grava dados do select no excel
With xlWorkSheet.Range("A1")
.CopyFromRecordset(rs)
End With

'Fecha conexão
rs.Close()
cnn.Close()
