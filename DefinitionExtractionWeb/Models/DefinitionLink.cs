namespace DefinitionExtractionWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DefinitionLink
    {
        public int ID { get; set; }

        [Display(Name = "��������� ����������")]
        public int Descriptor_ID { get; set; }

        [Display(Name = "����� ���������� �������")]
        public int Start_char { get; set; }

        [Display(Name = "����� ���������")]
        public int Length { get; set; }

        [Display(Name = "�����������-��������")]
        public int Definition_ID { get; set; }

        public virtual Definition Definition { get; set; }

        public virtual Descriptor Descriptor { get; set; }
    }
}
