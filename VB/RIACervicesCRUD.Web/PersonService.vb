Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.EntityFramework
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace RIACervicesCRUD.Web


	' Implements application logic using the PersonsSampleDBEntities context.
	' TODO: Add your application logic to these methods or in additional methods.
	' TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
	' Also consider adding roles to restrict access as appropriate.
	' [RequiresAuthentication]
	<EnableClientAccess()> _
	Public Class PersonService
		Inherits LinqToEntitiesDomainService(Of PersonsSampleDBEntities)

		' TODO:
		' Consider constraining the results of your query method.  If you need additional input you can
		' add parameters to this method or create additional query methods with different names.
		' To support paging you will need to add ordering to the 'Person' query.
		Public Function GetPerson() As IQueryable(Of Person)
			Return Me.ObjectContext.Person
		End Function

		Public Sub InsertPerson(ByVal person As Person)
			If (person.EntityState <> EntityState.Detached) Then
				Me.ObjectContext.ObjectStateManager.ChangeObjectState(person, EntityState.Added)
			Else
				Me.ObjectContext.Person.AddObject(person)
			End If
		End Sub

		Public Sub UpdatePerson(ByVal currentPerson As Person)
			Me.ObjectContext.Person.AttachAsModified(currentPerson, Me.ChangeSet.GetOriginal(currentPerson))
		End Sub

		Public Sub DeletePerson(ByVal person As Person)
			If (person.EntityState = EntityState.Detached) Then
				Me.ObjectContext.Person.Attach(person)
			End If
			Me.ObjectContext.Person.DeleteObject(person)
		End Sub
	End Class
End Namespace


