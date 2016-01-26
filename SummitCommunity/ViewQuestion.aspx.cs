using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;

namespace SummitCommunity
{
	public partial class ViewQuestion : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
		{

		}

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Question FormViewQuestionDetails_GetItem([QueryString]int id)
        {
            return this.Data.Questions.GetById(id);
        }
    }
}