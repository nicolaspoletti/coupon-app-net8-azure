using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Requiered]
        public string CouponCode { get; set; }
        [Requiered]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}