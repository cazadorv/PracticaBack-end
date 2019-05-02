namespace practica_Back_end
{
       public class Cliente
        {
           public long Id {get; set;}
           public string Nombre { get; set;}
           public string Apellido { get; set;}
           public string Direccion { get; set;}
           
           public Cliente(long id, string nombre, string apellido, string direccion)
           {
                   this.Id = id;
                   this.Nombre = nombre;
                   this.Apellido = apellido;
                   this.Direccion = direccion;
           }
        }
}