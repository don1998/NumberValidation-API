namespace WebApplication7.Scripts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            phoneNumInfoes = new HashSet<phoneNumInfo>();
        }

        [Key]
        [StringLength(30)]
        public string username { get; set; }

        [StringLength(30)]
        public string password { get; set; }

        [StringLength(50)]
        public string fullName { get; set; }

        [StringLength(30)]
        public string department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phoneNumInfo> phoneNumInfoes { get; set; }
    }
}
