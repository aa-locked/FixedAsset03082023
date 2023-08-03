﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixedAsset.Model.Domain.MaterialGroup
{
    public class TFAMtrlSubGrp
    {
        [Key]
        public int FAMtrlSubGrpId { get; set; }
        [ForeignKey("TFAMtrlGrp")]
        public int FAMtrlGrpId { get; set; }        
        
        [Required]
        [StringLength(20, ErrorMessage = "No Of Char Cannot Be More Than 20")]
        [DisplayName("Short Description ")]
        public string SubGrpShortDesc { get; set; }
        [Required]
        [StringLength(200)]
        [DisplayName("Description(200 Char)")]
        public string SubGrpDesc { get; set; }
        public bool ActStatus { get; set; } = true;
        public int AddedBy { get; set; } = 123;
        public DateTime AddedOn { get; set; } = DateTime.Now;

        //Nevigation Property

        public TFAMtrlGrp TFAMtrlGrp { get; set; }


    }
}
