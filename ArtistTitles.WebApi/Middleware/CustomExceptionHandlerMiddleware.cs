﻿using FluentValidation;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using ArtistTitles.Application.Common.Exceptions;

namespace ArtistTitles.WebApi.Middleware
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExceptionHandlerMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);                
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;

            switch (exception)
            {
                case ValidationException validationException:
                    code = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.Errors);
                    break;

                case OfferNotFound:
                    code = HttpStatusCode.NotFound;
                    break;
                       
                case OfferAlreadyExistException:
                    code = HttpStatusCode.Conflict;
                    break;                
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;    

            if(result == string.Empty)
            {
                result = JsonSerializer.Serialize(new { error = exception.Message });
            }
            return context.Response.WriteAsync(result);
        }
    }
}
