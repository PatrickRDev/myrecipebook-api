using System.Globalization;


namespace MyRecipeBook.API.Middleware
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures);

            var reqestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

            var cultureinfo = new CultureInfo("en");

            if(string.IsNullOrEmpty(reqestedCulture) == false && supportedLanguages.Any(c => c.Name.Equals(reqestedCulture)))
            {
                cultureinfo = new CultureInfo(reqestedCulture);
            }

            CultureInfo.CurrentCulture = cultureinfo;
            CultureInfo.CurrentUICulture = cultureinfo;

            await _next(context);
        }
    }
}
