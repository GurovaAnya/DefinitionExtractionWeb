//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefinitionExtractionWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Definition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Definition()
        {
            this.DefinitionLinks = new HashSet<DefinitionLink>();
        }
    
        public int ID { get; set; }
        public int Descriptor_ID { get; set; }
        public string Definition_content { get; set; }
        public int Start_line { get; set; }
        public int Start_char { get; set; }
        public int End_line { get; set; }
        public int End_char { get; set; }
        public int User_ID { get; set; }
        public System.DateTime Insert_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefinitionLink> DefinitionLinks { get; set; }
        public virtual Descriptor Descriptor { get; set; }
        public virtual User User { get; set; }
    }
}
