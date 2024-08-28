using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myCrudC_.Models
{

    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public string Id {get; set;}

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [Column("name")]
        [MaxLength(100, ErrorMessage ="Lo sentimos pero el campo Nombre debe ser maximo de 100 caracteres")]
        public string Name {get; set;}

        [Required(ErrorMessage = "El campo apellido es obligatorio.")]
        [Column("last_name")]
        [MaxLength(100, ErrorMessage ="Lo sentimos pero el campo apellido  debe ser maximo de 100 caracteres")]

        public string LastName {get; set;}

        [Column("birthdate")]
        public DateTime BirthDate {get; set;}

        [Required(ErrorMessage = "El campo puesto del trabajor es obligatorio.")] 
        [Column("job_title")]
        [MaxLength(100, ErrorMessage ="Lo sentimos pero el campo apellido  debe ser maximo de 100 caracteres")]

        public string JobTitle {get; set;}

        [Column("department")]
        public string Department {get; set;}

        [Required(ErrorMessage = "El campo fecha de contratacion es obligatorio.")]
        [Column("hire_date")]
        public DateTime HireDate {get; set;}

        [Required(ErrorMessage = "El campo salario es obligatorio.")]
        [Column("salary")]
        public double Salary {get; set;}

        [Column("address")]
        [MaxLength(255, ErrorMessage ="Lo sentimos pero el campo de direccion deber ser maximo de 255 caracteres")]
        public string Address {get; set;}

        [Column("phone_number")]
        [MaxLength(255, ErrorMessage ="Lo sentimos pero el campo de direccion deber ser maximo de 255 caracteres")]

        public string PhoneNumber {get; set;}

        public Employee(){
            Id = Guid.NewGuid().ToString();
        }
    }
}