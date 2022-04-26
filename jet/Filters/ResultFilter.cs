using jet.Bean;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace jet.Filters
{
    public class ResultFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is EmptyResult) {
                context.Result = new ObjectResult(new ResponseBean
                {
                    Code = "200",
                    Message = "操作成功",
                    Data = null
                });
            }
            if (context.Result is ObjectResult result)
            {
                if (result.Value is ResponseBean)
                {
                    return;
                }

                context.Result = new ObjectResult(new ResponseBean
                {
                    Code = "200",
                    Message = "操作成功",
                    Data = result.Value
                });
            }
        }
    }
}
