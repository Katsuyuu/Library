//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.BorrowController = new HashSet<BorrowController>();
        }
    
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public int PublisherID { get; set; }
        public int PublishYear { get; set; }
        public int Quantity { get; set; }
        public int BorrowLimit { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Publishers Publishers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowController> BorrowController { get; set; }
    }
}