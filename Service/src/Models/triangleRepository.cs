namespace Triangles.Service {
 using System;
public class TriangleRepository {
    public string triangleType(int a, int b, int c) {
        if (a == b && b == c) {
            return "Ligesidet"; 
        }
        if (a == b || a == c || b == c) {
            return "Ligebenet"; 
        }
        if (Math.Pow(a, 2) + Math.Pow(b, 2)  == Math.Pow(c, 2)) {//Only obvious extension I could think of. can be extended to accommodate different combinations of a, b and c.
            return "Retvinklet"; 
        }
        return "Andet";// 
        }
    }
}