using Xunit;
using Triangles.Service;

namespace Triangles.test.Service
{
    public class Triangles_triangleRepositoryShould
    {
        private readonly TriangleRepository _triangleRep;
        public Triangles_triangleRepositoryShould()
        {
            _triangleRep = new TriangleRepository();
        }

        [Fact]
        public void Input_1_2_2_ShouldBeLigebenet()
        {
            var result = _triangleRep.triangleType(1, 2, 2);

            Assert.Equal(result, $"Ligebenet");
        }
        [Fact]
        public void Input_2_2_2_ShouldBeLigesidet()
        {
            var result = _triangleRep.triangleType(2, 2, 2);

            Assert.Equal(result, $"Ligesidet");
        }
        [Fact]
        public void Input_3_4_5_ShouldBeRetvinklet()
        {
            var result = _triangleRep.triangleType(3, 4, 5);

            Assert.Equal(result, $"Retvinklet");
        }
        [Fact]
        public void Input_2_3_5_ShouldBeAndet()
        {
            var result = _triangleRep.triangleType(2, 3, 5);

            Assert.Equal(result, $"Andet");
        }

    }
}