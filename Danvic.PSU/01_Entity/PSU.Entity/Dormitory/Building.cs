﻿//-----------------------------------------------------------------------
// <copyright file= "Building.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018-02-19 20:40:46
// Modified by:
// Description: 寝室楼信息表
//-----------------------------------------------------------------------
using PSU.Utility.System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSU.Entity.Dormitory
{
    public class Building : SysField
    {
        #region Attribute

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public string BuildingOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public long Id { get; set; } = TimeUtility.GetTimespans();

        /// <summary>
        /// 所属校区名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string CampusName { get; set; }

        /// <summary>
        /// 寝室楼名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 总楼层
        /// </summary>
        [Required]
        public int Floor { get; set; }

        /// <summary>
        /// 寝室楼类型
        /// 1:male;2:female;3:remix
        /// </summary>
        [Required]
        public short Type { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        #endregion

        #region Foreign Key

        /// <summary>
        /// 所属校区主键
        /// </summary>
        public string CampusFK { get; set; }

        [ForeignKey("CampusFK")]
        public virtual Campus Campus { get; set; }

        #endregion
    }
}
