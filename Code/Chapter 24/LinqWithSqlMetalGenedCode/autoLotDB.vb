﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace AutoLotDatabase
	
	Partial Public Class AutoLot
		Inherits System.Data.Linq.DataContext
		
		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertCreditRisks(instance As CreditRisks)
    End Sub
    Partial Private Sub UpdateCreditRisks(instance As CreditRisks)
    End Sub
    Partial Private Sub DeleteCreditRisks(instance As CreditRisks)
    End Sub
    Partial Private Sub InsertCustomers(instance As Customers)
    End Sub
    Partial Private Sub UpdateCustomers(instance As Customers)
    End Sub
    Partial Private Sub DeleteCustomers(instance As Customers)
    End Sub
    Partial Private Sub InsertInventory(instance As Inventory)
    End Sub
    Partial Private Sub UpdateInventory(instance As Inventory)
    End Sub
    Partial Private Sub DeleteInventory(instance As Inventory)
    End Sub
    Partial Private Sub InsertOrders(instance As Orders)
    End Sub
    Partial Private Sub UpdateOrders(instance As Orders)
    End Sub
    Partial Private Sub DeleteOrders(instance As Orders)
    End Sub
    #End Region
		
		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public ReadOnly Property CreditRisks() As System.Data.Linq.Table(Of CreditRisks)
			Get
				Return Me.GetTable(Of CreditRisks)
			End Get
		End Property
		
		Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customers)
			Get
				Return Me.GetTable(Of Customers)
			End Get
		End Property
		
		Public ReadOnly Property Inventory() As System.Data.Linq.Table(Of Inventory)
			Get
				Return Me.GetTable(Of Inventory)
			End Get
		End Property
		
		Public ReadOnly Property Orders() As System.Data.Linq.Table(Of Orders)
			Get
				Return Me.GetTable(Of Orders)
			End Get
		End Property
		
		<FunctionAttribute(Name:="dbo.GetPetName")>  _
		Public Function GetPetName(<Parameter(DbType:="Int")> ByVal carID As System.Nullable(Of Integer), <Parameter(DbType:="Char(10)")> ByRef petName As String) As <Parameter(DbType:="Int")> Integer
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), carID, petName)
			petName = CType(result.GetParameterValue(1),String)
			Return CType(result.ReturnValue,Integer)
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_alterdiagram")>  _
		Public Function Sp_alterdiagram(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer), <Parameter(DbType:="Int")> ByVal version As System.Nullable(Of Integer), <Parameter(DbType:="VarBinary(MAX)")> ByVal definition As System.Data.Linq.Binary) As <Parameter(DbType:="Int")> Integer
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id, version, definition)
			Return CType(result.ReturnValue,Integer)
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_creatediagram")>  _
		Public Function Sp_creatediagram(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer), <Parameter(DbType:="Int")> ByVal version As System.Nullable(Of Integer), <Parameter(DbType:="VarBinary(MAX)")> ByVal definition As System.Data.Linq.Binary) As <Parameter(DbType:="Int")> Integer
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id, version, definition)
			Return CType(result.ReturnValue,Integer)
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_dropdiagram")>  _
		Public Function Sp_dropdiagram(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer)) As <Parameter(DbType:="Int")> Integer
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id)
			Return CType(result.ReturnValue,Integer)
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_helpdiagramdefinition")>  _
		Public Function Sp_helpdiagramdefinition(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer)) As ISingleResult(Of Sp_helpdiagramdefinitionResult)
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id)
			Return CType(result.ReturnValue,ISingleResult(Of Sp_helpdiagramdefinitionResult))
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_helpdiagrams")>  _
		Public Function Sp_helpdiagrams(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer)) As ISingleResult(Of Sp_helpdiagramsResult)
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id)
			Return CType(result.ReturnValue,ISingleResult(Of Sp_helpdiagramsResult))
		End Function
		
		<FunctionAttribute(Name:="dbo.sp_renamediagram")>  _
		Public Function Sp_renamediagram(<Parameter(DbType:="NVarChar(128)")> ByVal diagramname As String, <Parameter(DbType:="Int")> ByVal owner_id As System.Nullable(Of Integer), <Parameter(DbType:="NVarChar(128)")> ByVal new_diagramname As String) As <Parameter(DbType:="Int")> Integer
			Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), diagramname, owner_id, new_diagramname)
			Return CType(result.ReturnValue,Integer)
		End Function
	End Class
	
	<Table(Name:="dbo.CreditRisks")>  _
	Partial Public Class CreditRisks
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _CustID As Integer
		
		Private _FirstName As String
		
		Private _LastName As String
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustIDChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Column(Storage:="_CustID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
		Public Property CustID() As Integer
			Get
				Return Me._CustID
			End Get
			Set
				If ((Me._CustID = value)  _
							= false) Then
					Me.OnCustIDChanging(value)
					Me.SendPropertyChanging
					Me._CustID = value
					Me.SendPropertyChanged("CustID")
					Me.OnCustIDChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_FirstName", DbType:="VarChar(50)")>  _
		Public Property FirstName() As String
			Get
				Return Me._FirstName
			End Get
			Set
				If (String.Equals(Me._FirstName, value) = false) Then
					Me.OnFirstNameChanging(value)
					Me.SendPropertyChanging
					Me._FirstName = value
					Me.SendPropertyChanged("FirstName")
					Me.OnFirstNameChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_LastName", DbType:="VarChar(50)")>  _
		Public Property LastName() As String
			Get
				Return Me._LastName
			End Get
			Set
				If (String.Equals(Me._LastName, value) = false) Then
					Me.OnLastNameChanging(value)
					Me.SendPropertyChanging
					Me._LastName = value
					Me.SendPropertyChanged("LastName")
					Me.OnLastNameChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
	
	<Table(Name:="dbo.Customers")>  _
	Partial Public Class Customers
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _CustID As Integer
		
		Private _FirstName As String
		
		Private _LastName As String
		
		Private _Orders As EntitySet(Of Orders)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustIDChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._Orders = New EntitySet(Of Orders)(AddressOf Me.attach_Orders, AddressOf Me.detach_Orders)
			OnCreated
		End Sub
		
		<Column(Storage:="_CustID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
		Public Property CustID() As Integer
			Get
				Return Me._CustID
			End Get
			Set
				If ((Me._CustID = value)  _
							= false) Then
					Me.OnCustIDChanging(value)
					Me.SendPropertyChanging
					Me._CustID = value
					Me.SendPropertyChanged("CustID")
					Me.OnCustIDChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_FirstName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
		Public Property FirstName() As String
			Get
				Return Me._FirstName
			End Get
			Set
				If (String.Equals(Me._FirstName, value) = false) Then
					Me.OnFirstNameChanging(value)
					Me.SendPropertyChanging
					Me._FirstName = value
					Me.SendPropertyChanged("FirstName")
					Me.OnFirstNameChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_LastName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
		Public Property LastName() As String
			Get
				Return Me._LastName
			End Get
			Set
				If (String.Equals(Me._LastName, value) = false) Then
					Me.OnLastNameChanging(value)
					Me.SendPropertyChanging
					Me._LastName = value
					Me.SendPropertyChanged("LastName")
					Me.OnLastNameChanged
				End If
			End Set
		End Property
		
		<Association(Name:="FK_Orders_Customers", Storage:="_Orders", OtherKey:="CustID", DeleteRule:="NO ACTION")>  _
		Public Property Orders() As EntitySet(Of Orders)
			Get
				Return Me._Orders
			End Get
			Set
				Me._Orders.Assign(value)
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		Private Sub attach_Orders(ByVal entity As Orders)
			Me.SendPropertyChanging
			entity.Customers = Me
		End Sub
		
		Private Sub detach_Orders(ByVal entity As Orders)
			Me.SendPropertyChanging
			entity.Customers = Nothing
		End Sub
	End Class
	
	<Table(Name:="dbo.Inventory")>  _
	Partial Public Class Inventory
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _CarID As Integer
		
		Private _Make As String
		
		Private _Color As String
		
		Private _PetName As String
		
		Private _Orders As EntitySet(Of Orders)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCarIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCarIDChanged()
    End Sub
    Partial Private Sub OnMakeChanging(value As String)
    End Sub
    Partial Private Sub OnMakeChanged()
    End Sub
    Partial Private Sub OnColorChanging(value As String)
    End Sub
    Partial Private Sub OnColorChanged()
    End Sub
    Partial Private Sub OnPetNameChanging(value As String)
    End Sub
    Partial Private Sub OnPetNameChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._Orders = New EntitySet(Of Orders)(AddressOf Me.attach_Orders, AddressOf Me.detach_Orders)
			OnCreated
		End Sub
		
		<Column(Storage:="_CarID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
		Public Property CarID() As Integer
			Get
				Return Me._CarID
			End Get
			Set
				If ((Me._CarID = value)  _
							= false) Then
					Me.OnCarIDChanging(value)
					Me.SendPropertyChanging
					Me._CarID = value
					Me.SendPropertyChanged("CarID")
					Me.OnCarIDChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_Make", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
		Public Property Make() As String
			Get
				Return Me._Make
			End Get
			Set
				If (String.Equals(Me._Make, value) = false) Then
					Me.OnMakeChanging(value)
					Me.SendPropertyChanging
					Me._Make = value
					Me.SendPropertyChanged("Make")
					Me.OnMakeChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_Color", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
		Public Property Color() As String
			Get
				Return Me._Color
			End Get
			Set
				If (String.Equals(Me._Color, value) = false) Then
					Me.OnColorChanging(value)
					Me.SendPropertyChanging
					Me._Color = value
					Me.SendPropertyChanged("Color")
					Me.OnColorChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_PetName", DbType:="VarChar(50)")>  _
		Public Property PetName() As String
			Get
				Return Me._PetName
			End Get
			Set
				If (String.Equals(Me._PetName, value) = false) Then
					Me.OnPetNameChanging(value)
					Me.SendPropertyChanging
					Me._PetName = value
					Me.SendPropertyChanged("PetName")
					Me.OnPetNameChanged
				End If
			End Set
		End Property
		
		<Association(Name:="FK_Orders_Inventory", Storage:="_Orders", OtherKey:="CarID", DeleteRule:="NO ACTION")>  _
		Public Property Orders() As EntitySet(Of Orders)
			Get
				Return Me._Orders
			End Get
			Set
				Me._Orders.Assign(value)
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		Private Sub attach_Orders(ByVal entity As Orders)
			Me.SendPropertyChanging
			entity.Inventory = Me
		End Sub
		
		Private Sub detach_Orders(ByVal entity As Orders)
			Me.SendPropertyChanging
			entity.Inventory = Nothing
		End Sub
	End Class
	
	<Table(Name:="dbo.Orders")>  _
	Partial Public Class Orders
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _OrderID As Integer
		
		Private _CustID As Integer
		
		Private _CarID As Integer
		
		Private _Customers As EntityRef(Of Customers)
		
		Private _Inventory As EntityRef(Of Inventory)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnCustIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustIDChanged()
    End Sub
    Partial Private Sub OnCarIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCarIDChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._Customers = CType(Nothing, EntityRef(Of Customers))
			Me._Inventory = CType(Nothing, EntityRef(Of Inventory))
			OnCreated
		End Sub
		
		<Column(Storage:="_OrderID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set
				If ((Me._OrderID = value)  _
							= false) Then
					Me.OnOrderIDChanging(value)
					Me.SendPropertyChanging
					Me._OrderID = value
					Me.SendPropertyChanged("OrderID")
					Me.OnOrderIDChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_CustID", DbType:="Int NOT NULL")>  _
		Public Property CustID() As Integer
			Get
				Return Me._CustID
			End Get
			Set
				If ((Me._CustID = value)  _
							= false) Then
					If Me._Customers.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
					End If
					Me.OnCustIDChanging(value)
					Me.SendPropertyChanging
					Me._CustID = value
					Me.SendPropertyChanged("CustID")
					Me.OnCustIDChanged
				End If
			End Set
		End Property
		
		<Column(Storage:="_CarID", DbType:="Int NOT NULL")>  _
		Public Property CarID() As Integer
			Get
				Return Me._CarID
			End Get
			Set
				If ((Me._CarID = value)  _
							= false) Then
					If Me._Inventory.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
					End If
					Me.OnCarIDChanging(value)
					Me.SendPropertyChanging
					Me._CarID = value
					Me.SendPropertyChanged("CarID")
					Me.OnCarIDChanged
				End If
			End Set
		End Property
		
		<Association(Name:="FK_Orders_Customers", Storage:="_Customers", ThisKey:="CustID", IsForeignKey:=true)>  _
		Public Property Customers() As Customers
			Get
				Return Me._Customers.Entity
			End Get
			Set
				Dim previousValue As Customers = Me._Customers.Entity
				If ((Object.Equals(previousValue, value) = false)  _
							OrElse (Me._Customers.HasLoadedOrAssignedValue = false)) Then
					Me.SendPropertyChanging
					If ((previousValue Is Nothing)  _
								= false) Then
						Me._Customers.Entity = Nothing
						previousValue.Orders.Remove(Me)
					End If
					Me._Customers.Entity = value
					If ((value Is Nothing)  _
								= false) Then
						value.Orders.Add(Me)
						Me._CustID = value.CustID
					Else
						Me._CustID = CType(Nothing, Integer)
					End If
					Me.SendPropertyChanged("Customers")
				End If
			End Set
		End Property
		
		<Association(Name:="FK_Orders_Inventory", Storage:="_Inventory", ThisKey:="CarID", IsForeignKey:=true)>  _
		Public Property Inventory() As Inventory
			Get
				Return Me._Inventory.Entity
			End Get
			Set
				Dim previousValue As Inventory = Me._Inventory.Entity
				If ((Object.Equals(previousValue, value) = false)  _
							OrElse (Me._Inventory.HasLoadedOrAssignedValue = false)) Then
					Me.SendPropertyChanging
					If ((previousValue Is Nothing)  _
								= false) Then
						Me._Inventory.Entity = Nothing
						previousValue.Orders.Remove(Me)
					End If
					Me._Inventory.Entity = value
					If ((value Is Nothing)  _
								= false) Then
						value.Orders.Add(Me)
						Me._CarID = value.CarID
					Else
						Me._CarID = CType(Nothing, Integer)
					End If
					Me.SendPropertyChanged("Inventory")
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
	
	Partial Public Class Sp_helpdiagramdefinitionResult
		
		Private _Version As System.Nullable(Of Integer)
		
		Private _Definition As System.Data.Linq.Binary
		
		Public Sub New()
			MyBase.New
		End Sub
		
		<Column(Name:="version", Storage:="_Version", DbType:="Int")>  _
		Public Property Version() As System.Nullable(Of Integer)
			Get
				Return Me._Version
			End Get
			Set
				If (Me._Version.Equals(value) = false) Then
					Me._Version = value
				End If
			End Set
		End Property
		
		<Column(Name:="definition", Storage:="_Definition", DbType:="VarBinary(MAX)", CanBeNull:=true)>  _
		Public Property Definition() As System.Data.Linq.Binary
			Get
				Return Me._Definition
			End Get
			Set
				If (Object.Equals(Me._Definition, value) = false) Then
					Me._Definition = value
				End If
			End Set
		End Property
	End Class
	
	Partial Public Class Sp_helpdiagramsResult
		
		Private _Database As String
		
		Private _Name As String
		
		Private _ID As System.Nullable(Of Integer)
		
		Private _Owner As String
		
		Private _OwnerID As System.Nullable(Of Integer)
		
		Public Sub New()
			MyBase.New
		End Sub
		
		<Column(Storage:="_Database", DbType:="NVarChar(128)")>  _
		Public Property Database() As String
			Get
				Return Me._Database
			End Get
			Set
				If (String.Equals(Me._Database, value) = false) Then
					Me._Database = value
				End If
			End Set
		End Property
		
		<Column(Storage:="_Name", DbType:="NVarChar(128)")>  _
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set
				If (String.Equals(Me._Name, value) = false) Then
					Me._Name = value
				End If
			End Set
		End Property
		
		<Column(Storage:="_ID", DbType:="Int")>  _
		Public Property ID() As System.Nullable(Of Integer)
			Get
				Return Me._ID
			End Get
			Set
				If (Me._ID.Equals(value) = false) Then
					Me._ID = value
				End If
			End Set
		End Property
		
		<Column(Storage:="_Owner", DbType:="NVarChar(128)")>  _
		Public Property Owner() As String
			Get
				Return Me._Owner
			End Get
			Set
				If (String.Equals(Me._Owner, value) = false) Then
					Me._Owner = value
				End If
			End Set
		End Property
		
		<Column(Storage:="_OwnerID", DbType:="Int")>  _
		Public Property OwnerID() As System.Nullable(Of Integer)
			Get
				Return Me._OwnerID
			End Get
			Set
				If (Me._OwnerID.Equals(value) = false) Then
					Me._OwnerID = value
				End If
			End Set
		End Property
	End Class
End Namespace