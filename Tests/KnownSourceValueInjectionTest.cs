﻿using System;
using System.ComponentModel;
using NUnit.Framework;
using Omu.ValueInjecter;

namespace Tests
{
    [TestFixture]
    public class KnownSourceValueInjectionTest
    {
        public class Foo
        {
            public int Number { get; set; }
        }

        public class Bar
        {
            public int N1 { get; set; }
            public int N2 { get; set; }
            public int N3 { get; set; }
            public int N4 { get; set; }
            public int N5 { get; set; }
        }

        public class PlusOne : KnownSourceValueInjection<Foo>
        {
            protected override void Inject(Foo source, object target)
            {
                var targetProps = target.GetProps();
                var v = source.Number;
                for (var i = 0; i < targetProps.Count; i++)
                {
                    var o = targetProps[i];
                    if (o.PropertyType == typeof(int))
                        o.SetValue(target, v++);
                }
            }
        }

        [Test]
        public void Test()
        {
            var foo = new Foo { Number = 3 };
            var bar = new Bar();

            bar.InjectFrom<PlusOne>(foo);
            bar.N1.IsEqualTo(3);
            bar.N2.IsEqualTo(4);
            bar.N3.IsEqualTo(5);
            bar.N4.IsEqualTo(6);
            bar.N5.IsEqualTo(7);
        }
    }
}