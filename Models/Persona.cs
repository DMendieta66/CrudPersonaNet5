using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace CrudNetCore5.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre y Apellido es obligatorio")]
        [StringLength(120, ErrorMessage = "El campo de Nombre y Apellido tiene limite de 120 caracteres")]
        public string NombreApellido { get; set; }

        [Required(ErrorMessage =  "El campo de Numero de documento es obligatorio")]
        [StringLength(10, ErrorMessage = "El campo de Numero de Documento tiene limite de 10 caracteres")]
        public string NroDocumento { get; set; }

        [Required(ErrorMessage = "El campo de Correo Electronico es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo de Correo Electronico tiene limite de 20 caracteres")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo de Telefono es obligatorio")]
        [StringLength(15, ErrorMessage = "El campo de Telefono tiene limite de 15 caracteres")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El campo de Fecha de Nacimiento es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }


    }
}
