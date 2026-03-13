using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp_domain.Models
{
    public class CoindeskData
    {
        public required Time Time { get; set; }
        public required string Disclaimer { get; set; }
        public required string ChartName { get; set; }
        public required Bpi Bpi { get; set; }
    }

    public class Time
    {
        public required string Updated { get; set; }
        public DateTime UpdatedISO { get; set; }
        public required string Updateduk { get; set; }
    }

    public class Bpi
    {
        public required USD USD { get; set; }
        public required GBP GBP { get; set; }
        public required EUR EUR { get; set; }
    }

    public class USD
    {
        public required string Code { get; set; }
        public required string Symbol { get; set; }
        public required string Rate { get; set; }
        public required string Description { get; set; }
        public float RateFloat { get; set; }
    }

    public class GBP
    {
        public required string Code { get; set; }
        public required string Symbol { get; set; }
        public required string Rate { get; set; }
        public required string Description { get; set; }
        public float RateFloat { get; set; }
    }

    public class EUR
    {
        public required string Code { get; set; }
        public required string Symbol { get; set; }
        public required string Rate { get; set; }
        public required string Description { get; set; }
        public float RateFloat { get; set; }
    }
}