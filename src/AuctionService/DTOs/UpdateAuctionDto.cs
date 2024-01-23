using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionService.DTOs
{
    public class UpdateAuctionDto
    {
        [Required]
        public string Make { get; set; }

        
        public string Model { get; set; }

        public int? Year { get; set; }

        public string Color { get; set; }

        public int? Mileage { get; set; }
    }
}
