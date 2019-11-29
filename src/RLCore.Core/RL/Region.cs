using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class Region : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Parent { get; set; }
        [Required]
        public string Pac { get; set; }
        [Required]
        public string Level { get; set; }
        [Required, Column(TypeName = "geometry (multipolygon, 4326)")]
        public MultiPolygon Geom { get; set; }
    }
}
