<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFluxo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoOp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dtpLancamento = New System.Windows.Forms.DateTimePicker()
        Me.Groupbox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSaldoPrevisto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldoAtual = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvExtrato = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvLancamentosFuturos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Groupbox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvExtrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvLancamentosFuturos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipoOp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnIncluir)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.dtpLancamento)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lançamentos"
        '
        'cmbTipoOp
        '
        Me.cmbTipoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoOp.FormattingEnabled = True
        Me.cmbTipoOp.Items.AddRange(New Object() {"DEBITO", "CREDITO"})
        Me.cmbTipoOp.Location = New System.Drawing.Point(451, 20)
        Me.cmbTipoOp.Name = "cmbTipoOp"
        Me.cmbTipoOp.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoOp.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo OP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Data:"
        '
        'btnIncluir
        '
        Me.btnIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncluir.Location = New System.Drawing.Point(451, 91)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(121, 23)
        Me.btnIncluir.TabIndex = 5
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(451, 59)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(121, 20)
        Me.txtValor.TabIndex = 4
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(127, 63)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(136, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'dtpLancamento
        '
        Me.dtpLancamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLancamento.Location = New System.Drawing.Point(127, 22)
        Me.dtpLancamento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpLancamento.Name = "dtpLancamento"
        Me.dtpLancamento.Size = New System.Drawing.Size(136, 20)
        Me.dtpLancamento.TabIndex = 1
        '
        'Groupbox2
        '
        Me.Groupbox2.Controls.Add(Me.Label6)
        Me.Groupbox2.Controls.Add(Me.lblSaldoPrevisto)
        Me.Groupbox2.Controls.Add(Me.Label5)
        Me.Groupbox2.Controls.Add(Me.lblSaldoAtual)
        Me.Groupbox2.Location = New System.Drawing.Point(661, 25)
        Me.Groupbox2.Name = "Groupbox2"
        Me.Groupbox2.Size = New System.Drawing.Size(499, 125)
        Me.Groupbox2.TabIndex = 1
        Me.Groupbox2.TabStop = False
        Me.Groupbox2.Text = "Saldo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Saldo Previsto: "
        '
        'lblSaldoPrevisto
        '
        Me.lblSaldoPrevisto.AutoSize = True
        Me.lblSaldoPrevisto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPrevisto.Location = New System.Drawing.Point(131, 59)
        Me.lblSaldoPrevisto.Name = "lblSaldoPrevisto"
        Me.lblSaldoPrevisto.Size = New System.Drawing.Size(94, 24)
        Me.lblSaldoPrevisto.TabIndex = 2
        Me.lblSaldoPrevisto.Text = "Previsto"
        Me.lblSaldoPrevisto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Saldo Atual:"
        '
        'lblSaldoAtual
        '
        Me.lblSaldoAtual.AutoSize = True
        Me.lblSaldoAtual.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAtual.Location = New System.Drawing.Point(131, 21)
        Me.lblSaldoAtual.Name = "lblSaldoAtual"
        Me.lblSaldoAtual.Size = New System.Drawing.Size(67, 24)
        Me.lblSaldoAtual.TabIndex = 0
        Me.lblSaldoAtual.Text = "Saldo"
        Me.lblSaldoAtual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvExtrato)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 156)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 393)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extratos"
        '
        'dgvExtrato
        '
        Me.dgvExtrato.AllowUserToAddRows = False
        Me.dgvExtrato.AllowUserToDeleteRows = False
        Me.dgvExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExtrato.Location = New System.Drawing.Point(14, 16)
        Me.dgvExtrato.Name = "dgvExtrato"
        Me.dgvExtrato.ReadOnly = True
        Me.dgvExtrato.Size = New System.Drawing.Size(582, 368)
        Me.dgvExtrato.TabIndex = 11
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvLancamentosFuturos)
        Me.GroupBox4.Location = New System.Drawing.Point(661, 156)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(499, 393)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lançamentos Futuros"
        '
        'dgvLancamentosFuturos
        '
        Me.dgvLancamentosFuturos.AllowUserToAddRows = False
        Me.dgvLancamentosFuturos.AllowUserToDeleteRows = False
        Me.dgvLancamentosFuturos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLancamentosFuturos.Location = New System.Drawing.Point(10, 19)
        Me.dgvLancamentosFuturos.Name = "dgvLancamentosFuturos"
        Me.dgvLancamentosFuturos.ReadOnly = True
        Me.dgvLancamentosFuturos.Size = New System.Drawing.Size(483, 365)
        Me.dgvLancamentosFuturos.TabIndex = 12
        '
        'FrmFluxo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Groupbox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFluxo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fluxo de Caixa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Groupbox2.ResumeLayout(False)
        Me.Groupbox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvExtrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvLancamentosFuturos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents dtpLancamento As DateTimePicker
    Friend WithEvents Groupbox2 As GroupBox
    Friend WithEvents lblSaldoAtual As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvExtrato As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvLancamentosFuturos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoOp As ComboBox
    Friend WithEvents lblSaldoPrevisto As Label
    Friend WithEvents Label6 As Label
End Class
