using WeFramework.Core.Domain.Common;

namespace WeFramework.Core.Domain.Configuration
{
    /// <summary>
    /// ϵͳ������Ϣ
    /// </summary>
    public partial class Setting 
    {
        /// <summary>
        ///������Ϣ��ʶ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ������Ϣֵ
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// ������Ϣ��ע
        /// </summary>
        public string Remark { get; set; }
    }
}
