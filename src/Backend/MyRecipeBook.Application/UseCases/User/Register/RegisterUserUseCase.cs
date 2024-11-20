using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public  ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            Validate(request);
            //validar request
            //mapear a request em uma entidade
            //criptografia senha
            //salvar no banco de dados
            return new ResponseRegisterUserJson { Name = request.name };
        }


        private void Validate(RequestRegisterUserJson request) 
        {
            var validator = new RegisterUserValidator();
            var result= validator.Validate(request);

            if(result.IsValid == false)
            {
                var errorMessages = result.Errors.Select (x => x.ErrorMessage);
                throw new Exception();
            }

            

        }
    }
}
