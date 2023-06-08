namespace Jiang.Models
{
    /// <summary>
    /// 通用返回信息类
    /// </summary>
    public class ApiResultData
    {
        

        public ApiResultData(object? response)
        {
            this.status = 200;
            this.success = true;
            this.msg = "成功";
            this.response = response;
        }
        public ApiResultData()
        {
            this.status =400;
            this.msg = "失败";
        }
        

        public ApiResultData(int status,string msg)
        {
            this.status = 400;
           
            this.msg = msg;
        }

        /// <summary>
        /// 状态码
        /// </summary>
        public int status { get; set; } = 200;
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool success { get; set; } = false;
        /// <summary>
        /// 返回信息
        /// </summary>
        public string msg { get; set; } = "服务器异常";
        /// <summary>
        /// 返回数据集合
        /// </summary>
        public object? response { get; set; }
    }
}