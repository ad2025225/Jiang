using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jiang.Models.Entity;

public partial class User
{

    /// <summary>
    /// 账号
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// 密码
    /// </summary>
    public string UserPwd { get; set; } = null!;
}
