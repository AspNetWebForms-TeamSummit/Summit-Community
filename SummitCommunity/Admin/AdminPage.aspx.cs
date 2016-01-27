using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ninject;
using SummitCommunity.Data.Contracts;
using System.IO;

using SummitCommunity.Data.Models;

namespace SummitCommunity.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSaveCategory_Click(object sender, EventArgs e)
        {
            string fileName = String.Empty;
            string fileExtension = String.Empty;

            if (FileControl.HasFile)
            {
                fileExtension = Path.GetExtension(FileControl.FileName);
                fileName = Guid.NewGuid().ToString();

                FileControl.SaveAs(Server.MapPath
                   ("/CategoryImages/") + fileName + fileExtension);
            }

            this.Data.Categories.Add(new Category
            {
                Name = this.TextBoxAddCategory.Text,
                FileName = fileName,
                FileExtension = fileExtension
            });

            this.Data.SaveChanges();
        }
    }
}