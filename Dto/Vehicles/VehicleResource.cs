using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Dto.Vehicles
{
 
    public class VehicleResource
    {
        public int Id { get; set; }
        public int ModelId { get; set; } 
        public bool IsRegistered { get; set; }
        public ContactResours Contact { get; set; } 
        public ICollection<int> Features { get; set; }

        public VehicleResource() 
        {
            Features = new Collection<int>();
        }
    }
}