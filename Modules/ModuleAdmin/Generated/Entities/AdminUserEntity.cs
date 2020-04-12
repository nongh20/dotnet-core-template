﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCommon.Data.Domain.Entitites;
using CoreCommon.Data.Domain.Enums;
using ModuleAdmin.Generated.Enums;



namespace ModuleAdmin.Generated.Entities
{    
    public class AdminUserEntityModel : IEntityBase
    {
        
        [Key]
        [Column(Order=0)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Pass { get; set; }

        [MaxLength(10)]
        public string Language { get; set; }

        [MaxLength(50)]
        public string AllowIpAddress { get; set; }

        public Status Status { get; set; }

        [MaxLength(50)]
        public string No { get; set; }

        public AdminUserTheme Theme { get; set; }

        public bool IsSuper { get; set; }


        public AdminUserEntity ToEntity()
        {
            return new AdminUserEntity
            {
                Id=Id,
				Name=Name,
				Email=Email,
				Pass=Pass,
				Language=Language,
				AllowIpAddress=AllowIpAddress,
				Status=Status,
				No=No,
				Theme=Theme,
				IsSuper=IsSuper
            };
        }
    }

    [Table("AdminUser", Schema = "dbo")]
    public class AdminUserEntity : AdminUserEntityModel 
    {
        
    }
}