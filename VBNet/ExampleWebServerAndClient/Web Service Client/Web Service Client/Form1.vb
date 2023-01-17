'Author: Steven Metcalf
'Date: 5/15/2019
'Project: Final Project - Web Service Client
'Description: A web Service Client that connects to an external Program and reads back input

' Class description: the presentation layer responsible for updating the screen and reacting to GUI events
Public Class frmPresentation
    Private connection
    Private Sub frmPresentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New Business

    End Sub

    Private Sub btnHelloWorld_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click

        Dim hello As String = connection.HelloWorld()
        MsgBox(hello)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lvDisplay.Items.Clear()
        lvDisplay.Update()

        Dim CustomerId = -1
        Try
            CustomerId = Convert.ToInt32(tbCustomerID.Text)
        Catch ex As Exception
            CustomerId = -1
        End Try
        Dim name = tbName.Text
        Dim address1 = tbAddress1.Text
        Dim address2 = tbAddress2.Text
        Dim city = tbCity.Text
        Dim state = tbState.Text
        Dim zip = tbZip.Text


        Dim result = connection.CustomerSelect(CustomerId, name, address1, address2, city, state, zip)

        For Each item As Tuple(Of Integer, String, String, String, String, String, String) In result
            Dim lvItem = New ListViewItem(item.Item1.ToString)
            lvItem.SubItems.Add(item.Item2)
            lvItem.SubItems.Add(item.Item3)
            lvItem.SubItems.Add(item.Item4)
            lvItem.SubItems.Add(item.Item5)
            lvItem.SubItems.Add(item.Item6)
            lvItem.SubItems.Add(item.Item7)

            lvDisplay.Items.Add(lvItem)
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim CustomerId = tbCustomerID.Text
        If (Not IsNumeric(CustomerId)) Then
            MsgBox("Please Enter A Valid ID")
            Return
        End If
        Dim name = tbName.Text
        If (name.Equals("")) Then
            MsgBox("Please Enter a Name")
        End If
        Dim address1 = tbAddress1.Text
        If (name.Equals("")) Then
            MsgBox("Please Enter Address For Address 1")
        End If
        Dim address2 = tbAddress2.Text
        If (name.Equals("")) Then
            address2 = ""
        End If
        Dim city = tbCity.Text
        If (name.Equals("")) Then
            MsgBox("Please Enter a City")
        End If
        Dim state = tbState.Text
        If (name.Equals("")) Then
            MsgBox("Please Enter a State")
        End If
        Dim zip = tbZip.Text
        If (Not IsNumeric(zip)) Then
            MsgBox("Please Enter A Valid Zip")
            Return
        End If
        Try
            Dim result = connection.CustomerUpdate(CustomerId, name, address1, address2, city, state, zip)
            MsgBox("Entry Updated Successfully")
        Catch ex As Exception
            MsgBox("Please Check Your Entry and Try Again!")
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim name = tbName.Text
        Dim address1 = tbAddress1.Text
        Dim address2 = tbAddress2.Text
        Dim city = tbCity.Text
        Dim state = tbState.Text
        Dim zip = tbZip.Text

        If name.Equals("") Then
            MsgBox("You must input a valid name")
            Exit Sub
        ElseIf address1.Equals("") Then
            MsgBox("You must input a valid address for address 1")
            Exit Sub
        ElseIf address2.Equals("") Then
            address2 = "+"
        ElseIf city.Equals("") Then
            MsgBox("You must input a valid city name")
            Exit Sub
        ElseIf state.Equals("") Then
            MsgBox("You must input a valid state name")
            Exit Sub
        ElseIf zip.Equals("") Then
            MsgBox("You must input a valid zip code")
            Exit Sub
        End If

        Dim result = connection.CustomerInsert(name, address1, address2, city, state, zip)
        If result.substring(0, 1) = 0 Then
            MsgBox("Customer has been added!")
        Else
            MsgBox("Unable to add customer!")
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim customerID = tbCustomerID.Text
        Dim result
        If IsNumeric(customerID) Then
            result = connection.CustomerDelete(Convert.ToInt32(customerID))
            If result = "0" Then
                MsgBox("Customer Deleted")
            Else
                MsgBox("Customer Could not be deleted for that ID")
            End If
        Else
            MsgBox("You must enter a valid Customer ID")
        End If
    End Sub
End Class
