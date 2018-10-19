Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String
        TBid.Visible = False
        TBTranspppp.Visible = False
        BTUpdate.Visible = False


        Try
            strsql = "select * from Transportasi"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            cler_from()
            LVTranspor.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub cler_from()
        TBnama.Text = ""
        TBidnumber.Text = ""
        TBunit.Text = ""
        DateTimePicker1.Value = Now
        TBunitD.Text = ""
        TBareg.Text = ""
        CBtranspo.Text = ""
        TBphone.Text = ""
        TBintruksi.Text = ""
        TBTranspppp.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim uid As String




        Try


            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM Transportasi"
            cmd = New SqlCommand(query_id, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            uid = rd("MXID")
            rd.Close()



            query = "INSERT INTO Transportasi (RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Intruction) VALUES (" & uid & ",'" & TBnama.Text & "','" & TBidnumber.Text & "', '" & TBunit.Text & "','" & DateTimePicker1.Value & "','" & TBunitD.Text & "','" & TBareg.Text & "','" & CBtranspo.Text & "','" & TBphone.Text & "','" & TBintruksi.Text & "')"



            cmd = New SqlCommand(query, conn)
            rd = cmd.ExecuteReader
            rd.Close()

            cler_from()
            LVTranspor.Clear()
            show_list_Transportasi()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub show_list_Transportasi()
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVTranspor.View = View.Details        LVTranspor.Columns.Add("NO", 50)        LVTranspor.Columns.Add("Name Of Requestor", 125)        LVTranspor.Columns.Add("Unit From", 90)        LVTranspor.Columns.Add("Unit To", 70)        LVTranspor.Columns.Add("Request Date", 100)        LVTranspor.Columns.Add("Transportation", 100)        Call OpenKoneksi()        Dim query_id As String = "select * from Transportasi"        cmd = New SqlCommand(query_id, conn)        dr = cmd.ExecuteReader        Do While dr.Read            LVTranspor.Items.Add(dr("RequestId"))            LVTranspor.Items(LVTranspor.Items.Count - 1).SubItems.Add(dr("NameRequestor"))            LVTranspor.Items(LVTranspor.Items.Count - 1).SubItems.Add(dr("Unit"))            LVTranspor.Items(LVTranspor.Items.Count - 1).SubItems.Add(dr("UnitDestination"))            LVTranspor.Items(LVTranspor.Items.Count - 1).SubItems.Add(dr("DateIssue"))            LVTranspor.Items(LVTranspor.Items.Count - 1).SubItems.Add(dr("Transportation"))        Loop        dr.Close()        Call CloseKoneksi()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand        Dim dr As SqlDataReader
        Dim IDR As String
        BTUpdate.Visible = True
        BTSend.Visible = False

        Try
            IDR = LVTranspor.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "SELECT * FROM Transportasi WHERE RequestId='" + IDR + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader

            dr.Read()
            TBid.Text = dr("RequestId")
            TBnama.Text = dr("NameRequestor")
            TBidnumber.Text = dr("RequestorId")
            TBunit.Text = dr("Unit")
            DateTimePicker1.Value = Now
            TBunitD.Text = dr("UnitDestination")
            TBareg.Text = dr("acRegis")
            CBtranspo.Text = dr("Transportation")
            TBphone.Text = dr("Phone")
            TBintruksi.Text = dr("Intruction")

            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Idr As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            Idr = LVTranspor.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from Transportasi where RequestId='" + Idr + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVTranspor.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BTUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTUpdate.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String

        BTUpdate.Visible = False
        BTSend.Visible = True
        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM Transportasi"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = " Update Transportasi SET NameRequestor='" & TBnama.Text & "',RequestorId='" & TBidnumber.Text & "',Unit='" & TBunit.Text & "',DateIssue='" & DateTimePicker1.Value & "',UnitDestination='" & TBunitD.Text & "',acRegis='" & TBareg.Text & "',Transportation='" & CBtranspo.Text & "',Phone='" & TBphone.Text & "',Intruction='" & TBintruksi.Text & "' where RequestId='" & TBid.Text & "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            Call CloseKoneksi()
            cler_from()
            LVTranspor.Clear()
            show_list_Transportasi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub CBtranspo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtranspo.SelectedIndexChanged
        If CBtranspo.Text = "Other" Then
            TBTranspppp.Visible = True
        End If
    End Sub

    Private Sub TBTranspppp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTranspppp.TextChanged
        CBtranspo.Text = TBTranspppp.Text


        CBtranspo.Enabled = False


    End Sub
End Class
