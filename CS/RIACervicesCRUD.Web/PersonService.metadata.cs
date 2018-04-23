
namespace RIACervicesCRUD.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PersonMetadata as the class
    // that carries additional metadata for the Person class.
    [MetadataTypeAttribute(typeof(Person.PersonMetadata))]
    public partial class Person {

        // This class allows you to attach custom attributes to properties
        // of the Person class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PersonMetadata {

            // Metadata classes are not meant to be instantiated.
            private PersonMetadata() {
            }

            public Nullable<int> Age {
                get;
                set;
            }

            public string FirstName {
                get;
                set;
            }

            public Nullable<int> Height {
                get;
                set;
            }

            public int ID {
                get;
                set;
            }

            public string LastName {
                get;
                set;
            }

            public Nullable<bool> Married {
                get;
                set;
            }

            public Nullable<int> Weight {
                get;
                set;
            }
        }
    }
}
