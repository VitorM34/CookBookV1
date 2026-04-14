using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Exceptions;

namespace MyRecipeBook.Filters;

public class ExceptionFilter : IExceptionFilter

{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is MyRecipeBookException)
            HandleProjectException(context);
        else
            ThrowUnknowException(context);
        
    }

    private void HandleProjectException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException)
        {
            var exception = context.Exception as ErrorOnValidationException;
            
        }
    }
    
    private void ThrowUnknowException(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Result = new ObjectResult( new ResponseErrorJson(ResourcesMessagesExeption.UNKNOWN_ERROR));
    }
}