Public Class Shapes

    'Derek Bradshaw
    '10/24/2021
    'CPT 341 -  VB.NET NJIT Fall 2021 Semester





    Private Sub Shapes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()
        Dim toolTip2 As New ToolTip()
        Dim toolTip3 As New ToolTip()
        Dim toolTip4 As New ToolTip()
        toolTip1.ShowAlways = True
        toolTip2.ShowAlways = True
        toolTip3.ShowAlways = True
        toolTip4.ShowAlways = True
        toolTip1.SetToolTip(txtBase, "Enter a Valid Number for the Base")
        toolTip2.SetToolTip(txtHeight, "Enter a Valid Number for the Height")
        toolTip3.SetToolTip(txtDiameter, "Enter a Valid Number for the Diameter")
        toolTip4.SetToolTip(cboSelect, "Select the Calculations to be done")
    End Sub


    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        'Declare Variables
        Dim baseVal As Decimal
        Dim heightVal As Decimal
        Dim DiameterVal As Decimal
        Dim objRectangle As New clsRectangle
        Dim objTriangle As New clsTriangle
        Dim objCircle As New clsCircle



        'Error catching - Blank Values or non numbers entered

        Try 'storing Base Value.  
            baseVal = CDec(txtBase.Text)
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Base Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBase.Clear()
        End Try

        Try 'storing Height Value.  
            heightVal = CDec(txtHeight.Text)
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Height Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHeight.Clear()
        End Try

        Try 'storing Diameter Value.  
            DiameterVal = CDec(txtDiameter.Text)
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Diameter Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiameter.Clear()
        End Try

        If txtBase Is Nothing Then
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Base Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBase.Clear()
        End If
        If txtHeight Is Nothing Then
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Height Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHeight.Clear()
        End If
        If txtDiameter Is Nothing Then
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid value for 'Diameter Value'.  Cannot be left blank.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiameter.Clear()
        End If

        'End Error catching

        'Assign Properties
        With objRectangle
            .Base = baseVal
            .Height = heightVal
            .Diameter = DiameterVal
        End With
        With objTriangle
            .Base = baseVal
            .Height = heightVal
            .Diameter = DiameterVal
        End With
        With objCircle
            .Base = baseVal
            .Height = heightVal
            .Diameter = DiameterVal
        End With

        'Begin calculations - Changing the Lables on formm as we go
        'Each of the Sections are Rect, Triangle, Circle Ordered

        'Centroid - X
        If (cboSelect.SelectedIndex = 0) Then
            lblRectXCalc.Text = objRectangle.centx(objRectangle.Base)
            lblTriXCalc.Text = objTriangle.centx(objTriangle.Base)
            lblCircXCalc.Text = objCircle.centx(objCircle.Diameter)
        End If

        'Centroid - Y
        If (cboSelect.SelectedIndex = 1) Then
            lblRectYCalc.Text = objRectangle.centy(objRectangle.Height)
            lblTriYCalc.Text = objTriangle.centy(objTriangle.Height)
            lblCircYCalc.Text = objCircle.centy(objCircle.Diameter)
        End If


        'Area
        If (cboSelect.SelectedIndex = 2) Then
            lblRectAreaCalc.Text = objRectangle.Area(objRectangle.Base, objRectangle.Height)
            lblTriAreaCalc.Text = objTriangle.Area(objTriangle.Base, objTriangle.Height)
            lblCircAreaCalc.Text = objCircle.Area(objCircle.Diameter)
        End If




    End Sub


End Class
