using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validate.Entity
{

    /// <summary>
    /// 校验属性自定义扩展
    /// </summary>
    public class RequireExt : ValidationAttribute
    {
        public RequireType RequireType { get; set; }
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            string pattarn = string.Empty;
            switch (RequireType)
            {
                case RequireType.PHONE:
                    pattarn = PattarmConst.IsPhone;
                    break;
                case RequireType.MAIL:
                    pattarn = PattarmConst.IsMail;
                    break;
                case RequireType.URL:
                    pattarn = PattarmConst.IsUrl;
                    break;
                case RequireType.IDCARD:
                    pattarn = PattarmConst.IsIDCard;
                    break;
                case RequireType.PRICE:
                    pattarn = PattarmConst.IsPrice;
                    break;
                default:
                    throw new AccessViolationException("未定义的枚举类型");
            }
            if (!Regex.IsMatch(value.ToString(), pattarn))
            { return false; }
            return true;
        }
    }
    /// <summary>
    /// 校验枚举类型
    /// </summary>
    public enum RequireType
    {
        [Description("手机号")]
        PHONE = 1,
        [Description("邮箱")]
        MAIL = 2,
        [Description("正规URL")]
        URL=3,
        [Description("身份证号")]
        IDCARD=4,
        [Description("金额")]
        PRICE=5
    }
}
