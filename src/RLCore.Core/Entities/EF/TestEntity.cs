using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.Entities.EF
{
    public class TestEntityGeo : Entity
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //[Column(TypeName = "geometry (point)")]
        public Point Location { get; set; }
    }

    public class TestEntityGeo2 : Entity
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Column(TypeName = "geometry (point, 4326)")]
        public Point Location { get; set; }
    }
}
