using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummitCommunity
{
    using System.Threading;
    using Ninject;
    using SummitCommunity.Data;
    using SummitCommunity.Data.Contracts;

    public partial class _Default : Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.DropDownList1.DataSource = this.Data.Categories.All().Select(c => c.Name).ToList();
            this.DropDownList1.DataBind();
        }
    }
}