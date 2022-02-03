using System;

namespace _01_Protection
{
    class Program
    {
        internal struct Engine 
        {
            private string engineBlock; 
            private string cylinderHead; 
            public string valveCover; 
        }
        static void Main(string[] args)
        {
            Engine toyotaEngine = new Engine(); 
            toyotaEngine.valveCover = "plastic"; 
        }
    }
}

// Any members

// Private - Access is limited to the containing type. 
// Public - Access is not restricted.


// Internal - Access limited to current assembly.
// Protected - Access limited to containing class or types derived from the containing class. 


// Protected Internal - Access is limited to the current assembly or types derived from the containing class.
// Private Protected - Access is limited to the containing class or types derived from the containing 
// class within the current assembly.