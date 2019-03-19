Imports IEC61850.Client
Imports IEC61850.Common
Imports Microsoft.Office.Interop


Partial Class frmSWITCHERA
    Inherits System.Windows.Forms.Form
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Dim CICLO As Integer = 0

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSWITCHERA))
        Me.cmdED1_2 = New System.Windows.Forms.Button()
        Me.cmdED1_4 = New System.Windows.Forms.Button()
        Me.cmdED1_3 = New System.Windows.Forms.Button()
        Me.cmdED1_8 = New System.Windows.Forms.Button()
        Me.cmdED1_7 = New System.Windows.Forms.Button()
        Me.cmdED1_6 = New System.Windows.Forms.Button()
        Me.cmdED1_5 = New System.Windows.Forms.Button()
        Me.cmdED1_9 = New System.Windows.Forms.Button()
        Me.cmdED1_10 = New System.Windows.Forms.Button()
        Me.cmdED1_11 = New System.Windows.Forms.Button()
        Me.cmdED1_12 = New System.Windows.Forms.Button()
        Me.cmdED1_13 = New System.Windows.Forms.Button()
        Me.cmdED1_14 = New System.Windows.Forms.Button()
        Me.cmdED1_15 = New System.Windows.Forms.Button()
        Me.cmdED1_16 = New System.Windows.Forms.Button()
        Me.cmdED1_17 = New System.Windows.Forms.Button()
        Me.cmdED1_25 = New System.Windows.Forms.Button()
        Me.cmdED1_18 = New System.Windows.Forms.Button()
        Me.cmdED1_26 = New System.Windows.Forms.Button()
        Me.cmdED1_19 = New System.Windows.Forms.Button()
        Me.cmdED1_27 = New System.Windows.Forms.Button()
        Me.cmdED1_20 = New System.Windows.Forms.Button()
        Me.cmdED1_28 = New System.Windows.Forms.Button()
        Me.cmdED1_21 = New System.Windows.Forms.Button()
        Me.cmdED1_29 = New System.Windows.Forms.Button()
        Me.cmdED1_22 = New System.Windows.Forms.Button()
        Me.cmdED1_30 = New System.Windows.Forms.Button()
        Me.cmdED1_23 = New System.Windows.Forms.Button()
        Me.cmdED1_31 = New System.Windows.Forms.Button()
        Me.cmdED1_24 = New System.Windows.Forms.Button()
        Me.cmdED1_32 = New System.Windows.Forms.Button()
        Me.tbIED = New System.Windows.Forms.TextBox()
        Me.gb61850 = New System.Windows.Forms.GroupBox()
        Me.tbRutaExcel = New System.Windows.Forms.TextBox()
        Me.cmdED2_32 = New System.Windows.Forms.Button()
        Me.cmdED2_24 = New System.Windows.Forms.Button()
        Me.cmdED2_16 = New System.Windows.Forms.Button()
        Me.cmdED2_31 = New System.Windows.Forms.Button()
        Me.cmdED2_8 = New System.Windows.Forms.Button()
        Me.cmdED2_23 = New System.Windows.Forms.Button()
        Me.cmdED2_15 = New System.Windows.Forms.Button()
        Me.cmdED2_30 = New System.Windows.Forms.Button()
        Me.cmdED2_7 = New System.Windows.Forms.Button()
        Me.cmdED2_22 = New System.Windows.Forms.Button()
        Me.cmdED2_14 = New System.Windows.Forms.Button()
        Me.cmdED2_29 = New System.Windows.Forms.Button()
        Me.cmdED2_6 = New System.Windows.Forms.Button()
        Me.cmdED2_21 = New System.Windows.Forms.Button()
        Me.cmdED2_13 = New System.Windows.Forms.Button()
        Me.cmdED2_28 = New System.Windows.Forms.Button()
        Me.cmdED2_5 = New System.Windows.Forms.Button()
        Me.cmdED2_20 = New System.Windows.Forms.Button()
        Me.cmdED2_12 = New System.Windows.Forms.Button()
        Me.cmdED2_27 = New System.Windows.Forms.Button()
        Me.cmdED2_4 = New System.Windows.Forms.Button()
        Me.cmdED2_19 = New System.Windows.Forms.Button()
        Me.cmdED2_11 = New System.Windows.Forms.Button()
        Me.cmdED2_26 = New System.Windows.Forms.Button()
        Me.cmdED2_3 = New System.Windows.Forms.Button()
        Me.cmdED2_18 = New System.Windows.Forms.Button()
        Me.cmdED2_10 = New System.Windows.Forms.Button()
        Me.cmdED2_25 = New System.Windows.Forms.Button()
        Me.cmdED2_2 = New System.Windows.Forms.Button()
        Me.cmdED2_17 = New System.Windows.Forms.Button()
        Me.cmdED2_9 = New System.Windows.Forms.Button()
        Me.cmdED2_1 = New System.Windows.Forms.Button()
        Me.lbT1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPestanas = New System.Windows.Forms.ComboBox()
        Me.tbCODCOM = New System.Windows.Forms.TextBox()
        Me.cmdBrowser = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbSTATUS = New System.Windows.Forms.TextBox()
        Me.cmdDESCONECTAR = New System.Windows.Forms.Button()
        Me.cmdCONECTAR = New System.Windows.Forms.Button()
        Me.tbIP = New System.Windows.Forms.TextBox()
        Me.cmdDEFAULT = New System.Windows.Forms.Button()
        Me.cmdED1_1 = New System.Windows.Forms.Button()
        Me.gbIO = New System.Windows.Forms.GroupBox()
        Me.tbSD7_16 = New System.Windows.Forms.TextBox()
        Me.tbSD7_15 = New System.Windows.Forms.TextBox()
        Me.tbSD7_14 = New System.Windows.Forms.TextBox()
        Me.tbSD7_13 = New System.Windows.Forms.TextBox()
        Me.tbSD7_12 = New System.Windows.Forms.TextBox()
        Me.tbSD7_11 = New System.Windows.Forms.TextBox()
        Me.tbSD7_10 = New System.Windows.Forms.TextBox()
        Me.tbSD7_9 = New System.Windows.Forms.TextBox()
        Me.tbSD7_8 = New System.Windows.Forms.TextBox()
        Me.tbSD7_7 = New System.Windows.Forms.TextBox()
        Me.tbSD7_6 = New System.Windows.Forms.TextBox()
        Me.tbSD7_5 = New System.Windows.Forms.TextBox()
        Me.tbSD7_4 = New System.Windows.Forms.TextBox()
        Me.tbSD7_3 = New System.Windows.Forms.TextBox()
        Me.tbSD7_2 = New System.Windows.Forms.TextBox()
        Me.tbSD7_1 = New System.Windows.Forms.TextBox()
        Me.lbED7_32 = New System.Windows.Forms.Label()
        Me.lbED7_31 = New System.Windows.Forms.Label()
        Me.lbED7_16 = New System.Windows.Forms.Label()
        Me.lbED7_24 = New System.Windows.Forms.Label()
        Me.lbED7_15 = New System.Windows.Forms.Label()
        Me.lbED7_28 = New System.Windows.Forms.Label()
        Me.lbED7_8 = New System.Windows.Forms.Label()
        Me.lbED7_23 = New System.Windows.Forms.Label()
        Me.lbED7_12 = New System.Windows.Forms.Label()
        Me.lbED7_30 = New System.Windows.Forms.Label()
        Me.lbED7_7 = New System.Windows.Forms.Label()
        Me.lbED7_20 = New System.Windows.Forms.Label()
        Me.lbED7_14 = New System.Windows.Forms.Label()
        Me.lbED7_27 = New System.Windows.Forms.Label()
        Me.lbED7_4 = New System.Windows.Forms.Label()
        Me.lbED7_22 = New System.Windows.Forms.Label()
        Me.lbED7_11 = New System.Windows.Forms.Label()
        Me.lbED7_29 = New System.Windows.Forms.Label()
        Me.lbED7_6 = New System.Windows.Forms.Label()
        Me.lbED7_19 = New System.Windows.Forms.Label()
        Me.lbED7_13 = New System.Windows.Forms.Label()
        Me.lbED7_26 = New System.Windows.Forms.Label()
        Me.lbED7_3 = New System.Windows.Forms.Label()
        Me.lbED7_21 = New System.Windows.Forms.Label()
        Me.lbED7_10 = New System.Windows.Forms.Label()
        Me.lbED7_25 = New System.Windows.Forms.Label()
        Me.lbED7_5 = New System.Windows.Forms.Label()
        Me.lbED7_18 = New System.Windows.Forms.Label()
        Me.lbED7_9 = New System.Windows.Forms.Label()
        Me.lbED7_17 = New System.Windows.Forms.Label()
        Me.lbED7_2 = New System.Windows.Forms.Label()
        Me.lbED7_1 = New System.Windows.Forms.Label()
        Me.cmdED7_32 = New System.Windows.Forms.Button()
        Me.cmdED7_24 = New System.Windows.Forms.Button()
        Me.cmdED7_16 = New System.Windows.Forms.Button()
        Me.cmdED7_31 = New System.Windows.Forms.Button()
        Me.cmdED7_8 = New System.Windows.Forms.Button()
        Me.cmdED7_23 = New System.Windows.Forms.Button()
        Me.cmdED7_15 = New System.Windows.Forms.Button()
        Me.cmdED7_30 = New System.Windows.Forms.Button()
        Me.cmdED7_7 = New System.Windows.Forms.Button()
        Me.cmdED7_22 = New System.Windows.Forms.Button()
        Me.cmdED7_14 = New System.Windows.Forms.Button()
        Me.cmdED7_29 = New System.Windows.Forms.Button()
        Me.cmdED7_6 = New System.Windows.Forms.Button()
        Me.cmdED7_21 = New System.Windows.Forms.Button()
        Me.cmdED7_13 = New System.Windows.Forms.Button()
        Me.cmdED7_28 = New System.Windows.Forms.Button()
        Me.cmdED7_5 = New System.Windows.Forms.Button()
        Me.cmdED7_20 = New System.Windows.Forms.Button()
        Me.cmdED7_12 = New System.Windows.Forms.Button()
        Me.cmdED7_27 = New System.Windows.Forms.Button()
        Me.cmdED7_4 = New System.Windows.Forms.Button()
        Me.cmdED7_19 = New System.Windows.Forms.Button()
        Me.cmdED7_11 = New System.Windows.Forms.Button()
        Me.cmdED7_26 = New System.Windows.Forms.Button()
        Me.cmdED7_3 = New System.Windows.Forms.Button()
        Me.cmdED7_18 = New System.Windows.Forms.Button()
        Me.cmdED7_10 = New System.Windows.Forms.Button()
        Me.cmdED7_25 = New System.Windows.Forms.Button()
        Me.cmdED7_2 = New System.Windows.Forms.Button()
        Me.cmdED7_17 = New System.Windows.Forms.Button()
        Me.cmdED7_9 = New System.Windows.Forms.Button()
        Me.cmdED7_1 = New System.Windows.Forms.Button()
        Me.tbSD6_16 = New System.Windows.Forms.TextBox()
        Me.tbSD6_15 = New System.Windows.Forms.TextBox()
        Me.tbSD6_14 = New System.Windows.Forms.TextBox()
        Me.tbSD6_13 = New System.Windows.Forms.TextBox()
        Me.tbSD6_12 = New System.Windows.Forms.TextBox()
        Me.tbSD6_11 = New System.Windows.Forms.TextBox()
        Me.tbSD6_10 = New System.Windows.Forms.TextBox()
        Me.tbSD6_9 = New System.Windows.Forms.TextBox()
        Me.tbSD6_8 = New System.Windows.Forms.TextBox()
        Me.tbSD6_7 = New System.Windows.Forms.TextBox()
        Me.tbSD6_6 = New System.Windows.Forms.TextBox()
        Me.tbSD6_5 = New System.Windows.Forms.TextBox()
        Me.tbSD6_4 = New System.Windows.Forms.TextBox()
        Me.tbSD6_3 = New System.Windows.Forms.TextBox()
        Me.tbSD6_2 = New System.Windows.Forms.TextBox()
        Me.tbSD6_1 = New System.Windows.Forms.TextBox()
        Me.lbED6_32 = New System.Windows.Forms.Label()
        Me.lbED6_31 = New System.Windows.Forms.Label()
        Me.lbED6_16 = New System.Windows.Forms.Label()
        Me.lbED6_24 = New System.Windows.Forms.Label()
        Me.lbED6_15 = New System.Windows.Forms.Label()
        Me.lbED6_28 = New System.Windows.Forms.Label()
        Me.lbED6_8 = New System.Windows.Forms.Label()
        Me.lbED6_23 = New System.Windows.Forms.Label()
        Me.lbED6_12 = New System.Windows.Forms.Label()
        Me.lbED6_30 = New System.Windows.Forms.Label()
        Me.lbED6_7 = New System.Windows.Forms.Label()
        Me.lbED6_20 = New System.Windows.Forms.Label()
        Me.lbED6_14 = New System.Windows.Forms.Label()
        Me.lbED6_27 = New System.Windows.Forms.Label()
        Me.lbED6_4 = New System.Windows.Forms.Label()
        Me.lbED6_22 = New System.Windows.Forms.Label()
        Me.lbED6_11 = New System.Windows.Forms.Label()
        Me.lbED6_29 = New System.Windows.Forms.Label()
        Me.lbED6_6 = New System.Windows.Forms.Label()
        Me.lbED6_19 = New System.Windows.Forms.Label()
        Me.lbED6_13 = New System.Windows.Forms.Label()
        Me.lbED6_26 = New System.Windows.Forms.Label()
        Me.lbED6_3 = New System.Windows.Forms.Label()
        Me.lbED6_21 = New System.Windows.Forms.Label()
        Me.lbED6_10 = New System.Windows.Forms.Label()
        Me.lbED6_25 = New System.Windows.Forms.Label()
        Me.lbED6_5 = New System.Windows.Forms.Label()
        Me.lbED6_18 = New System.Windows.Forms.Label()
        Me.lbED6_9 = New System.Windows.Forms.Label()
        Me.lbED6_17 = New System.Windows.Forms.Label()
        Me.lbED6_2 = New System.Windows.Forms.Label()
        Me.lbED6_1 = New System.Windows.Forms.Label()
        Me.cmdED6_32 = New System.Windows.Forms.Button()
        Me.cmdED6_24 = New System.Windows.Forms.Button()
        Me.cmdED6_16 = New System.Windows.Forms.Button()
        Me.cmdED6_31 = New System.Windows.Forms.Button()
        Me.cmdED6_8 = New System.Windows.Forms.Button()
        Me.cmdED6_23 = New System.Windows.Forms.Button()
        Me.cmdED6_15 = New System.Windows.Forms.Button()
        Me.cmdED6_30 = New System.Windows.Forms.Button()
        Me.cmdED6_7 = New System.Windows.Forms.Button()
        Me.cmdED6_22 = New System.Windows.Forms.Button()
        Me.cmdED6_14 = New System.Windows.Forms.Button()
        Me.cmdED6_29 = New System.Windows.Forms.Button()
        Me.cmdED6_6 = New System.Windows.Forms.Button()
        Me.cmdED6_21 = New System.Windows.Forms.Button()
        Me.cmdED6_13 = New System.Windows.Forms.Button()
        Me.cmdED6_28 = New System.Windows.Forms.Button()
        Me.cmdED6_5 = New System.Windows.Forms.Button()
        Me.cmdED6_20 = New System.Windows.Forms.Button()
        Me.cmdED6_12 = New System.Windows.Forms.Button()
        Me.cmdED6_27 = New System.Windows.Forms.Button()
        Me.cmdED6_4 = New System.Windows.Forms.Button()
        Me.cmdED6_19 = New System.Windows.Forms.Button()
        Me.cmdED6_11 = New System.Windows.Forms.Button()
        Me.cmdED6_26 = New System.Windows.Forms.Button()
        Me.cmdED6_3 = New System.Windows.Forms.Button()
        Me.cmdED6_18 = New System.Windows.Forms.Button()
        Me.cmdED6_10 = New System.Windows.Forms.Button()
        Me.cmdED6_25 = New System.Windows.Forms.Button()
        Me.cmdED6_2 = New System.Windows.Forms.Button()
        Me.cmdED6_17 = New System.Windows.Forms.Button()
        Me.cmdED6_9 = New System.Windows.Forms.Button()
        Me.cmdED6_1 = New System.Windows.Forms.Button()
        Me.tbSD5_16 = New System.Windows.Forms.TextBox()
        Me.tbSD5_15 = New System.Windows.Forms.TextBox()
        Me.tbSD5_14 = New System.Windows.Forms.TextBox()
        Me.tbSD5_13 = New System.Windows.Forms.TextBox()
        Me.tbSD5_12 = New System.Windows.Forms.TextBox()
        Me.tbSD5_11 = New System.Windows.Forms.TextBox()
        Me.tbSD5_10 = New System.Windows.Forms.TextBox()
        Me.tbSD5_9 = New System.Windows.Forms.TextBox()
        Me.tbSD5_8 = New System.Windows.Forms.TextBox()
        Me.tbSD5_7 = New System.Windows.Forms.TextBox()
        Me.tbSD5_6 = New System.Windows.Forms.TextBox()
        Me.tbSD5_5 = New System.Windows.Forms.TextBox()
        Me.tbSD5_4 = New System.Windows.Forms.TextBox()
        Me.tbSD5_3 = New System.Windows.Forms.TextBox()
        Me.tbSD5_2 = New System.Windows.Forms.TextBox()
        Me.tbSD5_1 = New System.Windows.Forms.TextBox()
        Me.lbED5_32 = New System.Windows.Forms.Label()
        Me.lbED5_31 = New System.Windows.Forms.Label()
        Me.lbED5_16 = New System.Windows.Forms.Label()
        Me.lbED5_24 = New System.Windows.Forms.Label()
        Me.lbED5_15 = New System.Windows.Forms.Label()
        Me.lbED5_28 = New System.Windows.Forms.Label()
        Me.lbED5_8 = New System.Windows.Forms.Label()
        Me.lbED5_23 = New System.Windows.Forms.Label()
        Me.lbED5_12 = New System.Windows.Forms.Label()
        Me.lbED5_30 = New System.Windows.Forms.Label()
        Me.lbED5_7 = New System.Windows.Forms.Label()
        Me.lbED5_20 = New System.Windows.Forms.Label()
        Me.lbED5_14 = New System.Windows.Forms.Label()
        Me.lbED5_27 = New System.Windows.Forms.Label()
        Me.lbED5_4 = New System.Windows.Forms.Label()
        Me.lbED5_22 = New System.Windows.Forms.Label()
        Me.lbED5_11 = New System.Windows.Forms.Label()
        Me.lbED5_29 = New System.Windows.Forms.Label()
        Me.lbED5_6 = New System.Windows.Forms.Label()
        Me.lbED5_19 = New System.Windows.Forms.Label()
        Me.lbED5_13 = New System.Windows.Forms.Label()
        Me.lbED5_26 = New System.Windows.Forms.Label()
        Me.lbED5_3 = New System.Windows.Forms.Label()
        Me.lbED5_21 = New System.Windows.Forms.Label()
        Me.lbED5_10 = New System.Windows.Forms.Label()
        Me.lbED5_25 = New System.Windows.Forms.Label()
        Me.lbED5_5 = New System.Windows.Forms.Label()
        Me.lbED5_18 = New System.Windows.Forms.Label()
        Me.lbED5_9 = New System.Windows.Forms.Label()
        Me.lbED5_17 = New System.Windows.Forms.Label()
        Me.lbED5_2 = New System.Windows.Forms.Label()
        Me.lbED5_1 = New System.Windows.Forms.Label()
        Me.cmdED5_1 = New System.Windows.Forms.Button()
        Me.cmdED5_9 = New System.Windows.Forms.Button()
        Me.cmdED5_17 = New System.Windows.Forms.Button()
        Me.cmdED5_2 = New System.Windows.Forms.Button()
        Me.cmdED5_25 = New System.Windows.Forms.Button()
        Me.cmdED5_10 = New System.Windows.Forms.Button()
        Me.cmdED5_18 = New System.Windows.Forms.Button()
        Me.cmdED5_3 = New System.Windows.Forms.Button()
        Me.cmdED5_26 = New System.Windows.Forms.Button()
        Me.cmdED5_11 = New System.Windows.Forms.Button()
        Me.cmdED5_19 = New System.Windows.Forms.Button()
        Me.cmdED5_32 = New System.Windows.Forms.Button()
        Me.cmdED5_24 = New System.Windows.Forms.Button()
        Me.cmdED5_4 = New System.Windows.Forms.Button()
        Me.cmdED5_27 = New System.Windows.Forms.Button()
        Me.cmdED5_16 = New System.Windows.Forms.Button()
        Me.cmdED5_12 = New System.Windows.Forms.Button()
        Me.cmdED5_31 = New System.Windows.Forms.Button()
        Me.cmdED5_20 = New System.Windows.Forms.Button()
        Me.cmdED5_8 = New System.Windows.Forms.Button()
        Me.cmdED5_5 = New System.Windows.Forms.Button()
        Me.cmdED5_23 = New System.Windows.Forms.Button()
        Me.cmdED5_28 = New System.Windows.Forms.Button()
        Me.cmdED5_15 = New System.Windows.Forms.Button()
        Me.cmdED5_13 = New System.Windows.Forms.Button()
        Me.cmdED5_30 = New System.Windows.Forms.Button()
        Me.cmdED5_21 = New System.Windows.Forms.Button()
        Me.cmdED5_7 = New System.Windows.Forms.Button()
        Me.cmdED5_6 = New System.Windows.Forms.Button()
        Me.cmdED5_22 = New System.Windows.Forms.Button()
        Me.cmdED5_29 = New System.Windows.Forms.Button()
        Me.cmdED5_14 = New System.Windows.Forms.Button()
        Me.tbSD4_16 = New System.Windows.Forms.TextBox()
        Me.tbSD4_15 = New System.Windows.Forms.TextBox()
        Me.tbSD4_14 = New System.Windows.Forms.TextBox()
        Me.tbSD4_13 = New System.Windows.Forms.TextBox()
        Me.tbSD4_12 = New System.Windows.Forms.TextBox()
        Me.tbSD4_11 = New System.Windows.Forms.TextBox()
        Me.tbSD4_10 = New System.Windows.Forms.TextBox()
        Me.tbSD4_9 = New System.Windows.Forms.TextBox()
        Me.tbSD4_8 = New System.Windows.Forms.TextBox()
        Me.tbSD4_7 = New System.Windows.Forms.TextBox()
        Me.tbSD4_6 = New System.Windows.Forms.TextBox()
        Me.tbSD4_5 = New System.Windows.Forms.TextBox()
        Me.tbSD4_4 = New System.Windows.Forms.TextBox()
        Me.tbSD4_3 = New System.Windows.Forms.TextBox()
        Me.tbSD4_2 = New System.Windows.Forms.TextBox()
        Me.tbSD4_1 = New System.Windows.Forms.TextBox()
        Me.lbED4_32 = New System.Windows.Forms.Label()
        Me.lbED4_31 = New System.Windows.Forms.Label()
        Me.lbED4_16 = New System.Windows.Forms.Label()
        Me.lbED4_24 = New System.Windows.Forms.Label()
        Me.lbED4_15 = New System.Windows.Forms.Label()
        Me.lbED4_28 = New System.Windows.Forms.Label()
        Me.lbED4_8 = New System.Windows.Forms.Label()
        Me.lbED4_23 = New System.Windows.Forms.Label()
        Me.lbED4_12 = New System.Windows.Forms.Label()
        Me.lbED4_30 = New System.Windows.Forms.Label()
        Me.lbED4_7 = New System.Windows.Forms.Label()
        Me.lbED4_20 = New System.Windows.Forms.Label()
        Me.lbED4_14 = New System.Windows.Forms.Label()
        Me.lbED4_27 = New System.Windows.Forms.Label()
        Me.lbED4_4 = New System.Windows.Forms.Label()
        Me.lbED4_22 = New System.Windows.Forms.Label()
        Me.lbED4_11 = New System.Windows.Forms.Label()
        Me.lbED4_29 = New System.Windows.Forms.Label()
        Me.lbED4_6 = New System.Windows.Forms.Label()
        Me.lbED4_19 = New System.Windows.Forms.Label()
        Me.lbED4_13 = New System.Windows.Forms.Label()
        Me.lbED4_26 = New System.Windows.Forms.Label()
        Me.lbED4_3 = New System.Windows.Forms.Label()
        Me.lbED4_21 = New System.Windows.Forms.Label()
        Me.lbED4_10 = New System.Windows.Forms.Label()
        Me.lbED4_25 = New System.Windows.Forms.Label()
        Me.lbED4_5 = New System.Windows.Forms.Label()
        Me.lbED4_18 = New System.Windows.Forms.Label()
        Me.lbED4_9 = New System.Windows.Forms.Label()
        Me.lbED4_17 = New System.Windows.Forms.Label()
        Me.lbED4_2 = New System.Windows.Forms.Label()
        Me.lbED4_1 = New System.Windows.Forms.Label()
        Me.cmdED4_1 = New System.Windows.Forms.Button()
        Me.cmdED4_9 = New System.Windows.Forms.Button()
        Me.cmdED4_17 = New System.Windows.Forms.Button()
        Me.cmdED4_2 = New System.Windows.Forms.Button()
        Me.cmdED4_25 = New System.Windows.Forms.Button()
        Me.cmdED4_10 = New System.Windows.Forms.Button()
        Me.cmdED4_18 = New System.Windows.Forms.Button()
        Me.cmdED4_3 = New System.Windows.Forms.Button()
        Me.cmdED4_26 = New System.Windows.Forms.Button()
        Me.cmdED4_11 = New System.Windows.Forms.Button()
        Me.cmdED4_19 = New System.Windows.Forms.Button()
        Me.cmdED4_32 = New System.Windows.Forms.Button()
        Me.cmdED4_4 = New System.Windows.Forms.Button()
        Me.cmdED4_24 = New System.Windows.Forms.Button()
        Me.cmdED4_27 = New System.Windows.Forms.Button()
        Me.cmdED4_16 = New System.Windows.Forms.Button()
        Me.cmdED4_12 = New System.Windows.Forms.Button()
        Me.cmdED4_31 = New System.Windows.Forms.Button()
        Me.cmdED4_20 = New System.Windows.Forms.Button()
        Me.cmdED4_8 = New System.Windows.Forms.Button()
        Me.cmdED4_5 = New System.Windows.Forms.Button()
        Me.cmdED4_23 = New System.Windows.Forms.Button()
        Me.cmdED4_28 = New System.Windows.Forms.Button()
        Me.cmdED4_15 = New System.Windows.Forms.Button()
        Me.cmdED4_13 = New System.Windows.Forms.Button()
        Me.cmdED4_30 = New System.Windows.Forms.Button()
        Me.cmdED4_21 = New System.Windows.Forms.Button()
        Me.cmdED4_7 = New System.Windows.Forms.Button()
        Me.cmdED4_6 = New System.Windows.Forms.Button()
        Me.cmdED4_22 = New System.Windows.Forms.Button()
        Me.cmdED4_29 = New System.Windows.Forms.Button()
        Me.cmdED4_14 = New System.Windows.Forms.Button()
        Me.tbSD3_16 = New System.Windows.Forms.TextBox()
        Me.tbSD3_15 = New System.Windows.Forms.TextBox()
        Me.tbSD3_14 = New System.Windows.Forms.TextBox()
        Me.tbSD3_13 = New System.Windows.Forms.TextBox()
        Me.tbSD3_12 = New System.Windows.Forms.TextBox()
        Me.tbSD3_11 = New System.Windows.Forms.TextBox()
        Me.tbSD3_10 = New System.Windows.Forms.TextBox()
        Me.tbSD3_9 = New System.Windows.Forms.TextBox()
        Me.tbSD3_8 = New System.Windows.Forms.TextBox()
        Me.tbSD3_7 = New System.Windows.Forms.TextBox()
        Me.tbSD3_6 = New System.Windows.Forms.TextBox()
        Me.tbSD3_5 = New System.Windows.Forms.TextBox()
        Me.tbSD3_4 = New System.Windows.Forms.TextBox()
        Me.tbSD3_3 = New System.Windows.Forms.TextBox()
        Me.tbSD3_2 = New System.Windows.Forms.TextBox()
        Me.tbSD3_1 = New System.Windows.Forms.TextBox()
        Me.lbED3_32 = New System.Windows.Forms.Label()
        Me.lbED3_31 = New System.Windows.Forms.Label()
        Me.lbED3_16 = New System.Windows.Forms.Label()
        Me.lbED3_24 = New System.Windows.Forms.Label()
        Me.lbED3_15 = New System.Windows.Forms.Label()
        Me.lbED3_28 = New System.Windows.Forms.Label()
        Me.lbED3_8 = New System.Windows.Forms.Label()
        Me.lbED3_23 = New System.Windows.Forms.Label()
        Me.lbED3_12 = New System.Windows.Forms.Label()
        Me.lbED3_30 = New System.Windows.Forms.Label()
        Me.lbED3_7 = New System.Windows.Forms.Label()
        Me.lbED3_20 = New System.Windows.Forms.Label()
        Me.lbED3_14 = New System.Windows.Forms.Label()
        Me.lbED3_27 = New System.Windows.Forms.Label()
        Me.lbED3_4 = New System.Windows.Forms.Label()
        Me.lbED3_22 = New System.Windows.Forms.Label()
        Me.lbED3_11 = New System.Windows.Forms.Label()
        Me.lbED3_29 = New System.Windows.Forms.Label()
        Me.lbED3_6 = New System.Windows.Forms.Label()
        Me.lbED3_19 = New System.Windows.Forms.Label()
        Me.lbED3_13 = New System.Windows.Forms.Label()
        Me.lbED3_26 = New System.Windows.Forms.Label()
        Me.lbED3_3 = New System.Windows.Forms.Label()
        Me.lbED3_21 = New System.Windows.Forms.Label()
        Me.lbED3_10 = New System.Windows.Forms.Label()
        Me.lbED3_25 = New System.Windows.Forms.Label()
        Me.lbED3_5 = New System.Windows.Forms.Label()
        Me.lbED3_18 = New System.Windows.Forms.Label()
        Me.lbED3_9 = New System.Windows.Forms.Label()
        Me.lbED3_17 = New System.Windows.Forms.Label()
        Me.lbED3_2 = New System.Windows.Forms.Label()
        Me.lbED3_1 = New System.Windows.Forms.Label()
        Me.cmdED3_1 = New System.Windows.Forms.Button()
        Me.cmdED3_9 = New System.Windows.Forms.Button()
        Me.cmdED3_17 = New System.Windows.Forms.Button()
        Me.cmdED3_2 = New System.Windows.Forms.Button()
        Me.cmdED3_25 = New System.Windows.Forms.Button()
        Me.cmdED3_10 = New System.Windows.Forms.Button()
        Me.cmdED3_18 = New System.Windows.Forms.Button()
        Me.cmdED3_3 = New System.Windows.Forms.Button()
        Me.cmdED3_26 = New System.Windows.Forms.Button()
        Me.cmdED3_11 = New System.Windows.Forms.Button()
        Me.cmdED3_19 = New System.Windows.Forms.Button()
        Me.cmdED3_4 = New System.Windows.Forms.Button()
        Me.cmdED3_32 = New System.Windows.Forms.Button()
        Me.cmdED3_27 = New System.Windows.Forms.Button()
        Me.cmdED3_24 = New System.Windows.Forms.Button()
        Me.cmdED3_12 = New System.Windows.Forms.Button()
        Me.cmdED3_16 = New System.Windows.Forms.Button()
        Me.cmdED3_20 = New System.Windows.Forms.Button()
        Me.cmdED3_31 = New System.Windows.Forms.Button()
        Me.cmdED3_5 = New System.Windows.Forms.Button()
        Me.cmdED3_8 = New System.Windows.Forms.Button()
        Me.cmdED3_28 = New System.Windows.Forms.Button()
        Me.cmdED3_23 = New System.Windows.Forms.Button()
        Me.cmdED3_13 = New System.Windows.Forms.Button()
        Me.cmdED3_15 = New System.Windows.Forms.Button()
        Me.cmdED3_21 = New System.Windows.Forms.Button()
        Me.cmdED3_30 = New System.Windows.Forms.Button()
        Me.cmdED3_6 = New System.Windows.Forms.Button()
        Me.cmdED3_7 = New System.Windows.Forms.Button()
        Me.cmdED3_29 = New System.Windows.Forms.Button()
        Me.cmdED3_22 = New System.Windows.Forms.Button()
        Me.cmdED3_14 = New System.Windows.Forms.Button()
        Me.tbSD2_16 = New System.Windows.Forms.TextBox()
        Me.tbSD2_15 = New System.Windows.Forms.TextBox()
        Me.tbSD2_14 = New System.Windows.Forms.TextBox()
        Me.tbSD2_13 = New System.Windows.Forms.TextBox()
        Me.tbSD2_12 = New System.Windows.Forms.TextBox()
        Me.tbSD2_11 = New System.Windows.Forms.TextBox()
        Me.tbSD2_10 = New System.Windows.Forms.TextBox()
        Me.tbSD2_9 = New System.Windows.Forms.TextBox()
        Me.tbSD2_8 = New System.Windows.Forms.TextBox()
        Me.tbSD2_7 = New System.Windows.Forms.TextBox()
        Me.tbSD2_6 = New System.Windows.Forms.TextBox()
        Me.tbSD2_5 = New System.Windows.Forms.TextBox()
        Me.tbSD2_4 = New System.Windows.Forms.TextBox()
        Me.tbSD2_3 = New System.Windows.Forms.TextBox()
        Me.tbSD2_2 = New System.Windows.Forms.TextBox()
        Me.tbSD2_1 = New System.Windows.Forms.TextBox()
        Me.lbED2_32 = New System.Windows.Forms.Label()
        Me.lbED2_31 = New System.Windows.Forms.Label()
        Me.lbED2_16 = New System.Windows.Forms.Label()
        Me.lbED2_24 = New System.Windows.Forms.Label()
        Me.lbED2_15 = New System.Windows.Forms.Label()
        Me.lbED2_28 = New System.Windows.Forms.Label()
        Me.lbED2_8 = New System.Windows.Forms.Label()
        Me.lbED2_23 = New System.Windows.Forms.Label()
        Me.lbED2_12 = New System.Windows.Forms.Label()
        Me.lbED2_30 = New System.Windows.Forms.Label()
        Me.lbED2_7 = New System.Windows.Forms.Label()
        Me.lbED2_20 = New System.Windows.Forms.Label()
        Me.lbED2_14 = New System.Windows.Forms.Label()
        Me.lbED2_27 = New System.Windows.Forms.Label()
        Me.lbED2_4 = New System.Windows.Forms.Label()
        Me.lbED2_22 = New System.Windows.Forms.Label()
        Me.lbED2_11 = New System.Windows.Forms.Label()
        Me.lbED2_29 = New System.Windows.Forms.Label()
        Me.lbED2_6 = New System.Windows.Forms.Label()
        Me.lbED2_19 = New System.Windows.Forms.Label()
        Me.lbED2_13 = New System.Windows.Forms.Label()
        Me.lbED2_26 = New System.Windows.Forms.Label()
        Me.lbED2_3 = New System.Windows.Forms.Label()
        Me.lbED2_21 = New System.Windows.Forms.Label()
        Me.lbED2_10 = New System.Windows.Forms.Label()
        Me.lbED2_25 = New System.Windows.Forms.Label()
        Me.lbED2_5 = New System.Windows.Forms.Label()
        Me.lbED2_18 = New System.Windows.Forms.Label()
        Me.lbED2_9 = New System.Windows.Forms.Label()
        Me.lbED2_17 = New System.Windows.Forms.Label()
        Me.lbED2_2 = New System.Windows.Forms.Label()
        Me.lbED2_1 = New System.Windows.Forms.Label()
        Me.tbSD1_16 = New System.Windows.Forms.TextBox()
        Me.tbSD1_15 = New System.Windows.Forms.TextBox()
        Me.tbSD1_14 = New System.Windows.Forms.TextBox()
        Me.tbSD1_13 = New System.Windows.Forms.TextBox()
        Me.tbSD1_12 = New System.Windows.Forms.TextBox()
        Me.tbSD1_11 = New System.Windows.Forms.TextBox()
        Me.tbSD1_10 = New System.Windows.Forms.TextBox()
        Me.tbSD1_9 = New System.Windows.Forms.TextBox()
        Me.tbSD1_8 = New System.Windows.Forms.TextBox()
        Me.tbSD1_7 = New System.Windows.Forms.TextBox()
        Me.tbSD1_6 = New System.Windows.Forms.TextBox()
        Me.tbSD1_5 = New System.Windows.Forms.TextBox()
        Me.tbSD1_4 = New System.Windows.Forms.TextBox()
        Me.tbSD1_3 = New System.Windows.Forms.TextBox()
        Me.tbSD1_2 = New System.Windows.Forms.TextBox()
        Me.tbSD1_1 = New System.Windows.Forms.TextBox()
        Me.lbED1_32 = New System.Windows.Forms.Label()
        Me.lbED1_31 = New System.Windows.Forms.Label()
        Me.lbED1_16 = New System.Windows.Forms.Label()
        Me.lbED1_24 = New System.Windows.Forms.Label()
        Me.lbED1_15 = New System.Windows.Forms.Label()
        Me.lbED1_28 = New System.Windows.Forms.Label()
        Me.lbED1_8 = New System.Windows.Forms.Label()
        Me.lbED1_23 = New System.Windows.Forms.Label()
        Me.lbED1_12 = New System.Windows.Forms.Label()
        Me.lbED1_30 = New System.Windows.Forms.Label()
        Me.lbED1_7 = New System.Windows.Forms.Label()
        Me.lbED1_20 = New System.Windows.Forms.Label()
        Me.lbED1_14 = New System.Windows.Forms.Label()
        Me.lbED1_27 = New System.Windows.Forms.Label()
        Me.lbED1_4 = New System.Windows.Forms.Label()
        Me.lbED1_22 = New System.Windows.Forms.Label()
        Me.lbED1_11 = New System.Windows.Forms.Label()
        Me.lbED1_29 = New System.Windows.Forms.Label()
        Me.lbED1_6 = New System.Windows.Forms.Label()
        Me.lbED1_19 = New System.Windows.Forms.Label()
        Me.lbED1_13 = New System.Windows.Forms.Label()
        Me.lbED1_26 = New System.Windows.Forms.Label()
        Me.lbED1_3 = New System.Windows.Forms.Label()
        Me.lbED1_21 = New System.Windows.Forms.Label()
        Me.lbED1_10 = New System.Windows.Forms.Label()
        Me.lbED1_25 = New System.Windows.Forms.Label()
        Me.lbED1_5 = New System.Windows.Forms.Label()
        Me.lbED1_18 = New System.Windows.Forms.Label()
        Me.lbED1_9 = New System.Windows.Forms.Label()
        Me.lbED1_17 = New System.Windows.Forms.Label()
        Me.lbED1_2 = New System.Windows.Forms.Label()
        Me.lbED1_1 = New System.Windows.Forms.Label()
        Me.lbT4 = New System.Windows.Forms.Label()
        Me.lbT7 = New System.Windows.Forms.Label()
        Me.lbT6 = New System.Windows.Forms.Label()
        Me.lbT5 = New System.Windows.Forms.Label()
        Me.lbT3 = New System.Windows.Forms.Label()
        Me.lbT2 = New System.Windows.Forms.Label()
        Me.cmdRESET_SD = New System.Windows.Forms.Button()
        Me.tm_POLLING_SD_1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRESIZE = New System.Windows.Forms.Button()
        Me.gbRESIZE = New System.Windows.Forms.GroupBox()
        Me.cmdApCombo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBOARD7 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD6 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD5 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD4 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD3 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD2 = New System.Windows.Forms.CheckBox()
        Me.cbBOARD1 = New System.Windows.Forms.CheckBox()
        Me.tbN_BOARDS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbGOOSES = New System.Windows.Forms.GroupBox()
        Me.lbLGOOSE_12 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_8 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_4 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_11 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_10 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_7 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_6 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_9 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_3 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_5 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_2 = New System.Windows.Forms.Label()
        Me.lbLGOOSE_1 = New System.Windows.Forms.Label()
        Me.tm_POLLING_ED_1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRESET_ED = New System.Windows.Forms.Button()
        Me.tm_POLLING_ED_2 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_ED_3 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_ED_4 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_ED_5 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_ED_6 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_ED_7 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_2 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_3 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_4 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_5 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_6 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_SD_7 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_POLLING_GOOSES = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdSALIR = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdCANCELAR_AUTO = New System.Windows.Forms.Button()
        Me.cmdAUTO_TEST = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbTIPOCID = New System.Windows.Forms.GroupBox()
        Me.rbEF = New System.Windows.Forms.RadioButton()
        Me.rbDAPT = New System.Windows.Forms.RadioButton()
        Me.rbDAPTC = New System.Windows.Forms.RadioButton()
        Me.gb61850.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbIO.SuspendLayout()
        Me.gbRESIZE.SuspendLayout()
        Me.gbGOOSES.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbTIPOCID.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdED1_2
        '
        Me.cmdED1_2.AccessibleDescription = ""
        Me.cmdED1_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdED1_2.Location = New System.Drawing.Point(2, 51)
        Me.cmdED1_2.Name = "cmdED1_2"
        Me.cmdED1_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_2.TabIndex = 1
        Me.cmdED1_2.Text = "ED1_2"
        Me.cmdED1_2.UseVisualStyleBackColor = True
        '
        'cmdED1_4
        '
        Me.cmdED1_4.AccessibleDescription = ""
        Me.cmdED1_4.Location = New System.Drawing.Point(2, 87)
        Me.cmdED1_4.Name = "cmdED1_4"
        Me.cmdED1_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_4.TabIndex = 3
        Me.cmdED1_4.Text = "ED1_4"
        Me.cmdED1_4.UseVisualStyleBackColor = True
        '
        'cmdED1_3
        '
        Me.cmdED1_3.AccessibleDescription = ""
        Me.cmdED1_3.Location = New System.Drawing.Point(2, 69)
        Me.cmdED1_3.Name = "cmdED1_3"
        Me.cmdED1_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_3.TabIndex = 2
        Me.cmdED1_3.Text = "ED1_3"
        Me.cmdED1_3.UseVisualStyleBackColor = True
        '
        'cmdED1_8
        '
        Me.cmdED1_8.AccessibleDescription = ""
        Me.cmdED1_8.Location = New System.Drawing.Point(2, 159)
        Me.cmdED1_8.Name = "cmdED1_8"
        Me.cmdED1_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_8.TabIndex = 7
        Me.cmdED1_8.Text = "ED1_8"
        Me.cmdED1_8.UseVisualStyleBackColor = True
        '
        'cmdED1_7
        '
        Me.cmdED1_7.AccessibleDescription = ""
        Me.cmdED1_7.Location = New System.Drawing.Point(2, 141)
        Me.cmdED1_7.Name = "cmdED1_7"
        Me.cmdED1_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_7.TabIndex = 6
        Me.cmdED1_7.Text = "ED1_7"
        Me.cmdED1_7.UseVisualStyleBackColor = True
        '
        'cmdED1_6
        '
        Me.cmdED1_6.AccessibleDescription = ""
        Me.cmdED1_6.Location = New System.Drawing.Point(2, 123)
        Me.cmdED1_6.Name = "cmdED1_6"
        Me.cmdED1_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_6.TabIndex = 5
        Me.cmdED1_6.Text = "ED1_6"
        Me.cmdED1_6.UseVisualStyleBackColor = True
        '
        'cmdED1_5
        '
        Me.cmdED1_5.AccessibleDescription = ""
        Me.cmdED1_5.Location = New System.Drawing.Point(2, 105)
        Me.cmdED1_5.Name = "cmdED1_5"
        Me.cmdED1_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_5.TabIndex = 4
        Me.cmdED1_5.Text = "ED1_5"
        Me.cmdED1_5.UseVisualStyleBackColor = True
        '
        'cmdED1_9
        '
        Me.cmdED1_9.AccessibleDescription = ""
        Me.cmdED1_9.Location = New System.Drawing.Point(2, 177)
        Me.cmdED1_9.Name = "cmdED1_9"
        Me.cmdED1_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_9.TabIndex = 8
        Me.cmdED1_9.Text = "ED1_9"
        Me.cmdED1_9.UseVisualStyleBackColor = True
        '
        'cmdED1_10
        '
        Me.cmdED1_10.AccessibleDescription = ""
        Me.cmdED1_10.Location = New System.Drawing.Point(2, 195)
        Me.cmdED1_10.Name = "cmdED1_10"
        Me.cmdED1_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_10.TabIndex = 9
        Me.cmdED1_10.Text = "ED1_10"
        Me.cmdED1_10.UseVisualStyleBackColor = True
        '
        'cmdED1_11
        '
        Me.cmdED1_11.AccessibleDescription = ""
        Me.cmdED1_11.Location = New System.Drawing.Point(2, 213)
        Me.cmdED1_11.Name = "cmdED1_11"
        Me.cmdED1_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_11.TabIndex = 10
        Me.cmdED1_11.Text = "ED1_11"
        Me.cmdED1_11.UseVisualStyleBackColor = True
        '
        'cmdED1_12
        '
        Me.cmdED1_12.AccessibleDescription = ""
        Me.cmdED1_12.Location = New System.Drawing.Point(2, 231)
        Me.cmdED1_12.Name = "cmdED1_12"
        Me.cmdED1_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_12.TabIndex = 11
        Me.cmdED1_12.Text = "ED1_12"
        Me.cmdED1_12.UseVisualStyleBackColor = True
        '
        'cmdED1_13
        '
        Me.cmdED1_13.AccessibleDescription = ""
        Me.cmdED1_13.Location = New System.Drawing.Point(2, 249)
        Me.cmdED1_13.Name = "cmdED1_13"
        Me.cmdED1_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_13.TabIndex = 12
        Me.cmdED1_13.Text = "ED1_13"
        Me.cmdED1_13.UseVisualStyleBackColor = True
        '
        'cmdED1_14
        '
        Me.cmdED1_14.AccessibleDescription = ""
        Me.cmdED1_14.Location = New System.Drawing.Point(2, 267)
        Me.cmdED1_14.Name = "cmdED1_14"
        Me.cmdED1_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_14.TabIndex = 13
        Me.cmdED1_14.Text = "ED1_14"
        Me.cmdED1_14.UseVisualStyleBackColor = True
        '
        'cmdED1_15
        '
        Me.cmdED1_15.AccessibleDescription = ""
        Me.cmdED1_15.Location = New System.Drawing.Point(2, 285)
        Me.cmdED1_15.Name = "cmdED1_15"
        Me.cmdED1_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_15.TabIndex = 14
        Me.cmdED1_15.Text = "ED1_15"
        Me.cmdED1_15.UseVisualStyleBackColor = True
        '
        'cmdED1_16
        '
        Me.cmdED1_16.AccessibleDescription = ""
        Me.cmdED1_16.Location = New System.Drawing.Point(2, 303)
        Me.cmdED1_16.Name = "cmdED1_16"
        Me.cmdED1_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_16.TabIndex = 15
        Me.cmdED1_16.Text = "ED1_16"
        Me.cmdED1_16.UseVisualStyleBackColor = True
        '
        'cmdED1_17
        '
        Me.cmdED1_17.AccessibleDescription = ""
        Me.cmdED1_17.Location = New System.Drawing.Point(2, 321)
        Me.cmdED1_17.Name = "cmdED1_17"
        Me.cmdED1_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_17.TabIndex = 16
        Me.cmdED1_17.Text = "ED1_17"
        Me.cmdED1_17.UseVisualStyleBackColor = True
        '
        'cmdED1_25
        '
        Me.cmdED1_25.AccessibleDescription = ""
        Me.cmdED1_25.Location = New System.Drawing.Point(2, 465)
        Me.cmdED1_25.Name = "cmdED1_25"
        Me.cmdED1_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_25.TabIndex = 24
        Me.cmdED1_25.Text = "ED1_25"
        Me.cmdED1_25.UseVisualStyleBackColor = True
        '
        'cmdED1_18
        '
        Me.cmdED1_18.AccessibleDescription = ""
        Me.cmdED1_18.Location = New System.Drawing.Point(2, 339)
        Me.cmdED1_18.Name = "cmdED1_18"
        Me.cmdED1_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_18.TabIndex = 17
        Me.cmdED1_18.Text = "ED1_18"
        Me.cmdED1_18.UseVisualStyleBackColor = True
        '
        'cmdED1_26
        '
        Me.cmdED1_26.AccessibleDescription = ""
        Me.cmdED1_26.Location = New System.Drawing.Point(2, 483)
        Me.cmdED1_26.Name = "cmdED1_26"
        Me.cmdED1_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_26.TabIndex = 25
        Me.cmdED1_26.Text = "ED1_26"
        Me.cmdED1_26.UseVisualStyleBackColor = True
        '
        'cmdED1_19
        '
        Me.cmdED1_19.AccessibleDescription = ""
        Me.cmdED1_19.Location = New System.Drawing.Point(2, 357)
        Me.cmdED1_19.Name = "cmdED1_19"
        Me.cmdED1_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_19.TabIndex = 18
        Me.cmdED1_19.Text = "ED1_19"
        Me.cmdED1_19.UseVisualStyleBackColor = True
        '
        'cmdED1_27
        '
        Me.cmdED1_27.AccessibleDescription = ""
        Me.cmdED1_27.Location = New System.Drawing.Point(2, 501)
        Me.cmdED1_27.Name = "cmdED1_27"
        Me.cmdED1_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_27.TabIndex = 26
        Me.cmdED1_27.Text = "ED1_27"
        Me.cmdED1_27.UseVisualStyleBackColor = True
        '
        'cmdED1_20
        '
        Me.cmdED1_20.AccessibleDescription = ""
        Me.cmdED1_20.Location = New System.Drawing.Point(2, 375)
        Me.cmdED1_20.Name = "cmdED1_20"
        Me.cmdED1_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_20.TabIndex = 19
        Me.cmdED1_20.Text = "ED1_20"
        Me.cmdED1_20.UseVisualStyleBackColor = True
        '
        'cmdED1_28
        '
        Me.cmdED1_28.AccessibleDescription = ""
        Me.cmdED1_28.Location = New System.Drawing.Point(2, 519)
        Me.cmdED1_28.Name = "cmdED1_28"
        Me.cmdED1_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_28.TabIndex = 27
        Me.cmdED1_28.Text = "ED1_28"
        Me.cmdED1_28.UseVisualStyleBackColor = True
        '
        'cmdED1_21
        '
        Me.cmdED1_21.AccessibleDescription = ""
        Me.cmdED1_21.Location = New System.Drawing.Point(2, 393)
        Me.cmdED1_21.Name = "cmdED1_21"
        Me.cmdED1_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_21.TabIndex = 20
        Me.cmdED1_21.Text = "ED1_21"
        Me.cmdED1_21.UseVisualStyleBackColor = True
        '
        'cmdED1_29
        '
        Me.cmdED1_29.AccessibleDescription = ""
        Me.cmdED1_29.Location = New System.Drawing.Point(2, 537)
        Me.cmdED1_29.Name = "cmdED1_29"
        Me.cmdED1_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_29.TabIndex = 28
        Me.cmdED1_29.Text = "ED1_29"
        Me.cmdED1_29.UseVisualStyleBackColor = True
        '
        'cmdED1_22
        '
        Me.cmdED1_22.AccessibleDescription = ""
        Me.cmdED1_22.Location = New System.Drawing.Point(2, 411)
        Me.cmdED1_22.Name = "cmdED1_22"
        Me.cmdED1_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_22.TabIndex = 21
        Me.cmdED1_22.Text = "ED1_22"
        Me.cmdED1_22.UseVisualStyleBackColor = True
        '
        'cmdED1_30
        '
        Me.cmdED1_30.AccessibleDescription = ""
        Me.cmdED1_30.Location = New System.Drawing.Point(2, 555)
        Me.cmdED1_30.Name = "cmdED1_30"
        Me.cmdED1_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_30.TabIndex = 29
        Me.cmdED1_30.Text = "ED1_30"
        Me.cmdED1_30.UseVisualStyleBackColor = True
        '
        'cmdED1_23
        '
        Me.cmdED1_23.AccessibleDescription = ""
        Me.cmdED1_23.Location = New System.Drawing.Point(2, 429)
        Me.cmdED1_23.Name = "cmdED1_23"
        Me.cmdED1_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_23.TabIndex = 22
        Me.cmdED1_23.Text = "ED1_23"
        Me.cmdED1_23.UseVisualStyleBackColor = True
        '
        'cmdED1_31
        '
        Me.cmdED1_31.AccessibleDescription = ""
        Me.cmdED1_31.Location = New System.Drawing.Point(2, 573)
        Me.cmdED1_31.Name = "cmdED1_31"
        Me.cmdED1_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_31.TabIndex = 30
        Me.cmdED1_31.Text = "ED1_31"
        Me.cmdED1_31.UseVisualStyleBackColor = True
        '
        'cmdED1_24
        '
        Me.cmdED1_24.AccessibleDescription = ""
        Me.cmdED1_24.Location = New System.Drawing.Point(2, 447)
        Me.cmdED1_24.Name = "cmdED1_24"
        Me.cmdED1_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_24.TabIndex = 23
        Me.cmdED1_24.Text = "ED1_24"
        Me.cmdED1_24.UseVisualStyleBackColor = True
        '
        'cmdED1_32
        '
        Me.cmdED1_32.AccessibleDescription = ""
        Me.cmdED1_32.Location = New System.Drawing.Point(2, 591)
        Me.cmdED1_32.Name = "cmdED1_32"
        Me.cmdED1_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED1_32.TabIndex = 31
        Me.cmdED1_32.Text = "ED1_32"
        Me.cmdED1_32.UseVisualStyleBackColor = True
        '
        'tbIED
        '
        Me.tbIED.Location = New System.Drawing.Point(7, 15)
        Me.tbIED.Name = "tbIED"
        Me.tbIED.Size = New System.Drawing.Size(134, 20)
        Me.tbIED.TabIndex = 0
        '
        'gb61850
        '
        Me.gb61850.Controls.Add(Me.tbIED)
        Me.gb61850.Location = New System.Drawing.Point(90, 76)
        Me.gb61850.Name = "gb61850"
        Me.gb61850.Size = New System.Drawing.Size(150, 40)
        Me.gb61850.TabIndex = 0
        Me.gb61850.TabStop = False
        Me.gb61850.Text = "NOMBRE DEL IED"
        '
        'tbRutaExcel
        '
        Me.tbRutaExcel.Location = New System.Drawing.Point(363, 13)
        Me.tbRutaExcel.Name = "tbRutaExcel"
        Me.tbRutaExcel.Size = New System.Drawing.Size(23, 20)
        Me.tbRutaExcel.TabIndex = 2
        Me.tbRutaExcel.Visible = False
        '
        'cmdED2_32
        '
        Me.cmdED2_32.AccessibleDescription = ""
        Me.cmdED2_32.Location = New System.Drawing.Point(171, 591)
        Me.cmdED2_32.Name = "cmdED2_32"
        Me.cmdED2_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_32.TabIndex = 63
        Me.cmdED2_32.Text = "ED2_32"
        Me.cmdED2_32.UseVisualStyleBackColor = True
        '
        'cmdED2_24
        '
        Me.cmdED2_24.AccessibleDescription = ""
        Me.cmdED2_24.Location = New System.Drawing.Point(171, 447)
        Me.cmdED2_24.Name = "cmdED2_24"
        Me.cmdED2_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_24.TabIndex = 55
        Me.cmdED2_24.Text = "ED2_24"
        Me.cmdED2_24.UseVisualStyleBackColor = True
        '
        'cmdED2_16
        '
        Me.cmdED2_16.AccessibleDescription = ""
        Me.cmdED2_16.Location = New System.Drawing.Point(171, 303)
        Me.cmdED2_16.Name = "cmdED2_16"
        Me.cmdED2_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_16.TabIndex = 47
        Me.cmdED2_16.Text = "ED2_16"
        Me.cmdED2_16.UseVisualStyleBackColor = True
        '
        'cmdED2_31
        '
        Me.cmdED2_31.AccessibleDescription = ""
        Me.cmdED2_31.Location = New System.Drawing.Point(171, 573)
        Me.cmdED2_31.Name = "cmdED2_31"
        Me.cmdED2_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_31.TabIndex = 62
        Me.cmdED2_31.Text = "ED2_31"
        Me.cmdED2_31.UseVisualStyleBackColor = True
        '
        'cmdED2_8
        '
        Me.cmdED2_8.AccessibleDescription = ""
        Me.cmdED2_8.Location = New System.Drawing.Point(171, 159)
        Me.cmdED2_8.Name = "cmdED2_8"
        Me.cmdED2_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_8.TabIndex = 39
        Me.cmdED2_8.Text = "ED2_8"
        Me.cmdED2_8.UseVisualStyleBackColor = True
        '
        'cmdED2_23
        '
        Me.cmdED2_23.AccessibleDescription = ""
        Me.cmdED2_23.Location = New System.Drawing.Point(171, 429)
        Me.cmdED2_23.Name = "cmdED2_23"
        Me.cmdED2_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_23.TabIndex = 54
        Me.cmdED2_23.Text = "ED2_23"
        Me.cmdED2_23.UseVisualStyleBackColor = True
        '
        'cmdED2_15
        '
        Me.cmdED2_15.AccessibleDescription = ""
        Me.cmdED2_15.Location = New System.Drawing.Point(171, 285)
        Me.cmdED2_15.Name = "cmdED2_15"
        Me.cmdED2_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_15.TabIndex = 46
        Me.cmdED2_15.Text = "ED2_15"
        Me.cmdED2_15.UseVisualStyleBackColor = True
        '
        'cmdED2_30
        '
        Me.cmdED2_30.AccessibleDescription = ""
        Me.cmdED2_30.Location = New System.Drawing.Point(171, 555)
        Me.cmdED2_30.Name = "cmdED2_30"
        Me.cmdED2_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_30.TabIndex = 61
        Me.cmdED2_30.Text = "ED2_30"
        Me.cmdED2_30.UseVisualStyleBackColor = True
        '
        'cmdED2_7
        '
        Me.cmdED2_7.AccessibleDescription = ""
        Me.cmdED2_7.Location = New System.Drawing.Point(171, 141)
        Me.cmdED2_7.Name = "cmdED2_7"
        Me.cmdED2_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_7.TabIndex = 38
        Me.cmdED2_7.Text = "ED2_7"
        Me.cmdED2_7.UseVisualStyleBackColor = True
        '
        'cmdED2_22
        '
        Me.cmdED2_22.AccessibleDescription = ""
        Me.cmdED2_22.Location = New System.Drawing.Point(171, 411)
        Me.cmdED2_22.Name = "cmdED2_22"
        Me.cmdED2_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_22.TabIndex = 53
        Me.cmdED2_22.Text = "ED2_22"
        Me.cmdED2_22.UseVisualStyleBackColor = True
        '
        'cmdED2_14
        '
        Me.cmdED2_14.AccessibleDescription = ""
        Me.cmdED2_14.Location = New System.Drawing.Point(171, 267)
        Me.cmdED2_14.Name = "cmdED2_14"
        Me.cmdED2_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_14.TabIndex = 45
        Me.cmdED2_14.Text = "ED2_14"
        Me.cmdED2_14.UseVisualStyleBackColor = True
        '
        'cmdED2_29
        '
        Me.cmdED2_29.AccessibleDescription = ""
        Me.cmdED2_29.Location = New System.Drawing.Point(171, 537)
        Me.cmdED2_29.Name = "cmdED2_29"
        Me.cmdED2_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_29.TabIndex = 60
        Me.cmdED2_29.Text = "ED2_29"
        Me.cmdED2_29.UseVisualStyleBackColor = True
        '
        'cmdED2_6
        '
        Me.cmdED2_6.AccessibleDescription = ""
        Me.cmdED2_6.Location = New System.Drawing.Point(171, 123)
        Me.cmdED2_6.Name = "cmdED2_6"
        Me.cmdED2_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_6.TabIndex = 37
        Me.cmdED2_6.Text = "ED2_6"
        Me.cmdED2_6.UseVisualStyleBackColor = True
        '
        'cmdED2_21
        '
        Me.cmdED2_21.AccessibleDescription = ""
        Me.cmdED2_21.Location = New System.Drawing.Point(171, 393)
        Me.cmdED2_21.Name = "cmdED2_21"
        Me.cmdED2_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_21.TabIndex = 52
        Me.cmdED2_21.Text = "ED2_21"
        Me.cmdED2_21.UseVisualStyleBackColor = True
        '
        'cmdED2_13
        '
        Me.cmdED2_13.AccessibleDescription = ""
        Me.cmdED2_13.Location = New System.Drawing.Point(171, 249)
        Me.cmdED2_13.Name = "cmdED2_13"
        Me.cmdED2_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_13.TabIndex = 44
        Me.cmdED2_13.Text = "ED2_13"
        Me.cmdED2_13.UseVisualStyleBackColor = True
        '
        'cmdED2_28
        '
        Me.cmdED2_28.AccessibleDescription = ""
        Me.cmdED2_28.Location = New System.Drawing.Point(171, 519)
        Me.cmdED2_28.Name = "cmdED2_28"
        Me.cmdED2_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_28.TabIndex = 59
        Me.cmdED2_28.Text = "ED2_28"
        Me.cmdED2_28.UseVisualStyleBackColor = True
        '
        'cmdED2_5
        '
        Me.cmdED2_5.AccessibleDescription = ""
        Me.cmdED2_5.Location = New System.Drawing.Point(171, 105)
        Me.cmdED2_5.Name = "cmdED2_5"
        Me.cmdED2_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_5.TabIndex = 36
        Me.cmdED2_5.Text = "ED2_5"
        Me.cmdED2_5.UseVisualStyleBackColor = True
        '
        'cmdED2_20
        '
        Me.cmdED2_20.AccessibleDescription = ""
        Me.cmdED2_20.Location = New System.Drawing.Point(171, 375)
        Me.cmdED2_20.Name = "cmdED2_20"
        Me.cmdED2_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_20.TabIndex = 51
        Me.cmdED2_20.Text = "ED2_20"
        Me.cmdED2_20.UseVisualStyleBackColor = True
        '
        'cmdED2_12
        '
        Me.cmdED2_12.AccessibleDescription = ""
        Me.cmdED2_12.Location = New System.Drawing.Point(171, 231)
        Me.cmdED2_12.Name = "cmdED2_12"
        Me.cmdED2_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_12.TabIndex = 43
        Me.cmdED2_12.Text = "ED2_12"
        Me.cmdED2_12.UseVisualStyleBackColor = True
        '
        'cmdED2_27
        '
        Me.cmdED2_27.AccessibleDescription = ""
        Me.cmdED2_27.Location = New System.Drawing.Point(171, 501)
        Me.cmdED2_27.Name = "cmdED2_27"
        Me.cmdED2_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_27.TabIndex = 58
        Me.cmdED2_27.Text = "ED2_27"
        Me.cmdED2_27.UseVisualStyleBackColor = True
        '
        'cmdED2_4
        '
        Me.cmdED2_4.AccessibleDescription = ""
        Me.cmdED2_4.Location = New System.Drawing.Point(171, 87)
        Me.cmdED2_4.Name = "cmdED2_4"
        Me.cmdED2_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_4.TabIndex = 35
        Me.cmdED2_4.Text = "ED2_4"
        Me.cmdED2_4.UseVisualStyleBackColor = True
        '
        'cmdED2_19
        '
        Me.cmdED2_19.AccessibleDescription = ""
        Me.cmdED2_19.Location = New System.Drawing.Point(171, 357)
        Me.cmdED2_19.Name = "cmdED2_19"
        Me.cmdED2_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_19.TabIndex = 50
        Me.cmdED2_19.Text = "ED2_19"
        Me.cmdED2_19.UseVisualStyleBackColor = True
        '
        'cmdED2_11
        '
        Me.cmdED2_11.AccessibleDescription = ""
        Me.cmdED2_11.Location = New System.Drawing.Point(171, 213)
        Me.cmdED2_11.Name = "cmdED2_11"
        Me.cmdED2_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_11.TabIndex = 42
        Me.cmdED2_11.Text = "ED2_11"
        Me.cmdED2_11.UseVisualStyleBackColor = True
        '
        'cmdED2_26
        '
        Me.cmdED2_26.AccessibleDescription = ""
        Me.cmdED2_26.Location = New System.Drawing.Point(171, 483)
        Me.cmdED2_26.Name = "cmdED2_26"
        Me.cmdED2_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_26.TabIndex = 57
        Me.cmdED2_26.Text = "ED2_26"
        Me.cmdED2_26.UseVisualStyleBackColor = True
        '
        'cmdED2_3
        '
        Me.cmdED2_3.AccessibleDescription = ""
        Me.cmdED2_3.Location = New System.Drawing.Point(171, 69)
        Me.cmdED2_3.Name = "cmdED2_3"
        Me.cmdED2_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_3.TabIndex = 34
        Me.cmdED2_3.Text = "ED2_3"
        Me.cmdED2_3.UseVisualStyleBackColor = True
        '
        'cmdED2_18
        '
        Me.cmdED2_18.AccessibleDescription = ""
        Me.cmdED2_18.Location = New System.Drawing.Point(171, 339)
        Me.cmdED2_18.Name = "cmdED2_18"
        Me.cmdED2_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_18.TabIndex = 49
        Me.cmdED2_18.Text = "ED2_18"
        Me.cmdED2_18.UseVisualStyleBackColor = True
        '
        'cmdED2_10
        '
        Me.cmdED2_10.AccessibleDescription = ""
        Me.cmdED2_10.Location = New System.Drawing.Point(171, 195)
        Me.cmdED2_10.Name = "cmdED2_10"
        Me.cmdED2_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_10.TabIndex = 41
        Me.cmdED2_10.Text = "ED2_10"
        Me.cmdED2_10.UseVisualStyleBackColor = True
        '
        'cmdED2_25
        '
        Me.cmdED2_25.AccessibleDescription = ""
        Me.cmdED2_25.Location = New System.Drawing.Point(171, 465)
        Me.cmdED2_25.Name = "cmdED2_25"
        Me.cmdED2_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_25.TabIndex = 56
        Me.cmdED2_25.Text = "ED2_25"
        Me.cmdED2_25.UseVisualStyleBackColor = True
        '
        'cmdED2_2
        '
        Me.cmdED2_2.AccessibleDescription = ""
        Me.cmdED2_2.Location = New System.Drawing.Point(171, 51)
        Me.cmdED2_2.Name = "cmdED2_2"
        Me.cmdED2_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_2.TabIndex = 33
        Me.cmdED2_2.Text = "ED2_2"
        Me.cmdED2_2.UseVisualStyleBackColor = True
        '
        'cmdED2_17
        '
        Me.cmdED2_17.AccessibleDescription = ""
        Me.cmdED2_17.Location = New System.Drawing.Point(171, 321)
        Me.cmdED2_17.Name = "cmdED2_17"
        Me.cmdED2_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_17.TabIndex = 48
        Me.cmdED2_17.Text = "ED2_17"
        Me.cmdED2_17.UseVisualStyleBackColor = True
        '
        'cmdED2_9
        '
        Me.cmdED2_9.AccessibleDescription = ""
        Me.cmdED2_9.Location = New System.Drawing.Point(171, 177)
        Me.cmdED2_9.Name = "cmdED2_9"
        Me.cmdED2_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_9.TabIndex = 40
        Me.cmdED2_9.Text = "ED2_9"
        Me.cmdED2_9.UseVisualStyleBackColor = True
        '
        'cmdED2_1
        '
        Me.cmdED2_1.AccessibleDescription = ""
        Me.cmdED2_1.Location = New System.Drawing.Point(171, 33)
        Me.cmdED2_1.Name = "cmdED2_1"
        Me.cmdED2_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED2_1.TabIndex = 32
        Me.cmdED2_1.Text = "ED2_1"
        Me.cmdED2_1.UseVisualStyleBackColor = True
        '
        'lbT1
        '
        Me.lbT1.AutoSize = True
        Me.lbT1.Location = New System.Drawing.Point(2, 13)
        Me.lbT1.Name = "lbT1"
        Me.lbT1.Size = New System.Drawing.Size(169, 13)
        Me.lbT1.TabIndex = 128
        Me.lbT1.Text = "_________TARJETA_1________"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbPestanas)
        Me.GroupBox1.Controls.Add(Me.tbCODCOM)
        Me.GroupBox1.Controls.Add(Me.cmdBrowser)
        Me.GroupBox1.Location = New System.Drawing.Point(248, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 70)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CARGAR BASE DE DATOS"
        '
        'cbPestanas
        '
        Me.cbPestanas.FormattingEnabled = True
        Me.cbPestanas.Location = New System.Drawing.Point(47, 28)
        Me.cbPestanas.Name = "cbPestanas"
        Me.cbPestanas.Size = New System.Drawing.Size(100, 21)
        Me.cbPestanas.TabIndex = 1
        '
        'tbCODCOM
        '
        Me.tbCODCOM.Location = New System.Drawing.Point(153, 28)
        Me.tbCODCOM.Name = "tbCODCOM"
        Me.tbCODCOM.Size = New System.Drawing.Size(183, 20)
        Me.tbCODCOM.TabIndex = 2
        Me.tbCODCOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdBrowser
        '
        Me.cmdBrowser.AccessibleDescription = ""
        Me.cmdBrowser.Location = New System.Drawing.Point(10, 28)
        Me.cmdBrowser.Name = "cmdBrowser"
        Me.cmdBrowser.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowser.TabIndex = 0
        Me.cmdBrowser.Text = "..."
        Me.cmdBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBrowser.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbSTATUS)
        Me.GroupBox3.Controls.Add(Me.tbRutaExcel)
        Me.GroupBox3.Controls.Add(Me.cmdDESCONECTAR)
        Me.GroupBox3.Controls.Add(Me.cmdCONECTAR)
        Me.GroupBox3.Controls.Add(Me.tbIP)
        Me.GroupBox3.Location = New System.Drawing.Point(248, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(358, 40)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONEXION TCP/IP"
        '
        'tbSTATUS
        '
        Me.tbSTATUS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSTATUS.Enabled = False
        Me.tbSTATUS.Location = New System.Drawing.Point(323, 14)
        Me.tbSTATUS.MaxLength = 15
        Me.tbSTATUS.Name = "tbSTATUS"
        Me.tbSTATUS.ReadOnly = True
        Me.tbSTATUS.Size = New System.Drawing.Size(20, 20)
        Me.tbSTATUS.TabIndex = 3
        '
        'cmdDESCONECTAR
        '
        Me.cmdDESCONECTAR.AccessibleDescription = ""
        Me.cmdDESCONECTAR.Enabled = False
        Me.cmdDESCONECTAR.Location = New System.Drawing.Point(213, 14)
        Me.cmdDESCONECTAR.Name = "cmdDESCONECTAR"
        Me.cmdDESCONECTAR.Size = New System.Drawing.Size(100, 20)
        Me.cmdDESCONECTAR.TabIndex = 2
        Me.cmdDESCONECTAR.Text = "DESCONECTAR"
        Me.cmdDESCONECTAR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDESCONECTAR.UseVisualStyleBackColor = True
        '
        'cmdCONECTAR
        '
        Me.cmdCONECTAR.AccessibleDescription = ""
        Me.cmdCONECTAR.Location = New System.Drawing.Point(105, 14)
        Me.cmdCONECTAR.Name = "cmdCONECTAR"
        Me.cmdCONECTAR.Size = New System.Drawing.Size(100, 20)
        Me.cmdCONECTAR.TabIndex = 1
        Me.cmdCONECTAR.Text = "CONECTAR"
        Me.cmdCONECTAR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCONECTAR.UseVisualStyleBackColor = True
        '
        'tbIP
        '
        Me.tbIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbIP.Location = New System.Drawing.Point(8, 15)
        Me.tbIP.MaxLength = 15
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(85, 20)
        Me.tbIP.TabIndex = 0
        Me.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdDEFAULT
        '
        Me.cmdDEFAULT.AccessibleDescription = ""
        Me.cmdDEFAULT.Location = New System.Drawing.Point(3, 60)
        Me.cmdDEFAULT.Name = "cmdDEFAULT"
        Me.cmdDEFAULT.Size = New System.Drawing.Size(128, 23)
        Me.cmdDEFAULT.TabIndex = 3
        Me.cmdDEFAULT.Text = "RESTAURAR FORM."
        Me.cmdDEFAULT.UseVisualStyleBackColor = True
        '
        'cmdED1_1
        '
        Me.cmdED1_1.AccessibleDescription = ""
        Me.cmdED1_1.Location = New System.Drawing.Point(2, 32)
        Me.cmdED1_1.Name = "cmdED1_1"
        Me.cmdED1_1.Size = New System.Drawing.Size(54, 20)
        Me.cmdED1_1.TabIndex = 0
        Me.cmdED1_1.Text = "ED1_1"
        Me.cmdED1_1.UseVisualStyleBackColor = True
        '
        'gbIO
        '
        Me.gbIO.Controls.Add(Me.tbSD7_16)
        Me.gbIO.Controls.Add(Me.tbSD7_15)
        Me.gbIO.Controls.Add(Me.tbSD7_14)
        Me.gbIO.Controls.Add(Me.tbSD7_13)
        Me.gbIO.Controls.Add(Me.tbSD7_12)
        Me.gbIO.Controls.Add(Me.tbSD7_11)
        Me.gbIO.Controls.Add(Me.tbSD7_10)
        Me.gbIO.Controls.Add(Me.tbSD7_9)
        Me.gbIO.Controls.Add(Me.tbSD7_8)
        Me.gbIO.Controls.Add(Me.tbSD7_7)
        Me.gbIO.Controls.Add(Me.tbSD7_6)
        Me.gbIO.Controls.Add(Me.tbSD7_5)
        Me.gbIO.Controls.Add(Me.tbSD7_4)
        Me.gbIO.Controls.Add(Me.tbSD7_3)
        Me.gbIO.Controls.Add(Me.tbSD7_2)
        Me.gbIO.Controls.Add(Me.tbSD7_1)
        Me.gbIO.Controls.Add(Me.lbED7_32)
        Me.gbIO.Controls.Add(Me.lbED7_31)
        Me.gbIO.Controls.Add(Me.lbED7_16)
        Me.gbIO.Controls.Add(Me.lbED7_24)
        Me.gbIO.Controls.Add(Me.lbED7_15)
        Me.gbIO.Controls.Add(Me.lbED7_28)
        Me.gbIO.Controls.Add(Me.lbED7_8)
        Me.gbIO.Controls.Add(Me.lbED7_23)
        Me.gbIO.Controls.Add(Me.lbED7_12)
        Me.gbIO.Controls.Add(Me.lbED7_30)
        Me.gbIO.Controls.Add(Me.lbED7_7)
        Me.gbIO.Controls.Add(Me.lbED7_20)
        Me.gbIO.Controls.Add(Me.lbED7_14)
        Me.gbIO.Controls.Add(Me.lbED7_27)
        Me.gbIO.Controls.Add(Me.lbED7_4)
        Me.gbIO.Controls.Add(Me.lbED7_22)
        Me.gbIO.Controls.Add(Me.lbED7_11)
        Me.gbIO.Controls.Add(Me.lbED7_29)
        Me.gbIO.Controls.Add(Me.lbED7_6)
        Me.gbIO.Controls.Add(Me.lbED7_19)
        Me.gbIO.Controls.Add(Me.lbED7_13)
        Me.gbIO.Controls.Add(Me.lbED7_26)
        Me.gbIO.Controls.Add(Me.lbED7_3)
        Me.gbIO.Controls.Add(Me.lbED7_21)
        Me.gbIO.Controls.Add(Me.lbED7_10)
        Me.gbIO.Controls.Add(Me.lbED7_25)
        Me.gbIO.Controls.Add(Me.lbED7_5)
        Me.gbIO.Controls.Add(Me.lbED7_18)
        Me.gbIO.Controls.Add(Me.lbED7_9)
        Me.gbIO.Controls.Add(Me.lbED7_17)
        Me.gbIO.Controls.Add(Me.lbED7_2)
        Me.gbIO.Controls.Add(Me.lbED7_1)
        Me.gbIO.Controls.Add(Me.cmdED7_32)
        Me.gbIO.Controls.Add(Me.cmdED7_24)
        Me.gbIO.Controls.Add(Me.cmdED7_16)
        Me.gbIO.Controls.Add(Me.cmdED7_31)
        Me.gbIO.Controls.Add(Me.cmdED7_8)
        Me.gbIO.Controls.Add(Me.cmdED7_23)
        Me.gbIO.Controls.Add(Me.cmdED7_15)
        Me.gbIO.Controls.Add(Me.cmdED7_30)
        Me.gbIO.Controls.Add(Me.cmdED7_7)
        Me.gbIO.Controls.Add(Me.cmdED7_22)
        Me.gbIO.Controls.Add(Me.cmdED7_14)
        Me.gbIO.Controls.Add(Me.cmdED7_29)
        Me.gbIO.Controls.Add(Me.cmdED7_6)
        Me.gbIO.Controls.Add(Me.cmdED7_21)
        Me.gbIO.Controls.Add(Me.cmdED7_13)
        Me.gbIO.Controls.Add(Me.cmdED7_28)
        Me.gbIO.Controls.Add(Me.cmdED7_5)
        Me.gbIO.Controls.Add(Me.cmdED7_20)
        Me.gbIO.Controls.Add(Me.cmdED7_12)
        Me.gbIO.Controls.Add(Me.cmdED7_27)
        Me.gbIO.Controls.Add(Me.cmdED7_4)
        Me.gbIO.Controls.Add(Me.cmdED7_19)
        Me.gbIO.Controls.Add(Me.cmdED7_11)
        Me.gbIO.Controls.Add(Me.cmdED7_26)
        Me.gbIO.Controls.Add(Me.cmdED7_3)
        Me.gbIO.Controls.Add(Me.cmdED7_18)
        Me.gbIO.Controls.Add(Me.cmdED7_10)
        Me.gbIO.Controls.Add(Me.cmdED7_25)
        Me.gbIO.Controls.Add(Me.cmdED7_2)
        Me.gbIO.Controls.Add(Me.cmdED7_17)
        Me.gbIO.Controls.Add(Me.cmdED7_9)
        Me.gbIO.Controls.Add(Me.cmdED7_1)
        Me.gbIO.Controls.Add(Me.tbSD6_16)
        Me.gbIO.Controls.Add(Me.tbSD6_15)
        Me.gbIO.Controls.Add(Me.tbSD6_14)
        Me.gbIO.Controls.Add(Me.tbSD6_13)
        Me.gbIO.Controls.Add(Me.tbSD6_12)
        Me.gbIO.Controls.Add(Me.tbSD6_11)
        Me.gbIO.Controls.Add(Me.tbSD6_10)
        Me.gbIO.Controls.Add(Me.tbSD6_9)
        Me.gbIO.Controls.Add(Me.tbSD6_8)
        Me.gbIO.Controls.Add(Me.tbSD6_7)
        Me.gbIO.Controls.Add(Me.tbSD6_6)
        Me.gbIO.Controls.Add(Me.tbSD6_5)
        Me.gbIO.Controls.Add(Me.tbSD6_4)
        Me.gbIO.Controls.Add(Me.tbSD6_3)
        Me.gbIO.Controls.Add(Me.tbSD6_2)
        Me.gbIO.Controls.Add(Me.tbSD6_1)
        Me.gbIO.Controls.Add(Me.lbED6_32)
        Me.gbIO.Controls.Add(Me.lbED6_31)
        Me.gbIO.Controls.Add(Me.lbED6_16)
        Me.gbIO.Controls.Add(Me.lbED6_24)
        Me.gbIO.Controls.Add(Me.lbED6_15)
        Me.gbIO.Controls.Add(Me.lbED6_28)
        Me.gbIO.Controls.Add(Me.lbED6_8)
        Me.gbIO.Controls.Add(Me.lbED6_23)
        Me.gbIO.Controls.Add(Me.lbED6_12)
        Me.gbIO.Controls.Add(Me.lbED6_30)
        Me.gbIO.Controls.Add(Me.lbED6_7)
        Me.gbIO.Controls.Add(Me.lbED6_20)
        Me.gbIO.Controls.Add(Me.lbED6_14)
        Me.gbIO.Controls.Add(Me.lbED6_27)
        Me.gbIO.Controls.Add(Me.lbED6_4)
        Me.gbIO.Controls.Add(Me.lbED6_22)
        Me.gbIO.Controls.Add(Me.lbED6_11)
        Me.gbIO.Controls.Add(Me.lbED6_29)
        Me.gbIO.Controls.Add(Me.lbED6_6)
        Me.gbIO.Controls.Add(Me.lbED6_19)
        Me.gbIO.Controls.Add(Me.lbED6_13)
        Me.gbIO.Controls.Add(Me.lbED6_26)
        Me.gbIO.Controls.Add(Me.lbED6_3)
        Me.gbIO.Controls.Add(Me.lbED6_21)
        Me.gbIO.Controls.Add(Me.lbED6_10)
        Me.gbIO.Controls.Add(Me.lbED6_25)
        Me.gbIO.Controls.Add(Me.lbED6_5)
        Me.gbIO.Controls.Add(Me.lbED6_18)
        Me.gbIO.Controls.Add(Me.lbED6_9)
        Me.gbIO.Controls.Add(Me.lbED6_17)
        Me.gbIO.Controls.Add(Me.lbED6_2)
        Me.gbIO.Controls.Add(Me.lbED6_1)
        Me.gbIO.Controls.Add(Me.cmdED6_32)
        Me.gbIO.Controls.Add(Me.cmdED6_24)
        Me.gbIO.Controls.Add(Me.cmdED6_16)
        Me.gbIO.Controls.Add(Me.cmdED6_31)
        Me.gbIO.Controls.Add(Me.cmdED6_8)
        Me.gbIO.Controls.Add(Me.cmdED6_23)
        Me.gbIO.Controls.Add(Me.cmdED6_15)
        Me.gbIO.Controls.Add(Me.cmdED6_30)
        Me.gbIO.Controls.Add(Me.cmdED6_7)
        Me.gbIO.Controls.Add(Me.cmdED6_22)
        Me.gbIO.Controls.Add(Me.cmdED6_14)
        Me.gbIO.Controls.Add(Me.cmdED6_29)
        Me.gbIO.Controls.Add(Me.cmdED6_6)
        Me.gbIO.Controls.Add(Me.cmdED6_21)
        Me.gbIO.Controls.Add(Me.cmdED6_13)
        Me.gbIO.Controls.Add(Me.cmdED6_28)
        Me.gbIO.Controls.Add(Me.cmdED6_5)
        Me.gbIO.Controls.Add(Me.cmdED6_20)
        Me.gbIO.Controls.Add(Me.cmdED6_12)
        Me.gbIO.Controls.Add(Me.cmdED6_27)
        Me.gbIO.Controls.Add(Me.cmdED6_4)
        Me.gbIO.Controls.Add(Me.cmdED6_19)
        Me.gbIO.Controls.Add(Me.cmdED6_11)
        Me.gbIO.Controls.Add(Me.cmdED6_26)
        Me.gbIO.Controls.Add(Me.cmdED6_3)
        Me.gbIO.Controls.Add(Me.cmdED6_18)
        Me.gbIO.Controls.Add(Me.cmdED6_10)
        Me.gbIO.Controls.Add(Me.cmdED6_25)
        Me.gbIO.Controls.Add(Me.cmdED6_2)
        Me.gbIO.Controls.Add(Me.cmdED6_17)
        Me.gbIO.Controls.Add(Me.cmdED6_9)
        Me.gbIO.Controls.Add(Me.cmdED6_1)
        Me.gbIO.Controls.Add(Me.tbSD5_16)
        Me.gbIO.Controls.Add(Me.tbSD5_15)
        Me.gbIO.Controls.Add(Me.tbSD5_14)
        Me.gbIO.Controls.Add(Me.tbSD5_13)
        Me.gbIO.Controls.Add(Me.tbSD5_12)
        Me.gbIO.Controls.Add(Me.tbSD5_11)
        Me.gbIO.Controls.Add(Me.tbSD5_10)
        Me.gbIO.Controls.Add(Me.tbSD5_9)
        Me.gbIO.Controls.Add(Me.tbSD5_8)
        Me.gbIO.Controls.Add(Me.tbSD5_7)
        Me.gbIO.Controls.Add(Me.tbSD5_6)
        Me.gbIO.Controls.Add(Me.tbSD5_5)
        Me.gbIO.Controls.Add(Me.tbSD5_4)
        Me.gbIO.Controls.Add(Me.tbSD5_3)
        Me.gbIO.Controls.Add(Me.tbSD5_2)
        Me.gbIO.Controls.Add(Me.tbSD5_1)
        Me.gbIO.Controls.Add(Me.lbED5_32)
        Me.gbIO.Controls.Add(Me.lbED5_31)
        Me.gbIO.Controls.Add(Me.lbED5_16)
        Me.gbIO.Controls.Add(Me.lbED5_24)
        Me.gbIO.Controls.Add(Me.lbED5_15)
        Me.gbIO.Controls.Add(Me.lbED5_28)
        Me.gbIO.Controls.Add(Me.lbED5_8)
        Me.gbIO.Controls.Add(Me.lbED5_23)
        Me.gbIO.Controls.Add(Me.lbED5_12)
        Me.gbIO.Controls.Add(Me.lbED5_30)
        Me.gbIO.Controls.Add(Me.lbED5_7)
        Me.gbIO.Controls.Add(Me.lbED5_20)
        Me.gbIO.Controls.Add(Me.lbED5_14)
        Me.gbIO.Controls.Add(Me.lbED5_27)
        Me.gbIO.Controls.Add(Me.lbED5_4)
        Me.gbIO.Controls.Add(Me.lbED5_22)
        Me.gbIO.Controls.Add(Me.lbED5_11)
        Me.gbIO.Controls.Add(Me.lbED5_29)
        Me.gbIO.Controls.Add(Me.lbED5_6)
        Me.gbIO.Controls.Add(Me.lbED5_19)
        Me.gbIO.Controls.Add(Me.lbED5_13)
        Me.gbIO.Controls.Add(Me.lbED5_26)
        Me.gbIO.Controls.Add(Me.lbED5_3)
        Me.gbIO.Controls.Add(Me.lbED5_21)
        Me.gbIO.Controls.Add(Me.lbED5_10)
        Me.gbIO.Controls.Add(Me.lbED5_25)
        Me.gbIO.Controls.Add(Me.lbED5_5)
        Me.gbIO.Controls.Add(Me.lbED5_18)
        Me.gbIO.Controls.Add(Me.lbED5_9)
        Me.gbIO.Controls.Add(Me.lbED5_17)
        Me.gbIO.Controls.Add(Me.lbED5_2)
        Me.gbIO.Controls.Add(Me.lbED5_1)
        Me.gbIO.Controls.Add(Me.cmdED5_1)
        Me.gbIO.Controls.Add(Me.cmdED5_9)
        Me.gbIO.Controls.Add(Me.cmdED5_17)
        Me.gbIO.Controls.Add(Me.cmdED5_2)
        Me.gbIO.Controls.Add(Me.cmdED5_25)
        Me.gbIO.Controls.Add(Me.cmdED5_10)
        Me.gbIO.Controls.Add(Me.cmdED5_18)
        Me.gbIO.Controls.Add(Me.cmdED5_3)
        Me.gbIO.Controls.Add(Me.cmdED5_26)
        Me.gbIO.Controls.Add(Me.cmdED5_11)
        Me.gbIO.Controls.Add(Me.cmdED5_19)
        Me.gbIO.Controls.Add(Me.cmdED5_32)
        Me.gbIO.Controls.Add(Me.cmdED5_24)
        Me.gbIO.Controls.Add(Me.cmdED5_4)
        Me.gbIO.Controls.Add(Me.cmdED5_27)
        Me.gbIO.Controls.Add(Me.cmdED5_16)
        Me.gbIO.Controls.Add(Me.cmdED5_12)
        Me.gbIO.Controls.Add(Me.cmdED5_31)
        Me.gbIO.Controls.Add(Me.cmdED5_20)
        Me.gbIO.Controls.Add(Me.cmdED5_8)
        Me.gbIO.Controls.Add(Me.cmdED5_5)
        Me.gbIO.Controls.Add(Me.cmdED5_23)
        Me.gbIO.Controls.Add(Me.cmdED5_28)
        Me.gbIO.Controls.Add(Me.cmdED5_15)
        Me.gbIO.Controls.Add(Me.cmdED5_13)
        Me.gbIO.Controls.Add(Me.cmdED5_30)
        Me.gbIO.Controls.Add(Me.cmdED5_21)
        Me.gbIO.Controls.Add(Me.cmdED5_7)
        Me.gbIO.Controls.Add(Me.cmdED5_6)
        Me.gbIO.Controls.Add(Me.cmdED5_22)
        Me.gbIO.Controls.Add(Me.cmdED5_29)
        Me.gbIO.Controls.Add(Me.cmdED5_14)
        Me.gbIO.Controls.Add(Me.tbSD4_16)
        Me.gbIO.Controls.Add(Me.tbSD4_15)
        Me.gbIO.Controls.Add(Me.tbSD4_14)
        Me.gbIO.Controls.Add(Me.tbSD4_13)
        Me.gbIO.Controls.Add(Me.tbSD4_12)
        Me.gbIO.Controls.Add(Me.tbSD4_11)
        Me.gbIO.Controls.Add(Me.tbSD4_10)
        Me.gbIO.Controls.Add(Me.tbSD4_9)
        Me.gbIO.Controls.Add(Me.tbSD4_8)
        Me.gbIO.Controls.Add(Me.tbSD4_7)
        Me.gbIO.Controls.Add(Me.tbSD4_6)
        Me.gbIO.Controls.Add(Me.tbSD4_5)
        Me.gbIO.Controls.Add(Me.tbSD4_4)
        Me.gbIO.Controls.Add(Me.tbSD4_3)
        Me.gbIO.Controls.Add(Me.tbSD4_2)
        Me.gbIO.Controls.Add(Me.tbSD4_1)
        Me.gbIO.Controls.Add(Me.lbED4_32)
        Me.gbIO.Controls.Add(Me.lbED4_31)
        Me.gbIO.Controls.Add(Me.lbED4_16)
        Me.gbIO.Controls.Add(Me.lbED4_24)
        Me.gbIO.Controls.Add(Me.lbED4_15)
        Me.gbIO.Controls.Add(Me.lbED4_28)
        Me.gbIO.Controls.Add(Me.lbED4_8)
        Me.gbIO.Controls.Add(Me.lbED4_23)
        Me.gbIO.Controls.Add(Me.lbED4_12)
        Me.gbIO.Controls.Add(Me.lbED4_30)
        Me.gbIO.Controls.Add(Me.lbED4_7)
        Me.gbIO.Controls.Add(Me.lbED4_20)
        Me.gbIO.Controls.Add(Me.lbED4_14)
        Me.gbIO.Controls.Add(Me.lbED4_27)
        Me.gbIO.Controls.Add(Me.lbED4_4)
        Me.gbIO.Controls.Add(Me.lbED4_22)
        Me.gbIO.Controls.Add(Me.lbED4_11)
        Me.gbIO.Controls.Add(Me.lbED4_29)
        Me.gbIO.Controls.Add(Me.lbED4_6)
        Me.gbIO.Controls.Add(Me.lbED4_19)
        Me.gbIO.Controls.Add(Me.lbED4_13)
        Me.gbIO.Controls.Add(Me.lbED4_26)
        Me.gbIO.Controls.Add(Me.lbED4_3)
        Me.gbIO.Controls.Add(Me.lbED4_21)
        Me.gbIO.Controls.Add(Me.lbED4_10)
        Me.gbIO.Controls.Add(Me.lbED4_25)
        Me.gbIO.Controls.Add(Me.lbED4_5)
        Me.gbIO.Controls.Add(Me.lbED4_18)
        Me.gbIO.Controls.Add(Me.lbED4_9)
        Me.gbIO.Controls.Add(Me.lbED4_17)
        Me.gbIO.Controls.Add(Me.lbED4_2)
        Me.gbIO.Controls.Add(Me.lbED4_1)
        Me.gbIO.Controls.Add(Me.cmdED4_1)
        Me.gbIO.Controls.Add(Me.cmdED4_9)
        Me.gbIO.Controls.Add(Me.cmdED4_17)
        Me.gbIO.Controls.Add(Me.cmdED4_2)
        Me.gbIO.Controls.Add(Me.cmdED4_25)
        Me.gbIO.Controls.Add(Me.cmdED4_10)
        Me.gbIO.Controls.Add(Me.cmdED4_18)
        Me.gbIO.Controls.Add(Me.cmdED4_3)
        Me.gbIO.Controls.Add(Me.cmdED4_26)
        Me.gbIO.Controls.Add(Me.cmdED4_11)
        Me.gbIO.Controls.Add(Me.cmdED4_19)
        Me.gbIO.Controls.Add(Me.cmdED4_32)
        Me.gbIO.Controls.Add(Me.cmdED4_4)
        Me.gbIO.Controls.Add(Me.cmdED4_24)
        Me.gbIO.Controls.Add(Me.cmdED4_27)
        Me.gbIO.Controls.Add(Me.cmdED4_16)
        Me.gbIO.Controls.Add(Me.cmdED4_12)
        Me.gbIO.Controls.Add(Me.cmdED4_31)
        Me.gbIO.Controls.Add(Me.cmdED4_20)
        Me.gbIO.Controls.Add(Me.cmdED4_8)
        Me.gbIO.Controls.Add(Me.cmdED4_5)
        Me.gbIO.Controls.Add(Me.cmdED4_23)
        Me.gbIO.Controls.Add(Me.cmdED4_28)
        Me.gbIO.Controls.Add(Me.cmdED4_15)
        Me.gbIO.Controls.Add(Me.cmdED4_13)
        Me.gbIO.Controls.Add(Me.cmdED4_30)
        Me.gbIO.Controls.Add(Me.cmdED4_21)
        Me.gbIO.Controls.Add(Me.cmdED4_7)
        Me.gbIO.Controls.Add(Me.cmdED4_6)
        Me.gbIO.Controls.Add(Me.cmdED4_22)
        Me.gbIO.Controls.Add(Me.cmdED4_29)
        Me.gbIO.Controls.Add(Me.cmdED4_14)
        Me.gbIO.Controls.Add(Me.tbSD3_16)
        Me.gbIO.Controls.Add(Me.tbSD3_15)
        Me.gbIO.Controls.Add(Me.tbSD3_14)
        Me.gbIO.Controls.Add(Me.tbSD3_13)
        Me.gbIO.Controls.Add(Me.tbSD3_12)
        Me.gbIO.Controls.Add(Me.tbSD3_11)
        Me.gbIO.Controls.Add(Me.tbSD3_10)
        Me.gbIO.Controls.Add(Me.tbSD3_9)
        Me.gbIO.Controls.Add(Me.tbSD3_8)
        Me.gbIO.Controls.Add(Me.tbSD3_7)
        Me.gbIO.Controls.Add(Me.tbSD3_6)
        Me.gbIO.Controls.Add(Me.tbSD3_5)
        Me.gbIO.Controls.Add(Me.tbSD3_4)
        Me.gbIO.Controls.Add(Me.tbSD3_3)
        Me.gbIO.Controls.Add(Me.tbSD3_2)
        Me.gbIO.Controls.Add(Me.tbSD3_1)
        Me.gbIO.Controls.Add(Me.lbED3_32)
        Me.gbIO.Controls.Add(Me.lbED3_31)
        Me.gbIO.Controls.Add(Me.lbED3_16)
        Me.gbIO.Controls.Add(Me.lbED3_24)
        Me.gbIO.Controls.Add(Me.lbED3_15)
        Me.gbIO.Controls.Add(Me.lbED3_28)
        Me.gbIO.Controls.Add(Me.lbED3_8)
        Me.gbIO.Controls.Add(Me.lbED3_23)
        Me.gbIO.Controls.Add(Me.lbED3_12)
        Me.gbIO.Controls.Add(Me.lbED3_30)
        Me.gbIO.Controls.Add(Me.lbED3_7)
        Me.gbIO.Controls.Add(Me.lbED3_20)
        Me.gbIO.Controls.Add(Me.lbED3_14)
        Me.gbIO.Controls.Add(Me.lbED3_27)
        Me.gbIO.Controls.Add(Me.lbED3_4)
        Me.gbIO.Controls.Add(Me.lbED3_22)
        Me.gbIO.Controls.Add(Me.lbED3_11)
        Me.gbIO.Controls.Add(Me.lbED3_29)
        Me.gbIO.Controls.Add(Me.lbED3_6)
        Me.gbIO.Controls.Add(Me.lbED3_19)
        Me.gbIO.Controls.Add(Me.lbED3_13)
        Me.gbIO.Controls.Add(Me.lbED3_26)
        Me.gbIO.Controls.Add(Me.lbED3_3)
        Me.gbIO.Controls.Add(Me.lbED3_21)
        Me.gbIO.Controls.Add(Me.lbED3_10)
        Me.gbIO.Controls.Add(Me.lbED3_25)
        Me.gbIO.Controls.Add(Me.lbED3_5)
        Me.gbIO.Controls.Add(Me.lbED3_18)
        Me.gbIO.Controls.Add(Me.lbED3_9)
        Me.gbIO.Controls.Add(Me.lbED3_17)
        Me.gbIO.Controls.Add(Me.lbED3_2)
        Me.gbIO.Controls.Add(Me.lbED3_1)
        Me.gbIO.Controls.Add(Me.cmdED3_1)
        Me.gbIO.Controls.Add(Me.cmdED3_9)
        Me.gbIO.Controls.Add(Me.cmdED3_17)
        Me.gbIO.Controls.Add(Me.cmdED3_2)
        Me.gbIO.Controls.Add(Me.cmdED3_25)
        Me.gbIO.Controls.Add(Me.cmdED3_10)
        Me.gbIO.Controls.Add(Me.cmdED3_18)
        Me.gbIO.Controls.Add(Me.cmdED3_3)
        Me.gbIO.Controls.Add(Me.cmdED3_26)
        Me.gbIO.Controls.Add(Me.cmdED3_11)
        Me.gbIO.Controls.Add(Me.cmdED3_19)
        Me.gbIO.Controls.Add(Me.cmdED3_4)
        Me.gbIO.Controls.Add(Me.cmdED3_32)
        Me.gbIO.Controls.Add(Me.cmdED3_27)
        Me.gbIO.Controls.Add(Me.cmdED3_24)
        Me.gbIO.Controls.Add(Me.cmdED3_12)
        Me.gbIO.Controls.Add(Me.cmdED3_16)
        Me.gbIO.Controls.Add(Me.cmdED3_20)
        Me.gbIO.Controls.Add(Me.cmdED3_31)
        Me.gbIO.Controls.Add(Me.cmdED3_5)
        Me.gbIO.Controls.Add(Me.cmdED3_8)
        Me.gbIO.Controls.Add(Me.cmdED3_28)
        Me.gbIO.Controls.Add(Me.cmdED3_23)
        Me.gbIO.Controls.Add(Me.cmdED3_13)
        Me.gbIO.Controls.Add(Me.cmdED3_15)
        Me.gbIO.Controls.Add(Me.cmdED3_21)
        Me.gbIO.Controls.Add(Me.cmdED3_30)
        Me.gbIO.Controls.Add(Me.cmdED3_6)
        Me.gbIO.Controls.Add(Me.cmdED3_7)
        Me.gbIO.Controls.Add(Me.cmdED3_29)
        Me.gbIO.Controls.Add(Me.cmdED3_22)
        Me.gbIO.Controls.Add(Me.cmdED3_14)
        Me.gbIO.Controls.Add(Me.tbSD2_16)
        Me.gbIO.Controls.Add(Me.tbSD2_15)
        Me.gbIO.Controls.Add(Me.tbSD2_14)
        Me.gbIO.Controls.Add(Me.tbSD2_13)
        Me.gbIO.Controls.Add(Me.tbSD2_12)
        Me.gbIO.Controls.Add(Me.tbSD2_11)
        Me.gbIO.Controls.Add(Me.tbSD2_10)
        Me.gbIO.Controls.Add(Me.tbSD2_9)
        Me.gbIO.Controls.Add(Me.tbSD2_8)
        Me.gbIO.Controls.Add(Me.tbSD2_7)
        Me.gbIO.Controls.Add(Me.tbSD2_6)
        Me.gbIO.Controls.Add(Me.tbSD2_5)
        Me.gbIO.Controls.Add(Me.tbSD2_4)
        Me.gbIO.Controls.Add(Me.tbSD2_3)
        Me.gbIO.Controls.Add(Me.tbSD2_2)
        Me.gbIO.Controls.Add(Me.tbSD2_1)
        Me.gbIO.Controls.Add(Me.lbED2_32)
        Me.gbIO.Controls.Add(Me.lbED2_31)
        Me.gbIO.Controls.Add(Me.lbED2_16)
        Me.gbIO.Controls.Add(Me.lbED2_24)
        Me.gbIO.Controls.Add(Me.lbED2_15)
        Me.gbIO.Controls.Add(Me.lbED2_28)
        Me.gbIO.Controls.Add(Me.lbED2_8)
        Me.gbIO.Controls.Add(Me.lbED2_23)
        Me.gbIO.Controls.Add(Me.lbED2_12)
        Me.gbIO.Controls.Add(Me.lbED2_30)
        Me.gbIO.Controls.Add(Me.lbED2_7)
        Me.gbIO.Controls.Add(Me.lbED2_20)
        Me.gbIO.Controls.Add(Me.lbED2_14)
        Me.gbIO.Controls.Add(Me.lbED2_27)
        Me.gbIO.Controls.Add(Me.lbED2_4)
        Me.gbIO.Controls.Add(Me.lbED2_22)
        Me.gbIO.Controls.Add(Me.lbED2_11)
        Me.gbIO.Controls.Add(Me.lbED2_29)
        Me.gbIO.Controls.Add(Me.lbED2_6)
        Me.gbIO.Controls.Add(Me.lbED2_19)
        Me.gbIO.Controls.Add(Me.lbED2_13)
        Me.gbIO.Controls.Add(Me.lbED2_26)
        Me.gbIO.Controls.Add(Me.lbED2_3)
        Me.gbIO.Controls.Add(Me.lbED2_21)
        Me.gbIO.Controls.Add(Me.lbED2_10)
        Me.gbIO.Controls.Add(Me.lbED2_25)
        Me.gbIO.Controls.Add(Me.lbED2_5)
        Me.gbIO.Controls.Add(Me.lbED2_18)
        Me.gbIO.Controls.Add(Me.lbED2_9)
        Me.gbIO.Controls.Add(Me.lbED2_17)
        Me.gbIO.Controls.Add(Me.lbED2_2)
        Me.gbIO.Controls.Add(Me.lbED2_1)
        Me.gbIO.Controls.Add(Me.cmdED2_1)
        Me.gbIO.Controls.Add(Me.cmdED2_9)
        Me.gbIO.Controls.Add(Me.cmdED2_17)
        Me.gbIO.Controls.Add(Me.cmdED2_2)
        Me.gbIO.Controls.Add(Me.cmdED2_25)
        Me.gbIO.Controls.Add(Me.cmdED2_10)
        Me.gbIO.Controls.Add(Me.cmdED2_18)
        Me.gbIO.Controls.Add(Me.cmdED2_3)
        Me.gbIO.Controls.Add(Me.cmdED2_26)
        Me.gbIO.Controls.Add(Me.cmdED2_11)
        Me.gbIO.Controls.Add(Me.cmdED2_19)
        Me.gbIO.Controls.Add(Me.cmdED2_4)
        Me.gbIO.Controls.Add(Me.cmdED2_27)
        Me.gbIO.Controls.Add(Me.cmdED2_12)
        Me.gbIO.Controls.Add(Me.cmdED2_32)
        Me.gbIO.Controls.Add(Me.cmdED2_20)
        Me.gbIO.Controls.Add(Me.cmdED2_24)
        Me.gbIO.Controls.Add(Me.cmdED2_5)
        Me.gbIO.Controls.Add(Me.cmdED2_16)
        Me.gbIO.Controls.Add(Me.cmdED2_28)
        Me.gbIO.Controls.Add(Me.cmdED2_31)
        Me.gbIO.Controls.Add(Me.cmdED2_13)
        Me.gbIO.Controls.Add(Me.cmdED2_8)
        Me.gbIO.Controls.Add(Me.cmdED2_21)
        Me.gbIO.Controls.Add(Me.cmdED2_23)
        Me.gbIO.Controls.Add(Me.cmdED2_6)
        Me.gbIO.Controls.Add(Me.cmdED2_15)
        Me.gbIO.Controls.Add(Me.cmdED2_29)
        Me.gbIO.Controls.Add(Me.cmdED2_30)
        Me.gbIO.Controls.Add(Me.cmdED2_14)
        Me.gbIO.Controls.Add(Me.cmdED2_7)
        Me.gbIO.Controls.Add(Me.cmdED2_22)
        Me.gbIO.Controls.Add(Me.tbSD1_16)
        Me.gbIO.Controls.Add(Me.tbSD1_15)
        Me.gbIO.Controls.Add(Me.tbSD1_14)
        Me.gbIO.Controls.Add(Me.tbSD1_13)
        Me.gbIO.Controls.Add(Me.tbSD1_12)
        Me.gbIO.Controls.Add(Me.tbSD1_11)
        Me.gbIO.Controls.Add(Me.tbSD1_10)
        Me.gbIO.Controls.Add(Me.tbSD1_9)
        Me.gbIO.Controls.Add(Me.tbSD1_8)
        Me.gbIO.Controls.Add(Me.tbSD1_7)
        Me.gbIO.Controls.Add(Me.tbSD1_6)
        Me.gbIO.Controls.Add(Me.tbSD1_5)
        Me.gbIO.Controls.Add(Me.tbSD1_4)
        Me.gbIO.Controls.Add(Me.tbSD1_3)
        Me.gbIO.Controls.Add(Me.tbSD1_2)
        Me.gbIO.Controls.Add(Me.tbSD1_1)
        Me.gbIO.Controls.Add(Me.lbED1_32)
        Me.gbIO.Controls.Add(Me.lbED1_31)
        Me.gbIO.Controls.Add(Me.lbED1_16)
        Me.gbIO.Controls.Add(Me.lbED1_24)
        Me.gbIO.Controls.Add(Me.lbED1_15)
        Me.gbIO.Controls.Add(Me.lbED1_28)
        Me.gbIO.Controls.Add(Me.lbED1_8)
        Me.gbIO.Controls.Add(Me.lbED1_23)
        Me.gbIO.Controls.Add(Me.lbED1_12)
        Me.gbIO.Controls.Add(Me.lbED1_30)
        Me.gbIO.Controls.Add(Me.lbED1_7)
        Me.gbIO.Controls.Add(Me.lbED1_20)
        Me.gbIO.Controls.Add(Me.lbED1_14)
        Me.gbIO.Controls.Add(Me.lbED1_27)
        Me.gbIO.Controls.Add(Me.lbED1_4)
        Me.gbIO.Controls.Add(Me.lbED1_22)
        Me.gbIO.Controls.Add(Me.lbED1_11)
        Me.gbIO.Controls.Add(Me.lbED1_29)
        Me.gbIO.Controls.Add(Me.lbED1_6)
        Me.gbIO.Controls.Add(Me.lbED1_19)
        Me.gbIO.Controls.Add(Me.lbED1_13)
        Me.gbIO.Controls.Add(Me.lbED1_26)
        Me.gbIO.Controls.Add(Me.lbED1_3)
        Me.gbIO.Controls.Add(Me.lbED1_21)
        Me.gbIO.Controls.Add(Me.lbED1_10)
        Me.gbIO.Controls.Add(Me.lbED1_25)
        Me.gbIO.Controls.Add(Me.lbED1_5)
        Me.gbIO.Controls.Add(Me.lbED1_18)
        Me.gbIO.Controls.Add(Me.lbED1_9)
        Me.gbIO.Controls.Add(Me.lbED1_17)
        Me.gbIO.Controls.Add(Me.lbED1_2)
        Me.gbIO.Controls.Add(Me.lbED1_1)
        Me.gbIO.Controls.Add(Me.cmdED1_1)
        Me.gbIO.Controls.Add(Me.cmdED1_9)
        Me.gbIO.Controls.Add(Me.cmdED1_17)
        Me.gbIO.Controls.Add(Me.cmdED1_2)
        Me.gbIO.Controls.Add(Me.cmdED1_25)
        Me.gbIO.Controls.Add(Me.cmdED1_10)
        Me.gbIO.Controls.Add(Me.cmdED1_18)
        Me.gbIO.Controls.Add(Me.cmdED1_3)
        Me.gbIO.Controls.Add(Me.cmdED1_26)
        Me.gbIO.Controls.Add(Me.cmdED1_11)
        Me.gbIO.Controls.Add(Me.cmdED1_19)
        Me.gbIO.Controls.Add(Me.cmdED1_4)
        Me.gbIO.Controls.Add(Me.cmdED1_27)
        Me.gbIO.Controls.Add(Me.cmdED1_12)
        Me.gbIO.Controls.Add(Me.cmdED1_20)
        Me.gbIO.Controls.Add(Me.cmdED1_5)
        Me.gbIO.Controls.Add(Me.cmdED1_28)
        Me.gbIO.Controls.Add(Me.cmdED1_13)
        Me.gbIO.Controls.Add(Me.cmdED1_21)
        Me.gbIO.Controls.Add(Me.cmdED1_6)
        Me.gbIO.Controls.Add(Me.cmdED1_29)
        Me.gbIO.Controls.Add(Me.cmdED1_14)
        Me.gbIO.Controls.Add(Me.cmdED1_22)
        Me.gbIO.Controls.Add(Me.cmdED1_7)
        Me.gbIO.Controls.Add(Me.cmdED1_30)
        Me.gbIO.Controls.Add(Me.cmdED1_15)
        Me.gbIO.Controls.Add(Me.cmdED1_23)
        Me.gbIO.Controls.Add(Me.cmdED1_8)
        Me.gbIO.Controls.Add(Me.cmdED1_31)
        Me.gbIO.Controls.Add(Me.cmdED1_16)
        Me.gbIO.Controls.Add(Me.cmdED1_24)
        Me.gbIO.Controls.Add(Me.cmdED1_32)
        Me.gbIO.Controls.Add(Me.lbT4)
        Me.gbIO.Controls.Add(Me.lbT7)
        Me.gbIO.Controls.Add(Me.lbT6)
        Me.gbIO.Controls.Add(Me.lbT5)
        Me.gbIO.Controls.Add(Me.lbT3)
        Me.gbIO.Controls.Add(Me.lbT2)
        Me.gbIO.Controls.Add(Me.lbT1)
        Me.gbIO.Location = New System.Drawing.Point(9, 122)
        Me.gbIO.Name = "gbIO"
        Me.gbIO.Size = New System.Drawing.Size(1250, 620)
        Me.gbIO.TabIndex = 6
        Me.gbIO.TabStop = False
        Me.gbIO.Text = "ENTRADAS DIGITALES"
        '
        'tbSD7_16
        '
        Me.tbSD7_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_16.Enabled = False
        Me.tbSD7_16.Location = New System.Drawing.Point(1125, 307)
        Me.tbSD7_16.MaxLength = 15
        Me.tbSD7_16.Name = "tbSD7_16"
        Me.tbSD7_16.ReadOnly = True
        Me.tbSD7_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_16.TabIndex = 224
        Me.tbSD7_16.Text = "SD7_16"
        Me.tbSD7_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_15
        '
        Me.tbSD7_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_15.Enabled = False
        Me.tbSD7_15.Location = New System.Drawing.Point(1125, 289)
        Me.tbSD7_15.MaxLength = 15
        Me.tbSD7_15.Name = "tbSD7_15"
        Me.tbSD7_15.ReadOnly = True
        Me.tbSD7_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_15.TabIndex = 225
        Me.tbSD7_15.Text = "SD7_15"
        Me.tbSD7_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_14
        '
        Me.tbSD7_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_14.Enabled = False
        Me.tbSD7_14.Location = New System.Drawing.Point(1125, 271)
        Me.tbSD7_14.MaxLength = 15
        Me.tbSD7_14.Name = "tbSD7_14"
        Me.tbSD7_14.ReadOnly = True
        Me.tbSD7_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_14.TabIndex = 226
        Me.tbSD7_14.Text = "SD7_14"
        Me.tbSD7_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_13
        '
        Me.tbSD7_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_13.Enabled = False
        Me.tbSD7_13.Location = New System.Drawing.Point(1125, 252)
        Me.tbSD7_13.MaxLength = 15
        Me.tbSD7_13.Name = "tbSD7_13"
        Me.tbSD7_13.ReadOnly = True
        Me.tbSD7_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_13.TabIndex = 227
        Me.tbSD7_13.Text = "SD7_13"
        Me.tbSD7_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_12
        '
        Me.tbSD7_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_12.Enabled = False
        Me.tbSD7_12.Location = New System.Drawing.Point(1125, 235)
        Me.tbSD7_12.MaxLength = 15
        Me.tbSD7_12.Name = "tbSD7_12"
        Me.tbSD7_12.ReadOnly = True
        Me.tbSD7_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_12.TabIndex = 228
        Me.tbSD7_12.Text = "SD7_12"
        Me.tbSD7_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_11
        '
        Me.tbSD7_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_11.Enabled = False
        Me.tbSD7_11.Location = New System.Drawing.Point(1125, 217)
        Me.tbSD7_11.MaxLength = 15
        Me.tbSD7_11.Name = "tbSD7_11"
        Me.tbSD7_11.ReadOnly = True
        Me.tbSD7_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_11.TabIndex = 229
        Me.tbSD7_11.Text = "SD7_11"
        Me.tbSD7_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_10
        '
        Me.tbSD7_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_10.Enabled = False
        Me.tbSD7_10.Location = New System.Drawing.Point(1125, 198)
        Me.tbSD7_10.MaxLength = 15
        Me.tbSD7_10.Name = "tbSD7_10"
        Me.tbSD7_10.ReadOnly = True
        Me.tbSD7_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_10.TabIndex = 230
        Me.tbSD7_10.Text = "SD7_10"
        Me.tbSD7_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_9
        '
        Me.tbSD7_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_9.Enabled = False
        Me.tbSD7_9.Location = New System.Drawing.Point(1125, 181)
        Me.tbSD7_9.MaxLength = 15
        Me.tbSD7_9.Name = "tbSD7_9"
        Me.tbSD7_9.ReadOnly = True
        Me.tbSD7_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_9.TabIndex = 231
        Me.tbSD7_9.Text = "SD7_9"
        Me.tbSD7_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_8
        '
        Me.tbSD7_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_8.Enabled = False
        Me.tbSD7_8.Location = New System.Drawing.Point(1125, 163)
        Me.tbSD7_8.MaxLength = 15
        Me.tbSD7_8.Name = "tbSD7_8"
        Me.tbSD7_8.ReadOnly = True
        Me.tbSD7_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_8.TabIndex = 232
        Me.tbSD7_8.Text = "SD7_8"
        Me.tbSD7_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_7
        '
        Me.tbSD7_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_7.Enabled = False
        Me.tbSD7_7.Location = New System.Drawing.Point(1125, 145)
        Me.tbSD7_7.MaxLength = 15
        Me.tbSD7_7.Name = "tbSD7_7"
        Me.tbSD7_7.ReadOnly = True
        Me.tbSD7_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_7.TabIndex = 233
        Me.tbSD7_7.Text = "SD7_7"
        Me.tbSD7_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_6
        '
        Me.tbSD7_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_6.Enabled = False
        Me.tbSD7_6.Location = New System.Drawing.Point(1125, 127)
        Me.tbSD7_6.MaxLength = 15
        Me.tbSD7_6.Name = "tbSD7_6"
        Me.tbSD7_6.ReadOnly = True
        Me.tbSD7_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_6.TabIndex = 234
        Me.tbSD7_6.Text = "SD7_6"
        Me.tbSD7_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_5
        '
        Me.tbSD7_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_5.Enabled = False
        Me.tbSD7_5.Location = New System.Drawing.Point(1125, 109)
        Me.tbSD7_5.MaxLength = 15
        Me.tbSD7_5.Name = "tbSD7_5"
        Me.tbSD7_5.ReadOnly = True
        Me.tbSD7_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_5.TabIndex = 235
        Me.tbSD7_5.Text = "SD7_5"
        Me.tbSD7_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_4
        '
        Me.tbSD7_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_4.Enabled = False
        Me.tbSD7_4.Location = New System.Drawing.Point(1125, 90)
        Me.tbSD7_4.MaxLength = 15
        Me.tbSD7_4.Name = "tbSD7_4"
        Me.tbSD7_4.ReadOnly = True
        Me.tbSD7_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_4.TabIndex = 236
        Me.tbSD7_4.Text = "SD7_4"
        Me.tbSD7_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_3
        '
        Me.tbSD7_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_3.Enabled = False
        Me.tbSD7_3.Location = New System.Drawing.Point(1125, 73)
        Me.tbSD7_3.MaxLength = 15
        Me.tbSD7_3.Name = "tbSD7_3"
        Me.tbSD7_3.ReadOnly = True
        Me.tbSD7_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_3.TabIndex = 237
        Me.tbSD7_3.Text = "SD7_3"
        Me.tbSD7_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_2
        '
        Me.tbSD7_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_2.Enabled = False
        Me.tbSD7_2.Location = New System.Drawing.Point(1125, 55)
        Me.tbSD7_2.MaxLength = 15
        Me.tbSD7_2.Name = "tbSD7_2"
        Me.tbSD7_2.ReadOnly = True
        Me.tbSD7_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_2.TabIndex = 238
        Me.tbSD7_2.Text = "SD7_2"
        Me.tbSD7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD7_1
        '
        Me.tbSD7_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD7_1.Enabled = False
        Me.tbSD7_1.Location = New System.Drawing.Point(1125, 38)
        Me.tbSD7_1.MaxLength = 15
        Me.tbSD7_1.Name = "tbSD7_1"
        Me.tbSD7_1.ReadOnly = True
        Me.tbSD7_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD7_1.TabIndex = 239
        Me.tbSD7_1.Text = "SD7_1"
        Me.tbSD7_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED7_32
        '
        Me.lbED7_32.AutoSize = True
        Me.lbED7_32.Location = New System.Drawing.Point(1081, 599)
        Me.lbED7_32.Name = "lbED7_32"
        Me.lbED7_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_32.TabIndex = 4
        Me.lbED7_32.Text = "ED7_32"
        '
        'lbED7_31
        '
        Me.lbED7_31.AutoSize = True
        Me.lbED7_31.Location = New System.Drawing.Point(1081, 581)
        Me.lbED7_31.Name = "lbED7_31"
        Me.lbED7_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_31.TabIndex = 4
        Me.lbED7_31.Text = "ED7_31"
        '
        'lbED7_16
        '
        Me.lbED7_16.AutoSize = True
        Me.lbED7_16.Location = New System.Drawing.Point(1081, 310)
        Me.lbED7_16.Name = "lbED7_16"
        Me.lbED7_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_16.TabIndex = 4
        Me.lbED7_16.Text = "ED7_16"
        '
        'lbED7_24
        '
        Me.lbED7_24.AutoSize = True
        Me.lbED7_24.Location = New System.Drawing.Point(1081, 454)
        Me.lbED7_24.Name = "lbED7_24"
        Me.lbED7_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_24.TabIndex = 4
        Me.lbED7_24.Text = "ED7_24"
        '
        'lbED7_15
        '
        Me.lbED7_15.AutoSize = True
        Me.lbED7_15.Location = New System.Drawing.Point(1081, 292)
        Me.lbED7_15.Name = "lbED7_15"
        Me.lbED7_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_15.TabIndex = 4
        Me.lbED7_15.Text = "ED7_15"
        '
        'lbED7_28
        '
        Me.lbED7_28.AutoSize = True
        Me.lbED7_28.Location = New System.Drawing.Point(1081, 526)
        Me.lbED7_28.Name = "lbED7_28"
        Me.lbED7_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_28.TabIndex = 4
        Me.lbED7_28.Text = "ED7_28"
        '
        'lbED7_8
        '
        Me.lbED7_8.AutoSize = True
        Me.lbED7_8.Location = New System.Drawing.Point(1081, 166)
        Me.lbED7_8.Name = "lbED7_8"
        Me.lbED7_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_8.TabIndex = 4
        Me.lbED7_8.Text = "ED7_8"
        '
        'lbED7_23
        '
        Me.lbED7_23.AutoSize = True
        Me.lbED7_23.Location = New System.Drawing.Point(1081, 436)
        Me.lbED7_23.Name = "lbED7_23"
        Me.lbED7_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_23.TabIndex = 4
        Me.lbED7_23.Text = "ED7_23"
        '
        'lbED7_12
        '
        Me.lbED7_12.AutoSize = True
        Me.lbED7_12.Location = New System.Drawing.Point(1081, 238)
        Me.lbED7_12.Name = "lbED7_12"
        Me.lbED7_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_12.TabIndex = 4
        Me.lbED7_12.Text = "ED7_12"
        '
        'lbED7_30
        '
        Me.lbED7_30.AutoSize = True
        Me.lbED7_30.Location = New System.Drawing.Point(1081, 562)
        Me.lbED7_30.Name = "lbED7_30"
        Me.lbED7_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_30.TabIndex = 4
        Me.lbED7_30.Text = "ED7_30"
        '
        'lbED7_7
        '
        Me.lbED7_7.AutoSize = True
        Me.lbED7_7.Location = New System.Drawing.Point(1081, 148)
        Me.lbED7_7.Name = "lbED7_7"
        Me.lbED7_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_7.TabIndex = 4
        Me.lbED7_7.Text = "ED7_7"
        '
        'lbED7_20
        '
        Me.lbED7_20.AutoSize = True
        Me.lbED7_20.Location = New System.Drawing.Point(1081, 382)
        Me.lbED7_20.Name = "lbED7_20"
        Me.lbED7_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_20.TabIndex = 4
        Me.lbED7_20.Text = "ED7_20"
        '
        'lbED7_14
        '
        Me.lbED7_14.AutoSize = True
        Me.lbED7_14.Location = New System.Drawing.Point(1081, 274)
        Me.lbED7_14.Name = "lbED7_14"
        Me.lbED7_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_14.TabIndex = 4
        Me.lbED7_14.Text = "ED7_14"
        '
        'lbED7_27
        '
        Me.lbED7_27.AutoSize = True
        Me.lbED7_27.Location = New System.Drawing.Point(1081, 508)
        Me.lbED7_27.Name = "lbED7_27"
        Me.lbED7_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_27.TabIndex = 4
        Me.lbED7_27.Text = "ED7_27"
        '
        'lbED7_4
        '
        Me.lbED7_4.AutoSize = True
        Me.lbED7_4.Location = New System.Drawing.Point(1081, 94)
        Me.lbED7_4.Name = "lbED7_4"
        Me.lbED7_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_4.TabIndex = 4
        Me.lbED7_4.Text = "ED7_4"
        '
        'lbED7_22
        '
        Me.lbED7_22.AutoSize = True
        Me.lbED7_22.Location = New System.Drawing.Point(1081, 418)
        Me.lbED7_22.Name = "lbED7_22"
        Me.lbED7_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_22.TabIndex = 4
        Me.lbED7_22.Text = "ED7_22"
        '
        'lbED7_11
        '
        Me.lbED7_11.AutoSize = True
        Me.lbED7_11.Location = New System.Drawing.Point(1081, 220)
        Me.lbED7_11.Name = "lbED7_11"
        Me.lbED7_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_11.TabIndex = 4
        Me.lbED7_11.Text = "ED7_11"
        '
        'lbED7_29
        '
        Me.lbED7_29.AutoSize = True
        Me.lbED7_29.Location = New System.Drawing.Point(1081, 544)
        Me.lbED7_29.Name = "lbED7_29"
        Me.lbED7_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_29.TabIndex = 4
        Me.lbED7_29.Text = "ED7_29"
        '
        'lbED7_6
        '
        Me.lbED7_6.AutoSize = True
        Me.lbED7_6.Location = New System.Drawing.Point(1081, 130)
        Me.lbED7_6.Name = "lbED7_6"
        Me.lbED7_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_6.TabIndex = 4
        Me.lbED7_6.Text = "ED7_6"
        '
        'lbED7_19
        '
        Me.lbED7_19.AutoSize = True
        Me.lbED7_19.Location = New System.Drawing.Point(1081, 364)
        Me.lbED7_19.Name = "lbED7_19"
        Me.lbED7_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_19.TabIndex = 4
        Me.lbED7_19.Text = "ED7_19"
        '
        'lbED7_13
        '
        Me.lbED7_13.AutoSize = True
        Me.lbED7_13.Location = New System.Drawing.Point(1081, 256)
        Me.lbED7_13.Name = "lbED7_13"
        Me.lbED7_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_13.TabIndex = 4
        Me.lbED7_13.Text = "ED7_13"
        '
        'lbED7_26
        '
        Me.lbED7_26.AutoSize = True
        Me.lbED7_26.Location = New System.Drawing.Point(1081, 490)
        Me.lbED7_26.Name = "lbED7_26"
        Me.lbED7_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_26.TabIndex = 4
        Me.lbED7_26.Text = "ED7_26"
        '
        'lbED7_3
        '
        Me.lbED7_3.AutoSize = True
        Me.lbED7_3.Location = New System.Drawing.Point(1081, 76)
        Me.lbED7_3.Name = "lbED7_3"
        Me.lbED7_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_3.TabIndex = 4
        Me.lbED7_3.Text = "ED7_3"
        '
        'lbED7_21
        '
        Me.lbED7_21.AutoSize = True
        Me.lbED7_21.Location = New System.Drawing.Point(1081, 400)
        Me.lbED7_21.Name = "lbED7_21"
        Me.lbED7_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_21.TabIndex = 4
        Me.lbED7_21.Text = "ED7_21"
        '
        'lbED7_10
        '
        Me.lbED7_10.AutoSize = True
        Me.lbED7_10.Location = New System.Drawing.Point(1081, 202)
        Me.lbED7_10.Name = "lbED7_10"
        Me.lbED7_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_10.TabIndex = 4
        Me.lbED7_10.Text = "ED7_10"
        '
        'lbED7_25
        '
        Me.lbED7_25.AutoSize = True
        Me.lbED7_25.Location = New System.Drawing.Point(1081, 472)
        Me.lbED7_25.Name = "lbED7_25"
        Me.lbED7_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_25.TabIndex = 4
        Me.lbED7_25.Text = "ED7_25"
        '
        'lbED7_5
        '
        Me.lbED7_5.AutoSize = True
        Me.lbED7_5.Location = New System.Drawing.Point(1081, 112)
        Me.lbED7_5.Name = "lbED7_5"
        Me.lbED7_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_5.TabIndex = 4
        Me.lbED7_5.Text = "ED7_5"
        '
        'lbED7_18
        '
        Me.lbED7_18.AutoSize = True
        Me.lbED7_18.Location = New System.Drawing.Point(1081, 346)
        Me.lbED7_18.Name = "lbED7_18"
        Me.lbED7_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_18.TabIndex = 4
        Me.lbED7_18.Text = "ED7_18"
        '
        'lbED7_9
        '
        Me.lbED7_9.AutoSize = True
        Me.lbED7_9.Location = New System.Drawing.Point(1081, 184)
        Me.lbED7_9.Name = "lbED7_9"
        Me.lbED7_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_9.TabIndex = 4
        Me.lbED7_9.Text = "ED7_9"
        '
        'lbED7_17
        '
        Me.lbED7_17.AutoSize = True
        Me.lbED7_17.Location = New System.Drawing.Point(1081, 328)
        Me.lbED7_17.Name = "lbED7_17"
        Me.lbED7_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED7_17.TabIndex = 4
        Me.lbED7_17.Text = "ED7_17"
        '
        'lbED7_2
        '
        Me.lbED7_2.AutoSize = True
        Me.lbED7_2.Location = New System.Drawing.Point(1081, 58)
        Me.lbED7_2.Name = "lbED7_2"
        Me.lbED7_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_2.TabIndex = 4
        Me.lbED7_2.Text = "ED7_2"
        '
        'lbED7_1
        '
        Me.lbED7_1.AutoSize = True
        Me.lbED7_1.Location = New System.Drawing.Point(1081, 40)
        Me.lbED7_1.Name = "lbED7_1"
        Me.lbED7_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED7_1.TabIndex = 4
        Me.lbED7_1.Text = "ED7_1"
        '
        'cmdED7_32
        '
        Me.cmdED7_32.AccessibleDescription = ""
        Me.cmdED7_32.Location = New System.Drawing.Point(1029, 595)
        Me.cmdED7_32.Name = "cmdED7_32"
        Me.cmdED7_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_32.TabIndex = 223
        Me.cmdED7_32.Text = "ED7_32"
        Me.cmdED7_32.UseVisualStyleBackColor = True
        '
        'cmdED7_24
        '
        Me.cmdED7_24.AccessibleDescription = ""
        Me.cmdED7_24.Location = New System.Drawing.Point(1029, 451)
        Me.cmdED7_24.Name = "cmdED7_24"
        Me.cmdED7_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_24.TabIndex = 215
        Me.cmdED7_24.Text = "ED7_24"
        Me.cmdED7_24.UseVisualStyleBackColor = True
        '
        'cmdED7_16
        '
        Me.cmdED7_16.AccessibleDescription = ""
        Me.cmdED7_16.Location = New System.Drawing.Point(1029, 307)
        Me.cmdED7_16.Name = "cmdED7_16"
        Me.cmdED7_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_16.TabIndex = 207
        Me.cmdED7_16.Text = "ED7_16"
        Me.cmdED7_16.UseVisualStyleBackColor = True
        '
        'cmdED7_31
        '
        Me.cmdED7_31.AccessibleDescription = ""
        Me.cmdED7_31.Location = New System.Drawing.Point(1029, 577)
        Me.cmdED7_31.Name = "cmdED7_31"
        Me.cmdED7_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_31.TabIndex = 222
        Me.cmdED7_31.Text = "ED7_31"
        Me.cmdED7_31.UseVisualStyleBackColor = True
        '
        'cmdED7_8
        '
        Me.cmdED7_8.AccessibleDescription = ""
        Me.cmdED7_8.Location = New System.Drawing.Point(1029, 163)
        Me.cmdED7_8.Name = "cmdED7_8"
        Me.cmdED7_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_8.TabIndex = 199
        Me.cmdED7_8.Text = "ED7_8"
        Me.cmdED7_8.UseVisualStyleBackColor = True
        '
        'cmdED7_23
        '
        Me.cmdED7_23.AccessibleDescription = ""
        Me.cmdED7_23.Location = New System.Drawing.Point(1029, 433)
        Me.cmdED7_23.Name = "cmdED7_23"
        Me.cmdED7_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_23.TabIndex = 214
        Me.cmdED7_23.Text = "ED7_23"
        Me.cmdED7_23.UseVisualStyleBackColor = True
        '
        'cmdED7_15
        '
        Me.cmdED7_15.AccessibleDescription = ""
        Me.cmdED7_15.Location = New System.Drawing.Point(1029, 289)
        Me.cmdED7_15.Name = "cmdED7_15"
        Me.cmdED7_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_15.TabIndex = 206
        Me.cmdED7_15.Text = "ED7_15"
        Me.cmdED7_15.UseVisualStyleBackColor = True
        '
        'cmdED7_30
        '
        Me.cmdED7_30.AccessibleDescription = ""
        Me.cmdED7_30.Location = New System.Drawing.Point(1029, 559)
        Me.cmdED7_30.Name = "cmdED7_30"
        Me.cmdED7_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_30.TabIndex = 221
        Me.cmdED7_30.Text = "ED7_30"
        Me.cmdED7_30.UseVisualStyleBackColor = True
        '
        'cmdED7_7
        '
        Me.cmdED7_7.AccessibleDescription = ""
        Me.cmdED7_7.Location = New System.Drawing.Point(1029, 145)
        Me.cmdED7_7.Name = "cmdED7_7"
        Me.cmdED7_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_7.TabIndex = 198
        Me.cmdED7_7.Text = "ED7_7"
        Me.cmdED7_7.UseVisualStyleBackColor = True
        '
        'cmdED7_22
        '
        Me.cmdED7_22.AccessibleDescription = ""
        Me.cmdED7_22.Location = New System.Drawing.Point(1029, 415)
        Me.cmdED7_22.Name = "cmdED7_22"
        Me.cmdED7_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_22.TabIndex = 213
        Me.cmdED7_22.Text = "ED7_22"
        Me.cmdED7_22.UseVisualStyleBackColor = True
        '
        'cmdED7_14
        '
        Me.cmdED7_14.AccessibleDescription = ""
        Me.cmdED7_14.Location = New System.Drawing.Point(1029, 271)
        Me.cmdED7_14.Name = "cmdED7_14"
        Me.cmdED7_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_14.TabIndex = 205
        Me.cmdED7_14.Text = "ED7_14"
        Me.cmdED7_14.UseVisualStyleBackColor = True
        '
        'cmdED7_29
        '
        Me.cmdED7_29.AccessibleDescription = ""
        Me.cmdED7_29.Location = New System.Drawing.Point(1029, 541)
        Me.cmdED7_29.Name = "cmdED7_29"
        Me.cmdED7_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_29.TabIndex = 220
        Me.cmdED7_29.Text = "ED7_29"
        Me.cmdED7_29.UseVisualStyleBackColor = True
        '
        'cmdED7_6
        '
        Me.cmdED7_6.AccessibleDescription = ""
        Me.cmdED7_6.Location = New System.Drawing.Point(1029, 127)
        Me.cmdED7_6.Name = "cmdED7_6"
        Me.cmdED7_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_6.TabIndex = 197
        Me.cmdED7_6.Text = "ED7_6"
        Me.cmdED7_6.UseVisualStyleBackColor = True
        '
        'cmdED7_21
        '
        Me.cmdED7_21.AccessibleDescription = ""
        Me.cmdED7_21.Location = New System.Drawing.Point(1029, 397)
        Me.cmdED7_21.Name = "cmdED7_21"
        Me.cmdED7_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_21.TabIndex = 212
        Me.cmdED7_21.Text = "ED7_21"
        Me.cmdED7_21.UseVisualStyleBackColor = True
        '
        'cmdED7_13
        '
        Me.cmdED7_13.AccessibleDescription = ""
        Me.cmdED7_13.Location = New System.Drawing.Point(1029, 253)
        Me.cmdED7_13.Name = "cmdED7_13"
        Me.cmdED7_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_13.TabIndex = 204
        Me.cmdED7_13.Text = "ED7_13"
        Me.cmdED7_13.UseVisualStyleBackColor = True
        '
        'cmdED7_28
        '
        Me.cmdED7_28.AccessibleDescription = ""
        Me.cmdED7_28.Location = New System.Drawing.Point(1029, 523)
        Me.cmdED7_28.Name = "cmdED7_28"
        Me.cmdED7_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_28.TabIndex = 219
        Me.cmdED7_28.Text = "ED7_28"
        Me.cmdED7_28.UseVisualStyleBackColor = True
        '
        'cmdED7_5
        '
        Me.cmdED7_5.AccessibleDescription = ""
        Me.cmdED7_5.Location = New System.Drawing.Point(1029, 109)
        Me.cmdED7_5.Name = "cmdED7_5"
        Me.cmdED7_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_5.TabIndex = 196
        Me.cmdED7_5.Text = "ED7_5"
        Me.cmdED7_5.UseVisualStyleBackColor = True
        '
        'cmdED7_20
        '
        Me.cmdED7_20.AccessibleDescription = ""
        Me.cmdED7_20.Location = New System.Drawing.Point(1029, 379)
        Me.cmdED7_20.Name = "cmdED7_20"
        Me.cmdED7_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_20.TabIndex = 211
        Me.cmdED7_20.Text = "ED7_20"
        Me.cmdED7_20.UseVisualStyleBackColor = True
        '
        'cmdED7_12
        '
        Me.cmdED7_12.AccessibleDescription = ""
        Me.cmdED7_12.Location = New System.Drawing.Point(1029, 235)
        Me.cmdED7_12.Name = "cmdED7_12"
        Me.cmdED7_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_12.TabIndex = 203
        Me.cmdED7_12.Text = "ED7_12"
        Me.cmdED7_12.UseVisualStyleBackColor = True
        '
        'cmdED7_27
        '
        Me.cmdED7_27.AccessibleDescription = ""
        Me.cmdED7_27.Location = New System.Drawing.Point(1029, 505)
        Me.cmdED7_27.Name = "cmdED7_27"
        Me.cmdED7_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_27.TabIndex = 218
        Me.cmdED7_27.Text = "ED7_27"
        Me.cmdED7_27.UseVisualStyleBackColor = True
        '
        'cmdED7_4
        '
        Me.cmdED7_4.AccessibleDescription = ""
        Me.cmdED7_4.Location = New System.Drawing.Point(1029, 91)
        Me.cmdED7_4.Name = "cmdED7_4"
        Me.cmdED7_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_4.TabIndex = 195
        Me.cmdED7_4.Text = "ED7_4"
        Me.cmdED7_4.UseVisualStyleBackColor = True
        '
        'cmdED7_19
        '
        Me.cmdED7_19.AccessibleDescription = ""
        Me.cmdED7_19.Location = New System.Drawing.Point(1029, 361)
        Me.cmdED7_19.Name = "cmdED7_19"
        Me.cmdED7_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_19.TabIndex = 210
        Me.cmdED7_19.Text = "ED7_19"
        Me.cmdED7_19.UseVisualStyleBackColor = True
        '
        'cmdED7_11
        '
        Me.cmdED7_11.AccessibleDescription = ""
        Me.cmdED7_11.Location = New System.Drawing.Point(1029, 217)
        Me.cmdED7_11.Name = "cmdED7_11"
        Me.cmdED7_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_11.TabIndex = 202
        Me.cmdED7_11.Text = "ED7_11"
        Me.cmdED7_11.UseVisualStyleBackColor = True
        '
        'cmdED7_26
        '
        Me.cmdED7_26.AccessibleDescription = ""
        Me.cmdED7_26.Location = New System.Drawing.Point(1029, 487)
        Me.cmdED7_26.Name = "cmdED7_26"
        Me.cmdED7_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_26.TabIndex = 217
        Me.cmdED7_26.Text = "ED7_26"
        Me.cmdED7_26.UseVisualStyleBackColor = True
        '
        'cmdED7_3
        '
        Me.cmdED7_3.AccessibleDescription = ""
        Me.cmdED7_3.Location = New System.Drawing.Point(1029, 73)
        Me.cmdED7_3.Name = "cmdED7_3"
        Me.cmdED7_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_3.TabIndex = 194
        Me.cmdED7_3.Text = "ED7_3"
        Me.cmdED7_3.UseVisualStyleBackColor = True
        '
        'cmdED7_18
        '
        Me.cmdED7_18.AccessibleDescription = ""
        Me.cmdED7_18.Location = New System.Drawing.Point(1029, 343)
        Me.cmdED7_18.Name = "cmdED7_18"
        Me.cmdED7_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_18.TabIndex = 209
        Me.cmdED7_18.Text = "ED7_18"
        Me.cmdED7_18.UseVisualStyleBackColor = True
        '
        'cmdED7_10
        '
        Me.cmdED7_10.AccessibleDescription = ""
        Me.cmdED7_10.Location = New System.Drawing.Point(1029, 199)
        Me.cmdED7_10.Name = "cmdED7_10"
        Me.cmdED7_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_10.TabIndex = 201
        Me.cmdED7_10.Text = "ED7_10"
        Me.cmdED7_10.UseVisualStyleBackColor = True
        '
        'cmdED7_25
        '
        Me.cmdED7_25.AccessibleDescription = ""
        Me.cmdED7_25.Location = New System.Drawing.Point(1029, 469)
        Me.cmdED7_25.Name = "cmdED7_25"
        Me.cmdED7_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_25.TabIndex = 216
        Me.cmdED7_25.Text = "ED7_25"
        Me.cmdED7_25.UseVisualStyleBackColor = True
        '
        'cmdED7_2
        '
        Me.cmdED7_2.AccessibleDescription = ""
        Me.cmdED7_2.Location = New System.Drawing.Point(1029, 55)
        Me.cmdED7_2.Name = "cmdED7_2"
        Me.cmdED7_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_2.TabIndex = 193
        Me.cmdED7_2.Text = "ED7_2"
        Me.cmdED7_2.UseVisualStyleBackColor = True
        '
        'cmdED7_17
        '
        Me.cmdED7_17.AccessibleDescription = ""
        Me.cmdED7_17.Location = New System.Drawing.Point(1029, 325)
        Me.cmdED7_17.Name = "cmdED7_17"
        Me.cmdED7_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_17.TabIndex = 208
        Me.cmdED7_17.Text = "ED7_17"
        Me.cmdED7_17.UseVisualStyleBackColor = True
        '
        'cmdED7_9
        '
        Me.cmdED7_9.AccessibleDescription = ""
        Me.cmdED7_9.Location = New System.Drawing.Point(1029, 181)
        Me.cmdED7_9.Name = "cmdED7_9"
        Me.cmdED7_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_9.TabIndex = 200
        Me.cmdED7_9.Text = "ED7_9"
        Me.cmdED7_9.UseVisualStyleBackColor = True
        '
        'cmdED7_1
        '
        Me.cmdED7_1.AccessibleDescription = ""
        Me.cmdED7_1.Location = New System.Drawing.Point(1029, 37)
        Me.cmdED7_1.Name = "cmdED7_1"
        Me.cmdED7_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED7_1.TabIndex = 192
        Me.cmdED7_1.Text = "ED7_1"
        Me.cmdED7_1.UseVisualStyleBackColor = True
        '
        'tbSD6_16
        '
        Me.tbSD6_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_16.Enabled = False
        Me.tbSD6_16.Location = New System.Drawing.Point(965, 305)
        Me.tbSD6_16.MaxLength = 15
        Me.tbSD6_16.Name = "tbSD6_16"
        Me.tbSD6_16.ReadOnly = True
        Me.tbSD6_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_16.TabIndex = 224
        Me.tbSD6_16.Text = "SD6_16"
        Me.tbSD6_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_15
        '
        Me.tbSD6_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_15.Enabled = False
        Me.tbSD6_15.Location = New System.Drawing.Point(965, 287)
        Me.tbSD6_15.MaxLength = 15
        Me.tbSD6_15.Name = "tbSD6_15"
        Me.tbSD6_15.ReadOnly = True
        Me.tbSD6_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_15.TabIndex = 225
        Me.tbSD6_15.Text = "SD6_15"
        Me.tbSD6_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_14
        '
        Me.tbSD6_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_14.Enabled = False
        Me.tbSD6_14.Location = New System.Drawing.Point(965, 269)
        Me.tbSD6_14.MaxLength = 15
        Me.tbSD6_14.Name = "tbSD6_14"
        Me.tbSD6_14.ReadOnly = True
        Me.tbSD6_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_14.TabIndex = 226
        Me.tbSD6_14.Text = "SD6_14"
        Me.tbSD6_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_13
        '
        Me.tbSD6_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_13.Enabled = False
        Me.tbSD6_13.Location = New System.Drawing.Point(965, 250)
        Me.tbSD6_13.MaxLength = 15
        Me.tbSD6_13.Name = "tbSD6_13"
        Me.tbSD6_13.ReadOnly = True
        Me.tbSD6_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_13.TabIndex = 227
        Me.tbSD6_13.Text = "SD6_13"
        Me.tbSD6_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_12
        '
        Me.tbSD6_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_12.Enabled = False
        Me.tbSD6_12.Location = New System.Drawing.Point(965, 233)
        Me.tbSD6_12.MaxLength = 15
        Me.tbSD6_12.Name = "tbSD6_12"
        Me.tbSD6_12.ReadOnly = True
        Me.tbSD6_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_12.TabIndex = 228
        Me.tbSD6_12.Text = "SD6_12"
        Me.tbSD6_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_11
        '
        Me.tbSD6_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_11.Enabled = False
        Me.tbSD6_11.Location = New System.Drawing.Point(965, 215)
        Me.tbSD6_11.MaxLength = 15
        Me.tbSD6_11.Name = "tbSD6_11"
        Me.tbSD6_11.ReadOnly = True
        Me.tbSD6_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_11.TabIndex = 229
        Me.tbSD6_11.Text = "SD6_11"
        Me.tbSD6_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_10
        '
        Me.tbSD6_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_10.Enabled = False
        Me.tbSD6_10.Location = New System.Drawing.Point(965, 196)
        Me.tbSD6_10.MaxLength = 15
        Me.tbSD6_10.Name = "tbSD6_10"
        Me.tbSD6_10.ReadOnly = True
        Me.tbSD6_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_10.TabIndex = 230
        Me.tbSD6_10.Text = "SD6_10"
        Me.tbSD6_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_9
        '
        Me.tbSD6_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_9.Enabled = False
        Me.tbSD6_9.Location = New System.Drawing.Point(965, 179)
        Me.tbSD6_9.MaxLength = 15
        Me.tbSD6_9.Name = "tbSD6_9"
        Me.tbSD6_9.ReadOnly = True
        Me.tbSD6_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_9.TabIndex = 231
        Me.tbSD6_9.Text = "SD6_9"
        Me.tbSD6_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_8
        '
        Me.tbSD6_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_8.Enabled = False
        Me.tbSD6_8.Location = New System.Drawing.Point(965, 161)
        Me.tbSD6_8.MaxLength = 15
        Me.tbSD6_8.Name = "tbSD6_8"
        Me.tbSD6_8.ReadOnly = True
        Me.tbSD6_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_8.TabIndex = 232
        Me.tbSD6_8.Text = "SD6_8"
        Me.tbSD6_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_7
        '
        Me.tbSD6_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_7.Enabled = False
        Me.tbSD6_7.Location = New System.Drawing.Point(965, 143)
        Me.tbSD6_7.MaxLength = 15
        Me.tbSD6_7.Name = "tbSD6_7"
        Me.tbSD6_7.ReadOnly = True
        Me.tbSD6_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_7.TabIndex = 233
        Me.tbSD6_7.Text = "SD6_7"
        Me.tbSD6_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_6
        '
        Me.tbSD6_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_6.Enabled = False
        Me.tbSD6_6.Location = New System.Drawing.Point(965, 125)
        Me.tbSD6_6.MaxLength = 15
        Me.tbSD6_6.Name = "tbSD6_6"
        Me.tbSD6_6.ReadOnly = True
        Me.tbSD6_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_6.TabIndex = 234
        Me.tbSD6_6.Text = "SD6_6"
        Me.tbSD6_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_5
        '
        Me.tbSD6_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_5.Enabled = False
        Me.tbSD6_5.Location = New System.Drawing.Point(965, 107)
        Me.tbSD6_5.MaxLength = 15
        Me.tbSD6_5.Name = "tbSD6_5"
        Me.tbSD6_5.ReadOnly = True
        Me.tbSD6_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_5.TabIndex = 235
        Me.tbSD6_5.Text = "SD6_5"
        Me.tbSD6_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_4
        '
        Me.tbSD6_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_4.Enabled = False
        Me.tbSD6_4.Location = New System.Drawing.Point(965, 88)
        Me.tbSD6_4.MaxLength = 15
        Me.tbSD6_4.Name = "tbSD6_4"
        Me.tbSD6_4.ReadOnly = True
        Me.tbSD6_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_4.TabIndex = 236
        Me.tbSD6_4.Text = "SD6_4"
        Me.tbSD6_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_3
        '
        Me.tbSD6_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_3.Enabled = False
        Me.tbSD6_3.Location = New System.Drawing.Point(965, 71)
        Me.tbSD6_3.MaxLength = 15
        Me.tbSD6_3.Name = "tbSD6_3"
        Me.tbSD6_3.ReadOnly = True
        Me.tbSD6_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_3.TabIndex = 237
        Me.tbSD6_3.Text = "SD6_3"
        Me.tbSD6_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_2
        '
        Me.tbSD6_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_2.Enabled = False
        Me.tbSD6_2.Location = New System.Drawing.Point(965, 53)
        Me.tbSD6_2.MaxLength = 15
        Me.tbSD6_2.Name = "tbSD6_2"
        Me.tbSD6_2.ReadOnly = True
        Me.tbSD6_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_2.TabIndex = 238
        Me.tbSD6_2.Text = "SD6_2"
        Me.tbSD6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD6_1
        '
        Me.tbSD6_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD6_1.Enabled = False
        Me.tbSD6_1.Location = New System.Drawing.Point(965, 36)
        Me.tbSD6_1.MaxLength = 15
        Me.tbSD6_1.Name = "tbSD6_1"
        Me.tbSD6_1.ReadOnly = True
        Me.tbSD6_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD6_1.TabIndex = 239
        Me.tbSD6_1.Text = "SD6_1"
        Me.tbSD6_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED6_32
        '
        Me.lbED6_32.AutoSize = True
        Me.lbED6_32.Location = New System.Drawing.Point(911, 595)
        Me.lbED6_32.Name = "lbED6_32"
        Me.lbED6_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_32.TabIndex = 4
        Me.lbED6_32.Text = "ED6_32"
        '
        'lbED6_31
        '
        Me.lbED6_31.AutoSize = True
        Me.lbED6_31.Location = New System.Drawing.Point(911, 578)
        Me.lbED6_31.Name = "lbED6_31"
        Me.lbED6_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_31.TabIndex = 4
        Me.lbED6_31.Text = "ED6_31"
        '
        'lbED6_16
        '
        Me.lbED6_16.AutoSize = True
        Me.lbED6_16.Location = New System.Drawing.Point(911, 308)
        Me.lbED6_16.Name = "lbED6_16"
        Me.lbED6_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_16.TabIndex = 4
        Me.lbED6_16.Text = "ED6_16"
        '
        'lbED6_24
        '
        Me.lbED6_24.AutoSize = True
        Me.lbED6_24.Location = New System.Drawing.Point(911, 452)
        Me.lbED6_24.Name = "lbED6_24"
        Me.lbED6_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_24.TabIndex = 4
        Me.lbED6_24.Text = "ED6_24"
        '
        'lbED6_15
        '
        Me.lbED6_15.AutoSize = True
        Me.lbED6_15.Location = New System.Drawing.Point(911, 290)
        Me.lbED6_15.Name = "lbED6_15"
        Me.lbED6_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_15.TabIndex = 4
        Me.lbED6_15.Text = "ED6_15"
        '
        'lbED6_28
        '
        Me.lbED6_28.AutoSize = True
        Me.lbED6_28.Location = New System.Drawing.Point(911, 524)
        Me.lbED6_28.Name = "lbED6_28"
        Me.lbED6_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_28.TabIndex = 4
        Me.lbED6_28.Text = "ED6_28"
        '
        'lbED6_8
        '
        Me.lbED6_8.AutoSize = True
        Me.lbED6_8.Location = New System.Drawing.Point(911, 164)
        Me.lbED6_8.Name = "lbED6_8"
        Me.lbED6_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_8.TabIndex = 4
        Me.lbED6_8.Text = "ED6_8"
        '
        'lbED6_23
        '
        Me.lbED6_23.AutoSize = True
        Me.lbED6_23.Location = New System.Drawing.Point(911, 434)
        Me.lbED6_23.Name = "lbED6_23"
        Me.lbED6_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_23.TabIndex = 4
        Me.lbED6_23.Text = "ED6_23"
        '
        'lbED6_12
        '
        Me.lbED6_12.AutoSize = True
        Me.lbED6_12.Location = New System.Drawing.Point(911, 236)
        Me.lbED6_12.Name = "lbED6_12"
        Me.lbED6_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_12.TabIndex = 4
        Me.lbED6_12.Text = "ED6_12"
        '
        'lbED6_30
        '
        Me.lbED6_30.AutoSize = True
        Me.lbED6_30.Location = New System.Drawing.Point(911, 560)
        Me.lbED6_30.Name = "lbED6_30"
        Me.lbED6_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_30.TabIndex = 4
        Me.lbED6_30.Text = "ED6_30"
        '
        'lbED6_7
        '
        Me.lbED6_7.AutoSize = True
        Me.lbED6_7.Location = New System.Drawing.Point(911, 146)
        Me.lbED6_7.Name = "lbED6_7"
        Me.lbED6_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_7.TabIndex = 4
        Me.lbED6_7.Text = "ED6_7"
        '
        'lbED6_20
        '
        Me.lbED6_20.AutoSize = True
        Me.lbED6_20.Location = New System.Drawing.Point(911, 380)
        Me.lbED6_20.Name = "lbED6_20"
        Me.lbED6_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_20.TabIndex = 4
        Me.lbED6_20.Text = "ED6_20"
        '
        'lbED6_14
        '
        Me.lbED6_14.AutoSize = True
        Me.lbED6_14.Location = New System.Drawing.Point(911, 272)
        Me.lbED6_14.Name = "lbED6_14"
        Me.lbED6_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_14.TabIndex = 4
        Me.lbED6_14.Text = "ED6_14"
        '
        'lbED6_27
        '
        Me.lbED6_27.AutoSize = True
        Me.lbED6_27.Location = New System.Drawing.Point(911, 506)
        Me.lbED6_27.Name = "lbED6_27"
        Me.lbED6_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_27.TabIndex = 4
        Me.lbED6_27.Text = "ED6_27"
        '
        'lbED6_4
        '
        Me.lbED6_4.AutoSize = True
        Me.lbED6_4.Location = New System.Drawing.Point(911, 92)
        Me.lbED6_4.Name = "lbED6_4"
        Me.lbED6_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_4.TabIndex = 4
        Me.lbED6_4.Text = "ED6_4"
        '
        'lbED6_22
        '
        Me.lbED6_22.AutoSize = True
        Me.lbED6_22.Location = New System.Drawing.Point(911, 416)
        Me.lbED6_22.Name = "lbED6_22"
        Me.lbED6_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_22.TabIndex = 4
        Me.lbED6_22.Text = "ED6_22"
        '
        'lbED6_11
        '
        Me.lbED6_11.AutoSize = True
        Me.lbED6_11.Location = New System.Drawing.Point(911, 218)
        Me.lbED6_11.Name = "lbED6_11"
        Me.lbED6_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_11.TabIndex = 4
        Me.lbED6_11.Text = "ED6_11"
        '
        'lbED6_29
        '
        Me.lbED6_29.AutoSize = True
        Me.lbED6_29.Location = New System.Drawing.Point(911, 542)
        Me.lbED6_29.Name = "lbED6_29"
        Me.lbED6_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_29.TabIndex = 4
        Me.lbED6_29.Text = "ED6_29"
        '
        'lbED6_6
        '
        Me.lbED6_6.AutoSize = True
        Me.lbED6_6.Location = New System.Drawing.Point(911, 128)
        Me.lbED6_6.Name = "lbED6_6"
        Me.lbED6_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_6.TabIndex = 4
        Me.lbED6_6.Text = "ED6_6"
        '
        'lbED6_19
        '
        Me.lbED6_19.AutoSize = True
        Me.lbED6_19.Location = New System.Drawing.Point(911, 362)
        Me.lbED6_19.Name = "lbED6_19"
        Me.lbED6_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_19.TabIndex = 4
        Me.lbED6_19.Text = "ED6_19"
        '
        'lbED6_13
        '
        Me.lbED6_13.AutoSize = True
        Me.lbED6_13.Location = New System.Drawing.Point(911, 254)
        Me.lbED6_13.Name = "lbED6_13"
        Me.lbED6_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_13.TabIndex = 4
        Me.lbED6_13.Text = "ED6_13"
        '
        'lbED6_26
        '
        Me.lbED6_26.AutoSize = True
        Me.lbED6_26.Location = New System.Drawing.Point(911, 488)
        Me.lbED6_26.Name = "lbED6_26"
        Me.lbED6_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_26.TabIndex = 4
        Me.lbED6_26.Text = "ED6_26"
        '
        'lbED6_3
        '
        Me.lbED6_3.AutoSize = True
        Me.lbED6_3.Location = New System.Drawing.Point(911, 74)
        Me.lbED6_3.Name = "lbED6_3"
        Me.lbED6_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_3.TabIndex = 4
        Me.lbED6_3.Text = "ED6_3"
        '
        'lbED6_21
        '
        Me.lbED6_21.AutoSize = True
        Me.lbED6_21.Location = New System.Drawing.Point(911, 398)
        Me.lbED6_21.Name = "lbED6_21"
        Me.lbED6_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_21.TabIndex = 4
        Me.lbED6_21.Text = "ED6_21"
        '
        'lbED6_10
        '
        Me.lbED6_10.AutoSize = True
        Me.lbED6_10.Location = New System.Drawing.Point(911, 200)
        Me.lbED6_10.Name = "lbED6_10"
        Me.lbED6_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_10.TabIndex = 4
        Me.lbED6_10.Text = "ED6_10"
        '
        'lbED6_25
        '
        Me.lbED6_25.AutoSize = True
        Me.lbED6_25.Location = New System.Drawing.Point(911, 470)
        Me.lbED6_25.Name = "lbED6_25"
        Me.lbED6_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_25.TabIndex = 4
        Me.lbED6_25.Text = "ED6_25"
        '
        'lbED6_5
        '
        Me.lbED6_5.AutoSize = True
        Me.lbED6_5.Location = New System.Drawing.Point(911, 110)
        Me.lbED6_5.Name = "lbED6_5"
        Me.lbED6_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_5.TabIndex = 4
        Me.lbED6_5.Text = "ED6_5"
        '
        'lbED6_18
        '
        Me.lbED6_18.AutoSize = True
        Me.lbED6_18.Location = New System.Drawing.Point(911, 344)
        Me.lbED6_18.Name = "lbED6_18"
        Me.lbED6_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_18.TabIndex = 4
        Me.lbED6_18.Text = "ED6_18"
        '
        'lbED6_9
        '
        Me.lbED6_9.AutoSize = True
        Me.lbED6_9.Location = New System.Drawing.Point(911, 182)
        Me.lbED6_9.Name = "lbED6_9"
        Me.lbED6_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_9.TabIndex = 4
        Me.lbED6_9.Text = "ED6_9"
        '
        'lbED6_17
        '
        Me.lbED6_17.AutoSize = True
        Me.lbED6_17.Location = New System.Drawing.Point(911, 326)
        Me.lbED6_17.Name = "lbED6_17"
        Me.lbED6_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED6_17.TabIndex = 4
        Me.lbED6_17.Text = "ED6_17"
        '
        'lbED6_2
        '
        Me.lbED6_2.AutoSize = True
        Me.lbED6_2.Location = New System.Drawing.Point(911, 56)
        Me.lbED6_2.Name = "lbED6_2"
        Me.lbED6_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_2.TabIndex = 4
        Me.lbED6_2.Text = "ED6_2"
        '
        'lbED6_1
        '
        Me.lbED6_1.AutoSize = True
        Me.lbED6_1.Location = New System.Drawing.Point(911, 38)
        Me.lbED6_1.Name = "lbED6_1"
        Me.lbED6_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED6_1.TabIndex = 4
        Me.lbED6_1.Text = "ED6_1"
        '
        'cmdED6_32
        '
        Me.cmdED6_32.AccessibleDescription = ""
        Me.cmdED6_32.Location = New System.Drawing.Point(856, 593)
        Me.cmdED6_32.Name = "cmdED6_32"
        Me.cmdED6_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_32.TabIndex = 191
        Me.cmdED6_32.Text = "ED6_32"
        Me.cmdED6_32.UseVisualStyleBackColor = True
        '
        'cmdED6_24
        '
        Me.cmdED6_24.AccessibleDescription = ""
        Me.cmdED6_24.Location = New System.Drawing.Point(856, 449)
        Me.cmdED6_24.Name = "cmdED6_24"
        Me.cmdED6_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_24.TabIndex = 183
        Me.cmdED6_24.Text = "ED6_24"
        Me.cmdED6_24.UseVisualStyleBackColor = True
        '
        'cmdED6_16
        '
        Me.cmdED6_16.AccessibleDescription = ""
        Me.cmdED6_16.Location = New System.Drawing.Point(856, 305)
        Me.cmdED6_16.Name = "cmdED6_16"
        Me.cmdED6_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_16.TabIndex = 175
        Me.cmdED6_16.Text = "ED6_16"
        Me.cmdED6_16.UseVisualStyleBackColor = True
        '
        'cmdED6_31
        '
        Me.cmdED6_31.AccessibleDescription = ""
        Me.cmdED6_31.Location = New System.Drawing.Point(856, 575)
        Me.cmdED6_31.Name = "cmdED6_31"
        Me.cmdED6_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_31.TabIndex = 190
        Me.cmdED6_31.Text = "ED6_31"
        Me.cmdED6_31.UseVisualStyleBackColor = True
        '
        'cmdED6_8
        '
        Me.cmdED6_8.AccessibleDescription = ""
        Me.cmdED6_8.Location = New System.Drawing.Point(856, 161)
        Me.cmdED6_8.Name = "cmdED6_8"
        Me.cmdED6_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_8.TabIndex = 167
        Me.cmdED6_8.Text = "ED6_8"
        Me.cmdED6_8.UseVisualStyleBackColor = True
        '
        'cmdED6_23
        '
        Me.cmdED6_23.AccessibleDescription = ""
        Me.cmdED6_23.Location = New System.Drawing.Point(856, 431)
        Me.cmdED6_23.Name = "cmdED6_23"
        Me.cmdED6_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_23.TabIndex = 182
        Me.cmdED6_23.Text = "ED6_23"
        Me.cmdED6_23.UseVisualStyleBackColor = True
        '
        'cmdED6_15
        '
        Me.cmdED6_15.AccessibleDescription = ""
        Me.cmdED6_15.Location = New System.Drawing.Point(856, 287)
        Me.cmdED6_15.Name = "cmdED6_15"
        Me.cmdED6_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_15.TabIndex = 174
        Me.cmdED6_15.Text = "ED6_15"
        Me.cmdED6_15.UseVisualStyleBackColor = True
        '
        'cmdED6_30
        '
        Me.cmdED6_30.AccessibleDescription = ""
        Me.cmdED6_30.Location = New System.Drawing.Point(856, 557)
        Me.cmdED6_30.Name = "cmdED6_30"
        Me.cmdED6_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_30.TabIndex = 189
        Me.cmdED6_30.Text = "ED6_30"
        Me.cmdED6_30.UseVisualStyleBackColor = True
        '
        'cmdED6_7
        '
        Me.cmdED6_7.AccessibleDescription = ""
        Me.cmdED6_7.Location = New System.Drawing.Point(856, 143)
        Me.cmdED6_7.Name = "cmdED6_7"
        Me.cmdED6_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_7.TabIndex = 166
        Me.cmdED6_7.Text = "ED6_7"
        Me.cmdED6_7.UseVisualStyleBackColor = True
        '
        'cmdED6_22
        '
        Me.cmdED6_22.AccessibleDescription = ""
        Me.cmdED6_22.Location = New System.Drawing.Point(856, 413)
        Me.cmdED6_22.Name = "cmdED6_22"
        Me.cmdED6_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_22.TabIndex = 181
        Me.cmdED6_22.Text = "ED6_22"
        Me.cmdED6_22.UseVisualStyleBackColor = True
        '
        'cmdED6_14
        '
        Me.cmdED6_14.AccessibleDescription = ""
        Me.cmdED6_14.Location = New System.Drawing.Point(856, 269)
        Me.cmdED6_14.Name = "cmdED6_14"
        Me.cmdED6_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_14.TabIndex = 173
        Me.cmdED6_14.Text = "ED6_14"
        Me.cmdED6_14.UseVisualStyleBackColor = True
        '
        'cmdED6_29
        '
        Me.cmdED6_29.AccessibleDescription = ""
        Me.cmdED6_29.Location = New System.Drawing.Point(856, 539)
        Me.cmdED6_29.Name = "cmdED6_29"
        Me.cmdED6_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_29.TabIndex = 188
        Me.cmdED6_29.Text = "ED6_29"
        Me.cmdED6_29.UseVisualStyleBackColor = True
        '
        'cmdED6_6
        '
        Me.cmdED6_6.AccessibleDescription = ""
        Me.cmdED6_6.Location = New System.Drawing.Point(856, 125)
        Me.cmdED6_6.Name = "cmdED6_6"
        Me.cmdED6_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_6.TabIndex = 165
        Me.cmdED6_6.Text = "ED6_6"
        Me.cmdED6_6.UseVisualStyleBackColor = True
        '
        'cmdED6_21
        '
        Me.cmdED6_21.AccessibleDescription = ""
        Me.cmdED6_21.Location = New System.Drawing.Point(856, 395)
        Me.cmdED6_21.Name = "cmdED6_21"
        Me.cmdED6_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_21.TabIndex = 180
        Me.cmdED6_21.Text = "ED6_21"
        Me.cmdED6_21.UseVisualStyleBackColor = True
        '
        'cmdED6_13
        '
        Me.cmdED6_13.AccessibleDescription = ""
        Me.cmdED6_13.Location = New System.Drawing.Point(856, 251)
        Me.cmdED6_13.Name = "cmdED6_13"
        Me.cmdED6_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_13.TabIndex = 172
        Me.cmdED6_13.Text = "ED6_13"
        Me.cmdED6_13.UseVisualStyleBackColor = True
        '
        'cmdED6_28
        '
        Me.cmdED6_28.AccessibleDescription = ""
        Me.cmdED6_28.Location = New System.Drawing.Point(856, 521)
        Me.cmdED6_28.Name = "cmdED6_28"
        Me.cmdED6_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_28.TabIndex = 187
        Me.cmdED6_28.Text = "ED6_28"
        Me.cmdED6_28.UseVisualStyleBackColor = True
        '
        'cmdED6_5
        '
        Me.cmdED6_5.AccessibleDescription = ""
        Me.cmdED6_5.Location = New System.Drawing.Point(856, 107)
        Me.cmdED6_5.Name = "cmdED6_5"
        Me.cmdED6_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_5.TabIndex = 164
        Me.cmdED6_5.Text = "ED6_5"
        Me.cmdED6_5.UseVisualStyleBackColor = True
        '
        'cmdED6_20
        '
        Me.cmdED6_20.AccessibleDescription = ""
        Me.cmdED6_20.Location = New System.Drawing.Point(856, 377)
        Me.cmdED6_20.Name = "cmdED6_20"
        Me.cmdED6_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_20.TabIndex = 179
        Me.cmdED6_20.Text = "ED6_20"
        Me.cmdED6_20.UseVisualStyleBackColor = True
        '
        'cmdED6_12
        '
        Me.cmdED6_12.AccessibleDescription = ""
        Me.cmdED6_12.Location = New System.Drawing.Point(856, 233)
        Me.cmdED6_12.Name = "cmdED6_12"
        Me.cmdED6_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_12.TabIndex = 171
        Me.cmdED6_12.Text = "ED6_12"
        Me.cmdED6_12.UseVisualStyleBackColor = True
        '
        'cmdED6_27
        '
        Me.cmdED6_27.AccessibleDescription = ""
        Me.cmdED6_27.Location = New System.Drawing.Point(856, 503)
        Me.cmdED6_27.Name = "cmdED6_27"
        Me.cmdED6_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_27.TabIndex = 186
        Me.cmdED6_27.Text = "ED6_27"
        Me.cmdED6_27.UseVisualStyleBackColor = True
        '
        'cmdED6_4
        '
        Me.cmdED6_4.AccessibleDescription = ""
        Me.cmdED6_4.Location = New System.Drawing.Point(856, 89)
        Me.cmdED6_4.Name = "cmdED6_4"
        Me.cmdED6_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_4.TabIndex = 163
        Me.cmdED6_4.Text = "ED6_4"
        Me.cmdED6_4.UseVisualStyleBackColor = True
        '
        'cmdED6_19
        '
        Me.cmdED6_19.AccessibleDescription = ""
        Me.cmdED6_19.Location = New System.Drawing.Point(856, 359)
        Me.cmdED6_19.Name = "cmdED6_19"
        Me.cmdED6_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_19.TabIndex = 178
        Me.cmdED6_19.Text = "ED6_19"
        Me.cmdED6_19.UseVisualStyleBackColor = True
        '
        'cmdED6_11
        '
        Me.cmdED6_11.AccessibleDescription = ""
        Me.cmdED6_11.Location = New System.Drawing.Point(856, 215)
        Me.cmdED6_11.Name = "cmdED6_11"
        Me.cmdED6_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_11.TabIndex = 170
        Me.cmdED6_11.Text = "ED6_11"
        Me.cmdED6_11.UseVisualStyleBackColor = True
        '
        'cmdED6_26
        '
        Me.cmdED6_26.AccessibleDescription = ""
        Me.cmdED6_26.Location = New System.Drawing.Point(856, 485)
        Me.cmdED6_26.Name = "cmdED6_26"
        Me.cmdED6_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_26.TabIndex = 185
        Me.cmdED6_26.Text = "ED6_26"
        Me.cmdED6_26.UseVisualStyleBackColor = True
        '
        'cmdED6_3
        '
        Me.cmdED6_3.AccessibleDescription = ""
        Me.cmdED6_3.Location = New System.Drawing.Point(856, 71)
        Me.cmdED6_3.Name = "cmdED6_3"
        Me.cmdED6_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_3.TabIndex = 162
        Me.cmdED6_3.Text = "ED6_3"
        Me.cmdED6_3.UseVisualStyleBackColor = True
        '
        'cmdED6_18
        '
        Me.cmdED6_18.AccessibleDescription = ""
        Me.cmdED6_18.Location = New System.Drawing.Point(856, 341)
        Me.cmdED6_18.Name = "cmdED6_18"
        Me.cmdED6_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_18.TabIndex = 177
        Me.cmdED6_18.Text = "ED6_18"
        Me.cmdED6_18.UseVisualStyleBackColor = True
        '
        'cmdED6_10
        '
        Me.cmdED6_10.AccessibleDescription = ""
        Me.cmdED6_10.Location = New System.Drawing.Point(856, 197)
        Me.cmdED6_10.Name = "cmdED6_10"
        Me.cmdED6_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_10.TabIndex = 169
        Me.cmdED6_10.Text = "ED6_10"
        Me.cmdED6_10.UseVisualStyleBackColor = True
        '
        'cmdED6_25
        '
        Me.cmdED6_25.AccessibleDescription = ""
        Me.cmdED6_25.Location = New System.Drawing.Point(856, 467)
        Me.cmdED6_25.Name = "cmdED6_25"
        Me.cmdED6_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_25.TabIndex = 184
        Me.cmdED6_25.Text = "ED6_25"
        Me.cmdED6_25.UseVisualStyleBackColor = True
        '
        'cmdED6_2
        '
        Me.cmdED6_2.AccessibleDescription = ""
        Me.cmdED6_2.Location = New System.Drawing.Point(856, 53)
        Me.cmdED6_2.Name = "cmdED6_2"
        Me.cmdED6_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_2.TabIndex = 161
        Me.cmdED6_2.Text = "ED6_2"
        Me.cmdED6_2.UseVisualStyleBackColor = True
        '
        'cmdED6_17
        '
        Me.cmdED6_17.AccessibleDescription = ""
        Me.cmdED6_17.Location = New System.Drawing.Point(856, 323)
        Me.cmdED6_17.Name = "cmdED6_17"
        Me.cmdED6_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_17.TabIndex = 176
        Me.cmdED6_17.Text = "ED6_17"
        Me.cmdED6_17.UseVisualStyleBackColor = True
        '
        'cmdED6_9
        '
        Me.cmdED6_9.AccessibleDescription = ""
        Me.cmdED6_9.Location = New System.Drawing.Point(856, 179)
        Me.cmdED6_9.Name = "cmdED6_9"
        Me.cmdED6_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_9.TabIndex = 168
        Me.cmdED6_9.Text = "ED6_9"
        Me.cmdED6_9.UseVisualStyleBackColor = True
        '
        'cmdED6_1
        '
        Me.cmdED6_1.AccessibleDescription = ""
        Me.cmdED6_1.Location = New System.Drawing.Point(856, 35)
        Me.cmdED6_1.Name = "cmdED6_1"
        Me.cmdED6_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED6_1.TabIndex = 160
        Me.cmdED6_1.Text = "ED6_1"
        Me.cmdED6_1.UseVisualStyleBackColor = True
        '
        'tbSD5_16
        '
        Me.tbSD5_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_16.Enabled = False
        Me.tbSD5_16.Location = New System.Drawing.Point(796, 305)
        Me.tbSD5_16.MaxLength = 15
        Me.tbSD5_16.Name = "tbSD5_16"
        Me.tbSD5_16.ReadOnly = True
        Me.tbSD5_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_16.TabIndex = 224
        Me.tbSD5_16.Text = "SD5_16"
        Me.tbSD5_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_15
        '
        Me.tbSD5_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_15.Enabled = False
        Me.tbSD5_15.Location = New System.Drawing.Point(796, 287)
        Me.tbSD5_15.MaxLength = 15
        Me.tbSD5_15.Name = "tbSD5_15"
        Me.tbSD5_15.ReadOnly = True
        Me.tbSD5_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_15.TabIndex = 225
        Me.tbSD5_15.Text = "SD5_15"
        Me.tbSD5_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_14
        '
        Me.tbSD5_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_14.Enabled = False
        Me.tbSD5_14.Location = New System.Drawing.Point(796, 269)
        Me.tbSD5_14.MaxLength = 15
        Me.tbSD5_14.Name = "tbSD5_14"
        Me.tbSD5_14.ReadOnly = True
        Me.tbSD5_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_14.TabIndex = 226
        Me.tbSD5_14.Text = "SD5_14"
        Me.tbSD5_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_13
        '
        Me.tbSD5_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_13.Enabled = False
        Me.tbSD5_13.Location = New System.Drawing.Point(796, 250)
        Me.tbSD5_13.MaxLength = 15
        Me.tbSD5_13.Name = "tbSD5_13"
        Me.tbSD5_13.ReadOnly = True
        Me.tbSD5_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_13.TabIndex = 227
        Me.tbSD5_13.Text = "SD5_13"
        Me.tbSD5_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_12
        '
        Me.tbSD5_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_12.Enabled = False
        Me.tbSD5_12.Location = New System.Drawing.Point(796, 233)
        Me.tbSD5_12.MaxLength = 15
        Me.tbSD5_12.Name = "tbSD5_12"
        Me.tbSD5_12.ReadOnly = True
        Me.tbSD5_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_12.TabIndex = 228
        Me.tbSD5_12.Text = "SD5_12"
        Me.tbSD5_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_11
        '
        Me.tbSD5_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_11.Enabled = False
        Me.tbSD5_11.Location = New System.Drawing.Point(796, 215)
        Me.tbSD5_11.MaxLength = 15
        Me.tbSD5_11.Name = "tbSD5_11"
        Me.tbSD5_11.ReadOnly = True
        Me.tbSD5_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_11.TabIndex = 229
        Me.tbSD5_11.Text = "SD5_11"
        Me.tbSD5_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_10
        '
        Me.tbSD5_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_10.Enabled = False
        Me.tbSD5_10.Location = New System.Drawing.Point(796, 196)
        Me.tbSD5_10.MaxLength = 15
        Me.tbSD5_10.Name = "tbSD5_10"
        Me.tbSD5_10.ReadOnly = True
        Me.tbSD5_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_10.TabIndex = 230
        Me.tbSD5_10.Text = "SD5_10"
        Me.tbSD5_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_9
        '
        Me.tbSD5_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_9.Enabled = False
        Me.tbSD5_9.Location = New System.Drawing.Point(796, 179)
        Me.tbSD5_9.MaxLength = 15
        Me.tbSD5_9.Name = "tbSD5_9"
        Me.tbSD5_9.ReadOnly = True
        Me.tbSD5_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_9.TabIndex = 231
        Me.tbSD5_9.Text = "SD5_9"
        Me.tbSD5_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_8
        '
        Me.tbSD5_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_8.Enabled = False
        Me.tbSD5_8.Location = New System.Drawing.Point(796, 161)
        Me.tbSD5_8.MaxLength = 15
        Me.tbSD5_8.Name = "tbSD5_8"
        Me.tbSD5_8.ReadOnly = True
        Me.tbSD5_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_8.TabIndex = 232
        Me.tbSD5_8.Text = "SD5_8"
        Me.tbSD5_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_7
        '
        Me.tbSD5_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_7.Enabled = False
        Me.tbSD5_7.Location = New System.Drawing.Point(796, 143)
        Me.tbSD5_7.MaxLength = 15
        Me.tbSD5_7.Name = "tbSD5_7"
        Me.tbSD5_7.ReadOnly = True
        Me.tbSD5_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_7.TabIndex = 233
        Me.tbSD5_7.Text = "SD5_7"
        Me.tbSD5_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_6
        '
        Me.tbSD5_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_6.Enabled = False
        Me.tbSD5_6.Location = New System.Drawing.Point(796, 125)
        Me.tbSD5_6.MaxLength = 15
        Me.tbSD5_6.Name = "tbSD5_6"
        Me.tbSD5_6.ReadOnly = True
        Me.tbSD5_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_6.TabIndex = 234
        Me.tbSD5_6.Text = "SD5_6"
        Me.tbSD5_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_5
        '
        Me.tbSD5_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_5.Enabled = False
        Me.tbSD5_5.Location = New System.Drawing.Point(796, 107)
        Me.tbSD5_5.MaxLength = 15
        Me.tbSD5_5.Name = "tbSD5_5"
        Me.tbSD5_5.ReadOnly = True
        Me.tbSD5_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_5.TabIndex = 235
        Me.tbSD5_5.Text = "SD5_5"
        Me.tbSD5_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_4
        '
        Me.tbSD5_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_4.Enabled = False
        Me.tbSD5_4.Location = New System.Drawing.Point(796, 88)
        Me.tbSD5_4.MaxLength = 15
        Me.tbSD5_4.Name = "tbSD5_4"
        Me.tbSD5_4.ReadOnly = True
        Me.tbSD5_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_4.TabIndex = 236
        Me.tbSD5_4.Text = "SD5_4"
        Me.tbSD5_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_3
        '
        Me.tbSD5_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_3.Enabled = False
        Me.tbSD5_3.Location = New System.Drawing.Point(796, 71)
        Me.tbSD5_3.MaxLength = 15
        Me.tbSD5_3.Name = "tbSD5_3"
        Me.tbSD5_3.ReadOnly = True
        Me.tbSD5_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_3.TabIndex = 237
        Me.tbSD5_3.Text = "SD5_3"
        Me.tbSD5_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_2
        '
        Me.tbSD5_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_2.Enabled = False
        Me.tbSD5_2.Location = New System.Drawing.Point(796, 53)
        Me.tbSD5_2.MaxLength = 15
        Me.tbSD5_2.Name = "tbSD5_2"
        Me.tbSD5_2.ReadOnly = True
        Me.tbSD5_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_2.TabIndex = 238
        Me.tbSD5_2.Text = "SD5_2"
        Me.tbSD5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD5_1
        '
        Me.tbSD5_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD5_1.Enabled = False
        Me.tbSD5_1.Location = New System.Drawing.Point(796, 36)
        Me.tbSD5_1.MaxLength = 15
        Me.tbSD5_1.Name = "tbSD5_1"
        Me.tbSD5_1.ReadOnly = True
        Me.tbSD5_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD5_1.TabIndex = 239
        Me.tbSD5_1.Text = "SD5_1"
        Me.tbSD5_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED5_32
        '
        Me.lbED5_32.AutoSize = True
        Me.lbED5_32.Location = New System.Drawing.Point(738, 595)
        Me.lbED5_32.Name = "lbED5_32"
        Me.lbED5_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_32.TabIndex = 4
        Me.lbED5_32.Text = "ED5_32"
        '
        'lbED5_31
        '
        Me.lbED5_31.AutoSize = True
        Me.lbED5_31.Location = New System.Drawing.Point(738, 578)
        Me.lbED5_31.Name = "lbED5_31"
        Me.lbED5_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_31.TabIndex = 4
        Me.lbED5_31.Text = "ED5_31"
        '
        'lbED5_16
        '
        Me.lbED5_16.AutoSize = True
        Me.lbED5_16.Location = New System.Drawing.Point(738, 308)
        Me.lbED5_16.Name = "lbED5_16"
        Me.lbED5_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_16.TabIndex = 4
        Me.lbED5_16.Text = "ED5_16"
        '
        'lbED5_24
        '
        Me.lbED5_24.AutoSize = True
        Me.lbED5_24.Location = New System.Drawing.Point(738, 452)
        Me.lbED5_24.Name = "lbED5_24"
        Me.lbED5_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_24.TabIndex = 4
        Me.lbED5_24.Text = "ED5_24"
        '
        'lbED5_15
        '
        Me.lbED5_15.AutoSize = True
        Me.lbED5_15.Location = New System.Drawing.Point(738, 290)
        Me.lbED5_15.Name = "lbED5_15"
        Me.lbED5_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_15.TabIndex = 4
        Me.lbED5_15.Text = "ED5_15"
        '
        'lbED5_28
        '
        Me.lbED5_28.AutoSize = True
        Me.lbED5_28.Location = New System.Drawing.Point(738, 524)
        Me.lbED5_28.Name = "lbED5_28"
        Me.lbED5_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_28.TabIndex = 4
        Me.lbED5_28.Text = "ED5_28"
        '
        'lbED5_8
        '
        Me.lbED5_8.AutoSize = True
        Me.lbED5_8.Location = New System.Drawing.Point(738, 164)
        Me.lbED5_8.Name = "lbED5_8"
        Me.lbED5_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_8.TabIndex = 4
        Me.lbED5_8.Text = "ED5_8"
        '
        'lbED5_23
        '
        Me.lbED5_23.AutoSize = True
        Me.lbED5_23.Location = New System.Drawing.Point(738, 434)
        Me.lbED5_23.Name = "lbED5_23"
        Me.lbED5_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_23.TabIndex = 4
        Me.lbED5_23.Text = "ED5_23"
        '
        'lbED5_12
        '
        Me.lbED5_12.AutoSize = True
        Me.lbED5_12.Location = New System.Drawing.Point(738, 236)
        Me.lbED5_12.Name = "lbED5_12"
        Me.lbED5_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_12.TabIndex = 4
        Me.lbED5_12.Text = "ED5_12"
        '
        'lbED5_30
        '
        Me.lbED5_30.AutoSize = True
        Me.lbED5_30.Location = New System.Drawing.Point(738, 560)
        Me.lbED5_30.Name = "lbED5_30"
        Me.lbED5_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_30.TabIndex = 4
        Me.lbED5_30.Text = "ED5_30"
        '
        'lbED5_7
        '
        Me.lbED5_7.AutoSize = True
        Me.lbED5_7.Location = New System.Drawing.Point(738, 146)
        Me.lbED5_7.Name = "lbED5_7"
        Me.lbED5_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_7.TabIndex = 4
        Me.lbED5_7.Text = "ED5_7"
        '
        'lbED5_20
        '
        Me.lbED5_20.AutoSize = True
        Me.lbED5_20.Location = New System.Drawing.Point(738, 380)
        Me.lbED5_20.Name = "lbED5_20"
        Me.lbED5_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_20.TabIndex = 4
        Me.lbED5_20.Text = "ED5_20"
        '
        'lbED5_14
        '
        Me.lbED5_14.AutoSize = True
        Me.lbED5_14.Location = New System.Drawing.Point(738, 272)
        Me.lbED5_14.Name = "lbED5_14"
        Me.lbED5_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_14.TabIndex = 4
        Me.lbED5_14.Text = "ED5_14"
        '
        'lbED5_27
        '
        Me.lbED5_27.AutoSize = True
        Me.lbED5_27.Location = New System.Drawing.Point(738, 506)
        Me.lbED5_27.Name = "lbED5_27"
        Me.lbED5_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_27.TabIndex = 4
        Me.lbED5_27.Text = "ED5_27"
        '
        'lbED5_4
        '
        Me.lbED5_4.AutoSize = True
        Me.lbED5_4.Location = New System.Drawing.Point(738, 92)
        Me.lbED5_4.Name = "lbED5_4"
        Me.lbED5_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_4.TabIndex = 4
        Me.lbED5_4.Text = "ED5_4"
        '
        'lbED5_22
        '
        Me.lbED5_22.AutoSize = True
        Me.lbED5_22.Location = New System.Drawing.Point(738, 416)
        Me.lbED5_22.Name = "lbED5_22"
        Me.lbED5_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_22.TabIndex = 4
        Me.lbED5_22.Text = "ED5_22"
        '
        'lbED5_11
        '
        Me.lbED5_11.AutoSize = True
        Me.lbED5_11.Location = New System.Drawing.Point(738, 218)
        Me.lbED5_11.Name = "lbED5_11"
        Me.lbED5_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_11.TabIndex = 4
        Me.lbED5_11.Text = "ED5_11"
        '
        'lbED5_29
        '
        Me.lbED5_29.AutoSize = True
        Me.lbED5_29.Location = New System.Drawing.Point(738, 542)
        Me.lbED5_29.Name = "lbED5_29"
        Me.lbED5_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_29.TabIndex = 4
        Me.lbED5_29.Text = "ED5_29"
        '
        'lbED5_6
        '
        Me.lbED5_6.AutoSize = True
        Me.lbED5_6.Location = New System.Drawing.Point(738, 128)
        Me.lbED5_6.Name = "lbED5_6"
        Me.lbED5_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_6.TabIndex = 4
        Me.lbED5_6.Text = "ED5_6"
        '
        'lbED5_19
        '
        Me.lbED5_19.AutoSize = True
        Me.lbED5_19.Location = New System.Drawing.Point(738, 362)
        Me.lbED5_19.Name = "lbED5_19"
        Me.lbED5_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_19.TabIndex = 4
        Me.lbED5_19.Text = "ED5_19"
        '
        'lbED5_13
        '
        Me.lbED5_13.AutoSize = True
        Me.lbED5_13.Location = New System.Drawing.Point(738, 254)
        Me.lbED5_13.Name = "lbED5_13"
        Me.lbED5_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_13.TabIndex = 4
        Me.lbED5_13.Text = "ED5_13"
        '
        'lbED5_26
        '
        Me.lbED5_26.AutoSize = True
        Me.lbED5_26.Location = New System.Drawing.Point(738, 488)
        Me.lbED5_26.Name = "lbED5_26"
        Me.lbED5_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_26.TabIndex = 4
        Me.lbED5_26.Text = "ED5_26"
        '
        'lbED5_3
        '
        Me.lbED5_3.AutoSize = True
        Me.lbED5_3.Location = New System.Drawing.Point(738, 74)
        Me.lbED5_3.Name = "lbED5_3"
        Me.lbED5_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_3.TabIndex = 4
        Me.lbED5_3.Text = "ED5_3"
        '
        'lbED5_21
        '
        Me.lbED5_21.AutoSize = True
        Me.lbED5_21.Location = New System.Drawing.Point(738, 398)
        Me.lbED5_21.Name = "lbED5_21"
        Me.lbED5_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_21.TabIndex = 4
        Me.lbED5_21.Text = "ED5_21"
        '
        'lbED5_10
        '
        Me.lbED5_10.AutoSize = True
        Me.lbED5_10.Location = New System.Drawing.Point(738, 200)
        Me.lbED5_10.Name = "lbED5_10"
        Me.lbED5_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_10.TabIndex = 4
        Me.lbED5_10.Text = "ED5_10"
        '
        'lbED5_25
        '
        Me.lbED5_25.AutoSize = True
        Me.lbED5_25.Location = New System.Drawing.Point(738, 470)
        Me.lbED5_25.Name = "lbED5_25"
        Me.lbED5_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_25.TabIndex = 4
        Me.lbED5_25.Text = "ED5_25"
        '
        'lbED5_5
        '
        Me.lbED5_5.AutoSize = True
        Me.lbED5_5.Location = New System.Drawing.Point(738, 110)
        Me.lbED5_5.Name = "lbED5_5"
        Me.lbED5_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_5.TabIndex = 4
        Me.lbED5_5.Text = "ED5_5"
        '
        'lbED5_18
        '
        Me.lbED5_18.AutoSize = True
        Me.lbED5_18.Location = New System.Drawing.Point(738, 344)
        Me.lbED5_18.Name = "lbED5_18"
        Me.lbED5_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_18.TabIndex = 4
        Me.lbED5_18.Text = "ED5_18"
        '
        'lbED5_9
        '
        Me.lbED5_9.AutoSize = True
        Me.lbED5_9.Location = New System.Drawing.Point(738, 182)
        Me.lbED5_9.Name = "lbED5_9"
        Me.lbED5_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_9.TabIndex = 4
        Me.lbED5_9.Text = "ED5_9"
        '
        'lbED5_17
        '
        Me.lbED5_17.AutoSize = True
        Me.lbED5_17.Location = New System.Drawing.Point(738, 326)
        Me.lbED5_17.Name = "lbED5_17"
        Me.lbED5_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED5_17.TabIndex = 4
        Me.lbED5_17.Text = "ED5_17"
        '
        'lbED5_2
        '
        Me.lbED5_2.AutoSize = True
        Me.lbED5_2.Location = New System.Drawing.Point(738, 56)
        Me.lbED5_2.Name = "lbED5_2"
        Me.lbED5_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_2.TabIndex = 4
        Me.lbED5_2.Text = "ED5_2"
        '
        'lbED5_1
        '
        Me.lbED5_1.AutoSize = True
        Me.lbED5_1.Location = New System.Drawing.Point(738, 38)
        Me.lbED5_1.Name = "lbED5_1"
        Me.lbED5_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED5_1.TabIndex = 4
        Me.lbED5_1.Text = "ED5_1"
        '
        'cmdED5_1
        '
        Me.cmdED5_1.AccessibleDescription = ""
        Me.cmdED5_1.Location = New System.Drawing.Point(687, 34)
        Me.cmdED5_1.Name = "cmdED5_1"
        Me.cmdED5_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_1.TabIndex = 128
        Me.cmdED5_1.Text = "ED5_1"
        Me.cmdED5_1.UseVisualStyleBackColor = True
        '
        'cmdED5_9
        '
        Me.cmdED5_9.AccessibleDescription = ""
        Me.cmdED5_9.Location = New System.Drawing.Point(687, 178)
        Me.cmdED5_9.Name = "cmdED5_9"
        Me.cmdED5_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_9.TabIndex = 136
        Me.cmdED5_9.Text = "ED5_9"
        Me.cmdED5_9.UseVisualStyleBackColor = True
        '
        'cmdED5_17
        '
        Me.cmdED5_17.AccessibleDescription = ""
        Me.cmdED5_17.Location = New System.Drawing.Point(687, 322)
        Me.cmdED5_17.Name = "cmdED5_17"
        Me.cmdED5_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_17.TabIndex = 144
        Me.cmdED5_17.Text = "ED5_17"
        Me.cmdED5_17.UseVisualStyleBackColor = True
        '
        'cmdED5_2
        '
        Me.cmdED5_2.AccessibleDescription = ""
        Me.cmdED5_2.Location = New System.Drawing.Point(687, 52)
        Me.cmdED5_2.Name = "cmdED5_2"
        Me.cmdED5_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_2.TabIndex = 129
        Me.cmdED5_2.Text = "ED5_2"
        Me.cmdED5_2.UseVisualStyleBackColor = True
        '
        'cmdED5_25
        '
        Me.cmdED5_25.AccessibleDescription = ""
        Me.cmdED5_25.Location = New System.Drawing.Point(687, 466)
        Me.cmdED5_25.Name = "cmdED5_25"
        Me.cmdED5_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_25.TabIndex = 152
        Me.cmdED5_25.Text = "ED5_25"
        Me.cmdED5_25.UseVisualStyleBackColor = True
        '
        'cmdED5_10
        '
        Me.cmdED5_10.AccessibleDescription = ""
        Me.cmdED5_10.Location = New System.Drawing.Point(687, 196)
        Me.cmdED5_10.Name = "cmdED5_10"
        Me.cmdED5_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_10.TabIndex = 137
        Me.cmdED5_10.Text = "ED5_10"
        Me.cmdED5_10.UseVisualStyleBackColor = True
        '
        'cmdED5_18
        '
        Me.cmdED5_18.AccessibleDescription = ""
        Me.cmdED5_18.Location = New System.Drawing.Point(687, 340)
        Me.cmdED5_18.Name = "cmdED5_18"
        Me.cmdED5_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_18.TabIndex = 145
        Me.cmdED5_18.Text = "ED5_18"
        Me.cmdED5_18.UseVisualStyleBackColor = True
        '
        'cmdED5_3
        '
        Me.cmdED5_3.AccessibleDescription = ""
        Me.cmdED5_3.Location = New System.Drawing.Point(687, 70)
        Me.cmdED5_3.Name = "cmdED5_3"
        Me.cmdED5_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_3.TabIndex = 130
        Me.cmdED5_3.Text = "ED5_3"
        Me.cmdED5_3.UseVisualStyleBackColor = True
        '
        'cmdED5_26
        '
        Me.cmdED5_26.AccessibleDescription = ""
        Me.cmdED5_26.Location = New System.Drawing.Point(687, 484)
        Me.cmdED5_26.Name = "cmdED5_26"
        Me.cmdED5_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_26.TabIndex = 153
        Me.cmdED5_26.Text = "ED5_26"
        Me.cmdED5_26.UseVisualStyleBackColor = True
        '
        'cmdED5_11
        '
        Me.cmdED5_11.AccessibleDescription = ""
        Me.cmdED5_11.Location = New System.Drawing.Point(687, 214)
        Me.cmdED5_11.Name = "cmdED5_11"
        Me.cmdED5_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_11.TabIndex = 138
        Me.cmdED5_11.Text = "ED5_11"
        Me.cmdED5_11.UseVisualStyleBackColor = True
        '
        'cmdED5_19
        '
        Me.cmdED5_19.AccessibleDescription = ""
        Me.cmdED5_19.Location = New System.Drawing.Point(687, 358)
        Me.cmdED5_19.Name = "cmdED5_19"
        Me.cmdED5_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_19.TabIndex = 146
        Me.cmdED5_19.Text = "ED5_19"
        Me.cmdED5_19.UseVisualStyleBackColor = True
        '
        'cmdED5_32
        '
        Me.cmdED5_32.AccessibleDescription = ""
        Me.cmdED5_32.Location = New System.Drawing.Point(687, 592)
        Me.cmdED5_32.Name = "cmdED5_32"
        Me.cmdED5_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_32.TabIndex = 159
        Me.cmdED5_32.Text = "ED5_32"
        Me.cmdED5_32.UseVisualStyleBackColor = True
        '
        'cmdED5_24
        '
        Me.cmdED5_24.AccessibleDescription = ""
        Me.cmdED5_24.Location = New System.Drawing.Point(687, 448)
        Me.cmdED5_24.Name = "cmdED5_24"
        Me.cmdED5_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_24.TabIndex = 151
        Me.cmdED5_24.Text = "ED5_24"
        Me.cmdED5_24.UseVisualStyleBackColor = True
        '
        'cmdED5_4
        '
        Me.cmdED5_4.AccessibleDescription = ""
        Me.cmdED5_4.Location = New System.Drawing.Point(687, 88)
        Me.cmdED5_4.Name = "cmdED5_4"
        Me.cmdED5_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_4.TabIndex = 131
        Me.cmdED5_4.Text = "ED5_4"
        Me.cmdED5_4.UseVisualStyleBackColor = True
        '
        'cmdED5_27
        '
        Me.cmdED5_27.AccessibleDescription = ""
        Me.cmdED5_27.Location = New System.Drawing.Point(687, 502)
        Me.cmdED5_27.Name = "cmdED5_27"
        Me.cmdED5_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_27.TabIndex = 154
        Me.cmdED5_27.Text = "ED5_27"
        Me.cmdED5_27.UseVisualStyleBackColor = True
        '
        'cmdED5_16
        '
        Me.cmdED5_16.AccessibleDescription = ""
        Me.cmdED5_16.Location = New System.Drawing.Point(687, 304)
        Me.cmdED5_16.Name = "cmdED5_16"
        Me.cmdED5_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_16.TabIndex = 143
        Me.cmdED5_16.Text = "ED5_16"
        Me.cmdED5_16.UseVisualStyleBackColor = True
        '
        'cmdED5_12
        '
        Me.cmdED5_12.AccessibleDescription = ""
        Me.cmdED5_12.Location = New System.Drawing.Point(687, 232)
        Me.cmdED5_12.Name = "cmdED5_12"
        Me.cmdED5_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_12.TabIndex = 139
        Me.cmdED5_12.Text = "ED5_12"
        Me.cmdED5_12.UseVisualStyleBackColor = True
        '
        'cmdED5_31
        '
        Me.cmdED5_31.AccessibleDescription = ""
        Me.cmdED5_31.Location = New System.Drawing.Point(687, 574)
        Me.cmdED5_31.Name = "cmdED5_31"
        Me.cmdED5_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_31.TabIndex = 158
        Me.cmdED5_31.Text = "ED5_31"
        Me.cmdED5_31.UseVisualStyleBackColor = True
        '
        'cmdED5_20
        '
        Me.cmdED5_20.AccessibleDescription = ""
        Me.cmdED5_20.Location = New System.Drawing.Point(687, 376)
        Me.cmdED5_20.Name = "cmdED5_20"
        Me.cmdED5_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_20.TabIndex = 147
        Me.cmdED5_20.Text = "ED5_20"
        Me.cmdED5_20.UseVisualStyleBackColor = True
        '
        'cmdED5_8
        '
        Me.cmdED5_8.AccessibleDescription = ""
        Me.cmdED5_8.Location = New System.Drawing.Point(687, 160)
        Me.cmdED5_8.Name = "cmdED5_8"
        Me.cmdED5_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_8.TabIndex = 135
        Me.cmdED5_8.Text = "ED5_8"
        Me.cmdED5_8.UseVisualStyleBackColor = True
        '
        'cmdED5_5
        '
        Me.cmdED5_5.AccessibleDescription = ""
        Me.cmdED5_5.Location = New System.Drawing.Point(687, 106)
        Me.cmdED5_5.Name = "cmdED5_5"
        Me.cmdED5_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_5.TabIndex = 132
        Me.cmdED5_5.Text = "ED5_5"
        Me.cmdED5_5.UseVisualStyleBackColor = True
        '
        'cmdED5_23
        '
        Me.cmdED5_23.AccessibleDescription = ""
        Me.cmdED5_23.Location = New System.Drawing.Point(687, 430)
        Me.cmdED5_23.Name = "cmdED5_23"
        Me.cmdED5_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_23.TabIndex = 150
        Me.cmdED5_23.Text = "ED5_23"
        Me.cmdED5_23.UseVisualStyleBackColor = True
        '
        'cmdED5_28
        '
        Me.cmdED5_28.AccessibleDescription = ""
        Me.cmdED5_28.Location = New System.Drawing.Point(687, 520)
        Me.cmdED5_28.Name = "cmdED5_28"
        Me.cmdED5_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_28.TabIndex = 155
        Me.cmdED5_28.Text = "ED5_28"
        Me.cmdED5_28.UseVisualStyleBackColor = True
        '
        'cmdED5_15
        '
        Me.cmdED5_15.AccessibleDescription = ""
        Me.cmdED5_15.Location = New System.Drawing.Point(687, 286)
        Me.cmdED5_15.Name = "cmdED5_15"
        Me.cmdED5_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_15.TabIndex = 142
        Me.cmdED5_15.Text = "ED5_15"
        Me.cmdED5_15.UseVisualStyleBackColor = True
        '
        'cmdED5_13
        '
        Me.cmdED5_13.AccessibleDescription = ""
        Me.cmdED5_13.Location = New System.Drawing.Point(687, 250)
        Me.cmdED5_13.Name = "cmdED5_13"
        Me.cmdED5_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_13.TabIndex = 140
        Me.cmdED5_13.Text = "ED5_13"
        Me.cmdED5_13.UseVisualStyleBackColor = True
        '
        'cmdED5_30
        '
        Me.cmdED5_30.AccessibleDescription = ""
        Me.cmdED5_30.Location = New System.Drawing.Point(687, 556)
        Me.cmdED5_30.Name = "cmdED5_30"
        Me.cmdED5_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_30.TabIndex = 157
        Me.cmdED5_30.Text = "ED5_30"
        Me.cmdED5_30.UseVisualStyleBackColor = True
        '
        'cmdED5_21
        '
        Me.cmdED5_21.AccessibleDescription = ""
        Me.cmdED5_21.Location = New System.Drawing.Point(687, 394)
        Me.cmdED5_21.Name = "cmdED5_21"
        Me.cmdED5_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_21.TabIndex = 148
        Me.cmdED5_21.Text = "ED5_21"
        Me.cmdED5_21.UseVisualStyleBackColor = True
        '
        'cmdED5_7
        '
        Me.cmdED5_7.AccessibleDescription = ""
        Me.cmdED5_7.Location = New System.Drawing.Point(687, 142)
        Me.cmdED5_7.Name = "cmdED5_7"
        Me.cmdED5_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_7.TabIndex = 134
        Me.cmdED5_7.Text = "ED5_7"
        Me.cmdED5_7.UseVisualStyleBackColor = True
        '
        'cmdED5_6
        '
        Me.cmdED5_6.AccessibleDescription = ""
        Me.cmdED5_6.Location = New System.Drawing.Point(687, 124)
        Me.cmdED5_6.Name = "cmdED5_6"
        Me.cmdED5_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_6.TabIndex = 133
        Me.cmdED5_6.Text = "ED5_6"
        Me.cmdED5_6.UseVisualStyleBackColor = True
        '
        'cmdED5_22
        '
        Me.cmdED5_22.AccessibleDescription = ""
        Me.cmdED5_22.Location = New System.Drawing.Point(687, 412)
        Me.cmdED5_22.Name = "cmdED5_22"
        Me.cmdED5_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_22.TabIndex = 149
        Me.cmdED5_22.Text = "ED5_22"
        Me.cmdED5_22.UseVisualStyleBackColor = True
        '
        'cmdED5_29
        '
        Me.cmdED5_29.AccessibleDescription = ""
        Me.cmdED5_29.Location = New System.Drawing.Point(687, 538)
        Me.cmdED5_29.Name = "cmdED5_29"
        Me.cmdED5_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_29.TabIndex = 156
        Me.cmdED5_29.Text = "ED5_29"
        Me.cmdED5_29.UseVisualStyleBackColor = True
        '
        'cmdED5_14
        '
        Me.cmdED5_14.AccessibleDescription = ""
        Me.cmdED5_14.Location = New System.Drawing.Point(687, 268)
        Me.cmdED5_14.Name = "cmdED5_14"
        Me.cmdED5_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED5_14.TabIndex = 141
        Me.cmdED5_14.Text = "ED5_14"
        Me.cmdED5_14.UseVisualStyleBackColor = True
        '
        'tbSD4_16
        '
        Me.tbSD4_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_16.Enabled = False
        Me.tbSD4_16.Location = New System.Drawing.Point(627, 304)
        Me.tbSD4_16.MaxLength = 15
        Me.tbSD4_16.Name = "tbSD4_16"
        Me.tbSD4_16.ReadOnly = True
        Me.tbSD4_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_16.TabIndex = 224
        Me.tbSD4_16.Text = "SD4_16"
        Me.tbSD4_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_15
        '
        Me.tbSD4_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_15.Enabled = False
        Me.tbSD4_15.Location = New System.Drawing.Point(627, 286)
        Me.tbSD4_15.MaxLength = 15
        Me.tbSD4_15.Name = "tbSD4_15"
        Me.tbSD4_15.ReadOnly = True
        Me.tbSD4_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_15.TabIndex = 225
        Me.tbSD4_15.Text = "SD4_15"
        Me.tbSD4_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_14
        '
        Me.tbSD4_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_14.Enabled = False
        Me.tbSD4_14.Location = New System.Drawing.Point(627, 268)
        Me.tbSD4_14.MaxLength = 15
        Me.tbSD4_14.Name = "tbSD4_14"
        Me.tbSD4_14.ReadOnly = True
        Me.tbSD4_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_14.TabIndex = 226
        Me.tbSD4_14.Text = "SD4_14"
        Me.tbSD4_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_13
        '
        Me.tbSD4_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_13.Enabled = False
        Me.tbSD4_13.Location = New System.Drawing.Point(627, 249)
        Me.tbSD4_13.MaxLength = 15
        Me.tbSD4_13.Name = "tbSD4_13"
        Me.tbSD4_13.ReadOnly = True
        Me.tbSD4_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_13.TabIndex = 227
        Me.tbSD4_13.Text = "SD4_13"
        Me.tbSD4_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_12
        '
        Me.tbSD4_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_12.Enabled = False
        Me.tbSD4_12.Location = New System.Drawing.Point(627, 232)
        Me.tbSD4_12.MaxLength = 15
        Me.tbSD4_12.Name = "tbSD4_12"
        Me.tbSD4_12.ReadOnly = True
        Me.tbSD4_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_12.TabIndex = 228
        Me.tbSD4_12.Text = "SD4_12"
        Me.tbSD4_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_11
        '
        Me.tbSD4_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_11.Enabled = False
        Me.tbSD4_11.Location = New System.Drawing.Point(627, 214)
        Me.tbSD4_11.MaxLength = 15
        Me.tbSD4_11.Name = "tbSD4_11"
        Me.tbSD4_11.ReadOnly = True
        Me.tbSD4_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_11.TabIndex = 229
        Me.tbSD4_11.Text = "SD4_11"
        Me.tbSD4_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_10
        '
        Me.tbSD4_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_10.Enabled = False
        Me.tbSD4_10.Location = New System.Drawing.Point(627, 195)
        Me.tbSD4_10.MaxLength = 15
        Me.tbSD4_10.Name = "tbSD4_10"
        Me.tbSD4_10.ReadOnly = True
        Me.tbSD4_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_10.TabIndex = 230
        Me.tbSD4_10.Text = "SD4_10"
        Me.tbSD4_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_9
        '
        Me.tbSD4_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_9.Enabled = False
        Me.tbSD4_9.Location = New System.Drawing.Point(627, 178)
        Me.tbSD4_9.MaxLength = 15
        Me.tbSD4_9.Name = "tbSD4_9"
        Me.tbSD4_9.ReadOnly = True
        Me.tbSD4_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_9.TabIndex = 231
        Me.tbSD4_9.Text = "SD4_9"
        Me.tbSD4_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_8
        '
        Me.tbSD4_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_8.Enabled = False
        Me.tbSD4_8.Location = New System.Drawing.Point(627, 160)
        Me.tbSD4_8.MaxLength = 15
        Me.tbSD4_8.Name = "tbSD4_8"
        Me.tbSD4_8.ReadOnly = True
        Me.tbSD4_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_8.TabIndex = 232
        Me.tbSD4_8.Text = "SD4_8"
        Me.tbSD4_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_7
        '
        Me.tbSD4_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_7.Enabled = False
        Me.tbSD4_7.Location = New System.Drawing.Point(627, 142)
        Me.tbSD4_7.MaxLength = 15
        Me.tbSD4_7.Name = "tbSD4_7"
        Me.tbSD4_7.ReadOnly = True
        Me.tbSD4_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_7.TabIndex = 233
        Me.tbSD4_7.Text = "SD4_7"
        Me.tbSD4_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_6
        '
        Me.tbSD4_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_6.Enabled = False
        Me.tbSD4_6.Location = New System.Drawing.Point(627, 124)
        Me.tbSD4_6.MaxLength = 15
        Me.tbSD4_6.Name = "tbSD4_6"
        Me.tbSD4_6.ReadOnly = True
        Me.tbSD4_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_6.TabIndex = 234
        Me.tbSD4_6.Text = "SD4_6"
        Me.tbSD4_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_5
        '
        Me.tbSD4_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_5.Enabled = False
        Me.tbSD4_5.Location = New System.Drawing.Point(627, 106)
        Me.tbSD4_5.MaxLength = 15
        Me.tbSD4_5.Name = "tbSD4_5"
        Me.tbSD4_5.ReadOnly = True
        Me.tbSD4_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_5.TabIndex = 235
        Me.tbSD4_5.Text = "SD4_5"
        Me.tbSD4_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_4
        '
        Me.tbSD4_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_4.Enabled = False
        Me.tbSD4_4.Location = New System.Drawing.Point(627, 87)
        Me.tbSD4_4.MaxLength = 15
        Me.tbSD4_4.Name = "tbSD4_4"
        Me.tbSD4_4.ReadOnly = True
        Me.tbSD4_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_4.TabIndex = 236
        Me.tbSD4_4.Text = "SD4_4"
        Me.tbSD4_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_3
        '
        Me.tbSD4_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_3.Enabled = False
        Me.tbSD4_3.Location = New System.Drawing.Point(627, 70)
        Me.tbSD4_3.MaxLength = 15
        Me.tbSD4_3.Name = "tbSD4_3"
        Me.tbSD4_3.ReadOnly = True
        Me.tbSD4_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_3.TabIndex = 237
        Me.tbSD4_3.Text = "SD4_3"
        Me.tbSD4_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_2
        '
        Me.tbSD4_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_2.Enabled = False
        Me.tbSD4_2.Location = New System.Drawing.Point(627, 52)
        Me.tbSD4_2.MaxLength = 15
        Me.tbSD4_2.Name = "tbSD4_2"
        Me.tbSD4_2.ReadOnly = True
        Me.tbSD4_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_2.TabIndex = 238
        Me.tbSD4_2.Text = "SD4_2"
        Me.tbSD4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD4_1
        '
        Me.tbSD4_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD4_1.Enabled = False
        Me.tbSD4_1.Location = New System.Drawing.Point(627, 35)
        Me.tbSD4_1.MaxLength = 15
        Me.tbSD4_1.Name = "tbSD4_1"
        Me.tbSD4_1.ReadOnly = True
        Me.tbSD4_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD4_1.TabIndex = 239
        Me.tbSD4_1.Text = "SD4_1"
        Me.tbSD4_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED4_32
        '
        Me.lbED4_32.AutoSize = True
        Me.lbED4_32.Location = New System.Drawing.Point(571, 595)
        Me.lbED4_32.Name = "lbED4_32"
        Me.lbED4_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_32.TabIndex = 4
        Me.lbED4_32.Text = "ED4_32"
        '
        'lbED4_31
        '
        Me.lbED4_31.AutoSize = True
        Me.lbED4_31.Location = New System.Drawing.Point(571, 577)
        Me.lbED4_31.Name = "lbED4_31"
        Me.lbED4_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_31.TabIndex = 4
        Me.lbED4_31.Text = "ED4_31"
        '
        'lbED4_16
        '
        Me.lbED4_16.AutoSize = True
        Me.lbED4_16.Location = New System.Drawing.Point(571, 307)
        Me.lbED4_16.Name = "lbED4_16"
        Me.lbED4_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_16.TabIndex = 4
        Me.lbED4_16.Text = "ED4_16"
        '
        'lbED4_24
        '
        Me.lbED4_24.AutoSize = True
        Me.lbED4_24.Location = New System.Drawing.Point(571, 451)
        Me.lbED4_24.Name = "lbED4_24"
        Me.lbED4_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_24.TabIndex = 4
        Me.lbED4_24.Text = "ED4_24"
        '
        'lbED4_15
        '
        Me.lbED4_15.AutoSize = True
        Me.lbED4_15.Location = New System.Drawing.Point(571, 289)
        Me.lbED4_15.Name = "lbED4_15"
        Me.lbED4_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_15.TabIndex = 4
        Me.lbED4_15.Text = "ED4_15"
        '
        'lbED4_28
        '
        Me.lbED4_28.AutoSize = True
        Me.lbED4_28.Location = New System.Drawing.Point(571, 523)
        Me.lbED4_28.Name = "lbED4_28"
        Me.lbED4_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_28.TabIndex = 4
        Me.lbED4_28.Text = "ED4_28"
        '
        'lbED4_8
        '
        Me.lbED4_8.AutoSize = True
        Me.lbED4_8.Location = New System.Drawing.Point(571, 163)
        Me.lbED4_8.Name = "lbED4_8"
        Me.lbED4_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_8.TabIndex = 4
        Me.lbED4_8.Text = "ED4_8"
        '
        'lbED4_23
        '
        Me.lbED4_23.AutoSize = True
        Me.lbED4_23.Location = New System.Drawing.Point(571, 433)
        Me.lbED4_23.Name = "lbED4_23"
        Me.lbED4_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_23.TabIndex = 4
        Me.lbED4_23.Text = "ED4_23"
        '
        'lbED4_12
        '
        Me.lbED4_12.AutoSize = True
        Me.lbED4_12.Location = New System.Drawing.Point(571, 235)
        Me.lbED4_12.Name = "lbED4_12"
        Me.lbED4_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_12.TabIndex = 4
        Me.lbED4_12.Text = "ED4_12"
        '
        'lbED4_30
        '
        Me.lbED4_30.AutoSize = True
        Me.lbED4_30.Location = New System.Drawing.Point(571, 559)
        Me.lbED4_30.Name = "lbED4_30"
        Me.lbED4_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_30.TabIndex = 4
        Me.lbED4_30.Text = "ED4_30"
        '
        'lbED4_7
        '
        Me.lbED4_7.AutoSize = True
        Me.lbED4_7.Location = New System.Drawing.Point(571, 145)
        Me.lbED4_7.Name = "lbED4_7"
        Me.lbED4_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_7.TabIndex = 4
        Me.lbED4_7.Text = "ED4_7"
        '
        'lbED4_20
        '
        Me.lbED4_20.AutoSize = True
        Me.lbED4_20.Location = New System.Drawing.Point(571, 379)
        Me.lbED4_20.Name = "lbED4_20"
        Me.lbED4_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_20.TabIndex = 4
        Me.lbED4_20.Text = "ED4_20"
        '
        'lbED4_14
        '
        Me.lbED4_14.AutoSize = True
        Me.lbED4_14.Location = New System.Drawing.Point(571, 271)
        Me.lbED4_14.Name = "lbED4_14"
        Me.lbED4_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_14.TabIndex = 4
        Me.lbED4_14.Text = "ED4_14"
        '
        'lbED4_27
        '
        Me.lbED4_27.AutoSize = True
        Me.lbED4_27.Location = New System.Drawing.Point(571, 505)
        Me.lbED4_27.Name = "lbED4_27"
        Me.lbED4_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_27.TabIndex = 4
        Me.lbED4_27.Text = "ED4_27"
        '
        'lbED4_4
        '
        Me.lbED4_4.AutoSize = True
        Me.lbED4_4.Location = New System.Drawing.Point(571, 91)
        Me.lbED4_4.Name = "lbED4_4"
        Me.lbED4_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_4.TabIndex = 4
        Me.lbED4_4.Text = "ED4_4"
        '
        'lbED4_22
        '
        Me.lbED4_22.AutoSize = True
        Me.lbED4_22.Location = New System.Drawing.Point(571, 415)
        Me.lbED4_22.Name = "lbED4_22"
        Me.lbED4_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_22.TabIndex = 4
        Me.lbED4_22.Text = "ED4_22"
        '
        'lbED4_11
        '
        Me.lbED4_11.AutoSize = True
        Me.lbED4_11.Location = New System.Drawing.Point(571, 217)
        Me.lbED4_11.Name = "lbED4_11"
        Me.lbED4_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_11.TabIndex = 4
        Me.lbED4_11.Text = "ED4_11"
        '
        'lbED4_29
        '
        Me.lbED4_29.AutoSize = True
        Me.lbED4_29.Location = New System.Drawing.Point(571, 541)
        Me.lbED4_29.Name = "lbED4_29"
        Me.lbED4_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_29.TabIndex = 4
        Me.lbED4_29.Text = "ED4_29"
        '
        'lbED4_6
        '
        Me.lbED4_6.AutoSize = True
        Me.lbED4_6.Location = New System.Drawing.Point(571, 127)
        Me.lbED4_6.Name = "lbED4_6"
        Me.lbED4_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_6.TabIndex = 4
        Me.lbED4_6.Text = "ED4_6"
        '
        'lbED4_19
        '
        Me.lbED4_19.AutoSize = True
        Me.lbED4_19.Location = New System.Drawing.Point(571, 361)
        Me.lbED4_19.Name = "lbED4_19"
        Me.lbED4_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_19.TabIndex = 4
        Me.lbED4_19.Text = "ED4_19"
        '
        'lbED4_13
        '
        Me.lbED4_13.AutoSize = True
        Me.lbED4_13.Location = New System.Drawing.Point(571, 253)
        Me.lbED4_13.Name = "lbED4_13"
        Me.lbED4_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_13.TabIndex = 4
        Me.lbED4_13.Text = "ED4_13"
        '
        'lbED4_26
        '
        Me.lbED4_26.AutoSize = True
        Me.lbED4_26.Location = New System.Drawing.Point(571, 487)
        Me.lbED4_26.Name = "lbED4_26"
        Me.lbED4_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_26.TabIndex = 4
        Me.lbED4_26.Text = "ED4_26"
        '
        'lbED4_3
        '
        Me.lbED4_3.AutoSize = True
        Me.lbED4_3.Location = New System.Drawing.Point(571, 73)
        Me.lbED4_3.Name = "lbED4_3"
        Me.lbED4_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_3.TabIndex = 4
        Me.lbED4_3.Text = "ED4_3"
        '
        'lbED4_21
        '
        Me.lbED4_21.AutoSize = True
        Me.lbED4_21.Location = New System.Drawing.Point(571, 397)
        Me.lbED4_21.Name = "lbED4_21"
        Me.lbED4_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_21.TabIndex = 4
        Me.lbED4_21.Text = "ED4_21"
        '
        'lbED4_10
        '
        Me.lbED4_10.AutoSize = True
        Me.lbED4_10.Location = New System.Drawing.Point(571, 199)
        Me.lbED4_10.Name = "lbED4_10"
        Me.lbED4_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_10.TabIndex = 4
        Me.lbED4_10.Text = "ED4_10"
        '
        'lbED4_25
        '
        Me.lbED4_25.AutoSize = True
        Me.lbED4_25.Location = New System.Drawing.Point(571, 469)
        Me.lbED4_25.Name = "lbED4_25"
        Me.lbED4_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_25.TabIndex = 4
        Me.lbED4_25.Text = "ED4_25"
        '
        'lbED4_5
        '
        Me.lbED4_5.AutoSize = True
        Me.lbED4_5.Location = New System.Drawing.Point(571, 109)
        Me.lbED4_5.Name = "lbED4_5"
        Me.lbED4_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_5.TabIndex = 4
        Me.lbED4_5.Text = "ED4_5"
        '
        'lbED4_18
        '
        Me.lbED4_18.AutoSize = True
        Me.lbED4_18.Location = New System.Drawing.Point(571, 343)
        Me.lbED4_18.Name = "lbED4_18"
        Me.lbED4_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_18.TabIndex = 4
        Me.lbED4_18.Text = "ED4_18"
        '
        'lbED4_9
        '
        Me.lbED4_9.AutoSize = True
        Me.lbED4_9.Location = New System.Drawing.Point(571, 181)
        Me.lbED4_9.Name = "lbED4_9"
        Me.lbED4_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_9.TabIndex = 4
        Me.lbED4_9.Text = "ED4_9"
        '
        'lbED4_17
        '
        Me.lbED4_17.AutoSize = True
        Me.lbED4_17.Location = New System.Drawing.Point(571, 325)
        Me.lbED4_17.Name = "lbED4_17"
        Me.lbED4_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED4_17.TabIndex = 4
        Me.lbED4_17.Text = "ED4_17"
        '
        'lbED4_2
        '
        Me.lbED4_2.AutoSize = True
        Me.lbED4_2.Location = New System.Drawing.Point(571, 55)
        Me.lbED4_2.Name = "lbED4_2"
        Me.lbED4_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_2.TabIndex = 4
        Me.lbED4_2.Text = "ED4_2"
        '
        'lbED4_1
        '
        Me.lbED4_1.AutoSize = True
        Me.lbED4_1.Location = New System.Drawing.Point(571, 37)
        Me.lbED4_1.Name = "lbED4_1"
        Me.lbED4_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED4_1.TabIndex = 4
        Me.lbED4_1.Text = "ED4_1"
        '
        'cmdED4_1
        '
        Me.cmdED4_1.AccessibleDescription = ""
        Me.cmdED4_1.Location = New System.Drawing.Point(519, 34)
        Me.cmdED4_1.Name = "cmdED4_1"
        Me.cmdED4_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_1.TabIndex = 96
        Me.cmdED4_1.Text = "ED4_1"
        Me.cmdED4_1.UseVisualStyleBackColor = True
        '
        'cmdED4_9
        '
        Me.cmdED4_9.AccessibleDescription = ""
        Me.cmdED4_9.Location = New System.Drawing.Point(519, 178)
        Me.cmdED4_9.Name = "cmdED4_9"
        Me.cmdED4_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_9.TabIndex = 104
        Me.cmdED4_9.Text = "ED4_9"
        Me.cmdED4_9.UseVisualStyleBackColor = True
        '
        'cmdED4_17
        '
        Me.cmdED4_17.AccessibleDescription = ""
        Me.cmdED4_17.Location = New System.Drawing.Point(519, 322)
        Me.cmdED4_17.Name = "cmdED4_17"
        Me.cmdED4_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_17.TabIndex = 112
        Me.cmdED4_17.Text = "ED4_17"
        Me.cmdED4_17.UseVisualStyleBackColor = True
        '
        'cmdED4_2
        '
        Me.cmdED4_2.AccessibleDescription = ""
        Me.cmdED4_2.Location = New System.Drawing.Point(519, 52)
        Me.cmdED4_2.Name = "cmdED4_2"
        Me.cmdED4_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_2.TabIndex = 97
        Me.cmdED4_2.Text = "ED4_2"
        Me.cmdED4_2.UseVisualStyleBackColor = True
        '
        'cmdED4_25
        '
        Me.cmdED4_25.AccessibleDescription = ""
        Me.cmdED4_25.Location = New System.Drawing.Point(519, 466)
        Me.cmdED4_25.Name = "cmdED4_25"
        Me.cmdED4_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_25.TabIndex = 120
        Me.cmdED4_25.Text = "ED4_25"
        Me.cmdED4_25.UseVisualStyleBackColor = True
        '
        'cmdED4_10
        '
        Me.cmdED4_10.AccessibleDescription = ""
        Me.cmdED4_10.Location = New System.Drawing.Point(519, 196)
        Me.cmdED4_10.Name = "cmdED4_10"
        Me.cmdED4_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_10.TabIndex = 105
        Me.cmdED4_10.Text = "ED4_10"
        Me.cmdED4_10.UseVisualStyleBackColor = True
        '
        'cmdED4_18
        '
        Me.cmdED4_18.AccessibleDescription = ""
        Me.cmdED4_18.Location = New System.Drawing.Point(519, 340)
        Me.cmdED4_18.Name = "cmdED4_18"
        Me.cmdED4_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_18.TabIndex = 113
        Me.cmdED4_18.Text = "ED4_18"
        Me.cmdED4_18.UseVisualStyleBackColor = True
        '
        'cmdED4_3
        '
        Me.cmdED4_3.AccessibleDescription = ""
        Me.cmdED4_3.Location = New System.Drawing.Point(519, 70)
        Me.cmdED4_3.Name = "cmdED4_3"
        Me.cmdED4_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_3.TabIndex = 98
        Me.cmdED4_3.Text = "ED4_3"
        Me.cmdED4_3.UseVisualStyleBackColor = True
        '
        'cmdED4_26
        '
        Me.cmdED4_26.AccessibleDescription = ""
        Me.cmdED4_26.Location = New System.Drawing.Point(519, 484)
        Me.cmdED4_26.Name = "cmdED4_26"
        Me.cmdED4_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_26.TabIndex = 121
        Me.cmdED4_26.Text = "ED4_26"
        Me.cmdED4_26.UseVisualStyleBackColor = True
        '
        'cmdED4_11
        '
        Me.cmdED4_11.AccessibleDescription = ""
        Me.cmdED4_11.Location = New System.Drawing.Point(519, 214)
        Me.cmdED4_11.Name = "cmdED4_11"
        Me.cmdED4_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_11.TabIndex = 106
        Me.cmdED4_11.Text = "ED4_11"
        Me.cmdED4_11.UseVisualStyleBackColor = True
        '
        'cmdED4_19
        '
        Me.cmdED4_19.AccessibleDescription = ""
        Me.cmdED4_19.Location = New System.Drawing.Point(519, 358)
        Me.cmdED4_19.Name = "cmdED4_19"
        Me.cmdED4_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_19.TabIndex = 114
        Me.cmdED4_19.Text = "ED4_19"
        Me.cmdED4_19.UseVisualStyleBackColor = True
        '
        'cmdED4_32
        '
        Me.cmdED4_32.AccessibleDescription = ""
        Me.cmdED4_32.Location = New System.Drawing.Point(519, 592)
        Me.cmdED4_32.Name = "cmdED4_32"
        Me.cmdED4_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_32.TabIndex = 127
        Me.cmdED4_32.Text = "ED4_32"
        Me.cmdED4_32.UseVisualStyleBackColor = True
        '
        'cmdED4_4
        '
        Me.cmdED4_4.AccessibleDescription = ""
        Me.cmdED4_4.Location = New System.Drawing.Point(519, 88)
        Me.cmdED4_4.Name = "cmdED4_4"
        Me.cmdED4_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_4.TabIndex = 99
        Me.cmdED4_4.Text = "ED4_4"
        Me.cmdED4_4.UseVisualStyleBackColor = True
        '
        'cmdED4_24
        '
        Me.cmdED4_24.AccessibleDescription = ""
        Me.cmdED4_24.Location = New System.Drawing.Point(519, 448)
        Me.cmdED4_24.Name = "cmdED4_24"
        Me.cmdED4_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_24.TabIndex = 119
        Me.cmdED4_24.Text = "ED4_24"
        Me.cmdED4_24.UseVisualStyleBackColor = True
        '
        'cmdED4_27
        '
        Me.cmdED4_27.AccessibleDescription = ""
        Me.cmdED4_27.Location = New System.Drawing.Point(519, 502)
        Me.cmdED4_27.Name = "cmdED4_27"
        Me.cmdED4_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_27.TabIndex = 122
        Me.cmdED4_27.Text = "ED4_27"
        Me.cmdED4_27.UseVisualStyleBackColor = True
        '
        'cmdED4_16
        '
        Me.cmdED4_16.AccessibleDescription = ""
        Me.cmdED4_16.Location = New System.Drawing.Point(519, 304)
        Me.cmdED4_16.Name = "cmdED4_16"
        Me.cmdED4_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_16.TabIndex = 111
        Me.cmdED4_16.Text = "ED4_16"
        Me.cmdED4_16.UseVisualStyleBackColor = True
        '
        'cmdED4_12
        '
        Me.cmdED4_12.AccessibleDescription = ""
        Me.cmdED4_12.Location = New System.Drawing.Point(519, 232)
        Me.cmdED4_12.Name = "cmdED4_12"
        Me.cmdED4_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_12.TabIndex = 107
        Me.cmdED4_12.Text = "ED4_12"
        Me.cmdED4_12.UseVisualStyleBackColor = True
        '
        'cmdED4_31
        '
        Me.cmdED4_31.AccessibleDescription = ""
        Me.cmdED4_31.Location = New System.Drawing.Point(519, 574)
        Me.cmdED4_31.Name = "cmdED4_31"
        Me.cmdED4_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_31.TabIndex = 126
        Me.cmdED4_31.Text = "ED4_31"
        Me.cmdED4_31.UseVisualStyleBackColor = True
        '
        'cmdED4_20
        '
        Me.cmdED4_20.AccessibleDescription = ""
        Me.cmdED4_20.Location = New System.Drawing.Point(519, 376)
        Me.cmdED4_20.Name = "cmdED4_20"
        Me.cmdED4_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_20.TabIndex = 115
        Me.cmdED4_20.Text = "ED4_20"
        Me.cmdED4_20.UseVisualStyleBackColor = True
        '
        'cmdED4_8
        '
        Me.cmdED4_8.AccessibleDescription = ""
        Me.cmdED4_8.Location = New System.Drawing.Point(519, 160)
        Me.cmdED4_8.Name = "cmdED4_8"
        Me.cmdED4_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_8.TabIndex = 103
        Me.cmdED4_8.Text = "ED4_8"
        Me.cmdED4_8.UseVisualStyleBackColor = True
        '
        'cmdED4_5
        '
        Me.cmdED4_5.AccessibleDescription = ""
        Me.cmdED4_5.Location = New System.Drawing.Point(519, 106)
        Me.cmdED4_5.Name = "cmdED4_5"
        Me.cmdED4_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_5.TabIndex = 100
        Me.cmdED4_5.Text = "ED4_5"
        Me.cmdED4_5.UseVisualStyleBackColor = True
        '
        'cmdED4_23
        '
        Me.cmdED4_23.AccessibleDescription = ""
        Me.cmdED4_23.Location = New System.Drawing.Point(519, 430)
        Me.cmdED4_23.Name = "cmdED4_23"
        Me.cmdED4_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_23.TabIndex = 118
        Me.cmdED4_23.Text = "ED4_23"
        Me.cmdED4_23.UseVisualStyleBackColor = True
        '
        'cmdED4_28
        '
        Me.cmdED4_28.AccessibleDescription = ""
        Me.cmdED4_28.Location = New System.Drawing.Point(519, 520)
        Me.cmdED4_28.Name = "cmdED4_28"
        Me.cmdED4_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_28.TabIndex = 123
        Me.cmdED4_28.Text = "ED4_28"
        Me.cmdED4_28.UseVisualStyleBackColor = True
        '
        'cmdED4_15
        '
        Me.cmdED4_15.AccessibleDescription = ""
        Me.cmdED4_15.Location = New System.Drawing.Point(519, 286)
        Me.cmdED4_15.Name = "cmdED4_15"
        Me.cmdED4_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_15.TabIndex = 110
        Me.cmdED4_15.Text = "ED4_15"
        Me.cmdED4_15.UseVisualStyleBackColor = True
        '
        'cmdED4_13
        '
        Me.cmdED4_13.AccessibleDescription = ""
        Me.cmdED4_13.Location = New System.Drawing.Point(519, 250)
        Me.cmdED4_13.Name = "cmdED4_13"
        Me.cmdED4_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_13.TabIndex = 108
        Me.cmdED4_13.Text = "ED4_13"
        Me.cmdED4_13.UseVisualStyleBackColor = True
        '
        'cmdED4_30
        '
        Me.cmdED4_30.AccessibleDescription = ""
        Me.cmdED4_30.Location = New System.Drawing.Point(519, 556)
        Me.cmdED4_30.Name = "cmdED4_30"
        Me.cmdED4_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_30.TabIndex = 125
        Me.cmdED4_30.Text = "ED4_30"
        Me.cmdED4_30.UseVisualStyleBackColor = True
        '
        'cmdED4_21
        '
        Me.cmdED4_21.AccessibleDescription = ""
        Me.cmdED4_21.Location = New System.Drawing.Point(519, 394)
        Me.cmdED4_21.Name = "cmdED4_21"
        Me.cmdED4_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_21.TabIndex = 116
        Me.cmdED4_21.Text = "ED4_21"
        Me.cmdED4_21.UseVisualStyleBackColor = True
        '
        'cmdED4_7
        '
        Me.cmdED4_7.AccessibleDescription = ""
        Me.cmdED4_7.Location = New System.Drawing.Point(519, 142)
        Me.cmdED4_7.Name = "cmdED4_7"
        Me.cmdED4_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_7.TabIndex = 102
        Me.cmdED4_7.Text = "ED4_7"
        Me.cmdED4_7.UseVisualStyleBackColor = True
        '
        'cmdED4_6
        '
        Me.cmdED4_6.AccessibleDescription = ""
        Me.cmdED4_6.Location = New System.Drawing.Point(519, 124)
        Me.cmdED4_6.Name = "cmdED4_6"
        Me.cmdED4_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_6.TabIndex = 101
        Me.cmdED4_6.Text = "ED4_6"
        Me.cmdED4_6.UseVisualStyleBackColor = True
        '
        'cmdED4_22
        '
        Me.cmdED4_22.AccessibleDescription = ""
        Me.cmdED4_22.Location = New System.Drawing.Point(519, 412)
        Me.cmdED4_22.Name = "cmdED4_22"
        Me.cmdED4_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_22.TabIndex = 117
        Me.cmdED4_22.Text = "ED4_22"
        Me.cmdED4_22.UseVisualStyleBackColor = True
        '
        'cmdED4_29
        '
        Me.cmdED4_29.AccessibleDescription = ""
        Me.cmdED4_29.Location = New System.Drawing.Point(519, 538)
        Me.cmdED4_29.Name = "cmdED4_29"
        Me.cmdED4_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_29.TabIndex = 124
        Me.cmdED4_29.Text = "ED4_29"
        Me.cmdED4_29.UseVisualStyleBackColor = True
        '
        'cmdED4_14
        '
        Me.cmdED4_14.AccessibleDescription = ""
        Me.cmdED4_14.Location = New System.Drawing.Point(519, 268)
        Me.cmdED4_14.Name = "cmdED4_14"
        Me.cmdED4_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED4_14.TabIndex = 109
        Me.cmdED4_14.Text = "ED4_14"
        Me.cmdED4_14.UseVisualStyleBackColor = True
        '
        'tbSD3_16
        '
        Me.tbSD3_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_16.Enabled = False
        Me.tbSD3_16.Location = New System.Drawing.Point(457, 304)
        Me.tbSD3_16.MaxLength = 15
        Me.tbSD3_16.Name = "tbSD3_16"
        Me.tbSD3_16.ReadOnly = True
        Me.tbSD3_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_16.TabIndex = 224
        Me.tbSD3_16.Text = "SD3_16"
        Me.tbSD3_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_15
        '
        Me.tbSD3_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_15.Enabled = False
        Me.tbSD3_15.Location = New System.Drawing.Point(457, 286)
        Me.tbSD3_15.MaxLength = 15
        Me.tbSD3_15.Name = "tbSD3_15"
        Me.tbSD3_15.ReadOnly = True
        Me.tbSD3_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_15.TabIndex = 225
        Me.tbSD3_15.Text = "SD3_15"
        Me.tbSD3_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_14
        '
        Me.tbSD3_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_14.Enabled = False
        Me.tbSD3_14.Location = New System.Drawing.Point(457, 268)
        Me.tbSD3_14.MaxLength = 15
        Me.tbSD3_14.Name = "tbSD3_14"
        Me.tbSD3_14.ReadOnly = True
        Me.tbSD3_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_14.TabIndex = 226
        Me.tbSD3_14.Text = "SD3_14"
        Me.tbSD3_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_13
        '
        Me.tbSD3_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_13.Enabled = False
        Me.tbSD3_13.Location = New System.Drawing.Point(457, 249)
        Me.tbSD3_13.MaxLength = 15
        Me.tbSD3_13.Name = "tbSD3_13"
        Me.tbSD3_13.ReadOnly = True
        Me.tbSD3_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_13.TabIndex = 227
        Me.tbSD3_13.Text = "SD3_13"
        Me.tbSD3_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_12
        '
        Me.tbSD3_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_12.Enabled = False
        Me.tbSD3_12.Location = New System.Drawing.Point(457, 232)
        Me.tbSD3_12.MaxLength = 15
        Me.tbSD3_12.Name = "tbSD3_12"
        Me.tbSD3_12.ReadOnly = True
        Me.tbSD3_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_12.TabIndex = 228
        Me.tbSD3_12.Text = "SD3_12"
        Me.tbSD3_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_11
        '
        Me.tbSD3_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_11.Enabled = False
        Me.tbSD3_11.Location = New System.Drawing.Point(457, 214)
        Me.tbSD3_11.MaxLength = 15
        Me.tbSD3_11.Name = "tbSD3_11"
        Me.tbSD3_11.ReadOnly = True
        Me.tbSD3_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_11.TabIndex = 229
        Me.tbSD3_11.Text = "SD3_11"
        Me.tbSD3_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_10
        '
        Me.tbSD3_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_10.Enabled = False
        Me.tbSD3_10.Location = New System.Drawing.Point(457, 195)
        Me.tbSD3_10.MaxLength = 15
        Me.tbSD3_10.Name = "tbSD3_10"
        Me.tbSD3_10.ReadOnly = True
        Me.tbSD3_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_10.TabIndex = 230
        Me.tbSD3_10.Text = "SD3_10"
        Me.tbSD3_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_9
        '
        Me.tbSD3_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_9.Enabled = False
        Me.tbSD3_9.Location = New System.Drawing.Point(457, 178)
        Me.tbSD3_9.MaxLength = 15
        Me.tbSD3_9.Name = "tbSD3_9"
        Me.tbSD3_9.ReadOnly = True
        Me.tbSD3_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_9.TabIndex = 231
        Me.tbSD3_9.Text = "SD3_9"
        Me.tbSD3_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_8
        '
        Me.tbSD3_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_8.Enabled = False
        Me.tbSD3_8.Location = New System.Drawing.Point(457, 160)
        Me.tbSD3_8.MaxLength = 15
        Me.tbSD3_8.Name = "tbSD3_8"
        Me.tbSD3_8.ReadOnly = True
        Me.tbSD3_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_8.TabIndex = 232
        Me.tbSD3_8.Text = "SD3_8"
        Me.tbSD3_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_7
        '
        Me.tbSD3_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_7.Enabled = False
        Me.tbSD3_7.Location = New System.Drawing.Point(457, 142)
        Me.tbSD3_7.MaxLength = 15
        Me.tbSD3_7.Name = "tbSD3_7"
        Me.tbSD3_7.ReadOnly = True
        Me.tbSD3_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_7.TabIndex = 233
        Me.tbSD3_7.Text = "SD3_7"
        Me.tbSD3_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_6
        '
        Me.tbSD3_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_6.Enabled = False
        Me.tbSD3_6.Location = New System.Drawing.Point(457, 124)
        Me.tbSD3_6.MaxLength = 15
        Me.tbSD3_6.Name = "tbSD3_6"
        Me.tbSD3_6.ReadOnly = True
        Me.tbSD3_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_6.TabIndex = 234
        Me.tbSD3_6.Text = "SD3_6"
        Me.tbSD3_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_5
        '
        Me.tbSD3_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_5.Enabled = False
        Me.tbSD3_5.Location = New System.Drawing.Point(457, 106)
        Me.tbSD3_5.MaxLength = 15
        Me.tbSD3_5.Name = "tbSD3_5"
        Me.tbSD3_5.ReadOnly = True
        Me.tbSD3_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_5.TabIndex = 235
        Me.tbSD3_5.Text = "SD3_5"
        Me.tbSD3_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_4
        '
        Me.tbSD3_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_4.Enabled = False
        Me.tbSD3_4.Location = New System.Drawing.Point(457, 87)
        Me.tbSD3_4.MaxLength = 15
        Me.tbSD3_4.Name = "tbSD3_4"
        Me.tbSD3_4.ReadOnly = True
        Me.tbSD3_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_4.TabIndex = 236
        Me.tbSD3_4.Text = "SD3_4"
        Me.tbSD3_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_3
        '
        Me.tbSD3_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_3.Enabled = False
        Me.tbSD3_3.Location = New System.Drawing.Point(457, 70)
        Me.tbSD3_3.MaxLength = 15
        Me.tbSD3_3.Name = "tbSD3_3"
        Me.tbSD3_3.ReadOnly = True
        Me.tbSD3_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_3.TabIndex = 237
        Me.tbSD3_3.Text = "SD3_3"
        Me.tbSD3_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_2
        '
        Me.tbSD3_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_2.Enabled = False
        Me.tbSD3_2.Location = New System.Drawing.Point(457, 52)
        Me.tbSD3_2.MaxLength = 15
        Me.tbSD3_2.Name = "tbSD3_2"
        Me.tbSD3_2.ReadOnly = True
        Me.tbSD3_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_2.TabIndex = 238
        Me.tbSD3_2.Text = "SD3_2"
        Me.tbSD3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD3_1
        '
        Me.tbSD3_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD3_1.Enabled = False
        Me.tbSD3_1.Location = New System.Drawing.Point(457, 35)
        Me.tbSD3_1.MaxLength = 15
        Me.tbSD3_1.Name = "tbSD3_1"
        Me.tbSD3_1.ReadOnly = True
        Me.tbSD3_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD3_1.TabIndex = 239
        Me.tbSD3_1.Text = "SD3_1"
        Me.tbSD3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED3_32
        '
        Me.lbED3_32.AutoSize = True
        Me.lbED3_32.Location = New System.Drawing.Point(399, 593)
        Me.lbED3_32.Name = "lbED3_32"
        Me.lbED3_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_32.TabIndex = 4
        Me.lbED3_32.Text = "ED3_32"
        '
        'lbED3_31
        '
        Me.lbED3_31.AutoSize = True
        Me.lbED3_31.Location = New System.Drawing.Point(399, 575)
        Me.lbED3_31.Name = "lbED3_31"
        Me.lbED3_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_31.TabIndex = 4
        Me.lbED3_31.Text = "ED3_31"
        '
        'lbED3_16
        '
        Me.lbED3_16.AutoSize = True
        Me.lbED3_16.Location = New System.Drawing.Point(399, 305)
        Me.lbED3_16.Name = "lbED3_16"
        Me.lbED3_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_16.TabIndex = 4
        Me.lbED3_16.Text = "ED3_16"
        '
        'lbED3_24
        '
        Me.lbED3_24.AutoSize = True
        Me.lbED3_24.Location = New System.Drawing.Point(399, 449)
        Me.lbED3_24.Name = "lbED3_24"
        Me.lbED3_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_24.TabIndex = 4
        Me.lbED3_24.Text = "ED3_24"
        '
        'lbED3_15
        '
        Me.lbED3_15.AutoSize = True
        Me.lbED3_15.Location = New System.Drawing.Point(399, 287)
        Me.lbED3_15.Name = "lbED3_15"
        Me.lbED3_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_15.TabIndex = 4
        Me.lbED3_15.Text = "ED3_15"
        '
        'lbED3_28
        '
        Me.lbED3_28.AutoSize = True
        Me.lbED3_28.Location = New System.Drawing.Point(399, 521)
        Me.lbED3_28.Name = "lbED3_28"
        Me.lbED3_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_28.TabIndex = 4
        Me.lbED3_28.Text = "ED3_28"
        '
        'lbED3_8
        '
        Me.lbED3_8.AutoSize = True
        Me.lbED3_8.Location = New System.Drawing.Point(399, 161)
        Me.lbED3_8.Name = "lbED3_8"
        Me.lbED3_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_8.TabIndex = 4
        Me.lbED3_8.Text = "ED3_8"
        '
        'lbED3_23
        '
        Me.lbED3_23.AutoSize = True
        Me.lbED3_23.Location = New System.Drawing.Point(399, 431)
        Me.lbED3_23.Name = "lbED3_23"
        Me.lbED3_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_23.TabIndex = 4
        Me.lbED3_23.Text = "ED3_23"
        '
        'lbED3_12
        '
        Me.lbED3_12.AutoSize = True
        Me.lbED3_12.Location = New System.Drawing.Point(399, 233)
        Me.lbED3_12.Name = "lbED3_12"
        Me.lbED3_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_12.TabIndex = 4
        Me.lbED3_12.Text = "ED3_12"
        '
        'lbED3_30
        '
        Me.lbED3_30.AutoSize = True
        Me.lbED3_30.Location = New System.Drawing.Point(399, 557)
        Me.lbED3_30.Name = "lbED3_30"
        Me.lbED3_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_30.TabIndex = 4
        Me.lbED3_30.Text = "ED3_30"
        '
        'lbED3_7
        '
        Me.lbED3_7.AutoSize = True
        Me.lbED3_7.Location = New System.Drawing.Point(399, 143)
        Me.lbED3_7.Name = "lbED3_7"
        Me.lbED3_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_7.TabIndex = 4
        Me.lbED3_7.Text = "ED3_7"
        '
        'lbED3_20
        '
        Me.lbED3_20.AutoSize = True
        Me.lbED3_20.Location = New System.Drawing.Point(399, 377)
        Me.lbED3_20.Name = "lbED3_20"
        Me.lbED3_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_20.TabIndex = 4
        Me.lbED3_20.Text = "ED3_20"
        '
        'lbED3_14
        '
        Me.lbED3_14.AutoSize = True
        Me.lbED3_14.Location = New System.Drawing.Point(399, 269)
        Me.lbED3_14.Name = "lbED3_14"
        Me.lbED3_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_14.TabIndex = 4
        Me.lbED3_14.Text = "ED3_14"
        '
        'lbED3_27
        '
        Me.lbED3_27.AutoSize = True
        Me.lbED3_27.Location = New System.Drawing.Point(399, 503)
        Me.lbED3_27.Name = "lbED3_27"
        Me.lbED3_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_27.TabIndex = 4
        Me.lbED3_27.Text = "ED3_27"
        '
        'lbED3_4
        '
        Me.lbED3_4.AutoSize = True
        Me.lbED3_4.Location = New System.Drawing.Point(399, 89)
        Me.lbED3_4.Name = "lbED3_4"
        Me.lbED3_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_4.TabIndex = 4
        Me.lbED3_4.Text = "ED3_4"
        '
        'lbED3_22
        '
        Me.lbED3_22.AutoSize = True
        Me.lbED3_22.Location = New System.Drawing.Point(399, 413)
        Me.lbED3_22.Name = "lbED3_22"
        Me.lbED3_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_22.TabIndex = 4
        Me.lbED3_22.Text = "ED3_22"
        '
        'lbED3_11
        '
        Me.lbED3_11.AutoSize = True
        Me.lbED3_11.Location = New System.Drawing.Point(399, 215)
        Me.lbED3_11.Name = "lbED3_11"
        Me.lbED3_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_11.TabIndex = 4
        Me.lbED3_11.Text = "ED3_11"
        '
        'lbED3_29
        '
        Me.lbED3_29.AutoSize = True
        Me.lbED3_29.Location = New System.Drawing.Point(399, 539)
        Me.lbED3_29.Name = "lbED3_29"
        Me.lbED3_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_29.TabIndex = 4
        Me.lbED3_29.Text = "ED3_29"
        '
        'lbED3_6
        '
        Me.lbED3_6.AutoSize = True
        Me.lbED3_6.Location = New System.Drawing.Point(399, 125)
        Me.lbED3_6.Name = "lbED3_6"
        Me.lbED3_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_6.TabIndex = 4
        Me.lbED3_6.Text = "ED3_6"
        '
        'lbED3_19
        '
        Me.lbED3_19.AutoSize = True
        Me.lbED3_19.Location = New System.Drawing.Point(399, 359)
        Me.lbED3_19.Name = "lbED3_19"
        Me.lbED3_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_19.TabIndex = 4
        Me.lbED3_19.Text = "ED3_19"
        '
        'lbED3_13
        '
        Me.lbED3_13.AutoSize = True
        Me.lbED3_13.Location = New System.Drawing.Point(399, 251)
        Me.lbED3_13.Name = "lbED3_13"
        Me.lbED3_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_13.TabIndex = 4
        Me.lbED3_13.Text = "ED3_13"
        '
        'lbED3_26
        '
        Me.lbED3_26.AutoSize = True
        Me.lbED3_26.Location = New System.Drawing.Point(399, 485)
        Me.lbED3_26.Name = "lbED3_26"
        Me.lbED3_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_26.TabIndex = 4
        Me.lbED3_26.Text = "ED3_26"
        '
        'lbED3_3
        '
        Me.lbED3_3.AutoSize = True
        Me.lbED3_3.Location = New System.Drawing.Point(399, 71)
        Me.lbED3_3.Name = "lbED3_3"
        Me.lbED3_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_3.TabIndex = 4
        Me.lbED3_3.Text = "ED3_3"
        '
        'lbED3_21
        '
        Me.lbED3_21.AutoSize = True
        Me.lbED3_21.Location = New System.Drawing.Point(399, 395)
        Me.lbED3_21.Name = "lbED3_21"
        Me.lbED3_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_21.TabIndex = 4
        Me.lbED3_21.Text = "ED3_21"
        '
        'lbED3_10
        '
        Me.lbED3_10.AutoSize = True
        Me.lbED3_10.Location = New System.Drawing.Point(399, 197)
        Me.lbED3_10.Name = "lbED3_10"
        Me.lbED3_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_10.TabIndex = 4
        Me.lbED3_10.Text = "ED3_10"
        '
        'lbED3_25
        '
        Me.lbED3_25.AutoSize = True
        Me.lbED3_25.Location = New System.Drawing.Point(399, 467)
        Me.lbED3_25.Name = "lbED3_25"
        Me.lbED3_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_25.TabIndex = 4
        Me.lbED3_25.Text = "ED3_25"
        '
        'lbED3_5
        '
        Me.lbED3_5.AutoSize = True
        Me.lbED3_5.Location = New System.Drawing.Point(399, 107)
        Me.lbED3_5.Name = "lbED3_5"
        Me.lbED3_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_5.TabIndex = 4
        Me.lbED3_5.Text = "ED3_5"
        '
        'lbED3_18
        '
        Me.lbED3_18.AutoSize = True
        Me.lbED3_18.Location = New System.Drawing.Point(399, 341)
        Me.lbED3_18.Name = "lbED3_18"
        Me.lbED3_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_18.TabIndex = 4
        Me.lbED3_18.Text = "ED3_18"
        '
        'lbED3_9
        '
        Me.lbED3_9.AutoSize = True
        Me.lbED3_9.Location = New System.Drawing.Point(399, 179)
        Me.lbED3_9.Name = "lbED3_9"
        Me.lbED3_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_9.TabIndex = 4
        Me.lbED3_9.Text = "ED3_9"
        '
        'lbED3_17
        '
        Me.lbED3_17.AutoSize = True
        Me.lbED3_17.Location = New System.Drawing.Point(399, 323)
        Me.lbED3_17.Name = "lbED3_17"
        Me.lbED3_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED3_17.TabIndex = 4
        Me.lbED3_17.Text = "ED3_17"
        '
        'lbED3_2
        '
        Me.lbED3_2.AutoSize = True
        Me.lbED3_2.Location = New System.Drawing.Point(399, 53)
        Me.lbED3_2.Name = "lbED3_2"
        Me.lbED3_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_2.TabIndex = 4
        Me.lbED3_2.Text = "ED3_2"
        '
        'lbED3_1
        '
        Me.lbED3_1.AutoSize = True
        Me.lbED3_1.Location = New System.Drawing.Point(399, 35)
        Me.lbED3_1.Name = "lbED3_1"
        Me.lbED3_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED3_1.TabIndex = 4
        Me.lbED3_1.Text = "ED3_1"
        '
        'cmdED3_1
        '
        Me.cmdED3_1.AccessibleDescription = ""
        Me.cmdED3_1.Location = New System.Drawing.Point(347, 32)
        Me.cmdED3_1.Name = "cmdED3_1"
        Me.cmdED3_1.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_1.TabIndex = 64
        Me.cmdED3_1.Text = "ED3_1"
        Me.cmdED3_1.UseVisualStyleBackColor = True
        '
        'cmdED3_9
        '
        Me.cmdED3_9.AccessibleDescription = ""
        Me.cmdED3_9.Location = New System.Drawing.Point(347, 176)
        Me.cmdED3_9.Name = "cmdED3_9"
        Me.cmdED3_9.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_9.TabIndex = 72
        Me.cmdED3_9.Text = "ED3_9"
        Me.cmdED3_9.UseVisualStyleBackColor = True
        '
        'cmdED3_17
        '
        Me.cmdED3_17.AccessibleDescription = ""
        Me.cmdED3_17.Location = New System.Drawing.Point(347, 320)
        Me.cmdED3_17.Name = "cmdED3_17"
        Me.cmdED3_17.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_17.TabIndex = 80
        Me.cmdED3_17.Text = "ED3_17"
        Me.cmdED3_17.UseVisualStyleBackColor = True
        '
        'cmdED3_2
        '
        Me.cmdED3_2.AccessibleDescription = ""
        Me.cmdED3_2.Location = New System.Drawing.Point(347, 50)
        Me.cmdED3_2.Name = "cmdED3_2"
        Me.cmdED3_2.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_2.TabIndex = 65
        Me.cmdED3_2.Text = "ED3_2"
        Me.cmdED3_2.UseVisualStyleBackColor = True
        '
        'cmdED3_25
        '
        Me.cmdED3_25.AccessibleDescription = ""
        Me.cmdED3_25.Location = New System.Drawing.Point(347, 464)
        Me.cmdED3_25.Name = "cmdED3_25"
        Me.cmdED3_25.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_25.TabIndex = 88
        Me.cmdED3_25.Text = "ED3_25"
        Me.cmdED3_25.UseVisualStyleBackColor = True
        '
        'cmdED3_10
        '
        Me.cmdED3_10.AccessibleDescription = ""
        Me.cmdED3_10.Location = New System.Drawing.Point(347, 194)
        Me.cmdED3_10.Name = "cmdED3_10"
        Me.cmdED3_10.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_10.TabIndex = 73
        Me.cmdED3_10.Text = "ED3_10"
        Me.cmdED3_10.UseVisualStyleBackColor = True
        '
        'cmdED3_18
        '
        Me.cmdED3_18.AccessibleDescription = ""
        Me.cmdED3_18.Location = New System.Drawing.Point(347, 338)
        Me.cmdED3_18.Name = "cmdED3_18"
        Me.cmdED3_18.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_18.TabIndex = 81
        Me.cmdED3_18.Text = "ED3_18"
        Me.cmdED3_18.UseVisualStyleBackColor = True
        '
        'cmdED3_3
        '
        Me.cmdED3_3.AccessibleDescription = ""
        Me.cmdED3_3.Location = New System.Drawing.Point(347, 68)
        Me.cmdED3_3.Name = "cmdED3_3"
        Me.cmdED3_3.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_3.TabIndex = 66
        Me.cmdED3_3.Text = "ED3_3"
        Me.cmdED3_3.UseVisualStyleBackColor = True
        '
        'cmdED3_26
        '
        Me.cmdED3_26.AccessibleDescription = ""
        Me.cmdED3_26.Location = New System.Drawing.Point(347, 482)
        Me.cmdED3_26.Name = "cmdED3_26"
        Me.cmdED3_26.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_26.TabIndex = 89
        Me.cmdED3_26.Text = "ED3_26"
        Me.cmdED3_26.UseVisualStyleBackColor = True
        '
        'cmdED3_11
        '
        Me.cmdED3_11.AccessibleDescription = ""
        Me.cmdED3_11.Location = New System.Drawing.Point(347, 212)
        Me.cmdED3_11.Name = "cmdED3_11"
        Me.cmdED3_11.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_11.TabIndex = 74
        Me.cmdED3_11.Text = "ED3_11"
        Me.cmdED3_11.UseVisualStyleBackColor = True
        '
        'cmdED3_19
        '
        Me.cmdED3_19.AccessibleDescription = ""
        Me.cmdED3_19.Location = New System.Drawing.Point(347, 356)
        Me.cmdED3_19.Name = "cmdED3_19"
        Me.cmdED3_19.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_19.TabIndex = 82
        Me.cmdED3_19.Text = "ED3_19"
        Me.cmdED3_19.UseVisualStyleBackColor = True
        '
        'cmdED3_4
        '
        Me.cmdED3_4.AccessibleDescription = ""
        Me.cmdED3_4.Location = New System.Drawing.Point(347, 86)
        Me.cmdED3_4.Name = "cmdED3_4"
        Me.cmdED3_4.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_4.TabIndex = 67
        Me.cmdED3_4.Text = "ED3_4"
        Me.cmdED3_4.UseVisualStyleBackColor = True
        '
        'cmdED3_32
        '
        Me.cmdED3_32.AccessibleDescription = ""
        Me.cmdED3_32.Location = New System.Drawing.Point(347, 590)
        Me.cmdED3_32.Name = "cmdED3_32"
        Me.cmdED3_32.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_32.TabIndex = 95
        Me.cmdED3_32.Text = "ED3_32"
        Me.cmdED3_32.UseVisualStyleBackColor = True
        '
        'cmdED3_27
        '
        Me.cmdED3_27.AccessibleDescription = ""
        Me.cmdED3_27.Location = New System.Drawing.Point(347, 500)
        Me.cmdED3_27.Name = "cmdED3_27"
        Me.cmdED3_27.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_27.TabIndex = 90
        Me.cmdED3_27.Text = "ED3_27"
        Me.cmdED3_27.UseVisualStyleBackColor = True
        '
        'cmdED3_24
        '
        Me.cmdED3_24.AccessibleDescription = ""
        Me.cmdED3_24.Location = New System.Drawing.Point(347, 446)
        Me.cmdED3_24.Name = "cmdED3_24"
        Me.cmdED3_24.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_24.TabIndex = 87
        Me.cmdED3_24.Text = "ED3_24"
        Me.cmdED3_24.UseVisualStyleBackColor = True
        '
        'cmdED3_12
        '
        Me.cmdED3_12.AccessibleDescription = ""
        Me.cmdED3_12.Location = New System.Drawing.Point(347, 230)
        Me.cmdED3_12.Name = "cmdED3_12"
        Me.cmdED3_12.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_12.TabIndex = 75
        Me.cmdED3_12.Text = "ED3_12"
        Me.cmdED3_12.UseVisualStyleBackColor = True
        '
        'cmdED3_16
        '
        Me.cmdED3_16.AccessibleDescription = ""
        Me.cmdED3_16.Location = New System.Drawing.Point(347, 302)
        Me.cmdED3_16.Name = "cmdED3_16"
        Me.cmdED3_16.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_16.TabIndex = 79
        Me.cmdED3_16.Text = "ED3_16"
        Me.cmdED3_16.UseVisualStyleBackColor = True
        '
        'cmdED3_20
        '
        Me.cmdED3_20.AccessibleDescription = ""
        Me.cmdED3_20.Location = New System.Drawing.Point(347, 374)
        Me.cmdED3_20.Name = "cmdED3_20"
        Me.cmdED3_20.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_20.TabIndex = 83
        Me.cmdED3_20.Text = "ED3_20"
        Me.cmdED3_20.UseVisualStyleBackColor = True
        '
        'cmdED3_31
        '
        Me.cmdED3_31.AccessibleDescription = ""
        Me.cmdED3_31.Location = New System.Drawing.Point(347, 572)
        Me.cmdED3_31.Name = "cmdED3_31"
        Me.cmdED3_31.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_31.TabIndex = 94
        Me.cmdED3_31.Text = "ED3_31"
        Me.cmdED3_31.UseVisualStyleBackColor = True
        '
        'cmdED3_5
        '
        Me.cmdED3_5.AccessibleDescription = ""
        Me.cmdED3_5.Location = New System.Drawing.Point(347, 104)
        Me.cmdED3_5.Name = "cmdED3_5"
        Me.cmdED3_5.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_5.TabIndex = 68
        Me.cmdED3_5.Text = "ED3_5"
        Me.cmdED3_5.UseVisualStyleBackColor = True
        '
        'cmdED3_8
        '
        Me.cmdED3_8.AccessibleDescription = ""
        Me.cmdED3_8.Location = New System.Drawing.Point(347, 158)
        Me.cmdED3_8.Name = "cmdED3_8"
        Me.cmdED3_8.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_8.TabIndex = 71
        Me.cmdED3_8.Text = "ED3_8"
        Me.cmdED3_8.UseVisualStyleBackColor = True
        '
        'cmdED3_28
        '
        Me.cmdED3_28.AccessibleDescription = ""
        Me.cmdED3_28.Location = New System.Drawing.Point(347, 518)
        Me.cmdED3_28.Name = "cmdED3_28"
        Me.cmdED3_28.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_28.TabIndex = 91
        Me.cmdED3_28.Text = "ED3_28"
        Me.cmdED3_28.UseVisualStyleBackColor = True
        '
        'cmdED3_23
        '
        Me.cmdED3_23.AccessibleDescription = ""
        Me.cmdED3_23.Location = New System.Drawing.Point(347, 428)
        Me.cmdED3_23.Name = "cmdED3_23"
        Me.cmdED3_23.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_23.TabIndex = 86
        Me.cmdED3_23.Text = "ED3_23"
        Me.cmdED3_23.UseVisualStyleBackColor = True
        '
        'cmdED3_13
        '
        Me.cmdED3_13.AccessibleDescription = ""
        Me.cmdED3_13.Location = New System.Drawing.Point(347, 248)
        Me.cmdED3_13.Name = "cmdED3_13"
        Me.cmdED3_13.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_13.TabIndex = 76
        Me.cmdED3_13.Text = "ED3_13"
        Me.cmdED3_13.UseVisualStyleBackColor = True
        '
        'cmdED3_15
        '
        Me.cmdED3_15.AccessibleDescription = ""
        Me.cmdED3_15.Location = New System.Drawing.Point(347, 284)
        Me.cmdED3_15.Name = "cmdED3_15"
        Me.cmdED3_15.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_15.TabIndex = 78
        Me.cmdED3_15.Text = "ED3_15"
        Me.cmdED3_15.UseVisualStyleBackColor = True
        '
        'cmdED3_21
        '
        Me.cmdED3_21.AccessibleDescription = ""
        Me.cmdED3_21.Location = New System.Drawing.Point(347, 392)
        Me.cmdED3_21.Name = "cmdED3_21"
        Me.cmdED3_21.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_21.TabIndex = 84
        Me.cmdED3_21.Text = "ED3_21"
        Me.cmdED3_21.UseVisualStyleBackColor = True
        '
        'cmdED3_30
        '
        Me.cmdED3_30.AccessibleDescription = ""
        Me.cmdED3_30.Location = New System.Drawing.Point(347, 554)
        Me.cmdED3_30.Name = "cmdED3_30"
        Me.cmdED3_30.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_30.TabIndex = 93
        Me.cmdED3_30.Text = "ED3_30"
        Me.cmdED3_30.UseVisualStyleBackColor = True
        '
        'cmdED3_6
        '
        Me.cmdED3_6.AccessibleDescription = ""
        Me.cmdED3_6.Location = New System.Drawing.Point(347, 122)
        Me.cmdED3_6.Name = "cmdED3_6"
        Me.cmdED3_6.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_6.TabIndex = 69
        Me.cmdED3_6.Text = "ED3_6"
        Me.cmdED3_6.UseVisualStyleBackColor = True
        '
        'cmdED3_7
        '
        Me.cmdED3_7.AccessibleDescription = ""
        Me.cmdED3_7.Location = New System.Drawing.Point(347, 140)
        Me.cmdED3_7.Name = "cmdED3_7"
        Me.cmdED3_7.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_7.TabIndex = 70
        Me.cmdED3_7.Text = "ED3_7"
        Me.cmdED3_7.UseVisualStyleBackColor = True
        '
        'cmdED3_29
        '
        Me.cmdED3_29.AccessibleDescription = ""
        Me.cmdED3_29.Location = New System.Drawing.Point(347, 536)
        Me.cmdED3_29.Name = "cmdED3_29"
        Me.cmdED3_29.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_29.TabIndex = 92
        Me.cmdED3_29.Text = "ED3_29"
        Me.cmdED3_29.UseVisualStyleBackColor = True
        '
        'cmdED3_22
        '
        Me.cmdED3_22.AccessibleDescription = ""
        Me.cmdED3_22.Location = New System.Drawing.Point(347, 410)
        Me.cmdED3_22.Name = "cmdED3_22"
        Me.cmdED3_22.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_22.TabIndex = 85
        Me.cmdED3_22.Text = "ED3_22"
        Me.cmdED3_22.UseVisualStyleBackColor = True
        '
        'cmdED3_14
        '
        Me.cmdED3_14.AccessibleDescription = ""
        Me.cmdED3_14.Location = New System.Drawing.Point(347, 266)
        Me.cmdED3_14.Name = "cmdED3_14"
        Me.cmdED3_14.Size = New System.Drawing.Size(54, 19)
        Me.cmdED3_14.TabIndex = 77
        Me.cmdED3_14.Text = "ED3_14"
        Me.cmdED3_14.UseVisualStyleBackColor = True
        '
        'tbSD2_16
        '
        Me.tbSD2_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_16.Enabled = False
        Me.tbSD2_16.Location = New System.Drawing.Point(283, 302)
        Me.tbSD2_16.MaxLength = 15
        Me.tbSD2_16.Name = "tbSD2_16"
        Me.tbSD2_16.ReadOnly = True
        Me.tbSD2_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_16.TabIndex = 3
        Me.tbSD2_16.Text = "SD2_16"
        Me.tbSD2_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_15
        '
        Me.tbSD2_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_15.Enabled = False
        Me.tbSD2_15.Location = New System.Drawing.Point(283, 284)
        Me.tbSD2_15.MaxLength = 15
        Me.tbSD2_15.Name = "tbSD2_15"
        Me.tbSD2_15.ReadOnly = True
        Me.tbSD2_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_15.TabIndex = 3
        Me.tbSD2_15.Text = "SD2_15"
        Me.tbSD2_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_14
        '
        Me.tbSD2_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_14.Enabled = False
        Me.tbSD2_14.Location = New System.Drawing.Point(283, 266)
        Me.tbSD2_14.MaxLength = 15
        Me.tbSD2_14.Name = "tbSD2_14"
        Me.tbSD2_14.ReadOnly = True
        Me.tbSD2_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_14.TabIndex = 3
        Me.tbSD2_14.Text = "SD2_14"
        Me.tbSD2_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_13
        '
        Me.tbSD2_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_13.Enabled = False
        Me.tbSD2_13.Location = New System.Drawing.Point(283, 247)
        Me.tbSD2_13.MaxLength = 15
        Me.tbSD2_13.Name = "tbSD2_13"
        Me.tbSD2_13.ReadOnly = True
        Me.tbSD2_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_13.TabIndex = 3
        Me.tbSD2_13.Text = "SD2_13"
        Me.tbSD2_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_12
        '
        Me.tbSD2_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_12.Enabled = False
        Me.tbSD2_12.Location = New System.Drawing.Point(283, 230)
        Me.tbSD2_12.MaxLength = 15
        Me.tbSD2_12.Name = "tbSD2_12"
        Me.tbSD2_12.ReadOnly = True
        Me.tbSD2_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_12.TabIndex = 3
        Me.tbSD2_12.Text = "SD2_12"
        Me.tbSD2_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_11
        '
        Me.tbSD2_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_11.Enabled = False
        Me.tbSD2_11.Location = New System.Drawing.Point(283, 212)
        Me.tbSD2_11.MaxLength = 15
        Me.tbSD2_11.Name = "tbSD2_11"
        Me.tbSD2_11.ReadOnly = True
        Me.tbSD2_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_11.TabIndex = 3
        Me.tbSD2_11.Text = "SD2_11"
        Me.tbSD2_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_10
        '
        Me.tbSD2_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_10.Enabled = False
        Me.tbSD2_10.Location = New System.Drawing.Point(283, 193)
        Me.tbSD2_10.MaxLength = 15
        Me.tbSD2_10.Name = "tbSD2_10"
        Me.tbSD2_10.ReadOnly = True
        Me.tbSD2_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_10.TabIndex = 3
        Me.tbSD2_10.Text = "SD2_10"
        Me.tbSD2_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_9
        '
        Me.tbSD2_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_9.Enabled = False
        Me.tbSD2_9.Location = New System.Drawing.Point(283, 176)
        Me.tbSD2_9.MaxLength = 15
        Me.tbSD2_9.Name = "tbSD2_9"
        Me.tbSD2_9.ReadOnly = True
        Me.tbSD2_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_9.TabIndex = 3
        Me.tbSD2_9.Text = "SD2_9"
        Me.tbSD2_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_8
        '
        Me.tbSD2_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_8.Enabled = False
        Me.tbSD2_8.Location = New System.Drawing.Point(283, 158)
        Me.tbSD2_8.MaxLength = 15
        Me.tbSD2_8.Name = "tbSD2_8"
        Me.tbSD2_8.ReadOnly = True
        Me.tbSD2_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_8.TabIndex = 3
        Me.tbSD2_8.Text = "SD2_8"
        Me.tbSD2_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_7
        '
        Me.tbSD2_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_7.Enabled = False
        Me.tbSD2_7.Location = New System.Drawing.Point(283, 140)
        Me.tbSD2_7.MaxLength = 15
        Me.tbSD2_7.Name = "tbSD2_7"
        Me.tbSD2_7.ReadOnly = True
        Me.tbSD2_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_7.TabIndex = 3
        Me.tbSD2_7.Text = "SD2_7"
        Me.tbSD2_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_6
        '
        Me.tbSD2_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_6.Enabled = False
        Me.tbSD2_6.Location = New System.Drawing.Point(283, 122)
        Me.tbSD2_6.MaxLength = 15
        Me.tbSD2_6.Name = "tbSD2_6"
        Me.tbSD2_6.ReadOnly = True
        Me.tbSD2_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_6.TabIndex = 3
        Me.tbSD2_6.Text = "SD2_6"
        Me.tbSD2_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_5
        '
        Me.tbSD2_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_5.Enabled = False
        Me.tbSD2_5.Location = New System.Drawing.Point(283, 104)
        Me.tbSD2_5.MaxLength = 15
        Me.tbSD2_5.Name = "tbSD2_5"
        Me.tbSD2_5.ReadOnly = True
        Me.tbSD2_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_5.TabIndex = 3
        Me.tbSD2_5.Text = "SD2_5"
        Me.tbSD2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_4
        '
        Me.tbSD2_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_4.Enabled = False
        Me.tbSD2_4.Location = New System.Drawing.Point(283, 85)
        Me.tbSD2_4.MaxLength = 15
        Me.tbSD2_4.Name = "tbSD2_4"
        Me.tbSD2_4.ReadOnly = True
        Me.tbSD2_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_4.TabIndex = 3
        Me.tbSD2_4.Text = "SD2_4"
        Me.tbSD2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_3
        '
        Me.tbSD2_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_3.Enabled = False
        Me.tbSD2_3.Location = New System.Drawing.Point(283, 68)
        Me.tbSD2_3.MaxLength = 15
        Me.tbSD2_3.Name = "tbSD2_3"
        Me.tbSD2_3.ReadOnly = True
        Me.tbSD2_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_3.TabIndex = 3
        Me.tbSD2_3.Text = "SD2_3"
        Me.tbSD2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_2
        '
        Me.tbSD2_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_2.Enabled = False
        Me.tbSD2_2.Location = New System.Drawing.Point(283, 50)
        Me.tbSD2_2.MaxLength = 15
        Me.tbSD2_2.Name = "tbSD2_2"
        Me.tbSD2_2.ReadOnly = True
        Me.tbSD2_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_2.TabIndex = 3
        Me.tbSD2_2.Text = "SD2_2"
        Me.tbSD2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD2_1
        '
        Me.tbSD2_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD2_1.Enabled = False
        Me.tbSD2_1.Location = New System.Drawing.Point(283, 33)
        Me.tbSD2_1.MaxLength = 15
        Me.tbSD2_1.Name = "tbSD2_1"
        Me.tbSD2_1.ReadOnly = True
        Me.tbSD2_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD2_1.TabIndex = 3
        Me.tbSD2_1.Text = "SD2_1"
        Me.tbSD2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED2_32
        '
        Me.lbED2_32.AutoSize = True
        Me.lbED2_32.Location = New System.Drawing.Point(224, 594)
        Me.lbED2_32.Name = "lbED2_32"
        Me.lbED2_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_32.TabIndex = 4
        Me.lbED2_32.Text = "ED2_32"
        '
        'lbED2_31
        '
        Me.lbED2_31.AutoSize = True
        Me.lbED2_31.Location = New System.Drawing.Point(224, 576)
        Me.lbED2_31.Name = "lbED2_31"
        Me.lbED2_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_31.TabIndex = 4
        Me.lbED2_31.Text = "ED2_31"
        '
        'lbED2_16
        '
        Me.lbED2_16.AutoSize = True
        Me.lbED2_16.Location = New System.Drawing.Point(224, 306)
        Me.lbED2_16.Name = "lbED2_16"
        Me.lbED2_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_16.TabIndex = 4
        Me.lbED2_16.Text = "ED2_16"
        '
        'lbED2_24
        '
        Me.lbED2_24.AutoSize = True
        Me.lbED2_24.Location = New System.Drawing.Point(224, 450)
        Me.lbED2_24.Name = "lbED2_24"
        Me.lbED2_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_24.TabIndex = 4
        Me.lbED2_24.Text = "ED2_24"
        '
        'lbED2_15
        '
        Me.lbED2_15.AutoSize = True
        Me.lbED2_15.Location = New System.Drawing.Point(224, 288)
        Me.lbED2_15.Name = "lbED2_15"
        Me.lbED2_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_15.TabIndex = 4
        Me.lbED2_15.Text = "ED2_15"
        '
        'lbED2_28
        '
        Me.lbED2_28.AutoSize = True
        Me.lbED2_28.Location = New System.Drawing.Point(224, 522)
        Me.lbED2_28.Name = "lbED2_28"
        Me.lbED2_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_28.TabIndex = 4
        Me.lbED2_28.Text = "ED2_28"
        '
        'lbED2_8
        '
        Me.lbED2_8.AutoSize = True
        Me.lbED2_8.Location = New System.Drawing.Point(224, 162)
        Me.lbED2_8.Name = "lbED2_8"
        Me.lbED2_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_8.TabIndex = 4
        Me.lbED2_8.Text = "ED2_8"
        '
        'lbED2_23
        '
        Me.lbED2_23.AutoSize = True
        Me.lbED2_23.Location = New System.Drawing.Point(224, 432)
        Me.lbED2_23.Name = "lbED2_23"
        Me.lbED2_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_23.TabIndex = 4
        Me.lbED2_23.Text = "ED2_23"
        '
        'lbED2_12
        '
        Me.lbED2_12.AutoSize = True
        Me.lbED2_12.Location = New System.Drawing.Point(224, 234)
        Me.lbED2_12.Name = "lbED2_12"
        Me.lbED2_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_12.TabIndex = 4
        Me.lbED2_12.Text = "ED2_12"
        '
        'lbED2_30
        '
        Me.lbED2_30.AutoSize = True
        Me.lbED2_30.Location = New System.Drawing.Point(224, 558)
        Me.lbED2_30.Name = "lbED2_30"
        Me.lbED2_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_30.TabIndex = 4
        Me.lbED2_30.Text = "ED2_30"
        '
        'lbED2_7
        '
        Me.lbED2_7.AutoSize = True
        Me.lbED2_7.Location = New System.Drawing.Point(224, 144)
        Me.lbED2_7.Name = "lbED2_7"
        Me.lbED2_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_7.TabIndex = 4
        Me.lbED2_7.Text = "ED2_7"
        '
        'lbED2_20
        '
        Me.lbED2_20.AutoSize = True
        Me.lbED2_20.Location = New System.Drawing.Point(224, 378)
        Me.lbED2_20.Name = "lbED2_20"
        Me.lbED2_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_20.TabIndex = 4
        Me.lbED2_20.Text = "ED2_20"
        '
        'lbED2_14
        '
        Me.lbED2_14.AutoSize = True
        Me.lbED2_14.Location = New System.Drawing.Point(224, 270)
        Me.lbED2_14.Name = "lbED2_14"
        Me.lbED2_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_14.TabIndex = 4
        Me.lbED2_14.Text = "ED2_14"
        '
        'lbED2_27
        '
        Me.lbED2_27.AutoSize = True
        Me.lbED2_27.Location = New System.Drawing.Point(224, 504)
        Me.lbED2_27.Name = "lbED2_27"
        Me.lbED2_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_27.TabIndex = 4
        Me.lbED2_27.Text = "ED2_27"
        '
        'lbED2_4
        '
        Me.lbED2_4.AutoSize = True
        Me.lbED2_4.Location = New System.Drawing.Point(224, 90)
        Me.lbED2_4.Name = "lbED2_4"
        Me.lbED2_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_4.TabIndex = 4
        Me.lbED2_4.Text = "ED2_4"
        '
        'lbED2_22
        '
        Me.lbED2_22.AutoSize = True
        Me.lbED2_22.Location = New System.Drawing.Point(224, 414)
        Me.lbED2_22.Name = "lbED2_22"
        Me.lbED2_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_22.TabIndex = 4
        Me.lbED2_22.Text = "ED2_22"
        '
        'lbED2_11
        '
        Me.lbED2_11.AutoSize = True
        Me.lbED2_11.Location = New System.Drawing.Point(224, 216)
        Me.lbED2_11.Name = "lbED2_11"
        Me.lbED2_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_11.TabIndex = 4
        Me.lbED2_11.Text = "ED2_11"
        '
        'lbED2_29
        '
        Me.lbED2_29.AutoSize = True
        Me.lbED2_29.Location = New System.Drawing.Point(224, 540)
        Me.lbED2_29.Name = "lbED2_29"
        Me.lbED2_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_29.TabIndex = 4
        Me.lbED2_29.Text = "ED2_29"
        '
        'lbED2_6
        '
        Me.lbED2_6.AutoSize = True
        Me.lbED2_6.Location = New System.Drawing.Point(224, 126)
        Me.lbED2_6.Name = "lbED2_6"
        Me.lbED2_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_6.TabIndex = 4
        Me.lbED2_6.Text = "ED2_6"
        '
        'lbED2_19
        '
        Me.lbED2_19.AutoSize = True
        Me.lbED2_19.Location = New System.Drawing.Point(224, 360)
        Me.lbED2_19.Name = "lbED2_19"
        Me.lbED2_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_19.TabIndex = 4
        Me.lbED2_19.Text = "ED2_19"
        '
        'lbED2_13
        '
        Me.lbED2_13.AutoSize = True
        Me.lbED2_13.Location = New System.Drawing.Point(224, 252)
        Me.lbED2_13.Name = "lbED2_13"
        Me.lbED2_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_13.TabIndex = 4
        Me.lbED2_13.Text = "ED2_13"
        '
        'lbED2_26
        '
        Me.lbED2_26.AutoSize = True
        Me.lbED2_26.Location = New System.Drawing.Point(224, 486)
        Me.lbED2_26.Name = "lbED2_26"
        Me.lbED2_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_26.TabIndex = 4
        Me.lbED2_26.Text = "ED2_26"
        '
        'lbED2_3
        '
        Me.lbED2_3.AutoSize = True
        Me.lbED2_3.Location = New System.Drawing.Point(224, 72)
        Me.lbED2_3.Name = "lbED2_3"
        Me.lbED2_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_3.TabIndex = 4
        Me.lbED2_3.Text = "ED2_3"
        '
        'lbED2_21
        '
        Me.lbED2_21.AutoSize = True
        Me.lbED2_21.Location = New System.Drawing.Point(224, 396)
        Me.lbED2_21.Name = "lbED2_21"
        Me.lbED2_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_21.TabIndex = 4
        Me.lbED2_21.Text = "ED2_21"
        '
        'lbED2_10
        '
        Me.lbED2_10.AutoSize = True
        Me.lbED2_10.Location = New System.Drawing.Point(224, 198)
        Me.lbED2_10.Name = "lbED2_10"
        Me.lbED2_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_10.TabIndex = 4
        Me.lbED2_10.Text = "ED2_10"
        '
        'lbED2_25
        '
        Me.lbED2_25.AutoSize = True
        Me.lbED2_25.Location = New System.Drawing.Point(224, 468)
        Me.lbED2_25.Name = "lbED2_25"
        Me.lbED2_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_25.TabIndex = 4
        Me.lbED2_25.Text = "ED2_25"
        '
        'lbED2_5
        '
        Me.lbED2_5.AutoSize = True
        Me.lbED2_5.Location = New System.Drawing.Point(224, 108)
        Me.lbED2_5.Name = "lbED2_5"
        Me.lbED2_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_5.TabIndex = 4
        Me.lbED2_5.Text = "ED2_5"
        '
        'lbED2_18
        '
        Me.lbED2_18.AutoSize = True
        Me.lbED2_18.Location = New System.Drawing.Point(224, 342)
        Me.lbED2_18.Name = "lbED2_18"
        Me.lbED2_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_18.TabIndex = 4
        Me.lbED2_18.Text = "ED2_18"
        '
        'lbED2_9
        '
        Me.lbED2_9.AutoSize = True
        Me.lbED2_9.Location = New System.Drawing.Point(224, 180)
        Me.lbED2_9.Name = "lbED2_9"
        Me.lbED2_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_9.TabIndex = 4
        Me.lbED2_9.Text = "ED2_9"
        '
        'lbED2_17
        '
        Me.lbED2_17.AutoSize = True
        Me.lbED2_17.Location = New System.Drawing.Point(224, 324)
        Me.lbED2_17.Name = "lbED2_17"
        Me.lbED2_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED2_17.TabIndex = 4
        Me.lbED2_17.Text = "ED2_17"
        '
        'lbED2_2
        '
        Me.lbED2_2.AutoSize = True
        Me.lbED2_2.Location = New System.Drawing.Point(224, 54)
        Me.lbED2_2.Name = "lbED2_2"
        Me.lbED2_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_2.TabIndex = 4
        Me.lbED2_2.Text = "ED2_2"
        '
        'lbED2_1
        '
        Me.lbED2_1.AutoSize = True
        Me.lbED2_1.Location = New System.Drawing.Point(224, 36)
        Me.lbED2_1.Name = "lbED2_1"
        Me.lbED2_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED2_1.TabIndex = 4
        Me.lbED2_1.Text = "ED2_1"
        '
        'tbSD1_16
        '
        Me.tbSD1_16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_16.Enabled = False
        Me.tbSD1_16.Location = New System.Drawing.Point(114, 302)
        Me.tbSD1_16.MaxLength = 15
        Me.tbSD1_16.Name = "tbSD1_16"
        Me.tbSD1_16.ReadOnly = True
        Me.tbSD1_16.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_16.TabIndex = 3
        Me.tbSD1_16.Text = "SD1_16"
        Me.tbSD1_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_15
        '
        Me.tbSD1_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_15.Enabled = False
        Me.tbSD1_15.Location = New System.Drawing.Point(114, 284)
        Me.tbSD1_15.MaxLength = 15
        Me.tbSD1_15.Name = "tbSD1_15"
        Me.tbSD1_15.ReadOnly = True
        Me.tbSD1_15.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_15.TabIndex = 3
        Me.tbSD1_15.Text = "SD1_15"
        Me.tbSD1_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_14
        '
        Me.tbSD1_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_14.Enabled = False
        Me.tbSD1_14.Location = New System.Drawing.Point(114, 266)
        Me.tbSD1_14.MaxLength = 15
        Me.tbSD1_14.Name = "tbSD1_14"
        Me.tbSD1_14.ReadOnly = True
        Me.tbSD1_14.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_14.TabIndex = 3
        Me.tbSD1_14.Text = "SD1_14"
        Me.tbSD1_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_13
        '
        Me.tbSD1_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_13.Enabled = False
        Me.tbSD1_13.Location = New System.Drawing.Point(114, 247)
        Me.tbSD1_13.MaxLength = 15
        Me.tbSD1_13.Name = "tbSD1_13"
        Me.tbSD1_13.ReadOnly = True
        Me.tbSD1_13.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_13.TabIndex = 3
        Me.tbSD1_13.Text = "SD1_13"
        Me.tbSD1_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_12
        '
        Me.tbSD1_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_12.Enabled = False
        Me.tbSD1_12.Location = New System.Drawing.Point(114, 230)
        Me.tbSD1_12.MaxLength = 15
        Me.tbSD1_12.Name = "tbSD1_12"
        Me.tbSD1_12.ReadOnly = True
        Me.tbSD1_12.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_12.TabIndex = 3
        Me.tbSD1_12.Text = "SD1_12"
        Me.tbSD1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_11
        '
        Me.tbSD1_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_11.Enabled = False
        Me.tbSD1_11.Location = New System.Drawing.Point(114, 212)
        Me.tbSD1_11.MaxLength = 15
        Me.tbSD1_11.Name = "tbSD1_11"
        Me.tbSD1_11.ReadOnly = True
        Me.tbSD1_11.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_11.TabIndex = 3
        Me.tbSD1_11.Text = "SD1_11"
        Me.tbSD1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_10
        '
        Me.tbSD1_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_10.Enabled = False
        Me.tbSD1_10.Location = New System.Drawing.Point(114, 193)
        Me.tbSD1_10.MaxLength = 15
        Me.tbSD1_10.Name = "tbSD1_10"
        Me.tbSD1_10.ReadOnly = True
        Me.tbSD1_10.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_10.TabIndex = 3
        Me.tbSD1_10.Text = "SD1_10"
        Me.tbSD1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_9
        '
        Me.tbSD1_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_9.Enabled = False
        Me.tbSD1_9.Location = New System.Drawing.Point(114, 176)
        Me.tbSD1_9.MaxLength = 15
        Me.tbSD1_9.Name = "tbSD1_9"
        Me.tbSD1_9.ReadOnly = True
        Me.tbSD1_9.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_9.TabIndex = 3
        Me.tbSD1_9.Text = "SD1_9"
        Me.tbSD1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_8
        '
        Me.tbSD1_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_8.Enabled = False
        Me.tbSD1_8.Location = New System.Drawing.Point(114, 158)
        Me.tbSD1_8.MaxLength = 15
        Me.tbSD1_8.Name = "tbSD1_8"
        Me.tbSD1_8.ReadOnly = True
        Me.tbSD1_8.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_8.TabIndex = 3
        Me.tbSD1_8.Text = "SD1_8"
        Me.tbSD1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_7
        '
        Me.tbSD1_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_7.Enabled = False
        Me.tbSD1_7.Location = New System.Drawing.Point(114, 140)
        Me.tbSD1_7.MaxLength = 15
        Me.tbSD1_7.Name = "tbSD1_7"
        Me.tbSD1_7.ReadOnly = True
        Me.tbSD1_7.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_7.TabIndex = 3
        Me.tbSD1_7.Text = "SD1_7"
        Me.tbSD1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_6
        '
        Me.tbSD1_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_6.Enabled = False
        Me.tbSD1_6.Location = New System.Drawing.Point(114, 122)
        Me.tbSD1_6.MaxLength = 15
        Me.tbSD1_6.Name = "tbSD1_6"
        Me.tbSD1_6.ReadOnly = True
        Me.tbSD1_6.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_6.TabIndex = 3
        Me.tbSD1_6.Text = "SD1_6"
        Me.tbSD1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_5
        '
        Me.tbSD1_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_5.Enabled = False
        Me.tbSD1_5.Location = New System.Drawing.Point(114, 104)
        Me.tbSD1_5.MaxLength = 15
        Me.tbSD1_5.Name = "tbSD1_5"
        Me.tbSD1_5.ReadOnly = True
        Me.tbSD1_5.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_5.TabIndex = 3
        Me.tbSD1_5.Text = "SD1_5"
        Me.tbSD1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_4
        '
        Me.tbSD1_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_4.Enabled = False
        Me.tbSD1_4.Location = New System.Drawing.Point(114, 86)
        Me.tbSD1_4.MaxLength = 15
        Me.tbSD1_4.Name = "tbSD1_4"
        Me.tbSD1_4.ReadOnly = True
        Me.tbSD1_4.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_4.TabIndex = 3
        Me.tbSD1_4.Text = "SD1_4"
        Me.tbSD1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_3
        '
        Me.tbSD1_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_3.Enabled = False
        Me.tbSD1_3.Location = New System.Drawing.Point(114, 69)
        Me.tbSD1_3.MaxLength = 15
        Me.tbSD1_3.Name = "tbSD1_3"
        Me.tbSD1_3.ReadOnly = True
        Me.tbSD1_3.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_3.TabIndex = 3
        Me.tbSD1_3.Text = "SD1_3"
        Me.tbSD1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_2
        '
        Me.tbSD1_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_2.Enabled = False
        Me.tbSD1_2.Location = New System.Drawing.Point(114, 51)
        Me.tbSD1_2.MaxLength = 15
        Me.tbSD1_2.Name = "tbSD1_2"
        Me.tbSD1_2.ReadOnly = True
        Me.tbSD1_2.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_2.TabIndex = 3
        Me.tbSD1_2.Text = "SD1_2"
        Me.tbSD1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSD1_1
        '
        Me.tbSD1_1.BackColor = System.Drawing.SystemColors.Control
        Me.tbSD1_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSD1_1.Enabled = False
        Me.tbSD1_1.Location = New System.Drawing.Point(114, 34)
        Me.tbSD1_1.MaxLength = 15
        Me.tbSD1_1.Name = "tbSD1_1"
        Me.tbSD1_1.Size = New System.Drawing.Size(54, 20)
        Me.tbSD1_1.TabIndex = 3
        Me.tbSD1_1.Text = "SD1_1"
        Me.tbSD1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbED1_32
        '
        Me.lbED1_32.AutoSize = True
        Me.lbED1_32.Location = New System.Drawing.Point(55, 594)
        Me.lbED1_32.Name = "lbED1_32"
        Me.lbED1_32.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_32.TabIndex = 4
        Me.lbED1_32.Text = "ED1_32"
        '
        'lbED1_31
        '
        Me.lbED1_31.AutoSize = True
        Me.lbED1_31.Location = New System.Drawing.Point(55, 576)
        Me.lbED1_31.Name = "lbED1_31"
        Me.lbED1_31.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_31.TabIndex = 4
        Me.lbED1_31.Text = "ED1_31"
        '
        'lbED1_16
        '
        Me.lbED1_16.AutoSize = True
        Me.lbED1_16.Location = New System.Drawing.Point(55, 306)
        Me.lbED1_16.Name = "lbED1_16"
        Me.lbED1_16.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_16.TabIndex = 4
        Me.lbED1_16.Text = "ED1_16"
        '
        'lbED1_24
        '
        Me.lbED1_24.AutoSize = True
        Me.lbED1_24.Location = New System.Drawing.Point(55, 450)
        Me.lbED1_24.Name = "lbED1_24"
        Me.lbED1_24.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_24.TabIndex = 4
        Me.lbED1_24.Text = "ED1_24"
        '
        'lbED1_15
        '
        Me.lbED1_15.AutoSize = True
        Me.lbED1_15.Location = New System.Drawing.Point(55, 288)
        Me.lbED1_15.Name = "lbED1_15"
        Me.lbED1_15.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_15.TabIndex = 4
        Me.lbED1_15.Text = "ED1_15"
        '
        'lbED1_28
        '
        Me.lbED1_28.AutoSize = True
        Me.lbED1_28.Location = New System.Drawing.Point(55, 522)
        Me.lbED1_28.Name = "lbED1_28"
        Me.lbED1_28.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_28.TabIndex = 4
        Me.lbED1_28.Text = "ED1_28"
        '
        'lbED1_8
        '
        Me.lbED1_8.AutoSize = True
        Me.lbED1_8.Location = New System.Drawing.Point(55, 162)
        Me.lbED1_8.Name = "lbED1_8"
        Me.lbED1_8.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_8.TabIndex = 4
        Me.lbED1_8.Text = "ED1_8"
        '
        'lbED1_23
        '
        Me.lbED1_23.AutoSize = True
        Me.lbED1_23.Location = New System.Drawing.Point(55, 432)
        Me.lbED1_23.Name = "lbED1_23"
        Me.lbED1_23.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_23.TabIndex = 4
        Me.lbED1_23.Text = "ED1_23"
        '
        'lbED1_12
        '
        Me.lbED1_12.AutoSize = True
        Me.lbED1_12.Location = New System.Drawing.Point(55, 234)
        Me.lbED1_12.Name = "lbED1_12"
        Me.lbED1_12.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_12.TabIndex = 4
        Me.lbED1_12.Text = "ED1_12"
        '
        'lbED1_30
        '
        Me.lbED1_30.AutoSize = True
        Me.lbED1_30.Location = New System.Drawing.Point(55, 558)
        Me.lbED1_30.Name = "lbED1_30"
        Me.lbED1_30.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_30.TabIndex = 4
        Me.lbED1_30.Text = "ED1_30"
        '
        'lbED1_7
        '
        Me.lbED1_7.AutoSize = True
        Me.lbED1_7.Location = New System.Drawing.Point(55, 144)
        Me.lbED1_7.Name = "lbED1_7"
        Me.lbED1_7.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_7.TabIndex = 4
        Me.lbED1_7.Text = "ED1_7"
        '
        'lbED1_20
        '
        Me.lbED1_20.AutoSize = True
        Me.lbED1_20.Location = New System.Drawing.Point(55, 378)
        Me.lbED1_20.Name = "lbED1_20"
        Me.lbED1_20.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_20.TabIndex = 4
        Me.lbED1_20.Text = "ED1_20"
        '
        'lbED1_14
        '
        Me.lbED1_14.AutoSize = True
        Me.lbED1_14.Location = New System.Drawing.Point(55, 270)
        Me.lbED1_14.Name = "lbED1_14"
        Me.lbED1_14.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_14.TabIndex = 4
        Me.lbED1_14.Text = "ED1_14"
        '
        'lbED1_27
        '
        Me.lbED1_27.AutoSize = True
        Me.lbED1_27.Location = New System.Drawing.Point(55, 504)
        Me.lbED1_27.Name = "lbED1_27"
        Me.lbED1_27.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_27.TabIndex = 4
        Me.lbED1_27.Text = "ED1_27"
        '
        'lbED1_4
        '
        Me.lbED1_4.AutoSize = True
        Me.lbED1_4.Location = New System.Drawing.Point(55, 90)
        Me.lbED1_4.Name = "lbED1_4"
        Me.lbED1_4.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_4.TabIndex = 4
        Me.lbED1_4.Text = "ED1_4"
        '
        'lbED1_22
        '
        Me.lbED1_22.AutoSize = True
        Me.lbED1_22.Location = New System.Drawing.Point(55, 414)
        Me.lbED1_22.Name = "lbED1_22"
        Me.lbED1_22.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_22.TabIndex = 4
        Me.lbED1_22.Text = "ED1_22"
        '
        'lbED1_11
        '
        Me.lbED1_11.AutoSize = True
        Me.lbED1_11.Location = New System.Drawing.Point(55, 216)
        Me.lbED1_11.Name = "lbED1_11"
        Me.lbED1_11.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_11.TabIndex = 4
        Me.lbED1_11.Text = "ED1_11"
        '
        'lbED1_29
        '
        Me.lbED1_29.AutoSize = True
        Me.lbED1_29.Location = New System.Drawing.Point(55, 540)
        Me.lbED1_29.Name = "lbED1_29"
        Me.lbED1_29.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_29.TabIndex = 4
        Me.lbED1_29.Text = "ED1_29"
        '
        'lbED1_6
        '
        Me.lbED1_6.AutoSize = True
        Me.lbED1_6.Location = New System.Drawing.Point(55, 126)
        Me.lbED1_6.Name = "lbED1_6"
        Me.lbED1_6.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_6.TabIndex = 4
        Me.lbED1_6.Text = "ED1_6"
        '
        'lbED1_19
        '
        Me.lbED1_19.AutoSize = True
        Me.lbED1_19.Location = New System.Drawing.Point(55, 360)
        Me.lbED1_19.Name = "lbED1_19"
        Me.lbED1_19.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_19.TabIndex = 4
        Me.lbED1_19.Text = "ED1_19"
        '
        'lbED1_13
        '
        Me.lbED1_13.AutoSize = True
        Me.lbED1_13.Location = New System.Drawing.Point(55, 252)
        Me.lbED1_13.Name = "lbED1_13"
        Me.lbED1_13.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_13.TabIndex = 4
        Me.lbED1_13.Text = "ED1_13"
        '
        'lbED1_26
        '
        Me.lbED1_26.AutoSize = True
        Me.lbED1_26.Location = New System.Drawing.Point(55, 486)
        Me.lbED1_26.Name = "lbED1_26"
        Me.lbED1_26.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_26.TabIndex = 4
        Me.lbED1_26.Text = "ED1_26"
        '
        'lbED1_3
        '
        Me.lbED1_3.AutoSize = True
        Me.lbED1_3.Location = New System.Drawing.Point(55, 72)
        Me.lbED1_3.Name = "lbED1_3"
        Me.lbED1_3.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_3.TabIndex = 4
        Me.lbED1_3.Text = "ED1_3"
        '
        'lbED1_21
        '
        Me.lbED1_21.AutoSize = True
        Me.lbED1_21.Location = New System.Drawing.Point(55, 396)
        Me.lbED1_21.Name = "lbED1_21"
        Me.lbED1_21.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_21.TabIndex = 4
        Me.lbED1_21.Text = "ED1_21"
        '
        'lbED1_10
        '
        Me.lbED1_10.AutoSize = True
        Me.lbED1_10.Location = New System.Drawing.Point(55, 198)
        Me.lbED1_10.Name = "lbED1_10"
        Me.lbED1_10.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_10.TabIndex = 4
        Me.lbED1_10.Text = "ED1_10"
        '
        'lbED1_25
        '
        Me.lbED1_25.AutoSize = True
        Me.lbED1_25.Location = New System.Drawing.Point(55, 468)
        Me.lbED1_25.Name = "lbED1_25"
        Me.lbED1_25.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_25.TabIndex = 4
        Me.lbED1_25.Text = "ED1_25"
        '
        'lbED1_5
        '
        Me.lbED1_5.AutoSize = True
        Me.lbED1_5.Location = New System.Drawing.Point(55, 108)
        Me.lbED1_5.Name = "lbED1_5"
        Me.lbED1_5.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_5.TabIndex = 4
        Me.lbED1_5.Text = "ED1_5"
        '
        'lbED1_18
        '
        Me.lbED1_18.AutoSize = True
        Me.lbED1_18.Location = New System.Drawing.Point(55, 342)
        Me.lbED1_18.Name = "lbED1_18"
        Me.lbED1_18.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_18.TabIndex = 4
        Me.lbED1_18.Text = "ED1_18"
        '
        'lbED1_9
        '
        Me.lbED1_9.AutoSize = True
        Me.lbED1_9.Location = New System.Drawing.Point(55, 180)
        Me.lbED1_9.Name = "lbED1_9"
        Me.lbED1_9.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_9.TabIndex = 4
        Me.lbED1_9.Text = "ED1_9"
        '
        'lbED1_17
        '
        Me.lbED1_17.AutoSize = True
        Me.lbED1_17.Location = New System.Drawing.Point(55, 324)
        Me.lbED1_17.Name = "lbED1_17"
        Me.lbED1_17.Size = New System.Drawing.Size(46, 13)
        Me.lbED1_17.TabIndex = 4
        Me.lbED1_17.Text = "ED1_17"
        '
        'lbED1_2
        '
        Me.lbED1_2.AutoSize = True
        Me.lbED1_2.Location = New System.Drawing.Point(55, 54)
        Me.lbED1_2.Name = "lbED1_2"
        Me.lbED1_2.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_2.TabIndex = 4
        Me.lbED1_2.Text = "ED1_2"
        '
        'lbED1_1
        '
        Me.lbED1_1.AutoSize = True
        Me.lbED1_1.Location = New System.Drawing.Point(55, 36)
        Me.lbED1_1.Name = "lbED1_1"
        Me.lbED1_1.Size = New System.Drawing.Size(40, 13)
        Me.lbED1_1.TabIndex = 4
        Me.lbED1_1.Text = "ED1_1"
        '
        'lbT4
        '
        Me.lbT4.AutoSize = True
        Me.lbT4.Location = New System.Drawing.Point(516, 13)
        Me.lbT4.Name = "lbT4"
        Me.lbT4.Size = New System.Drawing.Size(169, 13)
        Me.lbT4.TabIndex = 128
        Me.lbT4.Text = "_________TARJETA_4________"
        '
        'lbT7
        '
        Me.lbT7.AutoSize = True
        Me.lbT7.Location = New System.Drawing.Point(1026, 13)
        Me.lbT7.Name = "lbT7"
        Me.lbT7.Size = New System.Drawing.Size(169, 13)
        Me.lbT7.TabIndex = 162
        Me.lbT7.Text = "_________TARJETA_7________"
        '
        'lbT6
        '
        Me.lbT6.AutoSize = True
        Me.lbT6.Location = New System.Drawing.Point(854, 13)
        Me.lbT6.Name = "lbT6"
        Me.lbT6.Size = New System.Drawing.Size(169, 13)
        Me.lbT6.TabIndex = 162
        Me.lbT6.Text = "_________TARJETA_6________"
        '
        'lbT5
        '
        Me.lbT5.AutoSize = True
        Me.lbT5.Location = New System.Drawing.Point(686, 13)
        Me.lbT5.Name = "lbT5"
        Me.lbT5.Size = New System.Drawing.Size(169, 13)
        Me.lbT5.TabIndex = 128
        Me.lbT5.Text = "_________TARJETA_5________"
        '
        'lbT3
        '
        Me.lbT3.AutoSize = True
        Me.lbT3.Location = New System.Drawing.Point(346, 13)
        Me.lbT3.Name = "lbT3"
        Me.lbT3.Size = New System.Drawing.Size(169, 13)
        Me.lbT3.TabIndex = 128
        Me.lbT3.Text = "_________TARJETA_3________"
        '
        'lbT2
        '
        Me.lbT2.AutoSize = True
        Me.lbT2.Location = New System.Drawing.Point(170, 13)
        Me.lbT2.Name = "lbT2"
        Me.lbT2.Size = New System.Drawing.Size(169, 13)
        Me.lbT2.TabIndex = 128
        Me.lbT2.Text = "_________TARJETA_2________"
        '
        'cmdRESET_SD
        '
        Me.cmdRESET_SD.AccessibleDescription = ""
        Me.cmdRESET_SD.Location = New System.Drawing.Point(3, 38)
        Me.cmdRESET_SD.Name = "cmdRESET_SD"
        Me.cmdRESET_SD.Size = New System.Drawing.Size(128, 22)
        Me.cmdRESET_SD.TabIndex = 4
        Me.cmdRESET_SD.Text = "RESET SALIDAS"
        Me.cmdRESET_SD.UseVisualStyleBackColor = True
        '
        'tm_POLLING_SD_1
        '
        Me.tm_POLLING_SD_1.Interval = 75
        '
        'cmdRESIZE
        '
        Me.cmdRESIZE.AccessibleDescription = ""
        Me.cmdRESIZE.Location = New System.Drawing.Point(115, 12)
        Me.cmdRESIZE.Name = "cmdRESIZE"
        Me.cmdRESIZE.Size = New System.Drawing.Size(26, 20)
        Me.cmdRESIZE.TabIndex = 1
        Me.cmdRESIZE.Text = "APLICAR"
        Me.cmdRESIZE.UseVisualStyleBackColor = True
        Me.cmdRESIZE.Visible = False
        '
        'gbRESIZE
        '
        Me.gbRESIZE.Controls.Add(Me.cmdApCombo)
        Me.gbRESIZE.Controls.Add(Me.Label8)
        Me.gbRESIZE.Controls.Add(Me.Label7)
        Me.gbRESIZE.Controls.Add(Me.Label6)
        Me.gbRESIZE.Controls.Add(Me.Label5)
        Me.gbRESIZE.Controls.Add(Me.Label4)
        Me.gbRESIZE.Controls.Add(Me.Label3)
        Me.gbRESIZE.Controls.Add(Me.Label2)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD7)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD6)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD5)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD4)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD3)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD2)
        Me.gbRESIZE.Controls.Add(Me.cbBOARD1)
        Me.gbRESIZE.Controls.Add(Me.tbN_BOARDS)
        Me.gbRESIZE.Controls.Add(Me.Label1)
        Me.gbRESIZE.Controls.Add(Me.cmdRESIZE)
        Me.gbRESIZE.Location = New System.Drawing.Point(90, 2)
        Me.gbRESIZE.Name = "gbRESIZE"
        Me.gbRESIZE.Size = New System.Drawing.Size(150, 70)
        Me.gbRESIZE.TabIndex = 2
        Me.gbRESIZE.TabStop = False
        Me.gbRESIZE.Text = "REDISTRIBUCION"
        '
        'cmdApCombo
        '
        Me.cmdApCombo.AccessibleDescription = ""
        Me.cmdApCombo.Location = New System.Drawing.Point(82, 13)
        Me.cmdApCombo.Name = "cmdApCombo"
        Me.cmdApCombo.Size = New System.Drawing.Size(61, 20)
        Me.cmdApCombo.TabIndex = 1
        Me.cmdApCombo.Text = "APLICAR"
        Me.cmdApCombo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1"
        '
        'cbBOARD7
        '
        Me.cbBOARD7.AutoSize = True
        Me.cbBOARD7.Checked = True
        Me.cbBOARD7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD7.Location = New System.Drawing.Point(129, 36)
        Me.cbBOARD7.Name = "cbBOARD7"
        Me.cbBOARD7.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD7.TabIndex = 5
        Me.cbBOARD7.UseVisualStyleBackColor = True
        '
        'cbBOARD6
        '
        Me.cbBOARD6.AutoSize = True
        Me.cbBOARD6.Checked = True
        Me.cbBOARD6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD6.Location = New System.Drawing.Point(109, 36)
        Me.cbBOARD6.Name = "cbBOARD6"
        Me.cbBOARD6.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD6.TabIndex = 5
        Me.cbBOARD6.UseVisualStyleBackColor = True
        '
        'cbBOARD5
        '
        Me.cbBOARD5.AutoSize = True
        Me.cbBOARD5.Checked = True
        Me.cbBOARD5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD5.Location = New System.Drawing.Point(88, 36)
        Me.cbBOARD5.Name = "cbBOARD5"
        Me.cbBOARD5.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD5.TabIndex = 5
        Me.cbBOARD5.UseVisualStyleBackColor = True
        '
        'cbBOARD4
        '
        Me.cbBOARD4.AutoSize = True
        Me.cbBOARD4.Checked = True
        Me.cbBOARD4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD4.Location = New System.Drawing.Point(67, 36)
        Me.cbBOARD4.Name = "cbBOARD4"
        Me.cbBOARD4.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD4.TabIndex = 5
        Me.cbBOARD4.UseVisualStyleBackColor = True
        '
        'cbBOARD3
        '
        Me.cbBOARD3.AutoSize = True
        Me.cbBOARD3.Checked = True
        Me.cbBOARD3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD3.Location = New System.Drawing.Point(46, 36)
        Me.cbBOARD3.Name = "cbBOARD3"
        Me.cbBOARD3.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD3.TabIndex = 5
        Me.cbBOARD3.UseVisualStyleBackColor = True
        '
        'cbBOARD2
        '
        Me.cbBOARD2.AutoSize = True
        Me.cbBOARD2.Checked = True
        Me.cbBOARD2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD2.Location = New System.Drawing.Point(25, 36)
        Me.cbBOARD2.Name = "cbBOARD2"
        Me.cbBOARD2.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD2.TabIndex = 5
        Me.cbBOARD2.UseVisualStyleBackColor = True
        '
        'cbBOARD1
        '
        Me.cbBOARD1.AutoSize = True
        Me.cbBOARD1.Checked = True
        Me.cbBOARD1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbBOARD1.Location = New System.Drawing.Point(4, 36)
        Me.cbBOARD1.Name = "cbBOARD1"
        Me.cbBOARD1.Size = New System.Drawing.Size(15, 14)
        Me.cbBOARD1.TabIndex = 5
        Me.cbBOARD1.UseVisualStyleBackColor = True
        '
        'tbN_BOARDS
        '
        Me.tbN_BOARDS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbN_BOARDS.Location = New System.Drawing.Point(84, 13)
        Me.tbN_BOARDS.MaxLength = 1
        Me.tbN_BOARDS.Name = "tbN_BOARDS"
        Me.tbN_BOARDS.Size = New System.Drawing.Size(25, 20)
        Me.tbN_BOARDS.TabIndex = 0
        Me.tbN_BOARDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbN_BOARDS.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nº TARJETAS"
        '
        'tpAyuda
        '
        Me.tpAyuda.AutomaticDelay = 100
        Me.tpAyuda.ToolTipTitle = "Informacion"
        Me.tpAyuda.UseAnimation = False
        Me.tpAyuda.UseFading = False
        '
        'gbGOOSES
        '
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_12)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_8)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_4)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_11)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_10)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_7)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_6)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_9)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_3)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_5)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_2)
        Me.gbGOOSES.Controls.Add(Me.lbLGOOSE_1)
        Me.gbGOOSES.Location = New System.Drawing.Point(615, 2)
        Me.gbGOOSES.Name = "gbGOOSES"
        Me.gbGOOSES.Size = New System.Drawing.Size(213, 115)
        Me.gbGOOSES.TabIndex = 7
        Me.gbGOOSES.TabStop = False
        Me.gbGOOSES.Text = "SUSCRIPCION DE GOOSES"
        '
        'lbLGOOSE_12
        '
        Me.lbLGOOSE_12.AutoSize = True
        Me.lbLGOOSE_12.Location = New System.Drawing.Point(139, 91)
        Me.lbLGOOSE_12.Name = "lbLGOOSE_12"
        Me.lbLGOOSE_12.Size = New System.Drawing.Size(69, 13)
        Me.lbLGOOSE_12.TabIndex = 4
        Me.lbLGOOSE_12.Text = "LGOOSE_12"
        '
        'lbLGOOSE_8
        '
        Me.lbLGOOSE_8.AutoSize = True
        Me.lbLGOOSE_8.Location = New System.Drawing.Point(71, 91)
        Me.lbLGOOSE_8.Name = "lbLGOOSE_8"
        Me.lbLGOOSE_8.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_8.TabIndex = 4
        Me.lbLGOOSE_8.Text = "LGOOSE_8"
        '
        'lbLGOOSE_4
        '
        Me.lbLGOOSE_4.AutoSize = True
        Me.lbLGOOSE_4.Location = New System.Drawing.Point(3, 91)
        Me.lbLGOOSE_4.Name = "lbLGOOSE_4"
        Me.lbLGOOSE_4.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_4.TabIndex = 4
        Me.lbLGOOSE_4.Text = "LGOOSE_4"
        '
        'lbLGOOSE_11
        '
        Me.lbLGOOSE_11.AutoSize = True
        Me.lbLGOOSE_11.Location = New System.Drawing.Point(139, 69)
        Me.lbLGOOSE_11.Name = "lbLGOOSE_11"
        Me.lbLGOOSE_11.Size = New System.Drawing.Size(69, 13)
        Me.lbLGOOSE_11.TabIndex = 4
        Me.lbLGOOSE_11.Text = "LGOOSE_11"
        '
        'lbLGOOSE_10
        '
        Me.lbLGOOSE_10.AutoSize = True
        Me.lbLGOOSE_10.Location = New System.Drawing.Point(139, 47)
        Me.lbLGOOSE_10.Name = "lbLGOOSE_10"
        Me.lbLGOOSE_10.Size = New System.Drawing.Size(69, 13)
        Me.lbLGOOSE_10.TabIndex = 4
        Me.lbLGOOSE_10.Text = "LGOOSE_10"
        '
        'lbLGOOSE_7
        '
        Me.lbLGOOSE_7.AutoSize = True
        Me.lbLGOOSE_7.Location = New System.Drawing.Point(71, 69)
        Me.lbLGOOSE_7.Name = "lbLGOOSE_7"
        Me.lbLGOOSE_7.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_7.TabIndex = 4
        Me.lbLGOOSE_7.Text = "LGOOSE_7"
        '
        'lbLGOOSE_6
        '
        Me.lbLGOOSE_6.AutoSize = True
        Me.lbLGOOSE_6.Location = New System.Drawing.Point(71, 47)
        Me.lbLGOOSE_6.Name = "lbLGOOSE_6"
        Me.lbLGOOSE_6.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_6.TabIndex = 4
        Me.lbLGOOSE_6.Text = "LGOOSE_6"
        '
        'lbLGOOSE_9
        '
        Me.lbLGOOSE_9.AutoSize = True
        Me.lbLGOOSE_9.Location = New System.Drawing.Point(139, 25)
        Me.lbLGOOSE_9.Name = "lbLGOOSE_9"
        Me.lbLGOOSE_9.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_9.TabIndex = 4
        Me.lbLGOOSE_9.Text = "LGOOSE_9"
        '
        'lbLGOOSE_3
        '
        Me.lbLGOOSE_3.AutoSize = True
        Me.lbLGOOSE_3.Location = New System.Drawing.Point(3, 69)
        Me.lbLGOOSE_3.Name = "lbLGOOSE_3"
        Me.lbLGOOSE_3.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_3.TabIndex = 4
        Me.lbLGOOSE_3.Text = "LGOOSE_3"
        '
        'lbLGOOSE_5
        '
        Me.lbLGOOSE_5.AutoSize = True
        Me.lbLGOOSE_5.Location = New System.Drawing.Point(71, 25)
        Me.lbLGOOSE_5.Name = "lbLGOOSE_5"
        Me.lbLGOOSE_5.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_5.TabIndex = 4
        Me.lbLGOOSE_5.Text = "LGOOSE_5"
        '
        'lbLGOOSE_2
        '
        Me.lbLGOOSE_2.AutoSize = True
        Me.lbLGOOSE_2.Location = New System.Drawing.Point(3, 47)
        Me.lbLGOOSE_2.Name = "lbLGOOSE_2"
        Me.lbLGOOSE_2.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_2.TabIndex = 4
        Me.lbLGOOSE_2.Text = "LGOOSE_2"
        '
        'lbLGOOSE_1
        '
        Me.lbLGOOSE_1.AutoSize = True
        Me.lbLGOOSE_1.Location = New System.Drawing.Point(3, 25)
        Me.lbLGOOSE_1.Name = "lbLGOOSE_1"
        Me.lbLGOOSE_1.Size = New System.Drawing.Size(63, 13)
        Me.lbLGOOSE_1.TabIndex = 4
        Me.lbLGOOSE_1.Text = "LGOOSE_1"
        '
        'tm_POLLING_ED_1
        '
        Me.tm_POLLING_ED_1.Interval = 300
        '
        'cmdRESET_ED
        '
        Me.cmdRESET_ED.AccessibleDescription = ""
        Me.cmdRESET_ED.Location = New System.Drawing.Point(3, 15)
        Me.cmdRESET_ED.Name = "cmdRESET_ED"
        Me.cmdRESET_ED.Size = New System.Drawing.Size(128, 23)
        Me.cmdRESET_ED.TabIndex = 9
        Me.cmdRESET_ED.Text = "RESET ENTRADAS"
        Me.cmdRESET_ED.UseVisualStyleBackColor = True
        '
        'tm_POLLING_ED_2
        '
        Me.tm_POLLING_ED_2.Interval = 300
        '
        'tm_POLLING_ED_3
        '
        Me.tm_POLLING_ED_3.Interval = 300
        '
        'tm_POLLING_ED_4
        '
        Me.tm_POLLING_ED_4.Interval = 300
        '
        'tm_POLLING_ED_5
        '
        Me.tm_POLLING_ED_5.Interval = 300
        '
        'tm_POLLING_ED_6
        '
        Me.tm_POLLING_ED_6.Interval = 300
        '
        'tm_POLLING_ED_7
        '
        Me.tm_POLLING_ED_7.Interval = 300
        '
        'tm_POLLING_SD_2
        '
        Me.tm_POLLING_SD_2.Interval = 75
        '
        'tm_POLLING_SD_3
        '
        Me.tm_POLLING_SD_3.Interval = 75
        '
        'tm_POLLING_SD_4
        '
        Me.tm_POLLING_SD_4.Interval = 75
        '
        'tm_POLLING_SD_5
        '
        Me.tm_POLLING_SD_5.Interval = 75
        '
        'tm_POLLING_SD_6
        '
        Me.tm_POLLING_SD_6.Interval = 75
        '
        'tm_POLLING_SD_7
        '
        Me.tm_POLLING_SD_7.Interval = 75
        '
        'tm_POLLING_GOOSES
        '
        Me.tm_POLLING_GOOSES.Interval = 1000
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "                  "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(8, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "                  "
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "                  "
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(8, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "                  "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "INDX.SP = 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(839, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 113)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CODIGO DE COLORES"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(54, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "INDX.q <> 0"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.HotPink
        Me.Label18.Location = New System.Drawing.Point(8, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 14)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "                  "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(54, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "INDX.ST = 0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(54, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "INDX.SP = 0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(54, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "INDX.ST = 1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdRESET_ED)
        Me.GroupBox4.Controls.Add(Me.cmdRESET_SD)
        Me.GroupBox4.Controls.Add(Me.cmdSALIR)
        Me.GroupBox4.Controls.Add(Me.cmdDEFAULT)
        Me.GroupBox4.Location = New System.Drawing.Point(1126, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(133, 114)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ACCIONES"
        '
        'cmdSALIR
        '
        Me.cmdSALIR.AccessibleDescription = ""
        Me.cmdSALIR.Location = New System.Drawing.Point(3, 85)
        Me.cmdSALIR.Name = "cmdSALIR"
        Me.cmdSALIR.Size = New System.Drawing.Size(128, 23)
        Me.cmdSALIR.TabIndex = 3
        Me.cmdSALIR.Text = "SALIR"
        Me.cmdSALIR.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdCANCELAR_AUTO)
        Me.GroupBox5.Controls.Add(Me.cmdAUTO_TEST)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(989, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(126, 115)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "AUTO TEST"
        '
        'cmdCANCELAR_AUTO
        '
        Me.cmdCANCELAR_AUTO.AccessibleDescription = ""
        Me.cmdCANCELAR_AUTO.Location = New System.Drawing.Point(3, 85)
        Me.cmdCANCELAR_AUTO.Name = "cmdCANCELAR_AUTO"
        Me.cmdCANCELAR_AUTO.Size = New System.Drawing.Size(116, 23)
        Me.cmdCANCELAR_AUTO.TabIndex = 11
        Me.cmdCANCELAR_AUTO.Text = "CANCELAR"
        Me.cmdCANCELAR_AUTO.UseVisualStyleBackColor = True
        '
        'cmdAUTO_TEST
        '
        Me.cmdAUTO_TEST.AccessibleDescription = ""
        Me.cmdAUTO_TEST.Location = New System.Drawing.Point(3, 15)
        Me.cmdAUTO_TEST.Name = "cmdAUTO_TEST"
        Me.cmdAUTO_TEST.Size = New System.Drawing.Size(116, 23)
        Me.cmdAUTO_TEST.TabIndex = 10
        Me.cmdAUTO_TEST.Text = "ACTIVAR"
        Me.cmdAUTO_TEST.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "CAMBIOS CADA 5 SEG."
        '
        'gbTIPOCID
        '
        Me.gbTIPOCID.Controls.Add(Me.rbDAPTC)
        Me.gbTIPOCID.Controls.Add(Me.rbDAPT)
        Me.gbTIPOCID.Controls.Add(Me.rbEF)
        Me.gbTIPOCID.Location = New System.Drawing.Point(9, 2)
        Me.gbTIPOCID.Name = "gbTIPOCID"
        Me.gbTIPOCID.Size = New System.Drawing.Size(75, 115)
        Me.gbTIPOCID.TabIndex = 12
        Me.gbTIPOCID.TabStop = False
        Me.gbTIPOCID.Text = "TIPO CID"
        '
        'rbEF
        '
        Me.rbEF.AutoSize = True
        Me.rbEF.Checked = True
        Me.rbEF.Location = New System.Drawing.Point(4, 23)
        Me.rbEF.Name = "rbEF"
        Me.rbEF.Size = New System.Drawing.Size(38, 17)
        Me.rbEF.TabIndex = 0
        Me.rbEF.TabStop = True
        Me.rbEF.Text = "EF"
        Me.rbEF.UseVisualStyleBackColor = True
        '
        'rbDAPT
        '
        Me.rbDAPT.AutoSize = True
        Me.rbDAPT.Location = New System.Drawing.Point(4, 52)
        Me.rbDAPT.Name = "rbDAPT"
        Me.rbDAPT.Size = New System.Drawing.Size(60, 17)
        Me.rbDAPT.TabIndex = 1
        Me.rbDAPT.Text = "DA_PT"
        Me.rbDAPT.UseVisualStyleBackColor = True
        '
        'rbDAPTC
        '
        Me.rbDAPTC.AutoSize = True
        Me.rbDAPTC.Location = New System.Drawing.Point(4, 81)
        Me.rbDAPTC.Name = "rbDAPTC"
        Me.rbDAPTC.Size = New System.Drawing.Size(67, 17)
        Me.rbDAPTC.TabIndex = 2
        Me.rbDAPTC.Text = "DA_PTC"
        Me.rbDAPTC.UseVisualStyleBackColor = True
        '
        'frmSWITCHERA
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 746)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbRESIZE)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gb61850)
        Me.Controls.Add(Me.gbIO)
        Me.Controls.Add(Me.gbGOOSES)
        Me.Controls.Add(Me.gbTIPOCID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmSWITCHERA"
        Me.Text = "SWITCHERA SOFTWARE - INGETEAM - VER_0_2_4"
        Me.gb61850.ResumeLayout(False)
        Me.gb61850.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbIO.ResumeLayout(False)
        Me.gbIO.PerformLayout()
        Me.gbRESIZE.ResumeLayout(False)
        Me.gbRESIZE.PerformLayout()
        Me.gbGOOSES.ResumeLayout(False)
        Me.gbGOOSES.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbTIPOCID.ResumeLayout(False)
        Me.gbTIPOCID.PerformLayout()
        Me.ResumeLayout(False)

    End Sub




    Friend WithEvents cmdBrowser As Button
    Friend WithEvents cmdED1_10 As Button
    Friend WithEvents cmdED1_11 As Button
    Friend WithEvents cmdED1_12 As Button
    Friend WithEvents cmdED1_13 As Button
    Friend WithEvents cmdED1_14 As Button
    Friend WithEvents cmdED1_15 As Button
    Friend WithEvents cmdED1_16 As Button
    Friend WithEvents cmdED1_17 As Button
    Friend WithEvents cmdED1_18 As Button
    Friend WithEvents cmdED1_19 As Button
    Friend WithEvents cmdED1_2 As Button
    Friend WithEvents cmdED1_20 As Button
    Friend WithEvents cmdED1_21 As Button
    Friend WithEvents cmdED1_22 As Button
    Friend WithEvents cmdED1_23 As Button
    Friend WithEvents cmdED1_24 As Button
    Friend WithEvents cmdED1_25 As Button
    Friend WithEvents cmdED1_26 As Button
    Friend WithEvents cmdED1_27 As Button
    Friend WithEvents cmdED1_28 As Button
    Friend WithEvents cmdED1_29 As Button
    Friend WithEvents cmdED1_3 As Button
    Friend WithEvents cmdED1_30 As Button
    Friend WithEvents cmdED1_31 As Button
    Friend WithEvents cmdED1_32 As Button
    Friend WithEvents cmdED1_4 As Button
    Friend WithEvents cmdED1_5 As Button
    Friend WithEvents cmdED1_6 As Button
    Friend WithEvents cmdED1_7 As Button
    Friend WithEvents cmdED1_8 As Button
    Friend WithEvents cmdED1_9 As Button
    Friend WithEvents cmdED2_1 As Button
    Friend WithEvents cmdED2_10 As Button
    Friend WithEvents cmdED2_11 As Button
    Friend WithEvents cmdED2_12 As Button
    Friend WithEvents cmdED2_13 As Button
    Friend WithEvents cmdED2_14 As Button
    Friend WithEvents cmdED2_15 As Button
    Friend WithEvents cmdED2_16 As Button
    Friend WithEvents cmdED2_17 As Button
    Friend WithEvents cmdED2_18 As Button
    Friend WithEvents cmdED2_19 As Button
    Friend WithEvents cmdED2_2 As Button
    Friend WithEvents cmdED2_20 As Button
    Friend WithEvents cmdED2_21 As Button
    Friend WithEvents cmdED2_22 As Button
    Friend WithEvents cmdED2_23 As Button
    Friend WithEvents cmdED2_24 As Button
    Friend WithEvents cmdED2_25 As Button
    Friend WithEvents cmdED2_26 As Button
    Friend WithEvents cmdED2_27 As Button
    Friend WithEvents cmdED2_28 As Button
    Friend WithEvents cmdED2_29 As Button
    Friend WithEvents cmdED2_3 As Button
    Friend WithEvents cmdED2_30 As Button
    Friend WithEvents cmdED2_31 As Button
    Friend WithEvents cmdED2_32 As Button
    Friend WithEvents cmdED2_4 As Button
    Friend WithEvents cmdED2_5 As Button
    Friend WithEvents cmdED2_6 As Button
    Friend WithEvents cmdED2_7 As Button
    Friend WithEvents cmdED2_8 As Button
    Friend WithEvents cmdED2_9 As Button
    Friend WithEvents cbPestanas As ComboBox
    Friend WithEvents gb61850 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbT1 As Label
    Friend WithEvents tbRutaExcel As TextBox
    Friend WithEvents tbIED As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdDESCONECTAR As Button
    Friend WithEvents cmdCONECTAR As Button
    Friend WithEvents tbIP As TextBox
    Friend WithEvents tbSD1_4 As TextBox
    Friend WithEvents tbSD1_3 As TextBox
    Friend WithEvents tbSD1_2 As TextBox
    Friend WithEvents tbSD1_1 As TextBox
    Friend WithEvents cmdED1_1 As Button
    Friend WithEvents gbIO As GroupBox
    Friend WithEvents tbSTATUS As TextBox
    Friend WithEvents cmdRESET_SD As Button
    Friend WithEvents tm_POLLING_SD_1 As Timer
    Friend WithEvents lbED1_1 As Label
    Friend WithEvents lbED1_2 As Label
    Friend WithEvents lbED1_3 As Label
    Friend WithEvents lbED1_4 As Label
    Friend WithEvents lbED1_5 As Label
    Friend WithEvents lbED1_6 As Label
    Friend WithEvents lbED1_7 As Label
    Friend WithEvents lbED1_8 As Label
    Friend WithEvents lbED1_9 As Label
    Friend WithEvents lbED1_10 As Label
    Friend WithEvents lbED1_13 As Label
    Friend WithEvents lbED1_11 As Label
    Friend WithEvents lbED1_14 As Label
    Friend WithEvents lbED1_12 As Label
    Friend WithEvents lbED1_15 As Label
    Friend WithEvents lbED1_16 As Label
    Friend WithEvents lbED1_17 As Label
    Friend WithEvents lbED1_18 As Label
    Friend WithEvents lbED1_25 As Label
    Friend WithEvents lbED1_21 As Label
    Friend WithEvents lbED1_26 As Label
    Friend WithEvents lbED1_19 As Label
    Friend WithEvents lbED1_29 As Label
    Friend WithEvents lbED1_22 As Label
    Friend WithEvents lbED1_27 As Label
    Friend WithEvents lbED1_20 As Label
    Friend WithEvents lbED1_30 As Label
    Friend WithEvents lbED1_23 As Label
    Friend WithEvents lbED1_28 As Label
    Friend WithEvents lbED1_24 As Label
    Friend WithEvents lbED1_31 As Label
    Friend WithEvents tbSD1_16 As TextBox
    Friend WithEvents tbSD1_15 As TextBox
    Friend WithEvents tbSD1_14 As TextBox
    Friend WithEvents tbSD1_13 As TextBox
    Friend WithEvents tbSD1_12 As TextBox
    Friend WithEvents tbSD1_11 As TextBox
    Friend WithEvents tbSD1_10 As TextBox
    Friend WithEvents tbSD1_9 As TextBox
    Friend WithEvents tbSD1_8 As TextBox
    Friend WithEvents tbSD1_7 As TextBox
    Friend WithEvents tbSD1_6 As TextBox
    Friend WithEvents tbSD1_5 As TextBox
    Friend WithEvents lbED1_32 As Label
    Friend WithEvents lbED2_1 As Label
    Friend WithEvents lbED2_2 As Label
    Friend WithEvents lbED2_17 As Label
    Friend WithEvents lbED2_9 As Label
    Friend WithEvents lbED2_18 As Label
    Friend WithEvents lbED2_5 As Label
    Friend WithEvents lbED2_25 As Label
    Friend WithEvents lbED2_10 As Label
    Friend WithEvents lbED2_21 As Label
    Friend WithEvents lbED2_3 As Label
    Friend WithEvents lbED2_26 As Label
    Friend WithEvents lbED2_13 As Label
    Friend WithEvents lbED2_19 As Label
    Friend WithEvents lbED2_6 As Label
    Friend WithEvents lbED2_29 As Label
    Friend WithEvents lbED2_11 As Label
    Friend WithEvents lbED2_22 As Label
    Friend WithEvents lbED2_4 As Label
    Friend WithEvents lbED2_27 As Label
    Friend WithEvents lbED2_14 As Label
    Friend WithEvents lbED2_20 As Label
    Friend WithEvents lbED2_7 As Label
    Friend WithEvents lbED2_30 As Label
    Friend WithEvents lbED2_12 As Label
    Friend WithEvents lbED2_23 As Label
    Friend WithEvents lbED2_8 As Label
    Friend WithEvents lbED2_28 As Label
    Friend WithEvents lbED2_15 As Label
    Friend WithEvents lbED2_24 As Label
    Friend WithEvents lbED2_16 As Label
    Friend WithEvents lbED2_31 As Label
    Friend WithEvents lbED2_32 As Label
    Friend WithEvents lbED3_1 As Label
    Friend WithEvents lbED4_1 As Label
    Friend WithEvents lbED3_2 As Label
    Friend WithEvents lbED4_2 As Label
    Friend WithEvents lbED3_17 As Label
    Friend WithEvents lbED4_17 As Label
    Friend WithEvents lbED3_9 As Label
    Friend WithEvents lbED4_9 As Label
    Friend WithEvents lbED3_18 As Label
    Friend WithEvents lbED4_18 As Label
    Friend WithEvents lbED3_5 As Label
    Friend WithEvents lbED4_5 As Label
    Friend WithEvents lbED3_25 As Label
    Friend WithEvents lbED4_25 As Label
    Friend WithEvents lbED3_10 As Label
    Friend WithEvents lbED4_10 As Label
    Friend WithEvents lbED3_21 As Label
    Friend WithEvents lbED4_21 As Label
    Friend WithEvents lbED3_3 As Label
    Friend WithEvents lbED4_3 As Label
    Friend WithEvents lbED3_26 As Label
    Friend WithEvents lbED4_26 As Label
    Friend WithEvents lbED3_13 As Label
    Friend WithEvents lbED4_13 As Label
    Friend WithEvents lbED3_19 As Label
    Friend WithEvents lbED4_19 As Label
    Friend WithEvents lbED3_6 As Label
    Friend WithEvents lbED4_6 As Label
    Friend WithEvents lbED3_29 As Label
    Friend WithEvents lbED4_29 As Label
    Friend WithEvents lbED3_11 As Label
    Friend WithEvents lbED4_11 As Label
    Friend WithEvents lbED3_22 As Label
    Friend WithEvents lbED4_22 As Label
    Friend WithEvents lbED3_4 As Label
    Friend WithEvents lbED4_4 As Label
    Friend WithEvents lbED3_27 As Label
    Friend WithEvents lbED4_27 As Label
    Friend WithEvents lbED3_14 As Label
    Friend WithEvents lbED4_14 As Label
    Friend WithEvents lbED3_20 As Label
    Friend WithEvents lbED4_20 As Label
    Friend WithEvents lbED3_7 As Label
    Friend WithEvents lbED4_7 As Label
    Friend WithEvents lbED3_30 As Label
    Friend WithEvents lbED4_30 As Label
    Friend WithEvents lbED3_12 As Label
    Friend WithEvents lbED4_12 As Label
    Friend WithEvents lbED3_23 As Label
    Friend WithEvents lbED4_23 As Label
    Friend WithEvents lbED3_8 As Label
    Friend WithEvents lbED4_8 As Label
    Friend WithEvents lbED3_28 As Label
    Friend WithEvents lbED4_28 As Label
    Friend WithEvents lbED3_15 As Label
    Friend WithEvents lbED4_15 As Label
    Friend WithEvents lbED3_24 As Label
    Friend WithEvents lbED4_24 As Label
    Friend WithEvents lbED3_16 As Label
    Friend WithEvents lbED4_16 As Label
    Friend WithEvents lbED3_31 As Label
    Friend WithEvents lbED4_31 As Label
    Friend WithEvents lbED3_32 As Label
    Friend WithEvents lbED4_32 As Label
    Friend WithEvents lbED5_1 As Label
    Friend WithEvents lbED6_1 As Label
    Friend WithEvents lbED5_2 As Label
    Friend WithEvents lbED6_2 As Label
    Friend WithEvents lbED5_17 As Label
    Friend WithEvents lbED6_17 As Label
    Friend WithEvents lbED5_9 As Label
    Friend WithEvents lbED6_9 As Label
    Friend WithEvents lbED5_18 As Label
    Friend WithEvents lbED6_18 As Label
    Friend WithEvents lbED5_5 As Label
    Friend WithEvents lbED6_5 As Label
    Friend WithEvents lbED5_25 As Label
    Friend WithEvents lbED6_25 As Label
    Friend WithEvents lbED5_10 As Label
    Friend WithEvents lbED6_10 As Label
    Friend WithEvents lbED5_21 As Label
    Friend WithEvents lbED6_21 As Label
    Friend WithEvents lbED5_3 As Label
    Friend WithEvents lbED6_3 As Label
    Friend WithEvents lbED5_26 As Label
    Friend WithEvents lbED6_26 As Label
    Friend WithEvents lbED5_13 As Label
    Friend WithEvents lbED6_13 As Label
    Friend WithEvents lbED5_19 As Label
    Friend WithEvents lbED6_19 As Label
    Friend WithEvents lbED5_6 As Label
    Friend WithEvents lbED6_6 As Label
    Friend WithEvents lbED5_29 As Label
    Friend WithEvents lbED6_29 As Label
    Friend WithEvents lbED5_11 As Label
    Friend WithEvents lbED6_11 As Label
    Friend WithEvents lbED5_22 As Label
    Friend WithEvents lbED6_22 As Label
    Friend WithEvents lbED5_4 As Label
    Friend WithEvents lbED6_4 As Label
    Friend WithEvents lbED5_27 As Label
    Friend WithEvents lbED6_27 As Label
    Friend WithEvents lbED5_14 As Label
    Friend WithEvents lbED6_14 As Label
    Friend WithEvents lbED5_20 As Label
    Friend WithEvents lbED6_20 As Label
    Friend WithEvents lbED5_7 As Label
    Friend WithEvents lbED6_7 As Label
    Friend WithEvents lbED5_30 As Label
    Friend WithEvents lbED6_30 As Label
    Friend WithEvents lbED5_12 As Label
    Friend WithEvents lbED6_12 As Label
    Friend WithEvents lbED5_23 As Label
    Friend WithEvents lbED6_23 As Label
    Friend WithEvents lbED5_8 As Label
    Friend WithEvents lbED6_8 As Label
    Friend WithEvents lbED5_28 As Label
    Friend WithEvents lbED6_28 As Label
    Friend WithEvents lbED5_15 As Label
    Friend WithEvents lbED6_15 As Label
    Friend WithEvents lbED5_24 As Label
    Friend WithEvents lbED6_24 As Label
    Friend WithEvents lbED5_16 As Label
    Friend WithEvents lbED6_16 As Label
    Friend WithEvents lbED5_31 As Label
    Friend WithEvents lbED6_31 As Label
    Friend WithEvents lbED5_32 As Label
    Friend WithEvents lbED6_32 As Label
    Friend WithEvents lbED7_1 As Label
    Friend WithEvents lbED7_2 As Label
    Friend WithEvents lbED7_17 As Label
    Friend WithEvents lbED7_9 As Label
    Friend WithEvents lbED7_18 As Label
    Friend WithEvents lbED7_5 As Label
    Friend WithEvents lbED7_25 As Label
    Friend WithEvents lbED7_10 As Label
    Friend WithEvents lbED7_21 As Label
    Friend WithEvents lbED7_3 As Label
    Friend WithEvents lbED7_26 As Label
    Friend WithEvents lbED7_13 As Label
    Friend WithEvents lbED7_19 As Label
    Friend WithEvents lbED7_6 As Label
    Friend WithEvents lbED7_29 As Label
    Friend WithEvents lbED7_11 As Label
    Friend WithEvents lbED7_22 As Label
    Friend WithEvents lbED7_4 As Label
    Friend WithEvents lbED7_27 As Label
    Friend WithEvents lbED7_14 As Label
    Friend WithEvents lbED7_20 As Label
    Friend WithEvents lbED7_7 As Label
    Friend WithEvents lbED7_30 As Label
    Friend WithEvents lbED7_12 As Label
    Friend WithEvents lbED7_23 As Label
    Friend WithEvents lbED7_8 As Label
    Friend WithEvents lbED7_28 As Label
    Friend WithEvents lbED7_15 As Label
    Friend WithEvents lbED7_24 As Label
    Friend WithEvents lbED7_16 As Label
    Friend WithEvents lbED7_31 As Label
    Friend WithEvents lbED7_32 As Label
    Friend WithEvents tbSD7_16 As TextBox
    Friend WithEvents tbSD6_16 As TextBox
    Friend WithEvents tbSD5_16 As TextBox
    Friend WithEvents tbSD4_16 As TextBox
    Friend WithEvents tbSD3_16 As TextBox
    Friend WithEvents tbSD7_15 As TextBox
    Friend WithEvents tbSD6_15 As TextBox
    Friend WithEvents tbSD5_15 As TextBox
    Friend WithEvents tbSD4_15 As TextBox
    Friend WithEvents tbSD3_15 As TextBox
    Friend WithEvents tbSD7_14 As TextBox
    Friend WithEvents tbSD6_14 As TextBox
    Friend WithEvents tbSD5_14 As TextBox
    Friend WithEvents tbSD4_14 As TextBox
    Friend WithEvents tbSD3_14 As TextBox
    Friend WithEvents tbSD7_13 As TextBox
    Friend WithEvents tbSD6_13 As TextBox
    Friend WithEvents tbSD5_13 As TextBox
    Friend WithEvents tbSD4_13 As TextBox
    Friend WithEvents tbSD3_13 As TextBox
    Friend WithEvents tbSD7_12 As TextBox
    Friend WithEvents tbSD6_12 As TextBox
    Friend WithEvents tbSD5_12 As TextBox
    Friend WithEvents tbSD4_12 As TextBox
    Friend WithEvents tbSD3_12 As TextBox
    Friend WithEvents tbSD7_11 As TextBox
    Friend WithEvents tbSD6_11 As TextBox
    Friend WithEvents tbSD5_11 As TextBox
    Friend WithEvents tbSD4_11 As TextBox
    Friend WithEvents tbSD3_11 As TextBox
    Friend WithEvents tbSD7_10 As TextBox
    Friend WithEvents tbSD6_10 As TextBox
    Friend WithEvents tbSD5_10 As TextBox
    Friend WithEvents tbSD4_10 As TextBox
    Friend WithEvents tbSD3_10 As TextBox
    Friend WithEvents tbSD7_9 As TextBox
    Friend WithEvents tbSD6_9 As TextBox
    Friend WithEvents tbSD5_9 As TextBox
    Friend WithEvents tbSD4_9 As TextBox
    Friend WithEvents tbSD3_9 As TextBox
    Friend WithEvents tbSD7_8 As TextBox
    Friend WithEvents tbSD6_8 As TextBox
    Friend WithEvents tbSD5_8 As TextBox
    Friend WithEvents tbSD4_8 As TextBox
    Friend WithEvents tbSD3_8 As TextBox
    Friend WithEvents tbSD7_7 As TextBox
    Friend WithEvents tbSD6_7 As TextBox
    Friend WithEvents tbSD5_7 As TextBox
    Friend WithEvents tbSD4_7 As TextBox
    Friend WithEvents tbSD3_7 As TextBox
    Friend WithEvents tbSD7_6 As TextBox
    Friend WithEvents tbSD6_6 As TextBox
    Friend WithEvents tbSD5_6 As TextBox
    Friend WithEvents tbSD4_6 As TextBox
    Friend WithEvents tbSD3_6 As TextBox
    Friend WithEvents tbSD7_5 As TextBox
    Friend WithEvents tbSD6_5 As TextBox
    Friend WithEvents tbSD5_5 As TextBox
    Friend WithEvents tbSD4_5 As TextBox
    Friend WithEvents tbSD3_5 As TextBox
    Friend WithEvents tbSD7_4 As TextBox
    Friend WithEvents tbSD6_4 As TextBox
    Friend WithEvents tbSD5_4 As TextBox
    Friend WithEvents tbSD4_4 As TextBox
    Friend WithEvents tbSD3_4 As TextBox
    Friend WithEvents tbSD7_3 As TextBox
    Friend WithEvents tbSD6_3 As TextBox
    Friend WithEvents tbSD5_3 As TextBox
    Friend WithEvents tbSD4_3 As TextBox
    Friend WithEvents tbSD3_3 As TextBox
    Friend WithEvents tbSD7_2 As TextBox
    Friend WithEvents tbSD6_2 As TextBox
    Friend WithEvents tbSD5_2 As TextBox
    Friend WithEvents tbSD4_2 As TextBox
    Friend WithEvents tbSD3_2 As TextBox
    Friend WithEvents tbSD7_1 As TextBox
    Friend WithEvents tbSD6_1 As TextBox
    Friend WithEvents tbSD5_1 As TextBox
    Friend WithEvents tbSD4_1 As TextBox
    Friend WithEvents tbSD3_1 As TextBox
    Friend WithEvents tbSD2_16 As TextBox
    Friend WithEvents tbSD2_15 As TextBox
    Friend WithEvents tbSD2_14 As TextBox
    Friend WithEvents tbSD2_13 As TextBox
    Friend WithEvents tbSD2_12 As TextBox
    Friend WithEvents tbSD2_11 As TextBox
    Friend WithEvents tbSD2_10 As TextBox
    Friend WithEvents tbSD2_9 As TextBox
    Friend WithEvents tbSD2_8 As TextBox
    Friend WithEvents tbSD2_7 As TextBox
    Friend WithEvents tbSD2_6 As TextBox
    Friend WithEvents tbSD2_5 As TextBox
    Friend WithEvents tbSD2_4 As TextBox
    Friend WithEvents tbSD2_3 As TextBox
    Friend WithEvents tbSD2_2 As TextBox
    Friend WithEvents tbSD2_1 As TextBox
    Friend WithEvents lbT4 As Label
    Friend WithEvents lbT7 As Label
    Friend WithEvents lbT6 As Label
    Friend WithEvents cmdED7_32 As Button
    Friend WithEvents cmdED6_32 As Button
    Friend WithEvents cmdED7_24 As Button
    Friend WithEvents cmdED6_24 As Button
    Friend WithEvents cmdED7_16 As Button
    Friend WithEvents cmdED6_16 As Button
    Friend WithEvents cmdED7_31 As Button
    Friend WithEvents cmdED6_31 As Button
    Friend WithEvents cmdED7_8 As Button
    Friend WithEvents cmdED6_8 As Button
    Friend WithEvents cmdED7_23 As Button
    Friend WithEvents cmdED6_23 As Button
    Friend WithEvents cmdED7_15 As Button
    Friend WithEvents cmdED6_15 As Button
    Friend WithEvents cmdED7_30 As Button
    Friend WithEvents cmdED6_30 As Button
    Friend WithEvents cmdED7_7 As Button
    Friend WithEvents cmdED6_7 As Button
    Friend WithEvents cmdED7_22 As Button
    Friend WithEvents cmdED7_14 As Button
    Friend WithEvents cmdED6_22 As Button
    Friend WithEvents cmdED7_29 As Button
    Friend WithEvents cmdED6_14 As Button
    Friend WithEvents cmdED7_6 As Button
    Friend WithEvents cmdED6_29 As Button
    Friend WithEvents cmdED7_21 As Button
    Friend WithEvents cmdED6_6 As Button
    Friend WithEvents cmdED7_13 As Button
    Friend WithEvents cmdED6_21 As Button
    Friend WithEvents cmdED7_28 As Button
    Friend WithEvents cmdED3_1 As Button
    Friend WithEvents cmdED6_13 As Button
    Friend WithEvents cmdED4_1 As Button
    Friend WithEvents cmdED7_5 As Button
    Friend WithEvents cmdED6_28 As Button
    Friend WithEvents cmdED5_1 As Button
    Friend WithEvents cmdED7_20 As Button
    Friend WithEvents cmdED3_9 As Button
    Friend WithEvents cmdED6_5 As Button
    Friend WithEvents cmdED4_9 As Button
    Friend WithEvents cmdED7_12 As Button
    Friend WithEvents cmdED6_20 As Button
    Friend WithEvents cmdED5_9 As Button
    Friend WithEvents cmdED7_27 As Button
    Friend WithEvents cmdED3_17 As Button
    Friend WithEvents cmdED6_12 As Button
    Friend WithEvents cmdED4_17 As Button
    Friend WithEvents cmdED7_4 As Button
    Friend WithEvents cmdED6_27 As Button
    Friend WithEvents cmdED5_17 As Button
    Friend WithEvents cmdED7_19 As Button
    Friend WithEvents cmdED3_2 As Button
    Friend WithEvents cmdED6_4 As Button
    Friend WithEvents cmdED4_2 As Button
    Friend WithEvents cmdED7_11 As Button
    Friend WithEvents cmdED6_19 As Button
    Friend WithEvents cmdED5_2 As Button
    Friend WithEvents cmdED7_26 As Button
    Friend WithEvents cmdED3_25 As Button
    Friend WithEvents cmdED6_11 As Button
    Friend WithEvents cmdED4_25 As Button
    Friend WithEvents cmdED7_3 As Button
    Friend WithEvents cmdED6_26 As Button
    Friend WithEvents cmdED5_25 As Button
    Friend WithEvents cmdED7_18 As Button
    Friend WithEvents cmdED3_10 As Button
    Friend WithEvents cmdED6_3 As Button
    Friend WithEvents cmdED4_10 As Button
    Friend WithEvents cmdED7_10 As Button
    Friend WithEvents cmdED6_18 As Button
    Friend WithEvents cmdED5_10 As Button
    Friend WithEvents cmdED7_25 As Button
    Friend WithEvents cmdED3_18 As Button
    Friend WithEvents cmdED6_10 As Button
    Friend WithEvents cmdED4_18 As Button
    Friend WithEvents cmdED7_2 As Button
    Friend WithEvents cmdED6_25 As Button
    Friend WithEvents cmdED5_18 As Button
    Friend WithEvents cmdED7_17 As Button
    Friend WithEvents cmdED3_3 As Button
    Friend WithEvents cmdED6_2 As Button
    Friend WithEvents cmdED4_3 As Button
    Friend WithEvents cmdED7_9 As Button
    Friend WithEvents cmdED6_17 As Button
    Friend WithEvents cmdED5_3 As Button
    Friend WithEvents cmdED7_1 As Button
    Friend WithEvents cmdED3_26 As Button
    Friend WithEvents cmdED6_9 As Button
    Friend WithEvents cmdED4_26 As Button
    Friend WithEvents cmdED6_1 As Button
    Friend WithEvents lbT5 As Label
    Friend WithEvents cmdED5_26 As Button
    Friend WithEvents cmdED3_11 As Button
    Friend WithEvents lbT3 As Label
    Friend WithEvents cmdED4_11 As Button
    Friend WithEvents lbT2 As Label
    Friend WithEvents cmdED5_11 As Button
    Friend WithEvents cmdED3_19 As Button
    Friend WithEvents cmdED4_19 As Button
    Friend WithEvents cmdED5_19 As Button
    Friend WithEvents cmdED5_32 As Button
    Friend WithEvents cmdED3_4 As Button
    Friend WithEvents cmdED4_32 As Button
    Friend WithEvents cmdED4_4 As Button
    Friend WithEvents cmdED3_32 As Button
    Friend WithEvents cmdED5_24 As Button
    Friend WithEvents cmdED5_4 As Button
    Friend WithEvents cmdED4_24 As Button
    Friend WithEvents cmdED3_27 As Button
    Friend WithEvents cmdED3_24 As Button
    Friend WithEvents cmdED4_27 As Button
    Friend WithEvents cmdED5_27 As Button
    Friend WithEvents cmdED5_16 As Button
    Friend WithEvents cmdED4_16 As Button
    Friend WithEvents cmdED3_12 As Button
    Friend WithEvents cmdED3_16 As Button
    Friend WithEvents cmdED4_12 As Button
    Friend WithEvents cmdED5_12 As Button
    Friend WithEvents cmdED5_31 As Button
    Friend WithEvents cmdED4_31 As Button
    Friend WithEvents cmdED3_20 As Button
    Friend WithEvents cmdED3_31 As Button
    Friend WithEvents cmdED4_20 As Button
    Friend WithEvents cmdED5_20 As Button
    Friend WithEvents cmdED5_8 As Button
    Friend WithEvents cmdED4_8 As Button
    Friend WithEvents cmdED3_5 As Button
    Friend WithEvents cmdED3_8 As Button
    Friend WithEvents cmdED4_5 As Button
    Friend WithEvents cmdED5_5 As Button
    Friend WithEvents cmdED5_23 As Button
    Friend WithEvents cmdED4_23 As Button
    Friend WithEvents cmdED3_28 As Button
    Friend WithEvents cmdED3_23 As Button
    Friend WithEvents cmdED4_28 As Button
    Friend WithEvents cmdED5_28 As Button
    Friend WithEvents cmdED5_15 As Button
    Friend WithEvents cmdED4_15 As Button
    Friend WithEvents cmdED3_13 As Button
    Friend WithEvents cmdED3_15 As Button
    Friend WithEvents cmdED4_13 As Button
    Friend WithEvents cmdED5_13 As Button
    Friend WithEvents cmdED5_30 As Button
    Friend WithEvents cmdED4_30 As Button
    Friend WithEvents cmdED3_21 As Button
    Friend WithEvents cmdED3_30 As Button
    Friend WithEvents cmdED4_21 As Button
    Friend WithEvents cmdED5_21 As Button
    Friend WithEvents cmdED5_7 As Button
    Friend WithEvents cmdED4_7 As Button
    Friend WithEvents cmdED3_6 As Button
    Friend WithEvents cmdED3_7 As Button
    Friend WithEvents cmdED4_6 As Button
    Friend WithEvents cmdED5_6 As Button
    Friend WithEvents cmdED5_22 As Button
    Friend WithEvents cmdED4_22 As Button
    Friend WithEvents cmdED3_29 As Button
    Friend WithEvents cmdED3_22 As Button
    Friend WithEvents cmdED4_29 As Button
    Friend WithEvents cmdED5_29 As Button
    Friend WithEvents cmdED5_14 As Button
    Friend WithEvents cmdED4_14 As Button
    Friend WithEvents cmdED3_14 As Button
    Friend WithEvents cmdDEFAULT As Button
    Friend WithEvents tpAyuda As ToolTip
    Friend WithEvents tbCODCOM As TextBox
    Friend WithEvents cmdRESIZE As Button
    Friend WithEvents gbRESIZE As GroupBox
    Friend WithEvents tbN_BOARDS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbGOOSES As GroupBox
    Friend WithEvents lbLGOOSE_12 As Label
    Friend WithEvents lbLGOOSE_8 As Label
    Friend WithEvents lbLGOOSE_4 As Label
    Friend WithEvents lbLGOOSE_11 As Label
    Friend WithEvents lbLGOOSE_10 As Label
    Friend WithEvents lbLGOOSE_7 As Label
    Friend WithEvents lbLGOOSE_6 As Label
    Friend WithEvents lbLGOOSE_9 As Label
    Friend WithEvents lbLGOOSE_3 As Label
    Friend WithEvents lbLGOOSE_5 As Label
    Friend WithEvents lbLGOOSE_2 As Label
    Friend WithEvents lbLGOOSE_1 As Label
    Friend WithEvents tm_POLLING_ED_1 As Timer
    Friend WithEvents tm_POLLING_ED_2 As Timer
    Friend WithEvents tm_POLLING_ED_3 As Timer
    Friend WithEvents tm_POLLING_ED_4 As Timer
    Friend WithEvents tm_POLLING_ED_5 As Timer
    Friend WithEvents tm_POLLING_ED_6 As Timer
    Friend WithEvents tm_POLLING_ED_7 As Timer
    Friend WithEvents tm_POLLING_SD_2 As Timer
    Friend WithEvents tm_POLLING_SD_3 As Timer
    Friend WithEvents tm_POLLING_SD_4 As Timer
    Friend WithEvents tm_POLLING_SD_5 As Timer
    Friend WithEvents tm_POLLING_SD_6 As Timer
    Friend WithEvents tm_POLLING_SD_7 As Timer
    Friend WithEvents cbBOARD7 As CheckBox
    Friend WithEvents cbBOARD6 As CheckBox
    Friend WithEvents cbBOARD5 As CheckBox
    Friend WithEvents cbBOARD4 As CheckBox
    Friend WithEvents cbBOARD3 As CheckBox
    Friend WithEvents cbBOARD2 As CheckBox
    Friend WithEvents cbBOARD1 As CheckBox
    Friend WithEvents cmdApCombo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tm_POLLING_GOOSES As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdED1_1.Click, cmdED1_2.Click, cmdED1_3.Click, cmdED1_4.Click, cmdED1_5.Click, cmdED1_6.Click, cmdED1_7.Click, cmdED1_8.Click, cmdED1_9.Click, cmdED1_10.Click, cmdED1_11.Click, cmdED1_12.Click, cmdED1_13.Click, cmdED1_14.Click, cmdED1_15.Click, cmdED1_16.Click, cmdED1_17.Click, cmdED1_18.Click, cmdED1_19.Click, cmdED1_20.Click, cmdED1_21.Click, cmdED1_22.Click, cmdED1_23.Click, cmdED1_24.Click, cmdED1_25.Click, cmdED1_26.Click, cmdED1_27.Click, cmdED1_28.Click, cmdED1_29.Click, cmdED1_30.Click, cmdED1_31.Click, cmdED1_32.Click, cmdED2_1.Click, cmdED2_2.Click, cmdED2_3.Click, cmdED2_4.Click, cmdED2_5.Click, cmdED2_6.Click, cmdED2_7.Click, cmdED2_8.Click, cmdED2_9.Click, cmdED2_10.Click, cmdED2_11.Click, cmdED2_12.Click, cmdED2_13.Click, cmdED2_14.Click, cmdED2_15.Click, cmdED2_16.Click, cmdED2_17.Click, cmdED2_18.Click, cmdED2_19.Click, cmdED2_20.Click, cmdED2_21.Click, cmdED2_22.Click, cmdED2_23.Click, cmdED2_24.Click, cmdED2_25.Click, cmdED2_26.Click, cmdED2_27.Click, cmdED2_28.Click, cmdED2_29.Click, cmdED2_30.Click, cmdED2_31.Click, cmdED2_32.Click, cmdED3_1.Click, cmdED3_2.Click, cmdED3_3.Click, cmdED3_4.Click, cmdED3_5.Click, cmdED3_6.Click, cmdED3_7.Click, cmdED3_8.Click, cmdED3_9.Click, cmdED3_10.Click, cmdED3_11.Click, cmdED3_12.Click, cmdED3_13.Click, cmdED3_14.Click, cmdED3_15.Click, cmdED3_16.Click, cmdED3_17.Click, cmdED3_18.Click, cmdED3_19.Click, cmdED3_20.Click, cmdED3_21.Click, cmdED3_22.Click, cmdED3_23.Click, cmdED3_24.Click, cmdED3_25.Click, cmdED3_26.Click, cmdED3_27.Click, cmdED3_28.Click, cmdED3_29.Click, cmdED3_30.Click, cmdED3_31.Click, cmdED3_32.Click, cmdED4_1.Click, cmdED4_2.Click, cmdED4_3.Click, cmdED4_4.Click, cmdED4_5.Click, cmdED4_6.Click, cmdED4_7.Click, cmdED4_8.Click, cmdED4_9.Click, cmdED4_10.Click, cmdED4_11.Click, cmdED4_12.Click, cmdED4_13.Click, cmdED4_14.Click, cmdED4_15.Click, cmdED4_16.Click, cmdED4_17.Click, cmdED4_18.Click, cmdED4_19.Click, cmdED4_20.Click, cmdED4_21.Click, cmdED4_22.Click, cmdED4_23.Click, cmdED4_24.Click, cmdED4_25.Click, cmdED4_26.Click, cmdED4_27.Click, cmdED4_28.Click, cmdED4_29.Click, cmdED4_30.Click, cmdED4_31.Click, cmdED4_32.Click, cmdED5_1.Click, cmdED5_2.Click, cmdED5_3.Click, cmdED5_4.Click, cmdED5_5.Click, cmdED5_6.Click, cmdED5_7.Click, cmdED5_8.Click, cmdED5_9.Click, cmdED5_10.Click, cmdED5_11.Click, cmdED5_12.Click, cmdED5_13.Click, cmdED5_14.Click, cmdED5_15.Click, cmdED5_16.Click, cmdED5_17.Click, cmdED5_18.Click, cmdED5_19.Click, cmdED5_20.Click, cmdED5_21.Click, cmdED5_22.Click, cmdED5_23.Click, cmdED5_24.Click, cmdED5_25.Click, cmdED5_26.Click, cmdED5_27.Click, cmdED5_28.Click, cmdED5_29.Click, cmdED5_30.Click, cmdED5_31.Click, cmdED5_32.Click, cmdED6_1.Click, cmdED6_2.Click, cmdED6_3.Click, cmdED6_4.Click, cmdED6_5.Click, cmdED6_6.Click, cmdED6_7.Click, cmdED6_8.Click, cmdED6_9.Click, cmdED6_10.Click, cmdED6_11.Click, cmdED6_12.Click, cmdED6_13.Click, cmdED6_14.Click, cmdED6_15.Click, cmdED6_16.Click, cmdED6_17.Click, cmdED6_18.Click, cmdED6_19.Click, cmdED6_20.Click, cmdED6_21.Click, cmdED6_22.Click, cmdED6_23.Click, cmdED6_24.Click, cmdED6_25.Click, cmdED6_26.Click, cmdED6_27.Click, cmdED6_28.Click, cmdED6_29.Click, cmdED6_30.Click, cmdED6_31.Click, cmdED6_32.Click, cmdED7_1.Click, cmdED7_2.Click, cmdED7_3.Click, cmdED7_4.Click, cmdED7_5.Click, cmdED7_6.Click, cmdED7_7.Click, cmdED7_8.Click, cmdED7_9.Click, cmdED7_10.Click, cmdED7_11.Click, cmdED7_12.Click, cmdED7_13.Click, cmdED7_14.Click, cmdED7_15.Click, cmdED7_16.Click, cmdED7_17.Click, cmdED7_18.Click, cmdED7_19.Click, cmdED7_20.Click, cmdED7_21.Click, cmdED7_22.Click, cmdED7_23.Click, cmdED7_24.Click, cmdED7_25.Click, cmdED7_26.Click, cmdED7_27.Click, cmdED7_28.Click, cmdED7_29.Click, cmdED7_30.Click, cmdED7_31.Click, cmdED7_32.Click

        Try

            Dim ref850_DITYPE
            Dim pos_array
            Dim aux1 As Integer
            Dim aux2 As Integer
            Dim aux3 As Integer
            Dim val_array_ED
            Dim val_DITYPE As String

            If tbIED.Text = "" Then                                         'COMPROBACION DE PULSACION CON NOMBRE VACIO
                MsgBox("NOMBRE IED VACIO")
                tbIED.Focus()
                Exit Sub
            End If

            If tbIP.Text = "" Then                                          'COMPROBACION DE PULSACION CON DIRECCION IP VACIA
                MsgBox("DIRECCION IP VACIA")
                tbIP.Focus()
                Exit Sub
            End If

            If tbSTATUS.BackColor <> Color.GreenYellow Then                       'ERROR  CON MENSAJE DE CONEXION NO CONSEGUIDA
                MsgBox("Conexion no establecida con el IED")
                Exit Sub
            End If

            'GENERAR REFERENCIA 850 PARA CAMBIAR EL DATO
            ref850_DITYPE = tbIED.Text + "GEN/GGIO" + Mid(sender.Name, 6, 1) + ".DI" + Mid(sender.Name, 8, 2) + "Type.setVal"

            'LECTURA DE UNA REFERENCIA SP POR MMS
            val_DITYPE = conexion.ReadIntegerValue(ref850_DITYPE, FunctionalConstraint.SP)

            aux1 = Mid(sender.Name, 6, 1)                                   'EXTRAER NUMERO DE TARJETA Y NUMERO DE ENTRADA
            aux2 = Mid(sender.Name, 8, 2)
            aux3 = (Mid(sender.Name, 6, 1) - 1) * 32

            'CONSEGUIR POSICION DEL ARRAY DONDE ESTÁ EL VALOR ACTUAL RDEL ESTADO DE LA ENTRADA
            pos_array = (Mid(sender.Name, 6, 1) - 1) * 32 + Mid(sender.Name, 8, 2)
            val_array_ED = EDS_TOTALES(pos_array)

            If val_DITYPE = True Then                                     'PONER EL SP A 0 o 1 DEPENDIENDO DEL VALOR ALMACENADO DEL ARRAY
                conexion.WriteValue(ref850_DITYPE, FunctionalConstraint.SP, New MmsValue(0))
                sender.BackColor = Color.LightGreen
            ElseIf val_DITYPE = False Then
                conexion.WriteValue(ref850_DITYPE, FunctionalConstraint.SP, New MmsValue(1))
                sender.BackColor = Color.Orange
                EDS_TOTALES(pos_array) = True
            End If

        Catch ex As Exception
            MsgBox("El nombre del IED no concuerda con el fichero subido, pon a mano el nombre")
        End Try

    End Sub

    Dim EDS_TOTALES(224) As Boolean                             'ARRAY QUE MANEJA EL VALOR DE LAS 224 ENTRADAS QUE HAY DISPONIBLES

    Dim conexion As IedConnection                               'VARIABLE QUE GESTIONA LA CONEXION MMS CON EL EQUIPO INGETEAM

    Dim TARJ_TOTALES As Integer                                 'VARIABLE QUE LEE EL NUMERO DE TARJETAS DIFERENTES DE "VACIA" DE LA PESTAÑA DE EXCEL ACTIVA


    Private Sub cmdCONECTAR_Click(sender As Object, e As EventArgs) Handles cmdCONECTAR.Click
        '__
        Try

            If tbIP.Text = "" Then                              'COMPROBAR LA DIRECCION IP
                DIRECCION_IP_MAL()
                Exit Sub
            End If


            If tbIED.Text = "" Then                             'COMPROBAR EL NOMBRE DEL IED
                MsgBox("NOMBRE IED VACIO")
                Exit Sub
            End If

            'PEGAR AQUI EL COGIDO DE LA CONEXION FTP

            conexion = New IedConnection()                      'CONEXION CON EL CSHARP DONTNET_61850.DLL QUE CONECTA CON LA LIBRERIA C++ 61850.DLL
            conexion.Connect(tbIP.Text)                         'SE ESPECIFICA LA IP A LA QUE CONECTARSE

            tbSTATUS.BackColor = Color.GreenYellow                    'LED A VERDE SI LA CONEXION ES BUENA

            tm_POLLING_SD_1.Enabled = True                        'ACTIVAR LECTURA DE DATOS EN SEGUNDO PLANO
            tm_POLLING_SD_2.Enabled = True
            tm_POLLING_SD_3.Enabled = True
            tm_POLLING_SD_4.Enabled = True
            tm_POLLING_SD_5.Enabled = True
            tm_POLLING_SD_6.Enabled = True
            tm_POLLING_SD_7.Enabled = True
            tm_POLLING_ED_1.Enabled = True
            tm_POLLING_ED_2.Enabled = True
            tm_POLLING_ED_3.Enabled = True
            tm_POLLING_ED_4.Enabled = True
            tm_POLLING_ED_5.Enabled = True
            tm_POLLING_ED_6.Enabled = True
            tm_POLLING_ED_7.Enabled = True
            tm_POLLING_GOOSES.Enabled = True
            LEER_GOOSES()
            cmdCONECTAR.Enabled = False                         'DESHABILITO EL BOTON DE CONECTAR CON CONEXION ACTIVADA
            cmdDESCONECTAR.Enabled = True                       'HABILITO EL BOTON DE DESCONECTAR CON CONEXION ACTIVADA
            STATUS_TARJETAS()
            COMPROBAR_CALIDAD()

        Catch err As Exception

            tbSTATUS.BackColor = Color.Red                      'INFORMACION DE FALLO DE LA CONXION CON EL CODIGO DE ERROR
            MsgBox(err.Message,)

        End Try

    End Sub

    Private Sub tbIP_Leave(sender As Object, e As EventArgs) Handles tbIP.Leave

        Dim ArrCadena As String() = tbIP.Text.Split(".")        'CREO UN ARRAY DONDE GUARDO CADA UNO DE LOS OCTETOS DE LA DIRECCION IP
        Dim aBuscar As Char = "."                               'DEFINO UNA VARIABLE CON EL VALOR QUE SEPARA CADA OCTETO DEL ADIRECCION IP
        Dim n As Integer = 0                                    'DEFINO VARIABLE CON VALOR 0

        For Each c As Char In tbIP.Text                         'RECORRO LA CADENA DE LA IP CARACTER POR CARACTER PARA DETECTAR CUANTOS PUNTO HAY DENTRO
            If c = aBuscar Then
                n = n + 1
            End If
        Next
        If n <> 3 Then                                          'SI NO HAY 3 PUNTOS SALGO DEL SUB Y DOY ERROR
            If tbIP.Text = "" Then
                Exit Sub
            End If
            DIRECCION_IP_MAL()
            Exit Sub
        End If

        Try                                                     'COMPRUEBO SI TODOS LOS OCTETOS TIENEN UN VALOR
            If ArrCadena(0) Is Nothing Or ArrCadena(1) Is Nothing Or ArrCadena(2) Is Nothing Or ArrCadena(3) Is Nothing Then
                DIRECCION_IP_MAL()
                Exit Sub
            End If

            If ArrCadena(0) < 255 And ArrCadena(0) > 0 Then     'COMPRUEBO QUE CADA OCTETO ES MENOR QUE 255
                If ArrCadena(1) < 255 And ArrCadena(1) >= 0 Then
                    If ArrCadena(2) < 255 And ArrCadena(2) >= 0 Then
                        If ArrCadena(3) > 254 And ArrCadena(3) > 0 Then
                            DIRECCION_IP_MAL()
                            Exit Sub
                        End If
                    Else
                        DIRECCION_IP_MAL()
                        Exit Sub
                    End If
                Else
                    DIRECCION_IP_MAL()
                    Exit Sub
                End If
            Else
                DIRECCION_IP_MAL()
                Exit Sub
            End If

        Catch ex As Exception
            DIRECCION_IP_MAL()
        End Try

    End Sub

    Public Sub DIRECCION_IP_MAL()

        MsgBox("DIRECCION IP ERRONEA")                          'FUNCION RECURRENTE PARA DAR EL ERROR EN LA IP
        tbIP.Focus()
        tbIP.SelectAll()
        Exit Sub

    End Sub


    Private Sub Activar_salida(ByVal CtrlName As String, ByVal color_X As Color)
        Dim xCtrl() As Control = Controls.Find(CtrlName, True)  'FUNCION QUE RECIBE EL NOMBRE DEL TBEDX_Y  Y EL COLOR AL QUE DEBE PONERSE DICHO TEXTBOX
        For Each iControl As Control In xCtrl
            If iControl.Name = CtrlName Then
                Dim xTxt As TextBox = DirectCast(iControl, TextBox)
                xTxt.BackColor = color_X
            End If
        Next
    End Sub

    Private Sub Activar_entrada(ByVal CtrlName As String, ByVal color_X As Color)
        Dim xCtrl() As Control = Controls.Find(CtrlName, True)  'FUNCION QUE RECIBE EL NOMBRE DEL TBEDX_Y  Y EL COLOR AL QUE DEBE PONERSE DICHO TEXTBOX
        For Each iControl As Control In xCtrl
            If iControl.Name = CtrlName Then
                Dim xTxt As Button = DirectCast(iControl, Button)
                xTxt.BackColor = color_X
            End If
        Next
    End Sub


    Public Sub LEER_SDs()
        Dim SDs_TOTALES As Integer = 112
        Dim val_SD As String
        Dim ref_SD As String
        Dim N_SD As Integer = 1
        Dim N_BOARD As Integer = 1
        Try
            For tarjeta_SD As Integer = 1 To 7                  'RECORRO VARIABLE CON EL TOTAL DE TARJETAS
                For numero_SD As Integer = 1 To 16              'RECORRO VARIABLE CON EL TATAL DE SALIDAS POSILBES
                    If N_BOARD = 1 And N_SD = 5 Then            'CONTROLO EL INTENTO DE LEER UNA DIRECCION QUE NO EXISTE
                        Exit For
                    End If                                      'GENERO REFERENCIA 850 Y REALIZO SU LECTURA
                    ref_SD = tbIED.Text & "GEN/GGIO" & N_BOARD.ToString & ".SPCSO" & N_SD.ToString & ".stVal"
                    val_SD = conexion.ReadBooleanValue(ref_SD, FunctionalConstraint.ST)
                    If val_SD = True Then                       'SI LA SALIDA ESTA ACTIVADA GENERO LA CADENA NECESARIA PARA ENVIARSELA A LA FUNCION DE PINTAR TEXTBOX
                        Dim tbname As String = "tbSD" & N_BOARD.ToString & "_" & N_SD.ToString
                        Activar_salida(tbname, Color.Red)
                    End If
                    N_SD = N_SD + 1
                Next
                N_SD = 1                                        'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
                N_BOARD = N_BOARD + 1                           '
            Next

        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)
        End Try

    End Sub

    Public Sub LEER_SDs_NBOARD(N_BOARD)
        Dim SDs_TOTALES As Integer = 112
        Dim val_SD As String
        Dim ref_SD As String
        Dim N_SD As Integer = 1
        Dim TIPO_EQUIPO
        If rbEF.Checked = True Then
            TIPO_EQUIPO = 5
        Else
            TIPO_EQUIPO = 6
        End If
        Try
            For numero_SD As Integer = 1 To 16              'RECORRO VARIABLE CON EL TATAL DE SALIDAS POSILBES
                If N_BOARD = 1 And N_SD = TIPO_EQUIPO Then            'CONTROLO EL INTENTO DE LEER UNA DIRECCION QUE NO EXISTE
                    Exit For
                End If                                      'GENERO REFERENCIA 850 Y REALIZO SU LECTURA
                ref_SD = tbIED.Text & "GEN/GGIO" & N_BOARD.ToString & ".SPCSO" & N_SD.ToString & ".stVal"
                val_SD = conexion.ReadBooleanValue(ref_SD, FunctionalConstraint.ST)
                If val_SD = True Then                       'SI LA SALIDA ESTA ACTIVADA GENERO LA CADENA NECESARIA PARA ENVIARSELA A LA FUNCION DE PINTAR TEXTBOX
                    Dim tbname As String = "tbSD" & N_BOARD.ToString & "_" & N_SD.ToString
                    Activar_salida(tbname, Color.Red)
                End If
                N_SD = N_SD + 1
            Next
            N_SD = 1                                        'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
            N_BOARD = N_BOARD + 1                           '
        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)
        End Try

    End Sub

    Public Sub frmSWITCHERA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AutoScroll = True                                    'HABILITO EL SCROLL POR SI ES NECESARIO REDIMENIONAR EL FORMULARIO
        tbSTATUS.BackColor = Color.Red                          'PONGO EN ROJO EL BOTON DE CONEXION PARA INDICAR QUE NO HAY
        For i As Integer = 0 To EDS_TOTALES.Length - 1          'INICIALIZO TODOS LOS VALORES DEL ARRAY A 0
            EDS_TOTALES(i) = 0
        Next
        RE_COLOCAR()                                            'DISTRIBUYO UNIFORMEMENTE TODOS LOS ELEMENTOS DENTRO DEL FORMULARIO
    End Sub

    Private Sub cmdRESET_ED_Click(sender As Object, e As EventArgs) Handles cmdRESET_ED.Click
        RESET_INPUTS()
    End Sub

    Private Sub cmdRESET_SD_Click(sender As Object, e As EventArgs) Handles cmdRESET_SD.Click

        Dim SDs_TOTALES As Integer = 112                        'DEFINO VARIABLE CON EL TOTAL DE SALIDAS
        Dim N_SD As Integer = 1
        Dim N_BOARD As Integer = 1
        Try
            For tarjeta_SD As Integer = 1 To 7                  'RECORRO TODAS LA TARJETAS
                For numero_SD As Integer = 1 To 16              'RECORRO TODAS LAS SALIDAS Y GENERO CADENA PARA RESTABLECER EL COLOR DE CADA UNA DE LAS TBEDX_Y
                    Dim tbname As String = "tbSD" & N_BOARD.ToString & "_" & N_SD.ToString
                    Activar_salida(tbname, BackColor)
                    N_SD = N_SD + 1
                Next
                N_SD = 1
                N_BOARD = N_BOARD + 1
            Next

        Catch err As Exception
            MsgBox(err.Message)                                 'SE RECOGE ERROR PARA DEBUG
        End Try
    End Sub

    Private Sub Timer1_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_1.Tick
        Dim N_BOARD As Integer = 1
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer2_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_2.Tick
        Dim N_BOARD As Integer = 2
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer3_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_3.Tick
        Dim N_BOARD As Integer = 3
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer4_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_4.Tick
        Dim N_BOARD As Integer = 4
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer5_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_5.Tick
        Dim N_BOARD As Integer = 5
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer6_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_6.Tick
        Dim N_BOARD As Integer = 6
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer7_SD_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_SD_7.Tick
        Dim N_BOARD As Integer = 7
        LEER_SDs_NBOARD(N_BOARD)                                              'DESENCADENO LA LECTURA PERIODICA DE LAS VARIABLES DE SALIDAS 61850
    End Sub

    Private Sub Timer1_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_1.Tick
        Dim N_BOARD As Integer = 1
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer2_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_2.Tick
        Dim N_BOARD As Integer = 2
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer3_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_3.Tick
        Dim N_BOARD As Integer = 3
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer4_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_4.Tick
        Dim N_BOARD As Integer = 4
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer5_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_5.Tick
        Dim N_BOARD As Integer = 5
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer6_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_6.Tick
        Dim N_BOARD As Integer = 6
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Private Sub Timer7_ED_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_ED_7.Tick
        Dim N_BOARD As Integer = 7
        LEER_EDs_NBOARD(N_BOARD)
    End Sub

    Sub SomeButton_Click(sender As Object, e As EventArgs) Handles cmdBrowser.Click
        cbPestanas.Items.Clear()                                'LIMPIO Y VACIO EL COMBOBOX SIEMPRE QUES PULSE EL BOTÓN DE BROWSEAR
        cbPestanas.Text = ""
        Me.Text = "SWITCHERA SOFTWARE - INGETEAM - VER_0_2_3"
        Try                                                     'BUSCO EN EL SISTEMA EL EXCEL QUE VOY A ANALIZAR EN BUSCA DE PESTAÑAS CON BASES DE DATOS

            Using dialog As New OpenFileDialog                  'GENERO CUADRO DE DIALOGO CON EL QUE ENCONTAR EL EXCEL QUE NECESITEMOS
                dialog.Filter = "Libro de Excel 97-2003|*.xls|Libro de excel|*.xlsx"
                If dialog.ShowDialog() <> DialogResult.OK Then Return
                tbRutaExcel.Text = dialog.FileName
            End Using

            Dim PESTANA_XLS As Excel.Worksheet
            Dim XLS_LIBRO As New Excel.Application

            XLS_LIBRO.Workbooks.Open(tbRutaExcel.Text, 0, True)

            ' ################## PENDIENTE INTENTAR OCULTAR FORMULARIO DE LA EXCEL PROPIA EXCEL #################

            PESTANA_XLS = CType(XLS_LIBRO.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            Dim strSheetName As New List(Of String)

            For Each PESTANA_XLS In XLS_LIBRO.Sheets            'RECORRO UNA PRIMERA VEZ EL LIBRO EXCEL PARA COMPROBAR QUE EL EXCEL QUE ESTOY REVISANDO ES UN EXCEL DE TIPO BASE DE DATOS
                If PESTANA_XLS.Name = "PLANTILLA" Or PESTANA_XLS.Name = "TEMPLATE_EF" Or PESTANA_XLS.Name = "61850" Or PESTANA_XLS.Name = "_VERSIONES_" Or PESTANA_XLS.Name = "TEMPLATE_DA_PT" Or PESTANA_XLS.Name = "TEMPLATE_NO_INGE" Or PESTANA_XLS.Name = "DIGITALES" Or PESTANA_XLS.Name = "MEDIDAS" Or PESTANA_XLS.Name = "ORDENES" Or PESTANA_XLS.Name = "VERSIONES" Then
                    Exit For
                Else
                    MsgBox("El excel que has seleccionado no es uno de tipo de base de datos." + vbNewLine + vbNewLine + "La pestaña ''" + PESTANA_XLS.Name + "'' no es correcta.")
                    XLS_LIBRO.Workbooks.Close()                 '######### AVERIGUAR COMO FORZAR LA SALIDA SIN GUARDAR O ABRIR SOLO EN MODO LECTURA #######
                    XLS_LIBRO.Quit()
                    Exit Sub
                End If
            Next

            For Each PESTANA_XLS In XLS_LIBRO.Sheets            'RECORRO UNA SEGUNDA VEZ EL LIBRO EXCEL PARA LISTAR EN EL COMBOBOX TODAS LAS QUE NO SEAN LAS PESTAÑAS POR DEFECTO DEL DOCUMENTO.
                If PESTANA_XLS.Name <> "PLANTILLA" And PESTANA_XLS.Name <> "TEMPLATE_EF" And PESTANA_XLS.Name <> "61850" And PESTANA_XLS.Name <> "_VERSIONES_" And PESTANA_XLS.Name <> "TEMPLATE_DA_PT" And PESTANA_XLS.Name <> "TEMPLATE_NO_INGE" And PESTANA_XLS.Name <> "DIGITALES" And PESTANA_XLS.Name <> "MEDIDAS" And PESTANA_XLS.Name <> "ORDENES" And PESTANA_XLS.Name <> "VERSIONES" Then
                    cbPestanas.Items.Add(PESTANA_XLS.Name)
                End If
            Next

            Me.Text = Me.Text & " - " & tbRutaExcel.Text        'PONGO LA RUTA DEL ARCHIVO QUE ESTAMOS LEYENDO EN LA BARRA DE TITULO DE LA PROPIA VENTANA

        Catch err As Exception
            MsgBox(err.Message)                                 'CONTROL DE ERRORES GENERICO
        End Try

    End Sub

    Private Sub cbPestanas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPestanas.SelectedIndexChanged

        Try
            Dim libro_destino As String = cbPestanas.Items(cbPestanas.SelectedIndex).ToString

            Dim app_excel As Excel.Application
            Dim excel_actual As Excel.Workbook
            Dim tab_actual As Excel.Worksheet

            app_excel = New Excel.Application
            app_excel.Visible = False
            excel_actual = app_excel.Workbooks.Open(tbRutaExcel.Text)
            tab_actual = CType(excel_actual.Sheets(libro_destino), Excel.Worksheet) 'TROZO DE CODIGO PARA PODER ABRIR UN EXCEL DEL DISCO DURO

            tbCODCOM.Text = tab_actual.Cells(6, 1).value                            'EXTRAEMOS EL CODIGO COMERCIAL PARA PODER VERLO EN EL EN FORMULARIO
            Dim COD_TARJETA As String = Mid(tbCODCOM.Text, 22, 14)
            TARJ_TOTALES = CStr(COD_TARJETA.Where(Function(x) x <> "A"c).Count())   'CONTAR TARJETAS DIFFERENTES A PARA SABER CUANTAS TIENES

            RE_SHOW()                                                               'RESTABLECER LA VISTA INICIAL DE LOS ELEMENTOS ANTES DE REALZAR EL FILTRADO

            Dim celda_ied_name As String = tab_actual.Cells(17, 1).value            'EXTRAEMOS LA LINEA DONDE SE ENCUENTRA EL IED
            Dim ied_name As String = Mid(celda_ied_name, 13, 30)                    'EXTREAMOS LA PARTE QUE ES NOMBRE DE IED DE LA CELDA ANTERIOR
            Dim pos_ggio As Integer = Len(ied_name) + 10                            'POSICIONAMOS LA LOCALIZACION DEL NUMERO DE GGIO EN BASE AL NOMBRE DEL IED
            Dim pos_ind As Integer = Len(ied_name) + 15                             'POSICIONAMOS LA LOCALIZACION DEL NUMERO DE GGIO EN BASE AL NOMBRE DEL IED
            Dim FIL As Integer = 22                                                 'VARIABLE CON LA FILA INICIAL DESDE DONDE ESTÁ EL PRIMERA REFERENCIA 850
            Dim COL As Integer = 8                                                  'VARIABLE CON LA COLUMNA INICIAL DESDE DONDE ESTÁ EL PRIMERA REFERENCIA 850
            Dim actual_ggio As String                                               'VARIABLE PARA ALAMACENAR EL Nº DE ENTRADA DEL GGIO DE LA FILA QUE SE VA A LEER DEL EXCEL
            Dim actual_ind As String                                                'VARIABLE PARA ALAMACENAR EL Nº DE ENTRADA DEL IND DE LA FILA QUE SE VA A LEER DEL EXCEL
            Dim actual_GGIO_SPCSO As String                                         'VARIABLE PARA ALAMACENAR EL Nº DE SALIDA DEL GGIO DE LA FILA QUE SE VA A LEER DEL EXCEL
            Dim actual_SPCSO As String                                              'VARIABLE PARA ALAMACENAR EL Nº DE SALIDA DEL SPCSO DE LA FILA QUE SE VA A LEER DEL EXCEL

            For GGIO = 1 To 7                                                       'SE COMIENZA A RECORRER EL TODOS LOS GGIOS EXISTENTES
                For IND = 1 To 32                                                   'SE RECORREN TODAS LAS ENTRDAS DE LOS INDS POSIBLES
                    Dim celda_excel1 As String = tab_actual.Cells(FIL, COL).value   'SE VUELCA A LA VARIABLE EL VALOR DE LA CELDA CON LA REF. 850
                    Dim esSD As String = Mid(celda_excel1, pos_ggio + 2, 5)         'SE VUELCA A UNA VARIABLE LA PALABRA SPCSO PARA SABER SI SE ESTA TRATANDO DE UNA SALIDA
                    If esSD <> "SPCSO" Then                                         'SI ES UNA ENTRADA ENTRAMOS EN ESTA PARTE DEL IF
                        actual_ggio = Mid(celda_excel1, pos_ggio, 1)                'EXTRAMOS EL NUMERO DE GGIO
                        actual_ind = Mid(celda_excel1, pos_ind, 2)                  'EXTRAEMOS EL NUMERO DE IND
                        If GGIO = actual_ggio Then                                  'SI COINCIDE EL GGIO DEL "FOR" CON EL DEL VALOR EXTRAIDO DE LA EXCEL LO VOLCAREMOS SOBRE LA ETIQUETA QUE LE CORRESPONDE
                            Dim celda_excel2 As String = tab_actual.Cells(FIL, COL + 1).value
                            Dim lbname As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                            Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                            lbname(0).Text = celda_excel2
                            tpAyuda.SetToolTip(lbname(0), celda_excel2)
                            tpAyuda.SetToolTip(cmdNAME(0), celda_excel2)
                            FIL = FIL + 1                                           'AUMENTAMOS LA FILA PARA LEER EL SIGUIENTE REGISTRO DEL EXCEL EN EL SIGUIENTE PASO DEL "FOR"
                        Else                                                        'SI EL GGIO DEL "FOR" ES DIFERENTE AL LEIDO QUIERE DECIR QUE HEMOS CAMBIADO DE TARJETA EN LA EXCEL
                            For resto = IND To 32                                   'HACEMOS BUCLE PARA OCULTAR LOS ELEMENTOS RELACIONADOS CON EL RESTO DE ENTRADAS QUE ESTÁN EN EL FORMULARIO PERO QUE NO ESTÁN EN EL LISTADO EXCEL
                                Dim lbname As Control() = Me.Controls.Find("lbED" & GGIO & "_" & resto, True)
                                Dim cmdname = Me.Controls.Find("cmdED" & GGIO & "_" & resto, True)
                                lbname(0).Visible = False                           ' GENERAMOS DINAMICAMENTE LAS REFERENCIAS AL LB Y AL CMD PARA PODER ESCRIBIRLAS CONTINUAMENTE 
                                cmdname(0).Visible = False
                            Next
                            Exit For                                                'SALIMOS DEL "FOR" PARA SEGUIR CON LA SIGUIENTE TARJETA
                        End If
                    Else                                                            'SI ES UNA SALIDA ENTRAMOS EN ESTA PARTE DEL ELSE Y QUERRA DECIR QUE HEMOS LLEGADO AL FINAL DE LAS TARJETAS DE ENTRADAS Y AHORA EMPEZARÁN LAS SALIDAS, POR LO QUE HABRÁ QUE EL RESTO DE LA ULTIMA TARJETA
                        For resto = IND To 32
                            Dim lbname As Control() = Me.Controls.Find("lbED" & GGIO & "_" & resto, True)
                            Dim cmdname = Me.Controls.Find("cmdED" & GGIO & "_" & resto, True)
                            lbname(0).Visible = False
                            cmdname(0).Visible = False
                        Next

                        For ggio_vacio = GGIO + 1 To 7                              'SI ES UNA SALIDA ENTRAMOS EN ESTA PARTE DEL ELSE Y QUERRA DECIR QUE HEMOS LLEGADO AL FINAL DE LAS TARJETAS DE ENTRADAS Y AHORA EMPEZARÁN LAS SALIDAS, POR LO QUE HABRÁ QUE OCULTAR TODAS LAS QUE NO APAREZCAN EN LA EXCEL
                            For resto = 1 To 32
                                Dim lbname As Control() = Me.Controls.Find("lbED" & ggio_vacio & "_" & resto, True)
                                Dim cmdname = Me.Controls.Find("cmdED" & ggio_vacio & "_" & resto, True)
                                lbname(0).Visible = False
                                cmdname(0).Visible = False
                                If resto < 17 Then                                  'OCULTAMOS TAMBIÉN LOS TB DE LAS SALIDAS 
                                    Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & resto, True)
                                    tbNAMEs(0).Visible = False
                                End If
                            Next
                        Next

                        For GGIO_SPCSO = 1 To 7                                      'COMENZAMOS A OCULTAR Y DEJAR VISIBLES LOS ELEMENTOS DE TIPO TEXBOX QUE PERTENECEN A LAS SALIDAS
                            For SPCSO = 1 To 16                                      'TAMIBÉN APLICARMOS UN TEXTO FLOTANTE SOBRE EL TEXTBOX DE LAS SALIDAS
                                Dim celda_excel3 As String = tab_actual.Cells(FIL, COL).value
                                Dim celda_excel4 As String = tab_actual.Cells(FIL, COL + 1).value
                                actual_GGIO_SPCSO = Mid(celda_excel3, pos_ggio, 1)
                                actual_SPCSO = Mid(celda_excel3, pos_ind + 2, 1)
                                If actual_GGIO_SPCSO <> Nothing Then                 'SE COMPRUEBA SI SE HA LLEGADO AL FINAL DEL FICHERO
                                    If GGIO_SPCSO = actual_GGIO_SPCSO Then           'SE COMPRUEBA SI EL GGIO DEL "FOR" CORRESPONDE CON EL GGIO LEIDO DE LA EXCEL
                                        Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO_SPCSO & "_" & SPCSO, True)
                                        tbNAMEs(0).Visible = True
                                        tbNAMEs(0).Enabled = True
                                        tpAyuda.InitialDelay = 100                   'ESPEFICO EL TIEMPO EN EL QUE ENSAÑAREMOS EL TOOLTIP 
                                        tpAyuda.SetToolTip(tbNAMEs(0), celda_excel4) 'ASIGNAMOS AL TOOLTIP DEL TEXTBOS EL VALOR DE LA CELDA DEL DOCUMENTO EXCEL
                                    Else
                                        For RESTO1 = SPCSO To 16                     'OCULTAMOS EL RESTO DE SALIDAS NO ENCONTRADAS EN LOS REGISTROS DE LA EXCEL
                                            Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO_SPCSO & "_" & RESTO1, True)
                                            tbNAMEs(0).Visible = False
                                        Next
                                        Exit For                                     'SALIMOS DEL "FOR" PARA SEGUIR CON LA SIGUIENTE TARJETA
                                    End If
                                Else

                                    For RESTO2 = SPCSO To 16                         'DESPUES DE LLEGAR AL FINAL DEL LISTADO EXCEL LIMPIO LA TARJETA QUE ME HA DADO ERROR
                                        Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO_SPCSO & "_" & RESTO2, True)
                                        tbNAMEs(0).Visible = False
                                    Next

                                End If
                                FIL = FIL + 1                                        'AUMENTAMOS EL CONTADOR PARA LEER LA SIGUIENTE FILA DE LA EXCEL
                            Next
                        Next

                        app_excel.Workbooks.Close()                                  'UNA VEZ TERMINADO EL PROCESO CERRAMOS EL LIBRO
                        app_excel.Quit()                                             ' Y EL EXCEL
                        RE_COLOCAR()                                                 'APLICAMOS  LA FUNCION RECOLOCAR PARA QUE NOS DISTRIBULLA UNIFORMEMENTE EL ESPACIO DEL FORMULARIO
                        Exit Sub
                    End If
                Next
            Next
            app_excel.Workbooks.Close()                                              'UNA VEZ TERMINADO EL PROCESO CERRAMOS EL LIBRO
            app_excel.Quit()                                                         ' Y EL EXCEL
            RE_COLOCAR()                                                             'APLICAMOS  LA FUNCION RECOLOCAR PARA QUE NOS DISTRIBULLA UNIFORMEMENTE EL ESPACIO DEL FORMULARIO
        Catch err As Exception

        End Try

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbN_BOARDS.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then                                              'SE COMPRUEBA QUE SOLO SE INTRODUZACAN CARACTERES ENTRE EL 1 Y EL 7
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 55 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdRESIZEClick(sender As Object, e As EventArgs) Handles cmdRESIZE.Click
        If tbN_BOARDS.Text = "" Then                                             'SE COMPRUEBA QUE SE HAYA METIDO UN VALOR EN EL TEXTBOX DE NUMERO DE TARJETAS
            MsgBox("PARA APLICAR LOS CAMBIOS INDIQUE PRIMERO EL NUMERO DE TARJETAS")
            tbN_BOARDS.Focus()
            Exit Sub
        End If
        RE_SHOW()                                                                'LLAMAMOS A LA FUNCION RE_SHOW PARA QUE SE RESTABLEZCA LA VISTA DE LOS ELEMENTOS
        RE_COLOCAR()                                                             'LLAMAMOS A LA FUNCION DE RE_COLOCAR PARA REDISTRIBUYA LOS ELEMENTOS EN FUNCION DEL NUMORO DE TARJETAS INDICADO
    End Sub

    Private Sub RE_SHOW()

        Dim VERX_BOARDS As Integer                                              'CONTEMPLAMOS TODOS LOS POSIBLES CASOS DE POR LAS QUE APLICAR LA FUNCION DE RE_SHOW
        If tbRutaExcel.Text = "" And tbN_BOARDS.Text = "" Then
            VERX_BOARDS = 7
        Else
            If tbN_BOARDS.Text = "" Then
                VERX_BOARDS = TARJ_TOTALES
            Else
                VERX_BOARDS = tbN_BOARDS.Text
            End If
        End If


        For GGIO = 1 To VERX_BOARDS + 1 - 1                                     'RESTABLECER VISIBILIDAD DE LOS ELEMENTOS SI SE VIENE DE UNA CONFIGURACION DE TARJETAS MAS RESTRICTIVAS
            Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
            lbBOARD(0).Visible = True
            For IND = 1 To 32
                Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                cmdNAME(0).Visible = True
                lbNAME(0).Visible = True
            Next
            For IND = 1 To 16
                Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                tbNAMEs(0).Visible = True
            Next
        Next

        For GGIO = (VERX_BOARDS + 1) To 7                                       'OCULTAR TARJETAS QUE NO SE USEN
            Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
            lbBOARD(0).Visible = False
            For IND = 1 To 32
                Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                cmdNAME(0).Visible = False
                lbNAME(0).Visible = False
            Next
            For IND = 1 To 16
                Dim tbNAME As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                tbNAME(0).Visible = False
            Next
        Next

    End Sub

    Private Sub COMBO_RE_SHOW(VER, GGIO)

        If VER Then
            Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
            lbBOARD(0).Visible = True
            For IND = 1 To 32
                Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                cmdNAME(0).Visible = True
                lbNAME(0).Visible = True
            Next
            For IND = 1 To 16
                Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                tbNAMEs(0).Visible = True
            Next
        Else
            Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
            lbBOARD(0).Visible = False
            For IND = 1 To 32
                Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                cmdNAME(0).Visible = False
                lbNAME(0).Visible = False
            Next
            For IND = 1 To 16
                Dim tbNAME As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                tbNAME(0).Visible = False
            Next
        End If


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdDEFAULT.Click

        Dim CONFIRMA_RESTAURAR

        CONFIRMA_RESTAURAR = MsgBox("Esta acción desconectará la conexión con el IED." & vbNewLine & vbNewLine & "¿Desea continuar?", vbYesNo + vbInformation, "Confirmar acción")
        If CONFIRMA_RESTAURAR = vbYes Then
            If conexion IsNot Nothing Then          'CONTROLAR SI SE HA ESTABLECIDO PREVIAMENTE CONEXION PARA CERRARLA O NO
                conexion.Close()                    'DESCONEXION CON EL CSHARP DONTNET_61850.DLL QUE CONECTA CON LA LIBRERIA C++ 61850.DLL
            End If

            tbN_BOARDS.Clear()                      'RESTABLECEMOS TODOS LOS ELEMENTOS AL APLICAR EL BOTON DE RESET
            TARJ_TOTALES = Nothing
            tbCODCOM.Clear()
            tbRutaExcel.Clear()
            cbPestanas.Items.Clear()
            cbPestanas.Text = ""
            RE_SHOW()
            RE_COLOCAR()
            RE_QUITAR_LB()
            RE_LB_BOARDS()
            RE_CMD_COLOR()
            cmdDESCONECTAR_Click(1, e)
            Me.Text = "SWITCHERA SOFTWARE - INGETEAM - VER_0_2_3"
        End If

    End Sub

    Private Sub cmdDESCONECTAR_Click(sender As Object, e As EventArgs) Handles cmdDESCONECTAR.Click
        RESET_LGOOSE()
        If sender <> 1 Then
            conexion.Close()                    'DESCONEXION CON EL CSHARP DONTNET_61850.DLL QUE CONECTA CON LA LIBRERIA C++ 61850.DLL
        End If
        tbSTATUS.BackColor = Color.Red          'INFORMACION DE DE DESCONEXION tbSTATUS.BackColor = Color.Red
        cmdCONECTAR.Enabled = True              'HABILITAR BOTON
        cmdDESCONECTAR.Enabled = False          'DESHABILIATR BOTON
        tm_POLLING_SD_1.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_2.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_3.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_4.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_5.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_6.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_SD_7.Enabled = False         'DESHABILIATR LECTURA SD Y GOOSES
        tm_POLLING_ED_1.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_2.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_3.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_4.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_5.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_6.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_ED_7.Enabled = False         'DESHABILIATR LECTURA ED
        tm_POLLING_GOOSES.Enabled = False

    End Sub

    Private Sub RE_COLOCAR()

        Dim N_TARJETAS As Integer

        If tbN_BOARDS.Text = "" Then                                        'COMPROBAMOS SI SE HA RELELNADO LA CASILLA DE NUMERO DE TARJETAS QUE QUEREMOS ENSEÑAR
            N_TARJETAS = TARJ_TOTALES
            If N_TARJETAS = 0 Then
                N_TARJETAS = 7
            End If
        Else
            N_TARJETAS = tbN_BOARDS.Text
        End If

        Dim POS_INIT As Integer = 5                                         'VARIABLE CON EL PIXCEL DE INICIO
        Dim SIZE_FRAME As Integer = gbIO.Width / N_TARJETAS - 5             'ESTABLECEMOS EL TAMAÑO QUE DEDICAREMOS A CADA BLOQUE DE TARJETAS
        For GGIO = 1 To N_TARJETAS + 1 - 1                                  'RECORREMOS TODAS LAS TARJETAS DESDE LA PRIMERA HASTA LAS SE HAYA INDICADO EN EL TXT DE NUMERO DE TARJETAS O SINO REDISTRIBUIRIMOS TODAS LAS DISPONIBLES
            Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
            lbBOARD(0).Left = POS_INIT + (SIZE_FRAME * (GGIO - 1))          'ALINEAMOS LOS ELEMENTOS DE TIPO LABEL AL PIXEL CORRESPONDIENTE AL CALCULO ANTERIOR POR EL GGIO EN EL QUE ESTÁ EL BUCLE MENOS 1
            For IND = 1 To 32                                               'RECORREMOS TODAS LOS ELEMENTOS DE TIPO CMD Y LB PARA REDISTRIBUIRLOS
                Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                cmdNAME(0).Left = POS_INIT + (SIZE_FRAME * (GGIO - 1))      'COLOCAMOS EL CMD EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
                lbNAME(0).Left = POS_INIT + 54 + (SIZE_FRAME * (GGIO - 1))  'COLOCAMOS EL LB EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
                If IND < 17 Then                                            'RECORREMOS TODOS LOS ELEMENTOS DE TIPO TB QUE SOLO LLEGAN HASTA 16
                    Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                    tbNAMEs(0).Left = (SIZE_FRAME * GGIO) + POS_INIT - 54   'COLOCAMOS EL TB EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
                End If
            Next
        Next
    End Sub

    Private Sub COMBO_COLOCAR(POS_BOARD, N_TARJETAS, GGIO)

        Dim POS_INIT As Integer = 5                                         'VARIABLE CON EL PIXEL DE INICIO
        Dim SIZE_FRAME As Integer = gbIO.Width / N_TARJETAS - 5             'ESTABLECEMOS EL TAMAÑO QUE DEDICAREMOS A CADA BLOQUE DE TARJETAS
        Dim lbBOARD As Control() = Me.Controls.Find("lbT" & GGIO, True)
        lbBOARD(0).Left = POS_INIT + (SIZE_FRAME * (POS_BOARD - 1))          'ALINEAMOS LOS ELEMENTOS DE TIPO LABEL AL PIXEL CORRESPONDIENTE AL CALCULO ANTERIOR POR EL GGIO EN EL QUE ESTÁ EL BUCLE MENOS 1
        For IND = 1 To 32                                               'RECORREMOS TODAS LOS ELEMENTOS DE TIPO CMD Y LB PARA REDISTRIBUIRLOS
            Dim cmdNAME As Control() = Me.Controls.Find("cmdED" & GGIO & "_" & IND, True)
            Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
            cmdNAME(0).Left = POS_INIT + (SIZE_FRAME * (POS_BOARD - 1))      'COLOCAMOS EL CMD EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
            lbNAME(0).Left = POS_INIT + 54 + (SIZE_FRAME * (POS_BOARD - 1))  'COLOCAMOS EL LB EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
            If IND < 17 Then                                            'RECORREMOS TODOS LOS ELEMENTOS DE TIPO TB QUE SOLO LLEGAN HASTA 16
                Dim tbNAMEs As Control() = Me.Controls.Find("tbSD" & GGIO & "_" & IND, True)
                tbNAMEs(0).Left = (SIZE_FRAME * POS_BOARD) + POS_INIT - 54   'COLOCAMOS EL TB EN SITIO EN FUNCION DE LAS TARJETAS A MOSTRAR 
            End If
        Next
    End Sub


    Private Sub RE_QUITAR_LB()                              'FUNCION QUE VUELVE A PONER LAS LABEL CON EL VALOR ORIGINAL DESPUES DE HABER LEIDO UNA BASE DE DATOS DE EXCEL
        Dim N_TARJETAS As Integer = 7                       'INICIALIZO VARIABLE CON EL VALOR MÁXIMO DE TARJETAS
        For GGIO = 1 To N_TARJETAS + 1 - 1                  'BUCLE PARA RECORRER TODAS LAS TARJETAS
            For IND = 1 To 32                               'BUCLE PARA RECORRER TODAS LAS ETIQUETAS DE TODAS LAS TARJETAS
                Dim lbNAME As Control() = Me.Controls.Find("lbED" & GGIO & "_" & IND, True)
                lbNAME(0).Text = "ED" & GGIO & "_" & IND    'GENERAMOS VARIABLE PARA SELECCIONAR CADA LABEL Y LE DAMOS EL VALOR ORIGINAL
            Next
        Next

    End Sub

    Private Sub LEER_GOOSES()
        Dim val_GOOSE As Boolean
        Dim ref_GOOSE As String
        Try
            For LGOOSE = 1 To 12
                ref_GOOSE = tbIED.Text & "GEN/LGOS" & LGOOSE & ".St.stVal"
                val_GOOSE = conexion.ReadBooleanValue(ref_GOOSE, FunctionalConstraint.ST)
                Dim lbGOOSE As Control() = Me.Controls.Find("lbLGOOSE_" & LGOOSE, True)
                If val_GOOSE = True Then                       'SI LA SALIDA ESTA ACTIVADA GENERO LA CADENA NECESARIA PARA ENVIARSELA A LA FUNCION DE PINTAR TEXTBOX
                    lbGOOSE(0).BackColor = Color.GreenYellow
                    lbGOOSE(0).ForeColor = Color.Black
                Else
                    lbGOOSE(0).BackColor = Color.Red
                    lbGOOSE(0).ForeColor = Color.White
                End If
            Next

        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)
        End Try

    End Sub

    Private Sub RESET_LGOOSE()
        For LGOOSE = 1 To 12
            Dim lbGOOSE As Control() = Me.Controls.Find("lbLGOOSE_" & LGOOSE, True)
            lbGOOSE(0).BackColor = DefaultBackColor
            lbGOOSE(0).ForeColor = DefaultForeColor
        Next
    End Sub

    Private Sub RESET_INPUTS()
        Try                                     'REVISO SI ESTÁ EL CHECKBOX ACTIVO PARA PONER A VALOR 0 TODAS LAS ENTRADAS
            Dim ref850_sp
            Dim val_ed_sp
            For GGIO = 1 To 7
                For DI = 1 To 32
                    If GGIO = 1 And DI = 7 Then
                        Exit For
                    End If
                    ref850_sp = tbIED.Text + "GEN/GGIO" + GGIO.ToString + ".DI" + DI.ToString + "Type.setVal"
                    val_ed_sp = conexion.ReadIntegerValue(ref850_sp, FunctionalConstraint.SP)
                    If val_ed_sp = 1 Then
                        Dim tbname As String = "cmdED" & GGIO.ToString & "_" & DI.ToString
                        Activar_entrada(tbname, Color.LightGreen)
                    End If
                    conexion.WriteValue(ref850_sp, FunctionalConstraint.SP, New MmsValue(0))
                Next
            Next
        Catch ex As Exception
        End Try

    End Sub

    Public Sub LEER_EDs()
        Dim val_ED_ST As String
        Dim val_ED_SP As String
        Dim ref850_ST
        Dim ref850_SP
        Dim N_ED As Integer = 1
        Dim N_BOARD As Integer = 1
        Dim pos_array
        Dim val_array_ED
        Try
            For tarjeta_ED As Integer = 1 To 7                  'RECORRO VARIABLE CON EL TOTAL DE TARJETAS
                For numero_ED As Integer = 1 To 32              'RECORRO VARIABLE CON EL TOTAL DE ENTRADAS POSIBLES
                    If N_BOARD = 1 And N_ED = 7 Then            'CONTROLO EL INTENTO DE LEER UNA DIRECCION QUE NO EXISTE
                        Exit For
                    End If                                      'GENERO REFERENCIA 850 Y REALIZO SU LECTURA

                    'CONSEGUIR POSICION DEL ARRAY DONDE ESTÁ EL VALOR ACTUAL RDEL ESTADO DE LA ENTRADA
                    pos_array = (N_BOARD - 1) * 32 + N_ED
                    val_array_ED = EDS_TOTALES(pos_array)

                    ref850_SP = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".DI" + N_ED.ToString + "Type.setVal"
                    val_ED_SP = conexion.ReadIntegerValue(ref850_SP, FunctionalConstraint.SP)

                    ref850_ST = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".Ind" + N_ED.ToString + ".stVal"
                    val_ED_ST = conexion.ReadBooleanValue(ref850_ST, FunctionalConstraint.ST)

                    If val_ED_ST = True And val_ED_SP = True Then                       'SI LA SALIDA ESTA ACTIVADA GENERO LA CADENA NECESARIA PARA ENVIARSELA A LA FUNCION DE PINTAR TEXTBOX
                        Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                        Activar_entrada(tbname, Color.Red)
                    End If

                    If val_ED_ST = False And val_ED_SP = 0 And val_array_ED = True Then
                        Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                        Activar_entrada(tbname, Color.GreenYellow)
                    End If

                    N_ED = N_ED + 1
                Next
                N_ED = 1                                        'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
                N_BOARD = N_BOARD + 1                           '
            Next

        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)

        End Try


    End Sub


    Public Sub LEER_EDs_NBOARD(N_BOARD)
        Dim val_ED_ST As String
        Dim val_ED_SP As String
        Dim ref850_ST
        Dim ref850_SP
        Dim N_ED As Integer = 1
        Dim pos_array
        Dim val_array_ED
        Dim TIPO_EQUIPO
        If rbEF.Checked = True Then
            TIPO_EQUIPO = 7
        Else
            TIPO_EQUIPO = 6
        End If

        Try
            For numero_ED As Integer = 1 To 32              'RECORRO VARIABLE CON EL TOTAL DE ENTRADAS POSIBLES
                If N_BOARD = 1 And N_ED = TIPO_EQUIPO Then  'CONTROLO EL INTENTO DE LEER UNA DIRECCION QUE NO EXISTE
                    Exit For
                End If                                      'GENERO REFERENCIA 850 Y REALIZO SU LECTURA

                'CONSEGUIR POSICION DEL ARRAY DONDE ESTÁ EL VALOR ACTUAL DEL ESTADO DE LA ENTRADA
                pos_array = (N_BOARD - 1) * 32 + N_ED
                val_array_ED = EDS_TOTALES(pos_array)

                ref850_SP = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".DI" + N_ED.ToString + "Type.setVal"
                val_ED_SP = conexion.ReadIntegerValue(ref850_SP, FunctionalConstraint.SP)

                ref850_ST = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".Ind" + N_ED.ToString + ".stVal"
                val_ED_ST = conexion.ReadBooleanValue(ref850_ST, FunctionalConstraint.ST)

                If val_ED_ST = True And val_ED_SP = True Then                       'SI LA SALIDA ESTA ACTIVADA GENERO LA CADENA NECESARIA PARA ENVIARSELA A LA FUNCION DE PINTAR TEXTBOX
                    Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                    Activar_entrada(tbname, Color.Red)
                End If

                If val_ED_ST = False And val_ED_SP = 0 And val_array_ED = True Then
                    Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                    Activar_entrada(tbname, Color.GreenYellow)
                End If

                N_ED = N_ED + 1
            Next
            N_ED = 1                                        'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
            N_BOARD = N_BOARD + 1                           '

        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)

        End Try


    End Sub

    Private Sub cbPONER0_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents cmdRESET_ED As Button

    Private Sub cmdLEERSD_Click(sender As Object, e As EventArgs)
        LEER_EDs()
    End Sub



    Private Sub cmdApCombo_Click(sender As Object, e As EventArgs) Handles cmdApCombo.Click
        Dim VER As Boolean
        Dim N_BOARD As Integer
        Dim POS_BOARD As Integer

        If cbBOARD1.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD2.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD3.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD4.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD5.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD6.Checked Then N_BOARD = N_BOARD + 1
        If cbBOARD7.Checked Then N_BOARD = N_BOARD + 1

        If N_BOARD = 0 Then
            MsgBox("DEBE SELECCIONAR AL MENOS 1 TARJETA")
            cbBOARD1.Focus()
            Exit Sub
        End If

        If cbBOARD1.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=1)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=1)

        If cbBOARD2.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=2)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=2)
        If cbBOARD3.Checked Then

            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=3)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=3)

        If cbBOARD4.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=4)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=4)

        If cbBOARD5.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=5)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=5)

        If cbBOARD6.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=6)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=6)

        If cbBOARD7.Checked Then
            VER = 1
            POS_BOARD = POS_BOARD + 1
        Else
            VER = 0
        End If
        COMBO_RE_SHOW(VER, GGIO:=7)
        COMBO_COLOCAR(POS_BOARD, N_BOARD, GGIO:=7)

    End Sub

    Private Sub STATUS_TARJETAS()
        Dim ref850_TARJETA
        Dim error_ST_TARJETA
        Dim T
        For T = 1 To 7
            ref850_TARJETA = tbIED.Text & "GEN/LPHD1.GGIO" & T & "Nodet.stVal"
            error_ST_TARJETA = conexion.ReadBooleanValue(ref850_TARJETA, FunctionalConstraint.ST)
            Dim lbNAME As Control() = Me.Controls.Find("lbT" & T, True)
            If error_ST_TARJETA = True Then
                lbNAME(0).BackColor = Color.Red
            Else
                lbNAME(0).BackColor = Color.GreenYellow
            End If
        Next


    End Sub

    Private Sub RE_LB_BOARDS()
        For T = 1 To 7
            Dim lbNAME As Control() = Me.Controls.Find("lbT" & T, True)
            lbNAME(0).BackColor = DefaultBackColor
        Next
    End Sub

    Private Sub tm_POLLING_GOOSES_Tick(sender As Object, e As EventArgs) Handles tm_POLLING_GOOSES.Tick
        LEER_GOOSES()
    End Sub

    Private Sub COMPROBAR_CALIDAD()
        Dim val_ED_Q
        Dim ref850_Q
        Dim N_ED As Integer = 1
        Try
            For N_BOARD = 1 To 7
                For numero_ED As Integer = 1 To 32              'RECORRO VARIABLE CON EL TOTAL DE ENTRADAS POSIBLES
                    ref850_Q = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".Ind" + N_ED.ToString + ".q"
                    val_ED_Q = conexion.ReadQualityValue(ref850_Q, FunctionalConstraint.ST).GetValidity
                    If val_ED_Q <> 0 Then
                        Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                        Activar_entrada(tbname, Color.HotPink)
                    End If

                    N_ED = N_ED + 1
                Next
                N_ED = 1                                            'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
            Next

        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)

        End Try

    End Sub

    Private Sub RE_CMD_COLOR()
        Dim N_ED As Integer = 1
        Dim pos_array
        Dim val_array_ED
        Try
            For N_BOARD = 1 To 7
                For numero_ED As Integer = 1 To 32              'RECORRO VARIABLE CON EL TOTAL DE ENTRADAS POSIBLES
                    If N_BOARD = 1 And N_ED = 7 Then            'CONTROLO EL INTENTO DE LEER UNA DIRECCION QUE NO EXISTE
                        Exit For
                    End If                                      'GENERO REFERENCIA 850 Y REALIZO SU LECTURA

                    'CONSEGUIR POSICION DEL ARRAY DONDE ESTÁ EL VALOR ACTUAL RDEL ESTADO DE LA ENTRADA
                    pos_array = (N_BOARD - 1) * 32 + N_ED
                    val_array_ED = EDS_TOTALES(pos_array)
                    Dim tbname As String = "cmdED" & N_BOARD.ToString & "_" & N_ED.ToString
                    Dim xCtrl() As Control = Controls.Find(tbname, True)  'FUNCION QUE RECIBE EL NOMBRE DEL TBEDX_Y  Y EL COLOR AL QUE DEBE PONERSE DICHO TEXTBOX
                    For Each iControl As Control In xCtrl
                        If iControl.Name = tbname Then
                            Dim xTxt As Button = DirectCast(iControl, Button)
                            xTxt.UseVisualStyleBackColor = True
                        End If
                    Next
                    N_ED = N_ED + 1
                Next
                N_ED = 1                                        'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER                         '
            Next
        Catch err As Exception                                  'CUALQUIER ERROR ES DESPRECIADO (INTENTO DE LEER ALGUN CARACTER ERRONEO?)

        End Try
    End Sub

    Private Async Sub cmdAUTO_TEST_Click(sender As Object, e As EventArgs) Handles cmdAUTO_TEST.Click

        If rbEF.Checked = True Then
            Await Task.Run(Sub()
                               AUTO_TEST()
                           End Sub)
        Else
            MsgBox("Opcion solo disponible para equipos EF")
        End If

    End Sub


    Private Sub AUTO_TEST()
        If tbSTATUS.BackColor <> Color.GreenYellow Then                       'ERROR  CON MENSAJE DE CONEXION NO CONSEGUIDA
            MsgBox("Conexion no establecida con el IED")
            Exit Sub
        End If

        If cmdAUTO_TEST.BackColor = Color.Red Then
            MsgBox("Autotest en curso, espere a que termine o cancele el proceso")
            Exit Sub
        End If

        cmdAUTO_TEST.BackColor = Color.Red
        Dim ref850_TARJETA
        Dim error_ST_TARJETA
        Dim ref850_Q
        Dim val_ED_Q
        Dim ref850_DITYPE
        Dim N_ED As Integer = 1
        Dim numero_ED As Integer = 1

        For N_BOARD = 1 To 7
            'Dim cbNAME As Control() = Me.Controls.Find("cbBOARD" & N_BOARD, True)
            Dim cbNAME() As CheckBox = {cbBOARD1, cbBOARD2, cbBOARD3, cbBOARD4, cbBOARD5, cbBOARD6, cbBOARD7}
            ref850_TARJETA = tbIED.Text & "GEN/LPHD1.GGIO" & N_BOARD & "Nodet.stVal"
            error_ST_TARJETA = conexion.ReadBooleanValue(ref850_TARJETA, FunctionalConstraint.ST)
            If error_ST_TARJETA = False And cbNAME(N_BOARD - 1).Checked = True Then
                For numero_ED = 1 To 32              'RECORRO VARIABLE CON EL TOTAL DE ENTRADAS POSIBLES
                    If tbSTATUS.BackColor = Color.GreenYellow Then
                        If N_BOARD = 1 And N_ED = 7 Then
                            Exit For
                        End If
                        ref850_Q = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".Ind" + N_ED.ToString + ".q"
                        val_ED_Q = conexion.ReadQualityValue(ref850_Q, FunctionalConstraint.ST).GetValidity
                        If val_ED_Q = 0 Then
                            ref850_DITYPE = tbIED.Text + "GEN/GGIO" + N_BOARD.ToString + ".DI" + N_ED.ToString + "Type.setVal"  'GENERAR REFERENCIA 850 PARA CAMBIAR EL DATO
                            conexion.WriteValue(ref850_DITYPE, FunctionalConstraint.SP, New MmsValue(1))                        'ESCRITURA DE UNA REFERENCIA SP POR MMS
                            Dim cmdNAME As String = "cmdED" & N_BOARD.ToString & "_" & numero_ED.ToString
                            Activar_entrada(cmdNAME, Color.Red)
                            System.Threading.Thread.Sleep(5000)
                            conexion.WriteValue(ref850_DITYPE, FunctionalConstraint.SP, New MmsValue(0))
                            Activar_entrada(cmdNAME, Color.GreenYellow)
                            System.Threading.Thread.Sleep(5000)
                        End If
                        N_ED = N_ED + 1
                    Else
                        Exit Sub
                    End If
                Next
                N_ED = 1                                            'USO VARIABLES AUXILARES PARA AUMENTAR LOS VALORES DE LOS TXT A LEER
            Else
                numero_ED = 32
            End If
        Next
        cmdAUTO_TEST.BackColor = DefaultBackColor
        cmdAUTO_TEST.UseVisualStyleBackColor = True
    End Sub


    Private Sub cmdSALIR_Click(sender As Object, e As EventArgs) Handles cmdSALIR.Click
        Me.Close()
    End Sub

    Private Sub cmdCANCELAR_AUTO_Click(sender As Object, e As EventArgs) Handles cmdCANCELAR_AUTO.Click
        cmdAUTO_TEST.BackColor = DefaultBackColor
        cmdAUTO_TEST.UseVisualStyleBackColor = True
        cmdDESCONECTAR_Click(1, e)
    End Sub

    Private Sub rbEF_CheckedChanged(sender As Object, e As EventArgs) Handles rbEF.CheckedChanged
        cbBOARD4.Checked = True
        cbBOARD5.Checked = True
        cbBOARD6.Checked = True
        cbBOARD7.Checked = True
        cbBOARD4.Enabled = True
        cbBOARD5.Enabled = True
        cbBOARD6.Enabled = True
        cbBOARD7.Enabled = True
        If CICLO <> 0 Then
            cmdApCombo_Click(sender, e)
        Else
            CICLO = 1
        End If

    End Sub

    Private Sub rbDAPT_CheckedChanged(sender As Object, e As EventArgs) Handles rbDAPT.CheckedChanged
        cbBOARD4.Checked = False
        cbBOARD5.Checked = False
        cbBOARD6.Checked = False
        cbBOARD7.Checked = False
        cbBOARD4.Enabled = False
        cbBOARD5.Enabled = False
        cbBOARD6.Enabled = False
        cbBOARD7.Enabled = False
        cmdApCombo_Click(sender, e)

    End Sub

    Private Sub rbDAPTC_CheckedChanged(sender As Object, e As EventArgs) Handles rbDAPTC.CheckedChanged
        cbBOARD4.Checked = True
        cbBOARD5.Checked = True
        cbBOARD6.Checked = False
        cbBOARD7.Checked = False
        cbBOARD4.Enabled = True
        cbBOARD5.Enabled = True
        cbBOARD6.Enabled = False
        cbBOARD7.Enabled = False
        cmdApCombo_Click(sender, e)
    End Sub

End Class