using System;
using System.Collections.Generic;

namespace Jiang.Models.Entity;

public partial class EnterpriseInfo
{
    /// <summary>
    /// 编号
    /// </summary>
    public Guid EnterpriseInfoId { get; set; }

    /// <summary>
    /// 公司名称
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// 统一信用代码
    /// </summary>
    public string? CompanyCode { get; set; }

    /// <summary>
    /// 省份
    /// </summary>
    public string? Province { get; set; }

    /// <summary>
    /// 城市
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// 区县
    /// </summary>
    public string? Prefecture { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public int Status { get; set; }
}
