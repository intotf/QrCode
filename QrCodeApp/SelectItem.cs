using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeApp
{
    /// <summary>
    /// 下拉选择对象
    /// </summary>
    public class SelectItem
    {
        /// <summary>
        /// 值
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public bool Selecter { get; set; }
    }
}
