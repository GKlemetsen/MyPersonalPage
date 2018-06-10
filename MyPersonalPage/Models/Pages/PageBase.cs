using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MyPersonalPage.Models.Pages
{
    [ContentType(DisplayName = "PageBase", GUID = "111ddd11-3efd-4ed8-ad7b-546d99d77dcc", Description = "")]
    public class PageBase : PageData
    {
        [Display(
           Name = "Heading",
           Description = "Type in a header here",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
                    Name = "Main body",
                    Description = "Type in the main content of the page here",
                    GroupName = SystemTabNames.Content,
                    Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
                    Name = "Main content",
                    Description = "Main content goes here.",
                    GroupName = SystemTabNames.Content,
                    Order = 30)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}