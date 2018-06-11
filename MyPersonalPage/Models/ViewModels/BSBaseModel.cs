using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalPage.Models.ViewModels
{
    public class BSBaseModel
    {
        public DateTime Date { get; set; }
        public double BSLevelBefore { get; set; }
        public double BSLevelAfter { get; set; }
        public int ShortTermDose { get; set; }
    }
}
}