﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace H.Crawly
{
    public class DemoCrawlyHttpHandler : CrawlyHttpHandler
    {
        public override Content.CrawlyContentProcessor Populate(Content.CrawlyContentProcessor processor)
        {
            processor
                .Populate("title", "DemoCrawlyHttpHandler")
                .Populate("content", () => {
                    return HttpUtility.HtmlEncode(new WebClient().DownloadString("http://www.amairamas.ro"));
                });

            return base.Populate(processor);
        }
    }
}
