﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheNameFlewAway.Models
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// 上传资源记录
    /// </summary>
    public partial class UploadRecordForTeacher
    {
        /// <summary>
        /// 资源id
        /// </summary>
        public int sourceId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// 上传记录全参构造函数
        /// </summary>
        /// <param name="sourceId">资源id</param>
        /// <param name="userId">用户id</param>
        public UploadRecordForTeacher(int sourceId, int userId)
        {
            this.sourceId = sourceId;
            this.userId = userId;
        }
        /// <summary>
        /// 上传记录全参构造函数
        /// </summary>
        public UploadRecordForTeacher()
        {

        }
    }
}
