namespace Web.Ej1
{
    public class Persona //clase persona con una propiedad Nombre de tipo string
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public string GetSaludo() // metodo que devuelve 
        {
            return $"Hola mi nombre es {Nombre}";
        }
    }
}
