using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

namespace HelpmeHunter.Utilitarios.Middlewares
{
    public class Culture : OwinMiddleware
    {
        const string LANGUAGE = "LANGUAGE";

        public Culture(OwinMiddleware next) : base(next)
        {
        }

        public override Task Invoke(IOwinContext context)
        {
            var culture = context.Request.Query[LANGUAGE];
            var cookie = context.Request.Cookies[LANGUAGE];
            if (cookie != null)
            {
                cookie = culture;
            }
            else
            {
                context.Response.Cookies.Append(LANGUAGE, culture, new CookieOptions
                {
                    Expires = DateTime.UtcNow.AddYears(1)
                });
            }

            var url = context.Request.Uri.AbsoluteUri;
            context.Response.Redirect(url);

            return Next.Invoke(context);
        }
    }

    public static class CultureExtensions
    {
        public static void UseCulture(this IAppBuilder appBuilder)
        {
            appBuilder.Map("/culture", (app) =>
            {
                app.Use<Culture>();
            });
        }
    }
}
