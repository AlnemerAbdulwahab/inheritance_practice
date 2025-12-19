// a Practicing inheritance in C# by having A as a parent, E and B as childs of A and brothers, C as child of B, and D as a child of E.
// A has x method, B has x method and base.x() call, C has x method without base.x() call.
// E does not have x method, D has x method without base.x() call.
// They all have a cunstroctor that prints their class name when an object is created. and childs call base constructor.
using System;
namespace inheritance {

    public class A {
        public A() {
            Console.WriteLine("A constructor");
        }

        public virtual void x() {
            Console.WriteLine("A's x method");
        }
    }
    public class B : A {
        public B() : base() {
            Console.WriteLine("B constructor");
        }

        public override void x() {
            base.x();
            Console.WriteLine("B's x method");
        }
    }
    public class C : B {
        public C() : base() {
            Console.WriteLine("C constructor");
        }

        public override void x() {
            Console.WriteLine("C's x method");
        }
    }
    public class E : A {
        public E() : base() {
            Console.WriteLine("E constructor");
        }
    }
    public class D : E {
        public D() : base() {
            Console.WriteLine("D constructor");
        }

        public override void x() {
            Console.WriteLine("D's x method");
        }
    }
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Creating A:");
            A a = new A();
            a.x();
            
            Console.WriteLine("Creating B:");
            B b = new B();
            b.x();

            Console.WriteLine("\nCreating C:");
            C c = new C();
            c.x();

            Console.WriteLine("\nCreating E:");
            E e = new E();
            // e.x(); // E does not have x method

            Console.WriteLine("\nCreating D:");
            D d = new D();
            d.x();
        }
    }
}