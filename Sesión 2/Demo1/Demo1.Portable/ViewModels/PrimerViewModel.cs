using Demo1.Portable.Models;

namespace Demo1.Portable.ViewModels
{
    public class PrimerViewModel
    {
        public Persona GetPerson()
        {
            var persona = new Persona()
            {
                Nombre = "Chanchordi",
                Edad = 18
            };
            return persona;
        }
    }
}