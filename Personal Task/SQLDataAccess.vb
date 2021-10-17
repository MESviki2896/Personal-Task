Imports System.Configuration
Imports System.Data.SQLite
Imports System.Data
Imports Dapper
Imports Personal_Task.TrialTrackModel
Public Class SQLDataAccess
    Public Function LoadData(Optional ByVal modulename As String = "TrialTrack") As DataTable
        Dim dt As New DataTable
        Using cnn As IDbConnection = New SQLiteConnection(ConnectionString())
            Dim output As IDataReader
            If modulename = "TrialTrack" Then
                output = cnn.ExecuteReader("SELECT TCode,CustomerName,ProductName,Contact_Person,Contact_Num,Contact_Date,city,Sample_Date,ShippingDate,qty,DocketNumber,TMode,Remarks FROM TrialTask", New DynamicParameters())
            Else
                output = cnn.ExecuteReader("SELECT LeadID,TraderName,PersonName,ContactNo,AlternateContact,EmailID,ProductName,GivenDate,PaymentMode,Status,TID,Remarks from TaskList where status=1", New DynamicParameters())
            End If
            dt.Load(output)
            Return dt
        End Using
    End Function
    Public Function SavedData(ByVal model As TrialTrackModel)
        Using cnn As IDbConnection = New SQLiteConnection(ConnectionString())
            cnn.Execute("INSERT INTO TrialTask (CustomerName,ProductName,Contact_Person,Contact_Num,Contact_Date,city,Sample_Date,ShippingDate,qty,DocketNumber,TMode,Remarks,createdDate) VALUES(@CustomerName,@ProductName,@Contact_Person,@Contact_Num,@Contact_Date,@city,@Sample_Date,@ShippingDate,@Qty,@DocketNumber,@TMode,@Remarks,'" + Now().ToString + "')", model)
        End Using
    End Function
    Public Function SavedDataOrder(ByVal model As OrderModel)
        Using cnn As IDbConnection = New SQLiteConnection(ConnectionString())
            cnn.Execute("INSERT INTO TaskList(TraderName,PersonName,ContactNo,AlternateContact,EmailID,ProductName,GivenDate,PaymentMode,Status,TID,Remarks,CREATEDON) VALUES(@TraderName,@PersonName,@ContactNo,@AlternateContact,@EmailID,@ProductName,@GivenDate,@PaymentMode,@Status,@TID,@Remarks,'" + Now().ToString + "')", model)
        End Using
    End Function
    Public Function UpdateData(ByVal model As TrialTrackModel)
        Using cnn As IDbConnection = New SQLiteConnection(ConnectionString())
            cnn.Execute("update TrialTask set CustomerName=@CustomerName,ProductName=@ProductName,Contact_Person=@Contact_Person,Contact_Num=@Contact_Num,Contact_Date=@Contact_Date,city=@city,Sample_Date=@Sample_Date,ShippingDate=@ShippingDate,qty=@qty,DocketNumber=@DocketNumber,TMode=@TMode,Remarks=@Remarks where TCode=@LeadID", model)
        End Using
    End Function
    Public Function UpdateDataOrder(ByVal model As OrderModel)
        Using cnn As IDbConnection = New SQLiteConnection(ConnectionString())
            cnn.Execute("update TaskList set TraderName=@TraderName,PersonName=@PersonName,ContactNo=@ContactNo,AlternateContact=@AlternateContact,EmailID=@EmailID,ProductName=@ProductName,GivenDate=@GivenDate,PaymentMode=@PaymentMode,Status=@Status,TID=@TID,remarks=@Remarks where LeadID=@LeadID", model)
        End Using
    End Function
    Public Function ConnectionString(Optional ByVal id As String = "PersonaTask") As String
        Return ConfigurationManager.ConnectionStrings(id).ConnectionString
    End Function
End Class
Public Enum operationtype
    Insert
    Update
End Enum

