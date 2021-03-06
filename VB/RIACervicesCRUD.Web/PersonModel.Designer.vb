﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute()>

Namespace RIACervicesCRUD.Web
	#Region "Contexts"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	Partial Public Class PersonsSampleDBEntities
		Inherits ObjectContext
		#Region "Constructors"

		''' <summary>
		''' Initializes a new PersonsSampleDBEntities object using the connection string found in the 'PersonsSampleDBEntities' section of the application configuration file.
		''' </summary>
		Public Sub New()
			MyBase.New("name=PersonsSampleDBEntities", "PersonsSampleDBEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new PersonsSampleDBEntities object.
		''' </summary>
		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString, "PersonsSampleDBEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new PersonsSampleDBEntities object.
		''' </summary>
		Public Sub New(ByVal connection As EntityConnection)
			MyBase.New(connection, "PersonsSampleDBEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		#End Region

		#Region "Partial Methods"

		Partial Private Sub OnContextCreated()
		End Sub

		#End Region

		#Region "ObjectSet Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Person() As ObjectSet(Of Person)
			Get
				If (_Person Is Nothing) Then
					_Person = MyBase.CreateObjectSet(Of Person)("Person")
				End If
				Return _Person
			End Get
		End Property
		Private _Person As ObjectSet(Of Person)

		#End Region
		#Region "AddTo Methods"

		''' <summary>
		''' Deprecated Method for adding a new object to the Person EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToPerson(ByVal person As Person)
			MyBase.AddObject("Person", person)
		End Sub

		#End Region
	End Class


	#End Region

	#Region "Entities"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="PersonsSampleDBModel", Name:="Person"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Person
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Person object.
		''' </summary>
		''' <param name="id">Initial value of the ID property.</param>
		''' <param name="firstName">Initial value of the FirstName property.</param>
		Public Shared Function CreatePerson(ByVal id As Global.System.Int32, ByVal firstName As Global.System.String) As Person
			Dim person As New Person()
			person.ID = id
			person.FirstName = firstName
			Return person
		End Function

		#End Region
		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ID() As Global.System.Int32
			Get
				Return _ID
			End Get
			Set(ByVal value As System.Int32)
				If _ID <> value Then
					OnIDChanging(value)
					ReportPropertyChanging("ID")
					_ID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("ID")
					OnIDChanged()
				End If
			End Set
		End Property
		Private _ID As Global.System.Int32
		Partial Private Sub OnIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property FirstName() As Global.System.String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As System.String)
				OnFirstNameChanging(value)
				ReportPropertyChanging("FirstName")
				_FirstName = StructuralObject.SetValidValue(value, False)
				ReportPropertyChanged("FirstName")
				OnFirstNameChanged()
			End Set
		End Property
		Private _FirstName As Global.System.String
		Partial Private Sub OnFirstNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnFirstNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property LastName() As Global.System.String
			Get
				Return _LastName
			End Get
			Set(ByVal value As System.String)
				OnLastNameChanging(value)
				ReportPropertyChanging("LastName")
				_LastName = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("LastName")
				OnLastNameChanged()
			End Set
		End Property
		Private _LastName As Global.System.String
		Partial Private Sub OnLastNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnLastNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Age() As Global.System.Int32?
			Get
				Return _Age
			End Get
			Set(ByVal value? As System.Int32)
				OnAgeChanging(value)
				ReportPropertyChanging("Age")
				_Age = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Age")
				OnAgeChanged()
			End Set
		End Property
		Private _Age? As Global.System.Int32
		Partial Private Sub OnAgeChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnAgeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Married() As Global.System.Boolean?
			Get
				Return _Married
			End Get
			Set(ByVal value? As System.Boolean)
				OnMarriedChanging(value)
				ReportPropertyChanging("Married")
				_Married = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Married")
				OnMarriedChanged()
			End Set
		End Property
		Private _Married? As Global.System.Boolean
		Partial Private Sub OnMarriedChanging(ByVal value? As Global.System.Boolean)
		End Sub
		Partial Private Sub OnMarriedChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Weight() As Global.System.Int32?
			Get
				Return _Weight
			End Get
			Set(ByVal value? As System.Int32)
				OnWeightChanging(value)
				ReportPropertyChanging("Weight")
				_Weight = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Weight")
				OnWeightChanged()
			End Set
		End Property
		Private _Weight? As Global.System.Int32
		Partial Private Sub OnWeightChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnWeightChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Height() As Global.System.Int32?
			Get
				Return _Height
			End Get
			Set(ByVal value? As System.Int32)
				OnHeightChanging(value)
				ReportPropertyChanging("Height")
				_Height = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Height")
				OnHeightChanged()
			End Set
		End Property
		Private _Height? As Global.System.Int32
		Partial Private Sub OnHeightChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnHeightChanged()
		End Sub

		#End Region

	End Class

	#End Region

End Namespace
