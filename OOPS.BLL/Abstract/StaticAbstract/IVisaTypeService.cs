using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IVisaTypeService : IServiceBase
    {
        List<VisaTypeDTO> getAll();
        VisaTypeDTO getVisaType(int Id);
        VisaTypeDTO newVisaType(VisaTypeDTO VisaType);
        VisaTypeDTO updateVisaType(VisaTypeDTO VisaType);
        bool deleteVisaTypeDTO(int VisaTypeId);
    }
}
