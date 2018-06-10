using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace MyPersonalPage.Models.Blocks
{
    [ContentType(DisplayName = "JumbotronBlock", GUID = "eebca3cf-9eb9-40ab-8e53-b08e41895158", Description = "")]
    public class JumbotronBlock : BlockData
    {

        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

    }
}