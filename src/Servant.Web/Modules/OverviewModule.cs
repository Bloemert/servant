using Servant.Business;
using Servant.Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servant.Web.Modules
{
    public class OverviewModule : BaseModule
    {
        public OverviewModule()
            : base("/overview/")
        {
            var host = Nancy.TinyIoc.TinyIoCContainer.Current.Resolve<IHost>();
            var configuration = Nancy.TinyIoc.TinyIoCContainer.Current.Resolve<ServantConfiguration>();

            Get["/"] = parameters =>
                {
                    Model.OriginalServantUrl = configuration.ServantUrl;
                    Model.Settings = configuration;
                    return View["Index", Model];
                };

            Post["/"] = parameters =>
                {
                    return View["Index"];
                };
        }

    }
}