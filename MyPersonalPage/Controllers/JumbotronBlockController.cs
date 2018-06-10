using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using MyPersonalPage.Models.Blocks;

namespace MyPersonalPage.Controllers
{
    public class JumbotronBlockController : BlockController<JumbotronBlock>
    {
        public override ActionResult Index(JumbotronBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
