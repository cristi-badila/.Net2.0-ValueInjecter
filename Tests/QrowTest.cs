using NUnit.Framework;
using Omu.ValueInjecter;

namespace Tests
{
    public class QrowTest
    {
        public class Boo
        {
            public string Id { get; set; }
            public int Boo1Id { get; set; }
            public Boo Boo1 { get; set; }
        }

        public class FlatBoo
        {
            public int Boo1Id { get; set; }
        }

        [Test]
        public void AnotherUnflatTest()
        {
            var flat = new FlatBoo { Boo1Id = 5 };
            var boo = new Boo();

            boo.InjectFrom<UnflatLoopValueInjection>(flat);

            boo.Boo1Id.IsEqualTo(5);
            boo.Boo1.IsEqualTo(null);
        }
    }
}