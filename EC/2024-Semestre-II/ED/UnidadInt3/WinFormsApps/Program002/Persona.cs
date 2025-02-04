using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApps.Program002
{
    public abstract class Persona
    {
        public string NumeroIdentidad { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido {  get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public DateTime FechaNacimiento {  get; set; } = DateTime.MinValue;
        public int Edad {  get; set; }      
        public bool Estado {  get; set; }
    }
}
