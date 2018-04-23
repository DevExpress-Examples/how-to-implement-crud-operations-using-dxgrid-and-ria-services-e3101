Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace RIACervicesCRUD.Web


	' The MetadataTypeAttribute identifies PersonMetadata as the class
	' that carries additional metadata for the Person class.
	<MetadataTypeAttribute(GetType(Person.PersonMetadata))> _
	Partial Public Class Person

		' This class allows you to attach custom attributes to properties
		' of the Person class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class PersonMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateAge? As Integer
			Public Property Age() As Integer?
				Get
					Return privateAge
				End Get
				Set(ByVal value? As Integer)
					privateAge = value
				End Set
			End Property

			Private privateFirstName As String
			Public Property FirstName() As String
				Get
					Return privateFirstName
				End Get
				Set(ByVal value As String)
					privateFirstName = value
				End Set
			End Property

			Private privateHeight? As Integer
			Public Property Height() As Integer?
				Get
					Return privateHeight
				End Get
				Set(ByVal value? As Integer)
					privateHeight = value
				End Set
			End Property

			Private privateID As Integer
			Public Property ID() As Integer
				Get
					Return privateID
				End Get
				Set(ByVal value As Integer)
					privateID = value
				End Set
			End Property

			Private privateLastName As String
			Public Property LastName() As String
				Get
					Return privateLastName
				End Get
				Set(ByVal value As String)
					privateLastName = value
				End Set
			End Property

			Private privateMarried? As Boolean
			Public Property Married() As Boolean?
				Get
					Return privateMarried
				End Get
				Set(ByVal value? As Boolean)
					privateMarried = value
				End Set
			End Property

			Private privateWeight? As Integer
			Public Property Weight() As Integer?
				Get
					Return privateWeight
				End Get
				Set(ByVal value? As Integer)
					privateWeight = value
				End Set
			End Property
		End Class
	End Class
End Namespace
