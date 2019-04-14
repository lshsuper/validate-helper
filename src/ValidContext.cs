using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validation
{
    /// <summary>
    /// 校验上下文
    /// </summary>
   public class ValidContext
   {
        /// <summary>
        /// 校验当前模型
        /// </summary>
        /// <param name="model">当前的校验模型</param>
        /// <param name="errorMsg">提示信息</param>
        /// <param name="ignores">需要忽略的校验项</param>
        /// <returns></returns>
        public static bool Check(object model, ref string errorMsg, IEnumerable<string> ignores = null)
        {
            ValidationContext context = new ValidationContext(model);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isVail = Validator.TryValidateObject(model, context, results, true);
            if (isVail)
            {
                errorMsg = "验证通过";
                return true;
            }
            //判断是否有需要忽略的
            if (ignores != null)
                results = results.Where(o => !ignores.Contains(o.MemberNames.FirstOrDefault())).ToList();
            if (results.Count > 0)
            {
                errorMsg = results.FirstOrDefault().ErrorMessage;
                return false;
            }
            errorMsg = "验证通过";
            return true;

        }


    }
}
