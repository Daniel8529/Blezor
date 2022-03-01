using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Blezorejemplo.Entidades
{

   public class Productosdetalle{
      
       [Key]
       public int Productosdetalleid{ get; set; }
       [Required(ErrorMessage ="Es obligatorio introducir la descricion")]
    
       public int  Costo { get; set; }
       
       public float Precio{ get; set; }

       public int cantidad {get; set;}
       
       
   

   }
    
}