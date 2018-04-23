
namespace RIACervicesCRUD.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the PersonsSampleDBEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class PersonService : LinqToEntitiesDomainService<PersonsSampleDBEntities> {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Person' query.
        public IQueryable<Person> GetPerson() {
            return this.ObjectContext.Person;
        }

        public void InsertPerson(Person person) {
            if ((person.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(person, EntityState.Added);
            } else {
                this.ObjectContext.Person.AddObject(person);
            }
        }

        public void UpdatePerson(Person currentPerson) {
            this.ObjectContext.Person.AttachAsModified(currentPerson, this.ChangeSet.GetOriginal(currentPerson));
        }

        public void DeletePerson(Person person) {
            if ((person.EntityState == EntityState.Detached)) {
                this.ObjectContext.Person.Attach(person);
            }
            this.ObjectContext.Person.DeleteObject(person);
        }
    }
}


