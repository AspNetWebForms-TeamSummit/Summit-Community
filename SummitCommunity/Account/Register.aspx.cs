namespace SummitCommunity.Account
{
    using System;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using SummitCommunity.Data.Models;
    using SummitCommunity.Helpers;

    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = this.Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = this.Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new User()
            {
                UserName = this.UserName.Text,
                FirstName = this.FirstName.Text,
                LastName = this.LastName.Text,
                Email = this.Email.Text
            };

            IdentityResult result;
            try
            {
                result = manager.Create(user, this.Password.Text);
            }
            catch (DbEntityValidationException ex)
            {
                this.ErrorMessage.Text = string.Empty;
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        this.ErrorMessage.Text += validationError.ErrorMessage + " ";
                    }
                }

                return;
            }

            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(this.Request.QueryString["ReturnUrl"], this.Response);
            }
            else 
            {
                this.ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}