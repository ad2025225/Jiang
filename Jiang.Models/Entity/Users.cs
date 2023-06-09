using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jiang.Models.Entity;

public partial class Users
{
    /// <summary>
    /// 编号
    /// </summary>
    [Key]
    public Guid UserId { get; set; }

    /// <summary>
    /// 账号
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// 密码
    /// </summary>
    public string UserPwd { get; set; } = null!;

    /// <summary>
    /// 角色
    /// </summary>
    public string Role { get; set; } = null!;
}
