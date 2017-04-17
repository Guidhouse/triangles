namespace Triangles.Service
{
    using Nancy;

    public class TriangleModule : NancyModule
    {
        public TriangleModule() 
        {
            Get("/triangle/{a}/{b}/{c}", parameters => 
            {
                int _a = 0; 
                int _b = 0;
                int _c = 0;

                TriangleRepository rep = new TriangleRepository();

                if(int.TryParse(parameters.a, out _a) && int.TryParse(parameters.b, out _b) && int.TryParse(parameters.c, out _c)) 
                {
                    return rep.triangleType(_a, _b, _c);
                }
                else
                {
                    return "One or more of the parameters are not integers. Please try again";
                }
            });
        }
    }
}
