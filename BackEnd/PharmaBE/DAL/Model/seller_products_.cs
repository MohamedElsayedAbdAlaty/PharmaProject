namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("seller_products$")]
    public partial class seller_products_
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? seller_id { get; set; }

        public long? product_id { get; set; }

        public decimal? price { get; set; }

        public byte? status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public decimal? discount { get; set; }

        public byte? Availability { get; set; }

        public virtual product_ products_ { get; set; }

        public virtual seller_ sellers_ { get; set; }
    }
}
