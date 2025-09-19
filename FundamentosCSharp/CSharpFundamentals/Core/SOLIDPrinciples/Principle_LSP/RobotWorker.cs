
using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.Principle_LSP
{
    public class RobotWorker :IWorkeable
    {
        // <summary>
        /// This class violates the **Interface Segregation Principle (ISP)** because the Iworker interface
        /// is too broad, forcing a robot to implement methods like Eat() and Sleep() which it does not need.
        ///
        /// It also violates the **Liskov Substitution Principle (LSP)** because a RobotWorker cannot
        /// be safely substituted for a generic Iworker without breaking the program (it would throw an exception
        /// if a method tried to make the robot eat or sleep).
        /// </summary>
       
        
        
        //The Intefaces segregation  Principle consist on  not  using  unnecessary interfaces
        
        /* public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }*/

        public void WorkLSP()
        {
            Console.WriteLine("Robot only is working and applying Liskov Sustitution  Principle.");
        }
    }
}
