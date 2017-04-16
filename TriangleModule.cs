namespace Hellomicroservices
{
    using Nancy;

    public class TriangleModule : NancyModule
    {
        public TriangleModule() 
        {
            Get("/triangle/{a}/{b}/{c}", parameters => {
              var _a = (int) parameters.a;
              var _b = (int) parameters.b;
              var _c = (int) parameters.c;

              return  (_a == _b && _b == _c)? "Ligesidet": (_a == _b || _a == _c || _b == _c)? "Ligebenet" : " Andet";
            });
        }
    }
}
