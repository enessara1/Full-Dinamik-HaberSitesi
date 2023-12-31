//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using DataAccess.Models;
    using System;
    using System.Collections.Generic;
    
    public partial class Album:BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            this.AlbumIMGs = new HashSet<AlbumIMG>();
            this.Reviews = new HashSet<Review>();
            this.Categories = new HashSet<Category>();
        }
    
    
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime PublishDate { get; set; }
        public int Hit { get; set; }
        public string url { get; set; }
        public string Img { get; set; }
        public string MainSliderIMG { get; set; }
        public string SidebarIMG { get; set; }
        public string SliderBottomIMG { get; set; }
        public string BestWeeklyIMG { get; set; }
        public string BestWeeklySmIMG { get; set; }
        public string DetailsIMG { get; set; }
        public string OtherIMG { get; set; }
        public int UserId { get; set; }
        public string ImgDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbumIMG> AlbumIMGs { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }
    }
}
