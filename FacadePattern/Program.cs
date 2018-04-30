using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 
    /// The Facade Pattern provides a unified interface to a set of interfaces in a subsystem.
    /// facade defines a higher-level interface that makes the subsystem easier to use.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) Principle of Least Knowledge - talk only to your immediate friends
    ///     - Don't have a large number of classes coupled together
    ///     - Only invoke methods that belong to:
    ///         - The object itself
    ///         - Objects passed in as a parameter to the method
    ///         - Any objects the method creates or instantiates
    ///         - Any components of the object
    ///     - Don't call methods on objects that were returned from calling other methods
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
