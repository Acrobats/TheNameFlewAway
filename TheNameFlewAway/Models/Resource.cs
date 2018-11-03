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
    /// 资源
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// 资源id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 资源描述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 资源地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 资源类型
        /// </summary>
        public Nullable<int> typeid { get; set; }
        /// <summary>
        /// 资源上传时间
        /// </summary>
        public Nullable<System.DateTime> time { get; set; }

        /// <summary>
        /// 资源全参构造函数
        /// </summary>
        /// <param name="id">资源id</param>
        /// <param name="name">资源名称</param>
        /// <param name="description">资源描述</param>
        /// <param name="address">资源地址</param>
        /// <param name="typeid">资源类型id</param>
        /// <param name="time">资源上传时间</param>
        public Resource(int id, string name, string description, string address, int? typeid, DateTime? time)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.address = address;
            this.typeid = typeid;
            this.time = time;
        }
        /// <summary>
        /// 资源无参构造函数
        /// </summary>
        public Resource()
        {

        }
    }
}