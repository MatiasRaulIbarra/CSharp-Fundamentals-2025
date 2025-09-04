namespace CSharpFundamentals.Core.Models.Animals
{
    public class Animal
    {
        /// <summary>
        /// Makes a generic sound.
        /// </summary>
        public virtual void Sound()
        {
            Console.WriteLine("The sound of the animal is :");
        }
    }
}
