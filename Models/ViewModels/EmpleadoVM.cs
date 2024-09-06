using Microsoft.AspNetCore.Mvc.Rendering;


namespace HG100721_PIV.Models.ViewModels
{
    public class EmpleadoVM
    {
        public Empleado oEmpleado { get; set; }

        public List<SelectListItem> oListaCargo { get; set; }
    }
}
