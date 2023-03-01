<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblPayroll = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.lblGrossPayIndicator = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFICAIndicator = New System.Windows.Forms.Label()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblFederalIndicator = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateIndicator = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPayIndicator = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(1, 0)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(347, 216)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblPayroll
        '
        Me.lblPayroll.AutoSize = True
        Me.lblPayroll.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayroll.Location = New System.Drawing.Point(409, 20)
        Me.lblPayroll.Name = "lblPayroll"
        Me.lblPayroll.Size = New System.Drawing.Size(312, 36)
        Me.lblPayroll.TabIndex = 1
        Me.lblPayroll.Text = "Payroll Calculator"
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheck.Location = New System.Drawing.Point(487, 92)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(130, 27)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck"
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculator.Location = New System.Drawing.Point(478, 138)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(154, 27)
        Me.lblCalculator.TabIndex = 3
        Me.lblCalculator.Text = "Calculation"
        '
        'lblGrossPayIndicator
        '
        Me.lblGrossPayIndicator.AutoSize = True
        Me.lblGrossPayIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPayIndicator.Location = New System.Drawing.Point(214, 223)
        Me.lblGrossPayIndicator.Name = "lblGrossPayIndicator"
        Me.lblGrossPayIndicator.Size = New System.Drawing.Size(208, 29)
        Me.lblGrossPayIndicator.TabIndex = 4
        Me.lblGrossPayIndicator.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(432, 227)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 26)
        Me.txtGrossPay.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCompute.Location = New System.Drawing.Point(128, 268)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(150, 36)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Window
        Me.btnClear.Location = New System.Drawing.Point(325, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnExit.Location = New System.Drawing.Point(523, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFICAIndicator
        '
        Me.lblFICAIndicator.AutoSize = True
        Me.lblFICAIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICAIndicator.Location = New System.Drawing.Point(69, 325)
        Me.lblFICAIndicator.Name = "lblFICAIndicator"
        Me.lblFICAIndicator.Size = New System.Drawing.Size(69, 25)
        Me.lblFICAIndicator.TabIndex = 9
        Me.lblFICAIndicator.Text = "FICA:"
        '
        'lblFICATax
        '
        Me.lblFICATax.AutoSize = True
        Me.lblFICATax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(144, 325)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(66, 25)
        Me.lblFICATax.TabIndex = 10
        Me.lblFICATax.Text = "$0.00"
        '
        'lblFederalIndicator
        '
        Me.lblFederalIndicator.AutoSize = True
        Me.lblFederalIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalIndicator.Location = New System.Drawing.Point(259, 325)
        Me.lblFederalIndicator.Name = "lblFederalIndicator"
        Me.lblFederalIndicator.Size = New System.Drawing.Size(135, 25)
        Me.lblFederalIndicator.TabIndex = 11
        Me.lblFederalIndicator.Text = "Federal Tax:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(410, 325)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(66, 25)
        Me.lblFederalTax.TabIndex = 12
        Me.lblFederalTax.Text = "$0.00"
        '
        'lblStateIndicator
        '
        Me.lblStateIndicator.AutoSize = True
        Me.lblStateIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateIndicator.Location = New System.Drawing.Point(519, 325)
        Me.lblStateIndicator.Name = "lblStateIndicator"
        Me.lblStateIndicator.Size = New System.Drawing.Size(113, 25)
        Me.lblStateIndicator.TabIndex = 13
        Me.lblStateIndicator.Text = "State Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(638, 325)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(66, 25)
        Me.lblStateTax.TabIndex = 14
        Me.lblStateTax.Text = "$0.00"
        '
        'lblNetPayIndicator
        '
        Me.lblNetPayIndicator.AutoSize = True
        Me.lblNetPayIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayIndicator.Location = New System.Drawing.Point(185, 379)
        Me.lblNetPayIndicator.Name = "lblNetPayIndicator"
        Me.lblNetPayIndicator.Size = New System.Drawing.Size(271, 29)
        Me.lblNetPayIndicator.TabIndex = 15
        Me.lblNetPayIndicator.Text = "Net Paycheck Income:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(478, 379)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(76, 29)
        Me.lblNetPay.TabIndex = 16
        Me.lblNetPay.Text = "$0.00"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblNetPayIndicator)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblStateIndicator)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFederalIndicator)
        Me.Controls.Add(Me.lblFICATax)
        Me.Controls.Add(Me.lblFICAIndicator)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPayIndicator)
        Me.Controls.Add(Me.lblCalculator)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblPayroll)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblPayroll As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblGrossPayIndicator As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFICAIndicator As Label
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblFederalIndicator As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateIndicator As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPayIndicator As Label
    Friend WithEvents lblNetPay As Label
End Class
