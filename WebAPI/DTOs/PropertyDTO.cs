using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.DTOs
{
    public class PropertyDTO
    {
        public int SellOrRent { get; set; }
        public string Name { get; set; }
        public int PropertyTypeID { get; set; }
        public int FurnishingTypeID { get; set; }
        public int Price { get; set; }
        public int BHK { get; set; }
        public int BuiltArea { get; set; }
        public int CityID { get; set; }
        public bool ReadyToMove { get; set; }
        public int CarpetArea { get; set; }
        public string Address { get; set; }
        public string? Address2 { get; set; }
        public int FloorNo { get; set; }
        public int TotalFloors { get; set; }
        public string? MainEntrance { get; set; }
        public int Security { get; set; } = 0;
        public bool Gated { get; set; }
        public int Maintenance { get; set; } = 0;
        public DateTime EstPossessionOn { get; set; }
        public int Age { get; set; } = 0;
        public string Description { get; set; }
    }
}