namespace SummitCommunity.Admin
{
    using System;
    using System.Linq;
    using System.IO;
    using Ninject;
    using SummitCommunity.Data.Contracts;
    using SummitCommunity.Data.Models;

    public partial class AdminPage : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();
        }

        protected void ButtonSaveCategory_Click(object sender, EventArgs e)
        {
            string fileName = null;
            string fileExtension = null;

            if (this.FileControl.HasFile)
            {
                fileExtension = Path.GetExtension(this.FileControl.FileName);
                fileName = Guid.NewGuid().ToString();
                this.FileControl.SaveAs(this.Server.MapPath('/' + Constants.CategoryImagesFolder + '/' + fileName + fileExtension));
            }

            this.Data.Categories.Add(new Category
            {
                Name = this.TextBoxAddCategory.Text,
                FileName = fileName,
                FileExtension = fileExtension
            });

            this.Data.SaveChanges();
        }

        public IQueryable<Category> CategoriesListView_GetData()
        {
            return this.Data.Categories.All().OrderBy(c => c.Name);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void CategoriesListView_UpdateItem(int? id)
        {
            var category = this.Data.Categories.GetById(id);
            if (category == null)
            {
                this.ModelState.AddModelError(string.Empty, $"A category with ID {id} could not be found.");
                return;
            }

            this.TryUpdateModel(category);
            if (this.ModelState.IsValid)
            {
                this.Data.SaveChanges();
            }
        }

        public void CategoriesListView_DeleteItem(int? id)
        {
            var category = this.Data.Categories.GetById(id);
            if (category == null)
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(category.FileName))
            {
                File.Delete(this.Server.MapPath('/' + Constants.CategoryImagesFolder + '/' + category.FileName + category.FileExtension));
            }

            this.Data.Categories.Delete(category);
            this.Data.SaveChanges();
        }
    }
}