﻿//-----------------------------------------------------------------------
// <copyright file= "Bedding.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018-02-19 20:34:02
// Modified by:
// Description: 卧具信息表
//-----------------------------------------------------------------------
using PSU.Utility.System;
using System;
using System.ComponentModel.DataAnnotations;

namespace PSU.Entity.Admission
{
    public class Bedding : SysField
    {
        #region Constructed Function

        public Bedding()
        {
            BeddingOID = Guid.NewGuid();
            Id = TimeUtility.GetTimespans();
            CreatedOn = DateTime.Now;
            //CreatedIp = CommonUtility.GetClientIp();
        }

        #endregion

        #region Attribute

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid BeddingOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 物品名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 物品描述
        /// </summary>
        [MaxLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageSrc { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        #endregion
    }
}
