using System.Globalization;

namespace Middlewere.Service
{
    public class CultureMiddlewere
    {
        private readonly RequestDelegate _request;
        public CultureMiddlewere(RequestDelegate request)
        {
            _request = request;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var culturequery = context.Request.Query["culture"];
            if(!string.IsNullOrEmpty(culturequery))
            {
                var culture=new CultureInfo(culturequery);
                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }
            var test=CultureInfo.CurrentCulture;

            await _request(context);
        }
    }
}
