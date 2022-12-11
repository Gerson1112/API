using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore6.Bl.DTOs;
using NetCore6.Model.Entities;
using NetCore6.Services.Services;

namespace NetCore6.Controllers
{
    public class TurismoController : BaseController<Turismo, TurismoDTO>
    {
        public TurismoController(ITurismoService service) : base(service) { }

    }
}