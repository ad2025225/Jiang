using Jiang.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiang.Models
{
    /// <summary>
    /// 数据库上下文
    /// Add-Migration 更新或添加描述
    /// update-database
    /// </summary>
    public partial class MyContext : DbContext
    {
        /// <summary>
        /// 数据库构造
        /// </summary>
        /// <param name="options"></param>
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        /// <summary>
        /// 重写
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnterpriseInfo>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<EnterpriseInfo> EnterpriseInfo { get; set; }

    }
}
