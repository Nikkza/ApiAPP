namespace APIApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainTable")]
    public partial class TrainTable
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string AdvertisedLocationName { get; set; }
    }
}
