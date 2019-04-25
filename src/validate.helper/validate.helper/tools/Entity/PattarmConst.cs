using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validate.helper.tools.Entity
{

    /// <summary>
    /// 正则表达式常量（随机可扩展）
    /// </summary>
    public class PattarmConst
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public const string IsMail = @"^\w+([-+.]\w+)@\w+([-.]\w+).\w+([-.]\w+)*$";
        /// <summary>
        /// 手机号
        /// </summary>
        public const string IsPhone = @"^1[3|4|5|7|8|9][\d]{9}$";
        /// <summary>
        /// url
        /// </summary>
        public const string IsUrl = @"^((https|http|ftp|rtsp|mms){0,1}(:\/\/){0,1})www\.(([A-Za-z0-9-~]+)\.)+([A-Za-z0-9-~\/])+$";
        /// <summary>
        /// 汉字
        /// </summary>
        public const string IsChinese = @"[\u4e00-\u9fa5]";
        /// <summary>
        /// 15 or 18位的身份证号
        /// </summary>
        public const string IsIDCard = @"^\d{15}|\d{18}";
        /// <summary>
        /// 金额
        /// </summary>
        public const string IsPrice = @"^(([1-9][0-9]*)|(([0]\.\d{1,2}|[1-9][0-9]*\.\d{1,2})))$";
    }
}
