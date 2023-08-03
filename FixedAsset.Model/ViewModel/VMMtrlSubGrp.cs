using FixedAsset.Model.Domain.MaterialGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAsset.Model.ViewModel
{
    public class VMMtrlSubGrp
    {
        public TFAMtrlSubGrp TFAMtrlSubGrp { get; set; }
        public IEnumerable<SelectListItem> FAMtrlList { get; set; }

    }
}
