using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalPage.Models.ViewModels
{
    public class BSOneDayModel
    {
        public BSBreakFastModel BreakFastModel { get; set; }
        public BSLunchModel LunchModel { get; set; }
        public BSDinnerModel DinnerModel { get; set; }
        public int LongTermDose { get; set; }

    }
}