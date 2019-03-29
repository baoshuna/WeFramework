using System.Collections.Generic;
using System.ComponentModel;
using WeFramework.Core.Domain.Common;
using WeFramework.Core.Domain.Security;

namespace WeFramework.Core.Domain.Users
{
    /// <summary>
    /// ϵͳ��ɫ
    /// </summary>
    public partial class Role:BaseEntity
    {
        public Role()
        {
            this.Permissions = new List<Permission>();
        }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        [DefaultValue(true)]
        public bool Active { get; set; }

        /// <summary>
        /// ��ɫӵ�й��ܵ�
        /// </summary>
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
