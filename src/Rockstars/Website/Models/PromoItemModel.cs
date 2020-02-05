using System;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Website.Models
{
    public class PromoItemModel
    {
        public virtual Guid Id { get; set; }

        public virtual string Title { get; set; }
         
        public virtual Image Image { get; set; }

        public virtual Link Link { get; set; }

        [SitecoreField("Full Width")]
        public virtual bool FullWidth { get; set; }
    }
}