using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace MVCCeciliaCastellonFriend.Models
{


    
    public enum TipoAmigo
    {
        Conocido,
        CompaneroEstudio,
        ColegaTrabajo,
        Amigo,
        AmigoInfancia,
        Pariente

        
        
       
    }
    public class CeciliaCastellonFriend
    {

        public int FriendId { get; set; }
        

        [Required]
        [Display(Name = "Nombre Completo")]
        public string  Nombre { get; set; }


        DateTime Birthday { get; set; }



        [Required]
        public TipoAmigo Amigo { get; set; }

        
      
        public string Nickname { get; set; }








    }
}