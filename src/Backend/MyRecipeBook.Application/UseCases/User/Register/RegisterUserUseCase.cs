using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.UseCases.User.Register;

public class RegisterUserUseCase
{
    public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
    {
        Validate(request);
        
        //mapear a request em uma entidade 
        //criptografia da senha 
        //salvar no banco 
        
        
        return new ResponseRegisterUserJson
        {
            Name =  request.Name,
        };
    }

    private void Validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidator();

         var result = validator.Validate(request);

         if (result.IsValid == false)
         {
             var errorsMessages = result.Errors.Select(e => e.ErrorMessage);
             throw new Exception();
         }
    }
}