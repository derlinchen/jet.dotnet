using jet.Bean;
using jet.exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace jet.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<ExceptionFilter> _logger;
        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            var jetExp = context.Exception is JetException;
            context.Result = new ObjectResult(new ResponseBean
            {
                Code = "201",
                Message = context.Exception.Message
            });
            //非业务异常记录errorLog,返回500状态码，前端通过捕获500状态码进行友好提示
            if (jetExp == false)
            {
                _logger.LogError(context.Exception, context.Exception.Message);
            }
            base.OnException(context);
        }
    }
}
