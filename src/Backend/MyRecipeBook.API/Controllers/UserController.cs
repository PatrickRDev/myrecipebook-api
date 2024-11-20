
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using MyRecipeBook.Application.UseCases.User.Register;

//ponto de entrada pra nossa api
namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        //o producesresponsetype é 
        [ProducesResponseType(typeof(ResponseRegisterUserJson),StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            var useCase = new RegisterUserUseCase();
            var result = useCase.Execute(request);
            return Created(string.Empty,result);
        }
    }
}


