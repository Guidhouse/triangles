namespace Triangles.Service
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule() 
        {
            Get("/", parameters => {
                var hostName = Context.Request.Url.HostName + ((Context.Request.Url.Port != 80)? ":" + Context.Request.Url.Port : ""); 
              return  $"Try the URL: http://{hostName}/triangle/a/b/c. Where a, b and c are proposed sidelengths of a triangle";
            });
        }
    }
}
